using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkateRepository.Interface;
using System.Configuration;
using System.IO;


namespace SkateRepository.CSV
{
    public class CSVRepository : ISkateRepository
    {
        string path;

        public CSVRepository()
        {
            var filename = ConfigurationManager.AppSettings["CSVFileName"];
            path = AppDomain.CurrentDomain.BaseDirectory + filename;

        }

        public IEnumerable<Skate.Shared.Skateboard> GetSkateboards()
        {
            var skateboards = new List<Skate.Shared.Skateboard>();

            if (File.Exists(path))
            {
                using (var sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var elems = line.Split(',');
                        var sk = new Skate.Shared.Skateboard()
                        {
                            SkateboardName = elems[0],
                            SkateboardType = elems[1],
                            DateAdded = DateTime.Parse(elems[2]),
                            Rating = Int32.Parse(elems[3])
                        };
                        skateboards.Add(sk);
                    }
                }
            }
            return skateboards;
        }

        public Skate.Shared.Skateboard GetSkateboard(string skateboardName)
        {
            throw new NotImplementedException();
        }

        public void AddSkateboard(Skate.Shared.Skateboard skateboard)
        {
            throw new NotImplementedException();
        }

        public void UpdateSkateboard(string skateboardName, Skate.Shared.Skateboard skateboard)
        {
            throw new NotImplementedException();
        }

        public void DeleteSkateboard(string skateboardName)
        {
            throw new NotImplementedException();
        }

        public void UpdateSkateboards(IEnumerable<Skate.Shared.Skateboard> updatedSkateboards)
        {
            throw new NotImplementedException();
        }
    }
}
