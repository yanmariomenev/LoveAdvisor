namespace LoveAdvisor.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using LoveAdvisor.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Tips = new HashSet<Tip>();
        }

        [Required]
        public string Name { get; set; }

        public string Image { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public ICollection<Tip> Tips { get; set; }
    }
}
