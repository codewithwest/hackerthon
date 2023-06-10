
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json.Serialization;
namespace net_hack.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public JsonFileProductService ProductService;

    public ProjectUrlService ProjectService;
    public UserUrlService UserService;
    public IEnumerable<Product>? Products { get; private set; }
    public IEnumerable<Projects>? Projectss { get; private set; }
    public IEnumerable<User>? Users { get; private set; }




    public IndexModel(ILogger<IndexModel> logger,
    JsonFileProductService productService,
    ProjectUrlService projectService,
    UserUrlService userService
    )
    {
        _logger = logger;
        ProductService = productService;
        ProjectService = projectService;
        UserService = userService;

    }

    public void OnGet()
    {
        //  Holding the products in a variable called products
        Products = ProductService.GetProducts();
        Projectss = ProjectService.GetProjects();

        var s = (IEnumerable<User>)UserService.GetUser();
        Users = s;
        // WestDynamics = WestDynamicsService.One();

    }
}
