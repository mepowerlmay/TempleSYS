using System;
namespace TempleSYS.Model
{
	/// <summary>Temple_t_role表实体类
	/// 作者:alonso(line:menshin7)
	/// 创建时间:2020-01-12 12:54:14
	/// </summary>
	[Serializable]
	public partial class Temple_t_role
	{
		public Temple_t_role()
		{}
		private int _Id ;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _Id=value;}
			get{return _Id;}
		}
		private string _Rolename ;
		/// <summary>
		/// 
		/// </summary>
		public string Rolename
		{
			set{ _Rolename=value;}
			get{return _Rolename;}
		}
		private DateTime? _CreateDate ;
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateDate
		{
			set{ _CreateDate=value;}
			get{return _CreateDate;}
		}
	}
}
