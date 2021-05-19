using System.Collections.ObjectModel;
using System.Linq;

namespace StatisticsAnalysisTool.Models
{
    public class CraftingInformation
    {
        public ObservableCollection<CraftResource> CraftResource { get; set; }

        public double BaseFame { get; set; }

        public double JournalFillFame { get; set; }
        
        public int TotalAmountResources => CraftResource?
            .Where(x => x.UniqueName.Contains("LEATHER") || x.UniqueName.Contains("METALBAR") || x.UniqueName.Contains("PLANKS") || x.UniqueName.Contains("CLOTH"))
            .Sum(x => x?.Count) ?? 0;

        public double CraftingJournalFillRate => (100 / JournalFillFame) * (BaseFame * TotalAmountResources);
    }
}