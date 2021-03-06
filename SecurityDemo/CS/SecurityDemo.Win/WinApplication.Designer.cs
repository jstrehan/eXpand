using System.Runtime.Remoting.Channels;
using DevExpress.ExpressApp.MiddleTier.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using System;
using System.Configuration;
namespace SecurityDemo.Win
{
	partial class SecurityDemoWindowsFormsApplication
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
            this.module3 = new SecurityDemo.Module.SecurityDemoModule();
            this.module4 = new SecurityDemo.Module.Win.SecurityDemoWindowsFormsModule();
            this.module6 = new DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule();
            this.module7 = new DevExpress.ExpressApp.TreeListEditors.TreeListEditorsModuleBase();
            this.module8 = new DevExpress.ExpressApp.TreeListEditors.Win.TreeListEditorsWindowsFormsModule();
            this.module10 = new DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule();
            this.securityModule1 = new DevExpress.ExpressApp.Security.SecurityModule();
            this.securityProxy = new DevExpress.ExpressApp.Security.SecurityStrategyProxy();
            this.validationModule1 = new DevExpress.ExpressApp.Validation.ValidationModule();
            this.xpandSystemModule1 = new Xpand.ExpressApp.SystemModule.XpandSystemModule();
            this.xpandSystemWindowsFormsModule1 = new Xpand.ExpressApp.Win.SystemModule.XpandSystemWindowsFormsModule();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // securityProxy
            // 
            this.securityProxy.ConnectionString = "tcp://localhost:14362/SecurityDemoApplicationServer";
            // 
            // validationModule1
            // 
            this.validationModule1.AllowValidationDetailsAccess = true;
            // 
            // SecurityDemoWindowsFormsApplication
            // 
            this.ApplicationName = "SecurityDemo";
            this.ConnectionString = "tcp://localhost:14362/ApplicationServer";
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.securityModule1);
            this.Modules.Add(this.xpandSystemModule1);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module7);
            this.Modules.Add(this.module8);
            this.Modules.Add(this.validationModule1);
            this.Modules.Add(this.module10);
            this.Modules.Add(this.xpandSystemWindowsFormsModule1);
            this.Modules.Add(this.module4);
            this.Modules.Add(this.module6);
            this.Security = this.securityProxy;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
		private SecurityDemo.Module.SecurityDemoModule module3;
		private SecurityDemo.Module.Win.SecurityDemoWindowsFormsModule module4;
        private DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule module6;
        private DevExpress.ExpressApp.TreeListEditors.TreeListEditorsModuleBase module7;
        private DevExpress.ExpressApp.TreeListEditors.Win.TreeListEditorsWindowsFormsModule module8;
        private DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule module10;
        private DevExpress.ExpressApp.Security.SecurityModule securityModule1;
        private DevExpress.ExpressApp.Security.SecurityStrategyProxy securityProxy;
        private DevExpress.ExpressApp.Validation.ValidationModule validationModule1;
        private Xpand.ExpressApp.SystemModule.XpandSystemModule xpandSystemModule1;
        private Xpand.ExpressApp.Win.SystemModule.XpandSystemWindowsFormsModule xpandSystemWindowsFormsModule1;

    }
}
