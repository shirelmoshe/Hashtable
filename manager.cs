using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _21_11_2022
{
    internal class manager
    {
        
        private manager()
        {

        }

        private readonly static manager _INSTANCE = new manager();

        public static manager INSTANCE
        {
            get { return _INSTANCE; }

        }

        Hashtable tbl= new Hashtable();

        public void  LoadTable()
        {

            Random random = new Random(DateTime.Now.Millisecond);

            for (int i = 1; i < 1000; i++)
            {
               int randomNum= random.Next(1,5);
                if (randomNum % 2 == 0)
                {
                    Falafel yossi = new Falafel(randomNum);
                    yossi.numfalafelballs = random.Next(100,10000);
                    object o = tbl[yossi.Id];
                    Falafel num = (Falafel)o;
                    if (!(tbl[yossi.Id] is Falafel))
                    {
                        tbl.Add(yossi.Id,yossi);
                    }
                    else
                    {
                        Console.WriteLine("the id already exsit");
                    }

                }
                else
                {
                    iceCream Golda=new iceCream(randomNum);
                    Golda.numIceCreamBall=random.Next(1,5);
                   

                    if (!(tbl[Golda.Id]is iceCream))
                    {
                        tbl.Add(Golda.Id, Golda);
                    }
                    else
                    {
                        Console.WriteLine("the id already exsit");
                    }
                        
                }
                

            }

            for (int i= 0; i < 20; i++)
            {
                Console.WriteLine("please enter a number between 100 to 9999");
                string numUser=Console.ReadLine();
                int userResponse = int.Parse(numUser);

                if (tbl[userResponse] is Falafel)
                {
                    Console.WriteLine($"this falafel has { ((Falafel)tbl[userResponse]).numfalafelballs}");
                }
                else if(tbl[userResponse] is iceCream)
                {
                    Console.WriteLine($"this iceCream has {((iceCream)tbl[userResponse]).numIceCreamBall}");
                }
                else
                {
                    Console.WriteLine("the number dosent exsit in the table");
                }
            }
        }
        
    }
}
