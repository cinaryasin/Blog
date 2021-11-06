namespace Core.Business.CoreServiceBusiness
{
    /// <summary>
    /// Ekleme Servisi
    /// </summary>
    /// <typeparam name="TResult">Dönüş tipi</typeparam>
    /// <typeparam name="Entity">Entity</typeparam>
    public interface IAddService<out TResult, in TEntity>
    {
        TResult Add(TEntity entity);

    }
}
