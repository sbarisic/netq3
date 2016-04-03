using System;
using System.Collections.Generic;
using System.Text;

namespace cli_shared {
	public enum SYSCALL : int {
#if GAME
		//============== general Quake services ==================

		PRINT,        // ( const char *string );
						// print message on the local console

		ERROR,        // ( const char *string );
						// abort the game

		G_MILLISECONDS, // ( void );
						// get current time for profiling reasons
						// this should NOT be used for any game related tasks,
						// because it is not journaled

		// console variable interaction
		G_CVAR_REGISTER,    // ( vmCvar_t *vmCvar, const char *varName, const char *defaultValue, int flags );
		G_CVAR_UPDATE,  // ( vmCvar_t *vmCvar );
		G_CVAR_SET,     // ( const char *var_name, const char *value );
		G_CVAR_VARIABLE_INTEGER_VALUE,  // ( const char *var_name );

		G_CVAR_VARIABLE_STRING_BUFFER,  // ( const char *var_name, char *buffer, int bufsize );

		G_ARGC,         // ( void );
						// ClientCommand and ServerCommand parameter access

		G_ARGV,         // ( int n, char *buffer, int bufferLength );

		G_FS_FOPEN_FILE,    // ( const char *qpath, fileHandle_t *file, fsMode_t mode );
		G_FS_READ,      // ( void *buffer, int len, fileHandle_t f );
		G_FS_WRITE,     // ( const void *buffer, int len, fileHandle_t f );
		G_FS_FCLOSE_FILE,       // ( fileHandle_t f );

		G_SEND_CONSOLE_COMMAND, // ( const char *text );
								// add commands to the console as if they were typed in
								// for map changing, etc


		//=========== server specific functionality =============

		G_LOCATE_GAME_DATA,     // ( gentity_t *gEnts, int numGEntities, int sizeofGEntity_t,
								//							playerState_t *clients, int sizeofGameClient );
								// the game needs to let the server system know where and how big the gentities
								// are, so it can look at them directly without going through an interface

		G_DROP_CLIENT,      // ( int clientNum, const char *reason );
							// kick a client off the server with a message

		G_SEND_SERVER_COMMAND,  // ( int clientNum, const char *fmt, ... );
								// reliably sends a command string to be interpreted by the given
								// client.  If clientNum is -1, it will be sent to all clients

		G_SET_CONFIGSTRING, // ( int num, const char *string );
							// config strings hold all the index strings, and various other information
							// that is reliably communicated to all clients
							// All of the current configstrings are sent to clients when
							// they connect, and changes are sent to all connected clients.
							// All confgstrings are cleared at each level start.

		G_GET_CONFIGSTRING, // ( int num, char *buffer, int bufferSize );

		G_GET_USERINFO,     // ( int num, char *buffer, int bufferSize );
							// userinfo strings are maintained by the server system, so they
							// are persistant across level loads, while all other game visible
							// data is completely reset

		G_SET_USERINFO,     // ( int num, const char *buffer );

		G_GET_SERVERINFO,   // ( char *buffer, int bufferSize );
							// the serverinfo info string has all the cvars visible to server browsers

		G_SET_BRUSH_MODEL,  // ( gentity_t *ent, const char *name );
							// sets mins and maxs based on the brushmodel name

		G_TRACE,    // ( trace_t *results, const vec3_t start, const vec3_t mins, const vec3_t maxs, const vec3_t end, int passEntityNum, int contentmask );
					// collision detection against all linked entities

		G_POINT_CONTENTS,   // ( const vec3_t point, int passEntityNum );
							// point contents against all linked entities

		G_IN_PVS,           // ( const vec3_t p1, const vec3_t p2 );

		G_IN_PVS_IGNORE_PORTALS,    // ( const vec3_t p1, const vec3_t p2 );

		G_ADJUST_AREA_PORTAL_STATE, // ( gentity_t *ent, qboolean open );

		G_AREAS_CONNECTED,  // ( int area1, int area2 );

