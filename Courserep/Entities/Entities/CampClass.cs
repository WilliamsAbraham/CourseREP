using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
     public class CampClass
    {
        [Column("CampClassId")]
        public int Id { get; set; }
        public string Name { get; set; }
        public CampClassType Type { get; set; } = CampClassType.Internal;
        public string Description { get; set; }

        public  Repo Repo { get; set; }
        public Member Member { get; set; }

        [ForeignKey(nameof(Camp))]
        public int CampId { get; set; }
        public Camp Camp { get; set; }


    }

    public enum CampClassType {Internal,External}
}
