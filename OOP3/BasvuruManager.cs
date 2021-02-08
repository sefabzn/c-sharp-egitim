using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            krediManager.hesapla();
            foreach (var logturu in loggerService)
            {
                logturu.log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredituru in krediler)
            {
                kredituru.hesapla();
            }
        }
    }
}
