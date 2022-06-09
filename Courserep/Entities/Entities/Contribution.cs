using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Contribution
    {
        public int Id { get; set; }
        public ContributionType Type { get; set; }
      
        public string File { get; set; }
    }
     
    public enum ContributionType {Video,Picture,PDF,VoiceNote}
}
