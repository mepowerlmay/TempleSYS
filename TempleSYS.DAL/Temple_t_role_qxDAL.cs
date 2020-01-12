using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Dapper;
namespace TempleSYS.DAL
{
    /// <summary>[Temple_t_role_qx]表数据访问类
    /// 作者:牛腩(QQ:164423073)
    /// 创建时间:2020-01-12 13:30:50
    /// </summary>
    public partial class Temple_t_role_qxDAL
    {
        public Temple_t_role_qxDAL()
        { }
        /// <summary>增加一条数据
        /// 
        /// </summary>
        public int Add(TempleSYS.Model.Temple_t_role_qx model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Temple_t_role_qx](");
            strSql.Append("[roleid], [qxid], [CreateDate]  )");
            strSql.Append(" values (");
            strSql.Append("@roleid, @qxid, @CreateDate  );select @@identity;"); 
 
    using (var connection = ConnectionFactory.GetOpenConnection())
            {
                     int i = connection.Query<int>(strSql.ToString(), model).SingleOrDefault();;
                return i;
            }
        }

        /// <summary>更新一条数据
        /// 
        /// </summary>
        public bool Update(TempleSYS.Model.Temple_t_role_qx model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [Temple_t_role_qx] set ");
            strSql.Append("[roleid]=@roleid, [qxid]=@qxid, [CreateDate]=@CreateDate  ");
            strSql.Append(" where Id=@Id ");
       using (var connection = ConnectionFactory.GetOpenConnection())
            {
                int i = connection.Execute(strSql.ToString(), model);
                return i > 0;
            }
        }

        /// <summary>按条件更新数据
        /// 
        /// </summary>
        public bool UpdateByCond(string str_set, string cond)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [Temple_t_role_qx] set "+str_set +" "); 
            strSql.Append(" where "+cond);
               using (var connection = ConnectionFactory.GetOpenConnection())
            {
                  int i = connection.Execute(strSql.ToString());
                return i > 0;
            }
        }

        /// <summary>删除一条数据
        /// 
        /// </summary>
        public bool Delete(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [Temple_t_role_qx] ");
            strSql.Append(" where Id=@Id ");
         using (var connection = ConnectionFactory.GetOpenConnection())
            {

                int i = connection.Execute(strSql.ToString());
                return i > 0;
            }
        }

        /// <summary>根据条件删除数据
        /// 
        /// </summary>
        public bool DeleteByCond(string cond)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [Temple_t_role_qx] ");
            if (!string.IsNullOrEmpty(cond))
            {
                strSql.Append(" where " + cond);
            }
                 using (var connection = ConnectionFactory.GetOpenConnection())
            {
                int i = connection.Execute(strSql.ToString());
                return i > 0;
            }
        }
		
        /// <summary>取一个字段的值
        /// 
        /// </summary>
        /// <param name="filed">字段，如sum(je)</param>
        /// <param name="cond">条件，如userid=2</param>
        /// <returns></returns>
        public string GetOneFiled(string filed, string cond)
        {
            string sql = "select " + filed + " from [Temple_t_role_qx]";
            if (!string.IsNullOrEmpty(cond))
            {
                sql += " where " + cond;
            }
			
             using (var connection = ConnectionFactory.GetOpenConnection())
            {
                string tmp = connection.ExecuteScalar<string>(sql);
                return tmp;
            }
        }

        /// <summary>得到一个对象实体
        /// 
        /// </summary>
        public TempleSYS.Model.Temple_t_role_qx GetModel(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [Temple_t_role_qx] ");
            strSql.Append(" where Id=@Id ");
             TempleSYS.Model.Temple_t_role_qx model = null;
            using (var connection = ConnectionFactory.GetOpenConnection())
            {
                model = connection.Query<TempleSYS.Model.Temple_t_role_qx>(strSql.ToString(), new { Id=Id }).SingleOrDefault();				
    
            }
            return model;
        }

        /// <summary>根据条件得到一个对象实体
        /// 
        /// </summary>
        public TempleSYS.Model.Temple_t_role_qx GetModelByCond(string cond )
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 * from [Temple_t_role_qx] ");
            if (!string.IsNullOrEmpty(cond))
            {
                strSql.Append(" where " + cond);
            } 
        TempleSYS.Model.Temple_t_role_qx model = null;
            using (var connection = ConnectionFactory.GetOpenConnection())
            {
                model = connection.Query<TempleSYS.Model.Temple_t_role_qx>(strSql.ToString()).SingleOrDefault();

            }
            return model;
        }

 

 
 

        /// <summary>获得数据列表
        /// 
        /// </summary>
        public List<TempleSYS.Model.Temple_t_role_qx> GetListArray(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [Temple_t_role_qx] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            List<TempleSYS.Model.Temple_t_role_qx> list = new List<TempleSYS.Model.Temple_t_role_qx>();
                  using (var connection = ConnectionFactory.GetOpenConnection())
            {
                list = connection.Query<TempleSYS.Model.Temple_t_role_qx>(strSql.ToString()).ToList();

            }
            return list;
        }

        /// <summary>分页获取数据列表
        /// 
        /// </summary>
        public List<TempleSYS.Model.Temple_t_role_qx> GetListArray(string fileds, string orderstr, int PageSize, int PageIndex, string strWhere )
        { 
   string order = orderstr.Split(' ')[0];
            string ordertype= orderstr.Split(' ')[1];
            string cond = string.IsNullOrEmpty(strWhere) ? "" : string.Format(" where {0}",strWhere);
          string sql = string.Format("SELECT * FROM ( SELECT ROW_NUMBER() OVER (ORDER BY {0} {1}) AS pos, {2} FROM  [Temple_t_role_qx] {3}  ) AS sp WHERE pos BETWEEN {4} AND {5}",order,ordertype,fileds,cond, (((PageIndex - 1) * PageSize) + 1), PageSize * PageIndex);

		 // 	    string sql = string.Format("select {0} from [Temple_t_role_qx] {1} order by {2} offset {3} rows fetch next {4} rows only", fileds, cond, orderstr, (PageIndex - 1) * PageSize, PageSize);
          

            List<TempleSYS.Model.Temple_t_role_qx> list = new List<TempleSYS.Model.Temple_t_role_qx>(); 
                  using (var connection = ConnectionFactory.GetOpenConnection())
            {
                list = connection.Query<TempleSYS.Model.Temple_t_role_qx>(sql).ToList();

            }
            return list;
        }

 

        /// <summary>计算记录数
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int CalcCount(string cond )
        {
            string sql = "select count(1) from [Temple_t_role_qx]";
            if (!string.IsNullOrEmpty(cond))
            {
                sql += " where " + cond;
            }
         using (var connection = ConnectionFactory.GetOpenConnection())
            {
                int i = connection.Query<int>(sql).SingleOrDefault();;
                return i;

            }
        }
 
    }
}

