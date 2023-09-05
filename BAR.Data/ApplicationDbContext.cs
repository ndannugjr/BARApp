using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BAR.Data
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string basePath = AppContext.BaseDirectory;
            string databaseFolderPath = System.IO.Path.Combine(basePath, "DB");
            if (!System.IO.Directory.Exists(databaseFolderPath))
            {
                System.IO.Directory.CreateDirectory(databaseFolderPath);
            }

            string databaseSourcePath = "DataSource=" + System.IO.Path.Combine(databaseFolderPath, "BarDB1.db");

            optionsBuilder.UseSqlite(databaseSourcePath);

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserActivityLog> UserActivityLogs { get; set; }
        public  DbSet<MenuNavigation>  MenuNavigations { get; set; }
        public DbSet<ActivityHeader> ActivityHeader { get; set; }
        public DbSet<ActivityDescription> ActivityDescription { get; set; }
        public DbSet<ActivityQuestions> ActivityQuestions { get; set; }
        public DbSet<ActivityVoiceNonVoiceDetails> ActivityVoiceNonVoiceDetails { get; set; }
        public DbSet<AnswerSheet> AnswerSheet { get; set; }

    }
}
