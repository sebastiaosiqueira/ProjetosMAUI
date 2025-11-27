using AppMAUIGallery.Models;
using AppMAUIGallery.Views.Components.Forms;
using AppMAUIGallery.Views.Components.Mains;
using AppMAUIGallery.Views.Components.Visuals;
using AppMAUIGallery.Views.Layouts;
using System.IO;

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
            categories.Add(new Category()
            {
                Name = "Componentes (Views)",
                Components = new List<Component>
                    {
                        new Component
                        {
                            Title ="BoxView",
                           Description = "Um componente que cria uma caixa para se apresentada",
                           Page =typeof (BoxViewPage)
                        },
                        new Component
                        {
                            Title="Label",
                            Description = "Apresenta um texto na tela",
                            Page=typeof (LabelPage)
                        },
                        new Component {
                           Title="Button",
                           Description ="Apresenta um botão na tela",
                           Page=typeof (ButtonPage)
                        },
                        new Component {
                           Title="Image",
                           Description ="Apresenta uma imagem na tela",
                           Page=typeof (ImagePage)
                        },
                        new Component {
                           Title="ImageButton",
                           Description ="Cria uma caixa de marcaçao",
                           Page=typeof (ImageButtonPage)
                        }
                       

                    }
            });
            categories.Add(new Category
            {
                Name = "Visuais",
                Components = new List<Component>
                {
                    new Component {
                        Title = "Frame",
                        Description = "Caixa que envolve outros elementos.",
                        Page = typeof(FramePage)
                    },               
                    new Component
                    {
                    Title="Border",
                    Description = "Caixa que envolve outro elemento",
                    Page=typeof (BorderPage)
                    },
                     new Component
                    {
                    Title="Shadow",
                    Description = "Adiciona uma sombra ao elemento",
                    Page=typeof (ShadowPage)
                    }
                 },
            });
            categories.Add(new Category
            {
                Name = "Formularios",
                Components = new List<Component>
                {
                    new Component {
                        Title = "Entry",
                        Description = "Ele cria uma caixa de entrada de texto.",
                        Page = typeof(EntryPage)
                    },
                    new Component{
                        Title="Edit",
                        Description= "Recebe uma quantidade maior de caracteres",
                        Page=typeof (EditorPage)
                    },
                   new Component{
                        Title="Checkbox",
                        Description= "Cria uma caixa de marcação",
                        Page=typeof (CheckBoxPage)
                    },
                    new Component {
                            Title="RadioButton",
                            Description="Seleciona um unico item",
                            Page=typeof(RadionbuttonPage)
                        }
                 },
            });


            return categories;

        }
    }
}