		G_LINKENTITY,       // ( gentity_t *ent );
							// an entity will never be sent to a client or used for collision
							// if it is not passed to linkentity.  If the size, position, or
							// solidity changes, it must be relinked.

		G_UNLINKENTITY,     // ( gentity_t *ent );		
							// call before removing an interactive entity

		G_ENTITIES_IN_BOX,  // ( const vec3_t mins, const vec3_t maxs, gentity_t **list, int maxcount );
							// EntitiesInBox will return brush models based on their bounding box,
							// so exact determination must still be done with EntityContact

		G_ENTITY_CONTACT,   // ( const vec3_t mins, const vec3_t maxs, const gentity_t *ent );
							// perform an exact check against inline brush models of non-square shape

		// access for bots to get and free a server client (FIXME?)
		G_BOT_ALLOCATE_CLIENT,  // ( void );

		G_BOT_FREE_CLIENT,  // ( int clientNum );

		G_GET_USERCMD,  // ( int clientNum, usercmd_t *cmd )

		G_GET_ENTITY_TOKEN, // qboolean ( char *buffer, int bufferSize )
							// Retrieves the next string token from the entity spawn text, returning
							// false when all tokens have been parsed.
							// This should only be done at GAME_INIT time.

		G_FS_GETFILELIST,
		G_DEBUG_POLYGON_CREATE,
		G_DEBUG_POLYGON_DELETE,
		G_REAL_TIME,
		G_SNAPVECTOR,

		G_TRACECAPSULE, // ( trace_t *results, const vec3_t start, const vec3_t mins, const vec3_t maxs, const vec3_t end, int passEntityNum, int contentmask );
		G_ENTITY_CONTACTCAPSULE,    // ( const vec3_t mins, const vec3_t maxs, const gentity_t *ent );

		// 1.32
		G_FS_SEEK,

		BOTLIB_SETUP = 200,             // ( void );
		BOTLIB_SHUTDOWN,                // ( void );
		BOTLIB_LIBVAR_SET,
		BOTLIB_LIBVAR_GET,
		BOTLIB_PC_ADD_GLOBAL_DEFINE,
		BOTLIB_START_FRAME,
		BOTLIB_LOAD_MAP,
		BOTLIB_UPDATENTITY,
		BOTLIB_TEST,

		BOTLIB_GET_SNAPSHOT_ENTITY,     // ( int client, int ent );
		BOTLIB_GET_CONSOLE_MESSAGE,     // ( int client, char *message, int size );
		BOTLIB_USER_COMMAND,            // ( int client, usercmd_t *ucmd );

		BOTLIB_AAS_ENABLE_ROUTING_AREA = 300,
		BOTLIB_AAS_BBOX_AREAS,
		BOTLIB_AAS_AREA_INFO,
		BOTLIB_AAS_ENTITY_INFO,

		BOTLIB_AAS_INITIALIZED,
		BOTLIB_AAS_PRESENCE_TYPE_BOUNDING_BOX,
		BOTLIB_AAS_TIME,

		BOTLIB_AAS_POINT_AREA_NUM,
		BOTLIB_AAS_TRACE_AREAS,

		BOTLIB_AAS_POINT_CONTENTS,
		BOTLIB_AAS_NEXT_BSP_ENTITY,
		BOTLIB_AAS_VALUE_FOR_BSP_EPAIR_KEY,
		BOTLIB_AAS_VECTOR_FOR_BSP_EPAIR_KEY,
		BOTLIB_AAS_FLOAT_FOR_BSP_EPAIR_KEY,
		BOTLIB_AAS_INT_FOR_BSP_EPAIR_KEY,

		BOTLIB_AAS_AREA_REACHABILITY,

		BOTLIB_AAS_AREA_TRAVEL_TIME_TO_GOAL_AREA,

		BOTLIB_AAS_SWIMMING,
		BOTLIB_AAS_PREDICT_CLIENT_MOVEMENT,

