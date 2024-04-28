using GameZone.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GameZone.Services
{
    public class CategoriesService(ApplicationDbContext context) : ICategoriesService
    {
        private readonly ApplicationDbContext _context = context;

        public IEnumerable<SelectListItem> GetSelectList() => [.. _context.Categories
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                .OrderBy(c => c.Text)
                .AsNoTracking()];
    }
}
