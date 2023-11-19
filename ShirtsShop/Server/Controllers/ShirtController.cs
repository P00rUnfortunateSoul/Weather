using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShirtsShop.Server.Data;
using ShirtsShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShirtsShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShirtController : ControllerBase
    {
        static List<Size> sizes = new List<Size> {
            new Size { Id = 1, Name = "XS"},
            new Size { Id = 2, Name = "S"},
            new Size { Id = 3, Name = "XM"},
            new Size { Id = 4, Name = "M"},
            new Size { Id = 5, Name = "L"},
            new Size { Id = 6, Name = "XL"},
            new Size { Id = 7, Name = "XXL"},
            new Size { Id = 8, Name = "XXXL"},
            new Size { Id = 9, Name = "XXXXL"}
        };

        static List<Shirt> shirts = new List<Shirt> {
            new Shirt { Id = 1, Color = "Black", Text = "Long", Size = sizes[2] },
            new Shirt { Id = 2, Color = "White", Text = "Live", Size = sizes[4] }
        };

        private readonly DataContext _context;

        public ShirtController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> GetShirts()
        {
            return Ok(await GetDbShirts());
        }

        private async Task<List<Shirt>> GetDbShirts()
        {
            return await _context.Shirts.Include(sh => sh.Size).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleShirt(int id)
        {
            var shirt = await _context.Shirts.Include(sh => sh.Size).FirstOrDefaultAsync(s => s.Id == id);
            if (shirt == null)
                return NotFound("No such Shirts");
            return Ok(shirt);
        }

        [HttpGet("sizes")]
        public async Task<IActionResult> GetSizes()
        {
            return Ok(await _context.Sizes.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreateShirt(Shirt shirt)
        {
            _context.Shirts.Add(shirt);
            await _context.SaveChangesAsync();

            return Ok(await GetDbShirts());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateShirt(Shirt shirt, int id)
        {
            var dbShirt = await _context.Shirts.Include(sh => sh.Size).FirstOrDefaultAsync(s => s.Id == id);
            if (dbShirt == null)
                return NotFound("No such Shirts");

            dbShirt.Text = shirt.Text;
            dbShirt.Color = shirt.Color;
            dbShirt.SizeId = shirt.SizeId;

            await _context.SaveChangesAsync();

            return Ok(await GetDbShirts());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShirt(int id)
        {
            var dbShirt = await _context.Shirts.Include(sh => sh.Size).FirstOrDefaultAsync(s => s.Id == id);
            if (dbShirt == null)
                return NotFound("No such Shirts");

            _context.Shirts.Remove(dbShirt);
            await _context.SaveChangesAsync();

            return Ok(await GetDbShirts());
        }
    }
}
