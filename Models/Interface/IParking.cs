using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIAN_API.ViewModels.Parking;

namespace CIAN_API.Models.Interface
{
    public interface IParking : IDisposable
    {
        /// <summary>
        /// 傳回使用的資料庫實體
        /// </summary>
        DataClassesDataContext Entity { get; }

        void AddOutParking(IEnumerable<ParkingDeserialize> addParkingResource);
        List<ParkingDeserialize> GetOutParkingInfo();
    }
}