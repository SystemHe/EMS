using System;
using System.Data;
using System.Data.SqlClient;

//引用类库

namespace EMS.BaseClass
{
    internal class BaseInfo
    {
        private readonly DataBase data = new DataBase(); //创建DataBase类的对象

        #region 添加--往来单位信息

        /// <summary>
        ///   添加往来单位
        /// </summary>
        /// <param name="client"> </param>
        /// <returns> 返回往来单位id </returns>
        public int AddUnits(cUnitsInfo units)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@unitcode", SqlDbType.VarChar, 5, units.UnitCode),
                    data.MakeInParam("@fullname", SqlDbType.VarChar, 30, units.FullName),
                    data.MakeInParam("@tax", SqlDbType.VarChar, 30, units.Tax),
                    data.MakeInParam("@tel", SqlDbType.VarChar, 20, units.Tel),
                    data.MakeInParam("@linkman", SqlDbType.VarChar, 10, units.LinkMan),
                    data.MakeInParam("@address", SqlDbType.VarChar, 60, units.Address),
                    data.MakeInParam("@accounts", SqlDbType.VarChar, 80, units.Accounts),
                };
            return
                (data.RunProc(
                    "INSERT INTO tb_units (unitcode, fullname, tax, tel, linkman, address, accounts) VALUES (@unitcode,@fullname,@tax,@tel,@linkman,@address,@accounts)",
                    prams));
        }

        #endregion

        #region 修改--往来单位信息

        /// <summary>
        ///   修改往来单位信息
        /// </summary>
        /// <param name="units"> </param>
        /// <returns> </returns>
        public int UpdateUnits(cUnitsInfo units)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@unitcode", SqlDbType.VarChar, 5, units.UnitCode),
                    data.MakeInParam("@fullname", SqlDbType.VarChar, 30, units.FullName),
                    data.MakeInParam("@tax", SqlDbType.VarChar, 30, units.Tax),
                    data.MakeInParam("@tel", SqlDbType.VarChar, 20, units.Tel),
                    data.MakeInParam("@linkman", SqlDbType.VarChar, 10, units.LinkMan),
                    data.MakeInParam("@address", SqlDbType.VarChar, 60, units.Address),
                    data.MakeInParam("@accounts", SqlDbType.VarChar, 80, units.Accounts),
                };
            return
                (data.RunProc(
                    "update tb_units set fullname=@fullname,tax=@tax,tel=@tel,linkman=@linkman,address=@address,accounts=@accounts where unitcode=@unitcode",
                    prams));
        }

        #endregion

        #region 删除--往来单位信息

        /// <summary>
        ///   删除往来单位
        /// </summary>
        /// <param name="client"> </param>
        /// <returns> 返回往来单位id </returns>
        public int DeleteUnits(cUnitsInfo units)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@unitcode", SqlDbType.VarChar, 5, units.UnitCode),
                };
            return (data.RunProc("delete from tb_units where unitcode=@unitcode", prams));
        }

        #endregion

        #region 查询--往来单位信息

        /// <summary>
        ///   根据--单位编号--得到往来单位信息
        /// </summary>
        /// <param name="units"> </param>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet FindUnitsByUnitCode(cUnitsInfo units, string tbName)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@unitcode", SqlDbType.VarChar, 5, units.UnitCode + "%"),
                };
            return (data.RunProcReturn("select * from tb_units where unitcode like @unitcode", prams, tbName));
        }

        /// <summary>
        ///   根据--单位名称--得到往来单位信息
        /// </summary>
        /// <param name="units"> </param>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet FindUnitsByFullName(cUnitsInfo units, string tbName)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@fullname", SqlDbType.VarChar, 30, units.FullName + "%"),
                };
            return (data.RunProcReturn("select * from tb_units where fullname like @fullname", prams, tbName));
        }

        /// <summary>
        ///   得到所有--往来单位信息
        /// </summary>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet GetAllUnits(string tbName)
        {
            return (data.RunProcReturn("select * from tb_units ORDER BY unitcode", tbName));
        }

        #endregion

        #region 添加--库存商品信息

        /// <summary>
        ///   添加库存商品基本信息
        /// </summary>
        /// <param name="stock"> 库存商品数据结构类对象 </param>
        /// <returns> </returns>
        public int AddStock(cStockInfo stock)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@tradecode", SqlDbType.VarChar, 5, stock.TradeCode),
                    data.MakeInParam("@fullname", SqlDbType.VarChar, 30, stock.FullName),
                    data.MakeInParam("@type", SqlDbType.VarChar, 10, stock.TradeType),
                    data.MakeInParam("@standard", SqlDbType.VarChar, 10, stock.Standard),
                    data.MakeInParam("@unit", SqlDbType.VarChar, 4, stock.Unit),
                    data.MakeInParam("@produce", SqlDbType.VarChar, 20, stock.Produce),
                };
            return
                (data.RunProc(
                    "INSERT INTO tb_stock (tradecode, fullname, type, standard, unit, produce) VALUES (@tradecode,@fullname,@type,@standard,@unit,@produce)",
                    prams));
        }

        #endregion

        #region 修改--库存商品信息

        /// <summary>
        ///   修改库存商品信息
        /// </summary>
        /// <param name="stock"> 库存商品数据结构类对象 </param>
        /// <returns> </returns>
        public int UpdateStock(cStockInfo stock)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@tradecode", SqlDbType.VarChar, 5, stock.TradeCode),
                    data.MakeInParam("@fullname", SqlDbType.VarChar, 30, stock.FullName),
                    data.MakeInParam("@type", SqlDbType.VarChar, 10, stock.TradeType),
                    data.MakeInParam("@standard", SqlDbType.VarChar, 10, stock.Standard),
                    data.MakeInParam("@unit", SqlDbType.VarChar, 4, stock.Unit),
                    data.MakeInParam("@produce", SqlDbType.VarChar, 20, stock.Produce),
                };
            return
                (data.RunProc(
                    "update tb_stock set fullname=@fullname,type=@type,standard=@standard,unit=@unit,produce=@produce where tradecode=@tradecode",
                    prams));
        }

        #endregion

        #region 删除--库存商品信息

        /// <summary>
        ///   删除库存商品信息
        /// </summary>
        /// <param name="stock"> 库存商品数据结构类对象 </param>
        /// <returns> </returns>
        public int DeleteStock(cStockInfo stock)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@tradecode", SqlDbType.VarChar, 5, stock.TradeCode),
                };
            return (data.RunProc("delete from tb_stock where tradecode=@tradecode", prams));
        }

        #endregion

        #region 查询--往来单位信息

        /// <summary>
        ///   根据--商品产地--得到库存商品信息
        /// </summary>
        /// <param name="stock"> 库存商品数据结构类对象 </param>
        /// <param name="tbName"> 映射原表名称 </param>
        /// <returns> </returns>
        public DataSet FindStockByProduce(cStockInfo stock, string tbName)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@produce", SqlDbType.VarChar, 5, stock.Produce + "%"),
                };
            return (data.RunProcReturn("select * from tb_stock where produce like @produce", prams, tbName));
        }

        /// <summary>
        ///   根据--商品名称--得到库存商品信息
        /// </summary>
        /// <param name="units"> </param>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet FindStockByFullName(cStockInfo stock, string tbName)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@fullname", SqlDbType.VarChar, 30, stock.FullName + "%"),
                };
            return (data.RunProcReturn("select * from tb_stock where fullname like @fullname", prams, tbName));
        }

        /// <summary>
        ///   得到所有--库存商品信息
        /// </summary>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet GetAllStock(string tbName)
        {
            return (data.RunProcReturn("select * from tb_Stock ORDER BY tradecode", tbName));
        }

        #endregion

        #region 添加--公司职员信息

        /// <summary>
        ///   添加--公司职员--信息
        /// </summary>
        /// <param name="client"> </param>
        /// <returns> </returns>
        public int AddEmployee(cEmployeeInfo employee)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@employeecode", SqlDbType.VarChar, 5, employee.EmployeeCode),
                    data.MakeInParam("@fullname", SqlDbType.VarChar, 20, employee.FullName),
                    data.MakeInParam("@sex", SqlDbType.VarChar, 4, employee.Sex),
                    data.MakeInParam("@dept", SqlDbType.VarChar, 20, employee.Dept),
                    data.MakeInParam("@tel", SqlDbType.VarChar, 20, employee.Tel),
                    data.MakeInParam("@memo", SqlDbType.VarChar, 20, employee.Memo),
                };
            return
                (data.RunProc(
                    "INSERT INTO tb_Employee (employeecode, fullname, sex, dept, tel, memo) VALUES (@employeecode,@fullname,@sex,@dept,@tel,@memo)",
                    prams));
        }

        #endregion

        #region 修改--公司职员信息

        /// <summary>
        ///   修改--公司职员--信息
        /// </summary>
        /// <param name="units"> </param>
        /// <returns> </returns>
        public int UpdateEmployee(cEmployeeInfo employee)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@employeecode", SqlDbType.VarChar, 5, employee.EmployeeCode),
                    data.MakeInParam("@fullname", SqlDbType.VarChar, 20, employee.FullName),
                    data.MakeInParam("@sex", SqlDbType.VarChar, 4, employee.Sex),
                    data.MakeInParam("@dept", SqlDbType.VarChar, 20, employee.Dept),
                    data.MakeInParam("@tel", SqlDbType.VarChar, 20, employee.Tel),
                    data.MakeInParam("@memo", SqlDbType.VarChar, 20, employee.Memo),
                };
            return
                (data.RunProc(
                    "update tb_Employee set fullname=@fullname,sex=@sex,dept=@dept,tel=@tel,memo=@memo where employeecode=@employeecode",
                    prams));
        }

        #endregion

        #region 删除--公司职员信息

        /// <summary>
        ///   删除--公司职员--信息
        /// </summary>
        /// <param name="client"> </param>
        /// <returns> </returns>
        public int DeleteEmployee(cEmployeeInfo employee)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@employeecode", SqlDbType.VarChar, 5, employee.EmployeeCode),
                };
            return (data.RunProc("delete from tb_employee where employeecode=@employeecode", prams));
        }

        #endregion

        #region 查询--公司职员信息

        /// <summary>
        ///   根据--职员所在部门--得到公司职员信息
        /// </summary>
        /// <param name="units"> </param>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet FindEmployeeByDept(cEmployeeInfo employee, string tbName)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@dept", SqlDbType.VarChar, 20, employee.Dept + "%"),
                };
            return (data.RunProcReturn("select * from tb_employee where dept like @dept", prams, tbName));
        }

        /// <summary>
        ///   根据--职员姓名--得到公司职员信息
        /// </summary>
        /// <param name="units"> </param>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet FindEmployeeByFullName(cEmployeeInfo employee, string tbName)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@fullname", SqlDbType.VarChar, 20, employee.FullName + "%"),
                };
            return (data.RunProcReturn("select * from tb_employee where fullname like @fullname", prams, tbName));
        }

        /// <summary>
        ///   得到所有--公司职员信息
        /// </summary>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet GetAllEmployee(string tbName)
        {
            return (data.RunProcReturn("select * from tb_Employee ORDER BY employeecode", tbName));
        }

        #endregion

        #region 商品进销存---单据过账

        /// <summary>
        ///   得到所有tbName表中信息－－主要用来：得到最大的单据编号然后自动编号
        /// </summary>
        /// <param name="tbName"> 数据表名称 </param>
        /// <returns> </returns>
        public DataSet GetAllBill(string tbName_trueName)
        {
            return (data.RunProcReturn("select * from " + tbName_trueName + "", tbName_trueName));
        }

        /// <summary>
        ///   处理进货单和销售退货单-数据---向主表中添加数据
        /// </summary>
        /// <param name="billinfo"> 过账单据数据结构类对象 </param>
        /// <param name="AddTableName_trueName"> 数据库中数据表名称 </param>
        /// <returns> </returns>
        public int AddTableMainWarehouse(cBillInfo billinfo, string AddTableName_trueName)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@billdate", SqlDbType.DateTime, 8, billinfo.BillDate),
                    data.MakeInParam("@billcode", SqlDbType.VarChar, 20, billinfo.BillCode),
                    data.MakeInParam("@units", SqlDbType.VarChar, 30, billinfo.Units),
                    data.MakeInParam("@handle", SqlDbType.VarChar, 10, billinfo.Handle),
                    data.MakeInParam("@summary", SqlDbType.VarChar, 100, billinfo.Summary),
                    data.MakeInParam("@fullpayment", SqlDbType.Float, 8, billinfo.FullPayment),
                    data.MakeInParam("@payment", SqlDbType.Float, 8, billinfo.Payment),
                };
            return
                (data.RunProc(
                    "INSERT INTO " + AddTableName_trueName +
                    " (billdate, billcode, units, handle, summary, fullpayment,payment) VALUES (@billdate,@billcode,@units,@handle,@summary,@fullpayment,@payment)",
                    prams));
        }

        /// <summary>
        ///   处理进货退货单和销售单-数据---向主表中添加数据
        /// </summary>
        /// <param name="billinfo"> 过账单据数据结构类对象 </param>
        /// <param name="AddTableName_trueName"> 数据库中数据表名称 </param>
        /// <returns> </returns>
        public int AddTableMainSellhouse(cBillInfo billinfo, string AddTableName_trueName)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@billdate", SqlDbType.DateTime, 8, billinfo.BillDate),
                    data.MakeInParam("@billcode", SqlDbType.VarChar, 20, billinfo.BillCode),
                    data.MakeInParam("@units", SqlDbType.VarChar, 30, billinfo.Units),
                    data.MakeInParam("@handle", SqlDbType.VarChar, 10, billinfo.Handle),
                    data.MakeInParam("@summary", SqlDbType.VarChar, 100, billinfo.Summary),
                    data.MakeInParam("@fullpayment", SqlDbType.Float, 8, billinfo.FullPayment),
                    data.MakeInParam("@payment", SqlDbType.Float, 8, billinfo.Payment),
                };
            return
                (data.RunProc(
                    "INSERT INTO " + AddTableName_trueName +
                    " (billdate, billcode, units, handle, summary, fullgathering,gathering) VALUES (@billdate,@billcode,@units,@handle,@summary,@fullpayment,@payment)",
                    prams));
        }


        /// <summary>
        ///   向明细表中添加数据－进货单－销售退货单－销售单－进货退货单
        /// </summary>
        /// <param name="billinfo"> 过账单据数据结构类对象 </param>
        /// <param name="AddTableName_trueName"> 数据库中数据表名称 </param>
        /// <returns> </returns>
        public int AddTableDetailedWarehouse(cBillInfo billinfo, string AddTableName_trueName)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@billcode", SqlDbType.VarChar, 20, billinfo.BillCode),
                    data.MakeInParam("@tradecode", SqlDbType.VarChar, 20, billinfo.TradeCode),
                    data.MakeInParam("@fullname", SqlDbType.VarChar, 20, billinfo.FullName),
                    data.MakeInParam("@unit", SqlDbType.VarChar, 10, billinfo.TradeUnit),
                    data.MakeInParam("@qty", SqlDbType.Float, 8, billinfo.Qty),
                    data.MakeInParam("@price", SqlDbType.Float, 8, billinfo.Price),
                    data.MakeInParam("@tsum", SqlDbType.Float, 8, billinfo.TSum),
                    data.MakeInParam("@billdate", SqlDbType.DateTime, 8, billinfo.BillDate),
                };
            return
                (data.RunProc(
                    "INSERT INTO " + AddTableName_trueName +
                    " (billcode, tradecode, fullname, unit, qty, price,tsum,billdate) VALUES (@billcode,@tradecode,@fullname,@unit,@qty,@price,@tsum,@billdate)",
                    prams));
        }

        /// <summary>
        ///   修改库存数量和加权平均价格
        /// </summary>
        /// <param name="stock"> 库存商品数据结构类对象 </param>
        /// <returns> </returns>
        public int UpdateStock_QtyAndAveragerprice(cStockInfo stock)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@tradecode", SqlDbType.VarChar, 5, stock.TradeCode),
                    data.MakeInParam("@qty", SqlDbType.Float, 30, stock.Qty),
                    data.MakeInParam("@price", SqlDbType.Float, 30, stock.Price),
                    data.MakeInParam("@averageprice", SqlDbType.Float, 10, stock.AveragePrice),
                };
            return
                (data.RunProc(
                    "update tb_stock set qty=@qty,price=@averageprice,averageprice=@averageprice where tradecode=@tradecode",
                    prams));
        }

        /// <summary>
        ///   修改销售商品和进货退货商品--后的库存商品数量
        /// </summary>
        /// <param name="stock"> </param>
        /// <returns> </returns>
        public int UpdateSaleStock_Qty(cStockInfo stock)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@tradecode", SqlDbType.VarChar, 5, stock.TradeCode),
                    data.MakeInParam("@qty", SqlDbType.Float, 30, stock.Qty),
                };
            return (data.RunProc("update tb_stock set qty=@qty where tradecode=@tradecode", prams));
        }

        /// <summary>
        ///   修改库存数量和销售（和进货退货）最后一次价格
        /// </summary>
        /// <param name="stock"> 库存商品数据结构类对象 </param>
        /// <returns> </returns>
        public int UpdateStock_Qty(cStockInfo stock)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@tradecode", SqlDbType.VarChar, 5, stock.TradeCode),
                    data.MakeInParam("@qty", SqlDbType.Float, 30, stock.Qty),
                    data.MakeInParam("@price", SqlDbType.Float, 30, stock.SalePrice),
                };
            return (data.RunProc("update tb_stock set qty=@qty,saleprice=@price where tradecode=@tradecode", prams));
        }

        /// <summary>
        ///   根据商品编号TradeCode,主要得到数量和加权平均价格，用于对其更新。
        /// </summary>
        /// <param name="stock"> 库存商品数据结构类对象 </param>
        /// <param name="tbName"> 映射虚拟表名称 </param>
        /// <returns> </returns>
        public DataSet GetStockByTradeCode(cStockInfo stock, string tbName)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@tradecode", SqlDbType.VarChar, 30, stock.TradeCode),
                };
            return (data.RunProcReturn("select * from tb_stock where tradecode like @tradecode", prams, tbName));
        }

        #endregion

        #region 商品进销存---往来账明细表

        /// <summary>
        ///   添加数据---往来账本明细表
        /// </summary>
        /// <param name="currentAccount"> </param>
        /// <returns> </returns>
        public int AddCurrentAccount(cCurrentAccount currentAccount)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@billdate", SqlDbType.DateTime, 8, currentAccount.BillDate),
                    data.MakeInParam("@billcode", SqlDbType.VarChar, 20, currentAccount.BillCode),
                    data.MakeInParam("@addgathering", SqlDbType.Float, 8, currentAccount.AddGathering),
                    data.MakeInParam("@factaddfee", SqlDbType.Float, 8, currentAccount.FactAddFee),
                    data.MakeInParam("@reducegathering", SqlDbType.Float, 8, currentAccount.ReduceGathering),
                    data.MakeInParam("@factfee", SqlDbType.Float, 8, currentAccount.FactReduceGathering),
                    data.MakeInParam("@balance", SqlDbType.Float, 8, currentAccount.Balance),
                    data.MakeInParam("@units", SqlDbType.VarChar, 20, currentAccount.Units),
                };
            return
                (data.RunProc(
                    "INSERT INTO tb_currentaccount (billdate, billcode, addgathering, factaddfee, reducegathering, factfee,balance,units) VALUES (@billdate,@billcode,@addgathering,@factaddfee,@reducegathering,@factfee,@balance,@units)",
                    prams));
        }

        #endregion

        #region 进货管理--进货分析

        /// <summary>
        ///   商品进货分析--不含进货退货
        /// </summary>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet BuyStockAnalyse(string tbName)
        {
            return
                (data.RunProcReturn(
                    "SELECT a.tradecode, a.fullname, a.averageprice, b.qty, b.tsum FROM tb_stock a INNER JOIN (SELECT SUM(qty) AS qty, SUM(tsum) AS tsum, fullname FROM tb_rewarehouse_detailed GROUP BY fullname) b ON a.fullname = b.fullname WHERE (a.price > 0)",
                    tbName));
        }

        /// <summary>
        ///   商品进货分析（含退货）
        /// </summary>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet BuyAllStockAnalyse(string tbName)
        {
            return
                (data.RunProcReturn(
                    "select tradecode,fullname,sum(qty) as qty,AVG(price) AS price,sum(tsum) as tsum from tb_warehouse_detailed group by tradecode,fullname",
                    tbName));
        }

        #endregion

        #region  进货管理--进货统计

        /// <summary>
        ///   进货商品－－详细统计
        /// </summary>
        /// <param name="billinfo"> </param>
        /// <param name="tbName"> </param>
        /// <param name="starDateTime"> </param>
        /// <param name="endDateTime"> </param>
        /// <returns> </returns>
        public DataSet BuyStockSumDetailed(cBillInfo billinfo, string tbName, DateTime starDateTime,
                                           DateTime endDateTime)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@units", SqlDbType.VarChar, 30, "%" + billinfo.Units + "%"),
                    data.MakeInParam("@handle", SqlDbType.VarChar, 10, "%" + billinfo.Handle + "%"),
                };
            return
                (data.RunProcReturn(
                    "SELECT b.tradecode AS 商品编号, b.fullname AS 商品名称, SUM(b.qty) AS 进货数量,SUM(b.tsum) AS 进货金额 FROM tb_warehouse_main a INNER JOIN (SELECT billcode, tradecode, fullname, SUM(qty) AS qty, SUM(tsum) AS tsum FROM tb_warehouse_detailed GROUP BY tradecode, billcode, fullname) b ON a.billcode = b.billcode AND a.units LIKE @units AND a.handle LIKE @handle WHERE (a.billdate BETWEEN '" +
                    starDateTime + "' AND '" + endDateTime + "') GROUP BY b.tradecode, b.fullname", prams, tbName));
        }

        /// <summary>
        ///   进货商品－－统计所有
        /// </summary>
        /// <param name="billinfo"> </param>
        /// <param name="tbName"> </param>
        /// <param name="starDateTime"> </param>
        /// <param name="endDateTime"> </param>
        /// <returns> </returns>
        public DataSet BuyStockSum(string tbName)
        {
            return
                (data.RunProcReturn(
                    "select tradecode as 商品编号,fullname as 商品名称,sum(qty) as 进货数量,sum(tsum)as 进货金额 from tb_warehouse_detailed group by tradecode, fullname",
                    tbName));
        }

        #endregion

        #region  销售管理--销售统计

        /// <summary>
        ///   销售商品－－详细统计
        /// </summary>
        /// <param name="billinfo"> </param>
        /// <param name="tbName"> </param>
        /// <param name="starDateTime"> </param>
        /// <param name="endDateTime"> </param>
        /// <returns> </returns>
        public DataSet SellStockSumDetailed(cBillInfo billinfo, string tbName, DateTime starDateTime,
                                            DateTime endDateTime)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@units", SqlDbType.VarChar, 30, "%" + billinfo.Units + "%"),
                    data.MakeInParam("@handle", SqlDbType.VarChar, 10, "%" + billinfo.Handle + "%"),
                };
            return
                (data.RunProcReturn(
                    "SELECT b.tradecode AS 商品编号, b.fullname AS 商品名称, SUM(b.qty) AS 销售数量,SUM(b.tsum) AS 销售金额 FROM tb_sell_main a INNER JOIN (SELECT billcode, tradecode, fullname, SUM(qty) AS qty, SUM(tsum) AS tsum FROM tb_sell_detailed GROUP BY tradecode, billcode, fullname) b ON a.billcode = b.billcode AND a.units LIKE @units AND a.handle LIKE @units WHERE (a.billdate BETWEEN '" +
                    starDateTime + "' AND '" + endDateTime + "') GROUP BY b.tradecode, b.fullname", prams, tbName));
        }

        /// <summary>
        ///   销售商品－－统计所有
        /// </summary>
        /// <param name="billinfo"> </param>
        /// <param name="tbName"> </param>
        /// <param name="starDateTime"> </param>
        /// <param name="endDateTime"> </param>
        /// <returns> </returns>
        public DataSet SellStockSum(string tbName)
        {
            return
                (data.RunProcReturn(
                    "select tradecode as 商品编号,fullname as 商品名称,sum(qty) as 销售数量,sum(tsum) as 销售金额 from tb_sell_detailed group by tradecode, fullname",
                    tbName));
        }

        #endregion

        #region 销售管理--月销售状况

        /// <summary>
        ///   统计商品销售状况
        /// </summary>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet SellStockStatusSum(string tbName)
        {
            return
                (data.RunProcReturn(
                    "select a.tradecode as 商品编号,a.fullname as 商品名称,a.qty as 销售数量,a.price AS 销售均价,a.tsum as 销售金额,b.qty2 as '退货数量',b.tsum2 as '退货金额' from (SELECT tradecode,fullname,avg(price)as price,sum(qty) AS qty, sum(tsum) as tsum from tb_sell_detailed group by tradecode,fullname) a left join (SELECT tradecode,fullname,sum(qty) AS qty2, sum(tsum) as tsum2 from tb_resell_detailed group by tradecode,fullname) b on a.tradecode=b.tradecode ",
                    tbName));
        }

        /// <summary>
        ///   明细账本－－－‘商品销售’和‘商品销售退货’
        /// </summary>
        /// <param name="strTradeCode"> </param>
        /// <param name="starDateTime"> </param>
        /// <param name="endDateTime"> </param>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet SellStockDetailed(string strTradeCode, DateTime starDateTime, DateTime endDateTime, string tbName)
        {
            return
                (data.RunProcReturn(
                    "SELECT billdate as 销售日期, billcode as 单据编号, tradecode as 商品编号, fullname as 商品名称, price as 销售价格, qty as 销售数量, tsum as 销售金额 FROM " +
                    tbName + " where tradecode = '" + strTradeCode + "' AND billdate BETWEEN '" + starDateTime +
                    "' AND '" + endDateTime + "'", tbName));
        }

        #endregion

        #region 销售管理--商品销售排行

        /// <summary>
        ///   设置排行榜条件－－往来单位-下拉列表
        /// </summary>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet SetUnitsList(string tbName)
        {
            return (data.RunProcReturn("select * from tb_units", tbName));
        }

        /// <summary>
        ///   设置排行榜条件－－经手人-下拉列表
        /// </summary>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet SetHandleList(string tbName)
        {
            return (data.RunProcReturn("select * from tb_employee", tbName));
        }

        /// <summary>
        ///   按销售金额排行
        /// </summary>
        /// <param name="handle"> </param>
        /// <param name="units"> </param>
        /// <param name="StarDateTime"> </param>
        /// <param name="EndDateTime"> </param>
        /// <returns> </returns>
        public DataSet GetTSumDesc(string handle, string units, DateTime StarDateTime, DateTime EndDateTime,
                                   string tbName)
        {
            return
                (data.RunProcReturn(
                    "SELECT * FROM (SELECT b.tradecode AS 商品编号, b.fullname AS 商品名称, SUM(b.qty) AS 销售数量, SUM(b.tsum) AS 销售金额 FROM tb_sell_main a INNER JOIN (SELECT billcode, tradecode, fullname, SUM(qty) AS qty, SUM(tsum) AS tsum FROM tb_sell_detailed GROUP BY tradecode, billcode, fullname) b ON a.billcode = b.billcode AND a.units LIKE '%" +
                    units + "%' AND a.handle LIKE '%" + handle + "%' WHERE (a.billdate BETWEEN '" + StarDateTime +
                    "' AND '" + EndDateTime + "')GROUP BY b.tradecode, b.fullname) DERIVEDTBL ORDER BY 销售金额 DESC",
                    tbName));
        }

        /// <summary>
        ///   按销售数量排行
        /// </summary>
        /// <param name="handle"> </param>
        /// <param name="units"> </param>
        /// <param name="StarDateTime"> </param>
        /// <param name="EndDateTime"> </param>
        /// <returns> </returns>
        public DataSet GetQtyDesc(string handle, string units, DateTime StarDateTime, DateTime EndDateTime,
                                  string tbName)
        {
            return
                (data.RunProcReturn(
                    "SELECT * FROM (SELECT b.tradecode AS 商品编号, b.fullname AS 商品名称, SUM(b.qty) AS 销售数量, SUM(b.tsum) AS 销售金额 FROM tb_sell_main a INNER JOIN (SELECT billcode, tradecode, fullname, SUM(qty) AS qty, SUM(tsum) AS tsum FROM tb_sell_detailed GROUP BY tradecode, billcode, fullname) b ON a.billcode = b.billcode AND a.units LIKE '%" +
                    units + "%' AND a.handle LIKE '%" + handle + "%' WHERE (a.billdate BETWEEN '" + StarDateTime +
                    "' AND '" + EndDateTime + "')GROUP BY b.tradecode, b.fullname) DERIVEDTBL ORDER BY 销售数量 DESC",
                    tbName));
        }

        #endregion

        #region 销售管理--商品销售成本明细

        /// <summary>
        ///   根据单据编号--得到销售明细表中数据
        /// </summary>
        /// <param name="stock"> </param>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet GetDetailedkByBillCode(string billCode, string tbName)
        {
            return
                (data.RunProcReturn(
                    "SELECT tradecode,fullname,price,tsum,SUM(qty) AS qty FROM tb_sell_detailed WHERE (billcode = '" +
                    billCode + "')group by tradecode,fullname,price,tsum", tbName));
        }

        /// <summary>
        ///   根据单据编号--得到销售明细表中数据
        /// </summary>
        /// <param name="stock"> </param>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet GetStockByTradeCode(string tradeCode, string tbName)
        {
            return (data.RunProcReturn("select * from tb_stock where tradecode ='" + tradeCode + "'", tbName));
        }

        /// <summary>
        ///   根据日期－－查询销售主表中数据
        /// </summary>
        /// <param name="starDataTime"> </param>
        /// <param name="endDataTime"> </param>
        /// <returns> </returns>
        public DataSet FindSellStock(DateTime starDataTime, DateTime endDataTime)
        {
            return
                (data.RunProcReturn(
                    "select * from tb_sell_main where (billdate BETWEEN '" + starDataTime + " ' AND '" + endDataTime +
                    " ')", "tb_sell_main"));
        }

        #endregion

        #region 库存管理--库存状况

        /// <summary>
        ///   检索库存商品--并按数量排序
        /// </summary>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet setStockStatus(string tbName)
        {
            return (data.RunProcReturn("select * from tb_stock order by qty", tbName));
        }

        /// <summary>
        ///   根据商品编号，获得库存商品中所有信息
        /// </summary>
        /// <param name="tradeCode"> </param>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet GetStockLimitByTradeCode(string tradeCode, string tbName)
        {
            return (data.RunProcReturn("select * from tb_Stock where tradecode='" + tradeCode + "'", tbName));
        }

        /// <summary>
        ///   库存商品上下限设置
        /// </summary>
        /// <param name="stock"> </param>
        /// <returns> </returns>
        public int UpdateStockLimit(cStockInfo stock)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@tradecode", SqlDbType.VarChar, 5, stock.TradeCode),
                    data.MakeInParam("@upperlimit", SqlDbType.Float, 8, stock.UpperLimit),
                    data.MakeInParam("@lowerlimit", SqlDbType.Float, 8, stock.LowerLimit),
                };
            return
                (data.RunProc(
                    "update tb_stock set upperlimit=@upperlimit,lowerlimit=@lowerlimit where tradecode=@tradecode",
                    prams));
        }

        #endregion

        #region 库存商品上下限报警

        /// <summary>
        ///   库存商品下限报警
        /// </summary>
        /// <returns> </returns>
        public DataSet GetLowerLimit()
        {
            return
                (data.RunProcReturn(
                    "SELECT tradecode as 商品编号, fullname as 商品名称, qty as 库存数量,upperlimit as 库存上限,lowerlimit as 库存下限 from tb_stock WHERE (qty < lowerlimit) and lowerlimit > 0",
                    "tb_stock"));
        }

        /// <summary>
        ///   库存商品上限报警
        /// </summary>
        /// <returns> </returns>
        public DataSet GetUpperLimit()
        {
            return
                (data.RunProcReturn(
                    "SELECT tradecode as 商品编号, fullname as 商品名称, qty as 库存数量,upperlimit as 库存上限,lowerlimit as 库存下限 FROM tb_stock WHERE (upperlimit < qty) and upperlimit>0",
                    "tb_stock"));
        }

        #endregion

        #region 库存盘点

        public int CheckStock(cStockInfo stock)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@tradecode", SqlDbType.VarChar, 5, stock.TradeCode),
                    data.MakeInParam("@check", SqlDbType.Float, 8, stock.Check),
                };
            return (data.RunProc("update tb_stock set stockcheck=@check where tradecode=@tradecode", prams));
        }

        #endregion

        #region 本单位信息设置--系统设置

        /// <summary>
        ///   本单位信息设置
        /// </summary>
        /// <param name="units"> </param>
        /// <returns> </returns>
        public int UpdateSysUnits(cUnits units)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@fullname", SqlDbType.VarChar, 30, units.FullName),
                    data.MakeInParam("@tax", SqlDbType.VarChar, 30, units.Tax),
                    data.MakeInParam("@tel", SqlDbType.VarChar, 20, units.Tel),
                    data.MakeInParam("@linkman", SqlDbType.VarChar, 10, units.Linkman),
                    data.MakeInParam("@address", SqlDbType.VarChar, 60, units.Address),
                    data.MakeInParam("@accounts", SqlDbType.VarChar, 80, units.Accounts),
                };
            return
                (data.RunProc(
                    "update tb_unit set fullname=@fullname,tax=@tax,tel=@tel,linkman=@linkman,address=@address,accounts=@accounts",
                    prams));
        }

        public int InsertSysUnits(cUnits units)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@fullname", SqlDbType.VarChar, 30, units.FullName),
                    data.MakeInParam("@tax", SqlDbType.VarChar, 30, units.Tax),
                    data.MakeInParam("@tel", SqlDbType.VarChar, 20, units.Tel),
                    data.MakeInParam("@linkman", SqlDbType.VarChar, 10, units.Linkman),
                    data.MakeInParam("@address", SqlDbType.VarChar, 60, units.Address),
                    data.MakeInParam("@accounts", SqlDbType.VarChar, 80, units.Accounts),
                };
            return
                (data.RunProc(
                    "insert into tb_unit (fullname,tax,tel,linkman,address,accounts) values (@fullname,@tax,@tel,@linkman,@address,@accounts)",
                    prams));
        }

        /// <summary>
        ///   得到本单位信息设置
        /// </summary>
        /// <param name="tbName"> </param>
        /// <returns> </returns>
        public DataSet GetAllUnit()
        {
            return (data.RunProcReturn("select * from tb_unit", "tb_unit"));
        }

        #endregion

        #region  数据库备份与恢复--系统设置

        /// <summary>
        ///   备份数据库
        /// </summary>
        /// <param name="bakUpName"> </param>
        public void BackUp(string bakUpName)
        {
            data.RunProc("BACKUP DATABASE db_EMS TO DISK ='" + bakUpName + "'");
        }

        /// <summary>
        ///   恢复数据库
        /// </summary>
        /// <param name="reStoreName"> </param>
        public void ReStore(string reStoreName)
        {
            data.RunProc("backup log db_EMS to disk='" + reStoreName + "'use master RESTORE DATABASE db_EMS from disk='" +
                         reStoreName + "'");
        }

        #endregion

        #region  系统数据清理--系统设置

        /// <summary>
        ///   根据指定的数据表清除数据表中数据
        /// </summary>
        /// <param name="tbName_true"> </param>
        public void ClearTable(string tbName_true)
        {
            data.RunProc("delete from " + tbName_true + "");
        }

        #endregion

        #region 系统操作员及权限设置--系统设置

        /// <summary>
        ///   添加系统操作员
        /// </summary>
        /// <param name="userName"> </param>
        /// <param name="pwd"> </param>
        public void AddSysUser(string userName, string pwd)
        {
            data.RunProc("INSERT INTO tb_power (sysuser, password) VALUES ('" + userName + "', '" + pwd + "')");
        }

        /// <summary>
        ///   删除系统操作员
        /// </summary>
        /// <param name="ID"> </param>
        public void DeleteSysUser(int ID)
        {
            data.RunProc("delete from tb_power where id='" + ID + "'");
        }

        /// <summary>
        ///   获得所有系统用户信息
        /// </summary>
        /// <returns> </returns>
        public DataSet GetAllUser()
        {
            return (data.RunProcReturn("select * from tb_power", "tb_Power"));
        }

        /// <summary>
        ///   根据用户名称---查询系统用户
        /// </summary>
        /// <param name="userName"> </param>
        /// <returns> </returns>
        public bool FindUserName(string userName)
        {
            DataSet ds = null;
            ds = data.RunProcReturn("select * from tb_power where sysuser='" + userName + "'", "tb_power");
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        ///   修改系统用户信息及所对应的权限
        /// </summary>
        /// <param name="popedom"> </param>
        public void UpdateSysUser(cPopedom popedom)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@id", SqlDbType.Int, 4, popedom.ID),
                    data.MakeInParam("@sysuser", SqlDbType.VarChar, 20, popedom.SysUser),
                    data.MakeInParam("@password", SqlDbType.VarChar, 20, popedom.Password),
                    data.MakeInParam("@stock", SqlDbType.Bit, 1, popedom.Stock),
                    data.MakeInParam("@vendition", SqlDbType.Bit, 1, popedom.Vendition),
                    data.MakeInParam("@storage", SqlDbType.Bit, 1, popedom.Storage),
                    data.MakeInParam("@system", SqlDbType.Bit, 1, popedom.SystemSet),
                    data.MakeInParam("@base", SqlDbType.Bit, 1, popedom.Base_Info),
                };
            int i =
                data.RunProc(
                    "update tb_power set sysuser=@sysuser,password=@password,stock=@stock,vendition=@vendition,storage=@storage,system=@system,base=@base where id=@id",
                    prams);
        }

        #endregion

        #region 往来单位对账

        /// <summary>
        ///   往来单位列表--并统计应收额-增加及减少
        /// </summary>
        /// <returns> </returns>
        public DataSet GetUnitsList()
        {
            return
                (data.RunProcReturn(
                    "SELECT units as 往来单位, SUM(addgathering) AS 应收增加, SUM(reducegathering) AS 应收减少 FROM tb_currentaccount GROUP BY units",
                    "tb_currentaccount"));
        }

        ///<summary>
        ///  查询在指定的日期段中--是否存在－－查询结果
        ///</summary>
        ///<param name="units"> </param>
        ///<param name="starDateTime"> </param>
        ///<param name="endDateTime"> </param>
        ///<returns> </returns>
        public DataSet FindCurrentAccountDate(string units, DateTime starDateTime, DateTime endDateTime)
        {
            return
                (data.RunProcReturn(
                    "SELECT * FROM tb_currentaccount WHERE units='" + units + "' AND billdate BETWEEN '" + starDateTime +
                    "'AND '" + endDateTime + "'", "tb_currentaccount"));
        }

        /// <summary>
        ///   往来对账－－根据单据编号--查询明细表中数据
        /// </summary>
        /// <param name="billcode"> </param>
        /// <param name="tb_Detailed_true"> </param>
        /// <returns> </returns>
        public DataSet FindDetailde(string tb_Detailed_true, string billcode)
        {
            return
                (data.RunProcReturn(
                    "select * from " + tb_Detailed_true + " where (billcode='" + billcode + "')ORDER BY tsum",
                    "detailed"));
        }

        /// <summary>
        ///   往来对账－－根据单据编号--查询主表中数据
        /// </summary>
        /// <param name="tb_Main_true"> </param>
        /// <param name="billcode"> </param>
        /// <returns> </returns>
        public DataSet FindMain(string tb_Main_true, string billcode)
        {
            return (data.RunProcReturn("select * from " + tb_Main_true + " where billcode='" + billcode + "'", "main"));
        }

        #endregion

        #region 辅助工具管理

        //ShellExecute Me.hWnd, "open", "http://www.mingrisoft.com", 1, 1, 5
        public void OpenInernet()
        {
        }

        #endregion

        #region 系统登录

        /// <summary>
        ///   系统登录
        /// </summary>
        /// <param name="popedom"> </param>
        /// <returns> </returns>
        public DataSet Login(cPopedom popedom)
        {
            SqlParameter[] prams =
                {
                    data.MakeInParam("@sysuser", SqlDbType.VarChar, 20, popedom.SysUser),
                    data.MakeInParam("@password", SqlDbType.VarChar, 20, popedom.Password),
                };
            return
                (data.RunProcReturn("SELECT * FROM tb_power WHERE (sysuser = @sysuser) AND (password = @password)",
                                    prams, "tb_power"));
        }

        #endregion
    }

    #region 定义往来单位--数据结构

    public class cUnitsInfo
    {
        private string accounts = "";
        private string address = "";
        private string fullname = "";
        private float gathering;
        private string linkman = "";
        private float payment;
        private string tax = "";
        private string tel = "";
        private string unitcode = "";

        /// <summary>
        ///   单位编号
        /// </summary>
        public string UnitCode
        {
            get { return unitcode; }
            set { unitcode = value; }
        }

        /// <summary>
        ///   单位全称
        /// </summary>
        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }

        /// <summary>
        ///   单位税号
        /// </summary>
        public string Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        /// <summary>
        ///   联系人
        /// </summary>
        public string LinkMan
        {
            get { return linkman; }
            set { linkman = value; }
        }

        /// <summary>
        ///   联系电话
        /// </summary>
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        /// <summary>
        ///   单位地址
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        ///   开户行及账号
        /// </summary>
        public string Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        /// <summary>
        ///   累计应收款
        /// </summary>
        public float Gathering
        {
            get { return gathering; }
            set { gathering = value; }
        }

        /// <summary>
        ///   累计应付款
        /// </summary>
        public float Payment
        {
            get { return payment; }
            set { payment = value; }
        }
    }

    #endregion

    #region 定义库存商品--数据结构

    public class cStockInfo
    {
        private float averageprice;
        private float check;
        private string fullname = "";
        private float lowerlimit;
        private float price;
        private string produce = "";
        private float qty;
        private float saleprice;
        private string standard = "";
        private string tradecode = "";
        private string tradetpye = "";
        private string tradeunit = "";
        private float upperlimit;

        /// <summary>
        ///   商品编号
        /// </summary>
        public string TradeCode
        {
            get { return tradecode; }
            set { tradecode = value; }
        }

        /// <summary>
        ///   单位全称
        /// </summary>
        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }

        /// <summary>
        ///   商品型号
        /// </summary>
        public string TradeType
        {
            get { return tradetpye; }
            set { tradetpye = value; }
        }

        /// <summary>
        ///   商品规格
        /// </summary>
        public string Standard
        {
            get { return standard; }
            set { standard = value; }
        }

        /// <summary>
        ///   商品单位
        /// </summary>
        public string Unit
        {
            get { return tradeunit; }
            set { tradeunit = value; }
        }

        /// <summary>
        ///   商品产地
        /// </summary>
        public string Produce
        {
            get { return produce; }
            set { produce = value; }
        }

        /// <summary>
        ///   库存数量
        /// </summary>
        public float Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        /// <summary>
        ///   进货时最后一次价格
        /// </summary>
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        ///   加权平均价格
        /// </summary>
        public float AveragePrice
        {
            get { return averageprice; }
            set { averageprice = value; }
        }

        /// <summary>
        ///   销售时的最后一次销价
        /// </summary>
        public float SalePrice
        {
            get { return saleprice; }
            set { saleprice = value; }
        }

        /// <summary>
        ///   盘点数量
        /// </summary>
        public float Check
        {
            get { return check; }
            set { check = value; }
        }

        /// <summary>
        ///   库存报警上限
        /// </summary>
        public float UpperLimit
        {
            get { return upperlimit; }
            set { upperlimit = value; }
        }

        /// <summary>
        ///   库存报警下限
        /// </summary>
        public float LowerLimit
        {
            get { return lowerlimit; }
            set { lowerlimit = value; }
        }
    }

    #endregion

    #region 定义公司职员--数据结构

    public class cEmployeeInfo
    {
        private string dept = "";
        private string employeecode = "";
        private string fullname = "";
        private string memo = "";
        private string sex = "";
        private string tel = "";

        /// <summary>
        ///   职员编号
        /// </summary>
        public string EmployeeCode
        {
            get { return employeecode; }
            set { employeecode = value; }
        }

        /// <summary>
        ///   职员姓名
        /// </summary>
        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }

        /// <summary>
        ///   职员性别
        /// </summary>
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        /// <summary>
        ///   所在部门
        /// </summary>
        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        /// <summary>
        ///   职员电话
        /// </summary>
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        /// <summary>
        ///   备注信息
        /// </summary>
        public string Memo
        {
            get { return memo; }
            set { memo = value; }
        }
    }

    #endregion

    #region 定义过账单据--数据结构

    public class cBillInfo
    {
        //主表结构
        private string billcode = "";
        private DateTime billdate = DateTime.Now;
        private string fullname = "";
        private float fullpayment;
        private string handle = "";
        private float payment;
        private float price;
        private float qty;
        private string summary = "";

        //明细表结构
        private string tradecode = "";
        private string tradeunit = "";
        private float tsum;
        private string units = "";

        /// <summary>
        ///   录单日期
        /// </summary>
        public DateTime BillDate
        {
            get { return billdate; }
            set { billdate = value; }
        }

        /// <summary>
        ///   单据编号
        /// </summary>
        public string BillCode
        {
            get { return billcode; }
            set { billcode = value; }
        }

        /// <summary>
        ///   供货单位
        /// </summary>
        public string Units
        {
            get { return units; }
            set { units = value; }
        }

        /// <summary>
        ///   经手人
        /// </summary>
        public string Handle
        {
            get { return handle; }
            set { handle = value; }
        }

        /// <summary>
        ///   摘要
        /// </summary>
        public string Summary
        {
            get { return summary; }
            set { summary = value; }
        }

        /// <summary>
        ///   应付金额
        /// </summary>
        public float FullPayment
        {
            get { return fullpayment; }
            set { fullpayment = value; }
        }

        /// <summary>
        ///   实付金额
        /// </summary>
        public float Payment
        {
            get { return payment; }
            set { payment = value; }
        }

        //***************明细表结构******************//
        /// <summary>
        ///   商品编号
        /// </summary>
        public string TradeCode
        {
            get { return tradecode; }
            set { tradecode = value; }
        }

        /// <summary>
        ///   商品名称
        /// </summary>
        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }

        /// <summary>
        ///   商品单位
        /// </summary>
        public string TradeUnit
        {
            get { return tradeunit; }
            set { tradeunit = value; }
        }

        /// <summary>
        ///   数量
        /// </summary>
        public float Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        /// <summary>
        ///   价格
        /// </summary>
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        ///   金额=数量*价格
        /// </summary>
        public float TSum
        {
            get { return tsum; }
            set { tsum = value; }
        }
    }

    #endregion

    #region 定义往来账本明细--数据结构

    public class cCurrentAccount
    {
        private float addgathering; //应收增加
        private float balance; //应收与增加 差额
        private string billcode = "";
        private DateTime billdate = DateTime.Now;
        private float factaddfee; //实际增加
        private float factreducegathering; //实际减少
        private float reducegathering; //应收减少
        private string units = "";

        /// <summary>
        ///   录单日期
        /// </summary>
        public DateTime BillDate
        {
            get { return billdate; }
            set { billdate = value; }
        }

        /// <summary>
        ///   单据编号
        /// </summary>
        public string BillCode
        {
            get { return billcode; }
            set { billcode = value; }
        }

        /// <summary>
        ///   应收增加
        /// </summary>
        public float AddGathering
        {
            get { return addgathering; }
            set { addgathering = value; }
        }

        /// <summary>
        ///   实际增加
        /// </summary>
        public float FactAddFee
        {
            get { return factaddfee; }
            set { factaddfee = value; }
        }

        /// <summary>
        ///   应收减少
        /// </summary>
        public float ReduceGathering
        {
            get { return reducegathering; }
            set { reducegathering = value; }
        }

        /// <summary>
        ///   实际减少
        /// </summary>
        public float FactReduceGathering
        {
            get { return factreducegathering; }
            set { factreducegathering = value; }
        }

        /// <summary>
        ///   余额(应收金额-实际金额)
        /// </summary>
        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        /// <summary>
        ///   往来单位
        /// </summary>
        public string Units
        {
            get { return units; }
            set { units = value; }
        }
    }

    #endregion

    #region 定义本单位信息设置--数据结构

    public class cUnits
    {
        private string accounts = "";
        private string address = "";
        private string fullname = "";
        private string linkman = "";
        private string tax = "";
        private string tel = "";

        /// <summary>
        ///   单位全称
        /// </summary>
        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }

        /// <summary>
        ///   税号
        /// </summary>
        public string Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        /// <summary>
        ///   单位电话
        /// </summary>
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        /// <summary>
        ///   联系人
        /// </summary>
        public string Linkman
        {
            get { return linkman; }
            set { linkman = value; }
        }

        /// <summary>
        ///   联系地址
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        ///   开户行及账号
        /// </summary>
        public string Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }
    }

    #endregion

    #region 定义往来账明细表－－－数据结构

    public class cCurrentaccount
    {
        private float addgathering;
        private float balance;
        private string billcode = "";
        private DateTime billdate = DateTime.Now;
        private float factaddfee;
        private float factfee;
        private float reducegathering;
        private string units = "";

        /// <summary>
        ///   录单日期
        /// </summary>
        public DateTime BillDate
        {
            get { return billdate; }
            set { billdate = value; }
        }

        /// <summary>
        ///   单据编号
        /// </summary>
        public string BillCode
        {
            get { return billcode; }
            set { billcode = value; }
        }

        /// <summary>
        ///   应收增加
        /// </summary>
        public float AddGathering
        {
            get { return addgathering; }
            set { addgathering = value; }
        }

        /// <summary>
        ///   实际增加
        /// </summary>
        public float FactAddfee
        {
            get { return factaddfee; }
            set { factaddfee = value; }
        }

        /// <summary>
        ///   应收减少
        /// </summary>
        public float ReduceGathering
        {
            get { return reducegathering; }
            set { reducegathering = value; }
        }

        /// <summary>
        ///   实际减少
        /// </summary>
        public float FactFee
        {
            get { return factfee; }
            set { factfee = value; }
        }

        /// <summary>
        ///   应收余额
        /// </summary>
        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        /// <summary>
        ///   往来单位
        /// </summary>
        public string Units
        {
            get { return units; }
            set { units = value; }
        }
    }

    #endregion

    #region 定义权限－－数据结构

    public class cPopedom
    {
        private Boolean base_info;
        private int id;
        private string password = "";
        private Boolean stock;
        private Boolean storage;
        private Boolean system;
        private string sysuser = "";
        private Boolean vendition;

        /// <summary>
        ///   ID
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        ///   用户名称
        /// </summary>
        public string SysUser
        {
            get { return sysuser; }
            set { sysuser = value; }
        }

        /// <summary>
        ///   用户密码
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        ///   进货权限
        /// </summary>
        public Boolean Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        /// <summary>
        ///   销售权限
        /// </summary>
        public Boolean Vendition
        {
            get { return vendition; }
            set { vendition = value; }
        }

        /// <summary>
        ///   库存权限
        /// </summary>
        public Boolean Storage
        {
            get { return storage; }
            set { storage = value; }
        }

        /// <summary>
        ///   系统设置权限
        /// </summary>
        public Boolean SystemSet
        {
            get { return system; }
            set { system = value; }
        }

        /// <summary>
        ///   基本信息权限
        /// </summary>
        public Boolean Base_Info
        {
            get { return base_info; }
            set { base_info = value; }
        }
    }

    #endregion
}