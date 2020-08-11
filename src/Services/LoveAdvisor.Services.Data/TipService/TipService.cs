namespace LoveAdvisor.Services.Data.TipService
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using LoveAdvisor.Data.Common.Repositories;
    using LoveAdvisor.Data.Models;
    using LoveAdvisor.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class TipService : ITipService
    {
        private readonly IDeletableEntityRepository<Category> categoryRepo;
        private readonly IDeletableEntityRepository<Tip> tipRepo;

        public TipService(
            IDeletableEntityRepository<Category> categoryRepo,
            IDeletableEntityRepository<Tip> tipRepo)
        {
            this.categoryRepo = categoryRepo;
            this.tipRepo = tipRepo;
        }

        public async Task<IEnumerable<T>> TakeConversationTips<T>()
        {
            var conversationList = this.categoryRepo
                .All()
                .Where(x => x.Name == "Conversation")
                .Select(x => x.Tips).Take(12);

            return await conversationList.To<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> TakeDatingTips<T>()
        {
            var tinderList = this.categoryRepo
               .All()
               .Where(x => x.Name == "Tinder")
               .Select(x => x.Tips).Take(12);

            return await tinderList.To<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> TakeTinderTips<T>()
        {
            var datingList = this.categoryRepo
               .All()
               .Where(x => x.Name == "Dating")
               .Select(x => x.Tips).Take(12);

            return await datingList.To<T>().ToListAsync();
        }
    }
}
