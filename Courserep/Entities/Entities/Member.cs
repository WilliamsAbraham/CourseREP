using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Member
    {
        [Column("MemberId")]
        public int Id { get; set; }
        public MemberType Type { get; set; }

        [ForeignKey(nameof(CampClass))]
        public int CampClassId { get; set; }
        public CampClass CampClass { get; set; }
    }

    public enum MemberType { Admin, Regular}
}
