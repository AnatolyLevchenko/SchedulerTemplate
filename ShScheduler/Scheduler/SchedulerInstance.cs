using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Matchers;
using ShScheduler.ViewModels;

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

        public static List<TriggerInfo> GetAllTriggers(this IScheduler scheduler)
        {

            

            List<TriggerInfo> tr=new List<TriggerInfo>();

            var allTriggerKeys = scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.AnyGroup());
            foreach (var triggerKey in allTriggerKeys)
            {
                var triggerdetails = scheduler.GetTrigger(triggerKey);
                var Jobdetails = scheduler.GetJobDetail(triggerdetails.JobKey);


                var state= scheduler.GetTriggerState(triggerKey);


                TriggerInfo ti=new TriggerInfo();
                ti.TriggerKey = triggerdetails.Key.Name;
                ti.JobName = triggerdetails.JobKey.Name;
                ti.State = state.ToString();

                var date = triggerdetails.GetNextFireTimeUtc()?.DateTime;
                if (date.HasValue)
                    ti.NextFireTimeUTC = date.Value.ToLocalTime().ToString();



                tr.Add(ti);

               // Console.WriteLine("IsCompleted -" + triggerdetails.IsCompleted + " |  TriggerKey  - " + triggerdetails.Result.Key.Name + " Job key -" + triggerdetails.Result.JobKey.Name);
            }

            return tr;
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
