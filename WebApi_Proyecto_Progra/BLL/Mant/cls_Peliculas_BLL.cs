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
    public class cls_Peliculas_BLL
    {
        string MsjError = string.Empty;

        public DataTable Listar_Peliculas()
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_DAL.sTableName = "Peliculas";
            obj_DAL.sSP_Name = "dbo.SP_ListarPelicula";
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
        public string Insertar_Pelicula(ref cls_Peliculas_DAL Obj_Pelicula_DAL)
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_BLL.CrearParametros(ref obj_DAL);
            obj_DAL.DT_Parametros.Rows.Add("@NOMBRE", SqlDbType.VarChar, Obj_Pelicula_DAL.sNombre.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@PRECIO", SqlDbType.Money, Obj_Pelicula_DAL.dPrecio.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@ANIO_ESTRENO", SqlDbType.DateTime, Obj_Pelicula_DAL.dtAnioEstreno.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@IDIOMAS", SqlDbType.VarChar, Obj_Pelicula_DAL.sIdiomas.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@SINOPSIS", SqlDbType.VarChar, Obj_Pelicula_DAL.sSinopsis.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@NUMERO_DESCARGAS", SqlDbType.SmallInt, Obj_Pelicula_DAL.iNumeroDescargas.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@ID_ESTADO", SqlDbType.Char, Obj_Pelicula_DAL.cIdEstado.ToString().Trim());
            obj_DAL.DT_Parametros.Rows.Add("@ID_GENERO", SqlDbType.SmallInt, Obj_Pelicula_DAL.sGenero.ToString().Trim());


            obj_DAL.sSP_Name = "dbo.SP_InsertarPelicula";
            MsjError = obj_BLL.Execute_NonQuery(ref obj_DAL);

            return MsjError;
        }
    }
}
