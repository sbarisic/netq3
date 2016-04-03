using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace cli_shared.API {
#if UI
	public unsafe static class UI {
		public static void CVar_Register(ref vmCvar CVar, string Name, string Value, int Flags = 0) {
			fixed (vmCvar* CVarPtr = &CVar)
			{
				Quake.Syscall(SYSCALL.UI_CVAR_REGISTER, new IntPtr(CVarPtr), Name, Value, Flags);
			}
		}

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
