using System;
namespace TempleSYS.Model
{
    /// <summary>TempleBoard表实体类
    /// 作者:alonso(line id: menshin7)
    /// 创建时间:2020-02-23 13:45:44
    /// </summary>
    [Serializable]
    public partial class TempleBoard
    {
        public TempleBoard()
        { }
        private int _Id;
        /// <summary>公佈欄
        /// 
        /// </summary>
        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        private DateTime? _BoDate;
        /// <summary>日期
        /// 
        /// </summary>
        public DateTime? BoDate
        {
            set { _BoDate = value; }
            get { return _BoDate; }
        }
        private string _BoContent;
        /// <summary>內容
        /// 
        /// </summary>
        public string BoContent
        {
            set { _BoContent = value; }
            get { return _BoContent; }
        }
        private DateTime? _BoEndDate;
        /// <summary>公告截止日
        /// 
        /// </summary>
        public DateTime? BoEndDate
        {
            set { _BoEndDate = value; }
            get { return _BoEndDate; }
        }
        private string _BoPeo;
        /// <summary>公告人
        /// 
        /// </summary>
        public string BoPeo
        {
            set { _BoPeo = value; }
            get { return _BoPeo; }
        }
        private DateTime? _CreateDate;
        /// <summary>建立日期
        /// 
        /// </summary>
        public DateTime? CreateDate
        {
            set { _CreateDate = value; }
            get { return _CreateDate; }
        }
        private string _CreateName;
        /// <summary>建立人
        /// 
        /// </summary>
        public string CreateName
        {
            set { _CreateName = value; }
            get { return _CreateName; }
        }
        private DateTime? _UpdateDate;
        /// <summary>更新日期
        /// 
        /// </summary>
        public DateTime? UpdateDate
        {
            set { _UpdateDate = value; }
            get { return _UpdateDate; }
        }
        private string _UpdateName;
        /// <summary>更新人
        /// 
        /// </summary>
        public string UpdateName
        {
            set { _UpdateName = value; }
            get { return _UpdateName; }
        }
    }
}
