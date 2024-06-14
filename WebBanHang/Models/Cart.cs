using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    //Lớp biểu diễn 1 phần tử của giỏ hàng
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
    //Lớp biểu diễn giỏ hàng
    public class Cart
    {
        private List<CartItem> _items;
        public Cart()
        {
            _items = new List<CartItem>();
        }
        public List<CartItem> Items { get { return _items; } }
        //Các phương thức xử lý trên giỏ hàng
        //Thêm sản phẩm vào giỏ hàng
        public void Add(Product p,int qty)
        {
            var item = _items.FirstOrDefault(x => x.Product.Id == p.Id);
            if (item == null) //Nếu chưa có
            {
                _items.Add(new CartItem { Product = p, Quantity = qty });
            }
            else //Nếu có rồi
            {
                item.Quantity += qty;
            }
        }
        //Cập nhật số lượng sản phẩm
        public void Update(int ProductId, int qty)
        {
            var item = _items.FirstOrDefault(x => x.Product.Id == ProductId);
            if(item!= null)
            {
                if (qty > 0)
                {
                    item.Quantity = qty;
                }
                else
                {
                    _items.Remove(item);
                }
            }
        }
        //Xoá sản phẩm trong giỏ
        public void Remove(int ProductId)
        {
            var item = _items.FirstOrDefault(x => x.Product.Id == ProductId);
            if (item != null)
            {
                _items.Remove(item);
            }
        }
        //Tính tổng thành tiền có 2 cách

        //Cách 1
        //public double Total
        //{

        //        double total = _items.Sum(x => x.Quantity * x.Product.Price);
        //        return total;

        //}

        //Cách 2
        public double Total
        {
            get
            {
                double total = _items.Sum(x => x.Quantity * x.Product.Price);
                return total;
            }
        }
        //Tính tổng số lượng sản phẩm
        public double Quantity
        {
            get
            {
                double total = _items.Sum(x => x.Quantity);
                return total;
            }
        }
    }
}
