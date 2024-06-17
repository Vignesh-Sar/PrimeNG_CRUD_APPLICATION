using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.VisualBasic;
using New_Grid_Api.Data;
using New_Grid_Api.DTOs;

namespace New_Grid_Api.Model;
public class Repositories:IRepositories
{
    public readonly DataContext _dataContext;
    public IMapper mapper;
  
    public Repositories(DataContext dataContext,IMapper _mapper)
    {
       _dataContext= dataContext;
       mapper=_mapper;
       
    }
    
    public bool PostDetails(Product product)
    {

           if(product!=null)
           {
           _dataContext.Add(product);
           _dataContext.SaveChanges();
           return true;
           }
           else
           {
            return false;
           }
    }
    public IEnumerable<ProductDTO> GetDetails()
    {
         var product=_dataContext.product_Details.ToList();
         var productDto=mapper.Map<IEnumerable<ProductDTO>>(product);
         System.Text.Json.JsonSerializer.Serialize(productDto);
         return productDto;
        
    }
    public bool DeleteDetails(Product product)
    {
        if(product!=null)
        {
            _dataContext.Remove(product);
            _dataContext.SaveChanges();
            return true;
        }
        return false;
    }
    public bool UpdateDetails(Product product)
    {
        if(product!=null)
        {
            _dataContext.Update(product);
            _dataContext.SaveChanges();
            return true;
        }
        return false;
    }


}