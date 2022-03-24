using System;
using System.Text;
using _24_03_2022.Extensions;

namespace _24_03_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Word:");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Word : {name}");
        menu:
            Console.WriteLine("===================================\n1.Capitalize Method.\n2.Reverse Method.\n3.Parameter Receiver Method.\n4.Array adding Method.\n===================================");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(name.CapitalizeString());
                    goto menu;
                case 2:
                    Console.Clear();
                    StringReverse(ref name);
                    Console.WriteLine(name);
                    goto menu;
                case 3:
                    Console.Clear();
                    string letterinword = " ";
                    ParameterReceiver(name, Convert.ToInt32(Console.ReadLine()), ref letterinword);
                    Console.WriteLine(letterinword);
                    goto menu;
                case 4:
                    Console.Clear();

                    goto menu;
              
                default:
                    Console.Clear();
                    Console.WriteLine("===Thanks===");
                    break;
            }

            //Array arr = new string[3] { "Tural", "Nizami", "Hesen" };
            //Array.Resize(ref arr, arr.Length + 1);
            //ArrayAdd(arr[], Console.ReadLine());
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(arr);
            //}

          
        }
        
        public static void CapitalizeString(ref string text)
        {
            char firstletter = Char.ToUpper(text[0]);
            StringBuilder stringBuilder = new StringBuilder(text);
            stringBuilder[0] = firstletter;
            text = stringBuilder.ToString();
        }

        public static void StringReverse(ref string text)
        {
            int j = 0;
            StringBuilder stringBuilder = new StringBuilder(text);
            for (int i = text.Length - 1; i >= 0; i--)
            {
                stringBuilder[j] = text[i];
                j++;
            }

            text = stringBuilder.ToString();
        }

        public static void ParameterReceiver(string text, int index, ref string letterinword)
        {
            char letter = text[index];
            StringBuilder stringBuilder = new StringBuilder(letterinword);
            stringBuilder[0] = letter; 
            letterinword = stringBuilder.ToString();
        }

        public static void ArrayAdd(ref string[] arr, string addword)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = addword;
        }
    }
}