		BOTLIB_EA_SAY = 400,
		BOTLIB_EA_SAY_TEAM,
		BOTLIB_EA_COMMAND,

		BOTLIB_EA_ACTION,
		BOTLIB_EA_GESTURE,
		BOTLIB_EA_TALK,
		BOTLIB_EA_ATTACK,
		BOTLIB_EA_USE,
		BOTLIB_EA_RESPAWN,
		BOTLIB_EA_CROUCH,
		BOTLIB_EA_MOVE_UP,
		BOTLIB_EA_MOVE_DOWN,
		BOTLIB_EA_MOVE_FORWARD,
		BOTLIB_EA_MOVE_BACK,
		BOTLIB_EA_MOVE_LEFT,
		BOTLIB_EA_MOVE_RIGHT,

		BOTLIB_EA_SELECT_WEAPON,
		BOTLIB_EA_JUMP,
		BOTLIB_EA_DELAYED_JUMP,
		BOTLIB_EA_MOVE,
		BOTLIB_EA_VIEW,

		BOTLIB_EA_END_REGULAR,
		BOTLIB_EA_GET_INPUT,
		BOTLIB_EA_RESET_INPUT,


		BOTLIB_AI_LOAD_CHARACTER = 500,
		BOTLIB_AI_FREE_CHARACTER,
		BOTLIB_AI_CHARACTERISTIC_FLOAT,
		BOTLIB_AI_CHARACTERISTIC_BFLOAT,
		BOTLIB_AI_CHARACTERISTIC_INTEGER,
		BOTLIB_AI_CHARACTERISTIC_BINTEGER,
		BOTLIB_AI_CHARACTERISTIC_STRING,

		BOTLIB_AI_ALLOC_CHAT_STATE,
		BOTLIB_AI_FREE_CHAT_STATE,
		BOTLIB_AI_QUEUE_CONSOLE_MESSAGE,
		BOTLIB_AI_REMOVE_CONSOLE_MESSAGE,
		BOTLIB_AI_NEXT_CONSOLE_MESSAGE,
		BOTLIB_AI_NUM_CONSOLE_MESSAGE,
		BOTLIB_AI_INITIAL_CHAT,
		BOTLIB_AI_REPLY_CHAT,
		BOTLIB_AI_CHAT_LENGTH,
		BOTLIB_AI_ENTER_CHAT,
		BOTLIB_AI_STRING_CONTAINS,
		BOTLIB_AI_FIND_MATCH,
		BOTLIB_AI_MATCH_VARIABLE,
		BOTLIB_AI_UNIFY_WHITE_SPACES,
		BOTLIB_AI_REPLACE_SYNONYMS,
		BOTLIB_AI_LOAD_CHAT_FILE,
		BOTLIB_AI_SET_CHAT_GENDER,
		BOTLIB_AI_SET_CHAT_NAME,

		BOTLIB_AI_RESET_GOAL_STATE,
		BOTLIB_AI_RESET_AVOID_GOALS,
		BOTLIB_AI_PUSH_GOAL,
		BOTLIB_AI_POP_GOAL,
		BOTLIB_AI_EMPTY_GOAL_STACK,
		BOTLIB_AI_DUMP_AVOID_GOALS,
		BOTLIB_AI_DUMP_GOAL_STACK,
		BOTLIB_AI_GOAL_NAME,
		BOTLIB_AI_GET_TOP_GOAL,
		BOTLIB_AI_GET_SECOND_GOAL,
		BOTLIB_AI_CHOOSE_LTG_ITEM,
		BOTLIB_AI_CHOOSE_NBG_ITEM,
		BOTLIB_AI_TOUCHING_GOAL,
		BOTLIB_AI_ITEM_GOAL_IN_VIS_BUT_NOT_VISIBLE,
		BOTLIB_AI_GET_LEVEL_ITEM_GOAL,
		BOTLIB_AI_AVOID_GOAL_TIME,
		BOTLIB_AI_INIT_LEVEL_ITEMS,
		BOTLIB_AI_UPDATE_ENTITY_ITEMS,
		BOTLIB_AI_LOAD_ITEM_WEIGHTS,
		BOTLIB_AI_FREE_ITEM_WEIGHTS,
		BOTLIB_AI_SAVE_GOAL_FUZZY_LOGIC,
		BOTLIB_AI_ALLOC_GOAL_STATE,
		BOTLIB_AI_FREE_GOAL_STATE,

