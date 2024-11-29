using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1
{
    internal class Program
    {    
            public static void Main(string[] args)
            {
                FunctionInsp inspector = new FunctionInsp();

                Console.WriteLine($"Главный инспектор: {inspector.GetInspector()}");
                Console.WriteLine($"Название автоинспекции: {inspector.GetCarInspection()}");

                bool success = inspector.SetInspector("Миронов А.В.");
                Console.WriteLine($"Изменение главного инспектора на Миронов А.В. успешно: {success}");
                Console.WriteLine($"Главный инспектор после изменения: {inspector.GetInspector()}");

                string numberPlate = inspector.GenerateNumber('А');
                Console.WriteLine($"Сгенерированный госномер: {numberPlate}");

                Console.WriteLine("Список сотрудников:");
                foreach (string worker in inspector.GetWorker())
                {
                    Console.WriteLine(worker);
                }

                inspector.AddWorker("Сидоров С.С.");
                Console.WriteLine("\nСписок сотрудников после добавления:");
                foreach (string worker in inspector.GetWorker())
                {
                    Console.WriteLine(worker);
                }

                Console.ReadKey();

            }
        


    }
}

