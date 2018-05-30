using System;
using System.ComponentModel.Composition;
using dnSpy.Contracts.MVVM;
using dnSpy.Contracts.Settings;

// Reads and writes the extension settings

namespace dnSpy.ScyllaHide {
	class ScyllaHideSettings : ViewModelBase
	{
		protected virtual void OnModified() {
		}

		public bool IsEnabledOption {
			get { return _isEnabledOption; }
			set {
				if (_isEnabledOption != value) {
					_isEnabledOption = value;
					OnPropertyChanged(nameof(IsEnabledOption));
					OnModified();
				}
			}
		}
		bool _isEnabledOption = true;

		public int SelectedProfile {
			get { return _selectedProfile; }
			set {
				if (_selectedProfile != value) {
					_selectedProfile = value;
					OnPropertyChanged(nameof(SelectedProfile));
					OnModified();
				}
			}
		}
		int _selectedProfile = 0;

		public string StringOption3 {
			get { return stringOption3; }
			set {
				if (stringOption3 != value) {
					stringOption3 = value;
					OnPropertyChanged(nameof(StringOption3));
					OnModified();
				}
			}
		}
		string stringOption3 = string.Empty;

		public ScyllaHideSettings Clone() => CopyTo(new ScyllaHideSettings());

		public ScyllaHideSettings CopyTo(ScyllaHideSettings other) {
			other.IsEnabledOption = IsEnabledOption;
			other.SelectedProfile = SelectedProfile;
			other.StringOption3 = StringOption3;
			return other;
		}
	}

	// Export this class so it can be imported by other classes in this extension
	[Export(typeof(ScyllaHideSettings))]
	sealed class ScyllaHideSettingsImpl : ScyllaHideSettings {

	    readonly ISettingsService settingsService;

		// Tell MEF to pass in the required ISettingsService instance exported by dnSpy
		[ImportingConstructor]
		 ScyllaHideSettingsImpl(ISettingsService settingsService) {
			this.settingsService = settingsService;

			// Read the settings from the file or use the default values if our settings haven't
			// been saved to it yet.

			disableSave = true;
			var sect = settingsService.GetOrCreateSection(ScyllaHideExtensionGlobalInfo.SETTINGS_GUID);
			IsEnabledOption = sect.Attribute<bool?>(nameof(IsEnabledOption)) ?? IsEnabledOption;
			SelectedProfile = sect.Attribute<int?>(nameof(SelectedProfile)) ?? SelectedProfile;
			StringOption3 = sect.Attribute<string>(nameof(StringOption3)) ?? StringOption3;
			disableSave = false;
		}
		readonly bool disableSave;

		// Called by the base class
		protected override void OnModified() {
			if (disableSave)
				return;

			// Save the settings
			var sect = settingsService.RecreateSection(ScyllaHideExtensionGlobalInfo.SETTINGS_GUID);
			sect.Attribute(nameof(IsEnabledOption), IsEnabledOption);
			sect.Attribute(nameof(SelectedProfile), SelectedProfile);
			sect.Attribute(nameof(StringOption3), StringOption3);
		}
	}
}
