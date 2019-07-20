using SqlSugar;

namespace demo123.Model
{
    /// <summary>
    /// 用户权限对照表
    /// </summary>
    public class user_right_map
    {
        /// <summary>
        /// 用户权限对照表
        /// </summary>
        public user_right_map()
        {
        }

        private System.Int32 _urm_id;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 urm_id { get { return this._urm_id; } set { this._urm_id = value; } }

        private System.Int32 _ur_id;
        /// <summary>
        /// 权限列表ID
        /// </summary>
        public System.Int32 ur_id { get { return this._ur_id; } set { this._ur_id = value; } }

        private System.Int32? _user_id;
        /// <summary>
        /// 用户ID
        /// </summary>
        public System.Int32? user_id { get { return this._user_id; } set { this._user_id = value; } }

        private System.Int32? _visiable;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? visiable { get { return this._visiable; } set { this._visiable = value; } }
    }
}