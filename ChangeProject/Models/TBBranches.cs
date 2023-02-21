using System.ComponentModel.DataAnnotations;

namespace ChangeProject.Models
{
    public class TBBranches
    {
        [Key]
        public int BranchesId { get; set; }
        public string BrancheName { get; set; } = string.Empty;
        public string BrancheNumber { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
