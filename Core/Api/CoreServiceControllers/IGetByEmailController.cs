namespace Core.Api.CoreServiceControllers
{
    public interface IGetByEmailController<out TActionResult, in Email>
    {
        TActionResult GetByEmail(Email email);
    }
}
