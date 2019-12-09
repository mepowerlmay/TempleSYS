using System;
namespace TempleSYS.Model
{
	/// <summary>TemplePeoBasic表实体类
	/// 作者:alonso(line id: menshin7)
	/// 创建时间:2019-12-09 23:21:44
	/// </summary>
	[Serializable]
	public partial class TemplePeoBasic
	{
		public TemplePeoBasic()
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
		private string _Names ;
		/// <summary>
		/// 
		/// </summary>
		public string Names
		{
			set{ _Names=value;}
			get{return _Names;}
		}
		private string _Gender ;
		/// <summary>
		/// 
		/// </summary>
		public string Gender
		{
			set{ _Gender=value;}
			get{return _Gender;}
		}
		private string _Idno ;
		/// <summary>
		/// 
		/// </summary>
		public string Idno
		{
			set{ _Idno=value;}
			get{return _Idno;}
		}
		private string _cellphone1 ;
		/// <summary>
		/// 
		/// </summary>
		public string cellphone1
		{
			set{ _cellphone1=value;}
			get{return _cellphone1;}
		}
		private string _cellphone2 ;
		/// <summary>
		/// 
		/// </summary>
		public string cellphone2
		{
			set{ _cellphone2=value;}
			get{return _cellphone2;}
		}
		private string _phone1 ;
		/// <summary>
		/// 
		/// </summary>
		public string phone1
		{
			set{ _phone1=value;}
			get{return _phone1;}
		}
		private string _phone2 ;
		/// <summary>
		/// 
		/// </summary>
		public string phone2
		{
			set{ _phone2=value;}
			get{return _phone2;}
		}
		private string _Birthday ;
		/// <summary>
		/// 
		/// </summary>
		public string Birthday
		{
			set{ _Birthday=value;}
			get{return _Birthday;}
		}
		private string _LBirthday ;
		/// <summary>
		/// 
		/// </summary>
		public string LBirthday
		{
			set{ _LBirthday=value;}
			get{return _LBirthday;}
		}
		private string _Bhour ;
		/// <summary>
		/// 
		/// </summary>
		public string Bhour
		{
			set{ _Bhour=value;}
			get{return _Bhour;}
		}
		private string _PostZone ;
		/// <summary>
		/// 
		/// </summary>
		public string PostZone
		{
			set{ _PostZone=value;}
			get{return _PostZone;}
		}
		private string _Addr ;
		/// <summary>
		/// 
		/// </summary>
		public string Addr
		{
			set{ _Addr=value;}
			get{return _Addr;}
		}
		private string _ChYears ;
		/// <summary>
		/// 
		/// </summary>
		public string ChYears
		{
			set{ _ChYears=value;}
			get{return _ChYears;}
		}
		private string _ZodiacSign ;
		/// <summary>
		/// 
		/// </summary>
		public string ZodiacSign
		{
			set{ _ZodiacSign=value;}
			get{return _ZodiacSign;}
		}
		private string _AddrNo ;
		/// <summary>
		/// 
		/// </summary>
		public string AddrNo
		{
			set{ _AddrNo=value;}
			get{return _AddrNo;}
		}
		private string _AddrMaster ;
		/// <summary>
		/// 
		/// </summary>
		public string AddrMaster
		{
			set{ _AddrMaster=value;}
			get{return _AddrMaster;}
		}
		private string _OpenNum ;
		/// <summary>
		/// 
		/// </summary>
		public string OpenNum
		{
			set{ _OpenNum=value;}
			get{return _OpenNum;}
		}
		private string _Dingshu ;
		/// <summary>
		/// 
		/// </summary>
		public string Dingshu
		{
			set{ _Dingshu=value;}
			get{return _Dingshu;}
		}
		private int? _IsDelete ;
		/// <summary>
		/// 
		/// </summary>
		public int? IsDelete
		{
			set{ _IsDelete=value;}
			get{return _IsDelete;}
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
		private string _CreateName ;
		/// <summary>
		/// 
		/// </summary>
		public string CreateName
		{
			set{ _CreateName=value;}
			get{return _CreateName;}
		}
		private DateTime? _UpdateDate ;
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpdateDate
		{
			set{ _UpdateDate=value;}
			get{return _UpdateDate;}
		}
		private string _UpdateName ;
		/// <summary>
		/// 
		/// </summary>
		public string UpdateName
		{
			set{ _UpdateName=value;}
			get{return _UpdateName;}
		}
	}
}
