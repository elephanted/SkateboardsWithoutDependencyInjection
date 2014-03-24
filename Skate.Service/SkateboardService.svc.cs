using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Skate.Shared;

namespace Skate.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class SkateboardService : ISkateboardService 
    {

        public List<Skateboard> GetSkateboards()
        {
            var p = new List<Skateboard>()
            {
                new Skateboard() { SkateboardName="Kahuna", SkateboardType="Longboard",
                    DateAdded = DateTime.Parse("08/21/2002"), Rating=2 },
                new Skateboard() { SkateboardName="Mullenator", SkateboardType="Freestyle", 
                    DateAdded = DateTime.Parse("11/12/1982"), Rating=1 },
                new Skateboard() { SkateboardName="Hawk Air", SkateboardType="Vert Ramp", 
                    DateAdded = DateTime.Parse("02/02/1978"), Rating=3 },
                new Skateboard() { SkateboardName="Lee Tre Flip", SkateboardType="Street", 
                    DateAdded = DateTime.Parse("11/08/1985"), Rating=6 },
                new Skateboard() { SkateboardName="Santa Cruiser", SkateboardType="Longboard", 
                    DateAdded = DateTime.Parse("03/13/2008"), Rating=5 },
                new Skateboard() { SkateboardName="The Ollie", SkateboardType="Freestyle", 
                    DateAdded = DateTime.Parse("06/12/1988"), Rating=7 },
                new Skateboard() { SkateboardName="Hosoi Classic", SkateboardType="Vert Ramp", 
                    DateAdded = DateTime.Parse("08/02/1985"), Rating=8 }
            };
            return p;
        }

        public Skateboard GetSkateboard(string skateboardName)
        {
            var p = new List<Skateboard>()
            {
                new Skateboard() { SkateboardName="Kahuna", SkateboardType="Longboard",
                    DateAdded = DateTime.Parse("08/21/2002"), Rating=2 },
                new Skateboard() { SkateboardName="Mullenator", SkateboardType="Freestyle", 
                    DateAdded = DateTime.Parse("11/12/1982"), Rating=1 },
                new Skateboard() { SkateboardName="Hawk Air", SkateboardType="Vert Ramp", 
                    DateAdded = DateTime.Parse("02/02/1978"), Rating=3 },
                new Skateboard() { SkateboardName="Lee Tre Flip", SkateboardType="Street", 
                    DateAdded = DateTime.Parse("11/08/1985"), Rating=6 },
                new Skateboard() { SkateboardName="Santa Cruiser", SkateboardType="Longboard", 
                    DateAdded = DateTime.Parse("03/13/2008"), Rating=5 },
                new Skateboard() { SkateboardName="The Ollie", SkateboardType="Freestyle", 
                    DateAdded = DateTime.Parse("06/12/1988"), Rating=7 },
                new Skateboard() { SkateboardName="Hosoi Classic", SkateboardType="Vert Ramp", 
                    DateAdded = DateTime.Parse("08/02/1985"), Rating=8 }
            };

            Skateboard skateboard = p.Where(s => s.SkateboardName == skateboardName).FirstOrDefault();
            return skateboard;
        }

        public void AddSkateboard(Skateboard newSkateboard)
        {
            throw new NotImplementedException();
        }

        public void UpdateSkateboard(string lastName, Skateboard updatedSkateboard)
        {
            throw new NotImplementedException();
        }

        public void DeleteSkateboard(string lastName)
        {
            throw new NotImplementedException();
        }

        public void UpdateSkateboards(List<Skateboard> updatedSkateboards)
        {
            throw new NotImplementedException();
        }
    }
}
