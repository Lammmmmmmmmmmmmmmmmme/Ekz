using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekz_Horkova
{
    public class ЗаправочнаяСтанция
    {
        public void ЗаправитьТранспорт(Хранилище хранилище, double объем)
        {
            if (хранилище.ТекущийЗапас >= объем)
            {
                хранилище.ИзвлечьТопливо(объем);
                Console.WriteLine($"Транспорт заправлен на {объем} литров топлива.");
            }
            else
            {
                Console.WriteLine("Недостаточно топлива в хранилище для заправки.");
            }
        }
    }
}
