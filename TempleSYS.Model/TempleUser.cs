using System;
namespace TempleSYS.Model
{
    /// <summary>TempleUser表实体类
    /// 作者:alonso(line id: menshin7)
    /// 创建时间:2020-09-13 14:23:28
    /// </summary>
    [Serializable]
    public partial class TempleUser
    {
        public TempleUser()
        { }
        private int _Id;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        private string _Account;
        /// <summary>
        /// 
        /// </summary>
        public string Account
        {
            set { _Account = value; }
            get { return _Account; }
        }
        private string _Password;
        /// <summary>
        /// 
        /// </summary>
        public string Password
        {
            set { _Password = value; }
            get { return _Password; }
        }
        private string _UserName;
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _UserName = value; }
            get { return _UserName; }
        }
        private int? _RoleId;
        /// <summary>
        /// 
        /// </summary>
        public int? RoleId
        {
            set { _RoleId = value; }
            get { return _RoleId; }
        }
        private string _URole;
        /// <summary>
        /// 
        /// </summary>
        public string URole
        {
            set { _URole = value; }
            get { return _URole; }
        }
        private int? _RoleNameId;
        /// <summary>
        /// 
        /// </summary>
        public int? RoleNameId
        {
            set { _RoleNameId = value; }
            get { return _RoleNameId; }
        }
        private string _URoleName;
        /// <summary>
        /// 
        /// </summary>
        public string URoleName
        {
            set { _URoleName = value; }
            get { return _URoleName; }
        }
        private int? _IsDelete;
        /// <summary>
        /// 
        /// </summary>
        public int? IsDelete
        {
            set { _IsDelete = value; }
            get { return _IsDelete; }
        }
        private DateTime? _CreateDate;
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateDate
        {
            set { _CreateDate = value; }
            get { return _CreateDate; }
        }
        private string _CreateName;
        /// <summary>
        /// 
        /// </summary>
        public string CreateName
        {
            set { _CreateName = value; }
            get { return _CreateName; }
        }
        private DateTime? _UpdateDate;
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateDate
        {
            set { _UpdateDate = value; }
            get { return _UpdateDate; }
        }
        private string _UpdateName;
        /// <summary>
        /// 
        /// </summary>
        public string UpdateName
        {
            set { _UpdateName = value; }
            get { return _UpdateName; }
        }
    }
}
