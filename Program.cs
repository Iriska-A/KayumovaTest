using System;

namespace InspectorLib
{
    class Program
    {

        static string AddWorker = "Введите данные";
        static string Inspektor = "Автоинспекция г. Чита";
        static string Inspection = "Главный инспектор – Васильев Василий Иванович";
        static string Workers = "Фио сотрудников автоинспекции: Иванов И.И.;Зиронов Т.А.; Миронов А.В.; Васильев В.И.";
        static string Inspector = "Изменить главного испектора";
        static void Main(string[] args)
        {
            Console.WriteLine(Inspektor);
            Console.WriteLine(Inspection);
            Console.WriteLine(Workers);
            Console.Write(GenerateNumber("578", "NF", "75"));

            Console.Write("Введите данные нового сотрудника");
            string name = Console.ReadLine();
            Console.WriteLine(Workers + name);
            Console.Write("Введите данные нового инспектора");
           
            string fullname = "Васильев Василий Иванович";
            fullname = fullname.Replace(fullname, Console.ReadLine());
            Console.WriteLine("Главный инспектор - " + fullname);

            Console.ReadLine();

        }

        public string GetInspektor()
        {
            return Inspektor;
        }

        static string GenerateNumber(string number, string symbol, string code)
        {
            string answer = string.Empty;
            if (code == "75")
            {
                answer = number + symbol + code;
            }
            else
            {
                answer = "Не получилось";
            }

            return answer;
        }
         public void SetInspector() 
        {
            Console.Write($"Изменить ФИО главного инспектора");
            string fullname = "Васильев Василий Иванович";
            fullname = fullname.Replace(fullname, Console.ReadLine());
            Console.WriteLine("Inspection" + fullname);
           
        }
    }
}








   
   

