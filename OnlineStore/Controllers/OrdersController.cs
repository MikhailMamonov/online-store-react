using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineStore.Domain.Core.Entities;
using OnlineStore.Domain.Core.Repositories.Base;

namespace OnlineStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public OrdersController(ILogger<OrdersController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Orders = await _unitOfWork.Orders.FindAllAsync();
            return Ok(Orders);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _unitOfWork.Orders.FindByIdAsync(id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult> CreateOrder(Order Order)
        {
            if (ModelState.IsValid)
            {

                await _unitOfWork.Orders.CreateAsync(Order);
                await _unitOfWork.CompleteAsync();
                return CreatedAtAction("GetItem", new { Order.Id }, Order);
            }

            return new JsonResult("Somethign Went wrong") { StatusCode = 500 };
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, Order Order)
        {
            if (id != Order.Id)
                return BadRequest();
            await _unitOfWork.Orders.UpdateAsync(Order);
            await _unitOfWork.CompleteAsync();
            return NoContent();


        }

        // POST: OrdersController/Delete/5
        [HttpDelete("{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var Order = await _unitOfWork.Orders.FindByIdAsync(id);
            if (Order == null)
                return BadRequest();
            await _unitOfWork.Orders.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
            return Ok(Order);
        }
    }
}
