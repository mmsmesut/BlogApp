namespace BlogApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        public int CommentId { get; set; }

        [Column("Comment")]
        [Required]
        [StringLength(1500)]
        public string Comment1 { get; set; }

        public int ArticleId { get; set; }

        public DateTime CreationDate { get; set; }

        [Required]
        [StringLength(200)]
        public string NameSurname { get; set; }

        public int? LikedCount { get; set; }

        public virtual Article Article { get; set; }
    }
}
