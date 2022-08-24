using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Swordland.ApplicationLogic;
using Swordland.ApplicationLogic.Abstractions;
using Swordland.ApplicationLogic.Data;
using Swordland.Models;

namespace Swordland.Controllers
{
    public class TicketsController : Controller
    {
        private IUserRepository userRepository;
        private ITicketsRepository ticketsRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        public TicketsController(ITicketsRepository ticketsRepository, IUserRepository userRepository, UserManager<ApplicationUser> userManager)
        {
            this.userRepository = userRepository;
            this.ticketsRepository = ticketsRepository;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Tickets()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Tickets(TicketsViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (!userRepository.CheckIfUserExists(_userManager.GetUserId(User).ToString()))
            {

                userRepository.AddUser(_userManager.GetUserId(User).ToString());
            }

            string UserId = _userManager.GetUserId(User).ToString();
            ticketsRepository.Add(new Tickets()
            {
                TicketsId = viewModel.TicketsId,
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                MatchNumber = viewModel.MatchNumber,
                CardNumber = viewModel.CardNumber,                
                UserId = UserId
            });          

            return View(viewModel);
        }
    }
}