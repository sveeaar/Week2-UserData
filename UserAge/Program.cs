using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis;
            //"Oled sündinud aastal {yearOfBirth}";

            Console.WriteLine("Kui vana te olete?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2022 - userAge;

            //Console.WriteLine("Oled sündinud " + yearOfBirth + " aastal");

            Console.WriteLine($"Oled sündinud {yearOfBirth} aastal");


        }
    }
}
