﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
namespace Project_Ecosystem;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
    class EcoSystemProgram
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Ecosystem System = new Ecosystem();
                System.startSystem();
            }
        }
    }
}
}
