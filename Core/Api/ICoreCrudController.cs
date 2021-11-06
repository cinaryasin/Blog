using Core.Api.CoreServiceControllers;

namespace Core.Api
{
    public interface ICoreCrudController<TActionResult, TEntity> :
        IAddController<TActionResult, TEntity>,
        IDeleteController<TActionResult, TEntity>,
        IUpdateController<TActionResult, TEntity>,
        IGetAllController<TActionResult>,
        IGetByIdController<TActionResult, int>
    {
    }
}
