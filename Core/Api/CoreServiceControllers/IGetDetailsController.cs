namespace Core.Api.CoreServiceControllers
{
    public interface IGetDetailsController<out TActionResult>
    {
        TActionResult GetDetails();
    }
}
