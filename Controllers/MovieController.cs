﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApiV.Services;
using MovieApiV.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieApiV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        //private readonly DataHandler dataHandler;
        //public MovieController(DataHandler handler)
        //{
        //    dataHandler = handler;
        //}

        //// GET: api/<MovieController>
        ////[HttpGet]
        //public async Task<ActionResult<IEnumerable<Movie>>> MovieListGet()
        //{
        //    var p = await dataHandler.MovieListGet();
        //  //  p = p.Where(p=>p.)
        //    return Ok(p);
        //}

        //// GET api/<MovieController>/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<IEnumerable<Movie>>> MovieGetSingle(int id)
        //{
        //    var model = await dataHandler.MovieListGet();
        //    return Ok(model.FirstOrDefault().Id == id);
        //}

        //// POST api/<MovieController>
        //[HttpPost]
        //public async Task<string> Post(Movie mode)
        //{
        //    string s = "fail creating new movie";

        //    if (dataHandler.AddMovie(mode))
        //        return s = "Created new movie";
        //    return s;
        //}

        //// PUT api/<MovieController>/5
        //[HttpPut("{id}")]                                                                                                                                                                                                                                                                                                                                                                                                                                            
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<MovieController>/5
        //[HttpDelete("{id}")]
        //public async Task<string> Delete(int id)
        //{
        //    string s = "fail delete movie";
        //    if (dataHandler.DeleteMovie(id))
        //        return s = "remove movie";

        //    return s;
        //}
    }
}
