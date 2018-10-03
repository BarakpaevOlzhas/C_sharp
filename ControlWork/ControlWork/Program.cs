using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    class Program
    {
        static void Filling(List<Category> categories)
        {
            Category bufCategory = new Category();

            int zero = 0;
            int one = 1;
            int two = 2;
            int three = 3;

            bufCategory.Name = "еда для животных";
            categories.Add(bufCategory);

            bufCategory.Name = "Отдых";
            categories.Add(bufCategory);

            bufCategory.Name = "Техника ";
            categories.Add(bufCategory);

            bufCategory.Name = "Природа";
            categories.Add(bufCategory);

            Product product = new Product("Wiscas",200,"");
            categories[zero].Products.Add(product);

            product.Add("Felix", 230,"");
            categories[zero].Products.Add(product);

            product.Add("палатка",20000,"");
            categories[one].Products.Add(product);

            product.Add("Гриль", 30000, "");
            categories[one].Products.Add(product);

            product.Add("Iphone XS", 400000, "");
            categories[two].Products.Add(product);

            product.Add("Iphone 8", 200000, "");
            categories[two].Products.Add(product);

            product.Add("Лопата", 200000, "");
            categories[three].Products.Add(product);

            product.Add("Топор", 200000, "");
            categories[three].Products.Add(product);
        }

       static void Menu(List<Category> categories)
        {
            int choise = 0;

            Console.WriteLine("1)Каталог");

            Console.WriteLine("2)Все товары");

            int.TryParse(Console.ReadLine(),out choise);

            if (choise == 1)
            {
                AllСatalogs(categories);
            }

            else if (choise == 2)
            {
                AllGoods(categories);
            }
        }

        static void AllGoods(List<Category> categories)
        {
            
        }

        static void AllСatalogs(List<Category> categories)
        {
            int choise = 0;

            for (int i = 0; i < categories.Capacity; i++)
            {
                Console.WriteLine($"{i}){categories[i].Name}");
            }

            Console.WriteLine();

            Console.WriteLine("выберите каталог");

            int.TryParse(Console.ReadLine(),out choise);


        }

        static void Main(string[] args)
        {
            MainUser user = new MainUser();

            List<Category> categories = new List<Category>();

            Filling(categories);

            int choise = 0;

            Console.WriteLine("1)Зарегистрироваться");

            Console.WriteLine("2)Войти");

            int.TryParse(Console.ReadLine(),out choise);

            if (choise == 1)
            {
                string name, password, mail, phone;

                Console.WriteLine("Введите Имя: ");
                name = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                password = Console.ReadLine();

                Console.WriteLine("Введите почту: ");
                mail = Console.ReadLine();

                Console.WriteLine("Введите номер телефона: ");
                Console.Write("+7 ");
                phone = Console.ReadLine();

                Console.WriteLine(user.SingUp(name, password, mail, phone));

                if (user.LogIn(name, password))
                {
                    Menu(categories);
                }

            }
            else if (choise == 2)
            {
                string name, password;                

                Console.WriteLine("Введите Имя: ");
                name = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                password = Console.ReadLine();

                if(user.LogIn(name, password))
                {
                    Menu(categories);
                }
            }

        }
    }
}
