using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryERP.Domain;

namespace InvertoryERP.Core.Domain
{
    public class BlogContent : Entity, IAggregateRoot
    {
        public string Title { get; set; }
        public DateTime PostedOn { get; set; }
        public string Tags { get; set; }
        public string Content { get; set; }

        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public BlogCategory BlogCategory { get; set; }
    }
}
