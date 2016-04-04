using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace cli_shared.API {
#if UI
	public unsafe static class UI {
		public static int ArgC() {
			return Quake.Syscall(SYSCALL.UI_ARGC);
		}

		public static string ArgV(int N) {
			byte* Buf = stackalloc byte[Quake.MAX_CVAR_VALUE_STRING];
			Quake.Syscall(SYSCALL.UI_ARGV, N, new IntPtr(Buf), Quake.MAX_CVAR_VALUE_STRING);
			return Marshal.PtrToStringAnsi(new IntPtr(Buf));
		}
	}
#endif
}
