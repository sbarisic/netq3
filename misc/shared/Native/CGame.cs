using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;

namespace cli_shared.Native {
#if CGAME
	public static unsafe class CGame {
		const string Dll = "cgamex86";

		[DllImport(Dll, CallingConvention = Quake.CConv, CharSet = Quake.CSet)]
		public static extern void UI_DrawProportionalString(int x, int y, string str, int style, ref QColor color);

		[DllImport(Dll, CallingConvention = Quake.CConv, CharSet = Quake.CSet)]
		public static extern void CG_DrawRect(float x, float y, float width, float height, float size, ref QColor color);

		[DllImport(Dll, CallingConvention = Quake.CConv, CharSet = Quake.CSet)]
		public static extern void CG_DrawSides(float x, float y, float w, float h, float size);

		[DllImport(Dll, CallingConvention = Quake.CConv, CharSet = Quake.CSet)]
		public static extern void CG_DrawTopBottom(float x, float y, float w, float h, float size);

		[DllImport(Dll, CallingConvention = Quake.CConv, CharSet = Quake.CSet)]
		public static extern void CG_FillRect(float x, float y, float width, float height, ref QColor color);

		[DllImport(Dll, CallingConvention = Quake.CConv, CharSet = Quake.CSet)]
		public static extern void CG_DrawPic(float x, float y, float width, float height, qhandle_t hShader);

		[DllImport(Dll, CallingConvention = Quake.CConv, CharSet = Quake.CSet)]
		public static extern void CG_DrawHead(float x, float y, float w, float h, int clientNum, ref QVector headAngles);
	}
#endif
}