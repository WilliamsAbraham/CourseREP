using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Camp
    {
        [Column("CampId")]
        public int Id { get; set; }
        public string Name { get; set; }
        public Member Member { get; set; }
        public Repo Repo { get; set; }

        public ICollection<CampClass> CampClasses { get; set; }

    }
}
