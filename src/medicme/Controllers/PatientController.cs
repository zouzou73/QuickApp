// ======================================
// Author: Ebenezer Monney
// Email:  info@ebenmonney.com
// Copyright (c) 2017 www.ebenmonney.com
// ======================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL;
using medicme.ViewModels;
using AutoMapper;
using DAL.Models;

namespace medicme.Controllers
{
    //[Route("api/[controller]/[action]")]
    [Route("api/[controller]")]
    public class PatientController : Controller
    {
        private IUnitOfWork _unitOfWork;


        public PatientController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var allPatients = _unitOfWork.Patients.GetAllPatientsData();
            return Ok(Mapper.Map<IEnumerable<PatientViewModel>>(allPatients));
        }


        [HttpGet("throw")]
        public IEnumerable<PatientViewModel> Throw()
        {
            throw new InvalidOperationException("This is a test exception: " + DateTime.Now);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value: " + id;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
