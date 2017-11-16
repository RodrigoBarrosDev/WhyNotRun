﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WhyNotRun.BO;
using WhyNotRun.Models.TechieViewModel;

namespace WhyNotRun.Controllers
{
    public class TechieController : ApiController
    {
        private TechieBO _techieBo;

        public TechieController()
        {
            _techieBo = new TechieBO();
        }

        [HttpPost]
        [Route("techies")]
        public async Task<IHttpActionResult> CreateTechie(CreateTechieViewModel model)
        {
            var result = await _techieBo.CreateTechie(model.ToTechie());
            if (result != null)
            {
                return Ok(result);
            }
            return InternalServerError();
        }

        [HttpGet]
        [Route("techies")]
        public async Task<IHttpActionResult> ListTechies(bool orderByName)
        {
            var result = await _techieBo.ListTechie();

            if (result != null)
                return Ok(result);
            
            return NotFound();
        }

        [HttpGet]
        [Route("techies/order/name")]
        public async Task<IHttpActionResult> OrderTechiePerName()
        {
            var result = await _techieBo.ListTechieOrderByName();
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        //[HttpGet]
        //[Route("techie/amount")]
        //public async Task<IHttpActionResult> AmountPostsPerTechie(ObjectId techieId)
        //{
        //    var result = await _techieBo.AmountPostsPerTechie(techieId);
        //    if (result >= 0)
        //    {
        //        return Ok(result);
        //    }
        //    return InternalServerError();
        //}

        [HttpGet]
        [Route("techies/points")]
        public async Task<IHttpActionResult> PointsPublication()
        {
            var result = await _techieBo.ListTechieOrderByName();
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }
    }
}
