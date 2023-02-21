using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace ChangeProject.Models
{
    public class TBTransactions
    {
        [Key]
        public int TransactionsId { get; set; }
        public TBUsers User { get; set; } 
        public TBCoinsTypes CurrentMoney { get; set; }
        public SqlMoney AmountCurrentMoney { get; set; }
        public TBCoinsTypes NewMoney { get; set; }
        public SqlMoney AmountNewMoney { get; set; }
        public DateTime Date { get; set; }
    }
}
