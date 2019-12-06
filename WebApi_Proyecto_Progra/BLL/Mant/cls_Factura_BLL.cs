using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.BD;
using BLL.BD;

namespace BLL.Mant
{
    public class cls_Factura_BLL
    {
        string MsjError = string.Empty;

        public DataTable Listar_Factura()
        {
            cls_BD_BLL obj_BLL = new cls_BD_BLL();
            cls_BD_DAL obj_DAL = new cls_BD_DAL();

            obj_DAL.sTableName = "Factura";
            obj_DAL.sSP_Name = "dbo.SP_LISTAR_FACTURA";
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
    }
}
