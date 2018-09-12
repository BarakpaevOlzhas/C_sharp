using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    public class Workbench
    {
        public int ResourceNumber { get; set; }
        
        public static Workbench operator +(Workbench workbenches ,int number)
        {
            workbenches.ResourceNumber = number;           

            return workbenches;
        }

    }
}
