
namespace CopyTradingIq
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabStatus = new MetroFramework.Controls.MetroTabPage();
            this.tabSettings = new MetroFramework.Controls.MetroTabPage();
            this.tabLog = new MetroFramework.Controls.MetroTabPage();
            this.txtLogs = new MetroFramework.Controls.MetroTextBox();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.TabControl.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabStatus);
            this.TabControl.Controls.Add(this.tabSettings);
            this.TabControl.Controls.Add(this.tabLog);
            this.TabControl.Location = new System.Drawing.Point(23, 63);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 2;
            this.TabControl.Size = new System.Drawing.Size(754, 364);
            this.TabControl.TabIndex = 0;
            this.TabControl.UseSelectable = true;
            // 
            // tabStatus
            // 
            this.tabStatus.HorizontalScrollbarBarColor = true;
            this.tabStatus.HorizontalScrollbarHighlightOnWheel = false;
            this.tabStatus.HorizontalScrollbarSize = 10;
            this.tabStatus.Location = new System.Drawing.Point(4, 38);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Size = new System.Drawing.Size(746, 322);
            this.tabStatus.TabIndex = 0;
            this.tabStatus.Text = "Status";
            this.tabStatus.VerticalScrollbarBarColor = true;
            this.tabStatus.VerticalScrollbarHighlightOnWheel = false;
            this.tabStatus.VerticalScrollbarSize = 10;
            // 
            // tabSettings
            // 
            this.tabSettings.HorizontalScrollbarBarColor = true;
            this.tabSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSettings.HorizontalScrollbarSize = 10;
            this.tabSettings.Location = new System.Drawing.Point(4, 38);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(746, 322);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.VerticalScrollbarBarColor = true;
            this.tabSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tabSettings.VerticalScrollbarSize = 10;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.txtLogs);
            this.tabLog.HorizontalScrollbarBarColor = true;
            this.tabLog.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLog.HorizontalScrollbarSize = 10;
            this.tabLog.Location = new System.Drawing.Point(4, 38);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(746, 322);
            this.tabLog.TabIndex = 2;
            this.tabLog.Text = "Log\'s";
            this.tabLog.VerticalScrollbarBarColor = true;
            this.tabLog.VerticalScrollbarHighlightOnWheel = false;
            this.tabLog.VerticalScrollbarSize = 10;
            // 
            // txtLogs
            // 
            // 
            // 
            // 
            this.txtLogs.CustomButton.Image = null;
            this.txtLogs.CustomButton.Location = new System.Drawing.Point(432, 2);
            this.txtLogs.CustomButton.Name = "";
            this.txtLogs.CustomButton.Size = new System.Drawing.Size(311, 311);
            this.txtLogs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLogs.CustomButton.TabIndex = 1;
            this.txtLogs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogs.CustomButton.UseSelectable = true;
            this.txtLogs.CustomButton.Visible = false;
            this.txtLogs.Lines = new string[] {
        "txtLogs"};
            this.txtLogs.Location = new System.Drawing.Point(0, 3);
            this.txtLogs.MaxLength = 32767;
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.PasswordChar = '\0';
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogs.SelectedText = "";
            this.txtLogs.SelectionLength = 0;
            this.txtLogs.SelectionStart = 0;
            this.txtLogs.ShortcutsEnabled = true;
            this.txtLogs.Size = new System.Drawing.Size(746, 316);
            this.txtLogs.TabIndex = 0;
            this.txtLogs.Text = "txtLogs";
            this.txtLogs.UseSelectable = true;
            this.txtLogs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(718, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close 😔";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage tabStatus;
        private MetroFramework.Controls.MetroTabPage tabSettings;
        private MetroFramework.Controls.MetroTabPage tabLog;
        private MetroFramework.Controls.MetroTextBox txtLogs;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}

