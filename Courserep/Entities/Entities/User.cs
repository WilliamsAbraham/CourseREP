using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class User
    {
        [Column("UserId")]
        public   Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }

        public ICollection<Message> Messages { get; set; }
        public ICollection<Camp> Camps { get; set; }
        public ICollection<CampClass> CampClasses { get; set; }
        public ICollection<Friend> Friends { get; set; }




    }
}
