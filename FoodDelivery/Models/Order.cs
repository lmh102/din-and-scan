using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        [Display(Name = "Thời gian đặt")]
        public DateTime OrderDate { get; set; }

        [Required]
        public double OrderTotalOriginal { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:0}")]
        [Display(Name = "Tổng giá trị")]
        public double OrderTotal { get; set; }

        [Required]
        [Display(Name = "Thời gian nhận")]
        public DateTime PickUpTime { get; set; }

        [Required]
        //[NotMapped]
        public DateTime? PickUpDate { get; set; }

        [Display(Name = "Mã giảm giá")]
        public string CouponCode { get; set; }
        public double CouponCodeDiscount { get; set; }
        [Display(Name = "Trạng thái")]
        public string Status { get; set; }
        public string PaymentStatus { get; set; }
        [Display(Name = "Ghi chú")]
        public string Comments { get; set; }

        [Required]
        [Display(Name = "Người đặt")]
        public string PickupName { get; set; }

        [Required]
        [Display(Name = "SĐT")]
        public string PhoneNumber { get; set; }
        
        public string TransactionId { get; set; }
    }
}
