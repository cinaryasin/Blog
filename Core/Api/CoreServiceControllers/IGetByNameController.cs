namespace Core.Api.CoreServiceControllers
{
    public interface IGetByNameController<out TActionResult, in Name>
    {
        TActionResult GetByName(Name name);
    }
}
