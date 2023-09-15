using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SkillTest_SpeedBox.Dto;
using SkillTest_SpeedBox.Interface;
using SkillTest_SpeedBox.Models;

namespace SkillTest_SpeedBox.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class SdekController : Controller
    {
        private readonly IHttpSdek _repository;
        private readonly IMapper _mapper;

        public SdekController(IHttpSdek repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost("calculator/tariff")]
        public async Task<IActionResult> GetPrice(OrderDTO orderDto)
        {
            var order = _mapper.Map<Order>(orderDto);

            order.version = "1.0";
            order.dateExecute = DateTime.Now.ToString("yyy-MM-dd");
            order.tariffId = 480;
            order.services = new Service[1];
            order.services[0] = new Service() { id = "8" };
            foreach (var item in order.goods)
            {
                item.weight /= 1000;
                item.height /= 10;
                item.length /= 10;
                item.width  /= 10;
            }

            var result = await _repository.CalculetPrice(order);

            return Ok(result);
        }
    }
}
