using System.Collections.Generic;
using ClassChallengeDEC08.Models;
using System.Linq;
using ClassChallengeDEC08.Data;
using Microsoft.EntityFrameworkCore;

namespace ClassChallengeDEC08.Services

{
    public class FriendsList : IFriendsList
    {
        
        private FriendContext butler;

        public FriendsList(FriendContext db)
        {
            butler = db;
        }

        public FriendsList()
        {
            //calls the method to set the initial value of the Friends list
            //InitializeFriendsList();
        }

        //THIS IS GOING TO BE DELEGATED TO MY DATA CONTEXT 
        //public void InitializeFriendsList()
        //{
        //    //sets the initial value of the Friends list
        //    Friends = new List<Friend>();
        //    Friends.Add(new Friend() { _friendID = 1, _friendName = "Jacob", _place = "North Carolina",_BirthDay = "Unknown", _Gender = "Staff Sarnt", _NickName = "Jake" });
        //    Friends.Add(new Friend() { _friendID = 2, _friendName = "Joeseph", _place = "Wisconsin",_BirthDay = "Unknown", _Gender = "Male", _NickName = "Joe" });
        //    Friends.Add(new Friend() { _friendID = 3, _friendName = "Fernando", _place = "Mexico", _BirthDay = "Unknown", _Gender = "Male", _NickName = "Leon" });

        //}

        public List<Friend> getFriends()
        {
            return butler.Friend.ToList();
        }

        public Friend getFriendById (int id)
        {
            return butler.Friend.SingleOrDefault(friend => friend._friendID == id); ;
        }

        public void insertNewFriend(Friend friend)
        {
            butler.Friend.Add(friend);
            butler.SaveChanges();
        }

        public void DeleteFriendById(int id)
        {
            //removes the Friend named FriendToRemove from the List named Friends
            Friend friend = butler.Friend.SingleOrDefault(friend => friend._friendID == id);
            butler.Friend.Remove(friend);
            butler.SaveChanges();
        }

       public void UpdateFriendById(Friend friend)
        {
            //changes friend at position ID-1 (the place in the list it is) to the friend that is passed from controller
            butler.Entry(friend).State = EntityState.Modified;
            butler.SaveChanges();
        }

    }
}
