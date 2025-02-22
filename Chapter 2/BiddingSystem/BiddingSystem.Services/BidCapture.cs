using BiddingSystem.Models.Entities;

namespace BiddingSystem.Services
{
	public class BidCapture : IBidProcessor
	{
		public Task ProcessBidAsync(Bid bid) {
			Console.WriteLine($"Capturing bid for ID: {bid.BidId} with amount {bid.Amount}");
			return Task.CompletedTask;
		}
	}
}
