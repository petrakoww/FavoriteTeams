using ApplicarionService.DTOs;
using Data.Entities;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicarionService.Implementations
{
    public class TeamManagmentService
    {
        public List<TeamDTO> Get(string filter)
        {
            List<TeamDTO> teamsDto = new List<TeamDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.TeamRepository.Get(x => x.Country.Contains(filter)))
                {
                    teamsDto.Add(new TeamDTO
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Country = item.Country,
                        Year = item.Year
                    });
                }
            }

            return teamsDto;
        }

        public TeamDTO GetById(int id)
        {
            TeamDTO teamDTO = new TeamDTO();
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Team team = unitOfWork.TeamRepository.GetByID(id);
                teamDTO = new TeamDTO
                {
                    Id = team.Id,
                    Name = team.Name,
                    Country = team.Country,
                    Year = team.Year
                };
            }
            return teamDTO;
        }

        public bool Save(TeamDTO teamDTO)
        {
            Team Team = new Team
            {
                Id = teamDTO.Id,
                Name = teamDTO.Name,
                Country = teamDTO.Country,
                Year = teamDTO.Year
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    if (teamDTO.Id == 0)
                    {
                        unitOfWork.TeamRepository.Insert(Team);
                        unitOfWork.Save();
                    }
                    else
                    {
                        unitOfWork.TeamRepository.Update(Team);
                        unitOfWork.Save();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    Team team = unitOfWork.TeamRepository.GetByID(id);
                    unitOfWork.TeamRepository.Delete(team);
                    unitOfWork.Save();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
