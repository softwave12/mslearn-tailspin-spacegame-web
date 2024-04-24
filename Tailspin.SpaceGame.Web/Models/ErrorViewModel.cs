namespace TailSpin.SpaceGame.Web.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
//fdfdfh
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}