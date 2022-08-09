using SalesMvcEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMvcEntityFramework.Services
{
    public class DepartamentService
    {
        private readonly SalesMvcEntityFrameworkContext _context;

        public DepartamentService(SalesMvcEntityFrameworkContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync(); ;
        }
    }
}
