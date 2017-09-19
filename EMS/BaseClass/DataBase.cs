using System;
using System.Data;
using System.Data.SqlClient;

//引用类库

namespace EMS.BaseClass
{
    internal class DataBase : IDisposable
    {
        private SqlConnection con; //创建连接对象

        #region   打开数据库连接

        /// <summary>
        ///   打开数据库连接.
        /// </summary>
        private void Open()
        {
            if (con == null) //判断连接对象是否为空
            {
                con = new SqlConnection("Server=localhost;DataBase=db_EMS;User=sa;Password=850304"); //创建数据库连接对象
            }
            if (con.State == ConnectionState.Closed) //判断数据库连接是否关闭
                con.Open(); //打开数据库连接
        }

        #endregion

        #region  关闭连接

        /// <summary>
        ///   关闭数据库连接
        /// </summary>
        public void Close()
        {
            if (con != null) //判断连接对象是否不为空
                con.Close(); //关闭数据库连接
        }

        #endregion

        #region 释放数据库连接资源

        /// <summary>
        ///   释放资源
        /// </summary>
        public void Dispose()
        {
            if (con != null) //判断连接对象是否不为空
            {
                con.Dispose(); //释放数据库连接资源
                con = null; //设置数据库连接为空
            }
        }

        #endregion

        #region   传入参数并且转换为SqlParameter类型

        /// <summary>
        ///   转换参数
        /// </summary>
        /// <param name="ParamName"> 存储过程名称或命令文本 </param>
        /// <param name="DbType"> 参数类型 </param>
        /// </param>
        /// <param name="Size"> 参数大小 </param>
        /// <param name="Value"> 参数值 </param>
        /// <returns> 新的 parameter 对象 </returns>
        public SqlParameter MakeInParam(string ParamName, SqlDbType DbType, int Size, object Value)
        {
            return MakeParam(ParamName, DbType, Size, ParameterDirection.Input, Value); //创建SQL参数
        }

        /// <summary>
        ///   初始化参数值
        /// </summary>
        /// <param name="ParamName"> 存储过程名称或命令文本 </param>
        /// <param name="DbType"> 参数类型 </param>
        /// <param name="Size"> 参数大小 </param>
        /// <param name="Direction"> 参数方向 </param>
        /// <param name="Value"> 参数值 </param>
        /// <returns> 新的 parameter 对象 </returns>
        public SqlParameter MakeParam(string ParamName, SqlDbType DbType, Int32 Size, ParameterDirection Direction,
                                      object Value)
        {
            SqlParameter param; //声明SQL参数对象
            if (Size > 0) //判断参数字段是否大于0
                param = new SqlParameter(ParamName, DbType, Size); //根据指定的类型和大小创建SQL参数
            else
                param = new SqlParameter(ParamName, DbType); //根据指定的类型创建SQL参数
            param.Direction = Direction; //设置SQL参数的类型
            if (!(Direction == ParameterDirection.Output && Value == null)) //判断是否为输出参数
                param.Value = Value; //设置参数返回值
            return param; //返回SQL参数
        }

        #endregion

        #region   执行参数命令文本(无数据库中数据返回)

        /// <summary>
        ///   执行命令
        /// </summary>
        /// <param name="procName"> 命令文本 </param>
        /// <param name="prams"> 参数对象 </param>
        /// <returns> </returns>
        public int RunProc(string procName, SqlParameter[] prams)
        {
            SqlCommand cmd = CreateCommand(procName, prams); //创建SqlCommand命令对象
            cmd.ExecuteNonQuery(); //执行SQL命令
            Close(); //关闭数据库连接
            return (int) cmd.Parameters["ReturnValue"].Value; //得到执行成功返回值
        }

