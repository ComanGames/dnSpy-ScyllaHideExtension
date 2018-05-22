using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using dnSpy.Contracts.Images;
using dnSpy.Contracts.Settings.Dialog;

// Adds an options dialog box page showing settings saved in ScyllaHideSettings

namespace dnSpy.ScyllaHide {
	// This instance gets called by dnSpy to create the page each time the user opens the options dialog
	[Export(typeof(IAppSettingsPageProvider))]	// Tell MEF we're exporting this instance
	sealed class SccyllaHideSettingsPageProvider : IAppSettingsPageProvider {
		readonly ScyllaHideSettings _scyllaHideSettings;

		// This constructor gets the single ScyllaHideSettingsImpl instance exported by ScyllaHideSettingsImpl in ScyllaHideSettings.cs
		[ImportingConstructor]
		SccyllaHideSettingsPageProvider(ScyllaHideSettings scyllaHideSettings) => this._scyllaHideSettings = scyllaHideSettings;

		public IEnumerable<AppSettingsPage> Create() {
			// We only create one page
			yield return new ScyllaHideSettingsPage(_scyllaHideSettings);
		}
	}

	sealed class ScyllaHideSettingsPage : AppSettingsPage {

		static readonly Guid THE_GUID = new Guid("7F406C01-4F42-48A9-B935-1522CD3AAE1B");

		// Guid of parent page or Guid.Empty if it has none
		public override Guid ParentGuid => Guid.Empty;

		// Unique guid of this settings page
		public override Guid Guid => THE_GUID;

		// The order of the page, let's place it after the debugger page
		public override double Order => AppSettingsConstants.ORDER_DEBUGGER + 0.1;

		public override string Title => "ScyllaHideExtension";

		// An image that can be shown. You can return ImageReference.None if you don't want an image.
		// Let's return an image since no other settings page is currently using images.
		public override ImageReference Icon => DsImages.Assembly;

		// This is the content shown in the page. It should be a WPF object (eg. a UserControl) or a
		// ViewModel with a DataTemplate defined in a resource dictionary.
		public override object UIObject {
			get {
				if (uiObject == null) {
					uiObject = new ScyllaHideSettingsControl();
					uiObject.DataContext = newSettings;
				}
				return uiObject;
			}
		}
		ScyllaHideSettingsControl uiObject;

		readonly ScyllaHideSettings globalSettings;
		readonly ScyllaHideSettings newSettings;

		public ScyllaHideSettingsPage(ScyllaHideSettings scyllaHideSettings) {
			globalSettings = scyllaHideSettings;
			newSettings = scyllaHideSettings.Clone();
		}

		public override void OnApply() =>
			// OK/Apply was pressed, save the settings
			newSettings.CopyTo(globalSettings);

		public override void OnClosed() {
			// The dialog box was closed
		}
	}
}
