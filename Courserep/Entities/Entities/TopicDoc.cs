using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class TopicDoc
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public TopicDocType Type { get; set; }
        public string File { get; set; }
        public DateTime Created { get; set; }
    }

    public enum TopicDocType { Note, Question}
}
