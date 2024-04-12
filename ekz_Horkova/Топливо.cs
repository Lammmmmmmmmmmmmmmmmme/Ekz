using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekz_Horkova
{
    public class Топливо
    {
        public double Объем { get; set; }
        public double Плотность { get; set; }

        public double ВычислитьМассу()
        {
            return Объем * Плотность;
        }
    }
}
