using System;

namespace tasklar
{
    class Human
    {

        public string Name;
        public string Surname;
        public byte Age;
        public string FullName()
        {
            return Name+" "+Surname;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Human first= new Human();
            //Student st1 = new Student()
            //{
            //    FullName = "Behruz Rehimov",
            //    GroupN = 231,
            //    Point = 99
            //};
            //Console.WriteLine(st1.IsGraduated());

            notebook[] comps = new notebook[3];
            double price;
            for (int i = 0; i < comps.Length; i++)
            {
                Console.WriteLine("Zehmet olmasa koputerin brendini qeyd edin: ");
                var brend = Console.ReadLine();

                Console.WriteLine("Zehmet olmasa koputerin modelini qeyd edin: ");
                var model = Console.ReadLine();

                do
                {
                    Console.WriteLine("Zehmet olmasa koputerin qiymetini qeyd edin (Menfi qiymet daxil ede bilmezsiz): ");
                    price = Convert.ToDouble(Console.ReadLine());

                } while (price<0);

                var comp = new notebook(brend,model,price);
                comps[i] = comp;
            }
            Console.WriteLine((comps[0].Price + comps[1].Price + comps[2].Price) / 3);
           

        }

    }
}
