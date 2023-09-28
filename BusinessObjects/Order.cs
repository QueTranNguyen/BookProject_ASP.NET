using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
	public class Order
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }
		[Required]
		public int BookId { get; set; }
		public Book Book { get; set; }
		[Required]
		public DateTime DeliveryDate { get; set; }
		[Required]
		public string DeleveryLocal { get; set; }
		[Required]
		public int CustomerId { get; set; }

		[Required]
		public string CustomerName { get; set; }
		[Required]
		public string CustomerPhone { get; set; }
		[Required]
		public double Total { get; set; }
		[Required]
		public Boolean IsConfirm { get; set; }
		[Required]
		public int DiscountId { get; set; }
		public Discount Discount { get; set; }
		public ICollection<Order> Orders { get;}
	}
}
