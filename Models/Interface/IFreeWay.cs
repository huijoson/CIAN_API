using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIAN_API.ViewModels.FreeWay;

namespace CIAN_API.Models.Interface
{
    public interface IFreeWay : IDisposable
    {
        /// <summary>
        /// 傳回使用的資料庫實體
        /// </summary>
        DataClassesDataContext Entity { get; }

        List<FreeWayDeserialize> GetFreeWayInfo();
    }
}
