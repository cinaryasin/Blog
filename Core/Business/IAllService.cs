using Core.Business.CoreServiceBusiness;
using Core.Utilities.Results;
using System.Collections.Generic;


namespace Core.Business
{
    /// <summary>
    /// Tüm Servisleri Kullandırır
    /// </summary>
    /// <typeparam name="TEntity">Entity</typeparam>

    public interface IAllService<TEntity> :

        IAddService<IResult, TEntity>,
        IDeleteService<IResult, TEntity>,
        IUpdateService<IDataResult<TEntity>, TEntity>,
        IGetAllService<IDataResult<List<TEntity>>>,
        IGetByIdService<IDataResult<TEntity>, int>,
        IGetByNameService<IDataResult<TEntity>, string>,
        IGetByEmailService<IDataResult<TEntity>, string>
    {
    }
}
