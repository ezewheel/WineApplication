using Common.DTOs;
using Data.Entities;

namespace Data.Repositories
{
    public interface IWineRepository
    {
        List<Wine> getAllWines();
        void addWine(Wine newWine);
    }
}