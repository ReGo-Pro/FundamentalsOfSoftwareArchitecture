using BiddingSystem.Models.Entities;

namespace BiddingSystem.Services
{
	public interface IBidProcessor
	{
		public Task ProcessBidAsync(Bid bid);
	}
}
