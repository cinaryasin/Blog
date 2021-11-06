using Core.Business.CoreServiceBusiness;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace Core.Business
{
    /// <summary>
    /// Ekleme , Güncelleme , Silme , Id'ye göre getirme ve Tüm Datayı getirme işlemi yapar
    /// </summary>
    /// <typeparam name="TEntity">Entity</typeparam>
    public interface ICrudService<TEntity> :
        IAddService<IResult, TEntity>,
        IDeleteService<IResult, TEntity>,
        IUpdateService<IDataResult<TEntity>, TEntity>,
        IGetAllService<IDataResult<List<TEntity>>>,
        IGetByIdService<IDataResult<TEntity>, int>
    {
    }
}
