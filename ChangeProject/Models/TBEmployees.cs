namespace ChangeProject.Models
{
    public class TBEmployees : TBUsers
    {
        public DateTime LoginTime { get; set; }
        public DateTime LogoutTime { get; set; }
        public TBBranches Branches { get; set; }
    }
}
