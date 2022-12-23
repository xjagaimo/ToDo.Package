using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo.Package.Rexiar
{
    public class Pkg1
    {
        public void updateApp(int mili)         //to start timer
        {
            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer_tick);
            timer.Interval = mili;
            timer.Start();
        }

        public void timer_tick(object sender, EventArgs ev)
        {
            
        }

        public bool testTime(DateTime date)     //to know if the given time is possible for pop up notification
        {
            if ((date - DateTime.Now).TotalSeconds <= 0)
            {
                return true;
            }
            return false;
        }

        public DateTime dateConverter(string date)      //to convert type of date & time from string to DateTime
        {
            return DateTime.ParseExact(date, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }
    }

    
}
