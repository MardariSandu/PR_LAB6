using System;
using System.Net;
using System.Net.Sockets;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int offset = -12; offset <= 12; offset++)
            {
                DateTime time = NetworkTime.GetNetworkTime().AddHours(offset);
                Console.WriteLine($"Exact time in GMT{NetworkTime.GetOffsetString(offset)}: {time}");
            }

            Console.ReadLine();
        }

    }
}
