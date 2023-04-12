using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleInQueue;
            int waitingTimeOnePerson = 10;
            int hour;
            int minute;
            int minuteInHour = 60;

            Console.Write("Сколько человек перед вами в очереди: ");
            peopleInQueue = Convert.ToInt32(Console.ReadLine());
            minute = peopleInQueue * waitingTimeOnePerson;
            hour = minute / minuteInHour;
            minute = minute % minuteInHour;
            Console.WriteLine($"Вам придется подождать в очереди {hour}ч.{minute}минут.");
        }
    }
}
