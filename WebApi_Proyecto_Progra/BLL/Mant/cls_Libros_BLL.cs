using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.BD;
using BLL.BD;
using DAL.Mant;

namespace BLL.Mant
{
    public class cls_Libros_BLL
    {
        string MsjError = string.Empty;

        public DataTable Listar_Libros()
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_DAL.sTableName = "Libros";
            obj_DAL.sSP_Name = "dbo.SP_ListarLibros";
            obj_BLL.Execute_DataAdapter(ref obj_DAL);

            if (MsjError == null)
            {
                return obj_DAL.Obj_DSet.Tables[0];
            }
            else
            {
                return null;
            }
        }
        public string Insertar_Libro(ref cls_Libros_DAL Obj_Libros_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@NOMBRE", SqlDbType.VarChar, Obj_Libros_DAL.sNombre.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@PRECIO", SqlDbType.Money, Obj_Libros_DAL.dPrecio.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@AUTORES", SqlDbType.VarChar, Obj_Libros_DAL.sAutores.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@IDIOMAS", SqlDbType.VarChar, Obj_Libros_DAL.sIdiomas.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@ANIO_PUBLICACION", SqlDbType.DateTime, Obj_Libros_DAL.dtAnioPublicacion.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@NUMERO_DESCARGAS", SqlDbType.SmallInt, Obj_Libros_DAL.iNumeroDescargas.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@ID_ESTADO", SqlDbType.Char, Obj_Libros_DAL.cIdEstado.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@ID_GENERO", SqlDbType.SmallInt, Obj_Libros_DAL.iIdGenero.ToString().Trim());


            obj_DAL.sSP_Name = "dbo.SP_InsertarLibro";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);

            return MsjError;
        }
    }
}
