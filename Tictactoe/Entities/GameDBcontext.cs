using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;
using Tictactoe.Entities;


namespace Tictactoe.Entities

{

    public class GameDBcontext : DbContext
    {

        public GameDBcontext(DbContextOptions options) : base(options)
        { 
        }


        public DbSet<Game> Games { get; set; }




    }





    


}


