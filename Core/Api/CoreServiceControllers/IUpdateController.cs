namespace Core.Api.CoreServiceControllers
{
    public interface IUpdateController<out TActionResult, in TEntity>
    {
        TActionResult Update(TEntity entity);
    }
}
