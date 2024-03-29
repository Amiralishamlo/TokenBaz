﻿using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Domain.ProductAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository;

public class ProductRepository : RepositoryBase<long, Product>, IProductRepository
{
    private readonly ShopContext _context;

    public ProductRepository(ShopContext context) : base(context)
    {
        _context = context;
    }

    public EditProduct GetDetails(long id)
    {
        return _context.Products.Select(x => new EditProduct
        {
            Id = x.Id,
            Name = x.Name,
            Code = x.Code,
            Slug = x.Slug,
            CategoryId = x.CategoryId,
            Description = x.Description,
            Keywords = x.Keywords,
            MetaDescription = x.MetaDescription,
            PictureAlt = x.PictureAlt,
            PictureTitle = x.PictureTitle,
            ShortDescription = x.ShortDescription,
            Addres=x.Addres,
            Application=x.Application,
            BazarTeteri=x.BazarTeteri,
            Email=x.Email,
            GhabeliatTabdilMogodiKochak= x.GhabeliatTabdilMogodiKochak,
            hadAksarZamanHoviat= x.hadAksarZamanHoviat,
            HadForosh=x.HadForosh,
            HadKharid=x.HadKharid,
            Information = x.Information,
            KarmozdBazarToman = x.KarmozdBazarToman,
            KifPolEkhtesasi = x.KifPolEkhtesasi,
            NaghdBaresi = x.NaghdBaresi,
            noSarafi = x.noSarafi,
            PayePoly = x.PayePoly,
            Phone = x.Phone,
            PoshtibaniShabake= x.PoshtibaniShabake,
            SystemDaramadZayi = x.SystemDaramadZayi,
            Tasvie= x.Tasvie,
            TedadKarmand = x.TedadKarmand,
            TolSarafi = x.TolSarafi,
            TwoLogin= x.TwoLogin,
            Url = x.Url,
        }).FirstOrDefault(x => x.Id == id);
    }

    public List<ProductViewModel> GetProducts()
    {
        return _context.Products.Select(x => new ProductViewModel
        {
            Id = x.Id,
            Name = x.Name,
            Picture = x.Picture,
            Slug = x.Slug,
        }).ToList();
    }

    public Product GetProductWithCategory(long id)
    {
        return _context.Products.Include(x => x.Category).FirstOrDefault(x => x.Id == id);
    }

    public List<ProductViewModel> Search(ProductSearchModel searchModel)
    {
        var query = _context.Products
            .Include(x => x.Category)
            .Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Category = x.Category.Name,
                CategoryId = x.CategoryId,
                Code = x.Code,
                Picture = x.Picture,
                CreationDate = x.CreationDate.ToFarsi()
            });

        if (!string.IsNullOrWhiteSpace(searchModel.Name))
            query = query.Where(x => x.Name.Contains(searchModel.Name));

        if (!string.IsNullOrWhiteSpace(searchModel.Code))
            query = query.Where(x => x.Code.Contains(searchModel.Code));

        if (searchModel.CategoryId != 0)
            query = query.Where(x => x.CategoryId == searchModel.CategoryId);

        return query.OrderByDescending(x => x.Id).ToList();
    }
}