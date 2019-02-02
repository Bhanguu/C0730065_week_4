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
            countryside c = new countryside();
        }
        class village
        {
           public bool isAstrildeHere;
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
                Mapple.villagename = "Toronto";
                Mapple.nextvillage = Toronto;
            }

        }
    }
}
    
