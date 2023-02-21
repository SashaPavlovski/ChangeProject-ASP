namespace ChangeProject.Models
{
    public class TBClosingCashRegister: TBMainCashRegister
    {
        public int ClosingCashRegisterId { get; set; }
        public TBOpeningCashRegister OpeningCashRegister { get; set; }
    }
}
