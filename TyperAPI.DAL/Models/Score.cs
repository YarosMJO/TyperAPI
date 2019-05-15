using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using TyperAPI.DAL.Repositories;

namespace TyperAPI.DAL.Models
{
    public class Score : Entitybase
    {
        [Range(0, 9999)]
        [DefaultValue(0)]
        [JsonProperty(PropertyName = "Score")]
        public int UserScore { get; set; }

        [JsonProperty(PropertyName = "Date")]
        public DateTime ScoreDateTime { get; set; }

        public User User { get; set; }
    }

}
