
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using codefucius_api.Models;

namespace codefucius_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly DataContext _context;

        public ReviewController(DataContext context)
        {
            _context = context;
        }

        // GET: api/review
        [HttpGet]
        public async Task<ActionResult<List<Review>>> GetReviews()
        {
            return await _context.Reviews.ToListAsync();
        }

        // GET: api/review/{guid}
        [HttpGet("{id}", Name="GetReview")]
        public async Task<ActionResult<Review>> GetReview(Guid id)
        {
            var review = await _context.Reviews.FindAsync(id);

            if (review == null)
            {
                return NotFound();
            }

            return review;
        }

        // POST: api/review
        [HttpPost]
        public async Task<ActionResult<Review>> PostReview(Review review)
        {
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetReview), new { id = review.ID }, review);
        }

        // PUT: api/review/{guid}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReview(Guid id, Review review)
        {
            if (id != review.ID)
            {
                return BadRequest();
            }

            var oldReview = await _context.Reviews.FindAsync(id);
            if (oldReview == null)
            {
                return NotFound();
            }

            oldReview.Title = review.Title;
            oldReview.Description = review.Description;
            oldReview.Deadline = review.Deadline;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!ReviewExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/review/{guid}
        [HttpDelete("{id}")]
        public async Task<ActionResult<Review>> DeleteReview(Guid id)
        {
            var review = await _context.Reviews.FindAsync(id);

            if (review == null)
            {
                return NotFound();
            }

            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();

            return review;
        }

        private bool ReviewExists(Guid id) =>
           _context.Reviews.Any(e => e.ID == id); 
    }
}