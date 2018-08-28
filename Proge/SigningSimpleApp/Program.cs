using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigningSimpleApp
{
    class Program
    {
        static private void Search_x()
        {
            int x2 = 7;
            int x = 3;
            int number = 4;
            int answer;
            Console.WriteLine("Введите число x: ");
            int x_which_led_the_user = int.Parse(Console.ReadLine());
            answer = x2 * (x_which_led_the_user * x_which_led_the_user) - 3 * x + number;
            Console.WriteLine("answer: " + answer);
        }
        static private void Print_number_R()
        {
            double R;
            double S;
            double L;
            double p = 3.14;
            Console.WriteLine("Введите радиус: ");
            R = int.Parse(Console.ReadLine());

            double D = R + R;
            L = p * D;
            S = p * R * R;

            Console.WriteLine("S = " + S);
            Console.WriteLine("L = " + L);
        }
        static private void Search_meters()
        {
            double centimeters;
            double meters;
            double difference = 100;
            Console.WriteLine("Введите сантиметры: ");
            centimeters = int.Parse(Console.ReadLine());
            meters = centimeters / difference;

            Console.WriteLine("m = " + meters);
        }
        static private void Search_Week()
        {
            int Day = 234;
            int day_in_week = 7;
            int Week;
            Week = Day / day_in_week;
            Console.WriteLine("Week = " + Week);
        }
        static private void two_numbers()
        {
            int dozens_of;
            int ten = 10;
            int units;
            int sum;
            int composition;
            Console.WriteLine("Введите двузначное число");
            int number = int.Parse(Console.ReadLine());

            dozens_of = number / ten;
            units = number % ten;
            sum = dozens_of + units;
            composition = dozens_of * units;

            Console.WriteLine("десятков " + dozens_of);
            Console.WriteLine("единиц " + units);
            Console.WriteLine("сумма " + sum);
            Console.WriteLine("произведение " + composition);
        }
        static private void four_digit()
        {
            int first_number;
            int second_number;
            int third_number;
            int fourth_number;
            int ten = 10;
            int hundred = 100;
            int thousand = 1000;
            int sum;

            Console.WriteLine("Введите четырехзначную число");
            int number = int.Parse(Console.ReadLine());

            fourth_number = number % ten;
            third_number = number % hundred;
            third_number = third_number / ten;
            second_number = number % thousand;
            second_number = second_number / hundred;
            first_number = number / thousand;
            sum = first_number + second_number + third_number + fourth_number;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("composition = " + first_number * second_number * third_number * fourth_number);

        }
        static private void three_digit()
        {
            int number = 456;
            int x;
            int ten = 10;
            int hundred = 100;
            int first_number;
            int second_number;
            int third_number;

            first_number = number % ten;
            second_number = number % hundred;
            second_number = second_number / ten;
            third_number = number / hundred;

            x = third_number * hundred + first_number * ten + second_number;

            Console.WriteLine("x = " + x);
        }
        static private void Boolen()
        {
            bool X;
            bool Y;

            X = false;
            Y = false;

            Console.WriteLine(!X && !Y);
            Console.WriteLine(X || (!X && Y));
            Console.WriteLine((!X && Y) || Y);
            Console.WriteLine();

            X = true;
            Y = true;

            Console.WriteLine(!X && !Y);
            Console.WriteLine(X || (!X && Y));
            Console.WriteLine((!X && Y) || Y);
            Console.WriteLine();

            X = true;
            Y = false;

            Console.WriteLine(!X && !Y);
            Console.WriteLine(X || (!X && Y));
            Console.WriteLine((!X && Y) || Y);
            Console.WriteLine();

            X = false;
            Y = true;

            Console.WriteLine(!X && !Y);
            Console.WriteLine(X || (!X && Y));
            Console.WriteLine((!X && Y) || Y);
        }


        static void Main(string[] args)
        {
            

            Console.ReadLine();
        }
    }
}

