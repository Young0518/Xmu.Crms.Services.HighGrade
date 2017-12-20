using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xmu.Crms.Shared.Scheduling;
using Xmu.Crms.Shared.Service;

namespace Xmu.Crms.Services.Insomnia
{
    public class TimerService : ITimerService
    {
        [Cron("0 0/40 8-21 ? * *")]
        public void CountPresentationGrade()
        {
            
        }

        [Cron("0 0/30 7-21 ? * *")]
        public void FixedGroupToSeminarGroup()
        {
            
        }
    }
}