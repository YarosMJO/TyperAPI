using System;
namespace TyperAPI.Shared.Dtos
{
    public class ScoreDto
    {
        public int Id { get; set; }
        public int UserScore { get; set; }
        public DateTime ScoreDateTime { get; set; }
        public int User { get; set; }
    }
}