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
			app.Screenshot("Let's start by Tapping on the 'Shop Now' Button");

			app.Tap("WOMEN");
			app.Screenshot("Then we Tapped on 'Women'");

			app.Tap(x => x.Class("android.widget.FrameLayout").Index(1));
			app.Screenshot("Next we Tapped on 'Shoes'");

			app.Tap("image");
			app.Screenshot("We Tapped on the first shoe");

			app.Tap("website_button");
			app.Screenshot();

			app.ScrollDown();

			app.Tap("5");

			app.Tap("website_button");
		}


	}
}
