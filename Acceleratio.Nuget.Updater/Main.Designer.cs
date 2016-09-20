﻿using System;
using Microsoft.Win32;


namespace Acceleratio.Nuget.Updater
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.rootPathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.solutionsList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.repositoryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.latestCheckBox = new System.Windows.Forms.CheckBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.versionsDropDown = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.uploadCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteOldCheckBox = new System.Windows.Forms.CheckBox();
            this.packagesComboBoxList = new CheckComboBoxTest.CheckedComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Root directory:";
            // 
            // rootPathTextBox
            // 
            this.rootPathTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rootPathTextBox.Location = new System.Drawing.Point(114, 41);
            this.rootPathTextBox.Name = "rootPathTextBox";
            this.rootPathTextBox.ReadOnly = true;
            this.rootPathTextBox.Size = new System.Drawing.Size(530, 23);
            this.rootPathTextBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(650, 13);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(245, 51);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse for solution directory";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // solutionsList
            // 
            this.solutionsList.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.solutionsList.FormattingEnabled = true;
            this.solutionsList.ItemHeight = 15;
            this.solutionsList.Location = new System.Drawing.Point(15, 203);
            this.solutionsList.Name = "solutionsList";
            this.solutionsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.solutionsList.Size = new System.Drawing.Size(629, 154);
            this.solutionsList.TabIndex = 4;
            this.solutionsList.SelectedIndexChanged += new System.EventHandler(this.solutionsList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "NuGet repository:";
            // 
            // repositoryTextBox
            // 
            this.repositoryTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.repositoryTextBox.Location = new System.Drawing.Point(114, 13);
            this.repositoryTextBox.Name = "repositoryTextBox";
            this.repositoryTextBox.Size = new System.Drawing.Size(441, 23);
            this.repositoryTextBox.TabIndex = 6;
            this.repositoryTextBox.Text = "";            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Package(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Solutions:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusTextBox.Location = new System.Drawing.Point(15, 385);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statusTextBox.Size = new System.Drawing.Size(629, 160);
            this.statusTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Package version:";
            // 
            // latestCheckBox
            // 
            this.latestCheckBox.AutoSize = true;
            this.latestCheckBox.Checked = true;
            this.latestCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.latestCheckBox.Enabled = false;
            this.latestCheckBox.Location = new System.Drawing.Point(650, 102);
            this.latestCheckBox.Name = "latestCheckBox";
            this.latestCheckBox.Size = new System.Drawing.Size(55, 17);
            this.latestCheckBox.TabIndex = 17;
            this.latestCheckBox.Text = "Latest";
            this.latestCheckBox.UseVisualStyleBackColor = true;
            this.latestCheckBox.CheckedChanged += new System.EventHandler(this.latestCheckBox_CheckedChanged);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(650, 203);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(245, 52);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "Update selected solutions";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // versionsDropDown
            // 
            this.versionsDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionsDropDown.Enabled = false;
            this.versionsDropDown.FormattingEnabled = true;
            this.versionsDropDown.Location = new System.Drawing.Point(114, 100);
            this.versionsDropDown.Name = "versionsDropDown";
            this.versionsDropDown.Size = new System.Drawing.Size(530, 21);
            this.versionsDropDown.TabIndex = 19;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(561, 13);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(83, 23);
            this.connectButton.TabIndex = 21;
            this.connectButton.Text = "Load";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Advanced options:";
            // 
            // uploadCheckBox
            // 
            this.uploadCheckBox.AutoSize = true;
            this.uploadCheckBox.Checked = true;
            this.uploadCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uploadCheckBox.Location = new System.Drawing.Point(114, 137);
            this.uploadCheckBox.Name = "uploadCheckBox";
            this.uploadCheckBox.Size = new System.Drawing.Size(257, 17);
            this.uploadCheckBox.TabIndex = 23;
            this.uploadCheckBox.Text = "Upload files to packages folder on source control";
            this.uploadCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteOldCheckBox
            // 
            this.deleteOldCheckBox.AutoSize = true;
            this.deleteOldCheckBox.Checked = true;
            this.deleteOldCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteOldCheckBox.Location = new System.Drawing.Point(114, 160);
            this.deleteOldCheckBox.Name = "deleteOldCheckBox";
            this.deleteOldCheckBox.Size = new System.Drawing.Size(405, 17);
            this.deleteOldCheckBox.TabIndex = 24;
            this.deleteOldCheckBox.Text = "Delete older files from packages folder on source control (this could take a whil" +
    "e)";
            this.deleteOldCheckBox.UseVisualStyleBackColor = true;
            // 
            // packagesComboBoxList
            // 
            this.packagesComboBoxList.CheckOnClick = true;
            this.packagesComboBoxList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.packagesComboBoxList.DropDownHeight = 1;
            this.packagesComboBoxList.Enabled = false;
            this.packagesComboBoxList.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.packagesComboBoxList.FormattingEnabled = true;
            this.packagesComboBoxList.IntegralHeight = false;
            this.packagesComboBoxList.Location = new System.Drawing.Point(114, 70);
            this.packagesComboBoxList.Name = "packagesComboBoxList";
            this.packagesComboBoxList.Size = new System.Drawing.Size(530, 24);
            this.packagesComboBoxList.TabIndex = 20;
            this.packagesComboBoxList.ValueSeparator = "; ";
            this.packagesComboBoxList.DropDownClosed += new System.EventHandler(this.packagesComboBoxList_DropDownClosed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(873, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "1.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 558);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.deleteOldCheckBox);
            this.Controls.Add(this.uploadCheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.packagesComboBoxList);
            this.Controls.Add(this.versionsDropDown);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.latestCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.repositoryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.solutionsList);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.rootPathTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceleratio.Nuget.Updater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rootPathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ListBox solutionsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox repositoryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox latestCheckBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox versionsDropDown;
        private CheckComboBoxTest.CheckedComboBox packagesComboBoxList;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox uploadCheckBox;
        private System.Windows.Forms.CheckBox deleteOldCheckBox;
        private System.Windows.Forms.Label label8;
    }
}
