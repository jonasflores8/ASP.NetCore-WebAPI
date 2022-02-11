namespace ASP.NetCore_WebAPI.Models
{
	public class User
	{
		public User(string name)
		{
			this.Name = name;
		}

		public string? Name { get; set; }
	}
}
