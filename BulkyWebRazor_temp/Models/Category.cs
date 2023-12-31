﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyWebRazor_temp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } //primary key, if we have Id/CategoryId the annotation is not required
        [Required]
        [MaxLength(20)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "The field Display Order must be between 1-100!")]
        public int DisplayOrder { get; set; }


    }
}
