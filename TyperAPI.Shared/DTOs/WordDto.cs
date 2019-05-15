using TyperAPI.Shared.Enums;

namespace TyperAPI.Shared.Dtos
{
    public class WordDto
    {
        public int Id { get; set; }
        public string WordValue { get; set; }
        public Category Category { get; set; }
        public Country Language { get; set; }
        public int Point { get; set; }
    }
}
