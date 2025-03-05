using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ASP_NET_WEB.Components
{
    [ViewComponent(Name = "MenuView")]
    public class MenuViewComponent : ViewComponent
    {
        private readonly DataContext _context;

        public MenuViewComponent(DataContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listOfMenu = (from m in _context.TblMenus where (m.Position == 1) select m)
                .ToList();
            return await Task.FromResult((IViewComponentResult) View("Default", listOfMenu));
        }
    }
}