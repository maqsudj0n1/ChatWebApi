namespace ChatWebApi.Models
{
    public class Message
    {
        public Guid MessageId { get; set; }
        public string Username { get; set; }
        public string Body { get; set; }
        public DateTime SendTime { get; set; }
    }
}
