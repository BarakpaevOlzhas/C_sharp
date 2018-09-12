using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    public class Inventory
    {
        private int sizeResources;
        private int[] resources;

        public Inventory()
        {
            sizeResources = 12;

            resources = new int[sizeResources];

            for (int i =0; i < sizeResources;i++)
            {
                resources[i] = 0;
            }
        }

        public int this[int index]
        {
            get
            {
                return resources[index];
            }
            set
            {
                resources[index] = value;
            }
        }



        /*
         * 1)Древесина 
         * 2)Доска 
         * 3)Палка
         * 4)Булыжник
         * 5)Железо
         * 6)Золото
         * 7)Алмаз
         * 8)Кирка 
         * 9)Лопата 
         * 10)Меч
         * 11)Топор
         * 12)Мотыга
         */
    }
}
