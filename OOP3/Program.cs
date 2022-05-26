using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager krediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerManager();
            ILoggerService fileLoggerService = new FileLoggerManager();


            //1.Option
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new KonutKrediManager(), new List<ILoggerService>() { new DatabaseLoggerManager(), new SmsLoggerManager() });

            //2.Option
            List<ILoggerService> loggerServices = new List<ILoggerService> { new SmsLoggerManager(), new FileLoggerManager() };
            basvuruManager.BasvuruYap(new IhtiyacKrediManager(),loggerServices);



            List<IKrediManager> krediler = new List<IKrediManager>() { krediManager, tasitKrediManager, konutKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            Console.ReadLine();
        }
    }
}
