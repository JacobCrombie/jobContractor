using System;
using jobContractor.Models;
using jobContractor.Services;
using Microsoft.AspNetCore.Mvc;

namespace jobContractor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewsController : ControllerBase
    {
        private readonly ReviewsService _service;

    public ReviewsController(ReviewsService service)
    {
      _service = service;
    }
    [HttpGet]
    public ActionResult<Review> Get()
    {
        try
        {
            return Ok(_service.Get());
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("{id}")]
    public ActionResult<Review> Get(int id)
    {
        try
        {
            return Ok(_service.Get(id));
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public ActionResult<Review> Create([FromBody] Review newRev)
    {
        try
        {
            return Ok(_service.Create(newRev));
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpPut("{id}")]
    public ActionResult<Review> Edit([FromBody] Review updatedRev)
    {
        try
        {
            updat
            return Ok(_service.Edit(updatedRev));
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpDelete("{id}")]
    public ActionResult<Review> Delete(int id)
    {
        try
        {
            return Ok(_service.Delete(id));
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

  }
}