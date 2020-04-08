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
            Decimal[] ArrayDecimal = { 2.1m, 2.2m, 2.3m, 2.4m, 2.5m, 2.6m, 2.7m };
            float[] ArrayFloat = { 6.1f, 6.2f, 6.3f, 6.4f, 6.5f, 5.6f, 6.7f, 6.8f, 6.9f };
            Console.WriteLine($"Удаленный элемент из массива ArrayString: {ArrayHelper.Pop(ref ArrayString)}");
            Console.WriteLine($"Удаленный элемент из массива ArrayInt: {ArrayHelper.Pop(ref ArrayInt)}");
            Console.WriteLine($"Удаленный элемент из массива ArrayDouble: {ArrayHelper.Pop(ref ArrayDouble)}");
            Console.WriteLine($"Удаленный элемент из массива ArrayDecimal: {ArrayHelper.Pop(ref ArrayDecimal)}");
            Console.WriteLine($"Удаленный элемент из массива ArrayFloat: {ArrayHelper.Pop(ref ArrayFloat)}\n\n");

            Console.WriteLine($"Длина массив ArrayString после добавления еще один элемент с конца массива: {ArrayHelper.Push(ref ArrayString, "J")}");
            Console.WriteLine($"Длина массив ArrayInt после добавления еще один элемент с конца массива: {ArrayHelper.Push(ref ArrayInt, 11)}");
            Console.WriteLine($"Длина массив ArrayDouble после добавления еще один элемент с конца массива: {ArrayHelper.Push(ref ArrayDouble, 6.0)}");
            Console.WriteLine($"Длина массив ArrayDecimal после добавления еще один элемент с конца массива: {ArrayHelper.Push(ref ArrayDecimal, 2.8m)}");
            Console.WriteLine($"Длина массив ArrayFloat после добавления еще один элемент с конца массива: {ArrayHelper.Push(ref ArrayFloat, 7.0f)}\n\n");

            Console.WriteLine($"Удаленный элемент из массива ArrayString: {ArrayHelper.Shift(ref ArrayString)}");
            Console.WriteLine($"Удаленный элемент из массива ArrayInt: {ArrayHelper.Shift(ref ArrayInt)}");
            Console.WriteLine($"Удаленный элемент из массива ArrayDouble: {ArrayHelper.Shift(ref ArrayDouble)}");
            Console.WriteLine($"Удаленный элемент из массива ArrayDecimal: {ArrayHelper.Shift(ref ArrayDecimal)}");
            Console.WriteLine($"Удаленный элемент из массива ArrayFloat: {ArrayHelper.Shift(ref ArrayFloat)}\n\n");

            Console.WriteLine($"Длина массив ArrayString после добавления еще один элемент в начало массива: {ArrayHelper.UnShift(ref ArrayString, "Aa")}");
            Console.WriteLine($"Длина массив ArrayInt после добавления еще один элемент начало массива: {ArrayHelper.UnShift(ref ArrayInt, 0)}");
            Console.WriteLine($"Длина массив ArrayDouble после добавления еще один элемент начало массива: {ArrayHelper.UnShift(ref ArrayDouble, 5.0)}");
            Console.WriteLine($"Длина массив ArrayDecimal после добавления еще один элемент начало массива: {ArrayHelper.UnShift(ref ArrayDecimal, 2.0m)}");
            Console.WriteLine($"Длина массив ArrayFloat после добавления еще один элемент начало массива: {ArrayHelper.UnShift(ref ArrayFloat, 6.0f)}\n\n");
            Console.ReadKey();
        }
    }
    static class ArrayHelper
    {

        //Метод Pop() c перегрузкой
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


        //Метод Push() c перегрузкой
        public static int Push(ref string[] Arr, string Element)
        {
            Arr = Arr.Concat(new string[] { Element }).ToArray();
            int LengthUpdatedArray = Arr.Length;
            return LengthUpdatedArray;
        }
        public static int Push(ref int[] Arr, int Element)
        {
            Arr = Arr.Concat(new int[] { Element }).ToArray();
            int LengthUpdatedArray = Arr.Length;
            return LengthUpdatedArray;
        }
        public static int Push(ref double[] Arr, double Element)
        {
            Arr = Arr.Concat(new double[] { Element }).ToArray();
            int LengthUpdatedArray = Arr.Length;
            return LengthUpdatedArray;
        }
        public static int Push(ref Decimal[] Arr, Decimal Element)
        {
            Arr = Arr.Concat(new Decimal[] { Element }).ToArray();
            int LengthUpdatedArray = Arr.Length;
            return LengthUpdatedArray;
        }
        public static int Push(ref float[] Arr, float Element)
        {
            Arr = Arr.Concat(new float[] { Element }).ToArray();
            int LengthUpdatedArray = Arr.Length;
            return LengthUpdatedArray;
        }


        //Метод Shift() c перегрузкой
        public static string Shift(ref string[] Arr)
        {
            string RemoteElement = Arr[0];
            Arr = Arr.Where((item, index) => index != 0).ToArray();
            return RemoteElement;
        }
        public static int Shift(ref int[] Arr)
        {
            int RemoteElement = Arr[0];
            Arr = Arr.Where((item, index) => index != 0).ToArray();
            return RemoteElement;
        }
        public static double Shift(ref double[] Arr)
        {
            double RemoteElement = Arr[0];
            Arr = Arr.Where((item, index) => index != 0).ToArray();
            return RemoteElement;
        }
        public static Decimal Shift(ref Decimal[] Arr)
        {
            Decimal RemoteElement = Arr[0];
            Arr = Arr.Where((item, index) => index != 0).ToArray();
            return RemoteElement;
        }
        public static float Shift(ref float[] Arr)
        {
            float RemoteElement = Arr[0];
            Arr = Arr.Where((item, index) => index != 0).ToArray();
            return RemoteElement;
        }


        //Метод UnShift() c перегрузкой
        public static int UnShift(ref string[] Arr, string Element)
        {
            var NewArray = new string[Arr.Length + 1];
            Array.Copy(Arr, 0, NewArray, 1, Arr.Length);
            int LengthUpdatedArray = NewArray.Length;
            return LengthUpdatedArray;
        }
        public static int UnShift(ref int[] Arr, int Element)
        {
            var NewArray = new int[Arr.Length + 1];
            Array.Copy(Arr, 0, NewArray, 1, Arr.Length);
            int LengthUpdatedArray = NewArray.Length;
            return LengthUpdatedArray;
        }
        public static int UnShift(ref double[] Arr, double Element)
        {
            var NewArray = new double[Arr.Length + 1];
            Array.Copy(Arr, 0, NewArray, 1, Arr.Length);
            int LengthUpdatedArray = NewArray.Length;
            return LengthUpdatedArray;
        }
        public static int UnShift(ref Decimal[] Arr, Decimal Element)
        {
            var NewArray = new Decimal[Arr.Length + 1];
            Array.Copy(Arr, 0, NewArray, 1, Arr.Length);
            int LengthUpdatedArray = NewArray.Length;
            return LengthUpdatedArray;
        }
        public static int UnShift(ref float[] Arr, float Element)
        {
            var NewArray = new float[Arr.Length + 1];
            Array.Copy(Arr, 0, NewArray, 1, Arr.Length);
            int LengthUpdatedArray = NewArray.Length;
            return LengthUpdatedArray;
        }
    }
}
