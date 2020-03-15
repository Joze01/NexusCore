using DiagnostikaNexusCore.DOT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiagnostikaNexusCore.Models.Openf;
using Microsoft.EntityFrameworkCore;
using DiagnostikaNexusCore.DTO.Hl7Response;

namespace DiagnostikaNexusCore.DAL.ResponseBuilder
{
    public class RBDataProvider
    {
        private readonly OpenfContext _contextOpenf= new OpenfContext();


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

        public async Task<Ranges> getRangosAsync(ResultHistory resulValue)
        {
            // rEFERNECIAS A LAS TABLAS
            var operfilDataContext = _contextOpenf.OperfilData;
            Ranges rangos = new Ranges();

            // Hacer un query de consulta
            var query = (from operfilData in operfilDataContext
                    where operfilData.CodPerfil == resulValue.Param.ToString()
                    select new
                    {
                        operfilData.ValorInferior1,
                        operfilData.ValorSuperior1
                    });


            var result = await query.ToListAsync();

            foreach (var item in result)
            {
                rangos.ValorInferior = item.ValorInferior1;
                rangos.ValorSuperior = item.ValorSuperior1;
            }

            return rangos;
        }
       /* public async Task<Responsable> getResponsableAsync(ResultHistory resulValue)
        {
            // REFERNECIAS A LAS TABLAS OT
            var ot = _contextOpenf.Ot;
            Responsable resp = new Responsable();

            // Hacer un query de consulta
            var query = (from Ot in _contextOpenf.Ot
                         where Ot.TCustom = resulValue.Order.ToString()
                         select new
                         {
                             Ot.TValidadoPor
                         }) ;

            var result = await query.ToListAsync();

            foreach (var item in result)
            {
                resp.Validador = item.TValidadoPor; 
              
            }

            return resp;
        }
        public async Task<Identificador> getIdentificadorAsync(ResultHistory resulValue)
        {
            // REFERNECIAS A LAS TABLAS OT
            var oficha = _contextOpenf.Oficha;
            Identificador Iden = new Identificador();

            // Hacer un query de consulta
            var query = (from Oficha in _contextOpenf.Oficha
                         where Oficha.Custom = resulValue.Identification.ToString()
                         select new
                         {
                              
                         });

            var result = await query.ToListAsync();

            foreach (var item in result)
            {
                

            }

            return Iden;
        }*/

    }
}
