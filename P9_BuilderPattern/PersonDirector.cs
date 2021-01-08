using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_BuilderPattern
{
  public  class PersonDirector
    {
        private PersonBuilder pb;
        public PersonDirector(PersonBuilder personBuilder)
        {
            pb = personBuilder;
        }

        public void CreatePerson()
        {
            pb.BuildeHead();
            pb.BuildBody();
            pb.BuildArmLeft();
            pb.BuildArmRight();
            pb.BuildLegLeft();
            pb.BuildLegRight();
        }
    }
}
