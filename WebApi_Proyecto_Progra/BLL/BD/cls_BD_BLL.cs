using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using DAL.BD;


namespace BLL.BD
{
    public class cls_BD_BLL
    {
        string MsjError = string.Empty;

            //METODO DE CONECXION A LA BASE DE DATOS SQL SERVER
            public void CrearConx(ref cls_BD_DAL Obj_BD_DAL)
            {
                try
                {
                Obj_BD_DAL.sCxCadena = ConfigurationManager.ConnectionStrings["Descargas"].ConnectionString;
                Obj_BD_DAL.Obj_Connec_DB = new SqlConnection(Obj_BD_DAL.sCxCadena);
                Obj_BD_DAL.sMsjError = string.Empty;
                Obj_BD_DAL.Obj_Connec_DB.Open();
            }
                catch (Exception ex)
                {
                Obj_BD_DAL.sMsjError = ex.Message.ToString();
                Obj_BD_DAL.Obj_Connec_DB = null;
                Obj_BD_DAL.sCxCadena = string.Empty; ;
                }
            }

            public void CerrarConx(ref cls_BD_DAL obj_BD_DAL)
        {
            //CIERRE DE LA ENTRADA DE DATOS
            if (obj_BD_DAL.Obj_Connec_DB != null)
            {
                if (obj_BD_DAL.Obj_Connec_DB.State == ConnectionState.Open)
                {
                    obj_BD_DAL.Obj_Connec_DB.Close();
                }

                //DESTRUCCION DE LA CONECXION PARA NO CONSUMIR
                obj_BD_DAL.Obj_Connec_DB.Dispose();
            }
        }

            //METODO DE CREACION DE PARAMETROS, QUE RELACIONAN LAS VARIABLES
            //DE LA BASE DE DATOS CON LA DE LA PLATAFORMA DE VISUAL(DAL)
            public void CrearParametros(ref cls_BD_DAL obj_BD_DAL)
            {
            obj_BD_DAL.DT_Parametros = new DataTable("Parametros");
            obj_BD_DAL.DT_Parametros.Columns.Add("Nombre");
            obj_BD_DAL.DT_Parametros.Columns.Add("Tipo");
            obj_BD_DAL.DT_Parametros.Columns.Add("Valor");

            }

            //METODO EJECUTABLE DE LAS ACCIONES DE LISTAR Y FILTRAR
            public string Execute_DataAdapter(ref cls_BD_DAL obj_BD_DAL)
            {
                try
                {
                    //SE CREA LA CONECXION A LA BD SQL
                    CrearConx(ref obj_BD_DAL);

                //INSTANCIAR EL DATA ADAPTER CON LOS PARAMETROS QUE RECIBE SP
                obj_BD_DAL.Obj_DAdapter = new SqlDataAdapter(obj_BD_DAL.sSP_Name, obj_BD_DAL.Obj_Connec_DB);

                //Ejecutar Stored Procedure
                obj_BD_DAL.Obj_DAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                //SE CREA UN DBTYPE PARA LUEGO ASIGNARLO JUNTO A LOS PARAMETROS DEL DATADAPTER
                SqlDbType DBType;
                //DEFINICION DEL VALOR DEL PARAMETRO (VARIABLES)
                if (obj_BD_DAL.DT_Parametros != null)
                        {
                            foreach (DataRow DR in obj_BD_DAL.DT_Parametros.Rows)
                            {
                        DBType = (SqlDbType) Enum.Parse (typeof(SqlDbType),DR[1].ToString().Trim());

                        obj_BD_DAL.Obj_DAdapter.SelectCommand.Parameters.Add(DR["Nombre"].ToString(), DBType).Value = DR["Valor"].ToString();
                            }
                        }
                obj_BD_DAL.Obj_DSet = new DataSet();
                obj_BD_DAL.Obj_DAdapter.Fill(obj_BD_DAL.Obj_DSet, obj_BD_DAL.sTableName);

               MsjError = null;                    

                }
                catch (Exception error)
                {
                MsjError = error.Message.ToString();
                }
                finally
                {
                CerrarConx(ref obj_BD_DAL);
                }
            return MsjError;
            }

            //METODO EJECUTABLE DE LAS ACCIONES DE INSERTAR, ELIMINAR Y MODIFICAR
            public string Execute_NonQuery(ref cls_BD_DAL Obj_DB_DAL)
            {
                try
                {
                    CrearConx(ref Obj_DB_DAL);

                        Obj_DB_DAL.Obj_Command = new SqlCommand(Obj_DB_DAL.sSP_Name, Obj_DB_DAL.Obj_Connec_DB);

                        Obj_DB_DAL.Obj_Command.CommandType = CommandType.StoredProcedure;
                SqlDbType DBType;
                if (Obj_DB_DAL.DT_Parametros != null)
                        {
                            foreach (DataRow DR in Obj_DB_DAL.DT_Parametros.Rows)
                            {
                        DBType = (SqlDbType)Enum.Parse(typeof(SqlDbType), DR[1].ToString().Trim());
                                                                                 

                                Obj_DB_DAL.Obj_Command.Parameters.Add(DR["Nombre"].ToString(), DBType).Value = DR["Valor"].ToString();
                            }
                        }

                        Obj_DB_DAL.Obj_Command.ExecuteNonQuery();

                        Obj_DB_DAL.sMsjError = string.Empty;


                MsjError = null;
            }
                catch (Exception error)
                {
                    Obj_DB_DAL.sMsjError = error.Message.ToString();
                }
                finally
                {
                CerrarConx(ref Obj_DB_DAL);
                }
            return MsjError;
            }
            
        }
}
