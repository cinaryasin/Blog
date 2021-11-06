namespace Core.Api.CoreServiceControllers
{
    public interface IGetByIdController<out TActionResult, Id>
    {
        TActionResult GetById(Id id);
    }
}
