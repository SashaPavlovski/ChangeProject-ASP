using System.ComponentModel.DataAnnotations;

namespace ChangeProject.Models
{
    public class TBCashRegisterTracking
    {
        [Key]
        public int CashRegisterTrackingId { get; set; }
        public int UserRandomId { get; set; }
        public TBBranches Branches { get; set; }
        public TBUsers User { get; set; }
        public TBSafeMoneyTracking SafeMoneyTracking { get; set; }
        public string UserPassword { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
