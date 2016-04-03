using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace cli_shared {
	public static class Shared {
		public static void Print(string Str) {
			EntryPoint.Syscall_string(SYSCALL.PRINT, Str);
		}

		public static void Error(string Str) {
			EntryPoint.Syscall_string(SYSCALL.ERROR, Str);
		}
	}
}