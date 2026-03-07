using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsPluralSight
{
    internal class Async
    {   
        public static async Task Main(string[] args)
        {
            var result = await DoTaskAsync(5);
            Console.WriteLine(result);
        }

        public static async Task<string> DoTaskAsync(int timeOnTask)
        {
            // Simulera en asynkron operation
            await Task.Delay(timeOnTask*1000); // Simulera en fördröjning på 5 sekunder
            return $"Task was done in {timeOnTask} secons";
        }
    }
}
