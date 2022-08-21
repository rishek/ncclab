using System;
namespace ClassAndObject
{

    public class Testing
    {

        public void Checking()
        {
            Console.WriteLine("Hello Rishek");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Testing obj = new Testing(); 
            obj.Checking();
        }
    }
}
