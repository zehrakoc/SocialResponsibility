using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialResponsibility.Model.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Content { get; set; }
        public DateTime? PostDate { get; set; }

        [ForeignKey("BaseComment")]
        public int? BaseCommentId { get; set; }
        public virtual Comment BaseComment { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual AppUser User { get; set; }

        [ForeignKey("Activity")]
        public int ActivityId { get; set; }
        public virtual Project Activity { get; set; }
    }
}
