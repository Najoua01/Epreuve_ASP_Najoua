using BLL_Epreuve.Entities;
using DAL = DAL_Epreuve.Entities;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve.Services
{
    public class MediaService : IMediaRepository<Media>
    {
        private readonly IMediaRepository<DAL.Media> _mediaRepository;
        public MediaService(IMediaRepository<DAL.Media> mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Media> Get()
        {
            throw new NotImplementedException();
        }

        public Media Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Media data)
        {
            throw new NotImplementedException();
        }

        public void Update(Media data)
        {
            throw new NotImplementedException();
        }
    }
}
