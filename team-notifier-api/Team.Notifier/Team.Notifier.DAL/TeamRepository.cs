namespace Team.Notifier.DAL
{
    public class TeamRepository : ITeamRepository
    {
        public Task<Common.Team> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Common.Team>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Add(Common.Team entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Common.Team entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Common.Team entity)
        {
            throw new NotImplementedException();
        }
    }
}