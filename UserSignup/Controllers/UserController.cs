using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;
using UserSignup.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(User user)
        {
            //TODO 3: update this to get all users from your UserData class
            // and return it to the view.  Update the view to display some user data.
            List<User> users = UserData.GetAll();
            return View(users);

            //if (user == null) user = new User();
            //return View(user);
        }

        // TODO 4: add a details controller and view that takes a single userid,
        // gets that user object from UserData, returns it to the details view
        // where it is displayed

        [HttpGet]
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    Username = addUserViewModel.Username,
                    Email = addUserViewModel.Email
                };

                UserData.Add(newUser);

                return Redirect("/User");

            }
            return View(addUserViewModel);
        }
    }
}