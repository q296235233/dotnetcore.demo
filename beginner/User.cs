using System.ComponentModel.DataAnnotations;

namespace beginner
{
    public class User
    {
        public int Id { get; set; }

        [Required,StringLength(49) ]
        public  string Name{get; set; }
    

    }
}