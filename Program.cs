using System;

namespace if_elseif
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time >= 6 && time <=11)
                Console.WriteLine("Have a Good Morning");
            else if(time > 11 && time <= 17)
                Console.WriteLine("Have a Good Day");
            else if(time > 17)
                Console.WriteLine("Have a Nice Night");
            
            Console.WriteLine(DateTime.Now);

            string sonuc = time <= 18 ? "iyi günler" : "İyi geceler";
            sonuc = time >= 6 && time <= 11 ? "Günaydın" : time <= 18 ? "iyi günler" : "iyi geceler";
            Console.WriteLine(sonuc);
            
        }
    }
}