

namespace Core.Api.CoreServiceControllers
{
    public interface IDeleteController<out TActionResult, in TEntity>
    {
        TActionResult Delete(TEntity entity);
    }
}
