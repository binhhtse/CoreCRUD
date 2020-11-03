using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public interface IDepartmentRepository : IGenericRepository<Department>
    {
        Department Get(int depId);
    }
}
