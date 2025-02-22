using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingSystem.Models.Entities
{
	public class Bid
	{
		public int BidId { get; set; }
		public int AuctionId { get; set; }
		public int UserId { get; set; }
		public decimal Amount { get; set; }
		public DateTime BidTime { get; set; }
	}
}
