using System;
using System.Collections.Generic;
using System.Text;

namespace StoredOfBuild.Domain.Products
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Category Category { get; private set; }
        public decimal Price { get; private set; }

        public int StockQuantity { get; private set; }

        public Product(string name, Category category, decimal price, int stockQuantity)
        {
            ValidateValues(name, category, price, stockQuantity);
            SetProperties(name, category, price, stockQuantity);

        }

        private void SetProperties(string name, Category category, decimal price, int stockQuantity)
        {
            Name = name;
            Category = category;
            Price = price;
            StockQuantity = stockQuantity;
        }

        private static void ValidateValues(string name, Category category, decimal price, int stockQuantity)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Nome é obrigatório.");
            DomainException.When(category == null, "Categoria é obrigatório.");
            DomainException.When(price < 0, "Preço não pode ser menor que 0.");
            DomainException.When(stockQuantity < 0, "Estoque não pode ser menor que 0.");
        }

        public void Update(string name, Category category, decimal price, int stockQuantity)
        {
            ValidateValues(name, category, price, stockQuantity);
            SetProperties(name, category, price, stockQuantity);
        }
    }
}
