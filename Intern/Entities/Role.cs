﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Intern.Entities
{
    [Table("Roles")]
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; } 

        [MaxLength(20)]
        public string RoleCode { get; set; }
        [MaxLength(100)]
        public string RoleDetail { get; set; }

        public List<Account> Accounts { get; set; }
    }
}
