using LMAK301.Entidades;
using System.Data.Entity;

namespace LMAK301
{
    public class DataContext:DbContext 
    {
        public DbSet<Student> Students { get; set; } 
        public DataContext():base("name=miConexion")
        {
        }
    }
}
