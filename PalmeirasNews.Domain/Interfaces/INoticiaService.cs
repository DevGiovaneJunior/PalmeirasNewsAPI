using PalmeirasNews.Domain.DTOs;
using System.Collections.Generic;

namespace PalmeirasNews.Domain.Interfaces
{
    public interface INoticiaService
    {
        void Add(NoticiaDTO obj);

        NoticiaDTO GetById(int id);

        IEnumerable<NoticiaDTO> GetAll();

        void Update(NoticiaDTO obj);

        void Remove(NoticiaDTO obj);

        void Dispose();
    }
}
