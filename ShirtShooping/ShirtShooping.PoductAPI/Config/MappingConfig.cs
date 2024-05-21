using AutoMapper;
using ShirtShooping.PoductAPI.Data.ValueObjects;
using ShirtShooping.PoductAPI.Model;

namespace ShirtShooping.PoductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;
        }
    }
}
