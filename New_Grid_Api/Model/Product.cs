using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace New_Grid_Api.Model;
public class Product
{
    [Key]
    public string Code{get;set;}=string.Empty;
    public string Name{get;set;}=string.Empty;
    public string Category{get;set;}=string.Empty;
    public int Quantity{get;set;}
}