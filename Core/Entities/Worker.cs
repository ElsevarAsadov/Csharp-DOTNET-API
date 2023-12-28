using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Core.Entities
{
    public class Worker : BaseEntity
    {
        public string FullName { get; set; }
        public string Description { get; set; }
        public string SocialMediaUrl { get; set; }
        public double Salary { get; set; }
        public List<WorkerProfession> WorkerProfessions { get; set; }
        [NotMapped]
        public IFormFile ImgFile { get; set; }
        public string? ImgUrl { get; set; }
    }
}
