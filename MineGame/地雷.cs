using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineGame
{
    public enum 区块状态 { 未知,标记,安全,爆炸,可疑}
    public class 地雷 :System.Windows.Forms.Button,I地雷
    {
        int _在雷场中的行位置;
        public int 在雷场中的行位置
        {
            get { return _在雷场中的行位置; }
            set { _在雷场中的行位置 = value; }
        }
        int _在雷场中的列位置;
        public int 在雷场中的列位置
        {
            get { return _在雷场中的列位置; }
            set { _在雷场中的列位置 = value; }
        }

        static int _长 = 35;
        public static int 高度
        {
            get { return 地雷._长; }
        }

        static int _宽 = 35;
        public static int 长度
        {
            get { return 地雷._宽; }
        }

        Boolean _is地雷;
        public Boolean Is地雷
        {
            get { return _is地雷; }
        }
                
        区块状态 _当前外观;
        public 区块状态 当前外观
        {
            set
            {
                _当前外观 = value;
                switch (_当前外观)
                {
                    case 区块状态.安全:
                        break;
                    case 区块状态.爆炸:
                        break;
                    case 区块状态.标记:
                        break;
                    case 区块状态.可疑:
                        break;
                    default:
                        this.BackgroundImage = System.Drawing.Image.FromFile("Images\\0.png");
                        break;
                }
            }
        }

        public 地雷()
        {
            设置地雷(false);            
        }
        public 地雷(Boolean 是否是地雷)
        {
            设置地雷(是否是地雷);
        }
        public void 设置地雷(Boolean 是否是地雷)
        {
            _is地雷 = 是否是地雷;
            this.Size = new System.Drawing.Size(_长, _宽);
            this.MouseDown += 地雷_MouseDown;
            this.MouseDoubleClick += 地雷_MouseDoubleClick;
        }

        void 地雷_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        void 地雷_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
        public void 外观方法(区块状态 初始化外观)
        {
            当前外观 = 初始化外观;
        }
    }
 

}
