using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AaAccounting.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// 订单。
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 订单ID。
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 订单总金额。
        /// </summary>
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        /// <summary>
        /// 订单明细列表。
        /// </summary>
        public IList<OrderDetail> OrderDetails { get; set; } 

        /// <summary>
        /// 付款人。
        /// </summary>
        public string Payer { get; set; }
    }

    public class OrderDetail
    {
        /// <summary>
        /// 消费者。
        /// </summary>
        public string Consumer { get; set; }

        /// <summary>
        /// 消费金额。
        /// </summary>
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
    }
}