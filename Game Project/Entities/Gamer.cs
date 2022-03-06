using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Entities
{
    public class Gamer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime birthDate { get; set; }
        public string Country { get; set; }
        public long NationalityID { get; set; }

        public Gamer(string name, string surname, DateTime birthDate, string country, long nationalityID)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            this.birthDate = birthDate;
            Country = country ?? throw new ArgumentNullException(nameof(country));
            NationalityID = nationalityID;
        }
    }
}
