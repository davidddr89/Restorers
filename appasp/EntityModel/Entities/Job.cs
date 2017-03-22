using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel.Entities
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public string JobName { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string PathImageBefore { get; set; }
        public string PathImageAfter { get; set; }
        public string Description { get; set; }
    }
}
