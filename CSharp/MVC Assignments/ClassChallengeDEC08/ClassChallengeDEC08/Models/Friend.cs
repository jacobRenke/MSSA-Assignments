using System.ComponentModel.DataAnnotations;

namespace ClassChallengeDEC08.Models
{
    public class Friend
    {
        
        [Required(ErrorMessage = "This is literally the easiest one to fill out.")]
        public int _friendID { get; set; }

        [Required(ErrorMessage = "Are you forgetting something?")]
        public string _friendName { get; set; }

        [Required(ErrorMessage = "You need this box filled too.")]
        [StringLength(25, ErrorMessage = "Name length can't be more than 25.")]
        public string _place { get; set; }

        [Required(ErrorMessage = "You need this box filled too.")]
        public string _BirthDay { get; set; }

        [Required(ErrorMessage = "You need this box filled too.")]
        public string _NickName{ get; set; }

        [Required(ErrorMessage = "You need this box filled too.")]   
        public string _Gender { get; set; }


    }
}
