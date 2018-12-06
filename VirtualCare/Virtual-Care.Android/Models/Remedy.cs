
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseApp.Models
{
    [Serializable()]
    public class Remedy
    {
        public string Id { get; set; }
        public string HoraIntervalo { get; set; }

        public DateTime HoraRemedio { get; set; }

        public string RemedioNome { get; set; }

        public override string ToString()
        {
            return RemedioNome + "\nHora: " + HoraRemedio + "\n";
        }

        public bool alarm()
        {
            var finalDateTime = DateTime.Now + TimeSpan.Parse(HoraIntervalo);
            if (DateTime.Now == finalDateTime)
                return true;
            else
                return false;

        }
    }
}
