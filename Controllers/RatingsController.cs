using Application.Data;
using Application.DTO;
using Application.Entities;
using Application.Enum;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RatingsController : ControllerBase
    {
        private readonly ILogger<RatingsController> _logger;
        private readonly AppDbContext _context;

        public RatingsController(ILogger<RatingsController> logger,
            AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost(Name = "MakeRating")]
        public async Task<IActionResult> MakeRating(RatingDTO rate)
        {
            try
            {
                var rateToData = new Rating
                {
                    Id = Guid.NewGuid().ToString(),
                    Rate = (SessionRating)rate.Rate,
                    QuestionNo1Rating = rate.QuestionNo1Rating,
                    QuestionNo2Rating = rate.QuestionNo2Rating,
                    QuestionNo3Rating = rate.QuestionNo3Rating,
                    QuestionNo4Rating = rate.QuestionNo4Rating,
                    ClientComment = rate.ClientComment,
                    WantToBeContacted = rate.WantToBeContacted,
                    Session = new Session
                    {
                        Client = new Client
                        {
                            ReferanceNumber = 1215151
                        },
                        Therapist = new Therapist
                        {
                            Name = "aaa"
                        }
                    },
                };

                await _context.Ratings.AddAsync(rateToData);
                await _context.SaveChangesAsync();

                return Ok();

            }
            catch (Exception ex)
            {
                _logger.LogError($"error while executing {nameof(MakeRating)} - {ex.Message}");

                return Problem();
            }
        }
    }
}
