using PregledPlus.Data;
using PregledPlus.Models;
using System.Linq.Expressions;

namespace PregledPlus.Repository
{
    public class VoziloRepository : Repository<Vozilo>, IVoziloRepository
    {
        private DBContext db;

        public VoziloRepository(DBContext _db) : base(_db)
        {
            db = _db;
        }
        public void Update(Vozilo vozilo)
        {
            db.Update(vozilo);
        }
    }
}
