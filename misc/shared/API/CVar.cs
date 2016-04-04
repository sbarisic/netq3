using System;
using System.Collections.Generic;
using System.Text;

namespace cli_shared.API {
	public static unsafe class CVar {
		static void CVar_Register(vmCvar* CVar, string Name, string Value, int Flags) {
			Quake.Syscall(
#if CGAME
					SYSCALL.CG_CVAR_REGISTER
#elif GAME
					SYSCALL.G_CVAR_REGISTER
#elif UI
					SYSCALL.UI_CVAR_REGISTER
#endif
					, new IntPtr(CVar), Name, Value, Flags);
		}

		public static void Register(ref vmCvar CVar, string Name, string Value, int Flags = 0) {
			fixed (vmCvar* CVarPtr = &CVar)
			{
				CVar_Register(CVarPtr, Name, Value, Flags);
			}
		}

		public static void Register(string Name, string Value, int Flags = 0) {
			CVar_Register(null, Name, Value, Flags);
		}

		public static void Update(ref vmCvar CVar) {
			fixed (vmCvar* CVarPtr = &CVar)
			{
				Quake.Syscall(
#if CGAME
					SYSCALL.CG_CVAR_UPDATE
#elif GAME
					SYSCALL.G_CVAR_UPDATE
#elif UI
					SYSCALL.UI_CVAR_UPDATE
#endif
				, new IntPtr(CVarPtr));
			}
		}

		public static void Set(string Name, string Value) {
			Quake.Syscall(
#if CGAME
					SYSCALL.CG_CVAR_SET
#elif GAME
					SYSCALL.G_CVAR_SET
#elif UI
					SYSCALL.UI_CVAR_SET
#endif
				, Name, Value);
		}

		public static string VariableString(string Name) {
			IntPtr Val = Quake.Alloc(Quake.MAX_CVAR_VALUE_STRING);
			Quake.Syscall(
#if CGAME
					SYSCALL.CG_CVAR_VARIABLESTRINGBUFFER
#elif GAME
					SYSCALL.G_CVAR_VARIABLE_STRING_BUFFER
#elif UI
					SYSCALL.UI_CVAR_VARIABLESTRINGBUFFER
#endif
				, Name, Val, Quake.MAX_CVAR_VALUE_STRING);
			string Str = Quake.ToString(Val);
			Quake.Free(Val);
			return Str;
		}

		public static int VariableInt(string Name) {
			string Val = VariableString(Name);
			int I;
			if (int.TryParse(Val, out I))
				return I;
			return 0;
		}

		public static bool VariableBool(string Name) {
			return VariableInt(Name) != 0;
		}
	}
}