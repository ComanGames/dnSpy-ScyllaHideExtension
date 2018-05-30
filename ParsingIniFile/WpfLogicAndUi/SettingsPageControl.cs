using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using ReadingFromIni;

namespace WpfLogicAndUi
{
	public class SettingsPageControl :INotifyPropertyChanged
	{
		public SettingsPageControl()
		{
			settings = new ScyllaHideSettings();
		}

		private ScyllaHideSettings settings;
		#region GeneratedParams

		public bool BlockInputHook
		{
			get { return settings.CurrentSelectedSection.BlockInputHook; }
			set
			{
				if (settings.CurrentSelectedSection.BlockInputHook != value)
				{
					settings.CurrentSelectedSection.BlockInputHook = value;
					OnPropertyChanged(nameof(BlockInputHook));
					OnModefied();
				}
			}
		}

		public bool DllInectionTypeIsNormal
		{
			get { return settings.CurrentSelectedSection.DLLNormal; }
			set
			{
				if (value)
				{
					settings.CurrentSelectedSection.DLLNormal = true;
					settings.CurrentSelectedSection.DLLStealth = false;
				}
				else
				{
					settings.CurrentSelectedSection.DLLNormal = false;
					settings.CurrentSelectedSection.DLLStealth = true;
				}

				OnModefied();
				OnPropertyChanged(nameof(DllInectionTypeIsNormal));
			}
		}



		public bool DLLUnload
		{
			get { return settings.CurrentSelectedSection.DLLUnload; }
			set
			{
				if (settings.CurrentSelectedSection.DLLUnload != value)
				{
					settings.CurrentSelectedSection.DLLUnload = value;
					OnPropertyChanged(nameof(DLLUnload));
					OnModefied();
				}
			}
		}

		public bool GetLocalTimeHook
		{
			get { return settings.CurrentSelectedSection.GetLocalTimeHook; }
			set
			{
				if (settings.CurrentSelectedSection.GetLocalTimeHook != value)
				{
					settings.CurrentSelectedSection.GetLocalTimeHook = value;
					OnPropertyChanged(nameof(GetLocalTimeHook));
					OnModefied();
				}
			}
		}

		public bool GetSystemTimeHook
		{
			get { return settings.CurrentSelectedSection.GetSystemTimeHook; }
			set
			{
				if (settings.CurrentSelectedSection.GetSystemTimeHook != value)
				{
					settings.CurrentSelectedSection.GetSystemTimeHook = value;
					OnPropertyChanged(nameof(GetSystemTimeHook));
					OnModefied();
				}
			}
		}

		public bool GetTickCount64Hook
		{
			get { return settings.CurrentSelectedSection.GetTickCount64Hook; }
			set
			{
				if (settings.CurrentSelectedSection.GetTickCount64Hook != value)
				{
					settings.CurrentSelectedSection.GetTickCount64Hook = value;
					OnPropertyChanged(nameof(GetTickCount64Hook));
					OnModefied();
				}
			}
		}

		public bool GetTickCountHook
		{
			get { return settings.CurrentSelectedSection.GetTickCountHook; }
			set
			{
				if (settings.CurrentSelectedSection.GetTickCountHook != value)
				{
					settings.CurrentSelectedSection.GetTickCountHook = value;
					OnPropertyChanged(nameof(GetTickCountHook));
					OnModefied();
				}
			}
		}

		public bool KiUserExceptionDispatcherHook
		{
			get { return settings.CurrentSelectedSection.KiUserExceptionDispatcherHook; }
			set
			{
				if (settings.CurrentSelectedSection.KiUserExceptionDispatcherHook != value)
				{
					settings.CurrentSelectedSection.KiUserExceptionDispatcherHook = value;
					OnPropertyChanged(nameof(KiUserExceptionDispatcherHook));
					OnModefied();
				}
			}
		}

		public bool NtCloseHook
		{
			get { return settings.CurrentSelectedSection.NtCloseHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtCloseHook != value)
				{
					settings.CurrentSelectedSection.NtCloseHook = value;
					OnPropertyChanged(nameof(NtCloseHook));
					OnModefied();
				}
			}
		}

