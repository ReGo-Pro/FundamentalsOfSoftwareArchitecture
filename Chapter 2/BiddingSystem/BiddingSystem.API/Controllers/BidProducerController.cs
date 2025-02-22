using BiddingSystem.Models.Dtos;
using BiddingSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace BiddingSystem.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BidProducerController : ControllerBase
	{
		private readonly IEnumerable<IBidProcessor> _bidProcessors;

		public BidProducerController(IEnumerable<IBidProcessor> bidProcessors) {
			_bidProcessors = bidProcessors;
		}

		[HttpPost]
		public async Task<IActionResult> PostBid(BidDto bidDto) {
			if (!ModelState.IsValid) {
				return BadRequest(ModelState);
			}

			foreach (var processor in _bidProcessors) {
				await processor.ProcessBidAsync(bidDto.ToModel());
			}

			return Ok("Your bid has been successfully processed!");
		}
	}
}
