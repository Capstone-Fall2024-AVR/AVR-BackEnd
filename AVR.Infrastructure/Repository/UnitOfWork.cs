using AVR.Domain.Interfaces;
using AVR.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private MyDbContext _context = new MyDbContext();
    }
}
