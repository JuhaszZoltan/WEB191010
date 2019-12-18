using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEB191010.Dtos;
using WEB191010.Models;

namespace WEB191010.Controllers.Api
{
    public class UgyfelekController : ApiController
    {
        private ApplicationDbContext _context;

        public UgyfelekController()
        {
            _context = new ApplicationDbContext();
        }    

        //GET - /api/ugyfelek
        public IEnumerable<UgyfelDto> GetUgyfelek()
        {
            return _context.Ugyfelek.ToList().Select(Mapper.Map<Ugyfel, UgyfelDto>);
        }

        //GET - /api/ugyfelek/1
        public UgyfelDto GetUgyfel(int id)
        {
            var ugyfel = _context.Ugyfelek.SingleOrDefault(u => u.Id == id);

            if (ugyfel == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Ugyfel, UgyfelDto>(ugyfel);
        }

        //POST - /api/ugyfelek
        [HttpPost]
        public UgyfelDto CreateUgyfel(UgyfelDto ugyfelDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var ugyfel = Mapper.Map<UgyfelDto, Ugyfel>(ugyfelDto);

            _context.Ugyfelek.Add(ugyfel);
            _context.SaveChanges();

            ugyfelDto.Id = ugyfel.Id;

            return ugyfelDto;
        }

        //PUT - /api/ugyfelek/1
        [HttpPut]
        public void UpdateUgyfel(int id, UgyfelDto ugyfelDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var ugyfelInDb = _context.Ugyfelek.SingleOrDefault(u => u.Id == id);

            if (ugyfelDto == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(ugyfelDto, ugyfelInDb);

            _context.SaveChanges();
        }

        //DELETE /api/ugyfelek/1
        [HttpDelete]
        public void DeleteUgyfel(int id)
        {
            var ugyfelInDb = _context.Ugyfelek.SingleOrDefault(u => u.Id == id);

            if (ugyfelInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Ugyfelek.Remove(ugyfelInDb);
            _context.SaveChanges();
        }
    }
}
