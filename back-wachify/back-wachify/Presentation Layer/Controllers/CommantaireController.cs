﻿using back_wachify.Business_Logic_Layer.Dto;
using back_wachify.Business_Logic_Layer.Interfaces;
using back_wachify.Business_Logic_Layer.Model;
using back_wachify.Business_Logic_Layer.Services;
using Microsoft.AspNetCore.Mvc;

namespace back_wachify.Presentation_Layer.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CommantaireController : ControllerBase
	{
		private readonly ICommantireService _commantireService;

		public CommantaireController(ICommantireService commantireService)
		{
			_commantireService = commantireService;
		}

		
				[HttpGet("/all")]
				public async Task<ActionResult<List<Commantire>>> GetAllCommantires()
				{
					try
					{
						var commantires = await _commantireService.GetAllCommantires();
						return Ok(commantires);
					}
					catch (Exception ex)
					{
						return StatusCode(500, $"Internal server error: {ex.Message}");
					}
				}
		
		

				[HttpGet("{id}")]
				public async Task<IActionResult> GetCommantireById(int id)
				{
					try
					{
						var commantire = await _commantireService.GetCommantireparid(id);
						if (commantire == null)
						{
							return NotFound();
						}
						return Ok(commantire);
					}
					catch (Exception ex)
					{
						return StatusCode(500, $"Internal server error: {ex.Message}");
					}
				}

				




		[HttpPost]
		public async Task<IActionResult> AddReview(CommantireDTO commantire)
		{
			try
			{
				var addedCommantire = await _commantireService.AddCommantire(commantire);
				return Ok(addedCommantire);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"An error occurred: {ex.Message}");
			}
		}












	
		
		[HttpGet("film/{id}")]
		public async Task<ActionResult<List<Commantire>>> GetCommantiresByFilmId(int id)
		{
			try
			{
				var commantires = await _commantireService.GetCommantireParIdVedio(id);
				return Ok(commantires);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Internal server error: {ex.Message}");
			}
		}


		[HttpDelete("delete/{id}")]
		public async Task<ActionResult> DeleteCommantire(int id)
		{
			try
			{
			 _commantireService.DeleteCommantire(id);
				return Ok("delete sucesse");
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Internal server error: {ex.Message}");
			}
		}


		[HttpPut("/update")]
		public async Task<ActionResult> UpdateCommantire(Commantire commantire)
		{
			try
			{
				await _commantireService.UpdateCommantire(commantire);
				return Ok();
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Internal server error: {ex.Message}");
			}
		}

	}
}
