using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChangeProject.Models
{
    public class TBUsers
    {
        public TBUsers() { UserRandomId = 0; }
        [Key]
        public int UserId { get; set; }

        [NotMapped]
        public int ranId { get; set; }
        [NotMapped]

        int sum = 0;
        public int UserRandomId
        {
            get
            {
                if(UserId != 0)
                sum = (UserId * 10000) + ranId;
                return sum;
            }
            set
            {
                Random random = new Random();
                ranId = random.Next(1000);

            }
        }
        public string UserFirstName { get; set; } 
        public string UserLastName { get; set; } 
        public string UserPhone { get; set; }
        public string UserEmail { get; set; } 
        public string UserName { get; set; } 
        public string UserPassword { get; set; }
        public DateTime Date { get; set; }

        [NotMapped]
        public string UserFullName
        {
            get
            {
                return $"{UserFirstName} {UserLastName}";
            }
        }
    }
}
