using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOwinKatana
{
	class Program
	{
		static void Main(string[] args)
		{
			string url = "http://localhost:8080";

			using (WebApp.Start<Startup>(url))
			{
				Console.WriteLine("Started");
				Console.ReadKey();
				Console.WriteLine("Stopping");
			}
		}
	}

	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.Use<HelloWorldComponent>();

			//app.UseWelcomePage();

			//app.Run(ctx =>
			//	{
			//		return ctx.Response.WriteAsync("Hello World");
			//	});
		}
	}

	public class HelloWorldComponent
	{
		public Task Inwoke(IDictionary<string, object> enviroment)
		{
			return null;
		}
	}
}
