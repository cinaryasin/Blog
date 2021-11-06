namespace Core.Api.CoreServiceControllers
{
    public interface IAddController<out TActionResult, in TEntity>
    {
        TActionResult Add(TEntity entity);
    }
}
