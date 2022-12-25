
namespace vidu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BLOG")]
    public partial class BLOG
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string NAME { get; set; }

        [StringLength(100)]
        public string CREATOR { get; set; }

        public DateTime? DATE_CREATED { get; set; }

        [StringLength(100)]
        public string EDITOR { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        [Column(TypeName = "ntext")]
        public string CONTENT { get; set; }

        [StringLength(255)]
        public string IMAGE_COVER { get; set; }
    }
}
