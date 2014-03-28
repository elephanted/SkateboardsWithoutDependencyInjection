using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skate.Shared;
using SkateRepository.Service;
using SkateRepository.Interface;

namespace Skate.Presentation
{
    public class SkateViewModel 
    {
        protected ISkateRepository Repository;       
        public IEnumerable<Skateboard> Skateboards { get; set; }

        public SkateViewModel(ISkateRepository repository)
        {
            Repository = repository;
            Skateboards = Repository.GetSkateboards();
        }
    }
}
