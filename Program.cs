using System;
using System.Linq;

namespace MyprojecsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ArrayString = { "a", "b", "c", "d", "е", "f" };
            int[] ArrayInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] ArrayDouble = { 5.1, 5.2, 5.3, 5.4, 5.5, 5.6, 5.7, 5.8, 5.9 };
            Decimal[] ArrayDecimal = { 2.4m, 2.5m, 3.6m, 4.7m, 5.8m, 6.8m, 7.9m };
            float[] ArrayFloat = { 6.6f, 2.8f, 3.1f, 4.45f, 5.18f, 6.2f, 7f, 8f, 9.14f };
            Console.WriteLine($"Удаленный элемент из массива ArrayString: {ArrayHelper.Pop(ref ArrayString)}");
            Console.WriteLine($"Удаленный элемент из массива ArrayInt: {ArrayHelper.Pop(ref ArrayInt)}");
            Console.WriteLine($"Удаленный элемент из массива ArrayDouble: {ArrayHelper.Pop(ref ArrayDouble)}");
            Console.WriteLine($"Удаленный элемент из массива ArrayDecimal: {ArrayHelper.Pop(ref ArrayDecimal)}");
            Console.WriteLine($"Удаленный элемент из массива ArrayFloat: {ArrayHelper.Pop(ref ArrayFloat)}");

            Console.ReadKey();
        }
    }
    static class ArrayHelper
    {
        public static string Pop(ref string[] Arr)
        {
            int IndexRemoteElement = Arr.Length - 1;
            string RemoteElement = Arr[IndexRemoteElement];
            Arr = Arr.Where((item, index) => index != IndexRemoteElement).ToArray();
            return RemoteElement;
        }
        public static int Pop(ref int[] Arr)
        {
            int IndexRemoteElement = Arr.Length - 1;
            int RemoteElement = Arr[IndexRemoteElement];
            Arr = Arr.Where((item, index) => index != IndexRemoteElement).ToArray();
            return RemoteElement;
        }
        public static double Pop(ref double[] Arr)
        {
            int IndexRemoteElement = Arr.Length - 1;
            double RemoteElement = Arr[IndexRemoteElement];
            Arr = Arr.Where((item, index) => index != IndexRemoteElement).ToArray();
            return RemoteElement;
        }
        public static Decimal Pop(ref Decimal[] Arr)
        {
            int IndexRemoteElement = Arr.Length - 1;
            Decimal RemoteElement = Arr[IndexRemoteElement];
            Arr = Arr.Where((item, index) => index != IndexRemoteElement).ToArray();
            return RemoteElement;
        }
        public static float Pop(ref float[] Arr)
        {
            int IndexRemoteElement = Arr.Length - 1;
            float RemoteElement = Arr[IndexRemoteElement];
            Arr = Arr.Where((item, index) => index != IndexRemoteElement).ToArray();
            return RemoteElement;
        }
    }
}
