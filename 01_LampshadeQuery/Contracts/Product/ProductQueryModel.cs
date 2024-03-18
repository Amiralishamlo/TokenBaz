namespace _01_LampshadeQuery.Contracts.Product;

public class ProductQueryModel
{
    public long Id { get; set; }
    public string Picture { get; set; }
    public string PictureAlt { get; set; }
    public string PictureTitle { get; set; }
    public string Name { get; set; }
    public double DoublePrice { get; set; }
    public string Price { get; set; }
    public string PriceWithDiscount { get; set; }
    public int DiscountRate { get; set; }
    public string Category { get; set; }
    public string CategorySlug { get; set; }
    public bool HasDiscount { get; set; }
    public string DiscountExpireDate { get; set; }
    public string Code { get; set; }
    public string ShortDescription { get; set; }
    public string Slug { get; set; }
    public string Description { get; set; }
    public string Keywords { get; set; }
    public string MetaDescription { get; set; }
    public bool IsInStock { get; set; }
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
}