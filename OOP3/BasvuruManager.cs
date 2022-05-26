using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //Dependency Injection.....Working Independently with the objects by sender...
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }



        //Has same data types and the size is unknown i SELECT LISTS...
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediManagers)
        {

            foreach (var kredi in krediManagers)
            {
                kredi.Hesapla();
            }

        }


    }
}
