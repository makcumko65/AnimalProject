using Domain.Common;
using Domain.Models;
using System;

namespace Application.DTO
{
    public class ProcessingDto : AnimalBase
    {
        public ProcessingDto(Processing proccessing, DateTime processingDate, DateTime nextProcessingDate)
        {
            Id = proccessing.Id;
            Type = proccessing.Type;
            ProcessingDate = processingDate;
            NextProcessingDate = nextProcessingDate;
        }
        public long Id { get; set; }
        public string Type { get; set; }
        public DateTime ProcessingDate { get; set; }
        public DateTime NextProcessingDate { get; set; }
    }
}
