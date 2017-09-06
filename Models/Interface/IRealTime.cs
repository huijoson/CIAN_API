using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIAN_API.ViewModels.RealTime;

namespace CIAN_API.Models.Interface
{
    public interface IRealTime : IDisposable
    {
        /// <summary>
        /// 傳回使用的資料庫實體
        /// </summary>
        DataClassesDataContext Entity { get; }

        void addRealTimeInfo(IEnumerable<RealTimeInfoDeserialize> realTimeInfoSource);
        List<RealTimeInfoDeserialize> getRealTimeInfo(float latitude, float longitude, int radius);
    }
}
