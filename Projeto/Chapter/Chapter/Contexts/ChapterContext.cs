
using Microsoft.EntityFrameworkCore;
using Chapter.Models;

namespace Chapter.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {

        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {

        }

        //vamo utilizar esse método para configurar o banco de dados

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-7OK0DV8\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
            
       
        }
        //dbset

        public DbSet<Livro> Livros { get; set; }
    }


}