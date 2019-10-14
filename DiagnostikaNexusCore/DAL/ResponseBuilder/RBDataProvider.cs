using DiagnostikaNexusCore.DOT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiagnostikaNexusCore.Models.Openf;
using Microsoft.EntityFrameworkCore;

namespace DiagnostikaNexusCore.DAL.ResponseBuilder
{
    public class RBDataProvider
    {
        private readonly openfContext _contextOpenf= new openfContext();


        /// <summary>
        /// Function to get all results from an order
        /// </summary>
        /// <param name="OrderID">Order ID</param>
        /// <returns>The list of all exams ready to send</returns>
        public async Task<List<ResultHistory>> FindResultHistory(int OrderID)
        {
            ResultHistory resultHistory = new ResultHistory();
            List<ResultHistory> resultList = new List<ResultHistory>();
            var otContext = _contextOpenf.Ot;
            var operfilDataContext = _contextOpenf.OperfilData;
            var ohistidxContext = _contextOpenf.Ohistidx;

            var query = (from ohistidx in ohistidxContext
                         join ot in otContext on ohistidx.IdxUnicoId equals ot.TUnicoId
                         join oPerfilData in operfilDataContext on ot.TPerfilCodigo equals oPerfilData.CodPerfil
                         where ot.TOrder == OrderID && ot.TFromHis == 1 && ot.TValidado == 1 && ot.TParam == oPerfilData.ParCodigo
                         select new
                         {
                             ot.TOrder,
                             ohistidx.IdxHistoria,
                             ot.TDate,
                             ot.TParam,
                             ot.Rlinea,
                             ot.TComentario,
                             ot.TPerfilCodigo,
                             oPerfilData.Plantilla,
                             oPerfilData.PantillaBel,
                             oPerfilData.PlantillaBse,
                             oPerfilData.PlantillaEid,
                             ot.TValidadoPor,
                             ot.TFromHis,
                             ot.TValidado
                         });
            var result = await query.ToListAsync();

            foreach (var item in result)
            {
                ResultHistory resultValue = new ResultHistory();
                resultValue.Order = item.TOrder;
                resultValue.Identification = item.IdxHistoria;
                resultValue.DateValue = item.TDate;
                resultValue.Param = item.TParam;

                if (item.Rlinea.Substring(0, 1) == ".")
                {
                    resultValue.Result = "0"+item.Rlinea;
                }
                else {
                    resultValue.Result = item.Rlinea;
                }
                
                resultValue.Comment = item.TComentario;
                resultValue.Study = item.TPerfilCodigo;
                resultValue.Template = item.Plantilla;
                resultValue.BElement = item.PantillaBel.ToString();
                resultValue.BSubElement = item.PlantillaBse.ToString();
                resultValue.EElement = item.PlantillaEid.ToString();
                resultValue.ResponsableId = item.TValidadoPor;
                resultValue.TValidate = item.TValidado.ToString();

                resultList.Add(resultValue);
            }

            return resultList;
        }
    }
}
