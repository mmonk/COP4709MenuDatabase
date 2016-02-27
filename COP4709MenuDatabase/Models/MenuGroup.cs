﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace COP4709MenuDatabase.Models
{
    public class MenuGroup
    {
        [Key]
        public int MenuGroupID { get; set; }

        [ForeignKey("Menu")]
        public int MenuID { get; set; }

        public virtual Menu Menu { get; set; }

        [Required(ErrorMessage = "A title is required for the menu group")]
        [Display(Name = "Title")]
        public string MenuGroupTitle { get; set; }

        [Display(Name = "Description")]
        public string MenuGroupDescription { get; set; }
    }
}