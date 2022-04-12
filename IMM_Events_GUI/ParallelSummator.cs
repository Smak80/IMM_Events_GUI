using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM_Events_GUI
{
    public delegate void NextStepDelegate();

    public delegate void ResultDelegate();

    public class ParallelSummator
    {
        private class Summator
        {
            private int _shift;
            public static long N;
            public static int Inc;
            public static event NextStepDelegate NextStep;
            public static event ResultDelegate ResultReady;
            public static long R { get; set; }
            public static int ResCounter { get; set; }

            public static object locker = new ();

            public Summator(int shift)
            {
                _shift = shift;
            }

            public void Start()
            {
                int iCount = (int)(N / 100);
                int iter = 0;
                long r = 0;
                for (int i = _shift; i <= N; i+=Inc)
                {
                    r += i;
                    iter++;
                    if (iter % iCount == 0)
                        NextStep();
                }

                lock (locker)
                {
                    R += r;
                    ResCounter--;
                    if (ResCounter == 0)
                    {
                        ResultReady();
                    }
                }
            }
        }

        public event NextStepDelegate NextStep
        {
            add => Summator.NextStep += value;
            remove => Summator.NextStep -= value;
        }

        public event ResultDelegate ResultReady
        {
            add => Summator.ResultReady += value;
            remove => Summator.ResultReady -= value;
        }

        public long Result => Summator.R;

        public long N
        {
            get => Summator.N;
            set => Summator.N = value;
        }
        
        public ParallelSummator(long n)
        {
            N = n;
        }

        public void Start(int threadCount = 16)
        {
            Summator.Inc = threadCount;
            Summator.R = 0;
            Summator.ResCounter = threadCount;
            for (int i = 1; i <= threadCount; i++)
            {
                var s = new Summator(i);
                new Thread(s.Start).Start();
            }
        }
    }
}
