using SqlSugar;

namespace demo123.Model
{
    /// <summary>
    /// 用户菜单
    /// </summary>
    public class user_menu
    {
        /// <summary>
        /// 用户菜单
        /// </summary>
        public user_menu()
        {
        }

        private System.Int32 _um_id;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 um_id { get { return this._um_id; } set { this._um_id = value; } }

        private System.Int32 _parent_id;
        /// <summary>
        /// 父级um_id,0为顶级
        /// </summary>
        public System.Int32 parent_id { get { return this._parent_id; } set { this._parent_id = value; } }

        private System.Int32 _us_id;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 us_id { get { return this._us_id; } set { this._us_id = value; } }

        private System.String _um_title;
        /// <summary>
        /// 用户菜单名称
        /// </summary>
        public System.String um_title { get { return this._um_title; } set { this._um_title = value; } }

        private System.String _um_title_en;
        /// <summary>
        /// 菜单英文名称
        /// </summary>
        public System.String um_title_en { get { return this._um_title_en; } set { this._um_title_en = value; } }

        private System.String _um_url;
        /// <summary>
        /// URL
        /// </summary>
        public System.String um_url { get { return this._um_url; } set { this._um_url = value; } }

        private System.String _um_css;
        /// <summary>
        /// 样式
        /// </summary>
        public System.String um_css { get { return this._um_css; } set { this._um_css = value; } }

        private System.String _um_color;
        /// <summary>
        /// 
        /// </summary>
        public System.String um_color { get { return this._um_color; } set { this._um_color = value; } }

        private System.Int32 _um_sort;
        /// <summary>
        /// 排序
        /// </summary>
        public System.Int32 um_sort { get { return this._um_sort; } set { this._um_sort = value; } }

        private System.Int32? _sub_userPower;
        /// <summary>
        /// 代理客户权限
        /// </summary>
        public System.Int32? sub_userPower { get { return this._sub_userPower; } set { this._sub_userPower = value; } }
    }
}