using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using gymnasticHovedOpgave.Models;
using gymnasticHovedOpgave.Interfaces; // Replace with your actual namespace

namespace gymnasticHovedOpgave.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanningEventController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        // Inject the ApplicationDbContext into the constructor
        public PlanningEventController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PlanningEvent
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanningEvent>>> GetPlanningEvents()
        {
            // Fetch all planning events from the database
            var events = await _context.PlanningEvents.ToListAsync();
            return Ok(events); // Return the list of events as JSON
        }

        // GET: api/PlanningEvent/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlanningEvent>> GetPlanningEvent(int id)
        {
            var planningEvent = await _context.PlanningEvents.FindAsync(id);

            if (planningEvent == null)
            {
                return NotFound(); // If event is not found, return 404
            }

            return Ok(planningEvent); // Return the event as JSON
        }

        // POST: api/PlanningEvent
        [HttpPost]
        public async Task<ActionResult<PlanningEvent>> PostPlanningEvent(PlanningEvent planningEvent)
        {
            _context.PlanningEvents.Add(planningEvent);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPlanningEvent), new { id = planningEvent.Id }, planningEvent);
        }

        // PUT: api/PlanningEvent/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlanningEvent(int id, PlanningEvent planningEvent)
        {
            if (id != planningEvent.Id)
            {
                return BadRequest();
            }

            _context.Entry(planningEvent).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Return 204 No Content on success
        }

        // DELETE: api/PlanningEvent/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlanningEvent(int id)
        {
            var planningEvent = await _context.PlanningEvents.FindAsync(id);

            if (planningEvent == null)
            {
                return NotFound();
            }

            _context.PlanningEvents.Remove(planningEvent);
            await _context.SaveChangesAsync();

            return NoContent(); // Return 204 No Content on success
        }
    }
}
