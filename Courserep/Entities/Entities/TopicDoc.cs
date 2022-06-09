using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class TopicDoc
    {
        [Column("TopicDocId")]
        public int Id { get; set; }
        public string Topic { get; set; }
        public TopicDocType Type { get; set; }
        public string File { get; set; }
        public DateTime Created { get; set; }

        [ForeignKey(nameof(Repo))]
        public int RepoId { get; set; }
        public Repo Repo { get; set; }
        [ForeignKey(nameof(User))]
        public User User { get; set; }

        public ICollection<Contribution> Contributions { get; set; }

    }

    public enum TopicDocType { Note, Question}
}
