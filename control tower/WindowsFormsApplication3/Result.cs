using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
    class Result
    {
        int level;
        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        int time;
        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        public Result(int level, int t)
        {
            Level = level;
            Time = t;
        }
    }
}
