using Phone;
using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

class Example
{
    static void Main(string[] args)
    {
        int size = 0;
        Users[] users = new Users[size];
        int choise = 0;        
        ConsoleKey key;
        string password;
        string login;
        string phone;

        do
        {
            Console.SetCursorPosition(0,0);
            Console.ForegroundColor = choise == 0 ? ConsoleColor.Green : ConsoleColor.White; Console.WriteLine(">Просмотр<");
            Console.ForegroundColor = choise == 1 ? ConsoleColor.Green : ConsoleColor.White; Console.WriteLine(">Удалить<");
            Console.ForegroundColor = choise == 2 ? ConsoleColor.Green : ConsoleColor.White; Console.WriteLine(">Изменить<");
            Console.ForegroundColor = choise == 3 ? ConsoleColor.Green : ConsoleColor.White; Console.WriteLine(">Добавить<");

            key = Console.ReadKey().Key;

            if (key == ConsoleKey.DownArrow && choise != 3)
            {
                choise++;
            }

            else if (key == ConsoleKey.UpArrow && choise != 0)
            {
                choise--;
            }

            else if (key == ConsoleKey.Enter)
            {
                if (choise == 0)
                {
                    Show(users, size);
                }

                else if (choise == 1)
                {

                }

                else if (choise == 2)
                {

                }

                else if (choise == 3)
                {
                    AddUser(users,ref size);

                    Console.Clear();

                    Console.WriteLine("Введите логин");

                    login = Console.ReadLine();

                    Console.WriteLine("Введите пароль");

                    password = Console.ReadLine();

                    Console.WriteLine("Введите номер");

                    phone = Console.ReadLine();

                    Add(phone);
                }
            }


        } while (true);

        
    }

    static public void Add(string phone)
    {
        var accountSid = "AC86a4384f0074377a25283c22d1e2f774";
        var authToken = "a17714b709b64e09156e4a1df0628d47";
        TwilioClient.Init(accountSid, authToken);

        var messageOptions = new CreateMessageOptions(
            new PhoneNumber(phone));
        messageOptions.From = new PhoneNumber("+18142050418");
        messageOptions.Body = "1";

        var message = MessageResource.Create(messageOptions);
        Console.WriteLine(message.Body);
    }

    static public void AddUser(Users[] users,ref int size)
    {
        int zero = 0;
        int one = 1;

        if (size > zero)
        {
            Users[] buf = new Users[size];

            for (int i = zero; i < size; i++)
            {
                buf[i] = new Users();
            }

            users = new Users[size + one];

            for (int i = zero; i < size + one; i++)
            {
                users[i] = new Users();
            }

            for (int i = zero; i < size; i++)
            {
                buf[i].Login = users[i].Login;
                buf[i].PassWord = users[i].PassWord;
                buf[i].PhoneNumber = users[i].PhoneNumber;
            }
        }

        else
        {
            users = new Users[size + one];

            users[zero] = new Users();
        }
        size++;
    }

    static public void Show(Users[] users,int size)
    {
        for (int i = 0;i < size;i++)
        {
            Console.WriteLine($"Login: {users[i].Login}");
            Console.WriteLine($"PassWord: {users[i].PassWord}");
            Console.WriteLine($"PhoneNumber: {users[i].PhoneNumber}");
        }
    }

}