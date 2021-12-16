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
            return View(_friendsList);
        }

        public IActionResult Details (int? id)
        {
            //created a new friend object based off a method in the FriendsList Service
            //sends the GetFriendsById method an id that is sent from the view using a routed id
            Friend friend = _friendsList.GetFriendById(id);

            //returns the specific friend to the view
            return View(friend);
        }

        public IActionResult DeleteFriend(int? id)
        {
            //this method calls the DeleteFriendById method in the FriendsList Class (under Services)
            
            //uses the instantiated instance of IFriendsList to call the DeletFriendById using the 
            //routed ID from the CSHTML document
             _friendsList.DeleteFriendById(id);

            //redirects the users view to the Index view after deleting.
            return RedirectToAction("Index");
        }
     

        //public IActionResult UpdateFriendDetails(int? id)
        //{
        //    //created a new friend object based off a method in the FriendsList Service
        //    //sends the GetFriendsById method an id that is sent from the view using a routed id
        //    Friend friend = _friendsList.GetFriendById(id);

        //    //returns the specific friend to the view
        //    return View(friend);
        //}

        //public IActionResult UpdateFriend(Friend friend)
        //{
        //    //calls the UpdateFriendById function in the FriendsList class, sending it the friend and the friend's id.
        //    _friendsList.UpdateFriendById(friend, friend._friendID);

        //    //once the friend is updated you get redirected to the Index view
        //    return RedirectToAction("Index");
        //}
    


        //[HttpGet]
        //public IActionResult InsertNewFriend()
        //{
            
        //    return View();
        //}
        ////CREATE FRIENDS

        //[HttpPost]        
        //public IActionResult InsertNewFriend(Friend friend)
        //{
        //    //checks to see if validators are happy, if they are will go back to Index page.
        //    if (ModelState.IsValid)
        //    {
                
        //        _friendsList.Friends.Add(friend);
        //        return RedirectToAction("Index");
        //    }
            
            
        //    return View();
        //}
    }
}
