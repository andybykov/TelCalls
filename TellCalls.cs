
using Microsoft.VisualBasic;
using System.Text;

namespace DemoCS00
{
     internal enum CallType //Перечисление
    {
        city,
        mobile
    }
    internal struct Customer //структура
    {
        public string Name;
        public double Balance;
        public int Minutes;
        public CallType CallType;
    }
    internal class TellCalls
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
             
            Customer User; //Объявляем структуру
            Console.Write("Введите имя клиента: ");
            User.Name = Console.ReadLine();  //инициализируем поля
            Console.Write("Введите начальный баланс: ");
            User.Balance = Double.Parse(Console.ReadLine()); //инициализируем поля

            Console.Write("Введите длительность звонка: ");
            User.Minutes = int.Parse(Console.ReadLine()); //инициализируем поля

            Console.Write("Введите тип звонка звонка (г/м): ");

            // Выбор типа звонка через swicth-case
            switch (char.Parse(Console.ReadLine()))
            {
                case 'г':
                    User.CallType = CallType.city;  //инициализируем поля
                    break;
                case 'м':
                    User.CallType = CallType.mobile;  //инициализируем поля
                    break;
                default: 
                    User.CallType = CallType.city;  //по умолчанию город
                    break;
            }
            /*
             Обрабатываются звонки клиента в зависимости 
             * от типа звонка: «городской» (5 руб./мин.) и «мобильный» (1 руб./мин.), 
             * а также количества минут разговора
             */
            //if (callType == 'Г')
            //    balance -= minutes * 5;
            //else
            //    if (callType == 'М')
            //        balance -= minutes * 1;

            // Выбор тарификации в зависимости от типа звонка
            if (User.CallType == CallType.city)
                User.Balance -= User.Minutes * 5;
            else
            if (User.CallType == CallType.mobile)
                User.Balance -= User.Minutes * 1;
                      

            // вывод результата
            Console.WriteLine($"Клиент {User.Name} до взонка, имеет баланс {User.Balance}");

            // изменение баланса
            double amountPaid = 10;
            User.Balance += amountPaid;

            // вывод результата
            Console.WriteLine($"Клиент {User.Name} после завонка, имеет баланс {User.Balance}");

            //Console.WriteLine("Hello, ?");
            //string? sname = Console.ReadLine();
            //Console.WriteLine($"Hello {sname}!");
        }
    }
}
