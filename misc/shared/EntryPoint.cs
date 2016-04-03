using System;
using System.Collections.Generic;
using System.Text;
using RGiesecke.DllExport;
using System.Runtime.InteropServices;
using System.IO;

#if CGAME
using cli_cgame;
#elif GAME
using cli_game;
#elif UI
using cli_ui;
#endif

namespace cli_shared {
	public static class EntryPoint {
		[DllExport(CallingConvention = CallingConvention.Cdecl)]
		public static int cli_entry(EntryCmd Cmd, int A0, int A1, int A2, int A3, int A4, int A5, int A6, int A7, int A8, int A9, int A10, int A11) {
			if (Cmd == EntryCmd.INIT_SYSCALLPTR) {
				Quake.SyscallPtr = (IntPtr)A0;

				CreateDelegate(ref Quake.S0, Quake.SyscallPtr);
				CreateDelegate(ref Quake.S1, Quake.SyscallPtr);
				CreateDelegate(ref Quake.S2, Quake.SyscallPtr);
				CreateDelegate(ref Quake.S3, Quake.SyscallPtr);
				CreateDelegate(ref Quake.S4, Quake.SyscallPtr);
				CreateDelegate(ref Quake.S5, Quake.SyscallPtr);
				CreateDelegate(ref Quake.S6, Quake.SyscallPtr);
				CreateDelegate(ref Quake.S7, Quake.SyscallPtr);
				CreateDelegate(ref Quake.S8, Quake.SyscallPtr);
				CreateDelegate(ref Quake.S9, Quake.SyscallPtr);
				CreateDelegate(ref Quake.S10, Quake.SyscallPtr);
				CreateDelegate(ref Quake.S11, Quake.SyscallPtr);
				CreateDelegate(ref Quake.S12, Quake.SyscallPtr);

				return 0;
			}

			return Entry.VmMain(Cmd, A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11);
		}

		static void CreateDelegate<T>(ref T O, IntPtr FuncPtr) where T : class {
			O = (T)(object)Marshal.GetDelegateForFunctionPointer(FuncPtr, typeof(T));
		}
	}

	public enum EntryCmd : int {
#if GAME
		GAME_INIT,  // ( int levelTime, int randomSeed, int restart );
					// init and shutdown will be called every single level
					// The game should call G_GET_ENTITY_TOKEN to parse through all the
					// entity configuration text and spawn gentities.

		GAME_SHUTDOWN,
		GAME_CLIENT_CONNECT,    // ( int clientNum, qboolean firstTime, qboolean isBot );
								// return NULL if the client is allowed to connect, otherwise return
								// a text string with the reason for denial

		GAME_CLIENT_BEGIN,              // ( int clientNum );
		GAME_CLIENT_USERINFO_CHANGED,   // ( int clientNum );
		GAME_CLIENT_DISCONNECT,         // ( int clientNum );
		GAME_CLIENT_COMMAND,            // ( int clientNum );
		GAME_CLIENT_THINK,              // ( int clientNum );
		GAME_RUN_FRAME,                 // ( int levelTime );
		GAME_CONSOLE_COMMAND,           // ( void );
										// ConsoleCommand will be called when a command has been issued
										// that is not recognized as a builtin function.
										// The game can issue trap_argc() / trap_argv() commands to get the command
										// and parameters.  Return qfalse if the game doesn't recognize it as a command.

		BOTAI_START_FRAME ,             // ( int time );
#elif CGAME
		CG_INIT,
		//	void CG_Init( int serverMessageNum, int serverCommandSequence, int clientNum )
		// called when the level loads or when the renderer is restarted
		// all media should be registered at this time
		// cgame will display loading status by calling SCR_Update, which
		// will call CG_DrawInformation during the loading process
		// reliableCommandSequence will be 0 on fresh loads, but higher for
		// demos, tourney restarts, or vid_restarts

		CG_SHUTDOWN,
		//	void (*CG_Shutdown)( void );
		// oportunity to flush and close any open files

		CG_CONSOLE_COMMAND,
		//	qboolean (*CG_ConsoleCommand)( void );
		// a console command has been issued locally that is not recognized by the
		// main game system.
		// use Cmd_Argc() / Cmd_Argv() to read the command, return qfalse if the
		// command is not known to the game

		CG_DRAW_ACTIVE_FRAME,
		//	void (*CG_DrawActiveFrame)( int serverTime, stereoFrame_t stereoView, qboolean demoPlayback );
		// Generates and draws a game scene and status information at the given time.
		// If demoPlayback is set, local movement prediction will not be enabled

		CG_CROSSHAIR_PLAYER,//	int (*CG_CrosshairPlayer)( void );
		CG_LAST_ATTACKER,//	int (*CG_LastAttacker)( void );
		CG_KEY_EVENT, //	void	(*CG_KeyEvent)( int key, qboolean down );
		CG_MOUSE_EVENT,//	void	(*CG_MouseEvent)( int dx, int dy );
		CG_EVENT_HANDLING, //	void (*CG_EventHandling)(int type);

		CG_DRAW_ACTIVE_FRAME_COMPLETED,
#elif UI
		UI_GETAPIVERSION = 0,   // system reserved
		UI_INIT,    //	void	UI_Init( void );
		UI_SHUTDOWN, //	void	UI_Shutdown( void );
		UI_KEY_EVENT, //	void	UI_KeyEvent( int key );
		UI_MOUSE_EVENT,     //	void	UI_MouseEvent( int dx, int dy );
		UI_REFRESH,     //	void	UI_Refresh( int time );
		UI_IS_FULLSCREEN,   //	qboolean UI_IsFullscreen( void );
		UI_SET_ACTIVE_MENU,     //	void	UI_SetActiveMenu( uiMenuCommand_t menu );
		UI_CONSOLE_COMMAND,     //	qboolean UI_ConsoleCommand( int realTime );
		UI_DRAW_CONNECT_SCREEN,     //	void	UI_DrawConnectScreen( qboolean overlay );
		UI_HASUNIQUECDKEY,
		// if !overlay, the background will be drawn, otherwise it will be
		// overlayed over whatever the cgame has drawn.
		// a GetClientState syscall will be made to get the current strings
#endif

		INIT_SYSCALLPTR = 666,
	}
}