namespace BlogApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Author")]
    public partial class Author
    {
        public int AuthorId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string EmailAdress { get; set; }

        [StringLength(50)]
        public string Explanation { get; set; }

        public bool? Gender { get; set; }

        public int? ImageId { get; set; }

        public int? RoleId { get; set; }

        public bool? IsApproved { get; set; }
    }
}
