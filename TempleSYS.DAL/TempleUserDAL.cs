using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Dapper;
namespace TempleSYS.DAL
{
    /// <summary>[TempleUser]表数据访问类
    /// 作者:alonso(line id: menshin7)
    /// 创建时间:2019-12-09 23:21:47
    /// </summary>
    public partial class TempleUserDAL
    {
        public TempleUserDAL()
        { }
        /// <summary>增加一条数据
        /// 
        /// </summary>
        public int Add(TempleSYS.Model.TempleUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [TempleUser](");
            strSql.Append("[Account], [Password], [UserName], [URole], [URoleName], [IsDelete], [CreateDate], [CreateName], [UpdateDate], [UpdateName]  )");
            strSql.Append(" values (");
            strSql.Append("@Account, @Password, @UserName, @URole, @URoleName, @IsDelete, @CreateDate, @CreateName, @UpdateDate, @UpdateName  );select @@identity;");

            using (var connection = ConnectionFactory.GetOpenConnection())
            {
                int i = connection.Query<int>(strSql.ToString(), model).SingleOrDefault(); ;
                return i;
            }
        }

        /// <summary>更新一条数据
        /// 
        /// </summary>
        public bool Update(TempleSYS.Model.TempleUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [TempleUser] set ");
            strSql.Append("[Account]=@Account, [Password]=@Password, [UserName]=@UserName, [URole]=@URole, [URoleName]=@URoleName, [IsDelete]=@IsDelete, [CreateDate]=@CreateDate, [CreateName]=@CreateName, [UpdateDate]=@UpdateDate, [UpdateName]=@UpdateName  ");
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
            strSql.Append("update [TempleUser] set " + str_set + " ");
            strSql.Append(" where " + cond);
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
            strSql.Append("delete from [TempleUser] ");
            strSql.Append(" where Id=@Id ");
            using (var connection = ConnectionFactory.GetOpenConnection())
            {

                int i = connection.Execute(strSql.ToString(), new { Id = Id });
                return i > 0;
            }
        }

        /// <summary>根据条件删除数据
        /// 
        /// </summary>
        public bool DeleteByCond(string cond)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [TempleUser] ");
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
            string sql = "select " + filed + " from [TempleUser]";
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

        /// <summary>取一个字段的值
        /// 
        /// </summary>
        /// <param name="filed">字段，如sum(je)</param>
        /// <param name="cond">条件，如userid=2</param>
        /// <returns></returns>
        public double GetOneFiledDouble(string filed, string cond)
        {
            string tmp = GetOneFiled(filed, cond);
            return string.IsNullOrEmpty(tmp) ? 0 : double.Parse(tmp);
        }

        /// <summary>得到一个对象实体
        /// 
        /// </summary>
        public TempleSYS.Model.TempleUser GetModel(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [TempleUser] ");
            strSql.Append(" where Id=@Id ");
            TempleSYS.Model.TempleUser model = null;
            using (var connection = ConnectionFactory.GetOpenConnection())
            {
                model = connection.Query<TempleSYS.Model.TempleUser>(strSql.ToString(), new { Id = Id }).SingleOrDefault();

            }
            return model;
        }

        /// <summary>根据条件得到一个对象实体
        /// 
        /// </summary>
        public TempleSYS.Model.TempleUser GetModelByCond(string cond)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 * from [TempleUser] ");
            if (!string.IsNullOrEmpty(cond))
            {
                strSql.Append(" where " + cond);
            }
            TempleSYS.Model.TempleUser model = null;
            using (var connection = ConnectionFactory.GetOpenConnection())
            {
                model = connection.Query<TempleSYS.Model.TempleUser>(strSql.ToString()).SingleOrDefault();

            }
            return model;
        }






        /// <summary>获得数据列表
        /// 
        /// </summary>
        public List<TempleSYS.Model.TempleUser> GetListArray(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [TempleUser] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            List<TempleSYS.Model.TempleUser> list = new List<TempleSYS.Model.TempleUser>();
            using (var connection = ConnectionFactory.GetOpenConnection())
            {
                list = connection.Query<TempleSYS.Model.TempleUser>(strSql.ToString()).ToList();

            }
            return list;
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public List<TempleSYS.Model.TempleUser> GetListArray(string fileds, string orderstr, int PageSize, int PageIndex, string strWhere)
        {
            string order = orderstr.Split(' ')[0];
            string ordertype = orderstr.Split(' ')[1];
            string cond = string.IsNullOrEmpty(strWhere) ? "" : string.Format(" where {0}", strWhere);
            string sql = string.Format("SELECT * FROM ( SELECT ROW_NUMBER() OVER (ORDER BY {0} {1}) AS pos, {2} FROM  [TempleUser] {3}  ) AS sp WHERE pos BETWEEN {4} AND {5}", order, ordertype, fileds, cond, (((PageIndex - 1) * PageSize) + 1), PageSize * PageIndex);

            List<TempleSYS.Model.TempleUser> list = new List<TempleSYS.Model.TempleUser>();
            using (var connection = ConnectionFactory.GetOpenConnection())
            {
                list = connection.Query<TempleSYS.Model.TempleUser>(sql).ToList();
            }
            return list;
        }

        /// <summary>计算记录数
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int CalcCount(string cond)
        {
            string sql = "select count(1) from [TempleUser]";
            if (!string.IsNullOrEmpty(cond))
            {
                sql += " where " + cond;
            }
            using (var connection = ConnectionFactory.GetOpenConnection())
            {
                int i = connection.Query<int>(sql).SingleOrDefault();
                return i;

            }
        }

    }
}