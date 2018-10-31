using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Character
    {
        // Physical
        public Attribute Strength { get; set; }
        public Attribute Dexterity { get; set; }
        public Attribute Stamina { get; set; }

        public List<Attribute> PhysicalAttributes { get; } = new List<Attribute>();

        // Social
        public Attribute Charisma { get; set; }
        public Attribute Manipulateion { get; set; }
        public Attribute Appearance { get; set; }
        public List<Attribute> SocialAttributes { get; } = new List<Attribute>();

        // Mental
        public Attribute Intelligence { get; set; }
        public Attribute Perception { get; set; }
        public Attribute Wits { get; set; }
        public List<Attribute> MentalAttributes { get; } = new List<Attribute>();
    }
}
