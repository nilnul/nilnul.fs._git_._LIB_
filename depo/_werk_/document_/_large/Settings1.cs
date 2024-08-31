namespace nilnul.fs.git.depo._werk_.document_._large {
    
    
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    public sealed partial class Settings1 {
        
        public Settings1() {
            // // To add event handlers for saving and changing settings, uncomment the lines below:
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Add code to handle the SettingChangingEvent event here.
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Add code to handle the SettingsSaving event here.
        }

		//public int limit8octetsDiscounted {
		//	get {
		//		return this.limit8moctets * 999999;// 1048576;
		//	}
		//}
		/// <summary>
		/// <see cref="nilnul.fs.git.svrs_._aagg.LimitX.BlobInBytes"/>
		/// </summary>
		public int limit8octets
		{
			get
			{
				/// for legacy reasons, the limit in settings were set too low, previousely split part  would be resplit.
				return this.limit8moctets * nilnul.num_.radix_.binary_.Mega.INT32;
			}
		}

	}
}
