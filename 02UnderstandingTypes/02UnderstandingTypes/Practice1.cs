using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class Practice1
    {
        public void ShowNumberOfBytes()
        {
            Console.WriteLine("Type    : Size(Bytes)  : MinValue                           : MaxValue");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine($"sbyte   : {sizeof(sbyte)}           : {sbyte.MinValue}                            : {sbyte.MaxValue}");
            Console.WriteLine($"byte    : {sizeof(byte)}            : {byte.MinValue}                             : {byte.MaxValue}");
            Console.WriteLine($"short   : {sizeof(short)}           : {short.MinValue}                            : {short.MaxValue}");
            Console.WriteLine($"ushort  : {sizeof(ushort)}          : {ushort.MinValue}                           : {ushort.MaxValue}");
            Console.WriteLine($"int     : {sizeof(int)}             : {int.MinValue}                              : {int.MaxValue}");
            Console.WriteLine($"uint    : {sizeof(uint)}            : {uint.MinValue}                             : {uint.MaxValue}");
            Console.WriteLine($"long    : {sizeof(long)}            : {long.MinValue}                             : {long.MaxValue}");
            Console.WriteLine($"ulong   : {sizeof(ulong)}           : {ulong.MinValue}                            : {ulong.MaxValue}");
            Console.WriteLine($"float   : {sizeof(float)}           : {float.MinValue}                            : {float.MaxValue}");
            Console.WriteLine($"double  : {sizeof(double)}          : {double.MinValue}                           : {double.MaxValue}");
            Console.WriteLine($"decimal : {sizeof(decimal)}         : {decimal.MinValue}                          : {decimal.MaxValue}");
        }

        public void ConvertCentury()
        {
            Console.WriteLine("Enter the number of centuries:");
            int centuries = int.Parse(Console.ReadLine());

            BigInteger years = 100 * centuries;
            BigInteger days = (BigInteger)(365 * years);
            BigInteger hours = 24 * days;
            BigInteger minutes = 60 * hours;
            BigInteger seconds = 60 * minutes;
            BigInteger milliseconds = 1000 * seconds;
            BigInteger microseconds = 1000 * milliseconds;
            BigInteger nanoseconds = 1000 * microseconds;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = " +
                              $"{minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = " +
                              $"{microseconds} microseconds = {nanoseconds} nanoseconds");
        }

    }
}
