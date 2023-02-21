using System.ComponentModel.DataAnnotations;

namespace ChangeProject.Models
{
    public class TBCustomers:TBUsers
    {
        public string IDNumber { get; set; }

        [Display(Name = "תמונה")]
        public byte[] MyImage { get; set; }
        public IFormFile SetImage
        {
            set
            {
                if (value == null) return;
                MemoryStream stream = new MemoryStream();
                value.CopyTo(stream);
                MyImage = stream.ToArray();
            }
        }
        public DateTime Date { get; set; }
    }
}