		BOTLIB_AI_RESET_MOVE_STATE,
		BOTLIB_AI_MOVE_TO_GOAL,
		BOTLIB_AI_MOVE_IN_DIRECTION,
		BOTLIB_AI_RESET_AVOID_REACH,
		BOTLIB_AI_RESET_LAST_AVOID_REACH,
		BOTLIB_AI_REACHABILITY_AREA,
		BOTLIB_AI_MOVEMENT_VIEW_TARGET,
		BOTLIB_AI_ALLOC_MOVE_STATE,
		BOTLIB_AI_FREE_MOVE_STATE,
		BOTLIB_AI_INIT_MOVE_STATE,

		BOTLIB_AI_CHOOSE_BEST_FIGHT_WEAPON,
		BOTLIB_AI_GET_WEAPON_INFO,
		BOTLIB_AI_LOAD_WEAPON_WEIGHTS,
		BOTLIB_AI_ALLOC_WEAPON_STATE,
		BOTLIB_AI_FREE_WEAPON_STATE,
		BOTLIB_AI_RESET_WEAPON_STATE,

		BOTLIB_AI_GENETIC_PARENTS_AND_CHILD_SELECTION,
		BOTLIB_AI_INTERBREED_GOAL_FUZZY_LOGIC,
		BOTLIB_AI_MUTATE_GOAL_FUZZY_LOGIC,
		BOTLIB_AI_GET_NEXT_CAMP_SPOT_GOAL,
		BOTLIB_AI_GET_MAP_LOCATION_GOAL,
		BOTLIB_AI_NUM_INITIAL_CHATS,
		BOTLIB_AI_GET_CHAT_MESSAGE,
		BOTLIB_AI_REMOVE_FROM_AVOID_GOALS,
		BOTLIB_AI_PREDICT_VISIBLE_POSITION,

		BOTLIB_AI_SET_AVOID_GOAL_TIME,
		BOTLIB_AI_ADD_AVOID_SPOT,
		BOTLIB_AAS_ALTERNATIVE_ROUTE_GOAL,
		BOTLIB_AAS_PREDICT_ROUTE,
		BOTLIB_AAS_POINT_REACHABILITY_AREA_INDEX,

