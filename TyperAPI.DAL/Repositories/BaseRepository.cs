using System;
using System.Collections.Generic;
using System.Text;
using TyperAPI.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TyperAPI.DAL.Repositories
{
    public class BaseRepository
    {
        public TyperContext context;
        public BaseRepository() { }
        public BaseRepository(TyperContext context)
        {
            this.context = context;
            context.Database.Migrate();
            context.Database.EnsureCreated();
            //TODO Seeder.populateData();

        }

    }
}
