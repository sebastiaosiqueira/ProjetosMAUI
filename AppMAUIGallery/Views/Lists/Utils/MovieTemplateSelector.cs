

using AppMAUIGallery.Views.Lists.Models;

namespace AppMAUIGallery.Views.Lists.Utils
{
   public  class MovieTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TemplateDefault { get; set; }
        public DataTemplate TemplateLongMovie { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Movie movie = (Movie)item;

            return (movie.Duration.Hours>1) ? TemplateLongMovie : TemplateDefault;
        }
    }
}
