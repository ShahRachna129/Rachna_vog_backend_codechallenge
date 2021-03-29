using System;

namespace TestModule
{
    public class TestModule
    {
        static void Main(string[] args)
        {
            object[] data = { 1,2,3,4,5, 0, 1.0f , 2.0f ,"rachna"};
            foreach (var item in data)
            {
                SwitchPattern(item);
            }
            Console.WriteLine();
        }
        public static void SwitchPattern(object o)
        {
            switch (o)
            {
                case int i:
                    if(i>=1 && i<=4)
                        Console.WriteLine(i * 2);
                    if (i > 4 )
                        Console.WriteLine(i * 3);
                    if (i < 1)
                        throw new Exception("The value is Less then 0");
                    break;
               
                case float f:
                    if(f == 1.0f || f== 2.0f)
                    Console.WriteLine("3.0f");
                    break;
                case var x:
                    Console.WriteLine(x.ToString().ToUpper());
                    break;
                default:
                    Console.WriteLine(o);
                    break;
            }
        }
    }
}
