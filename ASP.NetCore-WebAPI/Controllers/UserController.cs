using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ASP.NetCore_WebAPI.Models;

namespace ASP.NetCore_WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		public static List<User> users = new List<User>();

		[HttpGet]
		public List<User> getNames()
		{
			return users;
		}

		[HttpPost]
		public void PostNames(string name)
		{
			if (!string.IsNullOrEmpty(name))
				users.Add(new User(name));
		}

		[HttpDelete]
		public void DeletNames(string name)
		{
			users.RemoveAt(users.IndexOf(users.First(x => x.Name.Equals(name))));
		}
	}
}
