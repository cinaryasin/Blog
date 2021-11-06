namespace Core.Business.CoreServiceBusiness
{
    /// <summary>
    /// Hepsini Getirme Servisi
    /// </summary>
    /// <typeparam name="TResultTEntity">Dönüş tipi ve Entity</typeparam>
    public interface IGetAllService<out TResultTEntity>
    {
        TResultTEntity GetAll();

    }
}
