using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(DataBaseContext context) : base(context)
        {
        }
        public Department Get(int Id)
        {
            var query = GetAll().FirstOrDefault(b => b.ID == Id);
            return query;
        }
    }
}
