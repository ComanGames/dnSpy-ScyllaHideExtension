using System.Collections.Generic;
using dnSpy.Contracts.App;
using dnSpy.Contracts.Extension;

// Each extension should export one class implementing IExtension

namespace dnSpy.ScyllaHide {
	[ExportExtension]
	sealed class ScyllaHideExtension : IExtension {
		public IEnumerable<string> MergedResourceDictionaries {
			get {
				// We don't have any extra resource dictionaries
				yield break;
			}
		}

		public ExtensionInfo ExtensionInfo => new ExtensionInfo {
			ShortDescription = "Scylla Hide support for dnSpy",
		};

		public void OnEvent(ExtensionEvent @event, object obj) {
		}
	}
}
