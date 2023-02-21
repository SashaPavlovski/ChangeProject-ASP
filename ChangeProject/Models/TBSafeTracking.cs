using System.ComponentModel.DataAnnotations;

namespace ChangeProject.Models
{
    public class TBSafeTracking
    {
        [Key]
        public int SafeTrackingId { get; set; }
        public TBBranches Branches { get; set; }
        TBSafeMoneyTracking SafeMoneyTracking { get; set; }
        public string UserPassword { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
