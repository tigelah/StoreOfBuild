using StoredOfBuild.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoredOfBuild.Domain.Products
{
    public class CategoryStorer
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryStorer(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Store(CategoryDTO dto)
        {
            var category = _categoryRepository.GetById(dto.Id);

            if (category == null)
            {
                category = new Category(dto.Name);
                _categoryRepository.Save(category); 
            }
            else
            {
                category.Update(dto.Name);
            }
        }
    }
}
