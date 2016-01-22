namespace P01_Caldwell_Scheidler
{
    partial class SimComSimulator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimComSimulator));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTextFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblProg = new System.Windows.Forms.Label();
            this.progTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.varTextBox = new System.Windows.Forms.RichTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTextFileToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openTextFileToolStripMenuItem
            // 
            this.openTextFileToolStripMenuItem.AutoToolTip = true;
            this.openTextFileToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.openTextFileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.openTextFileToolStripMenuItem.Name = "openTextFileToolStripMenuItem";
            this.openTextFileToolStripMenuItem.Size = new System.Drawing.Size(197, 25);
            this.openTextFileToolStripMenuItem.Text = "Open && Compile Text File";
            this.openTextFileToolStripMenuItem.ToolTipText = "Click to select a file to load a program from.";
            this.openTextFileToolStripMenuItem.Click += new System.EventHandler(this.openTextFileToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.quitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(52, 25);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // openTextFileDialog
            // 
            this.openTextFileDialog.Filter = "Text Files | *.txt";
            // 
            // lblProg
            // 
            this.lblProg.AutoSize = true;
            this.lblProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProg.Location = new System.Drawing.Point(125, 49);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(81, 20);
            this.lblProg.TabIndex = 2;
            this.lblProg.Text = "Program:";
            // 
            // progTextBox
            // 
            this.progTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.progTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.progTextBox.Location = new System.Drawing.Point(243, 49);
            this.progTextBox.Name = "progTextBox";
            this.progTextBox.ReadOnly = true;
            this.progTextBox.Size = new System.Drawing.Size(304, 334);
            this.progTextBox.TabIndex = 1;
            this.progTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Variables:";
            // 
            // varTextBox
            // 
            this.varTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.varTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.varTextBox.Location = new System.Drawing.Point(243, 405);
            this.varTextBox.Name = "varTextBox";
            this.varTextBox.ReadOnly = true;
            this.varTextBox.Size = new System.Drawing.Size(304, 175);
            this.varTextBox.TabIndex = 4;
            this.varTextBox.Text = "";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "SimCom Simulator - Caldwell & Scheidler 2016";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SimCom Simulator";
            this.notifyIcon1.Visible = true;
            // 
            // SimComSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::P01_Caldwell_Scheidler.Properties.Resources.Computer_Monitor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1354, 602);
            this.Controls.Add(this.varTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProg);
            this.Controls.Add(this.progTextBox);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SimComSimulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimCom Simulator - Caldwell & Scheidler 2016";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openTextFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openTextFileDialog;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label lblProg;
        private System.Windows.Forms.RichTextBox progTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox varTextBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

