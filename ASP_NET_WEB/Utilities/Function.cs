namespace ASP_NET_WEB.Utilities
{
    
    public class Function
    {
        public static string TitleSlugGenerator(string type, string? title, long id)
        {
            return type + "-" + SlugGenerator.SlugGenerator.GenerateSlug(title) + "-" + id.ToString() + ".html";
        }
    }
}