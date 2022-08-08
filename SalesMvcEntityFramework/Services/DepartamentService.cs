using SalesMvcEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesMvcEntityFramework.Services
{
    public class DepartamentService
    {
        private readonly SalesMvcEntityFrameworkContext _context;

        public DepartamentService(SalesMvcEntityFrameworkContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList(); ;
        }
    }
}
