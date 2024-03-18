using _0_Framework.Domain;
using ShopManagement.Domain.ProductCategoryAgg;

namespace ShopManagement.Domain.ProductAgg;

public class Product : EntityBase
{
    public Product(string name, string code, string shortDescription, string description,
        string picture, string pictureAlt, string pictureTitle, long categoryId, string slug,
        string keywords, string metaDescription, string noSarafi, string hadAksarZamanHoviat, string tolSarafi, string tedadKarmand, string karmozdBazarToman, bool bazarTeteri, string hadKharid, string hadForosh, bool kifPolEkhtesasi, bool ghabeliatTabdilMogodiKochak, bool systemDaramadZayi, bool twoLogin, bool application, string information, string payePoly, string poshtibaniShabake, string tasvie, string email, string phone, string addres, string naghdBaresi, string url)
    {
        Name = name;
        Code = code;
        ShortDescription = shortDescription;
        Description = description;
        Picture = picture;
        PictureAlt = pictureAlt;
        PictureTitle = pictureTitle;
        CategoryId = categoryId;
        Slug = slug;
        Keywords = keywords;
        MetaDescription = metaDescription;
        this.noSarafi = noSarafi;
        this.hadAksarZamanHoviat = hadAksarZamanHoviat;
        TolSarafi = tolSarafi;
        TedadKarmand = tedadKarmand;
        KarmozdBazarToman = karmozdBazarToman;
        BazarTeteri = bazarTeteri;
        HadKharid = hadKharid;
        HadForosh = hadForosh;
        KifPolEkhtesasi = kifPolEkhtesasi;
        GhabeliatTabdilMogodiKochak = ghabeliatTabdilMogodiKochak;
        SystemDaramadZayi = systemDaramadZayi;
        TwoLogin = twoLogin;
        Application = application;
        Information = information;
        PayePoly = payePoly;
        PoshtibaniShabake = poshtibaniShabake;
        Tasvie = tasvie;
        Email = email;
        Phone = phone;
        Addres = addres;
        NaghdBaresi = naghdBaresi;
        Url = url;
    }

    public string Name { get; private set; }
    public string Code { get; private set; }
    public string ShortDescription { get; private set; }
    public string Description { get; private set; }
    public string Picture { get; private set; }
    public string PictureAlt { get; private set; }
    public string PictureTitle { get; private set; }
    public long CategoryId { get; private set; }
    public string Slug { get; private set; }
    public string Keywords { get; private set; }
    public string MetaDescription { get; private set; }
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

    public ProductCategory Category { get; private set; }

    public void Edit(string name, string code, string shortDescription, string description,
        string picture, string pictureAlt, string pictureTitle, long categoryId, string slug,
        string keywords, string metaDescription, string noSarafi, string hadAksarZamanHoviat, string tolSarafi, string tedadKarmand, string karmozdBazarToman, bool bazarTeteri, string hadKharid, string hadForosh, bool kifPolEkhtesasi, bool ghabeliatTabdilMogodiKochak, bool systemDaramadZayi, bool twoLogin, bool application, string information, string payePoly, string poshtibaniShabake, string tasvie, string email, string phone, string addres, string naghdBaresi, string url)
    {
        TolSarafi = tolSarafi;
        TedadKarmand = tedadKarmand;
        KarmozdBazarToman = karmozdBazarToman;
        BazarTeteri = bazarTeteri;
        HadKharid = hadKharid;
        HadForosh = hadForosh;
        KifPolEkhtesasi = kifPolEkhtesasi;
        GhabeliatTabdilMogodiKochak = ghabeliatTabdilMogodiKochak;
        SystemDaramadZayi = systemDaramadZayi;
        TwoLogin = twoLogin;
        Application = application;
        Information = information;
        PayePoly = payePoly;
        PoshtibaniShabake = poshtibaniShabake;
        Tasvie = tasvie;
        Email = email;
        Phone = phone;
        Addres = addres;
        NaghdBaresi = naghdBaresi;
        Url = url;
        Name = name;
        Code = code;
        ShortDescription = shortDescription;
        Description = description;

        if (!string.IsNullOrWhiteSpace(picture))
            Picture = picture;

        PictureAlt = pictureAlt;
        PictureTitle = pictureTitle;
        CategoryId = categoryId;
        Slug = slug;
        Keywords = keywords;
        MetaDescription = metaDescription;
    }
}