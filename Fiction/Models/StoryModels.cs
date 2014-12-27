using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Fiction.Models
{
    public class Story
    {
        public Guid id { get; set; }
        public int type { get; set; }
        public string story { get; set; }
        public DateTime dateTimeCreated { get; set; }
        public DateTime dateTimeModified { get; set; }
        public int numberOfHearts { get; set; }
        public int numberOfComments { get; set; }
        public int numberOfReposts { get; set; }
        public string name { get; set; }
        
    }
    public class CreateStoryViewModel
    {
        [Required]
        [Display(Name="The type of story")]
        public int type;
        [Required]
        [Display(Name="Story")]
        public string story;
        [Display(Name="Name of story")]
        public string name;
    }
    public class StoryUserRelationship
    {
        public Guid id { get; set; }
        public Guid userId { get; set;}
        public Guid storyId { get; set; }
    }
}