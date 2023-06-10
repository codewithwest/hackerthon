
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace net_hack
{
    [Route("[controller]")]
    [ApiController]
    class ProjectsController : ControllerBase
    {
        public ProjectsController(ProjectUrlService projectService)
        {
            this.ProjectService = projectService;
        }
        public ProjectUrlService ProjectService { get; }
        [HttpGet]
        public IEnumerable<Projects> Get()
        {
            return ProjectService.GetProjects();
        }

    }
}
