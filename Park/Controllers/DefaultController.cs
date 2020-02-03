using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Park.Models;
namespace Park.Controllers
{
    /// <summary>
    /// 停车管理系统api
    /// </summary>
    [RoutePrefix("api/default")]
    public class DefaultController : ApiController
    {
        readonly db_Park _db = new db_Park();

        /// <summary>
        /// 返回停车表信息
        /// </summary>
        /// <returns>停车表信息集合</returns>
        [HttpGet]
        [Route("GetParkingLots")]
        public List<ParkingLot> GetParkingLots()
        {
            return _db.ParkingLot.ToList();
        }

        /// <summary>
        /// 根据车位信息查看停车信息
        /// </summary>
        /// <param name="plid">车位编号</param>
        /// <returns>车位停车信息集合</returns>
        [HttpGet]
        [Route("GetCardRecordsById")]
        public List<CardRecord> GetCardRecordsById(int plid)
        {
            return _db.CardRecord.Where(c => c.PLID == plid).ToList();
        }

        /// <summary>
        /// 释放_db
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
