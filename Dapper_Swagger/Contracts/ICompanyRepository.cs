﻿using Dapper_Swagger.Dto;
using Dapper_Swagger.Dto.Dapper_EMS.Dto;
using Dapper_Swagger.Entities;

namespace Dapper_Swagger.Contracts
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
        public Task<Company> GetCompany(int id);

        public Task<Company> CreateCompany(CompanyForCreationDto company);

        public Task UpdateCompany(int id, CompanyForUpdateDto company);
        public Task DeleteCompany(int id);
    }
}
