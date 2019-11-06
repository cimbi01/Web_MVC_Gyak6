using Gyak6.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Gyak6.Data_Access_Layer
{
    public class RandomModelContext : DbContext
    {
        public RandomModelContext() : base("RandomModelContextConnectionString")
        {}
        public DbSet<RandomModel> RandomModels { get; set; }

    }
}