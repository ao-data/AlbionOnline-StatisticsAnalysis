using log4net;
using Newtonsoft.Json;
using StatisticsAnalysisTool.Enumerations;
using StatisticsAnalysisTool.Models;
using StatisticsAnalysisTool.Models.ItemJson;
using StatisticsAnalysisTool.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace StatisticsAnalysisTool.Common
{
    public class ItemController
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static ObservableCollection<Item> Items;

        public static MainItemJson MainItemObject = new MainItemJson();

        public static readonly Brush ToggleOnColor = new SolidColorBrush((Color) Application.Current.Resources["Color.Blue.2"]);

        public static readonly Brush ToggleOffColor = new SolidColorBrush((Color) Application.Current.Resources["Color.Text.Normal"]);

        public static Item GetItemByUniqueName(string uniqueName)
        {
            return Items.FirstOrDefault(i => i.UniqueName == uniqueName);
        }

        public static Item GetItemByIndex(int index)
        {
            return Items?.FirstOrDefault(i => i.Index == index);
        }

        public static string LocalizedName(LocalizedNames localizedNames, string currentLanguage = null, string alternativeName = "NO_ITEM_NAME")
        {
            if (localizedNames == null)
                return alternativeName;

            if (string.IsNullOrEmpty(currentLanguage))
                currentLanguage = LanguageController.CurrentCultureInfo.TextInfo.CultureName.ToUpper();

            switch (FrequentlyValues.GameLanguages
                .FirstOrDefault(x => string.Equals(x.Value, currentLanguage, StringComparison.CurrentCultureIgnoreCase)).Key)
            {
                case GameLanguage.UnitedStates:
                    return localizedNames.EnUs ?? alternativeName;

                case GameLanguage.Germany:
                    return localizedNames.DeDe ?? alternativeName;

                case GameLanguage.Russia:
                    return localizedNames.RuRu ?? alternativeName;

                case GameLanguage.Poland:
                    return localizedNames.PlPl ?? alternativeName;

                case GameLanguage.Brazil:
                    return localizedNames.PtBr ?? alternativeName;

                case GameLanguage.France:
                    return localizedNames.FrFr ?? alternativeName;

                case GameLanguage.Spain:
                    return localizedNames.EsEs ?? alternativeName;

                case GameLanguage.Chinese:
                    return localizedNames.ZhCn ?? alternativeName;

                default:
                    return alternativeName;
            }
        }

        public static ItemTier GetTier(string uniqueName)
        {
            var tier = uniqueName.Substring(0, 2);
            return tier switch
            {
                "T1" => ItemTier.T1,
                "T2" => ItemTier.T2,
                "T3" => ItemTier.T3,
                "T4" => ItemTier.T4,
                "T5" => ItemTier.T5,
                "T6" => ItemTier.T6,
                "T7" => ItemTier.T7,
                "T8" => ItemTier.T8,
                _ => ItemTier.Unknown
            };
        }
        
        public static int GetItemLevel(string uniqueName)
        {
            if (uniqueName == null || !uniqueName.Contains("@")) return 0;

            return int.TryParse(uniqueName.Split('@')[1], out var number) ? number : 0;
        }
        
        public static ItemQuality GetQuality(int value)
        {
            return FrequentlyValues.ItemQualities.FirstOrDefault(x => x.Value == value).Key;
        }

        public static Style LocationStyle(Location location)
        {
            switch (location)
            {
                case Location.Caerleon:
                    return Application.Current.FindResource("CaerleonStyle") as Style;

                case Location.Thetford:
                    return Application.Current.FindResource("ThetfordStyle") as Style;

                case Location.Bridgewatch:
                    return Application.Current.FindResource("BridgewatchStyle") as Style;

                case Location.Martlock:
                    return Application.Current.FindResource("MartlockStyle") as Style;

                case Location.Lymhurst:
                    return Application.Current.FindResource("LymhurstStyle") as Style;

                case Location.FortSterling:
                    return Application.Current.FindResource("FortSterlingStyle") as Style;

                case Location.ArthursRest:
                    return Application.Current.FindResource("ArthursRestStyle") as Style;

                case Location.MerlynsRest:
                    return Application.Current.FindResource("MerlynsRestStyle") as Style;

                case Location.MorganasRest:
                    return Application.Current.FindResource("MorganasRestStyle") as Style;

                default:
                    return Application.Current.FindResource("DefaultCityStyle") as Style;
            }
        }

        public static Style GetStyleByTimestamp(DateTime value)
        {
            if (value.Date == DateTime.MinValue.Date)
                return Application.Current.FindResource("ListView.Grid.Label.Date.NoValue") as Style;

            if (value.AddHours(8) < DateTime.Now.ToUniversalTime().AddHours(-1))
                return Application.Current.FindResource("ListView.Grid.Label.Date.ToOldFirst") as Style;

            if (value.AddHours(4) < DateTime.Now.ToUniversalTime().AddHours(-1))
                return Application.Current.FindResource("ListView.Grid.Label.Date.ToOldSecond") as Style;

            if (value.AddHours(2) < DateTime.Now.ToUniversalTime().AddHours(-1))
                return Application.Current.FindResource("ListView.Grid.Label.Date.ToOldThird") as Style;

            return Application.Current.FindResource("ListView.Grid.Label.Date.Normal") as Style;
        }

        public static Style PriceStyle(bool bestSellMinPrice)
        {
            if (bestSellMinPrice) return Application.Current.FindResource("ListView.Grid.StackPanel.Label.BestPrice") as Style;

            return Application.Current.FindResource("ListView.Grid.StackPanel.Label.Price") as Style;
        }

        public static ulong GetMinPrice(List<ulong> list)
        {
            var min = ulong.MaxValue;
            foreach (var value in list)
            {
                if (value == 0)
                    continue;

                if (value < min)
                    min = value;
            }

            return min;
        }

        #region Item list

        public static async Task<bool> LoadItemListFromJsonAsync()
        {
            var url = Settings.Default.ItemListSourceUrl;
            var localFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}{Settings.Default.ItemListFileName}";

            if (!GetItemListSourceUrlIfExist(ref url))
            {
                return false;
            }

            if (File.Exists(localFilePath))
            {
                var fileDateTime = File.GetLastWriteTime(localFilePath);

                if (fileDateTime.AddDays(Settings.Default.UpdateItemListByDays) < DateTime.Now)
                {
                    if (await GetItemListFromWebAsync(url)) Items = GetItemListFromLocal();
                    return Items?.Count > 0;
                }

                Items = GetItemListFromLocal();
                return Items?.Count > 0;
            }

            if (await GetItemListFromWebAsync(url)) Items = GetItemListFromLocal();
            return Items?.Count > 0;
        }

        private static bool GetItemListSourceUrlIfExist(ref string url)
        {
            if (string.IsNullOrEmpty(Settings.Default.ItemListSourceUrl))
            {
                url = Settings.Default.DefaultItemListSourceUrl;
                if (string.IsNullOrEmpty(url))
                {
                    return false;
                }

                Settings.Default.ItemListSourceUrl = Settings.Default.DefaultItemListSourceUrl;
                MessageBox.Show(LanguageController.Translation("DEFAULT_ITEMLIST_HAS_BEEN_LOADED"), LanguageController.Translation("NOTE"));
            }

            return true;
        }

        private static ObservableCollection<Item> GetItemListFromLocal()
        {
            try
            {
                var localItemString = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}{Settings.Default.ItemListFileName}", Encoding.UTF8);
                return ConvertItemJsonObjectToItem(JsonConvert.DeserializeObject<ObservableCollection<ItemJsonObject>>(localItemString));
            }
            catch
            {
                return new ObservableCollection<Item>();
            }
        }

        private static ObservableCollection<Item> ConvertItemJsonObjectToItem(ObservableCollection<ItemJsonObject> itemJsonObjectList)
        {
            var result = itemJsonObjectList.Select(item => new Item
            {
                LocalizationNameVariable = item.LocalizationNameVariable,
                LocalizationDescriptionVariable = item.LocalizationDescriptionVariable,
                LocalizedNames = item.LocalizedNames,
                Index = item.Index,
                UniqueName = item.UniqueName
            }).ToList();

            return new ObservableCollection<Item>(result);
        }

        private static async Task<bool> GetItemListFromWebAsync(string url)
        {
            using var client = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(30)
            };

            try
            {
                using var response = await client.GetAsync(url);
                using var content = response.Content;
                var fileString = await content.ReadAsStringAsync();
                File.WriteAllText($"{AppDomain.CurrentDomain.BaseDirectory}{Settings.Default.ItemListFileName}", fileString, Encoding.UTF8);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void SetFavoriteItemsFromLocalFile()
        {
            var localFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}{Settings.Default.FavoriteItemsFileName}";
            if (File.Exists(localFilePath))
            {
                try
                {
                    var localItemString = File.ReadAllText(localFilePath, Encoding.UTF8);
                    foreach (var uniqueName in JsonConvert.DeserializeObject<List<string>>(localItemString))
                    {
                        var item = Items.FirstOrDefault(i => i.UniqueName == uniqueName);
                        if (item != null)
                        {
                            item.IsFavorite = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    ConsoleManager.WriteLineForError(MethodBase.GetCurrentMethod().DeclaringType, e);
                    Log.Error(MethodBase.GetCurrentMethod().Name, e);
                }
            }
        }

        public static void SaveFavoriteItemsToLocalFile()
        {
            var localFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}{Settings.Default.FavoriteItemsFileName}";
            var favoriteItems = Items.Where(x => x.IsFavorite);
            var toSaveFavoriteItems = favoriteItems.Select(x => x.UniqueName);
            var fileString = JsonConvert.SerializeObject(toSaveFavoriteItems);

            try
            {
                File.WriteAllText(localFilePath, fileString, Encoding.UTF8);
            }
            catch (Exception e)
            {
                ConsoleManager.WriteLineForError(MethodBase.GetCurrentMethod().DeclaringType, e);
                Log.Error(MethodBase.GetCurrentMethod().Name, e);
            }
        }

        #endregion Item list

        #region MainItemInformation
        
        public static void GetMainItemInfo(string uniqueName)
        {
            ////MainItemObject.Items.ShopCategories.ShopCategory.FirstOrDefault()

            //if (MainItemObject.Items.HideoutItem.UniqueName == uniqueName)
            //{
            //    return MainItemObject.Items.HideoutItem;
            //}

            //foreach (var farmableItem in MainItemObject.Items.FarmableItem.Where(farmableItem => farmableItem.UniqueName == uniqueName))
            //{
            //    return farmableItem;
            //}

            //foreach (var simpleItem in MainItemObject.Items.SimpleItem.Where(simpleItem => simpleItem.UniqueName == uniqueName))
            //{
            //    return simpleItem;
            //}

            //foreach (var consumableItem in MainItemObject.Items.ConsumableItem.Where(consumableItem => consumableItem.UniqueName == uniqueName))
            //{
            //    return consumableItem;
            //}

            //foreach (var consumableFromInventoryItem in MainItemObject.Items.ConsumableFromInventoryItem.Where(consumableFromInventoryItem => consumableFromInventoryItem.UniqueName == uniqueName))
            //{
            //    return consumableFromInventoryItem;
            //}

            //foreach (var equipmentItem in MainItemObject.Items.EquipmentItem.Where(equipmentItem => equipmentItem.UniqueName == uniqueName))
            //{
            //    return equipmentItem;
            //}

            //foreach (var weapon in MainItemObject.Items.Weapon.Where(weapon => weapon.UniqueName == uniqueName))
            //{
            //    return weapon;
            //}

            //foreach (var mount in MainItemObject.Items.Mount.Where(mount => mount.UniqueName == uniqueName))
            //{
            //    return mount;
            //}

            //foreach (var furnitureItem in MainItemObject.Items.FurnitureItem.Where(furnitureItem => furnitureItem.UniqueName == uniqueName))
            //{
            //    return furnitureItem;
            //}

            //foreach (var journalItem in MainItemObject.Items.JournalItem.Where(journalItem => journalItem.UniqueName == uniqueName))
            //{
            //    return journalItem;
            //}
        }

        // TODO: Under Construction
        public struct MyStruct
        {
            public string UniqueName { get; set; }
            public string Tier { get; set; }
            public string ShopCategory { get; set; }
            public string ShopSubCategory1 { get; set; }
        }

        public static async Task<bool> LoadMainItemInfoFromJsonAsync()
        {
            var url = Settings.Default.MainItemInfoSourceUrl;
            var localFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}{Settings.Default.MainItemInfoFileName}";

            if (!GetMainItemInfoSourceUrlIfExist(ref url))
            {
                return false;
            }

            if (File.Exists(localFilePath))
            {
                var fileDateTime = File.GetLastWriteTime(localFilePath);

                if (fileDateTime.AddDays(Settings.Default.UpdateItemListByDays) < DateTime.Now)
                {
                    if (await GetMainItemInfoFromWebAsync(url))
                    {
                        MainItemObject = GetMainItemInfoFromLocal();
                    }

                    return MainItemObject?.Items != null;
                }

                MainItemObject = GetMainItemInfoFromLocal();
                return MainItemObject?.Items != null;
            }

            if (await GetMainItemInfoFromWebAsync(url))
            {
                MainItemObject = GetMainItemInfoFromLocal();
            }
            return MainItemObject?.Items != null;
        }

        private static bool GetMainItemInfoSourceUrlIfExist(ref string url)
        {
            if (string.IsNullOrEmpty(Settings.Default.MainItemInfoSourceUrl))
            {
                url = Settings.Default.DefaultMainItemInfoSourceUrl;
                if (string.IsNullOrEmpty(url))
                {
                    return false;
                }

                Settings.Default.MainItemInfoSourceUrl = Settings.Default.DefaultMainItemInfoSourceUrl;
                MessageBox.Show(LanguageController.Translation("DEFAULT_MAIN_ITEM_INFO_HAS_BEEN_LOADED"), LanguageController.Translation("NOTE"));
            }

            return true;
        }

        private static MainItemJson GetMainItemInfoFromLocal()
        {
            try
            {
                var localItemString = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}{Settings.Default.MainItemInfoFileName}", Encoding.UTF8);
                return JsonConvert.DeserializeObject<MainItemJson>(localItemString);
            }
            catch
            {
                return new MainItemJson();
            }
        }

        private static async Task<bool> GetMainItemInfoFromWebAsync(string url)
        {
            using var client = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(30)
            };

            try
            {
                using var response = await client.GetAsync(url);
                using var content = response.Content;
                var fileString = await content.ReadAsStringAsync();

                File.WriteAllText($"{AppDomain.CurrentDomain.BaseDirectory}{Settings.Default.MainItemInfoFileName}", fileString, Encoding.UTF8);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion MainItemInformation
    }
}