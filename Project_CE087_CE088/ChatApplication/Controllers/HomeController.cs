using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChatApplication.Models;
using Microsoft.AspNetCore.Identity;
using ChatApplication.Areas.Identity.Data;
using ChatApplication.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace ChatApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ChatApplicationUser> userManager;
        private readonly SignInManager<ChatApplicationUser> signInManager;
        private readonly ChatApplicationDBContext chatApplicationDBContext;

        public HomeController(UserManager<ChatApplicationUser> userManager,
                             SignInManager<ChatApplicationUser> signInManager,
                             ChatApplicationDBContext chatApplicationDBContext)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.chatApplicationDBContext = chatApplicationDBContext;
        }

        public IActionResult Index()
        {
           return View();
        }

        [Authorize]
        public async Task<IActionResult> Dashboard()
        {
            HomeDashboardViewModel homeDashboardViewModel = new HomeDashboardViewModel()
            {
                Users = chatApplicationDBContext.Users.ToList(),
                MessagesBetween = null,
                ReceiverUser = null,
                LastMessageBetweenTwoUser = new Dictionary<string, Message>()
            };

            var loggedInUser = await userManager.GetUserAsync(User);

            for (int i=0; i< homeDashboardViewModel.Users.Count; i++)
            {
                if (homeDashboardViewModel.Users[i] == loggedInUser)
                    homeDashboardViewModel.Users.Remove(homeDashboardViewModel.Users[i]);
            }
            for (int i = 0; i < homeDashboardViewModel.Users.Count; i++)
            {
                if (homeDashboardViewModel.Users[i] != loggedInUser)
                {
                    // fetch mesg between these 2 users.
                    var user2Id = homeDashboardViewModel.Users[i].Id;
                    var result = chatApplicationDBContext.Messages.Where(q =>
                    ((
                        q.ReceiverUserID == user2Id) && (q.SenderUserID == loggedInUser.Id))
                        || ((q.SenderUserID == user2Id) && (q.ReceiverUserID == loggedInUser.Id))
                    );

                    if (result != null)
                    {
                        homeDashboardViewModel.MessagesBetween = result.ToList();
                        if (homeDashboardViewModel.MessagesBetween.Count != 0)
                        {
                            homeDashboardViewModel.LastMessageBetweenTwoUser[user2Id] = homeDashboardViewModel.MessagesBetween[homeDashboardViewModel.MessagesBetween.Count - 1];
                        }
                        else
                        {
                            homeDashboardViewModel.LastMessageBetweenTwoUser[user2Id] = null;
                        }
                    }
                    else
                    {
                        homeDashboardViewModel.LastMessageBetweenTwoUser[user2Id] = null;
                    }
                }
            }
            return View(model: homeDashboardViewModel);
        }

        public async Task<IActionResult> FetchUser(string UserId)
        {
            HomeDashboardViewModel homeDashboardViewModel = new HomeDashboardViewModel()
            {
                Users = chatApplicationDBContext.Users.ToList(),
                MessagesBetween = null,
                ReceiverUser = null,
                LastMessageBetweenTwoUser = new Dictionary<string, Message>()
            };
            var loggedInUser = await userManager.GetUserAsync(User);
            ViewBag.loginUser = loggedInUser.Id;
            


            for (int i = 0; i < homeDashboardViewModel.Users.Count; i++)
            {
                if (homeDashboardViewModel.Users[i] != loggedInUser)
                {
                    // fetch mesg between these 2 users.
                    var user2Id = homeDashboardViewModel.Users[i].Id;
                    var res = chatApplicationDBContext.Messages.Where(q =>
                    ((
                        q.ReceiverUserID == user2Id) && (q.SenderUserID == loggedInUser.Id))
                        || ((q.SenderUserID == user2Id) && (q.ReceiverUserID == loggedInUser.Id))
                    );

                    if (res != null)
                    {
                        homeDashboardViewModel.MessagesBetween = res.ToList();
                        if (homeDashboardViewModel.MessagesBetween.Count != 0)
                        {
                            homeDashboardViewModel.LastMessageBetweenTwoUser[user2Id] = homeDashboardViewModel.MessagesBetween[homeDashboardViewModel.MessagesBetween.Count - 1];
                        }
                        else
                        {
                            homeDashboardViewModel.LastMessageBetweenTwoUser[user2Id] = null;
                        }
                    }
                }
            }

            for (int i = 0; i < homeDashboardViewModel.Users.Count; i++)
            {
                if (homeDashboardViewModel.Users[i] == loggedInUser)
                    homeDashboardViewModel.Users.Remove(homeDashboardViewModel.Users[i]);
            }


            var result = chatApplicationDBContext.Messages.Where(q =>
                ((q.ReceiverUserID == UserId) && (q.SenderUserID == loggedInUser.Id))
                || ((q.SenderUserID == UserId) && (q.ReceiverUserID == loggedInUser.Id))
            );
            homeDashboardViewModel.MessagesBetween = result.ToList();
            
            ChatApplicationUser receiver = await userManager.FindByIdAsync(UserId);
            ViewBag.receiverId = receiver.Id;
            homeDashboardViewModel.ReceiverUser = receiver;
            return View("Dashboard",model: homeDashboardViewModel);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Hello User, by registering yourself you can chat with any other registered user.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
