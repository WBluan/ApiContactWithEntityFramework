using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Context
{
    //Classe que realiza a conexão com o banco de dados, 
    //recebe a herança do DbContext para ter acesso aos seus métodos e propriedades 
    public class ScheduleContext : DbContext
    {
        // Recebe um options em seu contrutor e passa para a classe DbContext
        public ScheduleContext(DbContextOptions<ScheduleContext> options) : base(options)
        {

        }

        //Precisamos vincular a entidade no DbSet para ser identificado como tabela
        public DbSet<Contact> Contact {get; set;}

    }
}