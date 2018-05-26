using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.Misc
{
    class AngleBetweenHourAndMinute
    {
        public static void Main()
        {
            AngleBetweenHourAndMinuteProcessor processor = new AngleBetweenHourAndMinuteProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class AngleBetweenHourAndMinuteProcessor
    {
        public void Process()
        {
            CalculateAngle(12,30);
            CalculateAngle(6, 20);
            CalculateAngle(3, 30);
            CalculateAngle(12, 00);
            CalculateAngle(11, 59);
        }

        /// <summary>
        /// 12 to 12 360 degree
        /// Minute: 360 / 60 = 6 degree per minute. So the angle (w.r.t 12) is (minute * 6) degree.
        /// Hour: 360 / 12 = 30 degree per hour. Also hour hand moves little bit based on the minutes.
        ///     At the max within an hour it moves 60 units. Hence, 30 / 60 = 0.5 degree per unit.
        ///     So the angle (w.r.t 12) for hour is ((hour * 30) + (minute * 0.5)) degree
        ///     Result= Math.Abs(Hour angle - minute angle)degree.
        ///     Angle on the oother side = (360 - Result)degree.
        /// </summary>
        private void CalculateAngle(int hour, int minute)
        {
            if (hour > 12 || minute > 60)
            {
                Console.WriteLine("Invalid parameter values");
                return;
            }

            hour = hour % 12;
            minute = minute % 60;

            int hourAngle = (int)((hour * (360 / 12)) + (minute * (30d / 60)));
            int minuteAngle = (minute * (360 / 60));

            int resultAngle = Math.Abs(hourAngle - minuteAngle);

            int smallerAngle = Math.Min(resultAngle, 360 - resultAngle);
            
            Console.WriteLine($"Smaller angle of {hour} hr and {minute} min is: {smallerAngle}");
        }
    }
}
