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
            int waitingHour;
            int waitingMinute;
            int minuteInHour = 60;

            Console.Write("Сколько человек перед вами в очереди: ");
            peopleInQueue = Convert.ToInt32(Console.ReadLine());
            waitingMinute = peopleInQueue * waitingTimeOnePerson;
            waitingHour = waitingMinute / minuteInHour;
            waitingMinute = waitingMinute % minuteInHour;
            Console.WriteLine($"Вам придется подождать в очереди {waitingHour}ч.{waitingMinute}минут.");
        }
    }
}
