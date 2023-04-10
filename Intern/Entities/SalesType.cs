﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Intern.Entities
{
    [Table("SalesTypes")]
    public class SalesType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesTypeId { get; set; } 

        [MaxLength(20)]
        public string SalesTypeCode { get; set; }
        [MaxLength(100)]
        public string SalesTypeDetail { get; set; }

        public List<Sales> Sales { get; set; }
    }
}
