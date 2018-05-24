namespace CustomLogoExample.Win {
    partial class CustomLogoExampleWindowsFormsApplication {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
            this.module3 = new CustomLogoExample.Module.CustomLogoExampleModule();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // CustomLogoExampleWindowsFormsApplication
            // 
            this.ApplicationName = "CustomLogoExample";
            this.CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema;
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.module3);
            this.UseOldTemplates = false;
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.CustomLogoExampleWindowsFormsApplication_DatabaseVersionMismatch);
            this.CustomizeLanguagesList += new System.EventHandler<DevExpress.ExpressApp.CustomizeLanguagesListEventArgs>(this.CustomLogoExampleWindowsFormsApplication_CustomizeLanguagesList);

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
        private CustomLogoExample.Module.CustomLogoExampleModule module3;
    }
}
