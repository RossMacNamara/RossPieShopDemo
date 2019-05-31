using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RossPieShopDemo.Models
{
    public class DbPieService : IPieRepository
    {
        private readonly AppDbContext appDbContext;
        //constructor injection
        public DbPieService(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }
        public IEnumerable<Pie> GetAllPies()
        {
            return appDbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return appDbContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
