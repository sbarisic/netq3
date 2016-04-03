using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using cli_shared;
using cli_shared.API;

namespace cli_ui {
	public static unsafe class Entry {
		static vmCvar addons_dotnet = new vmCvar();

		public static int VmMain(EntryCmd Cmd, int A0, int A1, int A2, int A3, int A4, int A5, int A6, int A7, int A8, int A9, int A10, int A11) {
			if (Cmd == EntryCmd.UI_INIT) {
				Shared.Print("^2Loading .NET Extensions\n");
				UI.CVar_Register(ref addons_dotnet, nameof(addons_dotnet), "1", Quake.CVAR_ARCHIVE);
			} else  if (Cmd == EntryCmd.UI_HASUNIQUECDKEY)
				return Quake.QFalse;

			return -1;
		}
	}
}