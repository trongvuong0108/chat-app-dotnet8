namespace ChatApp.Models
{
    public class CallOffer
    {
        public User Caller { get; set; } = new User();
        public User Callee { get; set; } = new User();
    }
}
