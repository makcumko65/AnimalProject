using Application.DTO;
using AutoMapper;
using Domain.Models;
using System.Linq;

namespace Application.Mapper
{
    public class AnimalMapper : Profile
    {
        public AnimalMapper()
        {
            CreateMap<Animal, AnimalDto>()
                .ForMember(an => an.Needs, a => a.MapFrom(c => c.AnimalNeeds.Select(x => x.Needs)))
                .ForMember(an => an.Attitudes, a => a.MapFrom(c => c.AnimalAttitudes.Select(x => new AttitudeToDto(x.AttitudeTo, x.Mark))))
                .ForMember(an => an.Defects, a => a.MapFrom(c => c.AnimalDefects.Select(x => x.Defect)))
                .ForMember(an => an.Keepings, a => a.MapFrom(c => c.AnimalKeepings.Select(x => x.Keeping)))
                .ForMember(an => an.Processings, a => a.MapFrom(c => c.AnimalProcessings.Select(x => new ProcessingDto(x.Processing
                                                                                , x.ProcessingDate, x.NextProcessingDate))))
                .ForMember(an => an.Vaccinations, a => a.MapFrom(c => c.AnimalVaccinations.Select(x => new VaccinationDto(x.Vaccination
                                                                                , x.VaccinationDate, x.NextVaccinationDate))));

            CreateMap<NeedsDto, Needs>();
            CreateMap<Needs, NeedsDto>();

            CreateMap<KeepingDto, Keeping>();
            CreateMap<Keeping, KeepingDto>();

            CreateMap<Vaccination, VaccinationDto>();

            CreateMap<AttitudeTo, AttitudeToDto>();
            CreateMap<AttitudeToDto, AttitudeTo>();

            CreateMap<ProcessingDto, Processing>();
            CreateMap<Processing, ProcessingDto>();

            CreateMap<DefectDto, Defect>();
            CreateMap<Defect, DefectDto>();
        }
    }
}
