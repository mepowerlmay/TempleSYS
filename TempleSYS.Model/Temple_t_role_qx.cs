using System;
namespace TempleSYS.Model
{
	/// <summary>Temple_t_role_qx表实体类
	/// 作者:alonso(line:menshin7)
	/// 创建时间:2020-01-12 12:54:14
	/// </summary>
	[Serializable]
	public partial class Temple_t_role_qx
	{
		public Temple_t_role_qx()
		{}
		private int _Id ;
		/// <summary>權限表
		/// 
		/// </summary>
		public int Id
		{
			set{ _Id=value;}
			get{return _Id;}
		}
		private int? _roleid ;
		/// <summary>
		/// 
		/// </summary>
		public int? roleid
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		private int? _qxid ;
		/// <summary>
		/// 
		/// </summary>
		public int? qxid
		{
			set{ _qxid=value;}
			get{return _qxid;}
		}
		private string _CreateDate ;
		/// <summary>
		/// 
		/// </summary>
		public string CreateDate
		{
			set{ _CreateDate=value;}
			get{return _CreateDate;}
		}
	}
}
