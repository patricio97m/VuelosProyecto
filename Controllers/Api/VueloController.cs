using AutoMapper;
using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using Vuelos.Dtos;
using Vuelos.Models;

namespace Vuelos.Controllers.Api
{
    public class VueloController : ApiController
    {
        private MyDBContext _context;

        public VueloController()
        {
            _context = new MyDBContext();
        }
        //GET /api/vuelos
        public IHttpActionResult GetVuelos()
        {
            var vuelosDtos = _context.Vuelo.ToList().Select(Mapper.Map<Vuelo, VueloDto>);
            return Ok(vuelosDtos);
        }
        //GET /api/vuelos/1
        public IHttpActionResult GetVuelo(int id)
        {
            var vuelo = _context.Vuelo.SingleOrDefault(c => c.Id == id);
            if (vuelo == null)
                return NotFound();

            return Ok(Mapper.Map<Vuelo, VueloDto>(vuelo));
        }

        // POST /api/vuelos
        [HttpPost]
        public IHttpActionResult CreateVuelo(VueloDto vueloDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var vuelo = Mapper.Map<VueloDto, Vuelo>(vueloDto);
            _context.Vuelo.Add(vuelo);
            _context.SaveChanges();

            vueloDto.Id = vuelo.Id;

            return Created(new Uri(Request.RequestUri + "/" + vuelo.Id), vueloDto);
        }

        // PUT /api/vuelos/1
        [HttpPut]
        public void UpdateVuelo(int id, VueloDto vueloDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var vueloInBd = _context.Vuelo.SingleOrDefault(c => c.Id == id);

            if (vueloInBd == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(vueloDto, vueloInBd);

            _context.SaveChanges();
        }

        // DELETE /api/vuelos/1
        [HttpDelete]
        public void DeleteVuelo(int id)
        {
            var vueloInBd = _context.Vuelo.SingleOrDefault(c => c.Id == id);

            if (vueloInBd == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Vuelo.Remove(vueloInBd);
            _context.SaveChanges();
        }
    }
}
