using System;
namespace TempleSYS.Model
{
	/// <summary>TempleGods表实体类
	/// 作者:alonso(line id: menshin7)
	/// 创建时间:2019-12-09 23:21:44
	/// </summary>
	[Serializable]
	public partial class TempleGods
	{
		public TempleGods()
		{}
		private int _Id ;
		/// <summary>神尊表
		/// 
		/// </summary>
		public int Id
		{
			set{ _Id=value;}
			get{return _Id;}
		}
		private string _FuName ;
		/// <summary>全名
		/// 
		/// </summary>
		public string FuName
		{
			set{ _FuName=value;}
			get{return _FuName;}
		}
		private string _shtName ;
		/// <summary>簡稱
		/// 
		/// </summary>
		public string shtName
		{
			set{ _shtName=value;}
			get{return _shtName;}
		}
		private int? _IsDelete ;
		/// <summary>是否停用
		/// 
		/// </summary>
		public int? IsDelete
		{
			set{ _IsDelete=value;}
			get{return _IsDelete;}
		}
		private DateTime? _CreateDate ;
		/// <summary>建立日期
		/// 
		/// </summary>
		public DateTime? CreateDate
		{
			set{ _CreateDate=value;}
			get{return _CreateDate;}
		}
		private string _CreateName ;
		/// <summary>建立人
		/// 
		/// </summary>
		public string CreateName
		{
			set{ _CreateName=value;}
			get{return _CreateName;}
		}
		private DateTime? _UpdateDate ;
		/// <summary>更新日期
		/// 
		/// </summary>
		public DateTime? UpdateDate
		{
			set{ _UpdateDate=value;}
			get{return _UpdateDate;}
		}
		private string _UpdateName ;
		/// <summary>更新人
		/// 
		/// </summary>
		public string UpdateName
		{
			set{ _UpdateName=value;}
			get{return _UpdateName;}
		}
	}
}
