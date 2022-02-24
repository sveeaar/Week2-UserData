using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et juhilube taotleda.";
            //kui kasutaja on vanem kui 18, siis programm kuvab konsoolis
            //"Oled piisavalt vana, et juhilube omada.";
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd saate juhilube taotleda.";

            Console.WriteLine("Palun sisestage oma sünniaasta");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube omada.");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube taotleda.");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd saate juhilube taotleda.");
            }
            Console.WriteLine("Kena päeva!");

        }
    }
}
