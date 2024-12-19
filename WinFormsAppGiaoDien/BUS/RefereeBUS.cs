using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class RefereeBUS
    {
        private RefereeDAL refereeDAL = new RefereeDAL();

        public List<RefereeDTO> GetAllReferees()
        {
            return refereeDAL.GetAllReferees();
        }

        public bool AddReferee(RefereeDTO referee)
        {
            if (string.IsNullOrEmpty(referee.RefereeID) || string.IsNullOrEmpty(referee.RefereeName))
            {
                throw new ArgumentException("RefereeID and RefereeName are required.");
            }
            return refereeDAL.AddReferee(referee);
        }

        public List<RefereeDTO> SearchReferees(string keyword)
        {
            return refereeDAL.SearchReferees(keyword);
        }

        public bool DeleteReferee(string refereeID)
        {
            return refereeDAL.DeleteReferee(refereeID);
        }
        public bool UpdateReferee(RefereeDTO referee)
        {
            if (string.IsNullOrEmpty(referee.RefereeID) || string.IsNullOrEmpty(referee.RefereeName))
            {
                throw new ArgumentException("RefereeID and RefereeName are required.");
            }
            return refereeDAL.UpdateReferee(referee);
        }

    }
}
