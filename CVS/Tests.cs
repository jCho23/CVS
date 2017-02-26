using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace CVS
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
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("notNowTextView");
			app.Screenshot("Let's start by Tapping on the 'Not Now' Button");

			app.Tap("ecMyDeals");
			app.Screenshot("We Tapped on the screen to dismiss the intro");

			app.Tap("optinNoThanks");
			app.Screenshot("Next, we declined the Bluetooth option");

			//app.Tap("hs_cvsTodayTitle");
			//app.Screenshot("Then, we Tapped on the 'Shop' Button");

			//app.Tap(x => x.Css("#un_searchbox"));
			//app.Screenshot("We Tapped on the 'Search' Text Field");

			//app.EnterText("Christmas");
			//app.Screenshot("We entered in our search, 'Christmas'");

			//app.PressEnter();
			//app.Screenshot("Then we Tapped the 'Enter' Button");

			//app.Tap(x => x.Css(".plp-mobileListItem").Index(1));
			//app.Screenshot("Next, we Tapped on our Christmas Item");

			//app.Back();
			//app.Screenshot("We Tapped on the 'Back' Button to return to home page");

		}

	}
}
