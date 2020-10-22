using System;
using jobContractor.Models;
using jobContractor.Services;
using Microsoft.AspNetCore.Mvc;

namespace jobContractor.Controllers
{
  public class BidsController : ControllerBase
  {
    private readonly BidsService _service;

    public BidsController(BidsService service)
    {
      _service = service;
    }

    [HttpGet]
    public ActionResult<Bid> Get()
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
    public ActionResult<Bid> Get(int id)
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
    public ActionResult<Bid> Create([FromBody] Bid newRev)
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
    public ActionResult<Bid> Edit([FromBody] Bid updatedRev, int id)
    {
      try
      {
        updatedRev.Id = id;
        return Ok(_service.Edit(updatedRev));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<Bid> Delete(int id)
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