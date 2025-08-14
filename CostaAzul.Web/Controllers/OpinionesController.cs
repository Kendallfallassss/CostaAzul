using CostaAzul.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using CostaAzul.API.Models.Entities;

[Authorize]
public class OpinionesController : Controller
{
    private readonly CostaAzulContext _context;

    public OpinionesController(CostaAzulContext context)
    {
        _context = context;
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Crear(Opinion opinion)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (userId == null) return Unauthorized();

        opinion.UsuarioId = int.Parse(userId);
        opinion.Fecha = DateTime.UtcNow;

        _context.Opiniones.Add(opinion);
        await _context.SaveChangesAsync();

        return RedirectToAction("Details", "Hoteles", new { id = opinion.HotelId });
    }
}
