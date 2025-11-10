using AppMAUIGallery.Models;
using AppMAUIGallery.Views.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGallery.Repositories
{
    internal class CategoryRepository
    {
        public CategoryRepository() { }
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Component>
                {
                    new Component {
                        Title = "StackLayout",
                        Description = "Organização sequencial do layout",
                        Page =typeof(StackLayoutPage)
                    },
                    new Component {
                        Title="Grid",
                        Description="Organiza os elementos dentro de uma tabela",
                        Page =typeof(GridLayoutPage)
                    },
                    new Component
                    {
                        Title="AbsoluteLayout",
                        Description = "Liberdade total para posicionar e dimensionar os elementos na tela",
                        Page =typeof(AbsoluteLayoutPage)
                    },
                    new Component {
                        Title="FlexLayoutPage",
                        Description="Organiza os elementos de forma sequencial com muitas opções de personalização",
                        Page=typeof(FlaxLayoutPage)
                    }
                }
                });
            return categories;

        }
    }
}
