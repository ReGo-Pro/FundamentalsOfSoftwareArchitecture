using BiddingSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingSystem.Models.Dtos
{
	public class BidDto
	{
		[Required]
		public int BidId { get; set; }

		[Required]
		public int AuctionId { get; set; }

		[Required]
		public int UserId { get; set; }

		[DataType(DataType.Currency)]
		public decimal Amount { get; set; }

		public DateTime BidTime { get; set; }

		public Bid ToModel() {
			return new Bid {
				BidId = BidId,
				AuctionId = AuctionId,
				UserId = UserId,
				Amount = Amount,
				BidTime = BidTime
			};
		}
	}
}
