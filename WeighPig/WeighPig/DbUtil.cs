using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WeighPig
{
    static class DbUtil
    {
        public static string Conn = "Database='xy_pig_data';Data Source='localhost';User Id='collecter';Password='xy123456';charset='utf8';pooling=true;Allow User Variables=True;";
        //public static string Conn = "Database='pig';Data Source='123.150.143.151';User Id='root';Password='jqt2017*';charset='utf8';pooling=true;Allow User Variables=True;";

        /// <summary>
        /// 查询按钮list
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static List<LabelItem> queryButtons(string sql)
        {
            List<LabelItem> buttons = new List<LabelItem>();
            MySqlConnection conn = new MySqlConnection(Conn);
            try
            {
                //打开连接  
                conn.Open();

                #region//查询数据
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            LabelItem bi1 = new LabelItem();
                            bi1.id = reader.GetInt32(0);
                            bi1.name = reader.GetString(1);
                            bi1.btn = reader.GetString(2);
                            buttons.Add(bi1);
                        }
                    }
                    return buttons;
                }
                catch (Exception)
                {
                    return buttons;
                }
                finally
                {
                    reader.Close();
                }
                #endregion
            }
            catch (Exception ex)
            {
                return buttons;
            }
            finally
            {
                //调用Close方法即使关闭连接   
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 保存标签
        /// </summary>
        /// <param name="buttons"></param>
        /// <returns></returns>
        public static bool saveButtons(List<LabelItem> buttons)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            try
            {
                //打开连接  
                conn.Open();

                StringBuilder strSql = new StringBuilder();
                foreach (LabelItem b in buttons)
                {
                    strSql.AppendFormat(@"update t_labels set name = '{1}',btn='{2}' where id={0};", b.id, b.name, b.btn);
                }
                MySqlCommand cmd_insert = new MySqlCommand(strSql.ToString(), conn);
                try
                {
                    cmd_insert.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                //调用Close方法即使关闭连接   
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 新增标签
        /// </summary>
        /// <param name="labelItem"></param>
        /// <returns></returns>
        public static bool insertLabelItem(LabelItem labelItem)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            try
            {
                //打开连接  
                conn.Open();

                #region//插入数据
                StringBuilder strSql = new StringBuilder();
                strSql.AppendFormat(@"insert into t_labels (name, btn, life_cycle) values('{0}', '{1}', '{2}')",
                                labelItem.name,
                                labelItem.btn,
                                labelItem.life_cycle);
                MySqlCommand cmd_insert = new MySqlCommand(strSql.ToString(), conn);
                try
                {
                    cmd_insert.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                #endregion
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                //调用Close方法即使关闭连接   
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 修改标签
        /// </summary>
        /// <param name="weights"></param>
        /// <returns></returns>
        public static bool updateLabelItem(LabelItem lableItem)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            try
            {
                //打开连接  
                conn.Open();

                StringBuilder strSql = new StringBuilder();
                strSql.AppendFormat(@"update t_labels set name='{0}',btn='{1}',life_cycle='{2}' where id={3}",
                                lableItem.name,
                                lableItem.btn,
                                lableItem.life_cycle,
                                lableItem.id);

                MySqlCommand cmd_insert = new MySqlCommand(strSql.ToString(), conn);
                try
                {
                    cmd_insert.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                //调用Close方法即使关闭连接   
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        /// <summary>
        /// 查询明细list
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static List<Weights> queryWeights(string sql)
        {
            List<Weights> weights = new List<Weights>();
            MySqlConnection conn = new MySqlConnection(Conn);
            try
            {
                //打开连接  
                conn.Open();

                #region//查询数据
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            Weights w = new Weights();
                            w.id = reader.GetString(0);
                            w.sn = reader.GetInt32(1);
                            w.create_time = reader.GetString(2);
                            w.weight = reader.GetString(3);
                            w.level = reader.GetString(4);
                            w.remarks = reader.GetString(5);
                            w.type = reader.GetString(6);
                            w.is_upload = reader.GetInt32(7);
                            w.life_cycle = reader.GetInt32(8);
                            w.is_handwrite = reader.GetInt32(9);
                            w.row_num = reader.GetInt32(10);
                            weights.Add(w);
                        }
                    }
                    return weights;
                }
                catch (Exception ex)
                {
                    return weights;
                }
                finally
                {
                    reader.Close();
                }
                #endregion
            }
            catch (Exception ex)
            {
                return weights;
            }
            finally
            {
                //调用Close方法即使关闭连接   
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 保存明细
        /// </summary>
        /// <param name="weights"></param>
        /// <returns></returns>
        public static bool insertWeight(Weights weights)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            try
            {
                //打开连接  
                conn.Open();

                #region//插入数据
                StringBuilder strSql = new StringBuilder();
                strSql.AppendFormat(@"insert into t_weights (id, sn, create_time, weight, level, remarks, type, is_upload, life_cycle, is_handwrite)
                values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                                weights.id,
                                weights.sn,
                                weights.create_time,
                                weights.weight,
                                weights.level,
                                weights.remarks,
                                weights.type,
                                weights.is_upload,
                                weights.life_cycle,
                                weights.is_handwrite);
                MySqlCommand cmd_insert = new MySqlCommand(strSql.ToString(), conn);
                try
                {
                    cmd_insert.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                #endregion
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                //调用Close方法即使关闭连接   
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 修改明细
        /// </summary>
        /// <param name="weights"></param>
        /// <returns></returns>
        public static bool updateWeight(Weights weights)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            try
            {
                //打开连接  
                conn.Open();

                StringBuilder strSql = new StringBuilder();
                strSql.AppendFormat(@"update t_weights set sn='{0}',weight='{1}',level='{2}',remarks='{3}',type='{4}', is_upload={5}, life_cycle={6} where id='{7}'", 
                                weights.sn, 
                                weights.weight, 
                                weights.level,
                                weights.remarks,
                                weights.type, 
                                weights.is_upload,
                                weights.life_cycle,
                                weights.id);

                MySqlCommand cmd_insert = new MySqlCommand(strSql.ToString(), conn);
                try
                {
                    cmd_insert.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                //调用Close方法即使关闭连接   
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 查询统计list
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static List<Reports> queryReports(string sql)
        {
            List<Reports> reports = new List<Reports>();
            MySqlConnection conn = new MySqlConnection(Conn);
            try
            {
                //打开连接  
                conn.Open();

                #region//查询数据
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            Reports r = new Reports();
                            r.report_level = reader.GetString(0);
                            r.report_count = reader.GetInt32(1);
                            r.report_weight = reader.GetDouble(2);
                            r.report_average = reader.GetDouble(3);
                            reports.Add(r);
                        }
                    }
                    return reports;
                }
                catch (Exception)
                {
                    return reports;
                }
                finally
                {
                    reader.Close();
                }
                #endregion
            }
            catch (Exception ex)
            {
                return reports;
            }
            finally
            {
                //调用Close方法即使关闭连接   
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static bool edit(string sql)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            try
            {
                //打开连接  
                conn.Open();
                #region//修改数据
                string result = "未执行";
                MySqlCommand cmd_update = new MySqlCommand(sql, conn);
                try
                {
                    cmd_update.ExecuteNonQuery();
                    result = "修改成功";
                    return true;
                }
                catch (Exception ex)
                {
                    result = "修改失败" + ex.Message;
                    return false;
                }
                #endregion
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                //调用Close方法即使关闭连接   
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static void delete(string sql)
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            try
            {
                //打开连接  
                conn.Open();
                string result = "未执行";
                MySqlCommand cmd_delete = new MySqlCommand(sql, conn);
                try
                {
                    cmd_delete.ExecuteNonQuery();
                    result = "删除成功";
                }
                catch (Exception ex)
                {

                    result = "删除失败" + ex.Message;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                //调用Close方法即使关闭连接   
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
