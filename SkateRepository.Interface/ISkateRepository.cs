using Skate.Shared;
using System.Collections.Generic;

namespace SkateRepository.Interface
{
    public interface ISkateRepository
    {
        IEnumerable<Skateboard> GetSkateboards();

        Skateboard GetSkateboard(string skateboardName);

        void AddSkateboard(Skateboard skateboard);

        void UpdateSkateboard(string skateboardName, Skateboard skateboard);

        void DeleteSkateboard(string skateboardName);

        void UpdateSkateboards(IEnumerable<Skateboard> updatedSkateboards);
    }
}
