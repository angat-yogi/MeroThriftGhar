using MeroThriftGhar.DataAccess.Data;
using MeroThriftGhar.DataAccess.Repository.IRepository;
using MeroThriftGhar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeroThriftGhar.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        //public void Update(Category category)
        //{
        //    var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
        //    if (objFromDb!=null)
        //    {
        //        objFromDb.Name = category.Name;
              
        //    }
           
        //}
    }
}
