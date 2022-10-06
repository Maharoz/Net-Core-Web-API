﻿using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository { 
        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext) 
        {
           
        }

        public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
               FindAll(trackChanges)
               .OrderBy(c => c.Name)
               .ToList();
    }
}
