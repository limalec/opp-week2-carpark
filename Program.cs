using System;

namespace carpark
{
    public class customer
    {
        public string name { get; set; }
        public int excess{ get; set; }
        public int time { get; set; }
        public static float total = 0;
        public customer(int _time,string _name)
        {
            time = _time;
            name = _name;
            if (time>3)
            {
                excess = time -3;
            }
            else
            {
               excess = 0;
            }
        }

        public float calculateCharges (int time,string name)
        {
            if(time >0 && time<=3)
            {
                float a = 2;
                Console.WriteLine(name + " : "+ a + "€");
                total = total + a;
                return a;
            }
            else
            {
                if(time==24)
                {
                    float a = 10;
                    Console.WriteLine(name + " : "+ a + "€");
                    total = total + a;
                    return a;                    
                }   
                if(time<24)
                {
                    float b = (float)excess/2;
                    float res = 2 + b;
                    Console.WriteLine(name + " : "+ res + "€");
                    total = total + res;
                    return res;
                }
                return 0;             
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            customer first = new customer(2,"Customer 1");
            first.calculateCharges(first.time,first.name);
            customer second = new customer(4,"Customer 2");
            second.calculateCharges(second.time,second.name);
            customer third = new customer(6,"Customer 3");
            third.calculateCharges(third.time,third.name);
            customer fourth = new customer(24,"Customer 4");
            fourth.calculateCharges(fourth.time,fourth.name);
            customer fifth = new customer(23,"Customer 5");
            fifth.calculateCharges(fifth.time,fifth.name);
            Console.WriteLine("Total : " + customer.total + "€");
        }
    }
}
