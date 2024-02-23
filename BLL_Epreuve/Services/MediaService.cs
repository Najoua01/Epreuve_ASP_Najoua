using BLL_Epreuve.Entities;
using DAL = DAL_Epreuve.Entities;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BLL_Epreuve.Mappers;

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
            return _mediaRepository.Get().Select(d => d.ToBLL());
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
