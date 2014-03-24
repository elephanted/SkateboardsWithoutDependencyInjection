using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skate.Shared;
using SkateRepository.Service;

namespace Skate.Presentation
{
    public class SkateViewModel 
    {
        protected ServiceRepository Repository = new ServiceRepository();
        public IEnumerable<Skateboard> Skateboards { get; set; }
        public SkateViewModel()
        {
            Skateboards = Repository.GetSkateboards();
        }
    }
}
