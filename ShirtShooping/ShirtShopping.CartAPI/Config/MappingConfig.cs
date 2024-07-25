using AutoMapper;
using ShirtShopping.CartAPI.Model;

namespace ShirtShooping.CartAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                //config.CreateMap<ProductVO, Product>();
                //config.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;
        }
    }
}
