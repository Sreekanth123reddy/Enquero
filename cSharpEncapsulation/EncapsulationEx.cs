using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpEncapsulation
{
    public class EncapsulationEx

    {
        public string Name { get; set; }
        public DateTime BirthDate { get; private set; }
        public EncapsulationEx(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        

        public int Age
        {
            get {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
            
        }

    }
}
