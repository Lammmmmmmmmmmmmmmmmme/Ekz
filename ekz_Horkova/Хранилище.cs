using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekz_Horkova
{
    public class Хранилище
    {
        public double Объем { get; set; }
        public double ТекущийЗапас { get; set; }

        public double ВычислитьДоступныйОбъем()
        {
            return Объем - ТекущийЗапас;
        }

        public void ДобавитьТопливо(Топливо топливо)
        {
            ТекущийЗапас += топливо.Объем;
        }

        public void ИзвлечьТопливо(double объем)
        {
            ТекущийЗапас -= объем;
        }
    }
}
