using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryERP.Domain;

namespace InvertoryERP.Core.Domain
{
    public class PropertyDetails : Entity, IAggregateRoot
    {
        [Required]
        public virtual string Unit { get; set; }
        [Display(Name = "House Number")]
        [Required]
        public virtual string StreetAddress1 { get; set; }
        [Display(Name = "Street Name")]
        public virtual string StreetAddress2 { get; set; }
        [Display(Name = "Hide Street Address")]
        public virtual bool IsHideStreetAddress { get; set; }
        [Display(Name = "Hide Street View")]
        public virtual bool IsHideStreetView { get; set; }
        public virtual string Suberb { get; set; }
        public virtual string Municipility { get; set; }
        public virtual Propertys Property { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
