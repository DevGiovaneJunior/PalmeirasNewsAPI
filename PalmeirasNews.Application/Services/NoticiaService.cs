using AutoMapper;
using Microsoft.Extensions.Logging;
using PalmeirasNews.Domain.DTOs;
using PalmeirasNews.Domain.Entities;
using PalmeirasNews.Domain.Interfaces;
using PalmeirasNews.Domain.Services;
using PalmeirasNews.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace PalmeirasNews.Application.Services
{
    public class NoticiaService : BaseService<Noticia>, INoticiaService
    {
        private readonly ILogger<NoticiaService> _logger;
        private readonly IMapper _mapper;
        public readonly INoticiaRepository _userRepository;

        public NoticiaService(ILogger<NoticiaService> logger,
            IMapper mapper,
            INoticiaRepository userRepository)
            : base(userRepository)  
        {
            _logger = logger;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public void Add(NoticiaDTO obj)
        {
            try
            {
                _userRepository.Add(_mapper.Map<Noticia>(obj));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }
        public NoticiaDTO GetById(int id)
        {
            try
            {
                var obj = _userRepository.GetById(id);
                return _mapper.Map<NoticiaDTO>(obj);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<NoticiaDTO> GetAll()
        {
            try
            {
                return _mapper.Map<IEnumerable<NoticiaDTO>>(_userRepository.GetAll());

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new List<NoticiaDTO>();
            }
        }
        public void Update(NoticiaDTO obj)
        {
            try
            {
                _userRepository.Update(_mapper.Map<Noticia>(obj));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }
        public void Remove(NoticiaDTO obj)
        {
            try
            {
                _userRepository.Remove(_mapper.Map<Noticia>(obj));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }
        public new virtual void Dispose()
        {
            _userRepository.Dispose();
        }
    }
}