		BOTLIB_PC_LOAD_SOURCE,
		BOTLIB_PC_FREE_SOURCE,
		BOTLIB_PC_READ_TOKEN,
		BOTLIB_PC_SOURCE_FILE_AND_LINE
#elif CGAME
		PRINT,
		ERROR,
		CG_MILLISECONDS,
		CG_CVAR_REGISTER,
		CG_CVAR_UPDATE,
		CG_CVAR_SET,
		CG_CVAR_VARIABLESTRINGBUFFER,
		CG_ARGC,
		CG_ARGV,
		CG_ARGS,
		CG_FS_FOPENFILE,
		CG_FS_READ,
		CG_FS_WRITE,
		CG_FS_FCLOSEFILE,
		CG_SENDCONSOLECOMMAND,
		CG_ADDCOMMAND,
		CG_SENDCLIENTCOMMAND,
		CG_UPDATESCREEN,
		CG_CM_LOADMAP,
		CG_CM_NUMINLINEMODELS,
		CG_CM_INLINEMODEL,
		CG_CM_LOADMODEL,
		CG_CM_TEMPBOXMODEL,
		CG_CM_POINTCONTENTS,
		CG_CM_TRANSFORMEDPOINTCONTENTS,
		CG_CM_BOXTRACE,
		CG_CM_TRANSFORMEDBOXTRACE,
		CG_CM_MARKFRAGMENTS,
		CG_S_STARTSOUND,
		CG_S_STARTLOCALSOUND,
		CG_S_CLEARLOOPINGSOUNDS,
		CG_S_ADDLOOPINGSOUND,
		CG_S_UPDATEENTITYPOSITION,
		CG_S_RESPATIALIZE,
		CG_S_REGISTERSOUND,
		CG_S_STARTBACKGROUNDTRACK,
		CG_R_LOADWORLDMAP,
		CG_R_REGISTERMODEL,
		CG_R_REGISTERSKIN,
		CG_R_REGISTERSHADER,
		CG_R_CLEARSCENE,
		CG_R_ADDREFENTITYTOSCENE,
		CG_R_ADDPOLYTOSCENE,
		CG_R_ADDLIGHTTOSCENE,
		CG_R_RENDERSCENE,
		CG_R_SETCOLOR,
		CG_R_DRAWSTRETCHPIC,
		CG_R_MODELBOUNDS,
		CG_R_LERPTAG,
		CG_GETGLCONFIG,
		CG_GETGAMESTATE,
		CG_GETCURRENTSNAPSHOTNUMBER,
		CG_GETSNAPSHOT,
		CG_GETSERVERCOMMAND,
		CG_GETCURRENTCMDNUMBER,
		CG_GETUSERCMD,
		CG_SETUSERCMDVALUE,
		CG_R_REGISTERSHADERNOMIP,
		CG_MEMORY_REMAINING,
		CG_R_REGISTERFONT,
		CG_KEY_ISDOWN,
		CG_KEY_GETCATCHER,
		CG_KEY_SETCATCHER,
		CG_KEY_GETKEY,
		CG_PC_ADD_GLOBAL_DEFINE,
		CG_PC_LOAD_SOURCE,
		CG_PC_FREE_SOURCE,
		CG_PC_READ_TOKEN,
		CG_PC_SOURCE_FILE_AND_LINE,
		CG_S_STOPBACKGROUNDTRACK,
		CG_REAL_TIME,
		CG_SNAPVECTOR,
		CG_REMOVECOMMAND,
		CG_R_LIGHTFORPOINT,
		CG_CIN_PLAYCINEMATIC,
		CG_CIN_STOPCINEMATIC,
		CG_CIN_RUNCINEMATIC,
		CG_CIN_DRAWCINEMATIC,
		CG_CIN_SETEXTENTS,
		CG_R_REMAP_SHADER,
		CG_S_ADDREALLOOPINGSOUND,
		CG_S_STOPLOOPINGSOUND,

		CG_CM_TEMPCAPSULEMODEL,
		CG_CM_CAPSULETRACE,
		CG_CM_TRANSFORMEDCAPSULETRACE,
		CG_R_ADDADDITIVELIGHTTOSCENE,
		CG_GET_ENTITY_TOKEN,
		CG_R_ADDPOLYSTOSCENE,
		CG_R_INPVS,
		// 1.32
		CG_FS_SEEK,

		/*
			CG_LOADCAMERA,
			CG_STARTCAMERA,
			CG_GETCAMERAINFO,
		*/

