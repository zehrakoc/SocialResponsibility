using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialResponsibility.Model.Entities
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        
        public string ProjectName { get; set; }
        
        public string ProjectDetail { get; set; }
        [MaxLength (255)]
        public string Location { get; set; }

        
        public string ImagePath { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime AddedDate { get; set; } = DateTime.Now;
       
        public bool IsActive { get; set; } = true;

        public virtual ICollection<ProjectParticipant> ProjectParticipants { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}

