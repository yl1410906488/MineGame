using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineGame
{
    interface I雷场
    {
        /// <summary>
        /// 产生地雷坐标
        /// </summary>
        void 布雷();

        /// <summary>
        /// 
        /// </summary>
        void 计算周围地雷数量();

        /// <summary>
        /// 加载地雷，显示雷场
        /// </summary>
        void 雷场显示();
    }
}
