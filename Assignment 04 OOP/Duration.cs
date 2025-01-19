using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment_04_OOP
{
    internal class Duration
    {
        private int hours, minutes, seconds;

        public Duration(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        //------------ Constructor -----------
        public Duration(int allSeconds)
        {
            hours = allSeconds/3600;
            allSeconds %= 3600;
            minutes = allSeconds/60;
            allSeconds %= 60;
            seconds = allSeconds;
        }

        //-------------- Methods -------------

        public static int ToSeconds(Duration d)
        {
            return d.hours * 3600 + d.minutes * 60 + d.seconds;
        }

        //--------- Method Overriding --------
        public override string ToString()
        {
            string printed = "";
            if (hours > 0) printed += $"Hours: {hours}, ";
            if (minutes > 0 || hours > 0) printed += $"Minutes: {minutes}, ";
            printed += $"Seconds: {seconds}";
            return printed;
        }
        public override bool Equals(object? obj)
        {
            Duration other = obj as Duration ?? new Duration(0,0,0);
            return (other.hours == hours && other.minutes == minutes && other.seconds == seconds);
        }

        //--------- Operator Overriding ------
        public static Duration operator + (Duration left, Duration right)
        {
            //return new Duration(0)
            //{
            //    hours = left.hours + right.hours + (left.minutes + right.minutes)/60,
            //    minutes = (left.minutes + right.minutes) % 60 + (left.seconds + right.seconds)/60,
            //    seconds = (left.seconds + right.seconds)%60
            //};

            // ************** Another Implementation **************
            return new Duration (ToSeconds(left) + ToSeconds(right));
        }
        public static Duration operator + (Duration left, int right)
        {
            return left + new Duration(right);
        }
        public static Duration operator + (int left, Duration right)
        {
            return new Duration(left) + right;
        }
        public static Duration operator ++(Duration duration)
        {
            return duration + new Duration(60);
        }
        public static Duration operator -(Duration left, Duration right)
        {
            //Duration result = new Duration(0);
            //result.hours = left.hours - right.hours;
            //if (left.minutes > right.minutes) result.minutes = left.minutes - right.minutes;
            //else
            //{
            //    result.hours--;
            //    result.minutes = right.minutes - left.minutes + 60;
            //}
            //if (left.seconds > right.seconds) result.seconds = left.seconds - right.seconds;
            //else
            //{
            //    if (result.minutes > 0)
            //    {
            //        result.minutes--;
            //        result.seconds = right.seconds - left.seconds+60;
            //    }
            //    else
            //    {
            //        result.hours--;
            //        result.minutes = 59;
            //        result.seconds = right.seconds-left.seconds+60;
            //    }
            //}
            //return result;

            //              *** Another better Implementation ***
            //int res = left.hours * 3600 + left.minutes * 60 + left.seconds - (right.hours * 3600 + right.minutes * 60 + right.seconds);
            //return new Duration(res);

            //      ********* Another Better Implementation using ToSeconds() *********
            return new Duration(ToSeconds(left) - ToSeconds(right));
        }
        public static Duration operator --(Duration duration)
        {
            return duration - new Duration(60);
        }
        public static bool operator >(Duration left, Duration right)
        {
            return (ToSeconds(left) > ToSeconds(right));
        }
        public static bool operator <(Duration left, Duration right)
        {
            return (ToSeconds(left) < ToSeconds(right));
        }
        public static bool operator >=(Duration left, Duration right)
        {
            return (ToSeconds(left) >= ToSeconds(right));
        }
        public static bool operator <=(Duration left, Duration right)
        {
            return (ToSeconds(left) <= ToSeconds(right));
        }

        //--------- Casting Overriding ------

        public static explicit operator DateTime (Duration d)
        {
            return new DateTime(1, 1, 1, d.hours%24, d.minutes, d.seconds);
        }
        
    }
}
