using DAL.Models;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ConsultationRepository : Repository<Consultation>, IConsultationRepository
    {
        public ConsultationRepository(ApplicationDbContext context) : base(context)
        { }
        private ApplicationDbContext appContext
        {
            get { return (ApplicationDbContext)_context; }
        }
    }
}
