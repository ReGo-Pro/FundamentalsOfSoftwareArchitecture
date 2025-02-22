using BiddingSystem.Models.Entities;

namespace BiddingSystem.Services
{
	public class BidHistory : IBidProcessor
	{
		public Task ProcessBidAsync(Bid bid) {
			Console.WriteLine($"Bid History: received @ {bid.BidTime.ToShortDateString()} with Id {bid.BidId}, Amount: {bid.Amount}");
			return Task.CompletedTask;
		}
	}
}
