using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        [Required(ErrorMessage ="Chưa nhập họ tên người đặt")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Chưa nhập địa chỉ nhận hàng")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Chưa nhập số điện thoại liên hệ")]
        public string Phone { get; set; }
        public double Total { get; set; }
        public string State { get; set; }   
    }
}
