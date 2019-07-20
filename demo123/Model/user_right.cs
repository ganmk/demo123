using SqlSugar;

namespace demo123.Model
{
    /// <summary>
    /// 用户权限表
    /// </summary>
    public class user_right
    {
        /// <summary>
        /// 用户权限表
        /// </summary>
        public user_right()
        {
        }

        private System.Int32 _ur_id;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 ur_id { get { return this._ur_id; } set { this._ur_id = value; } }

        private System.Int32? _um_id;
        /// <summary>
        /// 菜单ID
        /// </summary>
        public System.Int32? um_id { get { return this._um_id; } set { this._um_id = value; } }

        private System.String _ur_name;
        /// <summary>
        /// 
        /// </summary>
        public System.String ur_name { get { return this._ur_name; } set { this._ur_name = value; } }

        private System.String _ur_name_en;
        /// <summary>
        /// 
        /// </summary>
        public System.String ur_name_en { get { return this._ur_name_en; } set { this._ur_name_en = value; } }

        private System.String _ur_description;
        /// <summary>
        /// 
        /// </summary>
        public System.String ur_description { get { return this._ur_description; } set { this._ur_description = value; } }

        private System.String _ur_url;
        /// <summary>
        /// 
        /// </summary>
        public System.String ur_url { get { return this._ur_url; } set { this._ur_url = value; } }

        private System.SByte _ur_sort;
        /// <summary>
        /// 
        /// </summary>
        public System.SByte ur_sort { get { return this._ur_sort; } set { this._ur_sort = value; } }

        private System.Boolean _ur_common;
        /// <summary>
        /// 
        /// </summary>
        public System.Boolean ur_common { get { return this._ur_common; } set { this._ur_common = value; } }

        private System.Boolean _ur_type;
        /// <summary>
        /// 0:隐藏;1:显示
        /// </summary>
        public System.Boolean ur_type { get { return this._ur_type; } set { this._ur_type = value; } }

        private System.String _ur_module;
        /// <summary>
        /// 
        /// </summary>
        public System.String ur_module { get { return this._ur_module; } set { this._ur_module = value; } }

        private System.String _ur_icon;
        /// <summary>
        /// 
        /// </summary>
        public System.String ur_icon { get { return this._ur_icon; } set { this._ur_icon = value; } }

        private System.String _ur_newurl;
        /// <summary>
        /// 
        /// </summary>
        public System.String ur_newurl { get { return this._ur_newurl; } set { this._ur_newurl = value; } }
    }
}