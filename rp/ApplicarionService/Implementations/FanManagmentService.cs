using ApplicarionService.DTOs;
using Data.Context;
using Data.Entities;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicarionService.Implementations
{
    public class FanManagmentService
    {
        private teams1SystemDBContext ctx = new teams1SystemDBContext();

        public List<FanDTO> Get(string filter)
        {
            List<FanDTO> fansDto = new List<FanDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.FanRepository.Get(x => x.FirstName.Contains(filter)))
                {
                    fansDto.Add(new FanDTO
                    {
                        Id = item.Id,
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        Age = item.Age
                    });
                }
            }
            return fansDto;
        }

        public FanDTO GetById(int id)
        {
            FanDTO fanDTO = new FanDTO();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Fan fan = unitOfWork.FanRepository.GetByID(id);
                if (fan != null)
                {
                    fanDTO.Id = fan.Id;
                    fanDTO.FirstName = fan.FirstName;
                    fanDTO.LastName = fan.LastName;
                    fanDTO.Age = fan.Age;
                }
            }
            return fanDTO;
        }

        public bool Save(FanDTO fanDTO)
        {
            Fan fan = new Fan
            {
                Id = fanDTO.Id,
                FirstName = fanDTO.FirstName,
                LastName = fanDTO.LastName,
                Age = fanDTO.Age
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    if (fanDTO.Id == 0)
                    {
                        unitOfWork.FanRepository.Insert(fan);
                        unitOfWork.Save();
                    }
                    else
                    {
                        unitOfWork.FanRepository.Update(fan);
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
                    Fan fan = unitOfWork.FanRepository.GetByID(id);
                    unitOfWork.FanRepository.Delete(fan);
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
