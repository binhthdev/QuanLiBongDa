using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class TeamBUS
    {
        private TeamDAL teamDAL = new TeamDAL();

        public bool AddTeam(Team team)
        {
            return teamDAL.InsertTeam(team);
        }

        public bool UpdateTeam(Team team)
        {
            return teamDAL.UpdateTeam(team);
        }

        public bool DeleteTeam(string teamID)
        {
            return teamDAL.DeleteTeam(teamID);
        }

        public List<Team> GetTeams()
        {
            return teamDAL.GetAllTeams();
        }

        public List<Team> SearchTeams(string keyword)
        {
            return teamDAL.SearchTeams(keyword);
        }
    }
}
