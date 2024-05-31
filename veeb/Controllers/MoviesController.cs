using Microsoft.AspNetCore.Mvc;
using veeb.Data;

public class MoviesController : Controller
{
    private readonly ApplicationDbContext _context;

    public MoviesController(ApplicationDbContext context)
    {
        _context = context;
    }
}
