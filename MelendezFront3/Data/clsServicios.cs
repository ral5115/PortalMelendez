using MelendezFront3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MelendezFront3.Data
{
    public class clsServicios : clsDatos
    {
        public string sp_Validar_Usuario(string user, string pass)
        {
            DataSet ds = new DataSet();
            sqlComando.Connection = sqlConnection;
            sqlComando.Connection.Open();
            sqlComando.CommandType = CommandType.StoredProcedure;
            sqlComando.CommandText = "sp_ValidarUsuario";
            sqlComando.Parameters.AddWithValue("@Nombre", user);
            sqlComando.Parameters.AddWithValue("@Clave", pass);
            sqlAdaptador.SelectCommand = sqlComando;

            try
            {
                sqlAdaptador.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return "1";
                    }
                    else
                    {
                        return "0";
                    }
                }
                else
                {
                    return "0";
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlComando.Parameters.Clear();
                sqlComando.Connection.Close();
            }



        }

        public DataSet sp_Fuente_datos(Home data)
        {
            List<string> ls = new List<string>();

            if (data.InterfazId == "16")
            {
                ls.Add("Documento_Servicios");
                ls.Add("Movimiento_Servicios");
                ls.Add("Retenciones");
                ls.Add("Cuotas_CxC_2");
                ls.Add("Cuotas_CxC_1");
                
            }
            else if(data.InterfazId == "20")
            {
                ls.Add("Documento_Contable");
                ls.Add("Movimiento_Contable");
                ls.Add("Movimiento_CxC");
                ls.Add("Movimiento_CxP");
            }
            else
            {
                ls.Add("Inicial");
                ls.Add("Documento_Contable");
                ls.Add("Movimiento_Contable");
                ls.Add("Movimiento_CxC");
                ls.Add("Movimiento_CxP");
                ls.Add("Final");
            }

            var sp = sp_Interfaz(data.InterfazId);

            DataSet ds = new DataSet();
            sqlComando.Connection = sqlConnection;
            sqlComando.CommandType = CommandType.StoredProcedure;

            sqlComando.CommandText = sp.Tables[0].Rows[0]["sp"].ToString();

            sqlAdaptador.SelectCommand = sqlComando;
            sqlAdaptador.SelectCommand.CommandTimeout = 99999;

            try
            {

                for (int i = 0; i < ls.Count; i++)
                {
                    var dsTmpDatosOrigen = new DataSet();
                    sqlComando.Parameters.AddWithValue("@FechaIni", data.FechaIni.ToString("yyyyMMdd"));
                    sqlComando.Parameters.AddWithValue("@FechaFin", data.FechaFin.ToString("yyyyMMdd"));
                    sqlComando.Parameters.AddWithValue("@Lote", data.Lote);
                    sqlComando.Parameters.AddWithValue("@Compania", data.Empresa[0].Value.ToString());
                    sqlComando.Parameters.AddWithValue("@ind", i + 1);
                    sqlAdaptador.Fill(dsTmpDatosOrigen);
                    dsTmpDatosOrigen.Tables[0].TableName = ls[i].ToString();
                    ds.Tables.Add(dsTmpDatosOrigen.Tables[0].Copy());
                    sqlComando.Parameters.Clear();


                }

                return ds;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlComando.Parameters.Clear();
                sqlComando.Connection.Close();
            }



        }

        public DataSet sp_Interfaz(string id)
        {
            DataSet ds = new DataSet();
            sqlComando.Connection = sqlConnection;
            sqlComando.CommandType = CommandType.StoredProcedure;
            sqlComando.CommandText = "sp_Interfaz";
            sqlComando.Parameters.AddWithValue("@id", id);
            sqlAdaptador.SelectCommand = sqlComando;

            try
            {
                sqlAdaptador.Fill(ds);
                return ds;
                //return ds.Tables[0].Rows[0]["sp"].ToString();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlComando.Parameters.Clear();
                sqlComando.Connection.Close();
            }



        }
    }
}