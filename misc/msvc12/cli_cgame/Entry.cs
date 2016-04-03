using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cli_shared;
using cli_shared.Native;

namespace cli_cgame {
	public static class Entry {
		public static int VmMain(EntryCmd Cmd, int A0, int A1, int A2, int A3, int A4, int A5, int A6, int A7, int A8, int A9, int A10, int A11) {
			if (Cmd == EntryCmd.CG_DRAW_ACTIVE_FRAME_COMPLETED) {
				/*QColor Col = QColor.White;
				CGame.UI_DrawProportionalString(130, 300, "Dat head", Quake.UI_DROPSHADOW, ref Col);

				QVector Angles = new QVector(0, 180, 0);
				CGame.CG_DrawHead(100, 100, 200, 200, 0, ref Angles);
				
				return 0;*/
			}

			return -1;
		}
	}
}