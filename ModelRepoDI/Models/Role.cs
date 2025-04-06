﻿using System.ComponentModel.DataAnnotations;

namespace ModelRepoDI.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string RoleName { get; set; }
    }
}
