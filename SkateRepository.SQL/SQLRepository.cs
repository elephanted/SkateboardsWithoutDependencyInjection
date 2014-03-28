using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skate.Shared;
using SkateRepository.Interface;

namespace SkateRepository.SQL
{
    public class SQLRepository : ISkateRepository 
    {
        public IEnumerable<Skateboard> GetSkateboards()
        {
            using (var context = new SkateEntities())
            {
                var skateboards = from s in context.Skates
                             select new Skateboard
                             {
                                 SkateboardName = s.SkateboardName,
                                 SkateboardType = s.SkateboardType,
                                 DateAdded = s.DateAdded,
                                 Rating = s.Rating,
                             };

                return skateboards.ToList();
            }
        }

        public Skateboard GetSkateboard(string skateboardName)
        {
            throw new NotImplementedException();
        }

        public void AddSkateboard(Skateboard skateboard)
        {
            throw new NotImplementedException();
        }

        public void UpdateSkateboard(string skateboardName, Skateboard skateboard)
        {
            throw new NotImplementedException();
        }

        public void DeleteSkateboard(string skateboardName)
        {
            throw new NotImplementedException();
        }

        public void UpdateSkateboards(IEnumerable<Skateboard> updatedSkateboards)
        {
            throw new NotImplementedException();
        }
    }
}
