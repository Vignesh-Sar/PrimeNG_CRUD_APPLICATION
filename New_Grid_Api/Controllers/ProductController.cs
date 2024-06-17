using Microsoft.AspNetCore.Mvc;
using New_Grid_Api.Model;

namespace New_Grid_Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    
    public readonly IRepositories repositories;
    
    public ProductController(IRepositories _repositories)
    {
        repositories=_repositories;
    }

    [HttpPost("CreateAPI")]
    public async Task<IActionResult> EnterDetails(Product product)
    {
        if(product!=null)
        {
             repositories.PostDetails(product);
             return Ok();
        }
        return BadRequest();

    } 
    [HttpGet("GetAPI")]
    public async Task<IActionResult> GetDetails()
    {
        
        var response=repositories.GetDetails();
       
        return Ok(response);
    }
    [HttpDelete("DeleteAPI")]
    public async Task<IActionResult> DeleteValues(Product product)
    {
        if(product!=null){
        repositories.DeleteDetails(product);
        return Ok();
        }
        return BadRequest();
    }
    [HttpPut("UpdateAPI")]
    public async Task<IActionResult> UpdateValues(Product product)
    {
        if(product!=null)
        {
            repositories.UpdateDetails(product);
            return Ok();
        }
        return BadRequest();
    }


   
}
