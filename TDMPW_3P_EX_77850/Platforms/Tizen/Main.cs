using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace TDMPW_3P_EX_77850;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}