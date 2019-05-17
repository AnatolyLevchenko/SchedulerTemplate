using Quartz;

namespace ShScheduler.ViewModels
{
    class TriggerInfo
    {
        public string NextFireTimeUTC;

        public string Action
        {
            get
            {
                if (State.Equals(TriggerState.Normal.ToString()))
                    return "Pause";
                return "Start";
            }
        }

        public string TriggerKey { get; set; }
        public string JobName { get; set; }
        public string State { get; set; }
    }
}
