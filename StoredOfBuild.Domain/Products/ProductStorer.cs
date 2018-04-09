using StoredOfBuild.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoredOfBuild.Domain.Products
{
    public class ProductStorer
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Category> _categoryRepository;

        public ProductStorer(IRepository<Product> productRepository, IRepository<Category> categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public void Store(ProductDTO dto)
        {
            var category = _categoryRepository.GetById(dto.Categoryid);
            DomainException.When(category == null, "Categoria não existe ou invalida.");

            var product = _productRepository.GetById(dto.Id);
            if (product == null)
            {
                product = new Product(dto.Name, category, dto.Price, dto.StockQuantity);
                _productRepository.Save(product);
            }
            else
            {
                product.Update(dto.Name, category, dto.Price, dto.StockQuantity);
            }
        }
    }
}
