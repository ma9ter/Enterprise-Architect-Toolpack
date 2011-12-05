﻿/*
 * User: wij
 * Date: 25/02/2011 4:52
 */
namespace TSF.UmlToolingFramework.EANavigator
{
	partial class AboutWindow
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.ApplicationTitle = new System.Windows.Forms.Label();
			this.VersionLabel = new System.Windows.Forms.Label();
			this.Version = new System.Windows.Forms.Label();
			this.DateLabel = new System.Windows.Forms.Label();
			this.AssemblyDate = new System.Windows.Forms.Label();
			this.AuthorName = new System.Windows.Forms.Label();
			this.AuthorEmail = new System.Windows.Forms.LinkLabel();
			this.HomePage = new System.Windows.Forms.LinkLabel();
			this.OKButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ApplicationTitle
			// 
			this.ApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ApplicationTitle.Location = new System.Drawing.Point(13, 11);
			this.ApplicationTitle.Name = "ApplicationTitle";
			this.ApplicationTitle.Size = new System.Drawing.Size(178, 23);
			this.ApplicationTitle.TabIndex = 0;
			this.ApplicationTitle.Text = "EA Navigator";
			// 
			// VersionLabel
			// 
			this.VersionLabel.Location = new System.Drawing.Point(13, 71);
			this.VersionLabel.Name = "VersionLabel";
			this.VersionLabel.Size = new System.Drawing.Size(100, 23);
			this.VersionLabel.TabIndex = 1;
			this.VersionLabel.Text = "Version:";
			// 
			// Version
			// 
			this.Version.Location = new System.Drawing.Point(71, 71);
			this.Version.Name = "Version";
			this.Version.Size = new System.Drawing.Size(100, 23);
			this.Version.TabIndex = 2;
			this.Version.Text = "assemblyVersion";
			// 
			// DateLabel
			// 
			this.DateLabel.Location = new System.Drawing.Point(13, 84);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(100, 23);
			this.DateLabel.TabIndex = 3;
			this.DateLabel.Text = "Date:";
			// 
			// AssemblyDate
			// 
			this.AssemblyDate.Location = new System.Drawing.Point(71, 84);
			this.AssemblyDate.Name = "AssemblyDate";
			this.AssemblyDate.Size = new System.Drawing.Size(100, 23);
			this.AssemblyDate.TabIndex = 4;
			this.AssemblyDate.Text = "AssemblyDate";
			// 
			// AuthorName
			// 
			this.AuthorName.Location = new System.Drawing.Point(13, 38);
			this.AuthorName.Name = "AuthorName";
			this.AuthorName.Size = new System.Drawing.Size(132, 23);
			this.AuthorName.TabIndex = 6;
			this.AuthorName.Text = "© 2011 Geert Bellekens";
			// 
			// AuthorEmail
			// 
			this.AuthorEmail.Location = new System.Drawing.Point(135, 38);
			this.AuthorEmail.Name = "AuthorEmail";
			this.AuthorEmail.Size = new System.Drawing.Size(127, 23);
			this.AuthorEmail.TabIndex = 7;
			this.AuthorEmail.TabStop = true;
			this.AuthorEmail.Text = "geert@bellekens.com";
			this.AuthorEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuthorEmailLinkClicked);
			// 
			// HomePage
			// 
			this.HomePage.Location = new System.Drawing.Point(13, 121);
			this.HomePage.Name = "HomePage";
			this.HomePage.Size = new System.Drawing.Size(233, 23);
			this.HomePage.TabIndex = 8;
			this.HomePage.TabStop = true;
			this.HomePage.Text = "EA Navigator Home Page";
			this.HomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HomePageLinkClicked);
			// 
			// OKButton
			// 
			this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OKButton.AutoSize = true;
			this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OKButton.Location = new System.Drawing.Point(187, 157);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 9;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButtonClick);
			// 
			// AboutWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 192);
			this.Controls.Add(this.OKButton);
			this.Controls.Add(this.HomePage);
			this.Controls.Add(this.AuthorEmail);
			this.Controls.Add(this.AuthorName);
			this.Controls.Add(this.AssemblyDate);
			this.Controls.Add(this.DateLabel);
			this.Controls.Add(this.Version);
			this.Controls.Add(this.VersionLabel);
			this.Controls.Add(this.ApplicationTitle);
			this.Name = "AboutWindow";
			this.Text = "About EA Navigator";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.LinkLabel HomePage;
		private System.Windows.Forms.LinkLabel AuthorEmail;
		private System.Windows.Forms.Label AuthorName;
		private System.Windows.Forms.Label AssemblyDate;
		private System.Windows.Forms.Label DateLabel;
		private System.Windows.Forms.Label Version;
		private System.Windows.Forms.Label VersionLabel;
		private System.Windows.Forms.Label ApplicationTitle;
	}
}