using SistemaWebMvcVendedores.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaWebMvcVendedores.Services
{
    public class DepartmentService
    {
        private readonly SistemaWebMvcVendedoresContext _context;

        public DepartmentService(SistemaWebMvcVendedoresContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