		CG_MEMSET = 100,
		CG_MEMCPY,
		CG_STRNCPY,
		CG_SIN,
		CG_COS,
		CG_ATAN2,
		CG_SQRT,
		CG_FLOOR,
		CG_CEIL,
		CG_TESTPRINTINT,
		CG_TESTPRINTFLOAT,
		CG_ACOS
#elif UI
		ERROR,
		PRINT,
		UI_MILLISECONDS,
		UI_CVAR_SET,
		UI_CVAR_VARIABLEVALUE,
		UI_CVAR_VARIABLESTRINGBUFFER,
		UI_CVAR_SETVALUE,
		UI_CVAR_RESET,
		UI_CVAR_CREATE,
		UI_CVAR_INFOSTRINGBUFFER,
		UI_ARGC,
		UI_ARGV,
		UI_CMD_EXECUTETEXT,
		UI_FS_FOPENFILE,
		UI_FS_READ,
		UI_FS_WRITE,
		UI_FS_FCLOSEFILE,
		UI_FS_GETFILELIST,
		UI_R_REGISTERMODEL,
		UI_R_REGISTERSKIN,
		UI_R_REGISTERSHADERNOMIP,
		UI_R_CLEARSCENE,
		UI_R_ADDREFENTITYTOSCENE,
		UI_R_ADDPOLYTOSCENE,
		UI_R_ADDLIGHTTOSCENE,
		UI_R_RENDERSCENE,
		UI_R_SETCOLOR,
		UI_R_DRAWSTRETCHPIC,
		UI_UPDATESCREEN,
		UI_CM_LERPTAG,
		UI_CM_LOADMODEL,
		UI_S_REGISTERSOUND,
		UI_S_STARTLOCALSOUND,
		UI_KEY_KEYNUMTOSTRINGBUF,
		UI_KEY_GETBINDINGBUF,
		UI_KEY_SETBINDING,
		UI_KEY_ISDOWN,
		UI_KEY_GETOVERSTRIKEMODE,
		UI_KEY_SETOVERSTRIKEMODE,
		UI_KEY_CLEARSTATES,
		UI_KEY_GETCATCHER,
		UI_KEY_SETCATCHER,
		UI_GETCLIPBOARDDATA,
		UI_GETGLCONFIG,
		UI_GETCLIENTSTATE,
		UI_GETCONFIGSTRING,
		UI_LAN_GETPINGQUEUECOUNT,
		UI_LAN_CLEARPING,
		UI_LAN_GETPING,
		UI_LAN_GETPINGINFO,
		UI_CVAR_REGISTER,
		UI_CVAR_UPDATE,
		UI_MEMORY_REMAINING,
		UI_GET_CDKEY,
		UI_SET_CDKEY,
		UI_R_REGISTERFONT,
		UI_R_MODELBOUNDS,
		UI_PC_ADD_GLOBAL_DEFINE,
		UI_PC_LOAD_SOURCE,
		UI_PC_FREE_SOURCE,
		UI_PC_READ_TOKEN,
		UI_PC_SOURCE_FILE_AND_LINE,
		UI_S_STOPBACKGROUNDTRACK,
		UI_S_STARTBACKGROUNDTRACK,
		UI_REAL_TIME,
		UI_LAN_GETSERVERCOUNT,
		UI_LAN_GETSERVERADDRESSSTRING,
		UI_LAN_GETSERVERINFO,
		UI_LAN_MARKSERVERVISIBLE,
		UI_LAN_UPDATEVISIBLEPINGS,
		UI_LAN_RESETPINGS,
		UI_LAN_LOADCACHEDSERVERS,
		UI_LAN_SAVECACHEDSERVERS,
		UI_LAN_ADDSERVER,
		UI_LAN_REMOVESERVER,
		UI_CIN_PLAYCINEMATIC,
		UI_CIN_STOPCINEMATIC,
		UI_CIN_RUNCINEMATIC,
		UI_CIN_DRAWCINEMATIC,
		UI_CIN_SETEXTENTS,
		UI_R_REMAP_SHADER,
		UI_VERIFY_CDKEY,
		UI_LAN_SERVERSTATUS,
		UI_LAN_GETSERVERPING,
		UI_LAN_SERVERISVISIBLE,
		UI_LAN_COMPARESERVERS,
		// 1.32
		UI_FS_SEEK,
		UI_SET_PBCLSTATUS,

		UI_MEMSET = 100,
		UI_MEMCPY,
		UI_STRNCPY,
		UI_SIN,
		UI_COS,
		UI_ATAN2,
		UI_SQRT,
		UI_FLOOR,
		UI_CEIL
#endif
	}
}