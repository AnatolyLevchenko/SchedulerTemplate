namespace ShData.Models
{
   public class FeedbackModel
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public string Text { get; set; }
        public string TriggerName { get; set; }

        public string User { get; set; }
    }
}
