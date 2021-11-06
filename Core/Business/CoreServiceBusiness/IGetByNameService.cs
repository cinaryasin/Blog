namespace Core.Business.CoreServiceBusiness
{
    /// <summary>
    /// Name'e göre getirme
    /// </summary>
    /// <typeparam name="TResultTEntity">Dönüş tipi ve Entity</typeparam>
    /// <typeparam name="TParams">Parametre</typeparam>
    public interface IGetByNameService<out TResultTEntity, in TParams>
    {
        TResultTEntity GetByName(TParams name);

    }
}
