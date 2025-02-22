using BiddingSystem.Models.Entities;

namespace BiddingSystem.Services
{
	public class BidAnalyzer : IBidProcessor
	{
		public Task ProcessBidAsync(Bid bid) {
			Console.WriteLine($"Analyzing bid for ID: {bid.BidId} with amount {bid.Amount}");
			return Task.CompletedTask;
		}
	}
}
