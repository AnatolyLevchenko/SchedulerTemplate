namespace ShScheduler.ViewModels
{
    class TriggerInfo
    {
        public string NextFireTimeUTC;
        public bool IsCompleted { get; set; }
        public string TriggerKey { get; set; }
        public string JobName { get; set; }
    }
}
