using System;
using Microsoft.EntityFrameworkCore;

namespace CommunicationQuestions.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Questionnaire> Quiz { get; set; }
    }
}
