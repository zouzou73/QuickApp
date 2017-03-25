// ======================================
// Author: Ebenezer Monney
// Email:  info@ebenmonney.com
// Copyright (c) 2017 www.ebenmonney.com
// ======================================

using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUnitOfWork
    {
        ILaborantinRepository Laborantins { get; }
        IPatientRepository Patients { get; }
        IAppointementRepository Appointements { get; }
        IConsultationRepository Consultations { get; }
        IProviderRepository Providers { get; }
        
        int SaveChanges();
    }
}
