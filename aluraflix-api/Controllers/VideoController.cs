using System;
using System.Collections.Generic;
using System.Linq;
using aluraflix_api.Data;
using aluraflix_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace aluraflix_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoController : ControllerBase
    {
        //Trabalhando com a conexao com o BD
        private VideoContext _context;

        public VideoController(VideoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddVideo([FromBody] Video video)
        {
            _context.Videos.Add(video);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecoverVideoId), new { id = video.id }, video);
        }

        [HttpGet]
        public IEnumerable<Video> RecoverVideo()
        {
            return _context.Videos;
        }

        [HttpGet("{id}")]
        public IActionResult RecoverVideoId(int id)
        {
            Video video =  _context.Videos.FirstOrDefault(video => video.id == id);
            if(video != null)
            {
                return Ok(video);
            }
            return NotFound();
        }
    }
}
