using MongoDB.Driver;
using WasmDemo.Shared;

namespace WasmDemo.Server.Repository;

public class BeerRepository : AbstractInMemoryRepository<Beer>
{
    //private List<Beer> _beers = new List<Beer>();

    //public async Task<Beer?> UpdateAsync(Beer model)
    //{
    //    if (await DeleteAsync(model.Id))
    //    {
    //        await CreateAsync(model);
    //        return model;
    //    }

    //    return null;
    //}

    //public Task<bool> DeleteAsync(long id)
    //{
    //    var entityToRemove = _beers.FirstOrDefault(x => x.Id == id);

    //    if (entityToRemove is not null)
    //    {
    //        _beers.Remove(entityToRemove);
    //        return Task.FromResult(true);
    //    }
    //    return Task.FromResult(false);
    //}

    //public Task<Beer?> GetAsync(long id)
    //{
    //    var entity = _beers.FirstOrDefault(b => b.Id == id);

    //    if (entity is not null)
    //    {
    //        return Task.FromResult<Beer?>(entity);
    //    }

    //    return Task.FromResult<Beer?>(null);
    //}

    //public Task<IEnumerable<Beer>> GetAllAsync()
    //{
    //    return Task.FromResult(_beers.AsEnumerable());
    //}

    //public Task<Beer> CreateAsync(Beer model)
    //{
    //    if (model.Id == 0)
    //    {
    //        model.Id = _beers.Max(x => x.Id) + 1;
    //    }
    //    _beers.Add(model);
    //    return Task.FromResult(model);
    //}

    //public Task CreateManyAsync(List<Beer> models)
    //{
    //    foreach (var beer in models)
    //    {
    //        CreateAsync(beer);
    //    }
    //    return Task.CompletedTask;
    //}


}