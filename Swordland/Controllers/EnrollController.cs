using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swordland.ApplicationLogic.Abstractions;
using Swordland.ApplicationLogic.Data;
using Swordland.Models;

namespace Swordland.Controllers
{
    public class EnrollController : Controller
    {
        private IEnrollRepository enrollRepository;

        public EnrollController(IEnrollRepository enrollRepository)
        {
            this.enrollRepository = enrollRepository;
        }

        [HttpGet]
        public IActionResult Enroll()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Enroll(EnrollViewModel viewModel)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (!enrollRepository.CheckUniqueEmail(viewModel.Email))
            {

                enrollRepository.Add(new Enroll()
                {
                    EnrollId = viewModel.EnrollId,
                    FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName,
                    Email = viewModel.Email,
                    Sword = viewModel.Sword,
                    Description = viewModel.Description
                });

                ViewBag.message = "Your registration was successful!";
            }
            else
            {
                ViewBag.message = "You already used this email to submit this form!";
            }

            return View(viewModel);
        }
    }
}