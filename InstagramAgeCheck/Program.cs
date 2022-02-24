using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm kontrollib, kas kasutaja on 13 aastat vana või vanem;
            //kui kasutaja on 13 aastat vana või vanem, siis ta võib Instagrami kasutada;
            //kui kasutaja on noorem kui 13, siis ta on liiga noor, et Instagrami kasutada;

            Console.WriteLine("Palun sisestage oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kontot luua.");
            }
            else if(userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kontot luua.");
            }
            else
            {
                Console.WriteLine("Oled 13, seega piisavalt vana, et Instagrami kontot luua.");
            }
            Console.WriteLine("Kena päeva!");

        }
    }
}
