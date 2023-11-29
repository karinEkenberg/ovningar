using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övningar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.1
            /*     Console.WriteLine("Skriv in ett tal:");
                 string dittTal = Console.ReadLine();
                 int nr = Convert.ToInt32(dittTal);
                 Console.WriteLine("Skriv in ett nummer till:");
                 string dittAndraNr = Console.ReadLine();
                 int nr2 = Convert.ToInt32(dittAndraNr);
                 int sum = nr + nr2;
                 Console.WriteLine("Dina tal blir tillsammans: " + sum + "."); */

            //3.2
            /*    Console.WriteLine("skriv in ett tal: ");
                string dittTal = Console.ReadLine();
                int nr1 = Convert.ToInt32(dittTal);
                Console.WriteLine("Skriv ett tal till: ");
                string dittAndraTal = Console.ReadLine();   
                int nr2 = Convert.ToInt32(dittAndraTal);
                Console.WriteLine("Skriv ett tredje tal");
                string dittTredjeTal = Console.ReadLine();
                int nr3 = Convert.ToInt32(dittTredjeTal);
                int sum = nr1 + nr2 + nr3;
                Console.WriteLine("Medelvärdet av dina tal är " + sum/3 + ".");
            */
            //3.3
            /*   Console.WriteLine("Ange ett decimaltal: ");
               string dittTal = Console.ReadLine();
               double nr = Convert.ToDouble(dittTal);
               double result = Math.Ceiling(nr);
               Console.WriteLine("Ditt decimaltal blir avrundat " + result);*/

            //3.4
            /*   Console.WriteLine("Skriv in ett namn:");
               string namn1 = Console.ReadLine();
               Console.WriteLine("Skriv in ett namn till:");
               string namn2 = Console.ReadLine();
               Console.WriteLine("En dag för länge sedan var " + namn1 + " på väg till \n affären och där mötte hen sin bästa vän " + 
                   namn2 + " \nde talades vid en stund och gick sen till stranden för att bada");*/

            // 4.1 - 4.3
            /*   Console.WriteLine("Är det fint väder? Skriv j för ja och n för nej:");
               string inData = Console.ReadLine();
               if (inData.ToUpper() == "j".ToUpper())
               {
                   Console.WriteLine("Vi går på picknick!");
               }
               else if (inData.ToUpper() == "n".ToUpper())
               {
                   Console.WriteLine("Vi stannar inne och läser en bok!");
               }
               else
               {
                   Console.WriteLine("Jag förstår inte.");
               }*/
            //4.4
            /*   Console.WriteLine("Skriv hur många grader varmt det är i Stockholm just nu:");
               int stockholm = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Skriv in hur många grader varmt det är i Göteborg just nu:");
               int göteborg = Convert.ToInt32(Console.ReadLine());
               if(göteborg < stockholm)
               {
                   Console.WriteLine("Det är kallast i Göteborg!");
               }
               else if(göteborg > stockholm)
               {
                   Console.WriteLine("Det är kallast i Stockholm");
               }*/
            //5.1
            /*   for (int i = 0; i < 21; i++)
                  {
                      Console.WriteLine(i);
                  }*/
            //5.2
            /*  Console.WriteLine("Ange ett nr:");
              string inData = Console.ReadLine();
              int nr = Convert.ToInt32(inData);
              while(nr < 100)
              {
                  nr++;
                  Console.WriteLine("Nästkommande nr är " + nr);
              }*/
            //5.3
            /*     Console.WriteLine("Skriv in hur många gånger du vill singla slant:");
                 Random rnd = new Random();
                 string inData = Console.ReadLine();
                 int nr = Convert.ToInt32(inData);
                 int i = 0;
                 while(i < nr)
                 {


                     string[] kronaEllerKlave = { "Krona", "Klave" };
                     int mIndex = rnd.Next(kronaEllerKlave.Length);
                     Console.WriteLine("Du fick en {0}", kronaEllerKlave[mIndex]);
                 }*/
            //12.1



            string[] namnVektor = new string[5];
            for(int i = 0; i < namnVektor.Length; i++)
            {

                Console.WriteLine("Skriv in ett namn:");
                string inData = Console.ReadLine();

            }
        }
    }
}
