using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_WEB.Components
{
    [ViewComponent(Name = "Post")]
public class PostComponent : ViewComponent
{
    private readonly DataContext _context;
    public PostComponent(DataContext context)
    {
        _context = context;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var listOfPost = (from p in _context.ViewPostMenus orderby p.PostID descending select p).Take(8).ToList();
        return await Task.FromResult((IViewComponentResult)View("Default", listOfPost));
    }
}
}