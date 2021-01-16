using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserManagement.Entities
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public String FirstName { get; set; }

        [StringLength(50)]
        [Required]
        public String LastName { get; set; }

        [Required]
        public int Age { get; set; }
    }
}
