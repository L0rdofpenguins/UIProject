using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using TelerikUI.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting.Internal;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TelerikUI.Controllers
{
    public class TelerikUIPagesController : Controller
    {
        private static IOrder _orders;

        public TelerikUIPagesController(IOrder orders)
        {
            _orders = orders;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Grid()
        { 
            return View();
        }

        public IActionResult DragDrop()
        {
            return View();
        }

        public IActionResult ToolTip()
        {
            return View();
        }

        public IActionResult DropDownList()
        {
            return View();
        }

        public IActionResult Calendar()
        {
            return View();
        }

        public IActionResult BarGraphPieChart()
        {
            return View();
        }

        public IActionResult TreeView()
        {
            return View();
        }

        public IActionResult ReadOrders([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetOrders().ToDataSourceResult(request));
        }

        private static IEnumerable<OrderDTO> GetOrders()
        {
            var orders= _orders.GetAll();
            var orderDTOs = new List<OrderDTO>();
            foreach (Order o in orders)
            {
                orderDTOs.Add(new OrderDTO
                {
                    OrderId = o.OrderId,
                    StartDate = o.StartDate,
                    FinishDate = o.FinishDate
                });
            }

            return orderDTOs;
        }

        public async Task<ActionResult> SaveAsync(IEnumerable<IFormFile> files)
        {
            if (files != null)
            {
                foreach (var file in files)
                {
                    var fileContent = ContentDispositionHeaderValue.Parse(file.ContentDisposition);

                    // Some browsers send file names with full path.
                    // We are only interested in the file name.
                    var fileName = Path.GetFileName(fileContent.FileName.ToString().Trim('"'));
                    var hs = new HostingEnvironment();
                    var physicalPath = Path.Combine(hs.WebRootPath, "app_data", fileName);

                    // The files are not actually saved in this demo
                    using (var fileStream = new FileStream(physicalPath, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }
            }

            // Return an empty string to signify success
            return Content("");
        }
    }

}
