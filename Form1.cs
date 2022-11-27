using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Updater
{
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002CA0 File Offset: 0x000010A0
		[DebuggerNonUserCode]
		public Form1()
		{
			base.Load += this.Form1_Load;
			Form1.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002CCC File Offset: 0x000010CC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Form1.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Form1.__ENCList.Count == Form1.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int num2 = 0;
						int num3 = Form1.__ENCList.Count - 1;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							WeakReference weakReference = Form1.__ENCList[num4];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num4 != num;
								if (flag2)
								{
									Form1.__ENCList[num] = Form1.__ENCList[num4];
								}
								num++;
							}
							num4++;
						}
						Form1.__ENCList.RemoveRange(num, Form1.__ENCList.Count - num);
						Form1.__ENCList.Capacity = Form1.__ENCList.Count;
					}
					Form1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000031FC File Offset: 0x000015FC
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00003214 File Offset: 0x00001614
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00003220 File Offset: 0x00001620
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00003238 File Offset: 0x00001638
		internal virtual ProgressBar ProgressBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ProgressBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ProgressBar1 = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00003244 File Offset: 0x00001644
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0000325C File Offset: 0x0000165C
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				bool flag = this._Button1 != null;
				if (flag)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				flag = (this._Button1 != null);
				if (flag)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000032BC File Offset: 0x000016BC
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000032D4 File Offset: 0x000016D4
		internal virtual WebClient wc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._wc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				AsyncCompletedEventHandler value2 = new AsyncCompletedEventHandler(this.wc_DownloadFileCompleted);
				DownloadProgressChangedEventHandler value3 = new DownloadProgressChangedEventHandler(this.wc_DownloadProgressChanged);
				bool flag = this._wc != null;
				if (flag)
				{
					this._wc.DownloadFileCompleted -= value2;
					this._wc.DownloadProgressChanged -= value3;
				}
				this._wc = value;
				flag = (this._wc != null);
				if (flag)
				{
					this._wc.DownloadFileCompleted += value2;
					this._wc.DownloadProgressChanged += value3;
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000335C File Offset: 0x0000175C
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00003374 File Offset: 0x00001774
		internal virtual Timer t1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._t1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.t1_Tick);
				bool flag = this._t1 != null;
				if (flag)
				{
					this._t1.Tick -= value2;
				}
				this._t1 = value;
				flag = (this._t1 != null);
				if (flag)
				{
					this._t1.Tick += value2;
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000033D4 File Offset: 0x000017D4
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000033EC File Offset: 0x000017EC
		internal virtual Label lbl_inen
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_inen;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_inen = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000033F8 File Offset: 0x000017F8
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00003410 File Offset: 0x00001810
		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				bool flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick -= value2;
				}
				this._Timer1 = value;
				flag = (this._Timer1 != null);
				if (flag)
				{
					this._Timer1.Tick += value2;
				}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003470 File Offset: 0x00001870
		private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			this.ProgressBar1.Maximum = 100;
			this.ProgressBar1.Value = e.ProgressPercentage;
			this.lbl_inen.Text = "Şu ana kadar inen : " + Conversions.ToString(Math.Round((double)e.BytesReceived / 1024.0, 2)) + " Kb.";
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000034D8 File Offset: 0x000018D8
		public string App_Path()
		{
			return AppDomain.CurrentDomain.BaseDirectory;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000034F4 File Offset: 0x000018F4
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = Interaction.MsgBox("İşlemden vazgeçmek istediğinizden emin misiniz?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "İşlem Sonlandırılsın mı?") == MsgBoxResult.Yes;
			if (flag)
			{
				ProjectData.EndApp();
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003524 File Offset: 0x00001924
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			bool flag = e.Cancelled;
			if (flag)
			{
				this.t1.Enabled = false;
			}
			else
			{
				flag = File.Exists(Application.StartupPath + "\\RedaX.exe");
				if (flag)
				{
					try
					{
						File.Delete(Application.StartupPath + "\\RedaX.exe");
					}
					catch (Exception ex)
					{
						Interaction.MsgBox("Güncelleme yapılamıyor, Uygulamanın halen çalışan bir kopyasının olmadığından emin olduktan sonra tekrar güncellemeyi deneyin!", MsgBoxStyle.Exclamation, "Güncelleme Yapılamadı");
						ProjectData.EndApp();
					}
				}
				this.t1.Enabled = true;
				this.Timer1.Enabled = false;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000035D4 File Offset: 0x000019D4
		private void PaketiAc()
		{
			ZipInputStream zipInputStream = new ZipInputStream(File.OpenRead(Application.StartupPath + "\\update.zip"));
			byte[] array = new byte[2048];
			bool flag;
			for (;;)
			{
				Application.DoEvents();
				ZipEntry nextEntry = zipInputStream.GetNextEntry();
				flag = (nextEntry == null);
				if (flag)
				{
					break;
				}
				FileStream fileStream = File.Create(Application.StartupPath + "\\" + nextEntry.Name, 2048);
				for (;;)
				{
					int num = zipInputStream.Read(array, 0, 2048);
					flag = (num == 0);
					if (flag)
					{
						break;
					}
					fileStream.Write(array, 0, num);
				}
				fileStream.Close();
			}
			zipInputStream.Close();
			flag = File.Exists(Application.StartupPath + "\\RedaX.ex_");
			if (flag)
			{
				File.Copy(Application.StartupPath + "\\RedaX.ex_", Application.StartupPath + "\\RedaX.exe");
				File.Delete(Application.StartupPath + "\\update.zip");
				File.Delete(Application.StartupPath + "\\RedaX.ex_");
			}
			Interaction.Shell(Application.StartupPath + "\\RedaX.exe", AppWinStyle.NormalFocus, false, -1);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003710 File Offset: 0x00001B10
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
			try
			{
				UriTypeConverter uriTypeConverter = new UriTypeConverter();
				this.wc.DownloadFileAsync((Uri)uriTypeConverter.ConvertFromString("http://redax.edisteknoloji.com/update.zip"), Application.StartupPath + "\\update.zip");
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Lütfen indirilebilecek bir Link ekleyin", MsgBoxStyle.Information, "Download Manager");
			}
			this.Timer1.Enabled = false;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000379C File Offset: 0x00001B9C
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000037A0 File Offset: 0x00001BA0
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void t1_Tick(object sender, EventArgs e)
		{
			this.PaketiAc();
			this.t1.Enabled = false;
			this.Timer1.Enabled = false;
			ProjectData.EndApp();
		}

		// Token: 0x0400000D RID: 13
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400000F RID: 15
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000010 RID: 16
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		// Token: 0x04000011 RID: 17
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000012 RID: 18
		[AccessedThroughProperty("wc")]
		private WebClient _wc;

		// Token: 0x04000013 RID: 19
		[AccessedThroughProperty("t1")]
		private Timer _t1;

		// Token: 0x04000014 RID: 20
		[AccessedThroughProperty("lbl_inen")]
		private Label _lbl_inen;

		// Token: 0x04000015 RID: 21
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;
	}
}
