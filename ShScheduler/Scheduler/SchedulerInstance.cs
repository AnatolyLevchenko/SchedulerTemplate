using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Matchers;

namespace ShScheduler.Scheduler
{
    public class SchedulerInstance
    {
        public StdSchedulerFactory SchedFact { get; private set; }
        public IScheduler Scheduler { get; private set; }

        public SchedulerInstance()
        {
            Init();
        }
        
        private void Init()
        {
            SchedFact = new StdSchedulerFactory((NameValueCollection)ConfigurationManager.GetSection("quartz"));
            Scheduler =  SchedFact.GetScheduler();
            Scheduler.Start();
        }
    }

    static class Extensions
    {
        public static List<IJobDetail> GetJobs(this IScheduler scheduler)
        {
            List<IJobDetail> jobs = new List<IJobDetail>();

            foreach (JobKey jobKey in scheduler.GetJobKeys(GroupMatcher<JobKey>.AnyGroup()))
            {
                jobs.Add(scheduler.GetJobDetail(jobKey));
            }

            return jobs;
        }
    }
    public class Singleton
    {

        public static SchedulerInstance Instance { get; private set; }
    
        private Singleton()
        {

        }

        static Singleton()
        {
            if(Instance == null)
                Instance = new SchedulerInstance();
        }

 
    }
}
