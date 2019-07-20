using SqlSugar;

namespace demo123.Model
{
    /// <summary>
    /// 用户列表
    /// </summary>
    public class user
    {
        /// <summary>
        /// 用户列表
        /// </summary>
        public user()
        {
        }

        private System.Int32 _user_id;
        /// <summary>
        /// ID
        /// </summary>
        public System.Int32 user_id { get { return this._user_id; } set { this._user_id = value; } }

        private System.String _user_code;
        /// <summary>
        /// 登录名
        /// </summary>
        public System.String user_code { get { return this._user_code; } set { this._user_code = value; } }

        private System.Int32 _customer_id;
        /// <summary>
        /// 公司id
        /// </summary>
        public System.Int32 customer_id { get { return this._customer_id; } set { this._customer_id = value; } }

        private System.Int32? _customer_channelid;
        /// <summary>
        /// 客户渠道，相当于客户的分公司，同一公司不同分公司账号不允许查看相互的数据，总公司允许查看所有数据
        /// </summary>
        public System.Int32? customer_channelid { get { return this._customer_channelid; } set { this._customer_channelid = value; } }

        private System.SByte _is_admin;
        /// <summary>
        /// 是否为公司管理员账号：0-否,1-是
        /// </summary>
        public System.SByte is_admin { get { return this._is_admin; } set { this._is_admin = value; } }

        private System.String _user_password;
        /// <summary>
        /// 密码
        /// </summary>
        public System.String user_password { get { return this._user_password; } set { this._user_password = value; } }

        private System.String _real_name;
        /// <summary>
        /// 真实姓名
        /// </summary>
        public System.String real_name { get { return this._real_name; } set { this._real_name = value; } }

        private System.String _user_name;
        /// <summary>
        /// 真实姓名
        /// </summary>
        public System.String user_name { get { return this._user_name; } set { this._user_name = value; } }

        private System.String _user_name_en;
        /// <summary>
        /// 英文名
        /// </summary>
        public System.String user_name_en { get { return this._user_name_en; } set { this._user_name_en = value; } }

        private System.Boolean _user_status;
        /// <summary>
        /// 状态:0未激活,1激活
        /// </summary>
        public System.Boolean user_status { get { return this._user_status; } set { this._user_status = value; } }

        private System.String _user_email;
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public System.String user_email { get { return this._user_email; } set { this._user_email = value; } }

        private System.Boolean _email_verify;
        /// <summary>
        /// 邮箱是否验证，0：否，1：是
        /// </summary>
        public System.Boolean email_verify { get { return this._email_verify; } set { this._email_verify = value; } }

        private System.Int32 _ud_id;
        /// <summary>
        /// 人员所属部门id
        /// </summary>
        public System.Int32 ud_id { get { return this._ud_id; } set { this._ud_id = value; } }

        private System.Int32 _up_id;
        /// <summary>
        /// 职位position id
        /// </summary>
        public System.Int32 up_id { get { return this._up_id; } set { this._up_id = value; } }

        private System.DateTime? _user_password_update_time;
        /// <summary>
        /// 最近一次修改密码
        /// </summary>
        public System.DateTime? user_password_update_time { get { return this._user_password_update_time; } set { this._user_password_update_time = value; } }

        private System.String _user_phone;
        /// <summary>
        /// 联系电话
        /// </summary>
        public System.String user_phone { get { return this._user_phone; } set { this._user_phone = value; } }

        private System.String _user_mobile_phone;
        /// <summary>
        /// 联系手机号
        /// </summary>
        public System.String user_mobile_phone { get { return this._user_mobile_phone; } set { this._user_mobile_phone = value; } }

        private System.String _user_note;
        /// <summary>
        /// 备注
        /// </summary>
        public System.String user_note { get { return this._user_note; } set { this._user_note = value; } }

        private System.Int32 _user_supervisor_id;
        /// <summary>
        /// 上级管理者ID（0为顶级)
        /// </summary>
        public System.Int32 user_supervisor_id { get { return this._user_supervisor_id; } set { this._user_supervisor_id = value; } }

        private System.DateTime _user_add_time;
        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime user_add_time { get { return this._user_add_time; } set { this._user_add_time = value; } }

        private System.DateTime _user_last_login;
        /// <summary>
        /// 最后登录时间
        /// </summary>
        public System.DateTime user_last_login { get { return this._user_last_login; } set { this._user_last_login = value; } }

        private System.DateTime _user_update_time;
        /// <summary>
        /// 最后更新时间
        /// </summary>
        public System.DateTime user_update_time { get { return this._user_update_time; } set { this._user_update_time = value; } }

        private System.Int32? _tms_id;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? tms_id { get { return this._tms_id; } set { this._tms_id = value; } }

        private System.String _user_activate_code;
        /// <summary>
        /// 激活码
        /// </summary>
        public System.String user_activate_code { get { return this._user_activate_code; } set { this._user_activate_code = value; } }

        private System.Int32? _parent_user_id;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? parent_user_id { get { return this._parent_user_id; } set { this._parent_user_id = value; } }

        private System.String _reg_ip;
        /// <summary>
        /// 
        /// </summary>
        public System.String reg_ip { get { return this._reg_ip; } set { this._reg_ip = value; } }

        private System.String _user_imgUrl;
        /// <summary>
        /// 用户头像的路径
        /// </summary>
        public System.String user_imgUrl { get { return this._user_imgUrl; } set { this._user_imgUrl = value; } }

        private System.String _openid;
        /// <summary>
        /// 微信openid
        /// </summary>
        public System.String openid { get { return this._openid; } set { this._openid = value; } }

        private System.String _unionid;
        /// <summary>
        /// 微信unionid
        /// </summary>
        public System.String unionid { get { return this._unionid; } set { this._unionid = value; } }

        private System.String _nickname;
        /// <summary>
        /// 微信昵称
        /// </summary>
        public System.String nickname { get { return this._nickname; } set { this._nickname = value; } }

        private System.DateTime? _wx_modify_date;
        /// <summary>
        /// 微信更新日期
        /// </summary>
        public System.DateTime? wx_modify_date { get { return this._wx_modify_date; } set { this._wx_modify_date = value; } }

        private System.Boolean? _showbalance;
        /// <summary>
        /// 显示余额
        /// </summary>
        public System.Boolean? showbalance { get { return this._showbalance; } set { this._showbalance = value; } }
    }
}