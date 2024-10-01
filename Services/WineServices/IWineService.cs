using Common.DTOs;

namespace Services.WineServices
{
    public interface IWineService
    {
        List<WineForViewDto> getWines();
        void addWine(WineForAddDto newWine);
        void createUser(UserForAddDto newUser);
    }
}
