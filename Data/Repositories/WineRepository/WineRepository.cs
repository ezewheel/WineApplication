using Common.DTOs;
using Data.Entities;
using Data.Repositories;

namespace Services.Repository.WineRepository
{
    public class WineRepository : IWineRepository
    {
        private List<Wine> Wines = new List<Wine>
        {
            new Wine()
            {
                Id = 1,
                Name = "Don Alfredo",
                Variety = "Cabernet Sauvignon",
                Year = 2022,
                Region = "Cuyo",
                Stock = 20
            },
            new Wine()
            {
                Id = 2,
                Name = "Alma Mora",
                Variety = "Malbec",
                Year = 1828,
                Region = "Ushuaia",
                Stock = 1
            },
            new Wine()
            {
                Id = 3,
                Name = "Syrah",
                Variety = "Malbec",
                Year = 1,
                Region = "Mendoza",
                Stock = 2000
            }
        };

        public List<Wine> getAllWines()
        {
            return Wines;
        }

        public void addWine(Wine newWine)
        {
            Wines.Add(newWine);
        }
    }
}