using System;

namespace GU1_W06_StopWatch_Class
{
    internal class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;

        public StopWatch()
        {
            this.startTime = DateTime.Now;
        }

        public void Start()
        {
            this.startTime = DateTime.Now;
        }

        public void Stop()
        {
            this.endTime = DateTime.Now;
        }

        public double GetElapsedTime()
        {
            TimeSpan elapsedTime = this.endTime - this.startTime;
            return elapsedTime.TotalMilliseconds;
        }
    }
}
