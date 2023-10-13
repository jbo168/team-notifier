using Team.Notifier.DAL;

namespace Team.Notifier.Core
{
    public class TeamService : ITeamService
    {
        public readonly ITeamRepository _teamRepository;

        public TeamService(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }
        
        public async Task<IEnumerable<Common.Team>> GetAllTeams()
        {
            var teams = await _teamRepository.GetAll();

            return teams;
        }
    }
}