using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record CompanyDto {
        public Guid Id { get; init; } 
        public string? Name { get; init; } 
        public string? FullAddress { get; init; }
    }


}
