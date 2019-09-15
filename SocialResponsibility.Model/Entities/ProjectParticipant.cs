using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialResponsibility.Model.Entities
{
   public class ProjectParticipant
    {
        [Key, ForeignKey("AppUser"), Column(Order =10)]
        public string UserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        [Key, ForeignKey("Activity"), Column(Order =20)]
        public int ActivityId { get; set; }
        public virtual Project Activity { get; set; }
    }
}
