namespace Core.Business.CoreServiceBusiness
{
    /// <summary>
    /// Güncelleme Servisi
    /// </summary>
    /// <typeparam name="TResult">Dönüş Tipi</typeparam>
    /// <typeparam name="Entity">Entity</typeparam>
    public interface IUpdateService<out TResult, in Entity>
    {
        TResult Update(Entity entity);

    }
}
