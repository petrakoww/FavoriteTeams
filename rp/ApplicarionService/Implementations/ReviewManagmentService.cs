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
    public class ReviewManagmentService
    {
        public List<ReviewDTO> Get(string filter)
        {
            List<ReviewDTO> ReviewDto = new List<ReviewDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.ReviewRepository.Get(x => x.Comment.Contains(filter)))
                {
                    ReviewDto.Add(new ReviewDTO
                    {
                        Id = item.Id,
                        Comment = item.Comment,
                        Grade = item.Grade,

                        Fan = new Fan
                        {
                            Id = item.FanID
                        },

                        Team = new Team
                        {
                            Id = item.Team.Id
                        }
                    });
                }
            }
            return ReviewDto;
        }

        public ReviewDTO GetById(int id)
        {
            ReviewDTO ReviewDto = new ReviewDTO();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Review review = unitOfWork.ReviewRepository.GetByID(id);
                ReviewDto = new ReviewDTO
                {
                    Id = review.Id,
                    Comment = review.Comment,
                    Grade = review.Grade,

                    Fan = new Fan
                    {
                        Id = review.FanID
                    },

                    Team = new Team
                    {
                        Id = review.Team.Id
                    }
                };
            }
            return ReviewDto;
        }

        public bool Save(ReviewDTO reviewDto)
        {
            Review review = new Review
            {
                Id = reviewDto.Id,
                Comment = reviewDto.Comment,
                Grade = reviewDto.Grade,
                TeamID = reviewDto.Team.Id,
                FanID = reviewDto.Fan.Id
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    if (reviewDto.Id == 0)
                        unitOfWork.ReviewRepository.Insert(review);
                    else
                        unitOfWork.ReviewRepository.Update(review);

                    unitOfWork.Save();
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
                    Review review = unitOfWork.ReviewRepository.GetByID(id);
                    unitOfWork.ReviewRepository.Delete(review);
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