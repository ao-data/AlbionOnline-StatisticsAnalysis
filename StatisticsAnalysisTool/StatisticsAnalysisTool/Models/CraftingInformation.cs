using System.Collections.ObjectModel;
using System.Linq;

namespace StatisticsAnalysisTool.Models
{
    public class CraftingInformation
    {
        public ObservableCollection<CraftResource> CraftResource { get; set; }

        public int TotalAmountResources => CraftResource?.Sum(x => x?.Count) ?? 0;

        public int CraftingJournalFillRate => 100;
    }
}