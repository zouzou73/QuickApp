// ======================================
// Author: Ebenezer Monney
// Email:  info@ebenmonney.com
// Copyright (c) 2017 www.ebenmonney.com
// ======================================

using DAL.Models;
using System;
using System.Linq;


namespace medicme.ViewModels
{
    public class ConsultationViewModel
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int DocId { get; set; }
        public Provider Praticien { get; set; }
        public DateTime DateCreated { get; set; }
        public string Comments { get; set; }
    }
}
