using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Notifier.Core
{
    public interface ITeamService
    {
        Task<IEnumerable<Common.Team>> GetAllTeams();
    }
}
