using Common.DTOs;
using Data.Entities;
using Data.Repositories;

namespace Services.WineServices
{
    public class WineService : IWineService
    {
        private readonly IWineRepository _wineRepository;

        public WineService(IWineRepository wineRepository)
        {
            _wineRepository = wineRepository;
        }

        public List<WineForViewDto> getWines()
        {
            List<Wine> wines = _wineRepository.getAllWines().Where(w => w.Stock > 0).ToList();
            return wines.Select(w => new WineForViewDto()
            {
                Name = w.Name,
                Variety = w.Variety,
                Year = w.Year,
                Region = w.Region,
                Stock = w.Stock
            }).ToList();
        }

        public void addWine(WineForAddDto newWine)
        {
            Wine wine = new Wine()
            {
                Id = _wineRepository.getAllWines().Max(w => w.Id) + 1,
                Name = newWine.Name,
                Variety = newWine.Variety,
                Year = newWine.Year,
                Region = newWine.Region,
                Stock = newWine.Stock
            };

            _wineRepository.addWine(wine);
        }

        public void createUser(UserForAddDto newUser)
        {
            User user = new User()
            {
                Id = 0,
                Username = newUser.Username,
                Password = newUser.Password
            };
        }

    }
}
