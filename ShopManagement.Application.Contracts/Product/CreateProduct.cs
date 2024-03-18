using _0_Framework.Application;
using Microsoft.AspNetCore.Http;
using ShopManagement.Application.Contracts.ProductCategory;
using System.ComponentModel.DataAnnotations;

namespace ShopManagement.Application.Contracts.Product;

public class CreateProduct
{
    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Name { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Code { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string ShortDescription { get; set; }

    public string Description { get; set; }
    public IFormFile Picture { get; set; }
    public string PictureAlt { get; set; }
    public string PictureTitle { get; set; }

    [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequired)]
    public long CategoryId { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Slug { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string Keywords { get; set; }

    [Required(ErrorMessage = ValidationMessages.IsRequired)]
    public string MetaDescription { get; set; }
    public string noSarafi { get; set; }
    public string hadAksarZamanHoviat { get; set; }
    public string TolSarafi { get; set; }
    public string TedadKarmand { get; set; }
    public string KarmozdBazarToman { get; set; }
    public bool BazarTeteri { get; set; }
    public string HadKharid { get; set; }
    public string HadForosh { get; set; }
    public bool KifPolEkhtesasi { get; set; }
    public bool GhabeliatTabdilMogodiKochak { get; set; }
    public bool SystemDaramadZayi { get; set; }
    public bool TwoLogin { get; set; }
    public bool Application { get; set; }
    public string Information { get; set; }
    public string PayePoly { get; set; }
    public string PoshtibaniShabake { get; set; }
    public string Tasvie { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Addres { get; set; }
    public string NaghdBaresi { get; set; }
    public string Url { get; set; }

    public List<ProductCategoryViewModel> Categories { get; set; }
}