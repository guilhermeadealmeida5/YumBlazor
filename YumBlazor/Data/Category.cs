﻿using System.ComponentModel.DataAnnotations;

namespace YumBlazor.Data
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor, forneça o nome")]
        public string Name { get; set; }
    }
}
