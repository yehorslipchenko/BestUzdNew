using AutoMapper;
using BestUzdNew.Api.Dtos.Input;
using BestUzdNew.Domain.Entities;
using BestUzdNew.Logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestUzdNew.Api.Controllers
{
    [Route("api/servicegroup")]
    [ApiController]
    public class ServiceGroupController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServiceForServiceGroupEntity _service;

        public ServiceGroupController(IMapper mapper, IServiceForServiceGroupEntity sGroupService)
        {
            _mapper = mapper;
            _service = sGroupService;
        }



        [HttpPost]
        public async Task<IActionResult> CreateServiceGroup(ServiceGroupInDto serviceGroupInDto)
        {
            var serviceGroup = _mapper.Map<ServiceGroupInDto, ServiceGroup>(serviceGroupInDto);
            await _service.CreateServiceGroupAsync(serviceGroup);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var serviceGroup = await _service.GetServiceGroupAsync();
            var serviceGroupsDto = _mapper.Map<IEnumerable<ServiceGroup>, IEnumerable<ServiceGroupInDto>>(serviceGroup);

            return Ok(serviceGroupsDto);
        }
    }
}
