using System;
using System.Collections.Generic;
using System.Text;

namespace cli_shared.API {
	public static class Shared {
		public static void Print(string Str) {
			Quake.Syscall(SYSCALL.PRINT, Str);
		}

		public static void Print(string Fmt, params object[] Args) {
			Print(string.Format(Fmt, Args));
		}

		public static void Error(string Str) {
			Quake.Syscall(SYSCALL.ERROR, Str);
		}

		public static void Error(string Fmt, params object[] Args) {
			Error(string.Format(Fmt, Args));
		}
	}
}
