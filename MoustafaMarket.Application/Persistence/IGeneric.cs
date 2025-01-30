namespace MoustafaMarket.Application.Persistence;
public interface IGeneric<T> where T:class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetById(Guid id);
    //Task<IEnumerable<T>> GetByNameAsync(string name);
    Task<int> AddAsync(T item);
    Task<int> UpdateAsync(T item);
    Task<int> DeleteAsync(Guid id);
}
