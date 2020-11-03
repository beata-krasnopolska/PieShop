using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Model
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit pies", Description="With fruits"},
                new Category{CategoryId=2, CategoryName="Cheese cake", Description= "With cheese"},
                new Category{CategoryId=2, CategoryName="Seasonal", Description= "Seasonal cheese"}
            };
    }
}
