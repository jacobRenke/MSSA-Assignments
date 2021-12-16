using System.Collections.Generic;
using ClassChallengeDEC08.Models;
using System.Linq;

namespace ClassChallengeDEC08.Services

{
    public class FriendsList : IFriendsList
    {
        public List<Friend> Friends { get; set; }

        public FriendsList()
        {
            //calls the method to set the initial value of the Friends list
            InitializeFriendsList();

        }

        public void InitializeFriendsList()
        {
            //sets the initial value of the Friends list
            Friends = new List<Friend>();
            Friends.Add(new Friend() { _friendID = 1, _friendName = "Jacob", _place = "North Carolina",_BirthDay = "Unknown", _Gender = "Staff Sarnt", _NickName = "Jake" });
            Friends.Add(new Friend() { _friendID = 2, _friendName = "Joeseph", _place = "Wisconsin",_BirthDay = "Unknown", _Gender = "Male", _NickName = "Joe" });
            Friends.Add(new Friend() { _friendID = 3, _friendName = "Fernando", _place = "Mexico", _BirthDay = "Unknown", _Gender = "Male", _NickName = "Leon" });

        }

        public Friend GetFriendById (int? id)
        {

            
            //creating a new friend. SingleOrDefault attempts to retrieve a friend =>(where) friend._friendID is equal to ID
            Friend friend = this.Friends.SingleOrDefault(friend => friend._friendID == id);

            return friend;
        }

        public void DeleteFriendById(int? id)
        {
            //creating a new friend. SingleOrDefault attempts to retrieve a friend =>(where) friend._friendID is equal to ID
            Friend FriendToRemove = GetFriendById(id);

            //removes the Friend named FriendToRemove from the List named Friends
            this.Friends.Remove(FriendToRemove);
        }

       public void UpdateFriendById(Friend friend, int id)
        {
            //changes friend at position ID-1 (the place in the list it is) to the friend that is passed from controller
            Friends[id - 1] = friend;
        }

    }
}
