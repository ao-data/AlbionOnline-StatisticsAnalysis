using Newtonsoft.Json;
using StatisticsAnalysisTool.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StatisticsAnalysisTool.Models
{
    public class CraftResource : INotifyPropertyChanged
    {
        private string _uniqueName;
        private int _count;

        [JsonProperty(PropertyName = "uniqueName")]
        public string UniqueName {
            get => _uniqueName;
            set {
                _uniqueName = value;
                OnPropertyChanged();
            }
        }

        [JsonProperty(PropertyName = "count")]
        public int Count {
            get => _count;
            set {
                _count = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}