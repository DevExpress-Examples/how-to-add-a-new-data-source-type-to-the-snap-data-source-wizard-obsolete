namespace CustomWizardExample.Wizard.Views {
    partial class ChoosePersonsPageView {
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
            this.rgDataSourceType = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.panelBaseContent)).BeginInit();
            this.panelBaseContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAdditionalButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDataSourceType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(313, 418);
            this.buttonNext.Size = new System.Drawing.Size(59, 22);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(378, 418);
            this.buttonFinish.Size = new System.Drawing.Size(58, 22);
            // 
            // separatorTop
            // 
            this.separatorTop.Size = new System.Drawing.Size(448, 6);
            // 
            // labelHeader
            // 
            this.labelHeader.Location = new System.Drawing.Point(50, 21);
            this.labelHeader.Size = new System.Drawing.Size(396, 13);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Size = new System.Drawing.Size(50, 30);
            // 
            // panelBaseContent
            // 
            this.panelBaseContent.Controls.Add(this.rgDataSourceType);
            this.panelBaseContent.Size = new System.Drawing.Size(444, 364);
            // 
            // panelAdditionalButtons
            // 
            this.panelAdditionalButtons.Location = new System.Drawing.Point(0, 416);
            this.panelAdditionalButtons.Size = new System.Drawing.Size(311, 26);
            // 
            // rgDataSourceType
            // 
            this.rgDataSourceType.Dock = System.Windows.Forms.DockStyle.Top;
            this.rgDataSourceType.Location = new System.Drawing.Point(0, 0);
            this.rgDataSourceType.Name = "rgDataSourceType";
            this.rgDataSourceType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Load data from the xml file"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Load data from the predefined list")});
            this.rgDataSourceType.Size = new System.Drawing.Size(444, 96);
            this.rgDataSourceType.TabIndex = 3;
            // 
            // ChoosePersonsPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ChoosePersonsPageView";
            this.Size = new System.Drawing.Size(448, 452);
            ((System.ComponentModel.ISupportInitialize)(this.panelBaseContent)).EndInit();
            this.panelBaseContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAdditionalButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDataSourceType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup rgDataSourceType;



    }
}
