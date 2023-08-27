using AutoMapper;
using oldCapitalWeb.Data;
using oldCapitalWeb.Models;
namespace oldCapitalWeb.Services.FaQ
{
    using AutoMapper.QueryableExtensions;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class FaQservice : IFaQService
    {
        private readonly ApplicationDbContext data;
        private readonly IMapper mapper;

        public FaQservice(ApplicationDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<FaQViewModel>> GetAllFaQAsync(IQueryable<FaQ> faqQuery)
        => await faqQuery.ProjectTo<FaQViewModel>(this.mapper.ConfigurationProvider).ToListAsync();


        public Task AddFaQAsync(string question, string answer)
        {
            var newFaQ = new FaQ
            {
                Question = question,
                Answer = answer
            };

            this.data.FaQs.Add(newFaQ);
            this.data.SaveChanges();

            return Task.CompletedTask;
        }

        public Task DeleteFaQAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task EditFaQAsync(Guid id, FaQViewModel model)
        {
            throw new NotImplementedException();
        }


        public Task GetSingleFaQAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
