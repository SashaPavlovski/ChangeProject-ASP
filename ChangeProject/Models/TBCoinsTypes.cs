using System.ComponentModel.DataAnnotations;

namespace ChangeProject.Models
{
    public class TBCoinsTypes
    {
        [Key]
        public int CoinsTypesId { get; set; }
        public string CoinType { get; set; }
        public string TaxPercentage { get; set; }
        public DateTime Date { get; set; }
    }
}
