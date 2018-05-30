namespace ReadingFromIni
{
	public class ScyllaHideSettingsSection
	{
		public string SectionName;

		#region  vars
		public bool DLLNormal;
		public bool DLLStealth;
		public bool DLLUnload;
		public bool BlockInputHook;
		public bool GetLocalTimeHook;
		public bool GetSystemTimeHook;
		public bool GetTickCount64Hook;
		public bool GetTickCountHook;
		public bool KiUserExceptionDispatcherHook;
		public bool NtCloseHook;
		public bool NtContinueHook;
		public bool NtCreateThreadExHook;
		public bool NtGetContextThreadHook;
		public bool NtQueryInformationProcessHook;
		public bool NtQueryObjectHook;
		public bool NtQueryPerformanceCounterHook;
		public bool NtQuerySystemInformationHook;
		public bool NtQuerySystemTimeHook;
		public bool NtSetContextThreadHook;
		public bool NtSetDebugFilterStateHook;
		public bool NtSetInformationThreadHook;
		public bool NtSetInformationProcessHook;
		public bool NtUserBuildHwndListHook;
		public bool NtUserFindWindowExHook;
		public bool NtUserQueryWindowHook;
		public bool NtYieldExecutionHook;
		public bool OutputDebugStringHook;
		public bool PebBeingDebugged;
		public bool PebHeapFlags;
		public bool PebNtGlobalFlag;
		public bool PebStartupInfo;
		public bool PreventThreadCreation;
		public bool ProtectProcessId;
		public bool RemoveDebugPrivileges;
		public bool KillAntiAttach;
		public bool MalwareRunPeUnpacker;

		public bool handleExceptionPrint;
		public bool handleExceptionRip;
		public bool handleExceptionIllegalInstruction;
		public bool handleExceptionInvalidLockSequence;
		public bool handleExceptionNoncontinuableException;
		public bool handleExceptionAssertionFailure;
		public bool handleExceptionBreakpoint;
		public bool handleExceptionGuardPageViolation;
		public bool handleExceptionWx86Breakpoint;
		public bool AutostartServer;
		public bool BreakOnTLS;
		public bool FixOllyBugs;
		public bool RemoveEPBreak;
		public bool SkipEPOutsideCode;
		public bool X64Fix;
		public bool advancedGoto;
		public bool ignoreBadPEImage;
		public bool skipCompressedDoAnalyze;
		public bool skipCompressedDoNothing;
		public bool skipLoadDllDoLoad;
		public bool skipLoadDllDoNothing;
		public bool advancedInfobar;

		public string WindowTitle;
		public string ServerPort;
		#endregion


		public ScyllaHideSettingsSection(string sectionName)
		{
			SectionName = sectionName;
			DLLNormal = true;
			WindowTitle = "Sccylla Hide";
			ServerPort = "1337";
		}

		public void SaveSectionSettings(IniFile file)
		{
			file.Write("DLLNormal", BoolToStr(DLLNormal), SectionName);
			file.Write("DLLStealth", BoolToStr(DLLStealth), SectionName);
			file.Write("DLLUnload", BoolToStr(DLLUnload), SectionName);
			file.Write("BlockInputHook", BoolToStr(BlockInputHook), SectionName);
			file.Write("GetLocalTimeHook", BoolToStr(GetLocalTimeHook), SectionName);
			file.Write("GetSystemTimeHook", BoolToStr(GetSystemTimeHook), SectionName);
			file.Write("GetTickCount64Hook", BoolToStr(GetTickCount64Hook), SectionName);
			file.Write("GetTickCountHook", BoolToStr(GetTickCountHook), SectionName);
			file.Write("KiUserExceptionDispatcherHook", BoolToStr(KiUserExceptionDispatcherHook), SectionName);
			file.Write("NtCloseHook", BoolToStr(NtCloseHook), SectionName);
			file.Write("NtContinueHook", BoolToStr(NtContinueHook), SectionName);
			file.Write("NtCreateThreadExHook", BoolToStr(NtCreateThreadExHook), SectionName);
			file.Write("NtGetContextThreadHook", BoolToStr(NtGetContextThreadHook), SectionName);
			file.Write("NtQueryInformationProcessHook", BoolToStr(NtQueryInformationProcessHook), SectionName);
			file.Write("NtQueryObjectHook", BoolToStr(NtQueryObjectHook), SectionName);
			file.Write("NtQueryPerformanceCounterHook", BoolToStr(NtQueryPerformanceCounterHook), SectionName);
			file.Write("NtQuerySystemInformationHook", BoolToStr(NtQuerySystemInformationHook), SectionName);
			file.Write("NtQuerySystemTimeHook", BoolToStr(NtQuerySystemTimeHook), SectionName);
			file.Write("NtSetContextThreadHook", BoolToStr(NtSetContextThreadHook), SectionName);
			file.Write("NtSetDebugFilterStateHook", BoolToStr(NtSetDebugFilterStateHook), SectionName);
			file.Write("NtSetInformationThreadHook", BoolToStr(NtSetInformationThreadHook), SectionName);
			file.Write("NtSetInformationProcessHook", BoolToStr(NtSetInformationProcessHook), SectionName);
			file.Write("NtUserBuildHwndListHook", BoolToStr(NtUserBuildHwndListHook), SectionName);
			file.Write("NtUserFindWindowExHook", BoolToStr(NtUserFindWindowExHook), SectionName);
			file.Write("NtUserQueryWindowHook", BoolToStr(NtUserQueryWindowHook), SectionName);
			file.Write("NtYieldExecutionHook", BoolToStr(NtYieldExecutionHook), SectionName);
			file.Write("OutputDebugStringHook", BoolToStr(OutputDebugStringHook), SectionName);
			file.Write("PebBeingDebugged", BoolToStr(PebBeingDebugged), SectionName);
			file.Write("PebHeapFlags", BoolToStr(PebHeapFlags), SectionName);
			file.Write("PebNtGlobalFlag", BoolToStr(PebNtGlobalFlag), SectionName);
			file.Write("PebStartupInfo", BoolToStr(PebStartupInfo), SectionName);
			file.Write("PreventThreadCreation", BoolToStr(PreventThreadCreation), SectionName);
			file.Write("ProtectProcessId", BoolToStr(ProtectProcessId), SectionName);
			file.Write("RemoveDebugPrivileges", BoolToStr(RemoveDebugPrivileges), SectionName);
			file.Write("KillAntiAttach", BoolToStr(KillAntiAttach), SectionName);
			file.Write("MalwareRunPeUnpacker", BoolToStr(MalwareRunPeUnpacker), SectionName);
			file.Write("handleExceptionPrint", BoolToStr(handleExceptionPrint), SectionName);
			file.Write("handleExceptionRip", BoolToStr(handleExceptionRip), SectionName);
			file.Write("handleExceptionIllegalInstruction", BoolToStr(handleExceptionIllegalInstruction), SectionName);
			file.Write("handleExceptionInvalidLockSequence", BoolToStr(handleExceptionInvalidLockSequence), SectionName);
			file.Write("handleExceptionNoncontinuableException", BoolToStr(handleExceptionNoncontinuableException), SectionName);
			file.Write("handleExceptionAssertionFailure", BoolToStr(handleExceptionAssertionFailure), SectionName);
			file.Write("handleExceptionBreakpoint", BoolToStr(handleExceptionBreakpoint), SectionName);
			file.Write("handleExceptionGuardPageViolation", BoolToStr(handleExceptionGuardPageViolation), SectionName);
			file.Write("handleExceptionWx86Breakpoint", BoolToStr(handleExceptionWx86Breakpoint), SectionName);
			file.Write("AutostartServer", BoolToStr(AutostartServer), SectionName);
			file.Write("BreakOnTLS", BoolToStr(BreakOnTLS), SectionName);
			file.Write("FixOllyBugs", BoolToStr(FixOllyBugs), SectionName);
			file.Write("RemoveEPBreak", BoolToStr(RemoveEPBreak), SectionName);
			file.Write("SkipEPOutsideCode", BoolToStr(SkipEPOutsideCode), SectionName);
			file.Write("X64Fix", BoolToStr(X64Fix), SectionName);
			file.Write("advancedGoto", BoolToStr(advancedGoto), SectionName);
			file.Write("ignoreBadPEImage", BoolToStr(ignoreBadPEImage), SectionName);
			file.Write("skipCompressedDoAnalyze", BoolToStr(skipCompressedDoAnalyze), SectionName);
			file.Write("skipCompressedDoNothing", BoolToStr(skipCompressedDoNothing), SectionName);
			file.Write("skipLoadDllDoLoad", BoolToStr(skipLoadDllDoLoad), SectionName);
			file.Write("skipLoadDllDoNothing", BoolToStr(skipLoadDllDoNothing), SectionName);
			file.Write("advancedInfobar", BoolToStr(advancedInfobar), SectionName);

			file.Write("WindowTitle", WindowTitle, SectionName);
			file.Write("ServerPort", ServerPort, SectionName);
		}

		private string BoolToStr(bool param)
		{
			if (param)
				return "1";
			return "0";

		}
		public void ReadSectionSettings(IniFile file)
		{
			DLLNormal = file.Read("DLLNormal", SectionName) == "1";
			DLLStealth = file.Read("DLLStealth", SectionName) == "1";
			DLLUnload = file.Read("DLLUnload", SectionName) == "1";
			BlockInputHook = file.Read("BlockInputHook", SectionName) == "1";
			GetLocalTimeHook = file.Read("GetLocalTimeHook", SectionName) == "1";
			GetSystemTimeHook = file.Read("GetSystemTimeHook", SectionName) == "1";
			GetTickCount64Hook = file.Read("GetTickCount64Hook", SectionName) == "1";
			GetTickCountHook = file.Read("GetTickCountHook", SectionName) == "1";
			KiUserExceptionDispatcherHook = file.Read("KiUserExceptionDispatcherHook", SectionName) == "1";
			NtCloseHook = file.Read("NtCloseHook", SectionName) == "1";
			NtContinueHook = file.Read("NtContinueHook", SectionName) == "1";
			NtCreateThreadExHook = file.Read("NtCreateThreadExHook", SectionName) == "1";
			NtGetContextThreadHook = file.Read("NtGetContextThreadHook", SectionName) == "1";
			NtQueryInformationProcessHook = file.Read("NtQueryInformationProcessHook", SectionName) == "1";
			NtQueryObjectHook = file.Read("NtQueryObjectHook", SectionName) == "1";
			NtQueryPerformanceCounterHook = file.Read("NtQueryPerformanceCounterHook", SectionName) == "1";
			NtQuerySystemInformationHook = file.Read("NtQuerySystemInformationHook", SectionName) == "1";
			NtQuerySystemTimeHook = file.Read("NtQuerySystemTimeHook", SectionName) == "1";
			NtSetContextThreadHook = file.Read("NtSetContextThreadHook", SectionName) == "1";
			NtSetDebugFilterStateHook = file.Read("NtSetDebugFilterStateHook", SectionName) == "1";
			NtSetInformationThreadHook = file.Read("NtSetInformationThreadHook", SectionName) == "1";
			NtSetInformationProcessHook = file.Read("NtSetInformationProcessHook", SectionName) == "1";
			NtUserBuildHwndListHook = file.Read("NtUserBuildHwndListHook", SectionName) == "1";
			NtUserFindWindowExHook = file.Read("NtUserFindWindowExHook", SectionName) == "1";
			NtUserQueryWindowHook = file.Read("NtUserQueryWindowHook", SectionName) == "1";
			NtYieldExecutionHook = file.Read("NtYieldExecutionHook", SectionName) == "1";
			OutputDebugStringHook = file.Read("OutputDebugStringHook", SectionName) == "1";
			PebBeingDebugged = file.Read("PebBeingDebugged", SectionName) == "1";
			PebHeapFlags = file.Read("PebHeapFlags", SectionName) == "1";
			PebNtGlobalFlag = file.Read("PebNtGlobalFlag", SectionName) == "1";
			PebStartupInfo = file.Read("PebStartupInfo", SectionName) == "1";
			PreventThreadCreation = file.Read("PreventThreadCreation", SectionName) == "1";
			ProtectProcessId = file.Read("ProtectProcessId", SectionName) == "1";
			RemoveDebugPrivileges = file.Read("RemoveDebugPrivileges", SectionName) == "1";
			KillAntiAttach = file.Read("KillAntiAttach", SectionName) == "1";
			MalwareRunPeUnpacker = file.Read("MalwareRunPeUnpacker", SectionName) == "1";



			//not inclueded problems
			handleExceptionPrint = file.Read("handleExceptionPrint", SectionName) == "1";
			handleExceptionRip = file.Read("handleExceptionRip", SectionName) == "1";
			handleExceptionIllegalInstruction = file.Read("handleExceptionIllegalInstruction", SectionName) == "1";
			handleExceptionInvalidLockSequence = file.Read("handleExceptionInvalidLockSequence", SectionName) == "1";
			handleExceptionNoncontinuableException = file.Read("handleExceptionNoncontinuableException", SectionName) == "1";
			handleExceptionAssertionFailure = file.Read("handleExceptionAssertionFailure", SectionName) == "1";
			handleExceptionBreakpoint = file.Read("handleExceptionBreakpoint", SectionName) == "1";
			handleExceptionGuardPageViolation = file.Read("handleExceptionGuardPageViolation", SectionName) == "1";
			handleExceptionWx86Breakpoint = file.Read("handleExceptionWx86Breakpoint", SectionName) == "1";
			AutostartServer = file.Read("AutostartServer", SectionName) == "1";
			BreakOnTLS = file.Read("BreakOnTLS", SectionName) == "1";
			FixOllyBugs = file.Read("FixOllyBugs", SectionName) == "1";
			RemoveEPBreak = file.Read("RemoveEPBreak", SectionName) == "1";
			SkipEPOutsideCode = file.Read("SkipEPOutsideCode", SectionName) == "1";
			X64Fix = file.Read("X64Fix", SectionName) == "1";
			advancedGoto = file.Read("advancedGoto", SectionName) == "1";
			ignoreBadPEImage = file.Read("ignoreBadPEImage", SectionName) == "1";
			skipCompressedDoAnalyze = file.Read("skipCompressedDoAnalyze", SectionName) == "1";
			skipCompressedDoNothing = file.Read("skipCompressedDoNothing", SectionName) == "1";
			skipLoadDllDoLoad = file.Read("skipLoadDllDoLoad", SectionName) == "1";
			skipLoadDllDoNothing = file.Read("skipLoadDllDoNothing", SectionName) == "1";
			advancedInfobar = file.Read("advancedInfobar", SectionName) == "1";


			string title = file.Read("WindowTitle", SectionName);
			WindowTitle =string.IsNullOrEmpty(title)?"ScyllaHide":title;

			string serverPort = file.Read("ServerPort", SectionName);
			ServerPort = string.IsNullOrEmpty(serverPort)?"1337":serverPort;
		}


	}
}