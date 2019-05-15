using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TyperAPI.DAL.Repositories;
using TyperAPI.Shared.Enums;

namespace TyperAPI.DAL.Models
{
    public class Word: Entitybase
    {
        [JsonProperty(PropertyName = "Value")]
        [DefaultValue("")]
        public string WordValue { get; set; }

        [Range(0, 3)]
        [DefaultValue(Category.None)]
        [JsonProperty(PropertyName = "Category")]
        public Category Category { get; set; }

        [DefaultValue(Country.US)]
        [JsonProperty(PropertyName = "Language")]
        public Country Language { get; set; }

        public int Point { get; set; }
    }
}
