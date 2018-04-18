﻿using StoredOfBuild.Domain;
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

        public void Store(int id, string name)
        {
            var category = _categoryRepository.GetById(id);

            if (category == null)
            {
                category = new Category(name);
                _categoryRepository.Save(category);
            }
            else
                category.Update(name);
        }
    }
}