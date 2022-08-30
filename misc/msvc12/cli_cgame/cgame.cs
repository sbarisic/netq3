using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using cli_shared;
using cli_shared.Native;
using cli_shared.API;

namespace cli_cgame {
    public static class Entry {
        static Stopwatch RotationWatch = Stopwatch.StartNew();

        public static int VmMain(EntryCmd Cmd, int A0, int A1, int A2, int A3, int A4, int A5, int A6, int A7, int A8, int A9, int A10, int A11) {
            if (Cmd == EntryCmd.CG_INIT) {
                CVar.Register("addons_drawtest", "0");
                Shared.Print("^2.NET CGame Loaded\n");
            } else if (Cmd == EntryCmd.CG_DRAW_ACTIVE_FRAME_COMPLETED) {
                if (CVar.VariableBool("addons_drawtest")) {
                    if (!RotationWatch.IsRunning)
                        RotationWatch.Restart();

                    QColor Col = QColor.White;
                    CGame.UI_DrawProportionalString(130, 300, "Dat head", Quake.UI_DROPSHADOW, ref Col);

                    QVector Angles = new QVector(0, (float)(RotationWatch.Elapsed.TotalMilliseconds / 6), 0);
                    CGame.CG_DrawHead(100, 100, 200, 200, 0, ref Angles);
                } else if (RotationWatch.IsRunning)
                    RotationWatch.Stop();
                return 0;
            }

            return -1;
        }
    }
}