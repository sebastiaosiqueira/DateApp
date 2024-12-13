// See https://aka.ms/new-console-template for more information
using System.Globalization;
using Microsoft.VisualBasic;

namespace DateApp{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();
            var data = new DateTime(2020,10,12,8,23,14);
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.DayOfWeek);

            var data1 = DateTime.Now;
            Console.WriteLine(data1);

            var data2 = DateTime.UtcNow;
            Console.WriteLine(data2);

            var datahoje = DateTime.Now;

            var formatada = string.Format("{0:dd/MM/yyyy zz}", datahoje);
            Console.WriteLine(formatada);

             var formatada1= string.Format("{0:D}", datahoje);
            Console.WriteLine(formatada1);

            var formatada2= string.Format("{0:s}", datahoje);
            Console.WriteLine(formatada2);

            var formatada3= string.Format("{0:u}", datahoje);
            Console.WriteLine(formatada3);

            //incluir e remover data mes ano dia
            Console.WriteLine(datahoje.AddDays(12));
            Console.WriteLine(datahoje.AddMonths(3));
            Console.WriteLine(datahoje.AddYears(2));



            //comparacao de datas
          var datacomp = DateTime.Now;

          if(datacomp.Date == DateTime.Now.Date)
             Console.WriteLine("E igual");
            else
            Console.WriteLine("Diferente");
          
          
            Console.WriteLine(datacomp);


            //globalização
            Console.WriteLine(DateTime.Now);

            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-UK");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;
            Console.WriteLine(DateTime.Now.ToString("D", atual));

            //timezone
            var datatime = DateTime.UtcNow;
            Console.WriteLine(datatime);
            Console.WriteLine(datatime.ToLocalTime());

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

            Console.WriteLine(timezoneAustralia);
            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(datatime, timezoneAustralia);
            Console.WriteLine(horaAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach(var timezone in timezones){
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(datatime, timezone));
                Console.WriteLine("---------------");
            }

            //timespan
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);
             var timeSpansg = new TimeSpan(1);
            Console.WriteLine(timeSpansg);

            //quantos dias tem um mes
            Console.WriteLine(DateTime.DaysInMonth(2020, 2));

          /// se é final de semana sabado ou domingo
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
             Console.WriteLine(DateTime.Now.IsDaylightSavingTime());


        }

        static bool IsWeekend(DayOfWeek today){
            return today == DayOfWeek.Saturday || today== DayOfWeek.Sunday;
        }
    }
}
