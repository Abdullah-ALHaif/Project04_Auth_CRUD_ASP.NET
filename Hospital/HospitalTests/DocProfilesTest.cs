﻿using Hospital.Controllers;
using Hospital.Data;
using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTests
{
    class DocProfilesTest
    {
        private ApplicationDbContext _db;

        [OneTimeSetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("HospitalDatabase").Options;
            _db = new ApplicationDbContext(options);

           
        }

        [Test]
        public void Test1()
        {
            var controller = new DocProfiles(this._db);
            var result = controller.Index() as ViewResult;
            var DocP = result.ViewData["DocProfiles"] as List<DocProfile>;

            Assert.AreEqual(DocP.Count, 0);
            Assert.Pass();
        }
    }
}
