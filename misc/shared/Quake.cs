using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace cli_shared {
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int sf_0(SYSCALL A);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int sf_1(SYSCALL A, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A1);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int sf_2(SYSCALL A, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A2);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int sf_3(SYSCALL A, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A3);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int sf_4(SYSCALL A, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A3, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A4);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int sf_5(SYSCALL A, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A3, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A4, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A5);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int sf_6(SYSCALL A, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A3, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A4, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A5, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A6);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int sf_7(SYSCALL A, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A3, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A4, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A5, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A6, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A7);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int sf_8(SYSCALL A, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A3, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A4, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A5, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A6, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A7, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A8);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int sf_9(SYSCALL A, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A3, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A4, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A5, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A6, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A7, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A8, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A9);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int sf_10(SYSCALL A, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A3, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A4, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A5, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A6, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A7, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A8, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A9, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A10);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int sf_11(SYSCALL A, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A3, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A4, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A5, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A6, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A7, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A8, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A9, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A10, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A11);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int sf_12(SYSCALL A, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A3, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A4, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A5, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A6, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A7, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A8, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A9, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A10, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A11, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ObjectMarshal))] object A12);

	public static unsafe class Quake {
		public const CharSet CSet = CharSet.Ansi;
		public const CallingConvention CConv = CallingConvention.Cdecl;

		public const int MAX_CVAR_VALUE_STRING = 256;
		public const int QTrue = 1;
		public const int QFalse = 0;

		public const int CVAR_ARCHIVE = 0x0001;
		public const uint CVAR_USERINFO = 0x0002;   // sent to server on connect or change
		public const uint CVAR_SERVERINFO = 0x0004; // sent in response to front end requests
		public const uint CVAR_SYSTEMINFO = 0x0008; // these cvars will be duplicated on all clients
		public const uint CVAR_INIT = 0x0010;       // don't allow change from console at all, but can be set from the command line
		public const uint CVAR_LATCH = 0x0020;
		public const uint CVAR_ROM = 0x0040;            // display only, cannot be set by user at all
		public const uint CVAR_USER_CREATED = 0x0080;   // created by a set command
		public const uint CVAR_TEMP = 0x0100;           // can be set even when cheats are disabled, but is not archived
		public const uint CVAR_CHEAT = 0x0200;          // can not be changed if cheats are disabled
		public const uint CVAR_NORESTART = 0x0400;      // do not clear when a cvar_restart is issued
		public const uint CVAR_SERVER_CREATED = 0x0800; // cvar was created by a server the client connected to.
		public const uint CVAR_VM_CREATED = 0x1000;     // cvar was created exclusively in one of the VMs.
		public const uint CVAR_PROTECTED = 0x2000; // prevent modifying this var from VMs or the server,These flags are only returned by the Cvar_Flags() function
		public const uint CVAR_MODIFIED = 0x40000000;       // Cvar was modified
		public const uint CVAR_NONEXISTENT = 0x80000000;    // Cvar doesn't exist.

		public const int UI_LEFT = 0x00000000; // default
		public const int UI_CENTER = 0x00000001;
		public const int UI_RIGHT = 0x00000002;
		public const int UI_FORMATMASK = 0x00000007;
		public const int UI_SMALLFONT = 0x00000010;
		public const int UI_BIGFONT = 0x00000020; // default
		public const int UI_GIANTFONT = 0x00000040;
		public const int UI_DROPSHADOW = 0x00000800;
		public const int UI_BLINK = 0x00001000;
		public const int UI_INVERSE = 0x00002000;
		public const int UI_PULSE = 0x00004000;

		public static IntPtr SyscallPtr;

		public static sf_0 S0;
		public static sf_1 S1; public static sf_2 S2;
		public static sf_3 S3; public static sf_4 S4;
		public static sf_5 S5; public static sf_6 S6;
		public static sf_7 S7; public static sf_8 S8;
		public static sf_9 S9; public static sf_10 S10;
		public static sf_11 S11; public static sf_12 S12;

		public static int Syscall(SYSCALL S) => S0(S);
		public static int Syscall(SYSCALL S, object A1) => S1(S, A1);
		public static int Syscall(SYSCALL S, object A1, object A2) => S2(S, A1, A2);
		public static int Syscall(SYSCALL S, object A1, object A2, object A3) => S3(S, A1, A2, A3);
		public static int Syscall(SYSCALL S, object A1, object A2, object A3, object A4) => S4(S, A1, A2, A3, A4);
		public static int Syscall(SYSCALL S, object A1, object A2, object A3, object A4, object A5) => S5(S, A1, A2, A3, A4, A5);
		public static int Syscall(SYSCALL S, object A1, object A2, object A3, object A4, object A5, object A6) => S6(S, A1, A2, A3, A4, A5, A6);
		public static int Syscall(SYSCALL S, object A1, object A2, object A3, object A4, object A5, object A6, object A7) => S7(S, A1, A2, A3, A4, A5, A6, A7);
		public static int Syscall(SYSCALL S, object A1, object A2, object A3, object A4, object A5, object A6, object A7, object A8) => S8(S, A1, A2, A3, A4, A5, A6, A7, A8);
		public static int Syscall(SYSCALL S, object A1, object A2, object A3, object A4, object A5, object A6, object A7, object A8, object A9) => S9(S, A1, A2, A3, A4, A5, A6, A7, A8, A9);
		public static int Syscall(SYSCALL S, object A1, object A2, object A3, object A4, object A5, object A6, object A7, object A8, object A9, object A10) => S10(S, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10);
		public static int Syscall(SYSCALL S, object A1, object A2, object A3, object A4, object A5, object A6, object A7, object A8, object A9, object A10, object A11) => S11(S, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11);
		public static int Syscall(SYSCALL S, object A1, object A2, object A3, object A4, object A5, object A6, object A7, object A8, object A9, object A10, object A11, object A12) => S12(S, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12);

		public static IntPtr Alloc(int Size) {
			IntPtr Ptr = Marshal.AllocHGlobal(Size);
			for (int i = 0; i < Size; i++)
				*(byte*)(Ptr + i) = 0;
			return Ptr;
		}

		public static void Free(IntPtr Ptr) {
			Marshal.FreeHGlobal(Ptr);
		}

		public static string ToString(IntPtr Ptr) {
			return Marshal.PtrToStringAnsi(Ptr);
		}
	}
}