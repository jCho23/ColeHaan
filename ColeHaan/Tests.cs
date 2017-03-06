using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ColeHaan
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void AddWomenShoeTest()
		{
			app.Tap("skip_login");


			app.Tap("WOMEN");

			app.Tap(x => x.Class("android.widget.FrameLayout").Index(1));

			app.Tap("image");

			app.Tap("website_button");

			app.ScrollDown();

			app.Tap("5");

			app.Tap("website_button");
		}


	}
}
