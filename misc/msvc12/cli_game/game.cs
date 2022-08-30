using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cli_shared;
using cli_shared.API;
using cli_shared.Native;

namespace cli_game {
    public static class Entry {
        public static int VmMain(EntryCmd Cmd, int A0, int A1, int A2, int A3, int A4, int A5, int A6, int A7, int A8, int A9, int A10, int A11) {
            if (Cmd == EntryCmd.GAME_INIT) {
                Shared.Print("^2.NET Game Loaded\n");
            }

            return -1;
        }
    }
}