//
// System.Windows.Forms.MessageBoxOptions.cs
//
// Author:
//   Dennis Hayes (dennish@raytek.com)
//
// (C) 2002 Ximian, Inc.  http://www.ximian.com
//

namespace System.Windows.Forms
{
	[Flags]
	public enum MessageBoxOptions
	{
		DefaultDesktopOnly = 131072,
		RightAlign = 524288,
		RtlReading = 1048576,
		ServiceNotification = 2097152
	}
}
