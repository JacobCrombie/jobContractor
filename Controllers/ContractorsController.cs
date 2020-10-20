using System;
using jobContractor.Models;
using jobContractor.Services;
using Microsoft.AspNetCore.Mvc;

namespace jobContractor.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ContractorsController : ControllerBase
  {
    private readonly ContractorsService _service;
    public ContractorsController(ContractorsService cs)
    {
      _service = cs;
    }

    [HttpGet]
    public ActionResult<Contractor> Get()
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
    public ActionResult<Contractor> Get(int id)
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
    public ActionResult<Contractor> Create([FromBody] Contractor newContractor)
    {
        try
        {
            return Ok(_service.Create(newContractor));
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
  }
}