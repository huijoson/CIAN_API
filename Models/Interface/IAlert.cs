using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIAN_API.ViewModels.Alert;

namespace CIAN_API.Models.Interface
{
    public interface IAlert : IDisposable
    {
        /// <summary>
        /// 傳回使用的資料庫實體
        /// </summary>
        DataClassesDataContext Entity { get; }

        //新增災害示警資訊至資料庫
        void AddAlertInfo(IEnumerable<AlertDeserialize> alertResource);

        //取得災害警示
        List<AlertInfo> getAlertInfo(string keyWord);
    }
}
