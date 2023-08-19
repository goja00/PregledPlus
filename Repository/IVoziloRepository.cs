using PregledPlus.Models;

namespace PregledPlus.Repository
{
    public interface IVoziloRepository : IRepository<Vozilo>
    {
        void Update(Vozilo vozilo);
    }
}
