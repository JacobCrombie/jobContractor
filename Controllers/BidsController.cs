using System;
using jobContractor.Models;
using jobContractor.Services;
using Microsoft.AspNetCore.Mvc;

namespace jobContractor.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BidsController : ControllerBase
  {
    private readonly BidsService _service;

    public BidsController(BidsService service)
    {
      _service = service;
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
    public ActionResult<Bid> Create([FromBody] Bid newBid)
    {
      try
      {
        return Ok(_service.Create(newBid));
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