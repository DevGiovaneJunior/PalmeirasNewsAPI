using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PalmeirasNews.Domain.DTOs;
using PalmeirasNews.Domain.Interfaces;
using System.Collections.Generic;

namespace PalmeirasNews.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticiasController : ControllerBase
    {
        private readonly INoticiaService _noticiaService;
        public NoticiasController(INoticiaService noticiaService)
        {
            _noticiaService = noticiaService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(List<string>))]
        public ActionResult Post([FromBody] NoticiaDTO noticiaDTO)
        {
            if (noticiaDTO == null)
                return NotFound();

            _noticiaService.Add(noticiaDTO);
            return Created("Noticia Cadastrada com sucesso!", null);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NoticiaDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(List<string>))]
        public ActionResult Put([FromBody] NoticiaDTO noticiaDTO)
        {
            if (noticiaDTO == null)
                return NotFound();

            _noticiaService.Update(noticiaDTO);
            return Ok("Noticia Atualizada com sucesso!");
        }

        [HttpDelete()]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(List<string>))]
        public ActionResult Delete([FromBody] NoticiaDTO noticiaDTO)
        {
            if (noticiaDTO == null)
                return NotFound();

            _noticiaService.Remove(noticiaDTO);
            return Ok("Noticia Removida com sucesso!");
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<NoticiaDTO>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(List<string>))]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_noticiaService.GetAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NoticiaDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(List<string>))]
        public ActionResult<string> Get(int id)
        {
            return Ok(_noticiaService.GetById(id));
        }
    }
}
