using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_WeatherStation
{
    public class Program
    {
        static Weather weather = new Weather("",0);

        static List<Weather> väder = new List<Weather>();
        static void Main(string[] args)
        {


            for (int i = 0; i < 4; i++)
            {
                string stadInput = "";
                int tempInput = 0;
                Console.WriteLine("Ange stad");
                stadInput = Console.ReadLine();
                Console.WriteLine("Ange temperatur");
                tempInput = Convert.ToInt32(Console.ReadLine());
                väder.Add(new Weather(stadInput, tempInput));

            }
            
            BubbleSort(väder, väder.Count );
            for(int i = 0; i < väder.Count; i++)
            {
                Console.WriteLine(väder[i].ToString()) ;
            }
            Console.ReadLine();
            


            

            int linjärsökningres = Linjärsökning(väder,väder.Count, 30);
            if(linjärsökningres == -1)
            {
                Console.WriteLine("Tempen hittades inte");
            }
            else
            {
                Console.WriteLine("Tempen hittades på index " + linjärsökningres);
            }
            Console.ReadLine();

        }
        
        static void BubbleSort(List<Weather> bajs, int n)
        {
            n = bajs.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (bajs[j].Temp > bajs[j + 1].Temp)
                    {
                        Weather tmp = bajs[j];
                        bajs[j] = bajs[j + 1];
                        bajs[j + 1] = tmp;
                    }




        }
        static int Linjärsökning(List<Weather> bajs, int n, int sökTemp)
        {
            for (int i = 0; i < n; i++)
            {
                if (bajs[i].Temp == sökTemp)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
