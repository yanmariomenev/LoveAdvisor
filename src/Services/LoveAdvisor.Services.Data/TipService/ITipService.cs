namespace LoveAdvisor.Services.Data.TipService
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ITipService
    {
        Task<IEnumerable<T>> TakeTipsByCategory<T>(string category);
    }
}
