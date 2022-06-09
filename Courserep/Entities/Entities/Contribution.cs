using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Contribution
    {
        [Column("ContributionId")]
        public int Id { get; set; }
        public ContributionType Type { get; set; }
        public string File { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(TopicDoc))]
        public int TopicDocId { get; set; }
        public TopicDoc TopicDoc { get; set; }

        
    }
     
    public enum ContributionType {Video,Picture,PDF,VoiceNote}
}
