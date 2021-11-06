namespace Core.Business.CoreServiceBusiness
{
    /// <summary>
    /// Id'ye göre getirme
    /// </summary>
    /// <typeparam name="TResultTEntity">Dönüş tipi ve Entity</typeparam>
    /// <typeparam name="TParams">Parametre</typeparam>
    public interface IGetByIdService<out TResultTEntity, in TParams>
    {
        TResultTEntity GetById(TParams id);

    }
}
