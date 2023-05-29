using System;
namespace Generics
{
    public class Program
    {
        public static void Main(String[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter the Choice\n1)Int Data Type");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        IntDataType intDataType = new IntDataType();
                        int result = intDataType.IntCompare(4, 3, 2 );
                            Console.WriteLine(result);
                        break;
                }
            }
        }
    }
}