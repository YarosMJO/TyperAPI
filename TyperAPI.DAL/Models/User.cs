using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TyperAPI.DAL.Repositories;

namespace TyperAPI.DAL.Models
{
    public class User: Entitybase
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public List<Score> Scores { get; set; }
    }
}
