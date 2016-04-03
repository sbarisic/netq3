using System;
using System.Collections.Generic;
using System.Text;

namespace cli_shared {
#if UI
	public static unsafe class UI {
		public static void CVar_Register(vmCvar* CVar, string VarName, string Value, int Flags) {
			EntryPoint.Syscall_cvar_string_string_int(SYSCALL.UI_CVAR_REGISTER, CVar, VarName, Value, Flags);
		}
	}
#endif
}