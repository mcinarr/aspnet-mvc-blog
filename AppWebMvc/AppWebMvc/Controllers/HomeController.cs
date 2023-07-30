﻿using AppWebMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppWebMvc.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Index2()
		{
			return View();
		}

		public IActionResult Index3()
		{
			return View();
		}

		public IActionResult Index4()
		{
			return View();
		}
		public IActionResult Index5()
		{
			return View();
		}
		public IActionResult Index6()
		{
			return View();
		}



		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}