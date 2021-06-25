using Data.Context;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{

    public class UnitOfWork : IDisposable
    {
        private teams1SystemDBContext context = new teams1SystemDBContext();
        private GenericRepository<Team> teamRepository;
        private GenericRepository<Fan> fanRepository;
        private GenericRepository<Review> reviewRepository;

        public GenericRepository<Team> TeamRepository
        {
            get
            {
                if (this.teamRepository == null)
                {
                    this.teamRepository = new GenericRepository<Team>(context);
                }

                return teamRepository;
            }
        }

        public GenericRepository<Fan> FanRepository
        {
            get
            {
                if (this.fanRepository == null)
                {
                    this.fanRepository = new GenericRepository<Fan>(context);
                }

                return fanRepository;
            }
        }

        public GenericRepository<Review> ReviewRepository
        {
            get
            {
                if (this.reviewRepository == null)
                {
                    this.reviewRepository = new GenericRepository<Review>(context);
                }

                return reviewRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}
