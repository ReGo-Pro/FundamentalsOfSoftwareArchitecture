using BiddingSystem.Models.Entities;

namespace BiddingSystem.Services
{
	public class BidTracker : IBidProcessor
	{
		public Task ProcessBidAsync(Bid bid) {
			Console.WriteLine($"Tracking bid for ID: {bid.BidId} with amount {bid.Amount}");
			return Task.CompletedTask;
		}
	}
}
