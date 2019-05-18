using System;
using System.Collections.Generic;
using TyperAPI.DAL.Models;
using TyperAPI.Shared.Enums;

namespace TyperAPI.DAL.Repositories
{
    public class Seeder
    {
        public readonly List<User> Users = new List<User>()
        {
            new User()
            {
                Name = "Ivan",
                Scores = new List<Score>()
                {
                    new Score()
                    {
                        UserScore = 2100,
                        ScoreDateTime = DateTime.Now
                    },
                    new Score()
                    {
                        UserScore = 4700,
                        ScoreDateTime = DateTime.Now
                    },
                    new Score()
                    {
                        UserScore = 6500,
                        ScoreDateTime = DateTime.Now
                    },
                    new Score()
                    {
                        UserScore = 3100,
                        ScoreDateTime = DateTime.Now
                    }
                }
            },
            new User()
            {
                Name = "Petro",
                Scores = new List<Score>()
                {
                    new Score()
                    {
                        UserScore = 4250,
                        ScoreDateTime = DateTime.Now
                    },
                    new Score()
                    {
                        UserScore = 4200,
                        ScoreDateTime = DateTime.Now
                    },
                    new Score()
                    {
                        UserScore = 7300,
                        ScoreDateTime = DateTime.Now
                    },
                    new Score()
                    {
                        UserScore = 8200,
                        ScoreDateTime = DateTime.Now
                    }
                }
            },
            new User()
            {
                Name = "Petro",
                Scores = new List<Score>()
                {
                    new Score()
                    {
                        UserScore = 9420,
                        ScoreDateTime = DateTime.Now
                    },
                    new Score()
                    {
                        UserScore = 1500,
                        ScoreDateTime = DateTime.Now
                    },
                    new Score()
                    {
                        UserScore = 4700,
                        ScoreDateTime = DateTime.Now
                    },
                    new Score()
                    {
                        UserScore = 9600,
                        ScoreDateTime = DateTime.Now
                    }
                }
            }
        };

        public readonly List<Word> Words = new List<Word>()
        {
            new Word()
            {
                Category = Category.Sports,
                Language = Country.UA,
                WordValue = "rtrvrbtrbdccd",
                Point = 2,

            },
            new Word()
            {
                Category = Category.Sports,
                Language = Country.UA,
                WordValue = "uythtr",
                Point = 3,

            },
            new Word()
            {
                Category = Category.Traveling,
                Language = Country.PL,
                WordValue = "mgghmhgmhg",
                Point = 1,

            },
            new Word()
            {
                Category = Category.None,
                Language = Country.US,
                WordValue = "olloloololo",
                Point = 2,

            },
            new Word()
            {
                Category = Category.Idioms,
                Language = Country.UA,
                WordValue = "hhyyyhy",
                Point = 2,

            },
            new Word()
            {
                Category = Category.Sports,
                Language = Country.US,
                WordValue = "wwwdwdwd",
                Point = 3,

            },
            new Word()
            {
                Category = Category.Traveling,
                Language = Country.UA,
                WordValue = "fsfssvfvdsvdsdsvdsvdsffssf",
                Point = 3,

            },
            new Word()
            {
                Category = Category.Sports,
                Language = Country.US,
                WordValue = "vvvvvv",
                Point = 1,

            },
            new Word()
            {
                Category = Category.Sports,
                Language = Country.UA,
                WordValue = "wqdwdwdw",
                Point = 1,

            },
            new Word()
            {
                Category = Category.Sports,
                Language = Country.PL,
                WordValue = "qwdqwwqdq",
                Point = 1,

            }
        };
    }
}
