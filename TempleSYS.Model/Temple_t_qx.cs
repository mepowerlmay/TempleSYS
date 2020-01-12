using System;
namespace TempleSYS.Model
{
	/// <summary>Temple_t_qx表实体类
	/// 作者:alonso(line:menshin7)
	/// 创建时间:2020-01-12 12:54:14
	/// </summary>
	[Serializable]
	public partial class Temple_t_qx
	{
		public Temple_t_qx()
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
		private string _ModuleName ;
		/// <summary>
		/// 
		/// </summary>
		public string ModuleName
		{
			set{ _ModuleName=value;}
			get{return _ModuleName;}
		}
		private string _Cmd ;
		/// <summary>
		/// 
		/// </summary>
		public string Cmd
		{
			set{ _Cmd=value;}
			get{return _Cmd;}
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
