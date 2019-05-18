namespace ShData.Models
{
   public class FeedbackModel
    {
        public int Id { get; set; }
        public string Job { get; set; }
        public string Text { get; set; }
        public string Trigger { get; set; }

        public string User { get; set; }
    }
}
