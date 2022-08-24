using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Swordland.ApplicationLogic;
using Swordland.ApplicationLogic.Abstractions;
using Swordland.ApplicationLogic.Data;
using Swordland.Models;

namespace Swordland.Controllers
{
    public class ChallengersController : Controller
    {
        private IBetRepository betRepository;
        private IUserRepository userRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private IChallengerRepository challengerRepository;
        public ChallengersController(IChallengerRepository challengerRepository,
            IUserRepository userRepository, UserManager<ApplicationUser> userManager,
            IBetRepository betRepository)
        {
            this.betRepository = betRepository;
            this.userRepository = userRepository;
            _userManager = userManager;
            this.challengerRepository = challengerRepository;
        }
        [HttpGet]
        public ActionResult Challenge()
        {
            IEnumerable<ChallengersViewModel> viewModel = challengerRepository.GetAll().Select(s => new ChallengersViewModel
            {

                ChallengeId = s.ChallengeId,
                StageName = $"{s.StageName}",
                Image = s.Image,
                Description = s.Description,
                //Alias = s.Alias
            });
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Challenge(ChallengersViewModel viewModel)
        {
            return View(viewModel);
        }

        [HttpGet]
        [Authorize(Roles = "Client")]
        public ActionResult Bets()
        {
            BetViewModel model = new BetViewModel();

            return View(model);

        }

        [HttpPost]
        public ActionResult Bets(BetViewModel viewModel, int? id)
        {
            if (ModelState.IsValid)
            {
                if (id.HasValue)
                {
                    Challengers challengers = challengerRepository.GetChallenge(id.Value);
                    {
                        viewModel.ChallengerId = challengers.ChallengeId;
                    }
                }
                betRepository.Add(new Bet()
                {
                    BetId = viewModel.BetId,
                    Name = viewModel.Name,
                    Email = viewModel.Email,
                    CardNumber = viewModel.CardNumber,
                    Sum = viewModel.Sum,
                    ChallengerId = viewModel.ChallengerId
                });

                ViewBag.message = "Bet placed successfully!";

                return View(viewModel);

            }

            else {
                return View();
                    }
        }
    } 
}