        /// <summary>
        ///   直接执行SQL语句
        /// </summary>
        /// <param name="procName"> 命令文本 </param>
        /// <returns> </returns>
        public int RunProc(string procName)
        {
            Open(); //打开数据库连接
            SqlCommand cmd = new SqlCommand(procName, con); //创建SqlCommand命令对象
            cmd.ExecuteNonQuery(); //执行SQL命令
            Close(); //关闭数据库连接
            return 1; //返回1，表示执行成功
        }

        #endregion

        #region   执行参数命令文本(有返回值)

        /// <summary>
        ///   执行查询命令文本，并且返回DataSet数据集
        /// </summary>
        /// <param name="procName"> 命令文本 </param>
        /// <param name="prams"> 参数对象 </param>
        /// <param name="tbName"> 数据表名称 </param>
        /// <returns> </returns>
        public DataSet RunProcReturn(string procName, SqlParameter[] prams, string tbName)
        {
            SqlDataAdapter dap = CreateDataAdaper(procName, prams); //创建桥接器对象
            DataSet ds = new DataSet(); //创建数据集对象
            dap.Fill(ds, tbName); //填充数据集
            Close(); //关闭数据库连接
            return ds; //返回数据集
        }

        /// <summary>
        ///   执行命令文本，并且返回DataSet数据集
        /// </summary>
        /// <param name="procName"> 命令文本 </param>
        /// <param name="tbName"> 数据表名称 </param>
        /// <returns> DataSet </returns>
        public DataSet RunProcReturn(string procName, string tbName)
        {
            SqlDataAdapter dap = CreateDataAdaper(procName, null); //创建桥接器对象
            DataSet ds = new DataSet(); //创建数据集对象
            dap.Fill(ds, tbName); //填充数据集
            Close(); //关闭数据库连接
            return ds; //返回数据集
        }

        #endregion

        #region 将命令文本添加到SqlDataAdapter

        /// <summary>
        ///   创建一个SqlDataAdapter对象以此来执行命令文本
        /// </summary>
        /// <param name="procName"> 命令文本 </param>
        /// <param name="prams"> 参数对象 </param>
        /// <returns> </returns>
        private SqlDataAdapter CreateDataAdaper(string procName, SqlParameter[] prams)
        {
            Open(); //打开数据库连接
            SqlDataAdapter dap = new SqlDataAdapter(procName, con); //创建桥接器对象
            dap.SelectCommand.CommandType = CommandType.Text; //指定要执行的类型为命令文本
            if (prams != null) //判断SQL参数是否不为空
            {
                foreach (SqlParameter parameter in prams) //遍历传递的每个SQL参数
                    dap.SelectCommand.Parameters.Add(parameter); //将SQL参数添加到执行命令对象中
            }
            //加入返回参数
            dap.SelectCommand.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4,
                                                              ParameterDirection.ReturnValue, false, 0, 0, string.Empty,
                                                              DataRowVersion.Default, null));
            return dap; //返回桥接器对象
        }

        #endregion

        #region   将命令文本添加到SqlCommand

        /// <summary>
        ///   创建一个SqlCommand对象以此来执行命令文本
        /// </summary>
        /// <param name="procName"> 命令文本 </param>
        /// <param name="prams" 命令文本所需参数 </param>
        /// <returns> 返回SqlCommand对象 </returns>
        private SqlCommand CreateCommand(string procName, SqlParameter[] prams)
        {
            Open(); //打开数据库连接
            SqlCommand cmd = new SqlCommand(procName, con); //创建SqlCommand命令对象
            cmd.CommandType = CommandType.Text; //指定要执行的类型为命令文本
            // 依次把参数传入命令文本
            if (prams != null) //判断SQL参数是否不为空
            {
                foreach (SqlParameter parameter in prams) //遍历传递的每个SQL参数
                    cmd.Parameters.Add(parameter); //将SQL参数添加到执行命令对象中
            }
            //加入返回参数
            cmd.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4,
                                                ParameterDirection.ReturnValue, false, 0, 0, string.Empty,
                                                DataRowVersion.Default, null));
            return cmd; //返回SqlCommand命令对象
        }

        #endregion
    }
}