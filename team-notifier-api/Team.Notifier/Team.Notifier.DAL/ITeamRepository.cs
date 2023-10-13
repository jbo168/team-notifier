namespace Team.Notifier.DAL;

public interface ITeamRepository
{
    Task<IEnumerable<Common.Team>> GetAll();
}