		public bool NtContinueHook
		{
			get { return settings.CurrentSelectedSection.NtContinueHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtContinueHook != value)
				{
					settings.CurrentSelectedSection.NtContinueHook = value;
					OnPropertyChanged(nameof(NtContinueHook));
					OnModefied();
				}
			}
		}

		public bool NtCreateThreadExHook
		{
			get { return settings.CurrentSelectedSection.NtCreateThreadExHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtCreateThreadExHook != value)
				{
					settings.CurrentSelectedSection.NtCreateThreadExHook = value;
					OnPropertyChanged(nameof(NtCreateThreadExHook));
					OnModefied();
				}
			}
		}

		public bool NtGetContextThreadHook
		{
			get { return settings.CurrentSelectedSection.NtGetContextThreadHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtGetContextThreadHook != value)
				{
					settings.CurrentSelectedSection.NtGetContextThreadHook = value;
					OnPropertyChanged(nameof(NtGetContextThreadHook));
					OnModefied();
				}
			}
		}

		public bool NtQueryInformationProcessHook
		{
			get { return settings.CurrentSelectedSection.NtQueryInformationProcessHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtQueryInformationProcessHook != value)
				{
					settings.CurrentSelectedSection.NtQueryInformationProcessHook = value;
					OnPropertyChanged(nameof(NtQueryInformationProcessHook));
					OnModefied();
				}
			}
		}

		public bool NtQueryObjectHook
		{
			get { return settings.CurrentSelectedSection.NtQueryObjectHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtQueryObjectHook != value)
				{
					settings.CurrentSelectedSection.NtQueryObjectHook = value;
					OnPropertyChanged(nameof(NtQueryObjectHook));
					OnModefied();
				}
			}
		}

		public bool NtQueryPerformanceCounterHook
		{
			get { return settings.CurrentSelectedSection.NtQueryPerformanceCounterHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtQueryPerformanceCounterHook != value)
				{
					settings.CurrentSelectedSection.NtQueryPerformanceCounterHook = value;
					OnPropertyChanged(nameof(NtQueryPerformanceCounterHook));
					OnModefied();
				}
			}
		}

		public bool NtQuerySystemInformationHook
		{
			get { return settings.CurrentSelectedSection.NtQuerySystemInformationHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtQuerySystemInformationHook != value)
				{
					settings.CurrentSelectedSection.NtQuerySystemInformationHook = value;
					OnPropertyChanged(nameof(NtQuerySystemInformationHook));
					OnModefied();
				}
			}
		}

		public bool NtQuerySystemTimeHook
		{
			get { return settings.CurrentSelectedSection.NtQuerySystemTimeHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtQuerySystemTimeHook != value)
				{
					settings.CurrentSelectedSection.NtQuerySystemTimeHook = value;
					OnPropertyChanged(nameof(NtQuerySystemTimeHook));
					OnModefied();
				}
			}
		}

		public bool NtSetContextThreadHook
		{
			get { return settings.CurrentSelectedSection.NtSetContextThreadHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtSetContextThreadHook != value)
				{
					settings.CurrentSelectedSection.NtSetContextThreadHook = value;
					OnPropertyChanged(nameof(NtSetContextThreadHook));
					OnModefied();
				}
			}
		}

		public bool NtSetDebugFilterStateHook
		{
			get { return settings.CurrentSelectedSection.NtSetDebugFilterStateHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtSetDebugFilterStateHook != value)
				{
					settings.CurrentSelectedSection.NtSetDebugFilterStateHook = value;
					OnPropertyChanged(nameof(NtSetDebugFilterStateHook));
					OnModefied();
				}
			}
		}

		public bool NtSetInformationThreadHook
		{
			get { return settings.CurrentSelectedSection.NtSetInformationThreadHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtSetInformationThreadHook != value)
				{
					settings.CurrentSelectedSection.NtSetInformationThreadHook = value;
					OnPropertyChanged(nameof(NtSetInformationThreadHook));
					OnModefied();
				}
			}
		}

		public bool NtUserBuildHwndListHook
		{
			get { return settings.CurrentSelectedSection.NtUserBuildHwndListHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtUserBuildHwndListHook != value)
				{
					settings.CurrentSelectedSection.NtUserBuildHwndListHook = value;
					OnPropertyChanged(nameof(NtUserBuildHwndListHook));
					OnModefied();
				}
			}
		}

		public bool NtUserFindWindowExHook
		{
			get { return settings.CurrentSelectedSection.NtUserFindWindowExHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtUserFindWindowExHook != value)
				{
					settings.CurrentSelectedSection.NtUserFindWindowExHook = value;
					OnPropertyChanged(nameof(NtUserFindWindowExHook));
					OnModefied();
				}
			}
		}

		public bool NtUserQueryWindowHook
		{
			get { return settings.CurrentSelectedSection.NtUserQueryWindowHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtUserQueryWindowHook != value)
				{
					settings.CurrentSelectedSection.NtUserQueryWindowHook = value;
					OnPropertyChanged(nameof(NtUserQueryWindowHook));
					OnModefied();
				}
			}
		}

		public bool NtYieldExecutionHook
		{
			get { return settings.CurrentSelectedSection.NtYieldExecutionHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtYieldExecutionHook != value)
				{
					settings.CurrentSelectedSection.NtYieldExecutionHook = value;
					OnPropertyChanged(nameof(NtYieldExecutionHook));
					OnModefied();
				}
			}
		}

		public bool OutputDebugStringHook
		{
			get { return settings.CurrentSelectedSection.OutputDebugStringHook; }
			set
			{
				if (settings.CurrentSelectedSection.OutputDebugStringHook != value)
				{
					settings.CurrentSelectedSection.OutputDebugStringHook = value;
					OnPropertyChanged(nameof(OutputDebugStringHook));
					OnModefied();
				}
			}
		}

		public bool PebBeingDebugged
		{
			get { return settings.CurrentSelectedSection.PebBeingDebugged; }
			set
			{
				if (settings.CurrentSelectedSection.PebBeingDebugged != value)
				{
					settings.CurrentSelectedSection.PebBeingDebugged = value;
					OnPropertyChanged(nameof(PebBeingDebugged));
					OnModefied();
					OnPropertyChanged(nameof(HideFromPeb));
				}
			}
		}

		public bool PebHeapFlags
		{
			get { return settings.CurrentSelectedSection.PebHeapFlags; }
			set
			{
				if (settings.CurrentSelectedSection.PebHeapFlags != value)
				{
					settings.CurrentSelectedSection.PebHeapFlags = value;
					OnPropertyChanged(nameof(PebHeapFlags));
					OnModefied();
					OnPropertyChanged(nameof(HideFromPeb));
				}
			}
		}

		public bool PebNtGlobalFlag
		{
			get { return settings.CurrentSelectedSection.PebNtGlobalFlag; }
			set
			{
				if (settings.CurrentSelectedSection.PebNtGlobalFlag != value)
				{
					settings.CurrentSelectedSection.PebNtGlobalFlag = value;
					OnPropertyChanged(nameof(PebNtGlobalFlag));
					OnModefied();
					OnPropertyChanged(nameof(HideFromPeb));
				}
			}
		}

		public bool PebStartupInfo
		{
			get { return settings.CurrentSelectedSection.PebStartupInfo; }
			set
			{
				if (settings.CurrentSelectedSection.PebStartupInfo != value)
				{
					settings.CurrentSelectedSection.PebStartupInfo = value;
					OnPropertyChanged(nameof(PebStartupInfo));
					OnModefied();
					OnPropertyChanged(nameof(HideFromPeb));
				}
			}
		}

		public bool PreventThreadCreation
		{
			get { return settings.CurrentSelectedSection.PreventThreadCreation; }
			set
			{
				if (settings.CurrentSelectedSection.PreventThreadCreation != value)
				{
					settings.CurrentSelectedSection.PreventThreadCreation = value;
					OnPropertyChanged(nameof(PreventThreadCreation));
					OnModefied();
				}
			}
		}

		public bool RemoveDebugPrivileges
		{
			get { return settings.CurrentSelectedSection.RemoveDebugPrivileges; }
			set
			{
				if (settings.CurrentSelectedSection.RemoveDebugPrivileges != value)
				{
					settings.CurrentSelectedSection.RemoveDebugPrivileges = value;
					OnPropertyChanged(nameof(RemoveDebugPrivileges));
					OnModefied();
				}
			}
		}



		public bool NtSetInformationProcessHook
		{
			get { return settings.CurrentSelectedSection.NtSetInformationProcessHook; }
			set
			{
				if (settings.CurrentSelectedSection.NtSetInformationProcessHook != value)
				{
					settings.CurrentSelectedSection.NtSetInformationProcessHook = value;
					OnPropertyChanged(nameof(NtSetInformationProcessHook));
					OnModefied();
				}
			}
		}

		public bool KillAntiAttach
		{
			get { return settings.CurrentSelectedSection.KillAntiAttach; }
			set
			{
				if (settings.CurrentSelectedSection.KillAntiAttach != value)
				{
					settings.CurrentSelectedSection.KillAntiAttach = value;
					OnPropertyChanged(nameof(KillAntiAttach));
					OnModefied();
				}
			}
		}

		public bool RunPeUnpacker 
		{
			get { return settings.CurrentSelectedSection.MalwareRunPeUnpacker; }
			set
			{
				if (settings.CurrentSelectedSection.MalwareRunPeUnpacker != value)
				{
					settings.CurrentSelectedSection.MalwareRunPeUnpacker = value;
					OnPropertyChanged(nameof(RunPeUnpacker));
					OnModefied();
				}
			}
		}


		#endregion

		#region GeneratePrivParams

		public bool handleExceptionPrint
		{
			get { return settings.CurrentSelectedSection.handleExceptionPrint; }
			set
			{
				if (settings.CurrentSelectedSection.handleExceptionPrint != value)
				{
					settings.CurrentSelectedSection.handleExceptionPrint = value;
					OnPropertyChanged(nameof(handleExceptionPrint));
					OnModefied();
				}
			}
		}

		public bool handleExceptionRip
		{
			get { return settings.CurrentSelectedSection.handleExceptionRip; }
			set
			{
				if (settings.CurrentSelectedSection.handleExceptionRip != value)
				{
					settings.CurrentSelectedSection.handleExceptionRip = value;
					OnPropertyChanged(nameof(handleExceptionRip));
					OnModefied();
				}
			}
		}

		public bool handleExceptionIllegalInstruction
		{
			get { return settings.CurrentSelectedSection.handleExceptionIllegalInstruction; }
			set
			{
				if (settings.CurrentSelectedSection.handleExceptionIllegalInstruction != value)
				{
					settings.CurrentSelectedSection.handleExceptionIllegalInstruction = value;
					OnPropertyChanged(nameof(handleExceptionIllegalInstruction));
					OnModefied();
				}
			}
		}

		public bool handleExceptionInvalidLockSequence
		{
			get { return settings.CurrentSelectedSection.handleExceptionInvalidLockSequence; }
			set
			{
				if (settings.CurrentSelectedSection.handleExceptionInvalidLockSequence != value)
				{
					settings.CurrentSelectedSection.handleExceptionInvalidLockSequence = value;
					OnPropertyChanged(nameof(handleExceptionInvalidLockSequence));
					OnModefied();
				}
			}
		}

		public bool handleExceptionNoncontinuableException
		{
			get { return settings.CurrentSelectedSection.handleExceptionNoncontinuableException; }
			set
			{
				if (settings.CurrentSelectedSection.handleExceptionNoncontinuableException != value)
				{
					settings.CurrentSelectedSection.handleExceptionNoncontinuableException = value;
					OnPropertyChanged(nameof(handleExceptionNoncontinuableException));
					OnModefied();
				}
			}
		}

		public bool handleExceptionAssertionFailure
		{
			get { return settings.CurrentSelectedSection.handleExceptionAssertionFailure; }
			set
			{
				if (settings.CurrentSelectedSection.handleExceptionAssertionFailure != value)
				{
					settings.CurrentSelectedSection.handleExceptionAssertionFailure = value;
					OnPropertyChanged(nameof(handleExceptionAssertionFailure));
					OnModefied();
				}
			}
		}

		public bool handleExceptionBreakpoint
		{
			get { return settings.CurrentSelectedSection.handleExceptionBreakpoint; }
			set
			{
				if (settings.CurrentSelectedSection.handleExceptionBreakpoint != value)
				{
					settings.CurrentSelectedSection.handleExceptionBreakpoint = value;
					OnPropertyChanged(nameof(handleExceptionBreakpoint));
					OnModefied();
				}
			}
		}

		public bool handleExceptionGuardPageViolation
		{
			get { return settings.CurrentSelectedSection.handleExceptionGuardPageViolation; }
			set
			{
				if (settings.CurrentSelectedSection.handleExceptionGuardPageViolation != value)
				{
					settings.CurrentSelectedSection.handleExceptionGuardPageViolation = value;
					OnPropertyChanged(nameof(handleExceptionGuardPageViolation));
					OnModefied();
				}
			}
		}

		public bool handleExceptionWx86Breakpoint
		{
			get { return settings.CurrentSelectedSection.handleExceptionWx86Breakpoint; }
			set
			{
				if (settings.CurrentSelectedSection.handleExceptionWx86Breakpoint != value)
				{
					settings.CurrentSelectedSection.handleExceptionWx86Breakpoint = value;
					OnPropertyChanged(nameof(handleExceptionWx86Breakpoint));
					OnModefied();
				}
			}
		}

		public bool AutostartServer
		{
			get { return settings.CurrentSelectedSection.AutostartServer; }
			set
			{
				if (settings.CurrentSelectedSection.AutostartServer != value)
				{
					settings.CurrentSelectedSection.AutostartServer = value;
					OnPropertyChanged(nameof(AutostartServer));
					OnModefied();
				}
			}
		}

		public bool BreakOnTLS
		{
			get { return settings.CurrentSelectedSection.BreakOnTLS; }
			set
			{
				if (settings.CurrentSelectedSection.BreakOnTLS != value)
				{
					settings.CurrentSelectedSection.BreakOnTLS = value;
					OnPropertyChanged(nameof(BreakOnTLS));
					OnModefied();
				}
			}
		}

		public bool FixOllyBugs
		{
			get { return settings.CurrentSelectedSection.FixOllyBugs; }
			set
			{
				if (settings.CurrentSelectedSection.FixOllyBugs != value)
				{
					settings.CurrentSelectedSection.FixOllyBugs = value;
					OnPropertyChanged(nameof(FixOllyBugs));
					OnModefied();
				}
			}
		}

		public bool RemoveEPBreak
		{
			get { return settings.CurrentSelectedSection.RemoveEPBreak; }
			set
			{
				if (settings.CurrentSelectedSection.RemoveEPBreak != value)
				{
					settings.CurrentSelectedSection.RemoveEPBreak = value;
					OnPropertyChanged(nameof(RemoveEPBreak));
					OnModefied();
				}
			}
		}

		public bool SkipEPOutsideCode
		{
			get { return settings.CurrentSelectedSection.SkipEPOutsideCode; }
			set
			{
				if (settings.CurrentSelectedSection.SkipEPOutsideCode != value)
				{
					settings.CurrentSelectedSection.SkipEPOutsideCode = value;
					OnPropertyChanged(nameof(SkipEPOutsideCode));
					OnModefied();
				}
			}
		}

		public bool X64Fix
		{
			get { return settings.CurrentSelectedSection.X64Fix; }
			set
			{
				if (settings.CurrentSelectedSection.X64Fix != value)
				{
					settings.CurrentSelectedSection.X64Fix = value;
					OnPropertyChanged(nameof(X64Fix));
					OnModefied();
				}
			}
		}

		public bool advancedGoto
		{
			get { return settings.CurrentSelectedSection.advancedGoto; }
			set
			{
				if (settings.CurrentSelectedSection.advancedGoto != value)
				{
					settings.CurrentSelectedSection.advancedGoto = value;
					OnPropertyChanged(nameof(advancedGoto));
					OnModefied();
				}
			}
		}

		public bool ignoreBadPEImage
		{
			get { return settings.CurrentSelectedSection.ignoreBadPEImage; }
			set
			{
				if (settings.CurrentSelectedSection.ignoreBadPEImage != value)
				{
					settings.CurrentSelectedSection.ignoreBadPEImage = value;
					OnPropertyChanged(nameof(ignoreBadPEImage));
					OnModefied();
				}
			}
		}

		public bool skipCompressedDoAnalyze
		{
			get { return settings.CurrentSelectedSection.skipCompressedDoAnalyze; }
			set
			{
				if (settings.CurrentSelectedSection.skipCompressedDoAnalyze != value)
				{
					settings.CurrentSelectedSection.skipCompressedDoAnalyze = value;
					OnPropertyChanged(nameof(skipCompressedDoAnalyze));
					OnModefied();
				}
			}
		}

		public bool skipCompressedDoNothing
		{
			get { return settings.CurrentSelectedSection.skipCompressedDoNothing; }
			set
			{
				if (settings.CurrentSelectedSection.skipCompressedDoNothing != value)
				{
					settings.CurrentSelectedSection.skipCompressedDoNothing = value;
					OnPropertyChanged(nameof(skipCompressedDoNothing));
					OnModefied();
				}
			}
		}

		public bool skipLoadDllDoLoad
		{
			get { return settings.CurrentSelectedSection.skipLoadDllDoLoad; }
			set
			{
				if (settings.CurrentSelectedSection.skipLoadDllDoLoad != value)
				{
					settings.CurrentSelectedSection.skipLoadDllDoLoad = value;
					OnPropertyChanged(nameof(skipLoadDllDoLoad));
					OnModefied();
				}
			}
		}

		public bool skipLoadDllDoNothing
		{
			get { return settings.CurrentSelectedSection.skipLoadDllDoNothing; }
			set
			{
				if (settings.CurrentSelectedSection.skipLoadDllDoNothing != value)
				{
					settings.CurrentSelectedSection.skipLoadDllDoNothing = value;
					OnPropertyChanged(nameof(skipLoadDllDoNothing));
					OnModefied();
				}
			}
		}

		public bool advancedInfobar
		{
			get { return settings.CurrentSelectedSection.advancedInfobar; }
			set
			{
				if (settings.CurrentSelectedSection.advancedInfobar != value)
				{
					settings.CurrentSelectedSection.advancedInfobar = value;
					OnPropertyChanged(nameof(advancedInfobar));
					OnModefied();
				}
			}
		}

		public string WindowTitle
		{
			get { return settings.CurrentSelectedSection.WindowTitle; }
			set
			{
				if (settings.CurrentSelectedSection.WindowTitle != value)
				{
					settings.CurrentSelectedSection.WindowTitle = value;
					OnPropertyChanged(nameof(WindowTitle));
					OnModefied();
				}
			}
		}

		public string ServerPort
		{
			get { return settings.CurrentSelectedSection.ServerPort; }
			set
			{
				if (settings.CurrentSelectedSection.ServerPort != value)
				{
					settings.CurrentSelectedSection.ServerPort = value;
					OnPropertyChanged(nameof(ServerPort));
					OnModefied();
				}
			}
		}


		#endregion
		public List<string>  Profiles
		{
			get
			{

				List<string> result = new List<string>(settings.Sections.Count);
				for (int i = 0; i < settings.Sections.Count; i++)
				{
					result.Add(settings.Sections[i].SectionName);
					
				}

				return result;
			}
			set
			{
			}
		}

		public bool HideFromPeb
		{
			get { return PebBeingDebugged || PebHeapFlags || PebNtGlobalFlag || PebStartupInfo; }
			set
			{
				PebBeingDebugged = value;
				PebHeapFlags = value;
				PebNtGlobalFlag = value;
				PebStartupInfo = value;

				OnPropertyChanged(nameof(HideFromPeb));
			}
		}
		public int SelectedProfileIndex 
		{
			get
			{
				for (int i = 0; i < settings.Sections.Count; i++)
				{
					if (settings.CurrentSelectedSection == settings.Sections[i])
						return i;

				}
				return -1;

			}
			set
			{
				settings.CurrentSelectedSection = settings.Sections[value];
				OnModefied();
				UpdateAllUi();
			}
		}

		private void UpdateAllUi()
		{
			OnPropertyChanged(nameof(BlockInputHook));
			OnPropertyChanged(nameof(DLLUnload));
			OnPropertyChanged(nameof(DllInectionTypeIsNormal));
			OnPropertyChanged(nameof(GetLocalTimeHook));
			OnPropertyChanged(nameof(GetSystemTimeHook));
			OnPropertyChanged(nameof(GetTickCount64Hook));
			OnPropertyChanged(nameof(GetTickCountHook));
			OnPropertyChanged(nameof(KiUserExceptionDispatcherHook));
			OnPropertyChanged(nameof(NtCloseHook));
			OnPropertyChanged(nameof(NtContinueHook));
			OnPropertyChanged(nameof(NtCreateThreadExHook));
			OnPropertyChanged(nameof(NtGetContextThreadHook));
			OnPropertyChanged(nameof(NtQueryInformationProcessHook));
			OnPropertyChanged(nameof(NtQueryObjectHook));
			OnPropertyChanged(nameof(NtQueryPerformanceCounterHook));
			OnPropertyChanged(nameof(NtQuerySystemInformationHook));
			OnPropertyChanged(nameof(NtQuerySystemTimeHook));
			OnPropertyChanged(nameof(NtSetContextThreadHook));
			OnPropertyChanged(nameof(NtSetDebugFilterStateHook));
			OnPropertyChanged(nameof(NtSetInformationThreadHook));
			OnPropertyChanged(nameof(NtUserBuildHwndListHook));
			OnPropertyChanged(nameof(NtUserFindWindowExHook));
			OnPropertyChanged(nameof(NtUserQueryWindowHook));
			OnPropertyChanged(nameof(NtYieldExecutionHook));
			OnPropertyChanged(nameof(OutputDebugStringHook));
			OnPropertyChanged(nameof(PebBeingDebugged));
			OnPropertyChanged(nameof(PebHeapFlags));
			OnPropertyChanged(nameof(PebNtGlobalFlag));
			OnPropertyChanged(nameof(PebStartupInfo));
			OnPropertyChanged(nameof(PreventThreadCreation));
			OnPropertyChanged(nameof(RemoveDebugPrivileges));
			OnPropertyChanged(nameof(NtSetInformationProcessHook));
			OnPropertyChanged(nameof(KillAntiAttach));
			OnPropertyChanged(nameof(RunPeUnpacker));
			OnPropertyChanged(nameof(HideFromPeb));
			OnPropertyChanged(nameof(handleExceptionPrint));
			OnPropertyChanged(nameof(handleExceptionRip));
			OnPropertyChanged(nameof(handleExceptionIllegalInstruction));
			OnPropertyChanged(nameof(handleExceptionInvalidLockSequence));
			OnPropertyChanged(nameof(handleExceptionNoncontinuableException));
			OnPropertyChanged(nameof(handleExceptionAssertionFailure));
			OnPropertyChanged(nameof(handleExceptionBreakpoint));
			OnPropertyChanged(nameof(handleExceptionGuardPageViolation));
			OnPropertyChanged(nameof(handleExceptionWx86Breakpoint));
			OnPropertyChanged(nameof(AutostartServer));
			OnPropertyChanged(nameof(BreakOnTLS));
			OnPropertyChanged(nameof(FixOllyBugs));
			OnPropertyChanged(nameof(RemoveEPBreak));
			OnPropertyChanged(nameof(SkipEPOutsideCode));
			OnPropertyChanged(nameof(X64Fix));
			OnPropertyChanged(nameof(advancedGoto));
			OnPropertyChanged(nameof(ignoreBadPEImage));
			OnPropertyChanged(nameof(skipCompressedDoAnalyze));
			OnPropertyChanged(nameof(skipCompressedDoNothing));
			OnPropertyChanged(nameof(skipLoadDllDoLoad));
			OnPropertyChanged(nameof(skipLoadDllDoNothing));
			OnPropertyChanged(nameof(advancedInfobar));
			OnPropertyChanged(nameof(WindowTitle));
			OnPropertyChanged(nameof(ServerPort));
		}

		public void OnModefied()
		{
			settings.SaveAllSettings();
		}
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public Action<object,RoutedEventArgs> Button_Click
		{
			get { return button_Click; }
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			var dialog = new InputNewName();
			if (dialog.ShowDialog() == true)
			{
				string section = dialog.ResponseText;
				for (int i = 0; i < settings.Sections.Count; i++)
				{
					if (settings.Sections[i].SectionName == section)
					{
						MessageBox.Show(section + " such profile already exist");
						return;
					}
				}

				ScyllaHideSettingsSection sectionInst = new ScyllaHideSettingsSection(section);
				settings.Sections.Add(sectionInst);
				settings.CurrentSelectedSection = sectionInst;
				OnModefied();

				OnPropertyChanged(nameof(Profiles));
				OnPropertyChanged(nameof(SelectedProfileIndex));
				UpdateAllUi();


			}
		}


	}
}