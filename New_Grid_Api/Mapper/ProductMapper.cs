using AutoMapper;
using New_Grid_Api.DTOs;
using New_Grid_Api.Model;

namespace New_Grid_Api.Mapper;
public class ProductMapper:Profile
{
    public ProductMapper()
    {
        CreateMap<Product, ProductDTO>();
    }
}