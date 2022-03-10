using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface yani arayüzler nesneye dayalı programlamanın önemli özelliklerinden biridir. Sınıfların içermesi gereken metotların imzalarının yer aldığı, özelliklerin tanımlandığı bir taslak gibi düşünebiliriz.
            //Kesin belirlenmiş bir kural olmamasıyla beraber interface isimleri "I" ile başlar. I ile başlayan bir isim gördüğümüzde kolaylıkla bunun bir arayüz olduğunu anlarız. 

            FileLogger fileLogger= new FileLogger();
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            SmsLogger smsLogger= new SmsLogger();
            smsLogger.WriteLog();

            //yukardaki gibi yazmamıza gerek yok asagıdaki gibide yazabiliriz.
            LogManager logManager= new LogManager(new FileLogger());
            logManager.WriteLog();
        }
    }
}
