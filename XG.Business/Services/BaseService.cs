using XG.Data;
using XG.Business.Services.Interfaces;
namespace XG.Business.Services
{
    public class BaseService<T>: IBaseService<T> where T : XgEntity, new()
    {
    }
}
