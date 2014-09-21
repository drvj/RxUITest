
using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;
using ReactiveUI;

namespace RxUITest
{
	public partial class MainWindow : MonoMac.AppKit.NSWindow
	{
		#region Constructors

		// Called when created from unmanaged code
		public MainWindow (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public MainWindow (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		
		// Shared initialization code
		void Initialize ()
		{
			var vm = new TestViewModel ();
			vm.List = new ReactiveList<string> ();
		}

		#endregion
	}

	public class TestViewModel : ReactiveObject
	{
		public ReactiveList<string> List {
			get;
			set;
		}
	}
}

