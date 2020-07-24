using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace ActivityIssue
{
    public static class Function1
    {
        [FunctionName(nameof(Function1))]
        public static void Run([TimerTrigger("0 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            if (Activity.Current != null)
            {
                Activity.Current.AddTag("Test", "Test");
            }
        }
    }
}
