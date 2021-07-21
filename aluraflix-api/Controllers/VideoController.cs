using System;
using System.Collections.Generic;
using aluraflix_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace aluraflix_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoController : ControllerBase
    {
        private static List<Video> videos = new List<Video>();

        [HttpPost]
        public void AddVideo([FromBody] Video video)
        {
            videos.Add(video);
        }
    }
}
