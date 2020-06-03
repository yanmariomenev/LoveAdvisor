namespace LoveAdvisor.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using LoveAdvisor.Data.Common.Models;

    public class Tip : BaseDeletableModel<int>
    {
        [Required]
        public string Description { get; set; }

        public string HashTag { get; set; }

        public string Image { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
