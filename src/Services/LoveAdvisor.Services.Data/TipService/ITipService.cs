namespace LoveAdvisor.Services.Data.TipService
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ITipService
    {
        Task<IEnumerable<T>> TakeTinderTips<T>();

        Task<IEnumerable<T>> TakeDatingTips<T>();

        Task<IEnumerable<T>> TakeConversationTips<T>();
    }
}
