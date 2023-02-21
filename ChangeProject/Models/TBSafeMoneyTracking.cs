using System.ComponentModel.DataAnnotations;

namespace ChangeProject.Models
{
    public class TBSafeMoneyTracking
    {
        [Key]
        public int SafeMoneyTrackingId { get; set; }
        public TBCoinsTypes CoinsType { get; set; }
        public int AmountMoney { get; set; }
        public DateTime Date { get; set; }
    }
}
