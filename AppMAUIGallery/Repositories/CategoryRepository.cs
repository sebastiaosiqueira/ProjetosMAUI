using AppMAUIGallery.Models;
using AppMAUIGallery.Views.Cells;
using AppMAUIGallery.Views.Components.Forms;
using AppMAUIGallery.Views.Components.Mains;
using AppMAUIGallery.Views.Components.Visuals;
using AppMAUIGallery.Views.Layouts;

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
                        },
                     new Component {
                            Title="Swich",
                            Description="Caixa de marcação",
                            Page=typeof(SwichPage)
                        },
                     new Component {
                            Title="Stepper",
                            Description="Cria opções de incrementar e decrementar um número.",
                            Page=typeof(StepperPage)
                        },
                     new Component {
                            Title="Slider",
                            Description="Cria uma barra que incrementa e decrementa um número.",
                            Page=typeof(SliderPage)
                        },
                     new Component {
                            Title="TimePicker",
                            Description="Seleção da  hora e o minuto.",
                            Page=typeof(TimePickerPage)
                        },
                     new Component {
                            Title="DatePicker",
                            Description="Seleção data.",
                            Page=typeof(DatePickerPage)
                        },
                     new Component {
                            Title="Search",
                            Description="Campo de entrada de busca.",
                            Page=typeof(SearchPage)
                        }
                     ,
                     new Component {
                            Title="Picker",
                            Description="Seleciona ym ista da item",
                            Page=typeof(PickerPage)
                        }
                 },
            });
            categories.Add(
                new Category
                {
                    Name = "Celulas",
                    Components = new List<Component>
                    {
                        new Component {
                            Title = "TextCell",
                            Description = "Apresenta até duas labels onde uma e destinada ao titulo e outra a descricao",
                            Page = typeof(TextCellPage)
                        },new Component {
                            Title = "ImagemCell",
                            Description = "Apresenta uma imagem com duas labels onde uma e destinada ao titulo e outra a descricao",
                            Page = typeof(ImageCellPage)
                        },
                        new Component {
                            Title = "SwitchCellPage",
                            Description = "Apresenta uma label em conjunto com switch",
                            Page = typeof(SwitchCellPage)
                        },
                        new Component {
                            Title = "EntryCell",
                            Description = "Apresenta uma label em conjunto entry",
                            Page = typeof(EntryPage)
                        }, new Component {
                            Title = "ViewCell",
                            Description = "Apresenta uma label em conjunto entry",
                            Page = typeof(ViewCellPage)
                        },
                    }

                    });


            return categories;

        }
    }
}
