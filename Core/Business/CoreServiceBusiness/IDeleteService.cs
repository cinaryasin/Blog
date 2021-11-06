namespace Core.Business.CoreServiceBusiness
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TResult">Dönüş Tipi</typeparam>
    /// <typeparam name="TEntity">Entity</typeparam>
    public interface IDeleteService<out TResult, in TEntity>
    {
        TResult Delete(TEntity entity);
    }
}
