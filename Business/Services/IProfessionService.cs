using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Business.DTO.ProfessionDtos;
using Api.Core.Entities;

namespace Api.Business.Services
{
    public interface IProfessionService
    {
        Task CreateAsync([FromForm] ProfessionCreateDto professionCreateDto);
        Task Delete(int id);
        Task ToggleDelete(int id);
        Task<ProfessionGetDto> GetByIdAsync(int id);
        Task<IEnumerable<ProfessionGetDto>> GetAllAsync();
        Task UpdateAsync([FromForm] ProfessionUpdateDto professionUpdateDto);
    }
}
