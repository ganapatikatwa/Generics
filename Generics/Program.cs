using System;
namespace Generics
{
    public class Program
    {
        public static void Main(String[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter the Choice\n1)Int Data Type\n2)Float Data Type\n3)String Data Type");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        IntDataType intDataType = new IntDataType();
                        int result1 = intDataType.IntCompare(4, 3, 2 );
                            Console.WriteLine(result1);
                        break;
                    case 2:
                        FloatDataType floatDataType = new FloatDataType();
                        float result2=floatDataType.FloatCompare(4.3f, 2.5f, 5.6f );
                        Console.WriteLine(result2);
                        break;
                    case 3:
                        StringDataType stringDataType = new StringDataType();
                        string result3 = stringDataType.StringCompare("1", "4","3");
                        Console.WriteLine(result3);
                        break;
                }
            }
        }
    }
}