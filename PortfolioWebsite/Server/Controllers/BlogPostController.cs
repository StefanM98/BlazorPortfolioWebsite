using Microsoft.AspNetCore.Mvc;
using PortfolioWebsite.Shared;

namespace PortfolioWebsite.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogPostController : ControllerBase
    {
        private readonly ILogger<BlogPostController> _logger;
        
        private string[] titles = {
            "Building a Portfolio Website with .NET Blazor \u1F525",
            "DigitalOcean - .NET Core Hosted Blazor Web Assembly App",
            "What the hell is XAML?"
        };

        private string bodyText = "Lorem ipsum dolor sit amet, consectetur " +
            "adipiscing elit, sed do eiusmod tempor incididunt ut labore et " +
            "dolore magna aliqua. Ornare massa eget egestas purus viverra.";

        public BlogPostController(ILogger<BlogPostController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<BlogPost> Get()
        {
            return Enumerable.Range(0, 3).Select(index => new BlogPost
            {
                DatePosted = DateTime.Now.AddDays(-1 * index),
                Title = titles[index],
                Body = bodyText,
                Summary = bodyText
            })
            .ToArray();
        }
    }
}