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

        public async Task<IEnumerable<FaQViewModel>> GetAllFaQAsync()
        => await this.data.FaQs.ProjectTo<FaQViewModel>(this.mapper.ConfigurationProvider).ToListAsync();


        public async Task AddFaQAsync(string question, string answer)
        {
            var newFaQ = new FaQ
            {
                Question = question,
                Answer = answer
            };

            await this.data.FaQs.AddAsync(newFaQ);
            await this.data.SaveChangesAsync();

            return;
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
