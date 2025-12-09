using AppMAUIGallery.Models;
using AppMAUIGallery.Repositories;



namespace AppMAUIGallery.Repositories
{
    public partial class GroupComponentRepository : IGroupComponentRepository
    {
        private List<Component> _components;
        private List<GroupComponent> _groupComponents;
        public GroupComponentRepository()
        {
            LoadData();
        }

        public List<Component> GetComponents()
        {
            return _components;
        }



        public List<GroupComponent> GetGroupComponents()
        {
            return _groupComponents;
        }
    }
}
