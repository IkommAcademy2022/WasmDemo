using Microsoft.AspNetCore.Mvc;
using WasmDemo.Server.Repository;
using WasmDemo.Shared;

namespace WasmDemo.Server.Controllers
{
    public class BeersController : AbstractController<Beer>
    {
        public BeersController(IRepository<Beer> repo) : base(repo)
        {
            
        }
    }
}