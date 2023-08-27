namespace oldCapitalWeb.Services.FaQ
{
    using oldCapitalWeb.Models;

    using oldCapitalWeb.Data.Models;

    public interface IFaQService
    {

        public Task<IEnumerable<FaQViewModel>> GetAllFaQAsync();

        public Task GetSingleFaQAsync(Guid id);

        public Task AddFaQAsync(string question, string answer);

        public Task EditFaQAsync(Guid id, FaQViewModel model);

        public Task DeleteFaQAsync(Guid id);
    }
}
