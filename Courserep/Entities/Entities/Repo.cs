using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Repo
    {
        [Column("RepoId")]
        public int Id { get; set; }
        public CampClass CampClass { get; set; }
    }
}
