namespace Updater
{
	// Token: 0x0200000A RID: 10
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002DD0 File Offset: 0x000011D0
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002E20 File Offset: 0x00001220
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Updater.Form1));
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.wc = new global::System.Net.WebClient();
			this.t1 = new global::System.Windows.Forms.Timer(this.components);
			this.lbl_inen = new global::System.Windows.Forms.Label();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(12, 11);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(323, 13);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Lütfen güncelleme işlemi devam ederken bu pencereyi kapatmayın.";
			global::System.Windows.Forms.Control progressBar = this.ProgressBar1;
			location = new global::System.Drawing.Point(15, 52);
			progressBar.Location = location;
			this.ProgressBar1.Name = "ProgressBar1";
			global::System.Windows.Forms.Control progressBar2 = this.ProgressBar1;
			size = new global::System.Drawing.Size(385, 23);
			progressBar2.Size = size;
			this.ProgressBar1.Style = global::System.Windows.Forms.ProgressBarStyle.Marquee;
			this.ProgressBar1.TabIndex = 2;
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(137, 81);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(126, 33);
			button2.Size = size;
			this.Button1.TabIndex = 3;
			this.Button1.Text = "İptal";
			this.Button1.UseVisualStyleBackColor = true;
			this.wc.BaseAddress = "";
			this.wc.CachePolicy = null;
			this.wc.Credentials = null;
			this.wc.Encoding = (global::System.Text.Encoding)componentResourceManager.GetObject("wc.Encoding");
			this.wc.Headers = (global::System.Net.WebHeaderCollection)componentResourceManager.GetObject("wc.Headers");
			this.wc.QueryString = (global::System.Collections.Specialized.NameValueCollection)componentResourceManager.GetObject("wc.QueryString");
			this.wc.UseDefaultCredentials = false;
			this.t1.Interval = 2000;
			this.lbl_inen.AutoSize = true;
			global::System.Windows.Forms.Control lbl_inen = this.lbl_inen;
			location = new global::System.Drawing.Point(13, 33);
			lbl_inen.Location = location;
			this.lbl_inen.Name = "lbl_inen";
			global::System.Windows.Forms.Control lbl_inen2 = this.lbl_inen;
			size = new global::System.Drawing.Size(100, 13);
			lbl_inen2.Size = size;
			this.lbl_inen.TabIndex = 4;
			this.lbl_inen.Text = "Şu ana kadar inen :";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 3000;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(415, 121);
			this.ClientSize = size;
			this.Controls.Add(this.lbl_inen);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RedaX Updater";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400000E RID: 14
		private global::System.ComponentModel.IContainer components;
	}
}
