using Microsoft.AspNetCore.Mvc;
using ClassChallengeDEC08.Models;
using System.Collections.Generic;
using ClassChallengeDEC08.Services;

namespace ClassChallengeDEC08.Controllers
{
    public class FriendController : Controller
    {
        //initializes the dependency injection of FriendsList
        IFriendsList _friendsList;

        //public List<Friend> friends;

        //Inject service into Contrtoller
        public FriendController(IFriendsList friendsList)
        {
            //Dependency Injection Reference type values
            //See Startup.CS to see where we initialized the dependency injection
            _friendsList = friendsList;            
        }

        public IActionResult Index()
        {         
            return View(_friendsList.getFriends());
        }

        [HttpGet]
        public IActionResult InsertNewFriend()
        {
            return View();
        }

        // CREATE FRIENDS
        [HttpPost]
        public IActionResult InsertNewFriend(Friend friend)
        {
            if (ModelState.IsValid)
            {
                _friendsList.insertNewFriend(friend);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult FriendsDetail(int id)
        {
            Friend friend = _friendsList.getFriendById(id);
            return View(friend);
        }

        public IActionResult DeleteFriendById(int id)
        {
            _friendsList.DeleteFriendById(id);
            return RedirectToAction("Index");
            // Send it to a Are you sure page?
        }

        [HttpPost]
        public IActionResult UpdateFriendById(Friend friend)
        {
            _friendsList.UpdateFriendById(friend);
            return View(friend);
        }
    }
}
