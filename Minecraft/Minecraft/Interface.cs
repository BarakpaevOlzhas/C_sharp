using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Minecraft
{
    public class Interface
    {
        private int posX;
        private int posY;
        int resurse;

        public Interface()
        {
            posX = 0;
            posY = 0;
        }

        public void ShowCraftingTable()
        {
            int column = 3;
            int row = 3;
            int zero = 0;
            int one = 1;
            int two = 2;
            Workbench[,] workbench = new Workbench[row, column];
            ConsoleKey key;

            for (int i = 0;i < row; i++)
            {
                for (int j = 0;j < column;j++)
                {
                    workbench[i, j] = new Workbench();
                }
            }

           SetCursorPosition(0,3);
           ForegroundColor = ConsoleColor.Green; Write("########"); ForegroundColor = ConsoleColor.White; Write("########"); ForegroundColor = ConsoleColor.White; WriteLine("########");
           ForegroundColor = ConsoleColor.Green; Write("#      #"); ForegroundColor = ConsoleColor.White; Write("#      #"); ForegroundColor = ConsoleColor.White; WriteLine("#      #");
           ForegroundColor = ConsoleColor.Green; Write($"#  {workbench[zero, zero].ResourceNumber}   #"); ForegroundColor = ConsoleColor.White; Write($"#  {workbench[zero, one].ResourceNumber}   #"); ForegroundColor = ConsoleColor.White; WriteLine($"#  {workbench[zero, two].ResourceNumber}   #");
           ForegroundColor = ConsoleColor.Green; Write("#      #"); ForegroundColor = ConsoleColor.White; Write("#      #"); ForegroundColor = ConsoleColor.White; WriteLine("#      #");         
           ForegroundColor = ConsoleColor.Green; Write("########"); ForegroundColor = ConsoleColor.White; Write("########"); ForegroundColor = ConsoleColor.White; WriteLine("########");
                                                                                                                                                                   
           ForegroundColor = ConsoleColor.White; Write("########"); ForegroundColor = ConsoleColor.White; Write("########"); ForegroundColor = ConsoleColor.White; WriteLine("########");
           ForegroundColor = ConsoleColor.White; Write("#      #"); ForegroundColor = ConsoleColor.White; Write("#      #"); ForegroundColor = ConsoleColor.White; WriteLine("#      #");
            ForegroundColor = ConsoleColor.White; Write($"#  {workbench[one, zero].ResourceNumber}   #"); ForegroundColor = ConsoleColor.White; Write($"#  {workbench[one, one].ResourceNumber}   #"); ForegroundColor = ConsoleColor.White; WriteLine($"#  {workbench[one, two].ResourceNumber}   #");
            ForegroundColor = ConsoleColor.White; Write("#      #"); ForegroundColor = ConsoleColor.White; Write("#      #"); ForegroundColor = ConsoleColor.White; WriteLine("#      #");
           ForegroundColor = ConsoleColor.White; Write("########"); ForegroundColor = ConsoleColor.White; Write("########"); ForegroundColor = ConsoleColor.White; WriteLine("########");
                                                                                                                                                                   
           ForegroundColor = ConsoleColor.White; Write("########"); ForegroundColor = ConsoleColor.White; Write("########"); ForegroundColor = ConsoleColor.White; WriteLine("########");
           ForegroundColor = ConsoleColor.White; Write("#      #"); ForegroundColor = ConsoleColor.White; Write("#      #"); ForegroundColor = ConsoleColor.White; WriteLine("#      #");
            ForegroundColor = ConsoleColor.White; Write($"#  {workbench[two, zero].ResourceNumber}   #"); ForegroundColor = ConsoleColor.White; Write($"#  {workbench[two, one].ResourceNumber}   #"); ForegroundColor = ConsoleColor.White; WriteLine($"#  {workbench[two, two].ResourceNumber}   #");
            ForegroundColor = ConsoleColor.White; Write("#      #"); ForegroundColor = ConsoleColor.White; Write("#      #"); ForegroundColor = ConsoleColor.White; WriteLine("#      #");
           ForegroundColor = ConsoleColor.White; Write("########"); ForegroundColor = ConsoleColor.White; Write("########"); ForegroundColor = ConsoleColor.White; WriteLine("########");

            do
            {
                key = ReadKey().Key;
                if (key == ConsoleKey.UpArrow && posY != 0)
                {
                    posY--;
                }

                else if (key == ConsoleKey.DownArrow && posY != 2)
                {
                    posY++;
                }

                else if (key == ConsoleKey.LeftArrow && posX != 0)
                {
                    posX--;
                }

                else if (key == ConsoleKey.RightArrow && posX != 2)
                {
                    posX++;
                }

                else if (key == ConsoleKey.Enter)
                {
                    resurse = ChoiceOfResource();
                    workbench[posY ,posX] = workbench[posY,posX] + resurse;
                }

                SetCursorPosition(0, 3);
                ForegroundColor = posX == 0 && posY == 0 ? ConsoleColor.Green : ConsoleColor.White; Write("########"); ForegroundColor = posX == 1 && posY == 0 ? ConsoleColor.Green : ConsoleColor.White; Write("########"); ForegroundColor = posX == 2 && posY == 0 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("########");
                ForegroundColor = posX == 0 && posY == 0 ? ConsoleColor.Green : ConsoleColor.White; Write("#      #"); ForegroundColor = posX == 1 && posY == 0 ? ConsoleColor.Green : ConsoleColor.White; Write("#      #"); ForegroundColor = posX == 2 && posY == 0 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("#      #");
                ForegroundColor = posX == 0 && posY == 0 ? ConsoleColor.Green : ConsoleColor.White; Write($"#  {workbench[zero, zero].ResourceNumber}   #"); ForegroundColor = posX == 1 && posY == 0 ? ConsoleColor.Green : ConsoleColor.White; Write($"#  {workbench[zero, one].ResourceNumber}   #"); ForegroundColor = posX == 2 && posY == 0 ? ConsoleColor.Green : ConsoleColor.White; WriteLine($"#  {workbench[zero, two].ResourceNumber}   #");
                ForegroundColor = posX == 0 && posY == 0 ? ConsoleColor.Green : ConsoleColor.White; Write("#      #"); ForegroundColor = posX == 1 && posY == 0 ? ConsoleColor.Green : ConsoleColor.White; Write("#      #"); ForegroundColor = posX == 2 && posY == 0 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("#      #");
                ForegroundColor = posX == 0 && posY == 0 ? ConsoleColor.Green : ConsoleColor.White; Write("########"); ForegroundColor = posX == 1 && posY == 0 ? ConsoleColor.Green : ConsoleColor.White; Write("########"); ForegroundColor = posX == 2 && posY == 0 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("########");
               
                ForegroundColor = posX == 0 && posY == 1 ? ConsoleColor.Green : ConsoleColor.White; Write("########"); ForegroundColor = posX == 1 && posY == 1 ? ConsoleColor.Green : ConsoleColor.White; Write("########"); ForegroundColor = posX == 2 && posY == 1 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("########");
                ForegroundColor = posX == 0 && posY == 1 ? ConsoleColor.Green : ConsoleColor.White; Write("#      #"); ForegroundColor = posX == 1 && posY == 1 ? ConsoleColor.Green : ConsoleColor.White; Write("#      #"); ForegroundColor = posX == 2 && posY == 1 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("#      #");
                ForegroundColor = posX == 0 && posY == 1 ? ConsoleColor.Green : ConsoleColor.White; Write($"#  {workbench[one, zero].ResourceNumber}   #"); ForegroundColor = posX == 1 && posY == 1 ? ConsoleColor.Green : ConsoleColor.White; Write($"#  {workbench[one, one].ResourceNumber}   #"); ForegroundColor = posX == 2 && posY == 1 ? ConsoleColor.Green : ConsoleColor.White; WriteLine($"#  {workbench[one, two].ResourceNumber}   #");
                ForegroundColor = posX == 0 && posY == 1 ? ConsoleColor.Green : ConsoleColor.White; Write("#      #"); ForegroundColor = posX == 1 && posY == 1 ? ConsoleColor.Green : ConsoleColor.White; Write("#      #"); ForegroundColor = posX == 2 && posY == 1 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("#      #");
                ForegroundColor = posX == 0 && posY == 1 ? ConsoleColor.Green : ConsoleColor.White; Write("########"); ForegroundColor = posX == 1 && posY == 1 ? ConsoleColor.Green : ConsoleColor.White; Write("########"); ForegroundColor = posX == 2 && posY == 1 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("########");
                
                ForegroundColor = posX == 0 && posY == 2 ? ConsoleColor.Green : ConsoleColor.White; Write("########"); ForegroundColor = posX == 1 && posY == 2 ? ConsoleColor.Green : ConsoleColor.White; Write("########"); ForegroundColor = posX == 2 && posY == 2 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("########");
                ForegroundColor = posX == 0 && posY == 2 ? ConsoleColor.Green : ConsoleColor.White; Write("#      #"); ForegroundColor = posX == 1 && posY == 2 ? ConsoleColor.Green : ConsoleColor.White; Write("#      #"); ForegroundColor = posX == 2 && posY == 2 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("#      #");
                ForegroundColor = posX == 0 && posY == 2 ? ConsoleColor.Green : ConsoleColor.White; Write($"#  {workbench[two, zero].ResourceNumber}   #"); ForegroundColor = posX == 1 && posY == 2 ? ConsoleColor.Green : ConsoleColor.White; Write($"#  {workbench[two, one].ResourceNumber}   #"); ForegroundColor = posX == 2 && posY == 2 ? ConsoleColor.Green : ConsoleColor.White; WriteLine($"#  {workbench[two, two].ResourceNumber}   #");
                ForegroundColor = posX == 0 && posY == 2 ? ConsoleColor.Green : ConsoleColor.White; Write("#      #"); ForegroundColor = posX == 1 && posY == 2 ? ConsoleColor.Green : ConsoleColor.White; Write("#      #"); ForegroundColor = posX == 2 && posY == 2 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("#      #");
                ForegroundColor = posX == 0 && posY == 2 ? ConsoleColor.Green : ConsoleColor.White; Write("########"); ForegroundColor = posX == 1 && posY == 2 ? ConsoleColor.Green : ConsoleColor.White; Write("########"); ForegroundColor = posX == 2 && posY == 2 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("########");
               
            }
            while (key != ConsoleKey.Escape);
        }


        public int ChoiceOfResource()
        {
            ConsoleKey key;
            int choise = 0;

            SetCursorPosition(0,19);

            ForegroundColor = ConsoleColor.Green; WriteLine("1 - Древесина"); ForegroundColor = ConsoleColor.White;
            WriteLine("2 - Доска ");
            WriteLine("3 - Палка");
            WriteLine("4 - Булыжник");
            WriteLine("5 - Железо");
            WriteLine("6 - Золото");
            WriteLine("7 - Алмаз");
            

            do
            {
                key = ReadKey().Key;
                if (key == ConsoleKey.UpArrow && choise != 0)
                {
                    choise--;
                }

                else if (key == ConsoleKey.DownArrow && choise != 6)
                {
                    choise++;
                }              

                else if (key == ConsoleKey.Enter)
                {
                    if (choise == 0) return 1;

                    else if (choise == 1) return 2;

                    else if (choise == 2) return 3;

                    else if (choise == 3) return 4;

                    else if (choise == 4) return 5;

                    else if (choise == 5) return 6;

                    else if (choise == 6) return 7;
                }

                else if (key == ConsoleKey.Escape)
                {
                    break;
                }

                SetCursorPosition(0, 19);

                ForegroundColor = choise == 0 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("1 - Древесина");
                ForegroundColor = choise == 1 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("2 - Доска ");
                ForegroundColor = choise == 2 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("3 - Палка");
                ForegroundColor = choise == 3 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("4 - Булыжник");
                ForegroundColor = choise == 4 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("5 - Железо");
                ForegroundColor = choise == 5 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("6 - Золото");
                ForegroundColor = choise == 6 ? ConsoleColor.Green : ConsoleColor.White; WriteLine("7 - Алмаз");

            }
            while (key != ConsoleKey.Escape);
            return 0;
        }       

    }
}
