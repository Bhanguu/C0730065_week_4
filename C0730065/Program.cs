using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730065
{
    class Program
    {
        static void Main(string[] args)

        {
            countryside c =  new countryside();
            c.run();
            c.travel();
            Console.ReadLine();
            
           
        }
    }
    class LearningExperiment
    {
        public void run()
        {
            village Toronto;
            Toronto = new village();
            village a, b, c;
            Toronto.villagename = "version A";
            a = Toronto;
            Console.WriteLine(a.villagename);
            Toronto = new village();
            Toronto.villagename = "version B";
            b = Toronto;
            Console.WriteLine(a.villagename);
            Toronto = new village();
            Toronto.villagename = "version C";
            c = Toronto;
            Console.WriteLine(a.villagename);
        }
    }
        class village
        {
            public bool isAstrilde;
            public village nextvillage;
            public village prevvillage;
            public String villagename;
        }



        class countryside
        {
            village Mapple;
            village Toronto;
            village ajax;

            public void run()
            {
                Mapple = new village();
                Toronto = new village();
                ajax = new village();
                ajax.isAstrilde = true;
                Mapple.villagename = "Mapple";
                Mapple.nextvillage = Toronto;
            Toronto.nextvillage = ajax;
            Toronto.villagename = "Toronto";
            ajax.nextvillage = null;
            }
            public void travel()
            {
                village currentvillage = Mapple;

            while (currentvillage.nextvillage != null) { 

            Console.WriteLine("I am in " + currentvillage.villagename);
                

                    if (currentvillage.isAstrilde)
                        Console.WriteLine("you found astrilde in " + currentvillage);
                    else
                        currentvillage = currentvillage.nextvillage;
                }

            }
        }
    }


    
