using System;
using System.Text;

namespace Lambda_Main
{
    public delegate string MyDelegate(string name);
    class Program
    {
        static void Main()
        {
            MyDelegate obj = ( name) =>
            {
                return "Hello" + name + "a very good morning";
            };
            string str = obj.Invoke("raju");
            Console.WriteLine(str);
        }
    }
}
