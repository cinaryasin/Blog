namespace Core.Api.CoreServiceControllers
{
    public interface IGetAllController<out TActionResult>
    {
        TActionResult GetAll();
    }
}
