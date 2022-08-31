//Navid-Derakhshandeh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Events_for_RP_Program
{
    public delegate void Calc(double V, double I);
    
    class Program
    {
        public static event Calc ops;
        
        public static void Resistance(double V, double I)
        {
            Console.WriteLine("Resistance Equal by : {0}", V / I);
        }
        public static void Power(double V, double I)
        {
            Console.WriteLine("Power Equal by : {0}", V * I);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Number of Volatge : ");
            double V = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter The Number of Current : ");
            double I = Double.Parse(Console.ReadLine());
            
            ops = new Calc(Resistance);
            ops += new Calc(Power);
           

            ops(V, I);
            Console.ReadLine();
        }
    }
}
