using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace cli_shared {
	public unsafe struct vmCvar {
		public int Handle;
		public int ModificationCount;
		public float Value;
		public int Integer;
		fixed byte _String[Constants.MAX_CVAR_VALUE_STRING];

		public string String
		{
			get
			{
				fixed (byte* StrBuf = _String)
				{
					return Marshal.PtrToStringAnsi(new IntPtr(StrBuf));
				}
			}
		}
	}
}
