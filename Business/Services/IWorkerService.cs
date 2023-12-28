using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Business.DTO.WorkerDtos;
using Api.Core.Entities;

namespace Api.Business.Services
{
    public interface IWorkerService
    {
        Task CreateAsync([FromForm]WorkerCreateDto workerCreateDto);
        Task Delete(int id);
        Task ToggleDelete(int id);
        Task<WorkerGetDto> GetByIdAsync(int id);
        Task<IEnumerable<WorkerGetDto>> GetAllAsync(string? input, int? professionId, int? orderId);
        Task UpdateAsync([FromForm] WorkerUpdateDto workerUpdateDto);

    }
}
