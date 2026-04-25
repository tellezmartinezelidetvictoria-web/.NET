using CRUD_NET7_MVC.models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace CRUD_NET7_MVC.Datos
{
    public class AplicationDbcontext : DbContext
    {
        public AplicationDbcontext(DbContextOptions<AplicationDbcontext> options) : base(options)
        {
        }
        //models

        public DbSet<Contacto> Contacto { get; set; }
    }
}
