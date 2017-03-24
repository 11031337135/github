using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace namo.Models
{
    /// <summary>
    /// 訂單的服務
    /// </summary>



    public class OrderService
    {///<summary>
        ///新增訂單
        ///</summary>
        public void InserOrder(Order order)
        {

        }
        ///<summary>
        ///刪除訂單
        ///</summary>
        public void DeleteOrderById()
        {

        }
        ///<summary>
        ///更改訂單
        ///</summary>
        public void UpdateOrder()
        {

        }
        /// <summary>
        /// 取得訂單 
        /// </summary>
        /// <param name="id">訂單ID</param>
        /// <returns></returns>
        public Models.Order GetOrderById(string id)
        {
            Models.Order result = new Order();
            result.CustId = "GSS";
            result.CustName = "睿揚資訊";

            return result;
        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <returns></returns>
        //public List<Models.Order> GEtOrders()
        //{
        //    return new List<Order>();
        //}
    }
}