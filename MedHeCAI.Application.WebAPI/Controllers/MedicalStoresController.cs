using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedHeCAI.Application.Models;

namespace MedHeCAI.Application.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalStoresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MedicalStoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MedicalStores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MedicalStore>>> GetMedicalStores()
        {
            return await _context.MedicalStores.ToListAsync();
        }

        // GET: api/MedicalStores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MedicalStore>> GetMedicalStore(int id)
        {
            var medicalStore = await _context.MedicalStores.FindAsync(id);

            if (medicalStore == null)
            {
                return NotFound();
            }

            return medicalStore;
        }

        // PUT: api/MedicalStores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicalStore(int id, MedicalStore medicalStore)
        {
            if (id != medicalStore.StoreId)
            {
                return BadRequest();
            }

            _context.Entry(medicalStore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicalStoreExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MedicalStores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MedicalStore>> PostMedicalStore(MedicalStore medicalStore)
        {
            _context.MedicalStores.Add(medicalStore);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedicalStore", new { id = medicalStore.StoreId }, medicalStore);
        }

        // DELETE: api/MedicalStores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicalStore(int id)
        {
            var medicalStore = await _context.MedicalStores.FindAsync(id);
            if (medicalStore == null)
            {
                return NotFound();
            }

            _context.MedicalStores.Remove(medicalStore);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MedicalStoreExists(int id)
        {
            return _context.MedicalStores.Any(e => e.StoreId == id);
        }
    }
}
