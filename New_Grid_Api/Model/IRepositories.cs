using New_Grid_Api.DTOs;

namespace New_Grid_Api.Model;
public interface IRepositories
{
    public bool PostDetails(Product product);
    public IEnumerable<ProductDTO> GetDetails();
     public bool DeleteDetails(Product product);
     public bool UpdateDetails(Product product);

}