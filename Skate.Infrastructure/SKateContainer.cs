using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkateRepository.Interface;
using Skate.Shared;
using Skate.Presentation;
using SkateRepository.Service;

namespace Skate.Infrastructure
{
    public class SkateContainer 
    {
        static ISkateRepository _repository = new ServiceRepository();
        public SkateViewModel ViewModel = new SkateViewModel(_repository);

        //public ISkateRepository Repository()
        //{
        //    ISkateRepository repository = new ServiceRepository();
        //    return repository;
        //}

        //public SkateViewModel ViewModel()
        //{
        //    ISkateRepository Repository = new ServiceRepository();
        //    var viewModel = new SkateViewModel(Repository);
        //    return viewModel;
        //}        
    }
}
