using System.Data;
using AutoMapper;
using ClassLibrary;

namespace WebApplication.App_Start
{
    public class AutoMapperConfig
    {
        public static void Register()
        {
            Mapper.Initialize(cfg =>
            {
                //cfg.CreateMap<IDataReader, IList<Customer>>(); /*If source and destination object have same propery */
                //.ForMember(dest => dest.CustomerID, opt => opt.MapFrom(src =>  (int)src["CustomerID"]))
                //.ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => (string)src["FirstName"]))
                //.ForMember(dest => dest.LastName, opt => opt.MapFrom(src => (string)src["LastName"]));

                //cfg.CreateMap<source, destination>()
                // .ForMember(dest => dest.dId, opt => opt.MapFrom(src => src.sId)); /*If source and destination object haven't same property, you need do define which property refers to source property */
                cfg.CreateMap<IDataRecord, Customer>()
                    .ForMember(source => source.CustomerID, source => source.MapFrom(s => s.GetValue(s.GetOrdinal("CustomerID"))))
                    .ForMember(dest => dest.FirstName, source => source.MapFrom(s => s.GetValue(s.GetOrdinal("FirstName"))))
                    .ForMember(dest => dest.LastName, source => source.MapFrom(s => s.GetValue(s.GetOrdinal("LastName"))));
            });

            Mapper.AssertConfigurationIsValid();
        }
    }
}