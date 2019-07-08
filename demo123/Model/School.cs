using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace demo123.Model
{
    public enum SchoolTypeEnum
    {
        [Display(Name = "公立学校")]
        PUB,
        [Display(Name = "私立学校")]
        PRI
    }

    //public class School
    //{
    //    [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true,Length =36)]
    //    public Guid Id { get; set; }

    //    [Display(Name = "学校编码")]
    //    [Required(ErrorMessage = "{0}是必填项")]
    //    [RegularExpression("^[0-9]{3,3}$", ErrorMessage = "{0}必须是3位数字")]
    //    public string SchoolCode { get; set; }

    //    [Display(Name = "学校名称")]
    //    [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
    //    [Required(ErrorMessage = "{0}是必填项")]
    //    public string SchoolName { get; set; }

    //    [Display(Name = "学校类型")]
    //    [Required(ErrorMessage = "{0}是必填项")]
    //    public SchoolTypeEnum? SchoolType { get; set; }

    //    [Display(Name = "备注")]
    //    [Required]
    //    public string Remark { get; set; }

    //}

    /// <summary>
    /// 
    /// </summary>
    public class School
    {
        /// <summary>
        /// 
        /// </summary>
        public School()
        {
        }

        private System.String _SchoolCode;
        /// <summary>
        /// 
        /// </summary>
        public System.String SchoolCode { get { return this._SchoolCode; } set { this._SchoolCode = value; } }

        private System.String _SchoolName;
        /// <summary>
        /// 
        /// </summary>
        public System.String SchoolName { get { return this._SchoolName; } set { this._SchoolName = value; } }

        private System.Int32? _SchoolType;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? SchoolType { get { return this._SchoolType; } set { this._SchoolType = value; } }

        private System.String _Remark;
        /// <summary>
        /// 
        /// </summary>
        public System.String Remark { get { return this._Remark; } set { this._Remark = value; } }

        private System.String _Id;
        /// <summary>
        /// 
        /// </summary>
        public System.String Id { get { return this._Id; } set { this._Id = value; } }
    }

}
