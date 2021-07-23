using System;
using System.Collections.Generic;
using System.Linq;
using aluraflix_api.Data;
using aluraflix_api.Data.Dtos;
using aluraflix_api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace aluraflix_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoController : ControllerBase
    {
        //Trabalhando com a conexao com o BD
        private VideoContext _context;
        private IMapper _mapper;

        public VideoController(VideoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddVideo([FromBody] CreateVideoDto videoDto)
        {
            Video video = _mapper.Map<Video>(videoDto);
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
                ReadVideoDto videoDto = _mapper.Map<ReadVideoDto>(video);
                return Ok(videoDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVideo(int id, [FromBody] UpdateVideoDto videoDto)
        {
            Video video = _context.Videos.FirstOrDefault(video => video.id == id);
            if (video == null)
            {
                return NotFound();
            }
            _mapper.Map(videoDto, video);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVideo(int id)
        {
            Video video = _context.Videos.FirstOrDefault(video => video.id == id);
            if(video == null)
            {
                return NotFound();
            }
            _context.Remove(video);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
