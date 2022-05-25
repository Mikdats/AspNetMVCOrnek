using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVCOrnek_BussinessLayer
{
    public static class Logger
    {
        public static void LogMessage(string message)
        {
            try
            {
                //bir tane txt dosyası oluşsun onun içine mesjlar yazılsın.
                string dosyaAdi = "AspNetMVCOrnekLogs_" + DateTime.Now.ToString("yyyymmdd") + ".txt";
                string dosyaYolu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dosyaAdi);

                StreamWriter yazici = new StreamWriter(dosyaYolu, append: true);
                yazici.Flush();
                yazici.WriteLine($"{DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss")}{message}");
                yazici.Close();
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}
