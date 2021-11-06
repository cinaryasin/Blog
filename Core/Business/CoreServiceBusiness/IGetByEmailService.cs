namespace Core.Business.CoreServiceBusiness
{
    /// <summary>
    /// Email'e göre getirme
    /// </summary>
    /// <typeparam name="TResultTEntity">Dönüş tipi ve Entity</typeparam>
    /// <typeparam name="TParams">Parametre</typeparam>
    public interface IGetByEmailService<out TResultTEntity, in TParams>
    {
        TResultTEntity GetByEmail(TParams email);

    }
}
