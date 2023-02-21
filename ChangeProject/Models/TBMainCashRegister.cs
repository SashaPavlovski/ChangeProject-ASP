using System.ComponentModel.DataAnnotations;

namespace ChangeProject.Models
{
    public class TBMainCashRegister
    {
        [Key]
        public int MainCashRegisterId { get; set; }
        public TBCashRegisterTracking CashRegisterTracking { get; set; }
        public TBCoinsTypes CoinsType { get; set; }
        public int AmountMoney { get; set; }
        public DateTime Date { get; set; }

    }
}
