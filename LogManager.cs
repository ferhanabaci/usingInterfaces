using System;

namespace Interface
{
    public class LogManager:ILogger{
        public ILogger _logger;
        public LogManager(ILogger logger){
            _logger =logger;// cagrıldıgı yerden bana ne gelirse onu atıyorum 


        }

        public void WriteLog()
        {
            _logger.WriteLog();//ILoggerdan türüyen nesnenin writelogunu calıstırıyor
        }
    }

}