using Quartz;

namespace ShScheduler.ViewModels
{
    class JobModel
    {
        public JobModel(JobKey argKey)
        {
            this.Key = argKey.Name;
            this.Group = argKey.Group;
        }

        public string Key { get; set; }
        public string Group { get; set; }
    }
}
