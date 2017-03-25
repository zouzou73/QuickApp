using DAL.Models;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class LaborantinRepository : Repository<Laborantin>, ILaborantinRepository
    {
        public LaborantinRepository(ApplicationDbContext context) : base(context)
        { }
    }
}
