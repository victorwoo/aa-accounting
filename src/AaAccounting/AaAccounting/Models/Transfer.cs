using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AaAccounting.Models
{
    /// <summary>
    /// 转账记录。
    /// </summary>
    public class Transfer
    {
        /// <summary>
        /// 付款人。
        /// </summary>
        public Member Payer { get; set; }

        /// <summary>
        /// 收款人。
        /// </summary>
        public Member Reciever { get; set; }

        /// <summary>
        /// 转账金额。
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 发生时间。
        /// </summary>
        public DateTime DateTime { get; set; }
    }
}