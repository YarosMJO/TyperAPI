using System.Collections.Generic;

namespace TyperAPI.Shared.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Score> Scores { get; set; }
    }
}
