using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreReact.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreReact.Controllers
{
	public class HomeController : Controller
	{
		private static readonly IList<CommentModel> _comments;

		static HomeController()
		{
			_comments = new List<CommentModel>
			{
				new CommentModel
				{
					Id = 1,
					Author = "Daniel Lo Nigro",
					Text = "Hello ReactJS.NET World!"
				},
				new CommentModel
				{
					Id = 2,
					Author = "Pete Hunt",
					Text = "This is one comment"
				},
				new CommentModel
				{
					Id = 3,
					Author = "Jordan Walke",
					Text = "This is *another* comment"
				},
			};
		}

		public IActionResult Index()
		{
			return View();
		}

		[Route("comments")]
		[ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
		public ActionResult Comments()
		{
			return Json(_comments);
		}
	}
}