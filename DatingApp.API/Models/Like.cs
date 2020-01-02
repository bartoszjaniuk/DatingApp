namespace DatingApp.API.Models
{
    public class Like
    {
        public int LikerId { get; set; } // user likes some1
        public int LikeeId { get; set; } // user being like
        public virtual User Liker {get; set;}
        public virtual User Likee {get; set;}
    }
}