namespace ShScheduler.ViewModels
{
    class EmailMessage
    {
        public string From { get; set; }
        public string FromEmail { get; set; }

        public string To { get; set; }
        public string ToEmail { get; set; }

        public string Body { get; set; }
        public string Subject { get; set; }
    }
}
