using ApplicarionService.DTOs;
using ApplicarionService.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        private FanManagmentService fanService = new FanManagmentService();

        List<FanDTO> IService1.GetFans(string filter)
        {
            return fanService.Get(filter);
        }

        FanDTO IService1.GetFansById(int id)
        {
            return fanService.GetById(id);
        }

        string IService1.PostFan(FanDTO fanDto)
        {
            if (!fanService.Save(fanDto))
            {
                return "Fan not saved";

            }
            else
            {
                return "Fan saved";
            }
        }

        string IService1.PutFan(FanDTO fanDto)
        {
            if (!fanService.Save(fanDto))
            {
                return "Fan not updated";

            }
            else
            {
                return "Fan updated";
            }
        }
        string IService1.DeleteFan(int id)
        {
            if (!fanService.Delete(id))
            {
                return "Fan not deleted";

            }
            else
            {
                return "Fan deleted";
            }
        }
        private TeamManagmentService teamService = new TeamManagmentService();

        List<TeamDTO> IService1.GetTeams(string filter)
        {
            return teamService.Get(filter);
        }

        TeamDTO IService1.GetTeamById(int id)
        {
            return teamService.GetById(id);
        }

        string IService1.PostTeam(TeamDTO teamDto)
        {
            if (!teamService.Save(teamDto))
            {
                return "Team not saved";
            }
            else
            {
                return "Team saved";
            }
        }

        string IService1.PutTeam(TeamDTO teamDto)
        {
            if (!teamService.Save(teamDto))
            {
                return "Team not updated";
            }
            else
            {
                return "Team updated";
            }
        }
        string IService1.DeleteTeam(int id)
        {
            if (!teamService.Delete(id))
            {
                return "Team not deleted";

            }
            else
            {
                return "Team deleted";
            }
        }


        private ReviewManagmentService reviewService = new ReviewManagmentService();

        public List<ReviewDTO> GetReviews(string filter)
        {
            return reviewService.Get(filter);
        }

        ReviewDTO IService1.GetReviewsById(int id)
        {
            return reviewService.GetById(id);
        }

        string IService1.PostReview(ReviewDTO reviewDto)
        {
            if (!reviewService.Save(reviewDto))
            {
                return "Review not saved";
            }
            else
            {
                return "Review saved";
            }
        }

        string IService1.PutReview(ReviewDTO reviewDto)
        {
            if (!reviewService.Save(reviewDto))
            {
                return "Team not updated";
            }
            else
            {
                return "Team updated";
            }
        }

        string IService1.DeleteReview(int id)
        {
            if (!reviewService.Delete(id))
            {
                return "Review not deleted";

            }
            else
            {
                return "Review deleted";
            }
        }
    }
}