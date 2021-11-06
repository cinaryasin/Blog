using Core.Api.CoreServiceControllers;


namespace Core.Api
{
    public interface ICoreAllController<TActionResult, TEntity> :
        IAddController<TActionResult, TEntity>,
        IDeleteController<TActionResult, TEntity>,
        IUpdateController<TActionResult, TEntity>,
        IGetAllController<TActionResult>,
        IGetByIdController<TActionResult, int>,
        IGetByEmailController<TActionResult, string>,
        IGetByNameController<TActionResult, string>,
        IGetDetailsController<TActionResult>
    {
    }
}
