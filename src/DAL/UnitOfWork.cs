// ======================================
// Author: Ebenezer Monney
// Email:  info@ebenmonney.com
// Copyright (c) 2017 www.ebenmonney.com
// ======================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Repositories.Interfaces;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext _context;

        IPatientRepository _patients;
        IAppointementRepository _appointements;
        IProviderRepository _providers;
        IConsultationRepository _Consultations; 
        ILaborantinRepository _Laborantins;


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IConsultationRepository Consultations
        {
            get
            {
                if (_Consultations == null)
                    _Consultations = new ConsultationRepository(_context);

                return _Consultations;
            }
        }
        public ILaborantinRepository Laborantins
        {
            get
            {
                if (_Laborantins == null)
                    _Laborantins = new LaborantinRepository(_context);

                return _Laborantins;
            }
        }

        public IPatientRepository Patients
        {
            get
            {
                if (_patients == null)
                    _patients = new PatientRepository(_context);

                return _patients;
            }
        }



        public IAppointementRepository Appointements
        {
            get
            {
                if (_appointements == null)
                    _appointements = new AppointementRepository(_context);

                return _appointements;
            }
        }



        public IProviderRepository Providers
        {
            get
            {
                if (_providers == null)
                    _providers = new ProviderRepository(_context);

                return _providers;
            }
        }




        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
