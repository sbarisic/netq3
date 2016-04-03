using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace cli_shared {
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = Quake.CSet)]
	public unsafe struct vmCvar {
		public int Handle;
		public int ModificationCount;
		public float Value;
		public int Integer;
		public fixed char String[Quake.MAX_CVAR_VALUE_STRING];
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = Quake.CSet)]
	public unsafe struct QColor {
		public static QColor Red = new QColor(1, 0, 0, 1);
		public static QColor Green = new QColor(0, 1, 0, 1);
		public static QColor Blue = new QColor(0, 0, 1, 1);
		public static QColor White = new QColor(1, 1, 1, 1);
		public static QColor Black = new QColor(0, 0, 0, 1);

		public float R, G, B, A;

		public QColor(float R, float G, float B, float A) {
			this.R = R;
			this.G = G;
			this.B = B;
			this.A = A;
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = Quake.CSet)]
	public unsafe struct QVector {
		public static QVector Zero = new QVector(0, 0, 0);

		public float X, Y, Z;

		public QVector(float X, float Y, float Z) {
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = Quake.CSet)]
	public unsafe struct qhandle_t {
		public int Value;
	}
}