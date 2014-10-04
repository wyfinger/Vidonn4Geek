using ComLib;
using DllImportHelper;
using FunctionClass;
using Microsoft.Win32;
using Namespace_00;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using VidonnSync;
using VidonnSync.com.vidonn.www;
using VidonnSync.Properties;
[assembly: AssemblyVersion("2.0.0.4")]
[assembly: Namespace_00.Dotfuscator("124576:1:1:4.9.6005.29054", 1, true)]
[assembly: AssemblyCompany("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCopyright("Copyright © Vidonn.com 2014")]
[assembly: AssemblyDescription("Vidonn SmartBand Data Synchronization")]
[assembly: AssemblyFileVersion("2.0.0.4")]
[assembly: AssemblyProduct("Vidonn SmartBand")]
[assembly: AssemblyTitle("Vidonn SmartBand")]
[assembly: AssemblyTrademark("")]
[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: ComVisible(false)]
[assembly: Guid("6b112a58-a872-49d1-8685-cbd3d7f5614d")]
namespace Namespace_00
{
	internal static class Class_05
	{
		public static string Field_00 = "";
		public static string Field_01 = "";
		public static string Field_02 = "";
		public static string Field_03 = "";
		[STAThread]
		private static void Method_00()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmLogin());
		}
	}
	[AttributeUsage(AttributeTargets.Assembly), ComVisible(false)]
	public sealed class DotfuscatorAttribute : Attribute
	{
		private string Field_00;
		private bool Field_01;
		private int Field_02;
		public string A
		{
			get
			{
				return this.Field_00;
			}
		}
		public bool B
		{
			get
			{
				return this.Field_01;
			}
		}
		public int C
		{
			get
			{
				return this.Field_02;
			}
		}
		public DotfuscatorAttribute(string a, int c, bool b)
		{
			this.Field_00 = a;
			this.Field_02 = c;
			this.Field_01 = b;
		}
	}
}
namespace VidonnSync
{
	public class BitmapRegion
	{
		public static void Method_00(Control control, Bitmap bitmap)
		{
			if (control == null || bitmap == null)
			{
				return;
			}
			control.Width = bitmap.Width;
			control.Height = bitmap.Height;
			if (control is Form)
			{
				Form form = (Form)control;
				form.Width = control.Width;
				form.Height = control.Height;
				form.FormBorderStyle = FormBorderStyle.None;
				form.BackgroundImage = bitmap;
				GraphicsPath path = BitmapRegion.Method_01(bitmap);
				form.Region = new Region(path);
				return;
			}
			if (control is Button)
			{
				Button button = (Button)control;
				button.Text = "";
				button.Cursor = Cursors.Hand;
				button.BackgroundImage = bitmap;
				GraphicsPath path2 = BitmapRegion.Method_01(bitmap);
				button.Region = new Region(path2);
			}
		}
		private static GraphicsPath Method_01(Bitmap A_0)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			Color pixel = A_0.GetPixel(0, 0);
			for (int i = 0; i < A_0.Height; i++)
			{
				for (int j = 0; j < A_0.Width; j++)
				{
					if (A_0.GetPixel(j, i) != pixel)
					{
						int num = j;
						int num2 = num;
						while (num2 < A_0.Width && !(A_0.GetPixel(num2, i) == pixel))
						{
							num2++;
						}
						graphicsPath.AddRectangle(new Rectangle(num, i, num2 - num, 1));
						j = num2;
					}
				}
			}
			return graphicsPath;
		}
	}
	public class Class_00 : Form
	{
		private delegate void Class_01();
		public const int WM_SYSCOMMAND = 274;
		public const int SC_MOVE = 61456;
		public const int Field_00 = 2;
		private IContainer Field_01;
		private PictureBox Field_02;
		private Label Field_03;
		private Label Field_04;
		private Button Field_05;
		private Label Field_06;
		private Label Field_07;
		private GroupBox Field_08;
		private ComboBox Field_09;
		private ComboBox Field_10;
		private CheckBox Field_11;
		private CheckBox Field_12;
		private Label Field_13;
		private Label Field_14;
		private ComboBox Field_15;
		private ComboBox Field_16;
		private CheckBox Field_17;
		private CheckBox Field_18;
		private Label Field_19;
		private Label Field_20;
		private ComboBox Field_21;
		private ComboBox Field_22;
		private CheckBox Field_23;
		private CheckBox Field_24;
		private Label Field_25;
		private Label Field_26;
		private ComboBox Field_27;
		private ComboBox Field_28;
		private CheckBox Field_29;
		private CheckBox Field_30;
		private Label Field_31;
		private Label Field_32;
		private ComboBox Field_33;
		private ComboBox Field_34;
		private CheckBox Field_35;
		private CheckBox Field_36;
		private Label Field_37;
		private Label Field_38;
		private ComboBox Field_39;
		private ComboBox Field_40;
		private CheckBox Field_41;
		private CheckBox Field_42;
		private Label Field_43;
		private Label Field_44;
		private ComboBox Field_45;
		private ComboBox Field_46;
		private CheckBox Field_47;
		private CheckBox Field_48;
		private Label Field_49;
		private Label Field_50;
		private ComboBox Field_51;
		private ComboBox Field_52;
		private CheckBox Field_53;
		private CheckBox Field_54;
		private Label Field_55;
		private Label Field_56;
		private Label Field_57;
		private GroupBox Field_58;
		private Label Field_59;
		private TextBox Field_60;
		private Label Field_61;
		private Label Field_62;
		private TextBox Field_63;
		private Label Field_64;
		private ToolTip Field_65;
		public Class_00()
		{
			try
			{
				this.Method_00();
				new BitmapRegion();
				BitmapRegion.Method_00(this, Class_04.imgoth);
			}
			catch
			{
			}
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.Field_01 != null)
			{
				this.Field_01.Dispose();
			}
			base.Dispose(disposing);
		}
		private void Method_00()
		{
			this.Field_01 = new Container();
			this.Field_02 = new PictureBox();
			this.Field_03 = new Label();
			this.Field_04 = new Label();
			this.Field_05 = new Button();
			this.Field_06 = new Label();
			this.Field_07 = new Label();
			this.Field_08 = new GroupBox();
			this.Field_57 = new Label();
			this.Field_09 = new ComboBox();
			this.Field_10 = new ComboBox();
			this.Field_11 = new CheckBox();
			this.Field_12 = new CheckBox();
			this.Field_13 = new Label();
			this.Field_14 = new Label();
			this.Field_15 = new ComboBox();
			this.Field_16 = new ComboBox();
			this.Field_17 = new CheckBox();
			this.Field_18 = new CheckBox();
			this.Field_19 = new Label();
			this.Field_20 = new Label();
			this.Field_21 = new ComboBox();
			this.Field_22 = new ComboBox();
			this.Field_23 = new CheckBox();
			this.Field_24 = new CheckBox();
			this.Field_25 = new Label();
			this.Field_26 = new Label();
			this.Field_27 = new ComboBox();
			this.Field_28 = new ComboBox();
			this.Field_29 = new CheckBox();
			this.Field_30 = new CheckBox();
			this.Field_31 = new Label();
			this.Field_32 = new Label();
			this.Field_33 = new ComboBox();
			this.Field_34 = new ComboBox();
			this.Field_35 = new CheckBox();
			this.Field_36 = new CheckBox();
			this.Field_37 = new Label();
			this.Field_38 = new Label();
			this.Field_39 = new ComboBox();
			this.Field_40 = new ComboBox();
			this.Field_41 = new CheckBox();
			this.Field_42 = new CheckBox();
			this.Field_43 = new Label();
			this.Field_44 = new Label();
			this.Field_45 = new ComboBox();
			this.Field_46 = new ComboBox();
			this.Field_47 = new CheckBox();
			this.Field_48 = new CheckBox();
			this.Field_49 = new Label();
			this.Field_50 = new Label();
			this.Field_51 = new ComboBox();
			this.Field_52 = new ComboBox();
			this.Field_53 = new CheckBox();
			this.Field_54 = new CheckBox();
			this.Field_55 = new Label();
			this.Field_56 = new Label();
			this.Field_58 = new GroupBox();
			this.Field_59 = new Label();
			this.Field_60 = new TextBox();
			this.Field_61 = new Label();
			this.Field_62 = new Label();
			this.Field_63 = new TextBox();
			this.Field_64 = new Label();
			this.Field_65 = new ToolTip(this.Field_01);
			((ISupportInitialize)this.Field_02).BeginInit();
			this.Field_08.SuspendLayout();
			this.Field_58.SuspendLayout();
			base.SuspendLayout();
			this.Field_02.BackColor = Color.Transparent;
			this.Field_02.Cursor = Cursors.Hand;
			this.Field_02.Enabled = false;
			this.Field_02.Location = new Point(292, 5);
			this.Field_02.Name = "pictureBox1";
			this.Field_02.Size = new Size(22, 20);
			this.Field_02.TabIndex = 2;
			this.Field_02.TabStop = false;
			this.Field_02.Click += new EventHandler(this.Field_02_Click);
			this.Field_03.AutoSize = true;
			this.Field_03.BackColor = Color.Transparent;
			this.Field_03.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_03.ForeColor = Color.White;
			this.Field_03.Location = new Point(12, 17);
			this.Field_03.Name = "label1";
			this.Field_03.Size = new Size(117, 17);
			this.Field_03.TabIndex = 3;
			this.Field_03.Text = "SmartBand Time:";
			this.Field_04.AutoSize = true;
			this.Field_04.BackColor = Color.Transparent;
			this.Field_04.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_04.ForeColor = Color.MistyRose;
			this.Field_04.Location = new Point(130, 17);
			this.Field_04.Name = "lbl_DeviceTime";
			this.Field_04.Size = new Size(73, 17);
			this.Field_04.TabIndex = 4;
			this.Field_04.Text = "Reading...";
			this.Field_05.BackgroundImage = Class_04.btok;
			this.Field_05.Enabled = false;
			this.Field_05.Location = new Point(45, 395);
			this.Field_05.Name = "button1";
			this.Field_05.Size = new Size(240, 50);
			this.Field_05.TabIndex = 13;
			this.Field_05.UseVisualStyleBackColor = true;
			this.Field_05.Click += new EventHandler(this.Field_05_Click);
			this.Field_06.AutoSize = true;
			this.Field_06.BackColor = Color.Transparent;
			this.Field_06.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_06.ForeColor = Color.FromArgb(255, 192, 128);
			this.Field_06.Location = new Point(130, 43);
			this.Field_06.Name = "label12";
			this.Field_06.Size = new Size(73, 17);
			this.Field_06.TabIndex = 15;
			this.Field_06.Text = "Reading...";
			this.Field_07.AutoSize = true;
			this.Field_07.BackColor = Color.Transparent;
			this.Field_07.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_07.ForeColor = Color.White;
			this.Field_07.Location = new Point(21, 43);
			this.Field_07.Name = "label13";
			this.Field_07.Size = new Size(108, 17);
			this.Field_07.TabIndex = 14;
			this.Field_07.Text = "Computer Time:";
			this.Field_08.BackColor = Color.Transparent;
			this.Field_08.Controls.Add(this.Field_57);
			this.Field_08.Controls.Add(this.Field_09);
			this.Field_08.Controls.Add(this.Field_10);
			this.Field_08.Controls.Add(this.Field_11);
			this.Field_08.Controls.Add(this.Field_12);
			this.Field_08.Controls.Add(this.Field_13);
			this.Field_08.Controls.Add(this.Field_14);
			this.Field_08.Controls.Add(this.Field_15);
			this.Field_08.Controls.Add(this.Field_16);
			this.Field_08.Controls.Add(this.Field_17);
			this.Field_08.Controls.Add(this.Field_18);
			this.Field_08.Controls.Add(this.Field_19);
			this.Field_08.Controls.Add(this.Field_20);
			this.Field_08.Controls.Add(this.Field_21);
			this.Field_08.Controls.Add(this.Field_22);
			this.Field_08.Controls.Add(this.Field_23);
			this.Field_08.Controls.Add(this.Field_24);
			this.Field_08.Controls.Add(this.Field_25);
			this.Field_08.Controls.Add(this.Field_26);
			this.Field_08.Controls.Add(this.Field_27);
			this.Field_08.Controls.Add(this.Field_28);
			this.Field_08.Controls.Add(this.Field_29);
			this.Field_08.Controls.Add(this.Field_30);
			this.Field_08.Controls.Add(this.Field_31);
			this.Field_08.Controls.Add(this.Field_32);
			this.Field_08.Controls.Add(this.Field_33);
			this.Field_08.Controls.Add(this.Field_34);
			this.Field_08.Controls.Add(this.Field_35);
			this.Field_08.Controls.Add(this.Field_36);
			this.Field_08.Controls.Add(this.Field_37);
			this.Field_08.Controls.Add(this.Field_38);
			this.Field_08.Controls.Add(this.Field_39);
			this.Field_08.Controls.Add(this.Field_40);
			this.Field_08.Controls.Add(this.Field_41);
			this.Field_08.Controls.Add(this.Field_42);
			this.Field_08.Controls.Add(this.Field_43);
			this.Field_08.Controls.Add(this.Field_44);
			this.Field_08.Controls.Add(this.Field_45);
			this.Field_08.Controls.Add(this.Field_46);
			this.Field_08.Controls.Add(this.Field_47);
			this.Field_08.Controls.Add(this.Field_48);
			this.Field_08.Controls.Add(this.Field_49);
			this.Field_08.Controls.Add(this.Field_50);
			this.Field_08.Controls.Add(this.Field_51);
			this.Field_08.Controls.Add(this.Field_52);
			this.Field_08.Controls.Add(this.Field_53);
			this.Field_08.Controls.Add(this.Field_54);
			this.Field_08.Controls.Add(this.Field_55);
			this.Field_08.Controls.Add(this.Field_56);
			this.Field_08.ForeColor = Color.White;
			this.Field_08.Location = new Point(16, 112);
			this.Field_08.Name = "groupBox2";
			this.Field_08.Size = new Size(287, 239);
			this.Field_08.TabIndex = 16;
			this.Field_08.TabStop = false;
			this.Field_08.Text = "Alarm Clock";
			this.Field_57.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.Field_57.ForeColor = Color.Yellow;
			this.Field_57.Location = new Point(10, 18);
			this.Field_57.Name = "lbl_wait";
			this.Field_57.Size = new Size(267, 208);
			this.Field_57.TabIndex = 18;
			this.Field_57.Text = "Please waiting...";
			this.Field_09.BackColor = Color.MediumAquamarine;
			this.Field_09.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_09.DropDownWidth = 35;
			this.Field_09.ForeColor = Color.Black;
			this.Field_09.FormattingEnabled = true;
			this.Field_09.Location = new Point(217, 205);
			this.Field_09.Name = "cb_Aminite8";
			this.Field_09.Size = new Size(35, 20);
			this.Field_09.TabIndex = 55;
			this.Field_10.BackColor = Color.MediumAquamarine;
			this.Field_10.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_10.DropDownWidth = 35;
			this.Field_10.ForeColor = Color.Black;
			this.Field_10.FormattingEnabled = true;
			this.Field_10.Location = new Point(160, 205);
			this.Field_10.Name = "cb_Ahour8";
			this.Field_10.Size = new Size(35, 20);
			this.Field_10.TabIndex = 54;
			this.Field_11.AutoSize = true;
			this.Field_11.BackColor = Color.Transparent;
			this.Field_11.Checked = true;
			this.Field_11.CheckState = CheckState.Checked;
			this.Field_11.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_11.ForeColor = Color.White;
			this.Field_11.Location = new Point(101, 205);
			this.Field_11.Name = "cb_rp8";
			this.Field_11.Size = new Size(49, 21);
			this.Field_11.TabIndex = 53;
			this.Field_11.Text = "Re.";
			this.Field_11.UseVisualStyleBackColor = false;
			this.Field_12.AutoSize = true;
			this.Field_12.BackColor = Color.Transparent;
			this.Field_12.Checked = true;
			this.Field_12.CheckState = CheckState.Checked;
			this.Field_12.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_12.ForeColor = Color.White;
			this.Field_12.Location = new Point(13, 205);
			this.Field_12.Name = "CBX_EnableAlarm8";
			this.Field_12.Size = new Size(83, 21);
			this.Field_12.TabIndex = 52;
			this.Field_12.Text = "Enable 8";
			this.Field_12.UseVisualStyleBackColor = false;
			this.Field_12.CheckedChanged += new EventHandler(this.Field_12_CheckedChanged);
			this.Field_13.AutoSize = true;
			this.Field_13.BackColor = Color.Transparent;
			this.Field_13.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_13.ForeColor = Color.White;
			this.Field_13.Location = new Point(194, 205);
			this.Field_13.Name = "label19";
			this.Field_13.Size = new Size(22, 17);
			this.Field_13.TabIndex = 50;
			this.Field_13.Text = "H.";
			this.Field_14.AutoSize = true;
			this.Field_14.BackColor = Color.Transparent;
			this.Field_14.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_14.ForeColor = Color.White;
			this.Field_14.Location = new Point(255, 205);
			this.Field_14.Name = "label20";
			this.Field_14.Size = new Size(23, 17);
			this.Field_14.TabIndex = 51;
			this.Field_14.Text = "m.";
			this.Field_15.BackColor = Color.MediumAquamarine;
			this.Field_15.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_15.DropDownWidth = 35;
			this.Field_15.ForeColor = Color.Black;
			this.Field_15.FormattingEnabled = true;
			this.Field_15.Location = new Point(217, 179);
			this.Field_15.Name = "cb_Aminite7";
			this.Field_15.Size = new Size(35, 20);
			this.Field_15.TabIndex = 49;
			this.Field_16.BackColor = Color.MediumAquamarine;
			this.Field_16.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_16.DropDownWidth = 35;
			this.Field_16.ForeColor = Color.Black;
			this.Field_16.FormattingEnabled = true;
			this.Field_16.Location = new Point(160, 179);
			this.Field_16.Name = "cb_Ahour7";
			this.Field_16.Size = new Size(35, 20);
			this.Field_16.TabIndex = 48;
			this.Field_17.AutoSize = true;
			this.Field_17.BackColor = Color.Transparent;
			this.Field_17.Checked = true;
			this.Field_17.CheckState = CheckState.Checked;
			this.Field_17.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_17.ForeColor = Color.White;
			this.Field_17.Location = new Point(101, 179);
			this.Field_17.Name = "cb_rp7";
			this.Field_17.Size = new Size(49, 21);
			this.Field_17.TabIndex = 47;
			this.Field_17.Text = "Re.";
			this.Field_17.UseVisualStyleBackColor = false;
			this.Field_18.AutoSize = true;
			this.Field_18.BackColor = Color.Transparent;
			this.Field_18.Checked = true;
			this.Field_18.CheckState = CheckState.Checked;
			this.Field_18.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_18.ForeColor = Color.White;
			this.Field_18.Location = new Point(13, 179);
			this.Field_18.Name = "CBX_EnableAlarm7";
			this.Field_18.Size = new Size(83, 21);
			this.Field_18.TabIndex = 46;
			this.Field_18.Text = "Enable 7";
			this.Field_18.UseVisualStyleBackColor = false;
			this.Field_18.CheckedChanged += new EventHandler(this.Field_18_CheckedChanged);
			this.Field_19.AutoSize = true;
			this.Field_19.BackColor = Color.Transparent;
			this.Field_19.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_19.ForeColor = Color.White;
			this.Field_19.Location = new Point(194, 179);
			this.Field_19.Name = "label17";
			this.Field_19.Size = new Size(22, 17);
			this.Field_19.TabIndex = 44;
			this.Field_19.Text = "H.";
			this.Field_20.AutoSize = true;
			this.Field_20.BackColor = Color.Transparent;
			this.Field_20.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_20.ForeColor = Color.White;
			this.Field_20.Location = new Point(255, 179);
			this.Field_20.Name = "label18";
			this.Field_20.Size = new Size(23, 17);
			this.Field_20.TabIndex = 45;
			this.Field_20.Text = "m.";
			this.Field_21.BackColor = Color.MediumAquamarine;
			this.Field_21.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_21.DropDownWidth = 35;
			this.Field_21.ForeColor = Color.Black;
			this.Field_21.FormattingEnabled = true;
			this.Field_21.Location = new Point(217, 151);
			this.Field_21.Name = "cb_Aminite6";
			this.Field_21.Size = new Size(35, 20);
			this.Field_21.TabIndex = 43;
			this.Field_22.BackColor = Color.MediumAquamarine;
			this.Field_22.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_22.DropDownWidth = 35;
			this.Field_22.ForeColor = Color.Black;
			this.Field_22.FormattingEnabled = true;
			this.Field_22.Location = new Point(160, 151);
			this.Field_22.Name = "cb_Ahour6";
			this.Field_22.Size = new Size(35, 20);
			this.Field_22.TabIndex = 42;
			this.Field_23.AutoSize = true;
			this.Field_23.BackColor = Color.Transparent;
			this.Field_23.Checked = true;
			this.Field_23.CheckState = CheckState.Checked;
			this.Field_23.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_23.ForeColor = Color.White;
			this.Field_23.Location = new Point(101, 151);
			this.Field_23.Name = "cb_rp6";
			this.Field_23.Size = new Size(49, 21);
			this.Field_23.TabIndex = 41;
			this.Field_23.Text = "Re.";
			this.Field_23.UseVisualStyleBackColor = false;
			this.Field_24.AutoSize = true;
			this.Field_24.BackColor = Color.Transparent;
			this.Field_24.Checked = true;
			this.Field_24.CheckState = CheckState.Checked;
			this.Field_24.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_24.ForeColor = Color.White;
			this.Field_24.Location = new Point(13, 151);
			this.Field_24.Name = "CBX_EnableAlarm6";
			this.Field_24.Size = new Size(83, 21);
			this.Field_24.TabIndex = 40;
			this.Field_24.Text = "Enable 6";
			this.Field_24.UseVisualStyleBackColor = false;
			this.Field_24.CheckedChanged += new EventHandler(this.Field_24_CheckedChanged);
			this.Field_25.AutoSize = true;
			this.Field_25.BackColor = Color.Transparent;
			this.Field_25.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_25.ForeColor = Color.White;
			this.Field_25.Location = new Point(194, 151);
			this.Field_25.Name = "label15";
			this.Field_25.Size = new Size(22, 17);
			this.Field_25.TabIndex = 38;
			this.Field_25.Text = "H.";
			this.Field_26.AutoSize = true;
			this.Field_26.BackColor = Color.Transparent;
			this.Field_26.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_26.ForeColor = Color.White;
			this.Field_26.Location = new Point(255, 151);
			this.Field_26.Name = "label16";
			this.Field_26.Size = new Size(23, 17);
			this.Field_26.TabIndex = 39;
			this.Field_26.Text = "m.";
			this.Field_27.BackColor = Color.MediumAquamarine;
			this.Field_27.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_27.DropDownWidth = 35;
			this.Field_27.ForeColor = Color.Black;
			this.Field_27.FormattingEnabled = true;
			this.Field_27.Location = new Point(217, 125);
			this.Field_27.Name = "cb_Aminite5";
			this.Field_27.Size = new Size(35, 20);
			this.Field_27.TabIndex = 37;
			this.Field_28.BackColor = Color.MediumAquamarine;
			this.Field_28.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_28.DropDownWidth = 35;
			this.Field_28.ForeColor = Color.Black;
			this.Field_28.FormattingEnabled = true;
			this.Field_28.Location = new Point(160, 125);
			this.Field_28.Name = "cb_Ahour5";
			this.Field_28.Size = new Size(35, 20);
			this.Field_28.TabIndex = 36;
			this.Field_29.AutoSize = true;
			this.Field_29.BackColor = Color.Transparent;
			this.Field_29.Checked = true;
			this.Field_29.CheckState = CheckState.Checked;
			this.Field_29.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_29.ForeColor = Color.White;
			this.Field_29.Location = new Point(101, 125);
			this.Field_29.Name = "cb_rp5";
			this.Field_29.Size = new Size(49, 21);
			this.Field_29.TabIndex = 35;
			this.Field_29.Text = "Re.";
			this.Field_29.UseVisualStyleBackColor = false;
			this.Field_30.AutoSize = true;
			this.Field_30.BackColor = Color.Transparent;
			this.Field_30.Checked = true;
			this.Field_30.CheckState = CheckState.Checked;
			this.Field_30.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_30.ForeColor = Color.White;
			this.Field_30.Location = new Point(13, 125);
			this.Field_30.Name = "CBX_EnableAlarm5";
			this.Field_30.Size = new Size(83, 21);
			this.Field_30.TabIndex = 34;
			this.Field_30.Text = "Enable 5";
			this.Field_30.UseVisualStyleBackColor = false;
			this.Field_30.CheckedChanged += new EventHandler(this.Field_30_CheckedChanged);
			this.Field_31.AutoSize = true;
			this.Field_31.BackColor = Color.Transparent;
			this.Field_31.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_31.ForeColor = Color.White;
			this.Field_31.Location = new Point(194, 125);
			this.Field_31.Name = "label2";
			this.Field_31.Size = new Size(22, 17);
			this.Field_31.TabIndex = 32;
			this.Field_31.Text = "H.";
			this.Field_32.AutoSize = true;
			this.Field_32.BackColor = Color.Transparent;
			this.Field_32.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_32.ForeColor = Color.White;
			this.Field_32.Location = new Point(255, 125);
			this.Field_32.Name = "label14";
			this.Field_32.Size = new Size(23, 17);
			this.Field_32.TabIndex = 33;
			this.Field_32.Text = "m.";
			this.Field_33.BackColor = Color.MediumAquamarine;
			this.Field_33.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_33.DropDownWidth = 35;
			this.Field_33.ForeColor = Color.Black;
			this.Field_33.FormattingEnabled = true;
			this.Field_33.Location = new Point(217, 72);
			this.Field_33.Name = "cb_Aminite3";
			this.Field_33.Size = new Size(35, 20);
			this.Field_33.TabIndex = 31;
			this.Field_34.BackColor = Color.MediumAquamarine;
			this.Field_34.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_34.DropDownWidth = 35;
			this.Field_34.ForeColor = Color.Black;
			this.Field_34.FormattingEnabled = true;
			this.Field_34.Location = new Point(160, 72);
			this.Field_34.Name = "cb_Ahour3";
			this.Field_34.Size = new Size(35, 20);
			this.Field_34.TabIndex = 30;
			this.Field_35.AutoSize = true;
			this.Field_35.BackColor = Color.Transparent;
			this.Field_35.Checked = true;
			this.Field_35.CheckState = CheckState.Checked;
			this.Field_35.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_35.ForeColor = Color.White;
			this.Field_35.Location = new Point(101, 72);
			this.Field_35.Name = "cb_rp3";
			this.Field_35.Size = new Size(49, 21);
			this.Field_35.TabIndex = 29;
			this.Field_35.Text = "Re.";
			this.Field_35.UseVisualStyleBackColor = false;
			this.Field_36.AutoSize = true;
			this.Field_36.BackColor = Color.Transparent;
			this.Field_36.Checked = true;
			this.Field_36.CheckState = CheckState.Checked;
			this.Field_36.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_36.ForeColor = Color.White;
			this.Field_36.Location = new Point(13, 72);
			this.Field_36.Name = "CBX_EnableAlarm3";
			this.Field_36.Size = new Size(83, 21);
			this.Field_36.TabIndex = 28;
			this.Field_36.Text = "Enable 3";
			this.Field_36.UseVisualStyleBackColor = false;
			this.Field_36.CheckedChanged += new EventHandler(this.Field_36_CheckedChanged);
			this.Field_37.AutoSize = true;
			this.Field_37.BackColor = Color.Transparent;
			this.Field_37.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_37.ForeColor = Color.White;
			this.Field_37.Location = new Point(194, 72);
			this.Field_37.Name = "label11";
			this.Field_37.Size = new Size(22, 17);
			this.Field_37.TabIndex = 26;
			this.Field_37.Text = "H.";
			this.Field_38.AutoSize = true;
			this.Field_38.BackColor = Color.Transparent;
			this.Field_38.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_38.ForeColor = Color.White;
			this.Field_38.Location = new Point(255, 72);
			this.Field_38.Name = "label3";
			this.Field_38.Size = new Size(23, 17);
			this.Field_38.TabIndex = 27;
			this.Field_38.Text = "m.";
			this.Field_39.BackColor = Color.MediumAquamarine;
			this.Field_39.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_39.DropDownWidth = 35;
			this.Field_39.ForeColor = Color.Black;
			this.Field_39.FormattingEnabled = true;
			this.Field_39.Location = new Point(217, 46);
			this.Field_39.Name = "cb_Aminite2";
			this.Field_39.Size = new Size(35, 20);
			this.Field_39.TabIndex = 25;
			this.Field_40.BackColor = Color.MediumAquamarine;
			this.Field_40.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_40.DropDownWidth = 35;
			this.Field_40.ForeColor = Color.Black;
			this.Field_40.FormattingEnabled = true;
			this.Field_40.Location = new Point(160, 46);
			this.Field_40.Name = "cb_Ahour2";
			this.Field_40.Size = new Size(35, 20);
			this.Field_40.TabIndex = 24;
			this.Field_41.AutoSize = true;
			this.Field_41.BackColor = Color.Transparent;
			this.Field_41.Checked = true;
			this.Field_41.CheckState = CheckState.Checked;
			this.Field_41.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_41.ForeColor = Color.White;
			this.Field_41.Location = new Point(101, 46);
			this.Field_41.Name = "cb_rp2";
			this.Field_41.Size = new Size(49, 21);
			this.Field_41.TabIndex = 23;
			this.Field_41.Text = "Re.";
			this.Field_41.UseVisualStyleBackColor = false;
			this.Field_42.AutoSize = true;
			this.Field_42.BackColor = Color.Transparent;
			this.Field_42.Checked = true;
			this.Field_42.CheckState = CheckState.Checked;
			this.Field_42.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_42.ForeColor = Color.White;
			this.Field_42.Location = new Point(13, 46);
			this.Field_42.Name = "CBX_EnableAlarm2";
			this.Field_42.Size = new Size(83, 21);
			this.Field_42.TabIndex = 22;
			this.Field_42.Text = "Enable 2";
			this.Field_42.UseVisualStyleBackColor = false;
			this.Field_42.CheckedChanged += new EventHandler(this.Field_42_CheckedChanged);
			this.Field_43.AutoSize = true;
			this.Field_43.BackColor = Color.Transparent;
			this.Field_43.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_43.ForeColor = Color.White;
			this.Field_43.Location = new Point(194, 46);
			this.Field_43.Name = "label9";
			this.Field_43.Size = new Size(22, 17);
			this.Field_43.TabIndex = 20;
			this.Field_43.Text = "H.";
			this.Field_44.AutoSize = true;
			this.Field_44.BackColor = Color.Transparent;
			this.Field_44.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_44.ForeColor = Color.White;
			this.Field_44.Location = new Point(255, 46);
			this.Field_44.Name = "label10";
			this.Field_44.Size = new Size(23, 17);
			this.Field_44.TabIndex = 21;
			this.Field_44.Text = "m.";
			this.Field_45.BackColor = Color.MediumAquamarine;
			this.Field_45.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_45.DropDownWidth = 35;
			this.Field_45.ForeColor = Color.Black;
			this.Field_45.FormattingEnabled = true;
			this.Field_45.Location = new Point(217, 98);
			this.Field_45.Name = "cb_Aminite4";
			this.Field_45.Size = new Size(35, 20);
			this.Field_45.TabIndex = 19;
			this.Field_46.BackColor = Color.MediumAquamarine;
			this.Field_46.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_46.DropDownWidth = 35;
			this.Field_46.ForeColor = Color.Black;
			this.Field_46.FormattingEnabled = true;
			this.Field_46.Location = new Point(160, 98);
			this.Field_46.Name = "cb_Ahour4";
			this.Field_46.Size = new Size(35, 20);
			this.Field_46.TabIndex = 18;
			this.Field_47.AutoSize = true;
			this.Field_47.BackColor = Color.Transparent;
			this.Field_47.Checked = true;
			this.Field_47.CheckState = CheckState.Checked;
			this.Field_47.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_47.ForeColor = Color.White;
			this.Field_47.Location = new Point(101, 98);
			this.Field_47.Name = "cb_rp4";
			this.Field_47.Size = new Size(49, 21);
			this.Field_47.TabIndex = 17;
			this.Field_47.Text = "Re.";
			this.Field_47.UseVisualStyleBackColor = false;
			this.Field_48.AutoSize = true;
			this.Field_48.BackColor = Color.Transparent;
			this.Field_48.Checked = true;
			this.Field_48.CheckState = CheckState.Checked;
			this.Field_48.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_48.ForeColor = Color.White;
			this.Field_48.Location = new Point(13, 98);
			this.Field_48.Name = "CBX_EnableAlarm4";
			this.Field_48.Size = new Size(83, 21);
			this.Field_48.TabIndex = 16;
			this.Field_48.Text = "Enable 4";
			this.Field_48.UseVisualStyleBackColor = false;
			this.Field_48.CheckedChanged += new EventHandler(this.Field_48_CheckedChanged);
			this.Field_49.AutoSize = true;
			this.Field_49.BackColor = Color.Transparent;
			this.Field_49.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_49.ForeColor = Color.White;
			this.Field_49.Location = new Point(194, 98);
			this.Field_49.Name = "label4";
			this.Field_49.Size = new Size(22, 17);
			this.Field_49.TabIndex = 14;
			this.Field_49.Text = "H.";
			this.Field_50.AutoSize = true;
			this.Field_50.BackColor = Color.Transparent;
			this.Field_50.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_50.ForeColor = Color.White;
			this.Field_50.Location = new Point(255, 98);
			this.Field_50.Name = "label5";
			this.Field_50.Size = new Size(23, 17);
			this.Field_50.TabIndex = 15;
			this.Field_50.Text = "m.";
			this.Field_51.BackColor = Color.MediumAquamarine;
			this.Field_51.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_51.DropDownWidth = 35;
			this.Field_51.ForeColor = Color.Black;
			this.Field_51.FormattingEnabled = true;
			this.Field_51.Location = new Point(217, 20);
			this.Field_51.Name = "cb_Aminite1";
			this.Field_51.Size = new Size(35, 20);
			this.Field_51.TabIndex = 13;
			this.Field_52.BackColor = Color.MediumAquamarine;
			this.Field_52.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_52.DropDownWidth = 35;
			this.Field_52.ForeColor = Color.Black;
			this.Field_52.FormattingEnabled = true;
			this.Field_52.Location = new Point(160, 20);
			this.Field_52.Name = "cb_Ahour1";
			this.Field_52.Size = new Size(35, 20);
			this.Field_52.TabIndex = 12;
			this.Field_53.AutoSize = true;
			this.Field_53.BackColor = Color.Transparent;
			this.Field_53.Checked = true;
			this.Field_53.CheckState = CheckState.Checked;
			this.Field_53.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_53.ForeColor = Color.White;
			this.Field_53.Location = new Point(101, 20);
			this.Field_53.Name = "cb_rp1";
			this.Field_53.Size = new Size(49, 21);
			this.Field_53.TabIndex = 11;
			this.Field_53.Text = "Re.";
			this.Field_53.UseVisualStyleBackColor = false;
			this.Field_54.AutoSize = true;
			this.Field_54.BackColor = Color.Transparent;
			this.Field_54.Checked = true;
			this.Field_54.CheckState = CheckState.Checked;
			this.Field_54.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_54.ForeColor = Color.White;
			this.Field_54.Location = new Point(13, 20);
			this.Field_54.Name = "CBX_EnableAlarm";
			this.Field_54.Size = new Size(83, 21);
			this.Field_54.TabIndex = 10;
			this.Field_54.Text = "Enable 1";
			this.Field_54.UseVisualStyleBackColor = false;
			this.Field_54.CheckedChanged += new EventHandler(this.Field_54_CheckedChanged);
			this.Field_55.AutoSize = true;
			this.Field_55.BackColor = Color.Transparent;
			this.Field_55.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_55.ForeColor = Color.White;
			this.Field_55.Location = new Point(194, 20);
			this.Field_55.Name = "label6";
			this.Field_55.Size = new Size(22, 17);
			this.Field_55.TabIndex = 8;
			this.Field_55.Text = "H.";
			this.Field_56.AutoSize = true;
			this.Field_56.BackColor = Color.Transparent;
			this.Field_56.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_56.ForeColor = Color.White;
			this.Field_56.Location = new Point(255, 20);
			this.Field_56.Name = "label7";
			this.Field_56.Size = new Size(23, 17);
			this.Field_56.TabIndex = 9;
			this.Field_56.Text = "m.";
			this.Field_58.BackColor = Color.Transparent;
			this.Field_58.Controls.Add(this.Field_04);
			this.Field_58.Controls.Add(this.Field_03);
			this.Field_58.Controls.Add(this.Field_07);
			this.Field_58.Controls.Add(this.Field_06);
			this.Field_58.ForeColor = Color.White;
			this.Field_58.Location = new Point(16, 32);
			this.Field_58.Name = "groupBox1";
			this.Field_58.Size = new Size(287, 72);
			this.Field_58.TabIndex = 18;
			this.Field_58.TabStop = false;
			this.Field_58.Text = "Time Set";
			this.Field_59.AutoSize = true;
			this.Field_59.BackColor = Color.Transparent;
			this.Field_59.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_59.ForeColor = Color.White;
			this.Field_59.Location = new Point(273, 363);
			this.Field_59.Name = "label8";
			this.Field_59.Size = new Size(25, 17);
			this.Field_59.TabIndex = 24;
			this.Field_59.Text = "Kg";
			this.Field_60.Location = new Point(236, 363);
			this.Field_60.Name = "tbx_Weight";
			this.Field_60.Size = new Size(31, 21);
			this.Field_60.TabIndex = 23;
			this.Field_61.AutoSize = true;
			this.Field_61.BackColor = Color.Transparent;
			this.Field_61.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_61.ForeColor = Color.White;
			this.Field_61.Location = new Point(172, 363);
			this.Field_61.Name = "label21";
			this.Field_61.Size = new Size(56, 17);
			this.Field_61.TabIndex = 22;
			this.Field_61.Text = "Weight:";
			this.Field_62.AutoSize = true;
			this.Field_62.BackColor = Color.Transparent;
			this.Field_62.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_62.ForeColor = Color.White;
			this.Field_62.Location = new Point(107, 364);
			this.Field_62.Name = "label22";
			this.Field_62.Size = new Size(28, 17);
			this.Field_62.TabIndex = 21;
			this.Field_62.Text = "CM";
			this.Field_63.Location = new Point(70, 363);
			this.Field_63.Name = "tbx_Height";
			this.Field_63.Size = new Size(31, 21);
			this.Field_63.TabIndex = 20;
			this.Field_64.AutoSize = true;
			this.Field_64.BackColor = Color.Transparent;
			this.Field_64.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_64.ForeColor = Color.White;
			this.Field_64.Location = new Point(18, 363);
			this.Field_64.Name = "label23";
			this.Field_64.Size = new Size(53, 17);
			this.Field_64.TabIndex = 19;
			this.Field_64.Text = "Height:";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackgroundImage = Class_04.imgoth;
			base.ClientSize = new Size(320, 480);
			base.ControlBox = false;
			base.Controls.Add(this.Field_59);
			base.Controls.Add(this.Field_60);
			base.Controls.Add(this.Field_61);
			base.Controls.Add(this.Field_62);
			base.Controls.Add(this.Field_63);
			base.Controls.Add(this.Field_64);
			base.Controls.Add(this.Field_58);
			base.Controls.Add(this.Field_08);
			base.Controls.Add(this.Field_05);
			base.Controls.Add(this.Field_02);
			base.FormBorderStyle = FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmConfig";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			base.Load += new EventHandler(this.Method_04);
			base.MouseDown += new MouseEventHandler(this.Method_02);
			base.FormClosing += new FormClosingEventHandler(this.Method_16);
			((ISupportInitialize)this.Field_02).EndInit();
			this.Field_08.ResumeLayout(false);
			this.Field_08.PerformLayout();
			this.Field_58.ResumeLayout(false);
			this.Field_58.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll")]
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
		[DllImport("pm.dll")]
		public static extern bool pm_init(int port);
		[DllImport("pm.dll")]
		public static extern bool pm_exit();
		private void Method_01()
		{
			Class_00.Class_01 method = new Class_00.Class_01(this.Method_06);
			base.BeginInvoke(method);
		}
		private void Method_02(object A_0, MouseEventArgs A_1)
		{
			Class_00.ReleaseCapture();
			Class_00.SendMessage(base.Handle, 274, 61458, 0);
		}
		private void Field_02_Click(object A_0, EventArgs A_1)
		{
			base.Close();
			GC.Collect();
		}
		private void Method_04(object A_0, EventArgs A_1)
		{
			ThreadStart threadStart = null;
			base.Show();
			this.Refresh();
			try
			{
				if (threadStart == null)
				{
					threadStart = new ThreadStart(this.Method_17);
				}
				Thread thread = new Thread(threadStart);
				thread.Start();
				this.Field_65.SetToolTip(this.Field_02, "Close Me");
				this.Field_65.SetToolTip(this.Field_54, "Enable Alarm Clock 1");
				this.Field_65.SetToolTip(this.Field_42, "Enable Alarm Clock 2");
				this.Field_65.SetToolTip(this.Field_36, "Enable Alarm Clock 3");
				this.Field_65.SetToolTip(this.Field_48, "Enable Alarm Clock 4");
				this.Field_65.SetToolTip(this.Field_30, "Enable Alarm Clock 5");
				this.Field_65.SetToolTip(this.Field_24, "Enable Alarm Clock 6");
				this.Field_65.SetToolTip(this.Field_18, "Enable Alarm Clock 7");
				this.Field_65.SetToolTip(this.Field_12, "Enable Alarm Clock 8");
				this.Field_65.SetToolTip(this.Field_53, "Repeat alarm clock every day");
				this.Field_65.SetToolTip(this.Field_41, "Repeat alarm clock every day");
				this.Field_65.SetToolTip(this.Field_35, "Repeat alarm clock every day");
				this.Field_65.SetToolTip(this.Field_47, "Repeat alarm clock every day");
				this.Field_65.SetToolTip(this.Field_29, "Repeat alarm clock every day");
				this.Field_65.SetToolTip(this.Field_23, "Repeat alarm clock every day");
				this.Field_65.SetToolTip(this.Field_17, "Repeat alarm clock every day");
				this.Field_65.SetToolTip(this.Field_11, "Repeat alarm clock every day");
			}
			catch
			{
			}
		}
		private void Method_05()
		{
			try
			{
				for (int i = 0; i < 24; i++)
				{
					string item;
					if (i.ToString().Length < 2)
					{
						item = "0" + i.ToString();
					}
					else
					{
						item = i.ToString();
					}
					this.Field_52.Items.Add(item);
					this.Field_40.Items.Add(item);
					this.Field_34.Items.Add(item);
					this.Field_46.Items.Add(item);
					this.Field_28.Items.Add(item);
					this.Field_22.Items.Add(item);
					this.Field_16.Items.Add(item);
					this.Field_10.Items.Add(item);
				}
				for (int j = 0; j < 60; j++)
				{
					string item2;
					if (j.ToString().Length < 2)
					{
						item2 = "0" + j.ToString();
					}
					else
					{
						item2 = j.ToString();
					}
					this.Field_51.Items.Add(item2);
					this.Field_39.Items.Add(item2);
					this.Field_33.Items.Add(item2);
					this.Field_45.Items.Add(item2);
					this.Field_27.Items.Add(item2);
					this.Field_21.Items.Add(item2);
					this.Field_15.Items.Add(item2);
					this.Field_09.Items.Add(item2);
				}
			}
			catch
			{
			}
		}
		private void Method_06()
		{
			this.Method_05();
			this.Field_05.Enabled = false;
			try
			{
				int port = Convert.ToInt32(Class_05.Field_03.Replace("COM", ""));
				Class_00.pm_init(port);
				PM_Time pM_Time = default(PM_Time);
				ImportHelper.GetTime(out pM_Time);
				if (pM_Time.year.ToString() == "0")
				{
					this.Field_04.Text = string.Concat(new string[]
					{
						pM_Time.year.ToString(),
						"-",
						((int)(pM_Time.month + 1)).ToString(),
						"-",
						((int)(pM_Time.day + 1)).ToString(),
						"  ",
						pM_Time.hour.ToString(),
						":",
						pM_Time.minute.ToString(),
						":",
						pM_Time.second.ToString()
					});
				}
				else
				{
					this.Field_04.Text = string.Concat(new string[]
					{
						"20",
						pM_Time.year.ToString(),
						"-",
						((int)(pM_Time.month + 1)).ToString(),
						"-",
						((int)(pM_Time.day + 1)).ToString(),
						"  ",
						pM_Time.hour.ToString(),
						":",
						pM_Time.minute.ToString(),
						":",
						pM_Time.second.ToString()
					});
				}
				this.Field_06.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				PM_Conf pM_Conf = default(PM_Conf);
				ImportHelper.GetPMConf(out pM_Conf);
				this.Field_63.Text = pM_Conf.height.ToString();
				this.Field_60.Text = pM_Conf.weight.ToString();
				Class_00.pm_exit();


				SPLib sPLib = new SPLib();
				sPLib.MyPortName = Class_05.Field_03;
				string[,] oldAlarmSet = sPLib.getOldAlarmSet();
				sPLib.Close();
				string text = "";
				string text2 = "";
				for (int i = 1; i < 8; i++)
				{
					text += oldAlarmSet[0, i];
				}
				text = "0" + text;
				int selectedIndex = Convert.ToInt32(text, 2);
				this.Field_51.SelectedIndex = selectedIndex;
				if (oldAlarmSet[0, 0] == "1")
				{
					this.Field_54.Checked = true;
				}
				else
				{
					this.Field_54.Checked = false;
					this.Field_52.Enabled = false;
					this.Field_51.Enabled = false;
				}
				for (int j = 1; j < 8; j++)
				{
					text2 += oldAlarmSet[1, j];
				}
				text2 = "0" + text2;
				int selectedIndex2 = Convert.ToInt32(text2, 2);
				this.Field_52.SelectedIndex = selectedIndex2;
				if (oldAlarmSet[1, 0] == "1")
				{
					this.Field_53.Checked = true;
				}
				else
				{
					this.Field_53.Checked = false;
				}
				text = "";
				text2 = "";
				for (int k = 1; k < 8; k++)
				{
					text += oldAlarmSet[2, k];
				}
				text = "0" + text;
				selectedIndex = Convert.ToInt32(text, 2);
				this.Field_39.SelectedIndex = selectedIndex;
				if (oldAlarmSet[2, 0] == "1")
				{
					this.Field_42.Checked = true;
				}
				else
				{
					this.Field_42.Checked = false;
					this.Field_40.Enabled = false;
					this.Field_39.Enabled = false;
				}
				for (int l = 1; l < 8; l++)
				{
					text2 += oldAlarmSet[3, l];
				}
				text2 = "0" + text2;
				selectedIndex2 = Convert.ToInt32(text2, 2);
				this.Field_40.SelectedIndex = selectedIndex2;
				if (oldAlarmSet[3, 0] == "1")
				{
					this.Field_41.Checked = true;
				}
				else
				{
					this.Field_41.Checked = false;
				}
				text = "";
				text2 = "";
				for (int m = 1; m < 8; m++)
				{
					text += oldAlarmSet[4, m];
				}
				text = "0" + text;
				selectedIndex = Convert.ToInt32(text, 2);
				this.Field_33.SelectedIndex = selectedIndex;
				if (oldAlarmSet[4, 0] == "1")
				{
					this.Field_36.Checked = true;
				}
				else
				{
					this.Field_36.Checked = false;
					this.Field_34.Enabled = false;
					this.Field_33.Enabled = false;
				}
				for (int n = 1; n < 8; n++)
				{
					text2 += oldAlarmSet[5, n];
				}
				text2 = "0" + text2;
				selectedIndex2 = Convert.ToInt32(text2, 2);
				this.Field_34.SelectedIndex = selectedIndex2;
				if (oldAlarmSet[5, 0] == "1")
				{
					this.Field_35.Checked = true;
				}
				else
				{
					this.Field_35.Checked = false;
				}
				text = "";
				text2 = "";
				for (int num = 1; num < 8; num++)
				{
					text += oldAlarmSet[6, num];
				}
				text = "0" + text;
				selectedIndex = Convert.ToInt32(text, 2);
				this.Field_45.SelectedIndex = selectedIndex;
				if (oldAlarmSet[6, 0] == "1")
				{
					this.Field_48.Checked = true;
				}
				else
				{
					this.Field_48.Checked = false;
					this.Field_46.Enabled = false;
					this.Field_45.Enabled = false;
				}
				for (int num2 = 1; num2 < 8; num2++)
				{
					text2 += oldAlarmSet[7, num2];
				}
				text2 = "0" + text2;
				selectedIndex2 = Convert.ToInt32(text2, 2);
				this.Field_46.SelectedIndex = selectedIndex2;
				if (oldAlarmSet[7, 0] == "1")
				{
					this.Field_47.Checked = true;
				}
				else
				{
					this.Field_47.Checked = false;
				}
				text = "";
				text2 = "";
				for (int num3 = 1; num3 < 8; num3++)
				{
					text += oldAlarmSet[8, num3];
				}
				text = "0" + text;
				selectedIndex = Convert.ToInt32(text, 2);
				this.Field_27.SelectedIndex = selectedIndex;
				if (oldAlarmSet[8, 0] == "1")
				{
					this.Field_30.Checked = true;
				}
				else
				{
					this.Field_30.Checked = false;
					this.Field_28.Enabled = false;
					this.Field_27.Enabled = false;
				}
				for (int num4 = 1; num4 < 8; num4++)
				{
					text2 += oldAlarmSet[9, num4];
				}
				text2 = "0" + text2;
				selectedIndex2 = Convert.ToInt32(text2, 2);
				this.Field_28.SelectedIndex = selectedIndex2;
				if (oldAlarmSet[9, 0] == "1")
				{
					this.Field_29.Checked = true;
				}
				else
				{
					this.Field_29.Checked = false;
				}
				text = "";
				text2 = "";
				for (int num5 = 1; num5 < 8; num5++)
				{
					text += oldAlarmSet[10, num5];
				}
				text = "0" + text;
				selectedIndex = Convert.ToInt32(text, 2);
				this.Field_21.SelectedIndex = selectedIndex;
				if (oldAlarmSet[10, 0] == "1")
				{
					this.Field_24.Checked = true;
				}
				else
				{
					this.Field_24.Checked = false;
					this.Field_22.Enabled = false;
					this.Field_21.Enabled = false;
				}
				for (int num6 = 1; num6 < 8; num6++)
				{
					text2 += oldAlarmSet[11, num6];
				}
				text2 = "0" + text2;
				selectedIndex2 = Convert.ToInt32(text2, 2);
				this.Field_22.SelectedIndex = selectedIndex2;
				if (oldAlarmSet[11, 0] == "1")
				{
					this.Field_23.Checked = true;
				}
				else
				{
					this.Field_23.Checked = false;
				}
				text = "";
				text2 = "";
				for (int num7 = 1; num7 < 8; num7++)
				{
					text += oldAlarmSet[12, num7];
				}
				text = "0" + text;
				selectedIndex = Convert.ToInt32(text, 2);
				this.Field_15.SelectedIndex = selectedIndex;
				if (oldAlarmSet[12, 0] == "1")
				{
					this.Field_18.Checked = true;
				}
				else
				{
					this.Field_18.Checked = false;
					this.Field_16.Enabled = false;
					this.Field_15.Enabled = false;
				}
				for (int num8 = 1; num8 < 8; num8++)
				{
					text2 += oldAlarmSet[13, num8];
				}
				text2 = "0" + text2;
				selectedIndex2 = Convert.ToInt32(text2, 2);
				this.Field_16.SelectedIndex = selectedIndex2;
				if (oldAlarmSet[13, 0] == "1")
				{
					this.Field_17.Checked = true;
				}
				else
				{
					this.Field_17.Checked = false;
				}
				text = "";
				text2 = "";
				for (int num9 = 1; num9 < 8; num9++)
				{
					text += oldAlarmSet[14, num9];
				}
				text = "0" + text;
				selectedIndex = Convert.ToInt32(text, 2);
				this.Field_09.SelectedIndex = selectedIndex;
				if (oldAlarmSet[14, 0] == "1")
				{
					this.Field_12.Checked = true;
				}
				else
				{
					this.Field_12.Checked = false;
					this.Field_10.Enabled = false;
					this.Field_09.Enabled = false;
				}
				for (int num10 = 1; num10 < 8; num10++)
				{
					text2 += oldAlarmSet[15, num10];
				}
				text2 = "0" + text2;
				selectedIndex2 = Convert.ToInt32(text2, 2);
				this.Field_10.SelectedIndex = selectedIndex2;
				if (oldAlarmSet[15, 0] == "1")
				{
					this.Field_11.Checked = true;
				}
				else
				{
					this.Field_11.Checked = false;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Please make sure the SmartBand is plugged in. \r\n If you replace another Sma呕噓Ba䱍d, pl䁁ase sign in again! ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				base.Close();
			}
			finally
			{
				this.Field_57.Visible = false;
				this.Field_05.Enabled = true;
				this.Field_02.Enabled = true;
			}
		}
		private void Field_05_Click(object A_0, EventArgs A_1)
		{
			try
			{
				int port = Convert.ToInt32(Class_05.Field_03.Replace("COM", ""));
				Class_00.pm_init(port);
				DateTime now = DateTime.Now;
				PM_Time pM_Time = default(PM_Time);
				pM_Time.year = Convert.ToByte(now.ToString("yy"));
				pM_Time.month = Convert.ToByte(now.Month - 1);
				pM_Time.day = Convert.ToByte(now.Day - 1);
				pM_Time.hour = Convert.ToByte(now.Hour);
				pM_Time.minute = Convert.ToByte(now.Minute);
				pM_Time.second = Convert.ToByte(now.Second);
				ImportHelper.SetTime(out pM_Time);
				PM_Conf pM_Conf = default(PM_Conf);
				pM_Conf.height = Convert.ToByte(this.Field_63.Text.ToString().Trim());
				pM_Conf.weight = Convert.ToByte(this.Field_60.Text.ToString().Trim());
				pM_Conf.age = Convert.ToByte(25);
				pM_Conf.female = true;
				pM_Conf.goal1 = Convert.ToByte(39);
				pM_Conf.goal0 = Convert.ToByte(16);
				ImportHelper.SetPMConf(ref pM_Conf);
				Alarm[] array = new Alarm[8];
				if (this.Field_53.Checked)
				{
					array[0].hour = Convert.ToByte(128 + this.Field_52.SelectedIndex);
				}
				else
				{
					array[0].hour = Convert.ToByte(this.Field_52.SelectedIndex);
				}
				if (this.Field_54.Checked)
				{
					array[0].minute = Convert.ToByte(128 + this.Field_51.SelectedIndex);
				}
				else
				{
					array[0].minute = Convert.ToByte(this.Field_51.SelectedIndex);
				}
				if (this.Field_41.Checked)
				{
					array[1].hour = Convert.ToByte(128 + this.Field_40.SelectedIndex);
				}
				else
				{
					array[1].hour = Convert.ToByte(this.Field_40.SelectedIndex);
				}
				if (this.Field_42.Checked)
				{
					array[1].minute = Convert.ToByte(128 + this.Field_39.SelectedIndex);
				}
				else
				{
					array[1].minute = Convert.ToByte(this.Field_39.SelectedIndex);
				}
				if (this.Field_35.Checked)
				{
					array[2].hour = Convert.ToByte(128 + this.Field_34.SelectedIndex);
				}
				else
				{
					array[2].hour = Convert.ToByte(this.Field_34.SelectedIndex);
				}
				if (this.Field_36.Checked)
				{
					array[2].minute = Convert.ToByte(128 + this.Field_33.SelectedIndex);
				}
				else
				{
					array[2].minute = Convert.ToByte(this.Field_33.SelectedIndex);
				}
				if (this.Field_47.Checked)
				{
					array[3].hour = Convert.ToByte(128 + this.Field_46.SelectedIndex);
				}
				else
				{
					array[3].hour = Convert.ToByte(this.Field_46.SelectedIndex);
				}
				if (this.Field_48.Checked)
				{
					array[3].minute = Convert.ToByte(128 + this.Field_45.SelectedIndex);
				}
				else
				{
					array[3].minute = Convert.ToByte(this.Field_45.SelectedIndex);
				}
				if (this.Field_29.Checked)
				{
					array[4].hour = Convert.ToByte(128 + this.Field_28.SelectedIndex);
				}
				else
				{
					array[4].hour = Convert.ToByte(this.Field_28.SelectedIndex);
				}
				if (this.Field_30.Checked)
				{
					array[4].minute = Convert.ToByte(128 + this.Field_27.SelectedIndex);
				}
				else
				{
					array[4].minute = Convert.ToByte(this.Field_27.SelectedIndex);
				}
				if (this.Field_23.Checked)
				{
					array[5].hour = Convert.ToByte(128 + this.Field_22.SelectedIndex);
				}
				else
				{
					array[5].hour = Convert.ToByte(this.Field_22.SelectedIndex);
				}
				if (this.Field_24.Checked)
				{
					array[5].minute = Convert.ToByte(128 + this.Field_21.SelectedIndex);
				}
				else
				{
					array[5].minute = Convert.ToByte(this.Field_21.SelectedIndex);
				}
				if (this.Field_17.Checked)
				{
					array[6].hour = Convert.ToByte(128 + this.Field_16.SelectedIndex);
				}
				else
				{
					array[6].hour = Convert.ToByte(this.Field_16.SelectedIndex);
				}
				if (this.Field_18.Checked)
				{
					array[6].minute = Convert.ToByte(128 + this.Field_15.SelectedIndex);
				}
				else
				{
					array[6].minute = Convert.ToByte(this.Field_15.SelectedIndex);
				}
				if (this.Field_11.Checked)
				{
					array[7].hour = Convert.ToByte(128 + this.Field_10.SelectedIndex);
				}
				else
				{
					array[7].hour = Convert.ToByte(this.Field_10.SelectedIndex);
				}
				if (this.Field_12.Checked)
				{
					array[7].minute = Convert.ToByte(128 + this.Field_09.SelectedIndex);
				}
				else
				{
					array[7].minute = Convert.ToByte(this.Field_09.SelectedIndex);
				}
				ImportHelper.SetAlarmClock1(array);
			}
			catch
			{
				MessageBox.Show("Failed for saving data. Please retry");
			}
			Class_00.pm_exit();
			base.Close();
		}
		private void Field_54_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_54.Checked)
			{
				this.Field_52.Enabled = true;
				this.Field_51.Enabled = true;
				this.Field_53.Enabled = true;
				return;
			}
			this.Field_52.Enabled = false;
			this.Field_51.Enabled = false;
			this.Field_53.Enabled = false;
		}
		private void Field_42_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_42.Checked)
			{
				this.Field_40.Enabled = true;
				this.Field_39.Enabled = true;
				this.Field_41.Enabled = true;
				return;
			}
			this.Field_40.Enabled = false;
			this.Field_39.Enabled = false;
			this.Field_41.Enabled = false;
		}
		private void Field_36_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_36.Checked)
			{
				this.Field_34.Enabled = true;
				this.Field_33.Enabled = true;
				this.Field_35.Enabled = true;
				return;
			}
			this.Field_34.Enabled = false;
			this.Field_33.Enabled = false;
			this.Field_35.Enabled = false;
		}
		private void Field_48_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_48.Checked)
			{
				this.Field_46.Enabled = true;
				this.Field_45.Enabled = true;
				this.Field_47.Enabled = true;
				return;
			}
			this.Field_46.Enabled = false;
			this.Field_45.Enabled = false;
			this.Field_47.Enabled = false;
		}
		private void Field_30_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_30.Checked)
			{
				this.Field_28.Enabled = true;
				this.Field_27.Enabled = true;
				this.Field_29.Enabled = true;
				return;
			}
			this.Field_28.Enabled = false;
			this.Field_27.Enabled = false;
			this.Field_29.Enabled = false;
		}
		private void Field_24_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_24.Checked)
			{
				this.Field_22.Enabled = true;
				this.Field_21.Enabled = true;
				this.Field_23.Enabled = true;
				return;
			}
			this.Field_22.Enabled = false;
			this.Field_21.Enabled = false;
			this.Field_23.Enabled = false;
		}
		private void Field_18_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_18.Checked)
			{
				this.Field_16.Enabled = true;
				this.Field_15.Enabled = true;
				this.Field_17.Enabled = true;
				return;
			}
			this.Field_16.Enabled = false;
			this.Field_15.Enabled = false;
			this.Field_17.Enabled = false;
		}
		private void Field_12_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_12.Checked)
			{
				this.Field_10.Enabled = true;
				this.Field_09.Enabled = true;
				this.Field_11.Enabled = true;
				return;
			}
			this.Field_10.Enabled = false;
			this.Field_09.Enabled = false;
			this.Field_11.Enabled = false;
		}
		private void Method_16(object A_0, FormClosingEventArgs A_1)
		{
			Class_00.pm_exit();
		}
		[CompilerGenerated]
		private void Method_17()
		{
			this.Method_01();
		}
	}
	public class frmConfigAlarm : Form
	{
		private delegate void Class_03();
		private IContainer Field_00;
		private Button Field_01;
		private CheckBox Field_02;
		private CheckBox Field_03;
		private CheckBox Field_04;
		private CheckBox Field_05;
		private CheckBox Field_06;
		private CheckBox Field_07;
		private CheckBox Field_08;
		private ComboBox Field_09;
		private ComboBox Field_10;
		private CheckBox Field_11;
		private Label Field_12;
		private Label Field_13;
		private CheckBox Field_14;
		private CheckBox Field_15;
		private CheckBox Field_16;
		private CheckBox Field_17;
		private CheckBox Field_18;
		private CheckBox Field_19;
		private CheckBox Field_20;
		private ComboBox Field_21;
		private ComboBox Field_22;
		private CheckBox Field_23;
		private Label Field_24;
		private Label Field_25;
		private CheckBox Field_26;
		private CheckBox Field_27;
		private CheckBox Field_28;
		private CheckBox Field_29;
		private CheckBox Field_30;
		private CheckBox Field_31;
		private CheckBox Field_32;
		private ComboBox Field_33;
		private ComboBox Field_34;
		private CheckBox Field_35;
		private Label Field_36;
		private Label Field_37;
		private CheckBox Field_38;
		private CheckBox Field_39;
		private CheckBox Field_40;
		private CheckBox Field_41;
		private CheckBox Field_42;
		private CheckBox Field_43;
		private CheckBox Field_44;
		private ComboBox Field_45;
		private ComboBox Field_46;
		private CheckBox Field_47;
		private Label Field_48;
		private Label Field_49;
		private CheckBox Field_50;
		private CheckBox Field_51;
		private CheckBox Field_52;
		private CheckBox Field_53;
		private CheckBox Field_54;
		private CheckBox Field_55;
		private CheckBox Field_56;
		private ComboBox Field_57;
		private ComboBox Field_58;
		private CheckBox Field_59;
		private Label Field_60;
		private Label Field_61;
		private CheckBox Field_62;
		private CheckBox Field_63;
		private CheckBox Field_64;
		private CheckBox Field_65;
		private CheckBox Field_66;
		private CheckBox Field_67;
		private CheckBox Field_68;
		private ComboBox Field_69;
		private ComboBox Field_70;
		private CheckBox Field_71;
		private Label Field_72;
		private Label Field_73;
		private CheckBox Field_74;
		private CheckBox Field_75;
		private CheckBox Field_76;
		private CheckBox Field_77;
		private CheckBox Field_78;
		private CheckBox Field_79;
		private CheckBox Field_80;
		private ComboBox Field_81;
		private ComboBox Field_82;
		private CheckBox Field_83;
		private Label Field_84;
		private Label Field_85;
		private CheckBox Field_86;
		private CheckBox Field_87;
		private CheckBox Field_88;
		private CheckBox Field_89;
		private CheckBox Field_90;
		private CheckBox Field_91;
		private CheckBox Field_92;
		private ComboBox Field_93;
		private ComboBox Field_94;
		private CheckBox Field_95;
		private Label Field_96;
		private Label Field_97;
		private PictureBox Field_98;
		private Label Field_99;
		private ToolTip Field_100;
		public frmConfigAlarm()
		{
			this.Method_00();
			new BitmapRegion();
			BitmapRegion.Method_00(this, Class_04.imgoth);
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.Field_00 != null)
			{
				this.Field_00.Dispose();
			}
			base.Dispose(disposing);
		}
		private void Method_00()
		{
			this.Field_00 = new Container();
			this.Field_01 = new Button();
			this.Field_02 = new CheckBox();
			this.Field_03 = new CheckBox();
			this.Field_04 = new CheckBox();
			this.Field_05 = new CheckBox();
			this.Field_06 = new CheckBox();
			this.Field_07 = new CheckBox();
			this.Field_08 = new CheckBox();
			this.Field_09 = new ComboBox();
			this.Field_10 = new ComboBox();
			this.Field_11 = new CheckBox();
			this.Field_12 = new Label();
			this.Field_13 = new Label();
			this.Field_14 = new CheckBox();
			this.Field_15 = new CheckBox();
			this.Field_16 = new CheckBox();
			this.Field_17 = new CheckBox();
			this.Field_18 = new CheckBox();
			this.Field_19 = new CheckBox();
			this.Field_20 = new CheckBox();
			this.Field_21 = new ComboBox();
			this.Field_22 = new ComboBox();
			this.Field_23 = new CheckBox();
			this.Field_24 = new Label();
			this.Field_25 = new Label();
			this.Field_26 = new CheckBox();
			this.Field_27 = new CheckBox();
			this.Field_28 = new CheckBox();
			this.Field_29 = new CheckBox();
			this.Field_30 = new CheckBox();
			this.Field_31 = new CheckBox();
			this.Field_32 = new CheckBox();
			this.Field_33 = new ComboBox();
			this.Field_34 = new ComboBox();
			this.Field_35 = new CheckBox();
			this.Field_36 = new Label();
			this.Field_37 = new Label();
			this.Field_38 = new CheckBox();
			this.Field_39 = new CheckBox();
			this.Field_40 = new CheckBox();
			this.Field_41 = new CheckBox();
			this.Field_42 = new CheckBox();
			this.Field_43 = new CheckBox();
			this.Field_44 = new CheckBox();
			this.Field_45 = new ComboBox();
			this.Field_46 = new ComboBox();
			this.Field_47 = new CheckBox();
			this.Field_48 = new Label();
			this.Field_49 = new Label();
			this.Field_50 = new CheckBox();
			this.Field_51 = new CheckBox();
			this.Field_52 = new CheckBox();
			this.Field_53 = new CheckBox();
			this.Field_54 = new CheckBox();
			this.Field_55 = new CheckBox();
			this.Field_56 = new CheckBox();
			this.Field_57 = new ComboBox();
			this.Field_58 = new ComboBox();
			this.Field_59 = new CheckBox();
			this.Field_60 = new Label();
			this.Field_61 = new Label();
			this.Field_62 = new CheckBox();
			this.Field_63 = new CheckBox();
			this.Field_64 = new CheckBox();
			this.Field_65 = new CheckBox();
			this.Field_66 = new CheckBox();
			this.Field_67 = new CheckBox();
			this.Field_68 = new CheckBox();
			this.Field_69 = new ComboBox();
			this.Field_70 = new ComboBox();
			this.Field_71 = new CheckBox();
			this.Field_72 = new Label();
			this.Field_73 = new Label();
			this.Field_74 = new CheckBox();
			this.Field_75 = new CheckBox();
			this.Field_76 = new CheckBox();
			this.Field_77 = new CheckBox();
			this.Field_78 = new CheckBox();
			this.Field_79 = new CheckBox();
			this.Field_80 = new CheckBox();
			this.Field_81 = new ComboBox();
			this.Field_82 = new ComboBox();
			this.Field_83 = new CheckBox();
			this.Field_84 = new Label();
			this.Field_85 = new Label();
			this.Field_86 = new CheckBox();
			this.Field_87 = new CheckBox();
			this.Field_88 = new CheckBox();
			this.Field_89 = new CheckBox();
			this.Field_90 = new CheckBox();
			this.Field_91 = new CheckBox();
			this.Field_92 = new CheckBox();
			this.Field_93 = new ComboBox();
			this.Field_94 = new ComboBox();
			this.Field_95 = new CheckBox();
			this.Field_96 = new Label();
			this.Field_97 = new Label();
			this.Field_98 = new PictureBox();
			this.Field_99 = new Label();
			this.Field_100 = new ToolTip(this.Field_00);
			((ISupportInitialize)this.Field_98).BeginInit();
			base.SuspendLayout();
			this.Field_01.BackgroundImage = Class_04.btok;
			this.Field_01.Enabled = false;
			this.Field_01.Location = new Point(41, 401);
			this.Field_01.Name = "button1";
			this.Field_01.Size = new Size(240, 50);
			this.Field_01.TabIndex = 21;
			this.Field_01.UseVisualStyleBackColor = true;
			this.Field_01.Click += new EventHandler(this.Field_01_Click);
			this.Field_02.AutoSize = true;
			this.Field_02.BackColor = Color.Transparent;
			this.Field_02.Enabled = false;
			this.Field_02.ForeColor = Color.Yellow;
			this.Field_02.Location = new Point(259, 376);
			this.Field_02.Name = "Cb_Sat8";
			this.Field_02.Size = new Size(48, 16);
			this.Field_02.TabIndex = 242;
			this.Field_02.Text = "Sat.";
			this.Field_02.UseVisualStyleBackColor = false;
			this.Field_03.AutoSize = true;
			this.Field_03.BackColor = Color.Transparent;
			this.Field_03.Enabled = false;
			this.Field_03.ForeColor = Color.Yellow;
			this.Field_03.Location = new Point(221, 376);
			this.Field_03.Name = "Cb_Fri8";
			this.Field_03.Size = new Size(48, 16);
			this.Field_03.TabIndex = 241;
			this.Field_03.Text = "Fri.";
			this.Field_03.UseVisualStyleBackColor = false;
			this.Field_04.AutoSize = true;
			this.Field_04.BackColor = Color.Transparent;
			this.Field_04.Enabled = false;
			this.Field_04.ForeColor = Color.Yellow;
			this.Field_04.Location = new Point(183, 376);
			this.Field_04.Name = "Cb_Thu8";
			this.Field_04.Size = new Size(48, 16);
			this.Field_04.TabIndex = 240;
			this.Field_04.Text = "Thu.";
			this.Field_04.UseVisualStyleBackColor = false;
			this.Field_05.AutoSize = true;
			this.Field_05.BackColor = Color.Transparent;
			this.Field_05.Enabled = false;
			this.Field_05.ForeColor = Color.Yellow;
			this.Field_05.Location = new Point(145, 376);
			this.Field_05.Name = "Cb_Wed8";
			this.Field_05.Size = new Size(48, 16);
			this.Field_05.TabIndex = 239;
			this.Field_05.Text = "Wed.";
			this.Field_05.UseVisualStyleBackColor = false;
			this.Field_06.AutoSize = true;
			this.Field_06.BackColor = Color.Transparent;
			this.Field_06.Enabled = false;
			this.Field_06.ForeColor = Color.Yellow;
			this.Field_06.Location = new Point(107, 376);
			this.Field_06.Name = "Cb_Tue8";
			this.Field_06.Size = new Size(48, 16);
			this.Field_06.TabIndex = 238;
			this.Field_06.Text = "Tue.";
			this.Field_06.UseVisualStyleBackColor = false;
			this.Field_07.AutoSize = true;
			this.Field_07.BackColor = Color.Transparent;
			this.Field_07.Enabled = false;
			this.Field_07.ForeColor = Color.Yellow;
			this.Field_07.Location = new Point(69, 376);
			this.Field_07.Name = "Cb_Mon8";
			this.Field_07.Size = new Size(48, 16);
			this.Field_07.TabIndex = 237;
			this.Field_07.Text = "Mon.";
			this.Field_07.UseVisualStyleBackColor = false;
			this.Field_08.AutoSize = true;
			this.Field_08.BackColor = Color.Transparent;
			this.Field_08.Enabled = false;
			this.Field_08.ForeColor = Color.Yellow;
			this.Field_08.Location = new Point(31, 376);
			this.Field_08.Name = "Cb_Sun8";
			this.Field_08.Size = new Size(48, 16);
			this.Field_08.TabIndex = 236;
			this.Field_08.Text = "Sun.";
			this.Field_08.UseVisualStyleBackColor = false;
			this.Field_09.BackColor = Color.MediumAquamarine;
			this.Field_09.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_09.DropDownWidth = 35;
			this.Field_09.Enabled = false;
			this.Field_09.ForeColor = Color.Black;
			this.Field_09.FormattingEnabled = true;
			this.Field_09.Location = new Point(184, 354);
			this.Field_09.Name = "cb_Aminite8";
			this.Field_09.Size = new Size(35, 20);
			this.Field_09.TabIndex = 235;
			this.Field_10.BackColor = Color.MediumAquamarine;
			this.Field_10.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_10.DropDownWidth = 35;
			this.Field_10.Enabled = false;
			this.Field_10.ForeColor = Color.Black;
			this.Field_10.FormattingEnabled = true;
			this.Field_10.Location = new Point(127, 354);
			this.Field_10.Name = "cb_Ahour8";
			this.Field_10.Size = new Size(35, 20);
			this.Field_10.TabIndex = 234;
			this.Field_11.AutoSize = true;
			this.Field_11.BackColor = Color.Transparent;
			this.Field_11.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_11.ForeColor = Color.White;
			this.Field_11.Location = new Point(31, 352);
			this.Field_11.Name = "CBX_EnableAlarm8";
			this.Field_11.Size = new Size(83, 21);
			this.Field_11.TabIndex = 233;
			this.Field_11.Text = "Enable 8";
			this.Field_11.UseVisualStyleBackColor = false;
			this.Field_11.CheckedChanged += new EventHandler(this.Field_11_CheckedChanged);
			this.Field_12.AutoSize = true;
			this.Field_12.BackColor = Color.Transparent;
			this.Field_12.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_12.ForeColor = Color.White;
			this.Field_12.Location = new Point(161, 354);
			this.Field_12.Name = "label15";
			this.Field_12.Size = new Size(22, 17);
			this.Field_12.TabIndex = 231;
			this.Field_12.Text = "H.";
			this.Field_13.AutoSize = true;
			this.Field_13.BackColor = Color.Transparent;
			this.Field_13.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_13.ForeColor = Color.White;
			this.Field_13.Location = new Point(222, 354);
			this.Field_13.Name = "label16";
			this.Field_13.Size = new Size(23, 17);
			this.Field_13.TabIndex = 232;
			this.Field_13.Text = "m.";
			this.Field_14.AutoSize = true;
			this.Field_14.BackColor = Color.Transparent;
			this.Field_14.Enabled = false;
			this.Field_14.ForeColor = Color.Yellow;
			this.Field_14.Location = new Point(259, 330);
			this.Field_14.Name = "Cb_Sat7";
			this.Field_14.Size = new Size(48, 16);
			this.Field_14.TabIndex = 230;
			this.Field_14.Text = "Sat.";
			this.Field_14.UseVisualStyleBackColor = false;
			this.Field_15.AutoSize = true;
			this.Field_15.BackColor = Color.Transparent;
			this.Field_15.Enabled = false;
			this.Field_15.ForeColor = Color.Yellow;
			this.Field_15.Location = new Point(221, 330);
			this.Field_15.Name = "Cb_Fri7";
			this.Field_15.Size = new Size(48, 16);
			this.Field_15.TabIndex = 229;
			this.Field_15.Text = "Fri.";
			this.Field_15.UseVisualStyleBackColor = false;
			this.Field_16.AutoSize = true;
			this.Field_16.BackColor = Color.Transparent;
			this.Field_16.Enabled = false;
			this.Field_16.ForeColor = Color.Yellow;
			this.Field_16.Location = new Point(183, 330);
			this.Field_16.Name = "Cb_Thu7";
			this.Field_16.Size = new Size(48, 16);
			this.Field_16.TabIndex = 228;
			this.Field_16.Text = "Thu.";
			this.Field_16.UseVisualStyleBackColor = false;
			this.Field_17.AutoSize = true;
			this.Field_17.BackColor = Color.Transparent;
			this.Field_17.Enabled = false;
			this.Field_17.ForeColor = Color.Yellow;
			this.Field_17.Location = new Point(145, 330);
			this.Field_17.Name = "Cb_Wed7";
			this.Field_17.Size = new Size(48, 16);
			this.Field_17.TabIndex = 227;
			this.Field_17.Text = "Wed.";
			this.Field_17.UseVisualStyleBackColor = false;
			this.Field_18.AutoSize = true;
			this.Field_18.BackColor = Color.Transparent;
			this.Field_18.Enabled = false;
			this.Field_18.ForeColor = Color.Yellow;
			this.Field_18.Location = new Point(107, 330);
			this.Field_18.Name = "Cb_Tue7";
			this.Field_18.Size = new Size(48, 16);
			this.Field_18.TabIndex = 226;
			this.Field_18.Text = "Tue.";
			this.Field_18.UseVisualStyleBackColor = false;
			this.Field_19.AutoSize = true;
			this.Field_19.BackColor = Color.Transparent;
			this.Field_19.Enabled = false;
			this.Field_19.ForeColor = Color.Yellow;
			this.Field_19.Location = new Point(69, 330);
			this.Field_19.Name = "Cb_Mon7";
			this.Field_19.Size = new Size(48, 16);
			this.Field_19.TabIndex = 225;
			this.Field_19.Text = "Mon.";
			this.Field_19.UseVisualStyleBackColor = false;
			this.Field_20.AutoSize = true;
			this.Field_20.BackColor = Color.Transparent;
			this.Field_20.Enabled = false;
			this.Field_20.ForeColor = Color.Yellow;
			this.Field_20.Location = new Point(31, 330);
			this.Field_20.Name = "Cb_Sun7";
			this.Field_20.Size = new Size(48, 16);
			this.Field_20.TabIndex = 224;
			this.Field_20.Text = "Sun.";
			this.Field_20.UseVisualStyleBackColor = false;
			this.Field_21.BackColor = Color.MediumAquamarine;
			this.Field_21.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_21.DropDownWidth = 35;
			this.Field_21.Enabled = false;
			this.Field_21.ForeColor = Color.Black;
			this.Field_21.FormattingEnabled = true;
			this.Field_21.Location = new Point(184, 308);
			this.Field_21.Name = "cb_Aminite7";
			this.Field_21.Size = new Size(35, 20);
			this.Field_21.TabIndex = 223;
			this.Field_22.BackColor = Color.MediumAquamarine;
			this.Field_22.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_22.DropDownWidth = 35;
			this.Field_22.Enabled = false;
			this.Field_22.ForeColor = Color.Black;
			this.Field_22.FormattingEnabled = true;
			this.Field_22.Location = new Point(127, 308);
			this.Field_22.Name = "cb_Ahour7";
			this.Field_22.Size = new Size(35, 20);
			this.Field_22.TabIndex = 222;
			this.Field_23.AutoSize = true;
			this.Field_23.BackColor = Color.Transparent;
			this.Field_23.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_23.ForeColor = Color.WhiteSmoke;
			this.Field_23.Location = new Point(31, 306);
			this.Field_23.Name = "CBX_EnableAlarm7";
			this.Field_23.Size = new Size(83, 21);
			this.Field_23.TabIndex = 221;
			this.Field_23.Text = "Enable 7";
			this.Field_23.UseVisualStyleBackColor = false;
			this.Field_23.CheckedChanged += new EventHandler(this.Field_23_CheckedChanged);
			this.Field_24.AutoSize = true;
			this.Field_24.BackColor = Color.Transparent;
			this.Field_24.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_24.ForeColor = Color.White;
			this.Field_24.Location = new Point(161, 308);
			this.Field_24.Name = "label13";
			this.Field_24.Size = new Size(22, 17);
			this.Field_24.TabIndex = 219;
			this.Field_24.Text = "H.";
			this.Field_25.AutoSize = true;
			this.Field_25.BackColor = Color.Transparent;
			this.Field_25.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_25.ForeColor = Color.White;
			this.Field_25.Location = new Point(222, 308);
			this.Field_25.Name = "label14";
			this.Field_25.Size = new Size(23, 17);
			this.Field_25.TabIndex = 220;
			this.Field_25.Text = "m.";
			this.Field_26.AutoSize = true;
			this.Field_26.BackColor = Color.Transparent;
			this.Field_26.Enabled = false;
			this.Field_26.ForeColor = Color.Yellow;
			this.Field_26.Location = new Point(259, 284);
			this.Field_26.Name = "Cb_Sat6";
			this.Field_26.Size = new Size(48, 16);
			this.Field_26.TabIndex = 218;
			this.Field_26.Text = "Sat.";
			this.Field_26.UseVisualStyleBackColor = false;
			this.Field_27.AutoSize = true;
			this.Field_27.BackColor = Color.Transparent;
			this.Field_27.Enabled = false;
			this.Field_27.ForeColor = Color.Yellow;
			this.Field_27.Location = new Point(221, 284);
			this.Field_27.Name = "Cb_Fri6";
			this.Field_27.Size = new Size(48, 16);
			this.Field_27.TabIndex = 217;
			this.Field_27.Text = "Fri.";
			this.Field_27.UseVisualStyleBackColor = false;
			this.Field_28.AutoSize = true;
			this.Field_28.BackColor = Color.Transparent;
			this.Field_28.Enabled = false;
			this.Field_28.ForeColor = Color.Yellow;
			this.Field_28.Location = new Point(183, 284);
			this.Field_28.Name = "Cb_Thu6";
			this.Field_28.Size = new Size(48, 16);
			this.Field_28.TabIndex = 216;
			this.Field_28.Text = "Thu.";
			this.Field_28.UseVisualStyleBackColor = false;
			this.Field_29.AutoSize = true;
			this.Field_29.BackColor = Color.Transparent;
			this.Field_29.Enabled = false;
			this.Field_29.ForeColor = Color.Yellow;
			this.Field_29.Location = new Point(145, 284);
			this.Field_29.Name = "Cb_Wed6";
			this.Field_29.Size = new Size(48, 16);
			this.Field_29.TabIndex = 215;
			this.Field_29.Text = "Wed.";
			this.Field_29.UseVisualStyleBackColor = false;
			this.Field_30.AutoSize = true;
			this.Field_30.BackColor = Color.Transparent;
			this.Field_30.Enabled = false;
			this.Field_30.ForeColor = Color.Yellow;
			this.Field_30.Location = new Point(107, 284);
			this.Field_30.Name = "Cb_Tue6";
			this.Field_30.Size = new Size(48, 16);
			this.Field_30.TabIndex = 214;
			this.Field_30.Text = "Tue.";
			this.Field_30.UseVisualStyleBackColor = false;
			this.Field_31.AutoSize = true;
			this.Field_31.BackColor = Color.Transparent;
			this.Field_31.Enabled = false;
			this.Field_31.ForeColor = Color.Yellow;
			this.Field_31.Location = new Point(69, 284);
			this.Field_31.Name = "Cb_Mon6";
			this.Field_31.Size = new Size(48, 16);
			this.Field_31.TabIndex = 213;
			this.Field_31.Text = "Mon.";
			this.Field_31.UseVisualStyleBackColor = false;
			this.Field_32.AutoSize = true;
			this.Field_32.BackColor = Color.Transparent;
			this.Field_32.Enabled = false;
			this.Field_32.ForeColor = Color.Yellow;
			this.Field_32.Location = new Point(31, 284);
			this.Field_32.Name = "Cb_Sun6";
			this.Field_32.Size = new Size(48, 16);
			this.Field_32.TabIndex = 212;
			this.Field_32.Text = "Sun.";
			this.Field_32.UseVisualStyleBackColor = false;
			this.Field_33.BackColor = Color.MediumAquamarine;
			this.Field_33.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_33.DropDownWidth = 35;
			this.Field_33.Enabled = false;
			this.Field_33.ForeColor = Color.Black;
			this.Field_33.FormattingEnabled = true;
			this.Field_33.Location = new Point(184, 262);
			this.Field_33.Name = "cb_Aminite6";
			this.Field_33.Size = new Size(35, 20);
			this.Field_33.TabIndex = 211;
			this.Field_34.BackColor = Color.MediumAquamarine;
			this.Field_34.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_34.DropDownWidth = 35;
			this.Field_34.Enabled = false;
			this.Field_34.ForeColor = Color.Black;
			this.Field_34.FormattingEnabled = true;
			this.Field_34.Location = new Point(127, 262);
			this.Field_34.Name = "cb_Ahour6";
			this.Field_34.Size = new Size(35, 20);
			this.Field_34.TabIndex = 210;
			this.Field_35.AutoSize = true;
			this.Field_35.BackColor = Color.Transparent;
			this.Field_35.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_35.ForeColor = Color.White;
			this.Field_35.Location = new Point(31, 260);
			this.Field_35.Name = "CBX_EnableAlarm6";
			this.Field_35.Size = new Size(83, 21);
			this.Field_35.TabIndex = 209;
			this.Field_35.Text = "Enable 6";
			this.Field_35.UseVisualStyleBackColor = false;
			this.Field_35.CheckedChanged += new EventHandler(this.Field_35_CheckedChanged);
			this.Field_36.AutoSize = true;
			this.Field_36.BackColor = Color.Transparent;
			this.Field_36.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_36.ForeColor = Color.White;
			this.Field_36.Location = new Point(161, 262);
			this.Field_36.Name = "label11";
			this.Field_36.Size = new Size(22, 17);
			this.Field_36.TabIndex = 207;
			this.Field_36.Text = "H.";
			this.Field_37.AutoSize = true;
			this.Field_37.BackColor = Color.Transparent;
			this.Field_37.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_37.ForeColor = Color.White;
			this.Field_37.Location = new Point(222, 262);
			this.Field_37.Name = "label12";
			this.Field_37.Size = new Size(23, 17);
			this.Field_37.TabIndex = 208;
			this.Field_37.Text = "m.";
			this.Field_38.AutoSize = true;
			this.Field_38.BackColor = Color.Transparent;
			this.Field_38.Enabled = false;
			this.Field_38.ForeColor = Color.Yellow;
			this.Field_38.Location = new Point(259, 238);
			this.Field_38.Name = "Cb_Sat5";
			this.Field_38.Size = new Size(48, 16);
			this.Field_38.TabIndex = 206;
			this.Field_38.Text = "Sat.";
			this.Field_38.UseVisualStyleBackColor = false;
			this.Field_39.AutoSize = true;
			this.Field_39.BackColor = Color.Transparent;
			this.Field_39.Enabled = false;
			this.Field_39.ForeColor = Color.Yellow;
			this.Field_39.Location = new Point(221, 238);
			this.Field_39.Name = "Cb_Fri5";
			this.Field_39.Size = new Size(48, 16);
			this.Field_39.TabIndex = 205;
			this.Field_39.Text = "Fri.";
			this.Field_39.UseVisualStyleBackColor = false;
			this.Field_40.AutoSize = true;
			this.Field_40.BackColor = Color.Transparent;
			this.Field_40.Enabled = false;
			this.Field_40.ForeColor = Color.Yellow;
			this.Field_40.Location = new Point(183, 238);
			this.Field_40.Name = "Cb_Thu5";
			this.Field_40.Size = new Size(48, 16);
			this.Field_40.TabIndex = 204;
			this.Field_40.Text = "Thu.";
			this.Field_40.UseVisualStyleBackColor = false;
			this.Field_41.AutoSize = true;
			this.Field_41.BackColor = Color.Transparent;
			this.Field_41.Enabled = false;
			this.Field_41.ForeColor = Color.Yellow;
			this.Field_41.Location = new Point(145, 238);
			this.Field_41.Name = "Cb_Wed5";
			this.Field_41.Size = new Size(48, 16);
			this.Field_41.TabIndex = 203;
			this.Field_41.Text = "Wed.";
			this.Field_41.UseVisualStyleBackColor = false;
			this.Field_42.AutoSize = true;
			this.Field_42.BackColor = Color.Transparent;
			this.Field_42.Enabled = false;
			this.Field_42.ForeColor = Color.Yellow;
			this.Field_42.Location = new Point(107, 238);
			this.Field_42.Name = "Cb_Tue5";
			this.Field_42.Size = new Size(48, 16);
			this.Field_42.TabIndex = 202;
			this.Field_42.Text = "Tue.";
			this.Field_42.UseVisualStyleBackColor = false;
			this.Field_43.AutoSize = true;
			this.Field_43.BackColor = Color.Transparent;
			this.Field_43.Enabled = false;
			this.Field_43.ForeColor = Color.Yellow;
			this.Field_43.Location = new Point(69, 238);
			this.Field_43.Name = "Cb_Mon5";
			this.Field_43.Size = new Size(48, 16);
			this.Field_43.TabIndex = 201;
			this.Field_43.Text = "Mon.";
			this.Field_43.UseVisualStyleBackColor = false;
			this.Field_44.AutoSize = true;
			this.Field_44.BackColor = Color.Transparent;
			this.Field_44.Enabled = false;
			this.Field_44.ForeColor = Color.Yellow;
			this.Field_44.Location = new Point(31, 238);
			this.Field_44.Name = "Cb_Sun5";
			this.Field_44.Size = new Size(48, 16);
			this.Field_44.TabIndex = 200;
			this.Field_44.Text = "Sun.";
			this.Field_44.UseVisualStyleBackColor = false;
			this.Field_45.BackColor = Color.MediumAquamarine;
			this.Field_45.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_45.DropDownWidth = 35;
			this.Field_45.Enabled = false;
			this.Field_45.ForeColor = Color.Black;
			this.Field_45.FormattingEnabled = true;
			this.Field_45.Location = new Point(184, 216);
			this.Field_45.Name = "cb_Aminite5";
			this.Field_45.Size = new Size(35, 20);
			this.Field_45.TabIndex = 199;
			this.Field_46.BackColor = Color.MediumAquamarine;
			this.Field_46.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_46.DropDownWidth = 35;
			this.Field_46.Enabled = false;
			this.Field_46.ForeColor = Color.Black;
			this.Field_46.FormattingEnabled = true;
			this.Field_46.Location = new Point(127, 216);
			this.Field_46.Name = "cb_Ahour5";
			this.Field_46.Size = new Size(35, 20);
			this.Field_46.TabIndex = 198;
			this.Field_47.AutoSize = true;
			this.Field_47.BackColor = Color.Transparent;
			this.Field_47.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_47.ForeColor = Color.White;
			this.Field_47.Location = new Point(31, 214);
			this.Field_47.Name = "CBX_EnableAlarm5";
			this.Field_47.Size = new Size(83, 21);
			this.Field_47.TabIndex = 197;
			this.Field_47.Text = "Enable 5";
			this.Field_47.UseVisualStyleBackColor = false;
			this.Field_47.CheckedChanged += new EventHandler(this.Field_47_CheckedChanged);
			this.Field_48.AutoSize = true;
			this.Field_48.BackColor = Color.Transparent;
			this.Field_48.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_48.ForeColor = Color.White;
			this.Field_48.Location = new Point(161, 216);
			this.Field_48.Name = "label9";
			this.Field_48.Size = new Size(22, 17);
			this.Field_48.TabIndex = 195;
			this.Field_48.Text = "H.";
			this.Field_49.AutoSize = true;
			this.Field_49.BackColor = Color.Transparent;
			this.Field_49.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_49.ForeColor = Color.White;
			this.Field_49.Location = new Point(222, 216);
			this.Field_49.Name = "label10";
			this.Field_49.Size = new Size(23, 17);
			this.Field_49.TabIndex = 196;
			this.Field_49.Text = "m.";
			this.Field_50.AutoSize = true;
			this.Field_50.BackColor = Color.Transparent;
			this.Field_50.Enabled = false;
			this.Field_50.ForeColor = Color.Yellow;
			this.Field_50.Location = new Point(259, 192);
			this.Field_50.Name = "Cb_Sat4";
			this.Field_50.Size = new Size(48, 16);
			this.Field_50.TabIndex = 194;
			this.Field_50.Text = "Sat.";
			this.Field_50.UseVisualStyleBackColor = false;
			this.Field_51.AutoSize = true;
			this.Field_51.BackColor = Color.Transparent;
			this.Field_51.Enabled = false;
			this.Field_51.ForeColor = Color.Yellow;
			this.Field_51.Location = new Point(221, 192);
			this.Field_51.Name = "Cb_Fri4";
			this.Field_51.Size = new Size(48, 16);
			this.Field_51.TabIndex = 193;
			this.Field_51.Text = "Fri.";
			this.Field_51.UseVisualStyleBackColor = false;
			this.Field_52.AutoSize = true;
			this.Field_52.BackColor = Color.Transparent;
			this.Field_52.Enabled = false;
			this.Field_52.ForeColor = Color.Yellow;
			this.Field_52.Location = new Point(183, 192);
			this.Field_52.Name = "Cb_Thu4";
			this.Field_52.Size = new Size(48, 16);
			this.Field_52.TabIndex = 192;
			this.Field_52.Text = "Thu.";
			this.Field_52.UseVisualStyleBackColor = false;
			this.Field_53.AutoSize = true;
			this.Field_53.BackColor = Color.Transparent;
			this.Field_53.Enabled = false;
			this.Field_53.ForeColor = Color.Yellow;
			this.Field_53.Location = new Point(145, 192);
			this.Field_53.Name = "Cb_Wed4";
			this.Field_53.Size = new Size(48, 16);
			this.Field_53.TabIndex = 191;
			this.Field_53.Text = "Wed.";
			this.Field_53.UseVisualStyleBackColor = false;
			this.Field_54.AutoSize = true;
			this.Field_54.BackColor = Color.Transparent;
			this.Field_54.Enabled = false;
			this.Field_54.ForeColor = Color.Yellow;
			this.Field_54.Location = new Point(107, 192);
			this.Field_54.Name = "Cb_Tue4";
			this.Field_54.Size = new Size(48, 16);
			this.Field_54.TabIndex = 190;
			this.Field_54.Text = "Tue.";
			this.Field_54.UseVisualStyleBackColor = false;
			this.Field_55.AutoSize = true;
			this.Field_55.BackColor = Color.Transparent;
			this.Field_55.Enabled = false;
			this.Field_55.ForeColor = Color.Yellow;
			this.Field_55.Location = new Point(69, 192);
			this.Field_55.Name = "Cb_Mon4";
			this.Field_55.Size = new Size(48, 16);
			this.Field_55.TabIndex = 189;
			this.Field_55.Text = "Mon.";
			this.Field_55.UseVisualStyleBackColor = false;
			this.Field_56.AutoSize = true;
			this.Field_56.BackColor = Color.Transparent;
			this.Field_56.Enabled = false;
			this.Field_56.ForeColor = Color.Yellow;
			this.Field_56.Location = new Point(31, 192);
			this.Field_56.Name = "Cb_Sun4";
			this.Field_56.Size = new Size(48, 16);
			this.Field_56.TabIndex = 188;
			this.Field_56.Text = "Sun.";
			this.Field_56.UseVisualStyleBackColor = false;
			this.Field_57.BackColor = Color.MediumAquamarine;
			this.Field_57.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_57.DropDownWidth = 35;
			this.Field_57.Enabled = false;
			this.Field_57.ForeColor = Color.Black;
			this.Field_57.FormattingEnabled = true;
			this.Field_57.Location = new Point(184, 170);
			this.Field_57.Name = "cb_Aminite4";
			this.Field_57.Size = new Size(35, 20);
			this.Field_57.TabIndex = 187;
			this.Field_58.BackColor = Color.MediumAquamarine;
			this.Field_58.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_58.DropDownWidth = 35;
			this.Field_58.Enabled = false;
			this.Field_58.ForeColor = Color.Black;
			this.Field_58.FormattingEnabled = true;
			this.Field_58.Location = new Point(127, 170);
			this.Field_58.Name = "cb_Ahour4";
			this.Field_58.Size = new Size(35, 20);
			this.Field_58.TabIndex = 186;
			this.Field_59.AutoSize = true;
			this.Field_59.BackColor = Color.Transparent;
			this.Field_59.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_59.ForeColor = Color.White;
			this.Field_59.Location = new Point(31, 168);
			this.Field_59.Name = "CBX_EnableAlarm4";
			this.Field_59.Size = new Size(83, 21);
			this.Field_59.TabIndex = 185;
			this.Field_59.Text = "Enable 4";
			this.Field_59.UseVisualStyleBackColor = false;
			this.Field_59.CheckedChanged += new EventHandler(this.Field_59_CheckedChanged);
			this.Field_60.AutoSize = true;
			this.Field_60.BackColor = Color.Transparent;
			this.Field_60.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_60.ForeColor = Color.White;
			this.Field_60.Location = new Point(161, 170);
			this.Field_60.Name = "label5";
			this.Field_60.Size = new Size(22, 17);
			this.Field_60.TabIndex = 183;
			this.Field_60.Text = "H.";
			this.Field_61.AutoSize = true;
			this.Field_61.BackColor = Color.Transparent;
			this.Field_61.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_61.ForeColor = Color.White;
			this.Field_61.Location = new Point(222, 170);
			this.Field_61.Name = "label8";
			this.Field_61.Size = new Size(23, 17);
			this.Field_61.TabIndex = 184;
			this.Field_61.Text = "m.";
			this.Field_62.AutoSize = true;
			this.Field_62.BackColor = Color.Transparent;
			this.Field_62.Enabled = false;
			this.Field_62.ForeColor = Color.Yellow;
			this.Field_62.Location = new Point(259, 146);
			this.Field_62.Name = "Cb_Sat3";
			this.Field_62.Size = new Size(48, 16);
			this.Field_62.TabIndex = 182;
			this.Field_62.Text = "Sat.";
			this.Field_62.UseVisualStyleBackColor = false;
			this.Field_63.AutoSize = true;
			this.Field_63.BackColor = Color.Transparent;
			this.Field_63.Enabled = false;
			this.Field_63.ForeColor = Color.Yellow;
			this.Field_63.Location = new Point(221, 146);
			this.Field_63.Name = "Cb_Fri3";
			this.Field_63.Size = new Size(48, 16);
			this.Field_63.TabIndex = 181;
			this.Field_63.Text = "Fri.";
			this.Field_63.UseVisualStyleBackColor = false;
			this.Field_64.AutoSize = true;
			this.Field_64.BackColor = Color.Transparent;
			this.Field_64.Enabled = false;
			this.Field_64.ForeColor = Color.Yellow;
			this.Field_64.Location = new Point(183, 146);
			this.Field_64.Name = "Cb_Thu3";
			this.Field_64.Size = new Size(48, 16);
			this.Field_64.TabIndex = 180;
			this.Field_64.Text = "Thu.";
			this.Field_64.UseVisualStyleBackColor = false;
			this.Field_65.AutoSize = true;
			this.Field_65.BackColor = Color.Transparent;
			this.Field_65.Enabled = false;
			this.Field_65.ForeColor = Color.Yellow;
			this.Field_65.Location = new Point(145, 146);
			this.Field_65.Name = "Cb_Wed3";
			this.Field_65.Size = new Size(48, 16);
			this.Field_65.TabIndex = 179;
			this.Field_65.Text = "Wed.";
			this.Field_65.UseVisualStyleBackColor = false;
			this.Field_66.AutoSize = true;
			this.Field_66.BackColor = Color.Transparent;
			this.Field_66.Enabled = false;
			this.Field_66.ForeColor = Color.Yellow;
			this.Field_66.Location = new Point(107, 146);
			this.Field_66.Name = "Cb_Tue3";
			this.Field_66.Size = new Size(48, 16);
			this.Field_66.TabIndex = 178;
			this.Field_66.Text = "Tue.";
			this.Field_66.UseVisualStyleBackColor = false;
			this.Field_67.AutoSize = true;
			this.Field_67.BackColor = Color.Transparent;
			this.Field_67.Enabled = false;
			this.Field_67.ForeColor = Color.Yellow;
			this.Field_67.Location = new Point(69, 146);
			this.Field_67.Name = "Cb_Mon3";
			this.Field_67.Size = new Size(48, 16);
			this.Field_67.TabIndex = 177;
			this.Field_67.Text = "Mon.";
			this.Field_67.UseVisualStyleBackColor = false;
			this.Field_68.AutoSize = true;
			this.Field_68.BackColor = Color.Transparent;
			this.Field_68.Enabled = false;
			this.Field_68.ForeColor = Color.Yellow;
			this.Field_68.Location = new Point(31, 146);
			this.Field_68.Name = "Cb_Sun3";
			this.Field_68.Size = new Size(48, 16);
			this.Field_68.TabIndex = 176;
			this.Field_68.Text = "Sun.";
			this.Field_68.UseVisualStyleBackColor = false;
			this.Field_69.BackColor = Color.MediumAquamarine;
			this.Field_69.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_69.DropDownWidth = 35;
			this.Field_69.Enabled = false;
			this.Field_69.ForeColor = Color.Black;
			this.Field_69.FormattingEnabled = true;
			this.Field_69.Location = new Point(184, 124);
			this.Field_69.Name = "cb_Aminite3";
			this.Field_69.Size = new Size(35, 20);
			this.Field_69.TabIndex = 175;
			this.Field_70.BackColor = Color.MediumAquamarine;
			this.Field_70.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_70.DropDownWidth = 35;
			this.Field_70.Enabled = false;
			this.Field_70.ForeColor = Color.Black;
			this.Field_70.FormattingEnabled = true;
			this.Field_70.Location = new Point(127, 124);
			this.Field_70.Name = "cb_Ahour3";
			this.Field_70.Size = new Size(35, 20);
			this.Field_70.TabIndex = 174;
			this.Field_71.AutoSize = true;
			this.Field_71.BackColor = Color.Transparent;
			this.Field_71.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_71.ForeColor = Color.White;
			this.Field_71.Location = new Point(31, 122);
			this.Field_71.Name = "CBX_EnableAlarm3";
			this.Field_71.Size = new Size(83, 21);
			this.Field_71.TabIndex = 173;
			this.Field_71.Text = "Enable 3";
			this.Field_71.UseVisualStyleBackColor = false;
			this.Field_71.CheckedChanged += new EventHandler(this.Field_71_CheckedChanged);
			this.Field_72.AutoSize = true;
			this.Field_72.BackColor = Color.Transparent;
			this.Field_72.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_72.ForeColor = Color.White;
			this.Field_72.Location = new Point(161, 124);
			this.Field_72.Name = "label3";
			this.Field_72.Size = new Size(22, 17);
			this.Field_72.TabIndex = 171;
			this.Field_72.Text = "H.";
			this.Field_73.AutoSize = true;
			this.Field_73.BackColor = Color.Transparent;
			this.Field_73.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_73.ForeColor = Color.White;
			this.Field_73.Location = new Point(222, 124);
			this.Field_73.Name = "label4";
			this.Field_73.Size = new Size(23, 17);
			this.Field_73.TabIndex = 172;
			this.Field_73.Text = "m.";
			this.Field_74.AutoSize = true;
			this.Field_74.BackColor = Color.Transparent;
			this.Field_74.Enabled = false;
			this.Field_74.ForeColor = Color.Yellow;
			this.Field_74.Location = new Point(259, 100);
			this.Field_74.Name = "Cb_Sat2";
			this.Field_74.Size = new Size(48, 16);
			this.Field_74.TabIndex = 170;
			this.Field_74.Text = "Sat.";
			this.Field_74.UseVisualStyleBackColor = false;
			this.Field_75.AutoSize = true;
			this.Field_75.BackColor = Color.Transparent;
			this.Field_75.Enabled = false;
			this.Field_75.ForeColor = Color.Yellow;
			this.Field_75.Location = new Point(221, 100);
			this.Field_75.Name = "Cb_Fri2";
			this.Field_75.Size = new Size(48, 16);
			this.Field_75.TabIndex = 169;
			this.Field_75.Text = "Fri.";
			this.Field_75.UseVisualStyleBackColor = false;
			this.Field_76.AutoSize = true;
			this.Field_76.BackColor = Color.Transparent;
			this.Field_76.Enabled = false;
			this.Field_76.ForeColor = Color.Yellow;
			this.Field_76.Location = new Point(183, 100);
			this.Field_76.Name = "Cb_Thu2";
			this.Field_76.Size = new Size(48, 16);
			this.Field_76.TabIndex = 168;
			this.Field_76.Text = "Thu.";
			this.Field_76.UseVisualStyleBackColor = false;
			this.Field_77.AutoSize = true;
			this.Field_77.BackColor = Color.Transparent;
			this.Field_77.Enabled = false;
			this.Field_77.ForeColor = Color.Yellow;
			this.Field_77.Location = new Point(145, 100);
			this.Field_77.Name = "Cb_Wed2";
			this.Field_77.Size = new Size(48, 16);
			this.Field_77.TabIndex = 167;
			this.Field_77.Text = "Wed.";
			this.Field_77.UseVisualStyleBackColor = false;
			this.Field_78.AutoSize = true;
			this.Field_78.BackColor = Color.Transparent;
			this.Field_78.Enabled = false;
			this.Field_78.ForeColor = Color.Yellow;
			this.Field_78.Location = new Point(107, 100);
			this.Field_78.Name = "Cb_Tue2";
			this.Field_78.Size = new Size(48, 16);
			this.Field_78.TabIndex = 166;
			this.Field_78.Text = "Tue.";
			this.Field_78.UseVisualStyleBackColor = false;
			this.Field_79.AutoSize = true;
			this.Field_79.BackColor = Color.Transparent;
			this.Field_79.Enabled = false;
			this.Field_79.ForeColor = Color.Yellow;
			this.Field_79.Location = new Point(69, 100);
			this.Field_79.Name = "Cb_Mon2";
			this.Field_79.Size = new Size(48, 16);
			this.Field_79.TabIndex = 165;
			this.Field_79.Text = "Mon.";
			this.Field_79.UseVisualStyleBackColor = false;
			this.Field_80.AutoSize = true;
			this.Field_80.BackColor = Color.Transparent;
			this.Field_80.Enabled = false;
			this.Field_80.ForeColor = Color.Yellow;
			this.Field_80.Location = new Point(31, 100);
			this.Field_80.Name = "Cb_Sun2";
			this.Field_80.Size = new Size(48, 16);
			this.Field_80.TabIndex = 164;
			this.Field_80.Text = "Sun.";
			this.Field_80.UseVisualStyleBackColor = false;
			this.Field_81.BackColor = Color.MediumAquamarine;
			this.Field_81.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_81.DropDownWidth = 35;
			this.Field_81.Enabled = false;
			this.Field_81.ForeColor = Color.Black;
			this.Field_81.FormattingEnabled = true;
			this.Field_81.Location = new Point(184, 78);
			this.Field_81.Name = "cb_Aminite2";
			this.Field_81.Size = new Size(35, 20);
			this.Field_81.TabIndex = 163;
			this.Field_82.BackColor = Color.MediumAquamarine;
			this.Field_82.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_82.DropDownWidth = 35;
			this.Field_82.Enabled = false;
			this.Field_82.ForeColor = Color.Black;
			this.Field_82.FormattingEnabled = true;
			this.Field_82.Location = new Point(127, 78);
			this.Field_82.Name = "cb_Ahour2";
			this.Field_82.Size = new Size(35, 20);
			this.Field_82.TabIndex = 162;
			this.Field_83.AutoSize = true;
			this.Field_83.BackColor = Color.Transparent;
			this.Field_83.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_83.ForeColor = Color.White;
			this.Field_83.Location = new Point(31, 76);
			this.Field_83.Name = "CBX_EnableAlarm2";
			this.Field_83.Size = new Size(83, 21);
			this.Field_83.TabIndex = 161;
			this.Field_83.Text = "Enable 2";
			this.Field_83.UseVisualStyleBackColor = false;
			this.Field_83.CheckedChanged += new EventHandler(this.Field_83_CheckedChanged);
			this.Field_84.AutoSize = true;
			this.Field_84.BackColor = Color.Transparent;
			this.Field_84.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_84.ForeColor = Color.White;
			this.Field_84.Location = new Point(161, 78);
			this.Field_84.Name = "label1";
			this.Field_84.Size = new Size(22, 17);
			this.Field_84.TabIndex = 159;
			this.Field_84.Text = "H.";
			this.Field_85.AutoSize = true;
			this.Field_85.BackColor = Color.Transparent;
			this.Field_85.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_85.ForeColor = Color.White;
			this.Field_85.Location = new Point(222, 78);
			this.Field_85.Name = "label2";
			this.Field_85.Size = new Size(23, 17);
			this.Field_85.TabIndex = 160;
			this.Field_85.Text = "m.";
			this.Field_86.AutoSize = true;
			this.Field_86.BackColor = Color.Transparent;
			this.Field_86.Enabled = false;
			this.Field_86.ForeColor = Color.Yellow;
			this.Field_86.Location = new Point(259, 54);
			this.Field_86.Name = "Cb_Sat1";
			this.Field_86.Size = new Size(48, 16);
			this.Field_86.TabIndex = 158;
			this.Field_86.Text = "Sat.";
			this.Field_86.UseVisualStyleBackColor = false;
			this.Field_87.AutoSize = true;
			this.Field_87.BackColor = Color.Transparent;
			this.Field_87.Enabled = false;
			this.Field_87.ForeColor = Color.Yellow;
			this.Field_87.Location = new Point(221, 54);
			this.Field_87.Name = "Cb_Fri1";
			this.Field_87.Size = new Size(48, 16);
			this.Field_87.TabIndex = 157;
			this.Field_87.Text = "Fri.";
			this.Field_87.UseVisualStyleBackColor = false;
			this.Field_88.AutoSize = true;
			this.Field_88.BackColor = Color.Transparent;
			this.Field_88.Enabled = false;
			this.Field_88.ForeColor = Color.Yellow;
			this.Field_88.Location = new Point(183, 54);
			this.Field_88.Name = "Cb_Thu1";
			this.Field_88.Size = new Size(48, 16);
			this.Field_88.TabIndex = 156;
			this.Field_88.Text = "Thu.";
			this.Field_88.UseVisualStyleBackColor = false;
			this.Field_89.AutoSize = true;
			this.Field_89.BackColor = Color.Transparent;
			this.Field_89.Enabled = false;
			this.Field_89.ForeColor = Color.Yellow;
			this.Field_89.Location = new Point(145, 54);
			this.Field_89.Name = "Cb_Wed1";
			this.Field_89.Size = new Size(48, 16);
			this.Field_89.TabIndex = 155;
			this.Field_89.Text = "Wed.";
			this.Field_89.UseVisualStyleBackColor = false;
			this.Field_90.AutoSize = true;
			this.Field_90.BackColor = Color.Transparent;
			this.Field_90.Enabled = false;
			this.Field_90.ForeColor = Color.Yellow;
			this.Field_90.Location = new Point(107, 54);
			this.Field_90.Name = "Cb_Tue1";
			this.Field_90.Size = new Size(48, 16);
			this.Field_90.TabIndex = 154;
			this.Field_90.Text = "Tue.";
			this.Field_90.UseVisualStyleBackColor = false;
			this.Field_91.AutoSize = true;
			this.Field_91.BackColor = Color.Transparent;
			this.Field_91.Enabled = false;
			this.Field_91.ForeColor = Color.Yellow;
			this.Field_91.Location = new Point(69, 54);
			this.Field_91.Name = "Cb_Mon1";
			this.Field_91.Size = new Size(48, 16);
			this.Field_91.TabIndex = 153;
			this.Field_91.Text = "Mon.";
			this.Field_91.UseVisualStyleBackColor = false;
			this.Field_92.AutoSize = true;
			this.Field_92.BackColor = Color.Transparent;
			this.Field_92.Enabled = false;
			this.Field_92.ForeColor = Color.Yellow;
			this.Field_92.Location = new Point(31, 54);
			this.Field_92.Name = "Cb_Sun1";
			this.Field_92.Size = new Size(48, 16);
			this.Field_92.TabIndex = 152;
			this.Field_92.Text = "Sun.";
			this.Field_92.UseVisualStyleBackColor = false;
			this.Field_93.BackColor = Color.MediumAquamarine;
			this.Field_93.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_93.DropDownWidth = 35;
			this.Field_93.Enabled = false;
			this.Field_93.ForeColor = Color.Black;
			this.Field_93.FormattingEnabled = true;
			this.Field_93.Location = new Point(184, 32);
			this.Field_93.Name = "cb_Aminite1";
			this.Field_93.Size = new Size(35, 20);
			this.Field_93.TabIndex = 151;
			this.Field_94.BackColor = Color.MediumAquamarine;
			this.Field_94.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_94.DropDownWidth = 35;
			this.Field_94.Enabled = false;
			this.Field_94.ForeColor = Color.Black;
			this.Field_94.FormattingEnabled = true;
			this.Field_94.Location = new Point(127, 32);
			this.Field_94.Name = "cb_Ahour1";
			this.Field_94.Size = new Size(35, 20);
			this.Field_94.TabIndex = 150;
			this.Field_95.AutoSize = true;
			this.Field_95.BackColor = Color.Transparent;
			this.Field_95.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_95.ForeColor = Color.White;
			this.Field_95.Location = new Point(31, 30);
			this.Field_95.Name = "CBX_EnableAlarm1";
			this.Field_95.Size = new Size(83, 21);
			this.Field_95.TabIndex = 149;
			this.Field_95.Text = "Enable 1";
			this.Field_95.UseVisualStyleBackColor = false;
			this.Field_95.CheckedChanged += new EventHandler(this.Field_95_CheckedChanged);
			this.Field_96.AutoSize = true;
			this.Field_96.BackColor = Color.Transparent;
			this.Field_96.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_96.ForeColor = Color.White;
			this.Field_96.Location = new Point(161, 32);
			this.Field_96.Name = "label6";
			this.Field_96.Size = new Size(22, 17);
			this.Field_96.TabIndex = 147;
			this.Field_96.Text = "H.";
			this.Field_97.AutoSize = true;
			this.Field_97.BackColor = Color.Transparent;
			this.Field_97.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_97.ForeColor = Color.White;
			this.Field_97.Location = new Point(222, 32);
			this.Field_97.Name = "label7";
			this.Field_97.Size = new Size(23, 17);
			this.Field_97.TabIndex = 148;
			this.Field_97.Text = "m.";
			this.Field_98.BackColor = Color.Transparent;
			this.Field_98.Cursor = Cursors.Hand;
			this.Field_98.Enabled = false;
			this.Field_98.Location = new Point(292, 5);
			this.Field_98.Name = "pictureBox1";
			this.Field_98.Size = new Size(22, 20);
			this.Field_98.TabIndex = 243;
			this.Field_98.TabStop = false;
			this.Field_98.Click += new EventHandler(this.Field_98_Click);
			this.Field_99.BackColor = Color.Transparent;
			this.Field_99.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.Field_99.ForeColor = Color.Yellow;
			this.Field_99.Location = new Point(27, 32);
			this.Field_99.Name = "lbl_wait";
			this.Field_99.Size = new Size(273, 360);
			this.Field_99.TabIndex = 244;
			this.Field_99.Text = "Please waiting...";
			base.AcceptButton = this.Field_01;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackgroundImage = Class_04.imgoth;
			base.ClientSize = new Size(320, 480);
			base.ControlBox = false;
			base.Controls.Add(this.Field_99);
			base.Controls.Add(this.Field_98);
			base.Controls.Add(this.Field_02);
			base.Controls.Add(this.Field_03);
			base.Controls.Add(this.Field_04);
			base.Controls.Add(this.Field_05);
			base.Controls.Add(this.Field_06);
			base.Controls.Add(this.Field_07);
			base.Controls.Add(this.Field_08);
			base.Controls.Add(this.Field_09);
			base.Controls.Add(this.Field_10);
			base.Controls.Add(this.Field_11);
			base.Controls.Add(this.Field_12);
			base.Controls.Add(this.Field_13);
			base.Controls.Add(this.Field_14);
			base.Controls.Add(this.Field_15);
			base.Controls.Add(this.Field_16);
			base.Controls.Add(this.Field_17);
			base.Controls.Add(this.Field_18);
			base.Controls.Add(this.Field_19);
			base.Controls.Add(this.Field_20);
			base.Controls.Add(this.Field_21);
			base.Controls.Add(this.Field_22);
			base.Controls.Add(this.Field_23);
			base.Controls.Add(this.Field_24);
			base.Controls.Add(this.Field_25);
			base.Controls.Add(this.Field_26);
			base.Controls.Add(this.Field_27);
			base.Controls.Add(this.Field_28);
			base.Controls.Add(this.Field_29);
			base.Controls.Add(this.Field_30);
			base.Controls.Add(this.Field_31);
			base.Controls.Add(this.Field_32);
			base.Controls.Add(this.Field_33);
			base.Controls.Add(this.Field_34);
			base.Controls.Add(this.Field_35);
			base.Controls.Add(this.Field_36);
			base.Controls.Add(this.Field_37);
			base.Controls.Add(this.Field_38);
			base.Controls.Add(this.Field_39);
			base.Controls.Add(this.Field_40);
			base.Controls.Add(this.Field_41);
			base.Controls.Add(this.Field_42);
			base.Controls.Add(this.Field_43);
			base.Controls.Add(this.Field_44);
			base.Controls.Add(this.Field_45);
			base.Controls.Add(this.Field_46);
			base.Controls.Add(this.Field_47);
			base.Controls.Add(this.Field_48);
			base.Controls.Add(this.Field_49);
			base.Controls.Add(this.Field_50);
			base.Controls.Add(this.Field_51);
			base.Controls.Add(this.Field_52);
			base.Controls.Add(this.Field_53);
			base.Controls.Add(this.Field_54);
			base.Controls.Add(this.Field_55);
			base.Controls.Add(this.Field_56);
			base.Controls.Add(this.Field_57);
			base.Controls.Add(this.Field_58);
			base.Controls.Add(this.Field_59);
			base.Controls.Add(this.Field_60);
			base.Controls.Add(this.Field_61);
			base.Controls.Add(this.Field_62);
			base.Controls.Add(this.Field_63);
			base.Controls.Add(this.Field_64);
			base.Controls.Add(this.Field_65);
			base.Controls.Add(this.Field_66);
			base.Controls.Add(this.Field_67);
			base.Controls.Add(this.Field_68);
			base.Controls.Add(this.Field_69);
			base.Controls.Add(this.Field_70);
			base.Controls.Add(this.Field_71);
			base.Controls.Add(this.Field_72);
			base.Controls.Add(this.Field_73);
			base.Controls.Add(this.Field_74);
			base.Controls.Add(this.Field_75);
			base.Controls.Add(this.Field_76);
			base.Controls.Add(this.Field_77);
			base.Controls.Add(this.Field_78);
			base.Controls.Add(this.Field_79);
			base.Controls.Add(this.Field_80);
			base.Controls.Add(this.Field_81);
			base.Controls.Add(this.Field_82);
			base.Controls.Add(this.Field_83);
			base.Controls.Add(this.Field_84);
			base.Controls.Add(this.Field_85);
			base.Controls.Add(this.Field_86);
			base.Controls.Add(this.Field_87);
			base.Controls.Add(this.Field_88);
			base.Controls.Add(this.Field_89);
			base.Controls.Add(this.Field_90);
			base.Controls.Add(this.Field_91);
			base.Controls.Add(this.Field_92);
			base.Controls.Add(this.Field_93);
			base.Controls.Add(this.Field_94);
			base.Controls.Add(this.Field_95);
			base.Controls.Add(this.Field_96);
			base.Controls.Add(this.Field_97);
			base.Controls.Add(this.Field_01);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "frmConfigAlarm";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			base.Load += new EventHandler(this.Method_07);
			((ISupportInitialize)this.Field_98).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		private void Method_01()
		{
			frmConfigAlarm.Class_03 method = new frmConfigAlarm.Class_03(this.Method_02);
			base.BeginInvoke(method);
		}
		private void Method_02()
		{
			try
			{
				this.Method_03();
				SPLib sPLib = new SPLib();
				sPLib.MyPortName = Class_05.Field_03;
				string[,] alarmSet = sPLib.getAlarmSet();
				for (int i = 0; i < 8; i++)
				{
					if (alarmSet[i, 1] == "1")
					{
						CheckBox checkBox = (CheckBox)base.Controls.Find("CBX_EnableAlarm" + (i + 1).ToString(), true)[0];
						checkBox.Checked = true;
						ComboBox comboBox = (ComboBox)base.Controls.Find("cb_Ahour" + (i + 1).ToString(), true)[0];
						comboBox.SelectedIndex = Convert.ToInt32(alarmSet[i, 9]);
						ComboBox comboBox2 = (ComboBox)base.Controls.Find("cb_Aminite" + (i + 1).ToString(), true)[0];
						comboBox2.SelectedIndex = Convert.ToInt32(alarmSet[i, 10]);
					}
					if (alarmSet[i, 2] == "1")
					{
						CheckBox checkBox2 = (CheckBox)base.Controls.Find("Cb_Sun" + (i + 1).ToString(), true)[0];
						checkBox2.Checked = true;
					}
					if (alarmSet[i, 3] == "1")
					{
						CheckBox checkBox3 = (CheckBox)base.Controls.Find("Cb_Mon" + (i + 1).ToString(), true)[0];
						checkBox3.Checked = true;
					}
					if (alarmSet[i, 4] == "1")
					{
						CheckBox checkBox4 = (CheckBox)base.Controls.Find("Cb_Tue" + (i + 1).ToString(), true)[0];
						checkBox4.Checked = true;
					}
					if (alarmSet[i, 5] == "1")
					{
						CheckBox checkBox5 = (CheckBox)base.Controls.Find("Cb_Wed" + (i + 1).ToString(), true)[0];
						checkBox5.Checked = true;
					}
					if (alarmSet[i, 6] == "1")
					{
						CheckBox checkBox6 = (CheckBox)base.Controls.Find("Cb_Thu" + (i + 1).ToString(), true)[0];
						checkBox6.Checked = true;
					}
					if (alarmSet[i, 7] == "1")
					{
						CheckBox checkBox7 = (CheckBox)base.Controls.Find("Cb_Fri" + (i + 1).ToString(), true)[0];
						checkBox7.Checked = true;
					}
					if (alarmSet[i, 8] == "1")
					{
						CheckBox checkBox8 = (CheckBox)base.Controls.Find("Cb_Sat" + (i + 1).ToString(), true)[0];
						checkBox8.Checked = true;
					}
				}
				sPLib.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Please make sure the SmartBand is plugged in. \r\n If you replace another Smar婗Band, pl䑅䙃se sign in again! ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				base.Close();
			}
			finally
			{
				this.Field_99.Visible = false;
				this.Field_98.Enabled = true;
				this.Field_01.Enabled = true;
			}
		}
		private void Method_03()
		{
			try
			{
				for (int i = 0; i < 24; i++)
				{
					string item;
					if (i.ToString().Length < 2)
					{
						item = "0" + i.ToString();
					}
					else
					{
						item = i.ToString();
					}
					this.Field_94.Items.Add(item);
					this.Field_82.Items.Add(item);
					this.Field_70.Items.Add(item);
					this.Field_58.Items.Add(item);
					this.Field_46.Items.Add(item);
					this.Field_34.Items.Add(item);
					this.Field_22.Items.Add(item);
					this.Field_10.Items.Add(item);
				}
				this.Field_94.SelectedIndex = 0;
				this.Field_82.SelectedIndex = 0;
				this.Field_70.SelectedIndex = 0;
				this.Field_58.SelectedIndex = 0;
				this.Field_46.SelectedIndex = 0;
				this.Field_34.SelectedIndex = 0;
				this.Field_22.SelectedIndex = 0;
				this.Field_10.SelectedIndex = 0;
				for (int j = 0; j < 60; j++)
				{
					string item2;
					if (j.ToString().Length < 2)
					{
						item2 = "0" + j.ToString();
					}
					else
					{
						item2 = j.ToString();
					}
					this.Field_93.Items.Add(item2);
					this.Field_81.Items.Add(item2);
					this.Field_69.Items.Add(item2);
					this.Field_57.Items.Add(item2);
					this.Field_45.Items.Add(item2);
					this.Field_33.Items.Add(item2);
					this.Field_21.Items.Add(item2);
					this.Field_09.Items.Add(item2);
				}
				this.Field_93.SelectedIndex = 0;
				this.Field_81.SelectedIndex = 0;
				this.Field_69.SelectedIndex = 0;
				this.Field_57.SelectedIndex = 0;
				this.Field_45.SelectedIndex = 0;
				this.Field_33.SelectedIndex = 0;
				this.Field_21.SelectedIndex = 0;
				this.Field_09.SelectedIndex = 0;
			}
			catch
			{
			}
		}
		private void Field_98_Click(object A_0, EventArgs A_1)
		{
			base.Close();
		}
		private void Field_95_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_95.Checked)
			{
				this.Field_94.Enabled = true;
				this.Field_93.Enabled = true;
				this.Field_92.Enabled = true;
				this.Field_91.Enabled = true;
				this.Field_90.Enabled = true;
				this.Field_89.Enabled = true;
				this.Field_88.Enabled = true;
				this.Field_87.Enabled = true;
				this.Field_86.Enabled = true;
				return;
			}
			this.Field_94.Enabled = false;
			this.Field_93.Enabled = false;
			this.Field_92.Enabled = false;
			this.Field_91.Enabled = false;
			this.Field_90.Enabled = false;
			this.Field_89.Enabled = false;
			this.Field_88.Enabled = false;
			this.Field_87.Enabled = false;
			this.Field_86.Enabled = false;
		}
		private void Field_83_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_83.Checked)
			{
				this.Field_82.Enabled = true;
				this.Field_81.Enabled = true;
				this.Field_80.Enabled = true;
				this.Field_79.Enabled = true;
				this.Field_78.Enabled = true;
				this.Field_77.Enabled = true;
				this.Field_76.Enabled = true;
				this.Field_75.Enabled = true;
				this.Field_74.Enabled = true;
				return;
			}
			this.Field_82.Enabled = false;
			this.Field_81.Enabled = false;
			this.Field_80.Enabled = false;
			this.Field_79.Enabled = false;
			this.Field_78.Enabled = false;
			this.Field_77.Enabled = false;
			this.Field_76.Enabled = false;
			this.Field_75.Enabled = false;
			this.Field_74.Enabled = false;
		}
		private void Method_07(object A_0, EventArgs A_1)
		{
			ThreadStart threadStart = null;
			base.Show();
			this.Refresh();
			try
			{
				if (threadStart == null)
				{
					threadStart = new ThreadStart(this.Method_15);
				}
				Thread thread = new Thread(threadStart);
				thread.Start();
				this.Field_100.SetToolTip(this.Field_98, "Close Me");
				this.Field_100.SetToolTip(this.Field_95, "Enable Alarm Clock 1");
				this.Field_100.SetToolTip(this.Field_83, "Enable Alarm Clock 2");
				this.Field_100.SetToolTip(this.Field_71, "Enable Alarm Clock 3");
				this.Field_100.SetToolTip(this.Field_59, "Enable Alarm Clock 4");
				this.Field_100.SetToolTip(this.Field_47, "Enable Alarm Clock 5");
				this.Field_100.SetToolTip(this.Field_35, "Enable Alarm Clock 6");
				this.Field_100.SetToolTip(this.Field_23, "Enable Alarm Clock 7");
				this.Field_100.SetToolTip(this.Field_11, "Enable Alarm Clock 8");
			}
			catch
			{
			}
		}
		private void Field_71_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_71.Checked)
			{
				this.Field_70.Enabled = true;
				this.Field_69.Enabled = true;
				this.Field_68.Enabled = true;
				this.Field_67.Enabled = true;
				this.Field_66.Enabled = true;
				this.Field_65.Enabled = true;
				this.Field_64.Enabled = true;
				this.Field_63.Enabled = true;
				this.Field_62.Enabled = true;
				return;
			}
			this.Field_70.Enabled = false;
			this.Field_69.Enabled = false;
			this.Field_68.Enabled = false;
			this.Field_67.Enabled = false;
			this.Field_66.Enabled = false;
			this.Field_65.Enabled = false;
			this.Field_64.Enabled = false;
			this.Field_63.Enabled = false;
			this.Field_62.Enabled = false;
		}
		private void Field_59_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_59.Checked)
			{
				this.Field_58.Enabled = true;
				this.Field_57.Enabled = true;
				this.Field_56.Enabled = true;
				this.Field_55.Enabled = true;
				this.Field_54.Enabled = true;
				this.Field_53.Enabled = true;
				this.Field_52.Enabled = true;
				this.Field_51.Enabled = true;
				this.Field_50.Enabled = true;
				return;
			}
			this.Field_58.Enabled = false;
			this.Field_57.Enabled = false;
			this.Field_56.Enabled = false;
			this.Field_55.Enabled = false;
			this.Field_54.Enabled = false;
			this.Field_53.Enabled = false;
			this.Field_52.Enabled = false;
			this.Field_51.Enabled = false;
			this.Field_50.Enabled = false;
		}
		private void Field_47_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_47.Checked)
			{
				this.Field_46.Enabled = true;
				this.Field_45.Enabled = true;
				this.Field_44.Enabled = true;
				this.Field_43.Enabled = true;
				this.Field_42.Enabled = true;
				this.Field_41.Enabled = true;
				this.Field_40.Enabled = true;
				this.Field_39.Enabled = true;
				this.Field_38.Enabled = true;
				return;
			}
			this.Field_46.Enabled = false;
			this.Field_45.Enabled = false;
			this.Field_44.Enabled = false;
			this.Field_43.Enabled = false;
			this.Field_42.Enabled = false;
			this.Field_41.Enabled = false;
			this.Field_40.Enabled = false;
			this.Field_39.Enabled = false;
			this.Field_38.Enabled = false;
		}
		private void Field_35_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_35.Checked)
			{
				this.Field_34.Enabled = true;
				this.Field_33.Enabled = true;
				this.Field_32.Enabled = true;
				this.Field_31.Enabled = true;
				this.Field_30.Enabled = true;
				this.Field_29.Enabled = true;
				this.Field_28.Enabled = true;
				this.Field_27.Enabled = true;
				this.Field_26.Enabled = true;
				return;
			}
			this.Field_34.Enabled = false;
			this.Field_33.Enabled = false;
			this.Field_32.Enabled = false;
			this.Field_31.Enabled = false;
			this.Field_30.Enabled = false;
			this.Field_29.Enabled = false;
			this.Field_28.Enabled = false;
			this.Field_27.Enabled = false;
			this.Field_26.Enabled = false;
		}
		private void Field_23_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_23.Checked)
			{
				this.Field_22.Enabled = true;
				this.Field_21.Enabled = true;
				this.Field_20.Enabled = true;
				this.Field_19.Enabled = true;
				this.Field_18.Enabled = true;
				this.Field_17.Enabled = true;
				this.Field_16.Enabled = true;
				this.Field_15.Enabled = true;
				this.Field_14.Enabled = true;
				return;
			}
			this.Field_22.Enabled = false;
			this.Field_21.Enabled = false;
			this.Field_20.Enabled = false;
			this.Field_19.Enabled = false;
			this.Field_18.Enabled = false;
			this.Field_17.Enabled = false;
			this.Field_16.Enabled = false;
			this.Field_15.Enabled = false;
			this.Field_14.Enabled = false;
		}
		private void Field_11_CheckedChanged(object A_0, EventArgs A_1)
		{
			if (this.Field_11.Checked)
			{
				this.Field_10.Enabled = true;
				this.Field_09.Enabled = true;
				this.Field_08.Enabled = true;
				this.Field_07.Enabled = true;
				this.Field_06.Enabled = true;
				this.Field_05.Enabled = true;
				this.Field_04.Enabled = true;
				this.Field_03.Enabled = true;
				this.Field_02.Enabled = true;
				return;
			}
			this.Field_10.Enabled = false;
			this.Field_09.Enabled = false;
			this.Field_08.Enabled = false;
			this.Field_07.Enabled = false;
			this.Field_06.Enabled = false;
			this.Field_05.Enabled = false;
			this.Field_04.Enabled = false;
			this.Field_03.Enabled = false;
			this.Field_02.Enabled = false;
		}
		private void Field_01_Click(object A_0, EventArgs A_1)
		{
			this.Field_01.Enabled = false;
			this.Field_99.Text = "Saving data,please waiting...";
			this.Field_99.Visible = true;
			try
			{
				string[,] array = new string[8, 11];
				for (int i = 0; i < 8; i++)
				{
					for (int j = 0; j < 11; j++)
					{
						array[i, j] = "0";
					}
				}
				for (int k = 0; k < 8; k++)
				{
					array[k, 0] = "00";
					CheckBox checkBox = (CheckBox)base.Controls.Find("CBX_EnableAlarm" + (k + 1).ToString(), true)[0];
					if (checkBox.Checked)
					{
						array[k, 1] = "1";
						CheckBox checkBox2 = (CheckBox)base.Controls.Find("Cb_Sun" + (k + 1).ToString(), true)[0];
						if (checkBox2.Checked)
						{
							array[k, 2] = "1";
						}
						CheckBox checkBox3 = (CheckBox)base.Controls.Find("Cb_Mon" + (k + 1).ToString(), true)[0];
						if (checkBox3.Checked)
						{
							array[k, 3] = "1";
						}
						CheckBox checkBox4 = (CheckBox)base.Controls.Find("Cb_Tue" + (k + 1).ToString(), true)[0];
						if (checkBox4.Checked)
						{
							array[k, 4] = "1";
						}
						CheckBox checkBox5 = (CheckBox)base.Controls.Find("Cb_Wed" + (k + 1).ToString(), true)[0];
						if (checkBox5.Checked)
						{
							array[k, 5] = "1";
						}
						CheckBox checkBox6 = (CheckBox)base.Controls.Find("Cb_Thu" + (k + 1).ToString(), true)[0];
						if (checkBox6.Checked)
						{
							array[k, 6] = "1";
						}
						CheckBox checkBox7 = (CheckBox)base.Controls.Find("Cb_Fri" + (k + 1).ToString(), true)[0];
						if (checkBox7.Checked)
						{
							array[k, 7] = "1";
						}
						CheckBox checkBox8 = (CheckBox)base.Controls.Find("Cb_Sat" + (k + 1).ToString(), true)[0];
						if (checkBox8.Checked)
						{
							array[k, 8] = "1";
						}
						ComboBox comboBox = (ComboBox)base.Controls.Find("cb_Ahour" + (k + 1).ToString(), true)[0];
						array[k, 9] = comboBox.SelectedIndex.ToString();
						ComboBox comboBox2 = (ComboBox)base.Controls.Find("cb_Aminite" + (k + 1).ToString(), true)[0];
						array[k, 10] = comboBox2.SelectedIndex.ToString();
					}
				}
				SPLib sPLib = new SPLib();
				sPLib.MyPortName = Class_05.Field_03;
				sPLib.setAlarmSet(array);
				sPLib.Close();
			}
			catch
			{
				MessageBox.Show("Failed for saving data. Please retry");
			}
			finally
			{
				base.Close();
			}
		}
		[CompilerGenerated]
		private void Method_15()
		{
			this.Method_01();
		}
	}
	public class frmConfigNew : Form
	{
		private delegate void Class_02();
		public const int WM_SYSCOMMAND = 274;
		public const int SC_MOVE = 61456;
		public const int Field_00 = 2;
		private IContainer Field_01;
		private Button Field_02;
		private GroupBox Field_03;
		private Label Field_04;
		private Label Field_05;
		private Label Field_06;
		private Label Field_07;
		private GroupBox Field_08;
		private Label Field_09;
		private TextBox Field_10;
		private Label Field_11;
		private Label Field_12;
		private TextBox Field_13;
		private Label Field_14;
		private LinkLabel Field_15;
		private PictureBox Field_16;
		private ComboBox Field_17;
		private Label Field_18;
		private Label Field_19;
		private TextBox Field_20;
		private Label Field_21;
		private Label Field_22;
		private TextBox Field_23;
		private Label Field_24;
		private Label Field_25;
		public frmConfigNew()
		{
			this.Method_08();
			new BitmapRegion();
			BitmapRegion.Method_00(this, Class_04.imgoth);
		}
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll")]
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
		private void Method_00()
		{
			frmConfigNew.Class_02 method = new frmConfigNew.Class_02(this.Method_01);
			base.BeginInvoke(method);
		}
		private void Method_01()
		{
			try
			{
				SPLib sPLib = new SPLib();
				sPLib.MyPortName = Class_05.Field_03;
				this.Field_04.Text = sPLib.GetTime();
				this.Field_07.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				SPLib.PersonCfg personConfig = sPLib.getPersonConfig();
				this.Field_13.Text = personConfig.height.ToString();
				this.Field_10.Text = personConfig.weight.ToString();
				this.Field_20.Text = personConfig.age.ToString();
				this.Field_23.Text = personConfig.goal.ToString();
				if (personConfig.female)
				{
					this.Field_17.SelectedIndex = 1;
				}
				else
				{
					this.Field_17.SelectedIndex = 0;
				}
				sPLib.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Please make sure the SmartBand is plugged in. \r\n If you replace another SmartBa䵎d, please sign in again! ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				base.Close();
			}
			finally
			{
				this.Field_25.Visible = false;
				this.Field_15.Enabled = true;
				this.Field_02.Enabled = true;
			}
		}
		private void Method_02(object A_0, MouseEventArgs A_1)
		{
			frmConfigNew.ReleaseCapture();
			frmConfigNew.SendMessage(base.Handle, 274, 61458, 0);
		}
		private void Field_16_Click(object A_0, EventArgs A_1)
		{
			base.Close();
		}
		private void Method_04(object A_0, EventArgs A_1)
		{
			ThreadStart threadStart = null;
			base.Show();
			this.Refresh();
			try
			{
				if (threadStart == null)
				{
					threadStart = new ThreadStart(this.Method_09);
				}
				Thread thread = new Thread(threadStart);
				thread.Start();
			}
			catch
			{
			}
		}
		private void Method_05(object A_0, EventArgs A_1)
		{
			this.Field_17.Focus();
		}
		private void Field_02_Click(object A_0, EventArgs A_1)
		{
			this.Field_02.Enabled = false;
			this.Field_25.Text = "Saving data,please waiting...";
			this.Field_25.Visible = true;
			try
			{
				if (int.Parse(this.Field_13.Text.Trim()) <= 0 || int.Parse(this.Field_13.Text.Trim()) > 250)
				{
					MessageBox.Show("Please input the correct data of Height!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (int.Parse(this.Field_10.Text.Trim()) <= 0 || int.Parse(this.Field_10.Text.Trim()) > 300)
				{
					MessageBox.Show("Please input the correct data of Weight!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (int.Parse(this.Field_20.Text.Trim()) <= 0 || int.Parse(this.Field_20.Text.Trim()) > 120)
				{
					MessageBox.Show("Please input the correct data of Age!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (int.Parse(this.Field_23.Text.Trim()) <= 0 || int.Parse(this.Field_23.Text.Trim()) > 65000)
				{
					MessageBox.Show("Please input the correct data of Step!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			catch
			{
				MessageBox.Show("Please input the correct data!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			try
			{
				SPLib sPLib = new SPLib();
				sPLib.MyPortName = Class_05.Field_03;
				sPLib.setTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
				SPLib.PersonCfg personConfig = default(SPLib.PersonCfg);
				personConfig.height = Convert.ToInt32(this.Field_13.Text.ToString().Trim());
				personConfig.weight = Convert.ToInt32(this.Field_10.Text.ToString().Trim());
				personConfig.age = Convert.ToInt32(this.Field_20.Text.ToString().Trim());
				if (this.Field_17.SelectedIndex == 0)
				{
					personConfig.female = false;
				}
				else
				{
					personConfig.female = true;
				}
				personConfig.goal = Convert.ToInt32(this.Field_23.Text.ToString().Trim());
				sPLib.setPersonConfig(personConfig);
				sPLib.Close();
			}
			catch
			{
				MessageBox.Show("Failed for saving data. Please retry");
			}
			finally
			{
				base.Close();
			}
		}
		private void Method_07(object A_0, LinkLabelLinkClickedEventArgs A_1)
		{
			frmConfigAlarm frmConfigAlarm = new frmConfigAlarm();
			frmConfigAlarm.ShowDialog();
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.Field_01 != null)
			{
				this.Field_01.Dispose();
			}
			base.Dispose(disposing);
		}
		private void Method_08()
		{
			this.Field_02 = new Button();
			this.Field_03 = new GroupBox();
			this.Field_04 = new Label();
			this.Field_05 = new Label();
			this.Field_06 = new Label();
			this.Field_07 = new Label();
			this.Field_08 = new GroupBox();
			this.Field_25 = new Label();
			this.Field_22 = new Label();
			this.Field_23 = new TextBox();
			this.Field_24 = new Label();
			this.Field_17 = new ComboBox();
			this.Field_18 = new Label();
			this.Field_19 = new Label();
			this.Field_20 = new TextBox();
			this.Field_21 = new Label();
			this.Field_09 = new Label();
			this.Field_10 = new TextBox();
			this.Field_11 = new Label();
			this.Field_12 = new Label();
			this.Field_13 = new TextBox();
			this.Field_14 = new Label();
			this.Field_15 = new LinkLabel();
			this.Field_16 = new PictureBox();
			this.Field_03.SuspendLayout();
			this.Field_08.SuspendLayout();
			((ISupportInitialize)this.Field_16).BeginInit();
			base.SuspendLayout();
			this.Field_02.BackgroundImage = Class_04.btok;
			this.Field_02.Enabled = false;
			this.Field_02.Location = new Point(38, 374);
			this.Field_02.Name = "button1";
			this.Field_02.Size = new Size(240, 50);
			this.Field_02.TabIndex = 0;
			this.Field_02.UseVisualStyleBackColor = true;
			this.Field_02.Click += new EventHandler(this.Field_02_Click);
			this.Field_03.BackColor = Color.Transparent;
			this.Field_03.Controls.Add(this.Field_04);
			this.Field_03.Controls.Add(this.Field_05);
			this.Field_03.Controls.Add(this.Field_06);
			this.Field_03.Controls.Add(this.Field_07);
			this.Field_03.ForeColor = Color.White;
			this.Field_03.Location = new Point(15, 55);
			this.Field_03.Name = "groupBox1";
			this.Field_03.Size = new Size(287, 72);
			this.Field_03.TabIndex = 22;
			this.Field_03.TabStop = false;
			this.Field_03.Text = "Time Set";
			this.Field_04.AutoSize = true;
			this.Field_04.BackColor = Color.Transparent;
			this.Field_04.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_04.ForeColor = Color.MistyRose;
			this.Field_04.Location = new Point(130, 17);
			this.Field_04.Name = "lbl_DeviceTime";
			this.Field_04.Size = new Size(74, 20);
			this.Field_04.TabIndex = 4;
			this.Field_04.Text = "Reading...";
			this.Field_05.AutoSize = true;
			this.Field_05.BackColor = Color.Transparent;
			this.Field_05.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_05.ForeColor = Color.White;
			this.Field_05.Location = new Point(11, 17);
			this.Field_05.Name = "label1";
			this.Field_05.Size = new Size(123, 20);
			this.Field_05.TabIndex = 3;
			this.Field_05.Text = "SmartBand Time:";
			this.Field_06.AutoSize = true;
			this.Field_06.BackColor = Color.Transparent;
			this.Field_06.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_06.ForeColor = Color.White;
			this.Field_06.Location = new Point(18, 43);
			this.Field_06.Name = "label13";
			this.Field_06.Size = new Size(116, 20);
			this.Field_06.TabIndex = 14;
			this.Field_06.Text = "Computer Time:";
			this.Field_07.AutoSize = true;
			this.Field_07.BackColor = Color.Transparent;
			this.Field_07.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_07.ForeColor = Color.FromArgb(255, 192, 128);
			this.Field_07.Location = new Point(130, 43);
			this.Field_07.Name = "label12";
			this.Field_07.Size = new Size(74, 20);
			this.Field_07.TabIndex = 15;
			this.Field_07.Text = "Reading...";
			this.Field_08.BackColor = Color.Transparent;
			this.Field_08.Controls.Add(this.Field_25);
			this.Field_08.Controls.Add(this.Field_22);
			this.Field_08.Controls.Add(this.Field_23);
			this.Field_08.Controls.Add(this.Field_24);
			this.Field_08.Controls.Add(this.Field_17);
			this.Field_08.Controls.Add(this.Field_18);
			this.Field_08.Controls.Add(this.Field_19);
			this.Field_08.Controls.Add(this.Field_20);
			this.Field_08.Controls.Add(this.Field_21);
			this.Field_08.Controls.Add(this.Field_09);
			this.Field_08.Controls.Add(this.Field_10);
			this.Field_08.Controls.Add(this.Field_11);
			this.Field_08.Controls.Add(this.Field_12);
			this.Field_08.Controls.Add(this.Field_13);
			this.Field_08.Controls.Add(this.Field_14);
			this.Field_08.ForeColor = Color.White;
			this.Field_08.Location = new Point(15, 224);
			this.Field_08.Name = "groupBox3";
			this.Field_08.Size = new Size(287, 116);
			this.Field_08.TabIndex = 24;
			this.Field_08.TabStop = false;
			this.Field_08.Text = "Personal Information";
			this.Field_25.BackColor = Color.Transparent;
			this.Field_25.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.Field_25.ForeColor = Color.Yellow;
			this.Field_25.Location = new Point(8, 13);
			this.Field_25.Name = "lbl_wait";
			this.Field_25.Size = new Size(273, 97);
			this.Field_25.TabIndex = 27;
			this.Field_25.Text = "Please waiting...";
			this.Field_22.AutoSize = true;
			this.Field_22.BackColor = Color.Transparent;
			this.Field_22.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_22.ForeColor = Color.White;
			this.Field_22.Location = new Point(203, 83);
			this.Field_22.Name = "label9";
			this.Field_22.Size = new Size(39, 20);
			this.Field_22.TabIndex = 63;
			this.Field_22.Text = "Step";
			this.Field_23.Location = new Point(107, 82);
			this.Field_23.Name = "tbx_Gaol";
			this.Field_23.Size = new Size(90, 21);
			this.Field_23.TabIndex = 62;
			this.Field_24.AutoSize = true;
			this.Field_24.BackColor = Color.Transparent;
			this.Field_24.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_24.ForeColor = Color.White;
			this.Field_24.Location = new Point(25, 82);
			this.Field_24.Name = "label10";
			this.Field_24.Size = new Size(77, 20);
			this.Field_24.TabIndex = 61;
			this.Field_24.Text = "Goal Step:";
			this.Field_17.BackColor = Color.MediumAquamarine;
			this.Field_17.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Field_17.DropDownWidth = 50;
			this.Field_17.ForeColor = Color.Black;
			this.Field_17.FormattingEnabled = true;
			this.Field_17.Items.AddRange(new object[]
			{
				"Male",
				"Female"
			});
			this.Field_17.Location = new Point(202, 50);
			this.Field_17.Name = "cb_Sex";
			this.Field_17.Size = new Size(68, 20);
			this.Field_17.TabIndex = 15;
			this.Field_18.AutoSize = true;
			this.Field_18.BackColor = Color.Transparent;
			this.Field_18.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_18.ForeColor = Color.White;
			this.Field_18.Location = new Point(138, 49);
			this.Field_18.Name = "label4";
			this.Field_18.Size = new Size(61, 20);
			this.Field_18.TabIndex = 21;
			this.Field_18.Text = "Gender:";
			this.Field_19.AutoSize = true;
			this.Field_19.BackColor = Color.Transparent;
			this.Field_19.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_19.ForeColor = Color.White;
			this.Field_19.Location = new Point(244, 17);
			this.Field_19.Name = "label2";
			this.Field_19.Size = new Size(37, 20);
			this.Field_19.TabIndex = 20;
			this.Field_19.Text = "year";
			this.Field_20.Location = new Point(203, 16);
			this.Field_20.Name = "tbx_Age";
			this.Field_20.Size = new Size(40, 21);
			this.Field_20.TabIndex = 19;
			this.Field_21.AutoSize = true;
			this.Field_21.BackColor = Color.Transparent;
			this.Field_21.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_21.ForeColor = Color.White;
			this.Field_21.Location = new Point(159, 16);
			this.Field_21.Name = "label3";
			this.Field_21.Size = new Size(39, 20);
			this.Field_21.TabIndex = 18;
			this.Field_21.Text = "Age:";
			this.Field_09.AutoSize = true;
			this.Field_09.BackColor = Color.Transparent;
			this.Field_09.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_09.ForeColor = Color.White;
			this.Field_09.Location = new Point(108, 50);
			this.Field_09.Name = "label7";
			this.Field_09.Size = new Size(27, 20);
			this.Field_09.TabIndex = 17;
			this.Field_09.Text = "Kg";
			this.Field_10.Location = new Point(71, 49);
			this.Field_10.Name = "tbx_Weight";
			this.Field_10.Size = new Size(40, 21);
			this.Field_10.TabIndex = 16;
			this.Field_11.AutoSize = true;
			this.Field_11.BackColor = Color.Transparent;
			this.Field_11.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_11.ForeColor = Color.White;
			this.Field_11.Location = new Point(12, 49);
			this.Field_11.Name = "label8";
			this.Field_11.Size = new Size(61, 20);
			this.Field_11.TabIndex = 15;
			this.Field_11.Text = "Weight:";
			this.Field_12.AutoSize = true;
			this.Field_12.BackColor = Color.Transparent;
			this.Field_12.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_12.ForeColor = Color.White;
			this.Field_12.Location = new Point(108, 17);
			this.Field_12.Name = "label6";
			this.Field_12.Size = new Size(32, 20);
			this.Field_12.TabIndex = 14;
			this.Field_12.Text = "CM";
			this.Field_13.Location = new Point(71, 16);
			this.Field_13.Name = "tbx_Height";
			this.Field_13.Size = new Size(40, 21);
			this.Field_13.TabIndex = 13;
			this.Field_14.AutoSize = true;
			this.Field_14.BackColor = Color.Transparent;
			this.Field_14.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_14.ForeColor = Color.White;
			this.Field_14.Location = new Point(15, 16);
			this.Field_14.Name = "label5";
			this.Field_14.Size = new Size(58, 20);
			this.Field_14.TabIndex = 12;
			this.Field_14.Text = "Height:";
			this.Field_15.AutoSize = true;
			this.Field_15.BackColor = Color.Transparent;
			this.Field_15.Enabled = false;
			this.Field_15.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.Field_15.ForeColor = Color.White;
			this.Field_15.LinkBehavior = LinkBehavior.HoverUnderline;
			this.Field_15.LinkColor = Color.White;
			this.Field_15.Location = new Point(62, 162);
			this.Field_15.Name = "linkLabel1";
			this.Field_15.Size = new Size(189, 29);
			this.Field_15.TabIndex = 25;
			this.Field_15.TabStop = true;
			this.Field_15.Text = "Alarm Clock";
			this.Field_15.LinkClicked += new LinkLabelLinkClickedEventHandler(this.Method_07);
			this.Field_16.BackColor = Color.Transparent;
			this.Field_16.Cursor = Cursors.Hand;
			this.Field_16.Location = new Point(292, 5);
			this.Field_16.Name = "pictureBox1";
			this.Field_16.Size = new Size(22, 20);
			this.Field_16.TabIndex = 26;
			this.Field_16.TabStop = false;
			this.Field_16.Click += new EventHandler(this.Field_16_Click);
			base.AcceptButton = this.Field_02;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackgroundImage = Class_04.imgoth;
			base.ClientSize = new Size(320, 480);
			base.ControlBox = false;
			base.Controls.Add(this.Field_16);
			base.Controls.Add(this.Field_15);
			base.Controls.Add(this.Field_08);
			base.Controls.Add(this.Field_03);
			base.Controls.Add(this.Field_02);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "frmConfigNew";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			base.Load += new EventHandler(this.Method_04);
			base.Activated += new EventHandler(this.Method_05);
			base.MouseDown += new MouseEventHandler(this.Method_02);
			this.Field_03.ResumeLayout(false);
			this.Field_03.PerformLayout();
			this.Field_08.ResumeLayout(false);
			this.Field_08.PerformLayout();
			((ISupportInitialize)this.Field_16).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		[CompilerGenerated]
		private void Method_09()
		{
			this.Method_00();
		}
	}
	public class frmLogin : Form
	{
		public const int WM_SYSCOMMAND = 274;
		public const int SC_MOVE = 61456;
		public const int Field_00 = 2;
		private IContainer Field_01;
		private PictureBox Field_02;
		private ToolTip Field_03;
		private Button Field_04;
		private CheckBox Field_05;
		private Label Field_06;
		private Label Field_07;
		private TextBox Field_08;
		private TextBox Field_09;
		private PictureBox Field_10;
		private PictureBox Field_11;
		private PictureBox Field_12;
		private Label Field_13;
		public frmLogin()
		{
			this.Method_00();
			new BitmapRegion();
			BitmapRegion.Method_00(this, Class_04.imglogin);
			this.Field_03.SetToolTip(this.Field_02, "Close Me");
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.Field_01 != null)
			{
				this.Field_01.Dispose();
			}
			base.Dispose(disposing);
		}
		private void Method_00()
		{
			this.Field_01 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmLogin));
			this.Field_02 = new PictureBox();
			this.Field_03 = new ToolTip(this.Field_01);
			this.Field_04 = new Button();
			this.Field_05 = new CheckBox();
			this.Field_06 = new Label();
			this.Field_07 = new Label();
			this.Field_08 = new TextBox();
			this.Field_09 = new TextBox();
			this.Field_10 = new PictureBox();
			this.Field_11 = new PictureBox();
			this.Field_12 = new PictureBox();
			this.Field_13 = new Label();
			((ISupportInitialize)this.Field_02).BeginInit();
			((ISupportInitialize)this.Field_10).BeginInit();
			((ISupportInitialize)this.Field_11).BeginInit();
			((ISupportInitialize)this.Field_12).BeginInit();
			base.SuspendLayout();
			this.Field_02.BackColor = Color.Transparent;
			this.Field_02.Cursor = Cursors.Hand;
			this.Field_02.Location = new Point(293, 4);
			this.Field_02.Name = "pictureBox1";
			this.Field_02.Size = new Size(22, 20);
			this.Field_02.TabIndex = 0;
			this.Field_02.TabStop = false;
			this.Field_02.Click += new EventHandler(this.Field_02_Click);
			this.Field_04.BackColor = SystemColors.Control;
			this.Field_04.BackgroundImage = Class_04.btlogin;
			this.Field_04.Cursor = Cursors.Hand;
			this.Field_04.FlatStyle = FlatStyle.Popup;
			this.Field_04.Location = new Point(41, 342);
			this.Field_04.Name = "button2";
			this.Field_04.Size = new Size(240, 50);
			this.Field_04.TabIndex = 24;
			this.Field_04.UseVisualStyleBackColor = false;
			this.Field_04.Click += new EventHandler(this.Field_04_Click);
			this.Field_05.AutoSize = true;
			this.Field_05.BackColor = Color.Transparent;
			this.Field_05.ForeColor = Color.White;
			this.Field_05.Location = new Point(130, 303);
			this.Field_05.Name = "checkBox1";
			this.Field_05.Size = new Size(90, 16);
			this.Field_05.TabIndex = 23;
			this.Field_05.Text = "Remember Me";
			this.Field_05.UseVisualStyleBackColor = false;
			this.Field_06.AutoSize = true;
			this.Field_06.BackColor = Color.Transparent;
			this.Field_06.Font = new Font("Arial", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_06.ForeColor = Color.White;
			this.Field_06.Location = new Point(59, 265);
			this.Field_06.Name = "label2";
			this.Field_06.Size = new Size(70, 14);
			this.Field_06.TabIndex = 22;
			this.Field_06.Text = "Password:";
			this.Field_07.AutoSize = true;
			this.Field_07.BackColor = Color.Transparent;
			this.Field_07.Font = new Font("Arial", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Field_07.ForeColor = Color.White;
			this.Field_07.Location = new Point(66, 222);
			this.Field_07.Name = "label1";
			this.Field_07.Size = new Size(63, 16);
			this.Field_07.TabIndex = 21;
			this.Field_07.Text = "Account:";
			this.Field_08.BorderStyle = BorderStyle.FixedSingle;
			this.Field_08.Font = new Font("Arial", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_08.ForeColor = Color.Gray;
			this.Field_08.Location = new Point(130, 261);
			this.Field_08.Name = "textBox2";
			this.Field_08.Size = new Size(129, 24);
			this.Field_08.TabIndex = 20;
			this.Field_08.UseSystemPasswordChar = true;
			this.Field_09.BorderStyle = BorderStyle.FixedSingle;
			this.Field_09.ForeColor = Color.Navy;
			this.Field_09.Location = new Point(130, 219);
			this.Field_09.Name = "textBox1";
			this.Field_09.Size = new Size(129, 21);
			this.Field_09.TabIndex = 19;
			this.Field_10.BackColor = Color.Transparent;
			this.Field_10.Cursor = Cursors.Hand;
			this.Field_10.Location = new Point(12, 451);
			this.Field_10.Name = "pictureBox2";
			this.Field_10.Size = new Size(98, 20);
			this.Field_10.TabIndex = 25;
			this.Field_10.TabStop = false;
			this.Field_10.Click += new EventHandler(this.Field_10_Click);
			this.Field_11.BackColor = Color.Transparent;
			this.Field_11.Cursor = Cursors.Hand;
			this.Field_11.Location = new Point(229, 451);
			this.Field_11.Name = "pictureBox3";
			this.Field_11.Size = new Size(79, 20);
			this.Field_11.TabIndex = 26;
			this.Field_11.TabStop = false;
			this.Field_11.Click += new EventHandler(this.Field_11_Click);
			this.Field_12.BackColor = Color.Transparent;
			this.Field_12.Cursor = Cursors.Hand;
			this.Field_12.Location = new Point(128, 451);
			this.Field_12.Name = "pictureBox4";
			this.Field_12.Size = new Size(92, 20);
			this.Field_12.TabIndex = 27;
			this.Field_12.TabStop = false;
			this.Field_12.Click += new EventHandler(this.Field_12_Click);
			this.Field_13.BackColor = Color.Transparent;
			this.Field_13.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.Field_13.ForeColor = Color.Yellow;
			this.Field_13.Location = new Point(62, 212);
			this.Field_13.Name = "lbl_wait";
			this.Field_13.Size = new Size(197, 118);
			this.Field_13.TabIndex = 28;
			this.Field_13.Text = "Please waiting...";
			this.Field_13.Visible = false;
			base.AcceptButton = this.Field_04;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackgroundImage = Class_04.imglogin;
			base.ClientSize = new Size(320, 480);
			base.ControlBox = false;
			base.Controls.Add(this.Field_13);
			base.Controls.Add(this.Field_12);
			base.Controls.Add(this.Field_11);
			base.Controls.Add(this.Field_10);
			base.Controls.Add(this.Field_04);
			base.Controls.Add(this.Field_05);
			base.Controls.Add(this.Field_06);
			base.Controls.Add(this.Field_07);
			base.Controls.Add(this.Field_08);
			base.Controls.Add(this.Field_09);
			base.Controls.Add(this.Field_02);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmLogin";
			base.StartPosition = FormStartPosition.CenterScreen;
			base.Load += new EventHandler(this.Method_11);
			base.MouseDown += new MouseEventHandler(this.Method_01);
			((ISupportInitialize)this.Field_02).EndInit();
			((ISupportInitialize)this.Field_10).EndInit();
			((ISupportInitialize)this.Field_11).EndInit();
			((ISupportInitialize)this.Field_12).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll")]
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
		private void Method_01(object A_0, MouseEventArgs A_1)
		{
			frmLogin.ReleaseCapture();
			frmLogin.SendMessage(base.Handle, 274, 61458, 0);
		}
		private void Method_02()
		{
			string moduleName = Process.GetCurrentProcess().MainModule.ModuleName;
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(moduleName);
			Process[] processesByName = Process.GetProcessesByName(fileNameWithoutExtension);
			if (processesByName.Length > 1)
			{
				MessageBox.Show("The program is running! ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Application.Exit();
			}
		}
		private void Field_02_Click(object A_0, EventArgs A_1)
		{
			Application.Exit();
		}
		private void Field_10_Click(object A_0, EventArgs A_1)
		{
			Process.Start("http://www.vidonn.com/en/user/reg.aspx");
		}
		private void Field_11_Click(object A_0, EventArgs A_1)
		{
			Process.Start("http://www.vidonn.com/en/");
		}
		private void Field_04_Click(object A_0, EventArgs A_1)
		{
			try
			{
				this.Field_13.Visible = true;
				this.Field_04.Enabled = false;
				if (!(this.Field_09.Text == "") && !(this.Field_08.Text == ""))
				{
					VidonnSync.com.vidonn.www.Service service = new VidonnSync.com.vidonn.www.Service();
					string a = service.CheckLogin(this.Field_09.Text.Trim(), this.Field_08.Text.Trim(), "PCSYNC", "VD2013");
					if (a != "true")
					{
						MessageBox.Show(" Account or password is wrong! \r\n Please try again!");
						this.Field_13.Visible = false;
						this.Field_04.Enabled = true;
					}
					else
					{
						if (this.Field_05.Checked)
						{
							this.Method_10(this.Field_09.Text.Trim(), this.Field_08.Text.Trim());
						}
						else
						{
							this.Method_10("", "");
						}
						Class_05.Field_00 = this.Field_09.Text.Trim();
						frmMain frmMain = new frmMain();
						frmMain.Show();
						base.Hide();
					}
				}
				else
				{
					MessageBox.Show("Please input the account and password!");
					this.Field_13.Visible = false;
					this.Field_04.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				this.Field_04.Enabled = true;
				MessageBox.Show(ex.Message);
			}
		}
		private void Method_07()
		{
			this.Method_09();
			this.Method_08();
		}
		private void Method_08()
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.vidonn.com/download/updateen.xml");
				string text = "";
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					Stream responseStream = httpWebResponse.GetResponseStream();
					byte[] array = new byte[httpWebResponse.ContentLength];
					responseStream.Read(array, 0, (int)httpWebResponse.ContentLength);
					text = Encoding.UTF8.GetString(array, 0, array.Length);
					responseStream.Close();
				}
				string text2 = Assembly.GetExecutingAssembly().GetName().Version.ToString();
				if (Convert.ToInt16(text.Replace(".", "")) > Convert.ToInt16(text2.Replace(".", "")))
				{
					MessageBox.Show("Dear users, the system detects your Vidonn SmartBand data synchroni扟ation 偑剏ftw䩇r䙃 has a new version, please download and update it!", "Version detection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					try
					{
						Process.Start("Update.exe");
						Application.Exit();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message + "You may need to reinstall the software!");
						base.Hide();
						Application.Exit();
					}
				}
			}
			catch
			{
			}
		}
		private void Method_09()
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				string text = Environment.CurrentDirectory + "\\logcfg.xml";
				if (File.Exists(text))
				{
					xmlDocument.Load(text);
					XmlNode xmlNode = xmlDocument.SelectSingleNode("logconfig").FirstChild;
					this.Field_05.Checked = !(xmlNode.InnerText == "");
					this.Field_09.Text = xmlNode.InnerText;
					xmlNode = xmlNode.NextSibling;
					if (xmlNode.InnerText != "")
					{
						this.Field_08.Text = FClass.Decrypt(xmlNode.InnerText);
					}
					xmlNode = xmlNode.NextSibling;
					Class_05.Field_02 = xmlNode.InnerText;
				}
			}
			catch (Exception ex)
			{
				FClass.SaveErrLogs(ex.ToString());
			}
		}
		private void Method_10(string A_0, string A_1)
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				string text = Environment.CurrentDirectory + "\\logcfg.xml";
				A_1 = FClass.Encrypt(A_1);
				if (File.Exists(text))
				{
					xmlDocument.Load(text);
					if (A_0 != "" && A_1 != "")
					{
						XmlNode xmlNode = xmlDocument.SelectSingleNode("logconfig").FirstChild;
						xmlNode.InnerText = A_0;
						xmlNode = xmlNode.NextSibling;
						xmlNode.InnerText = A_1;
					}
					else
					{
						XmlNode xmlNode = xmlDocument.SelectSingleNode("logconfig").FirstChild;
						xmlNode.InnerText = "";
						xmlNode = xmlNode.NextSibling;
						xmlNode.InnerText = "";
					}
					xmlDocument.Save(text);
				}
				else
				{
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.vidonn.com/download/logcfg.xml");
					Stream stream = null;
					using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
					{
						stream = httpWebResponse.GetResponseStream();
					}
					DataSet dataSet = new DataSet();
					dataSet.ReadXml(stream);
					dataSet.WriteXml(text);
					stream.Close();
				}
			}
			catch (Exception ex)
			{
				FClass.SaveErrLogs(ex.ToString());
			}
		}
		private void Method_11(object A_0, EventArgs A_1)
		{
			this.Method_02();
			base.Show();
			this.Refresh();
			Thread thread = new Thread(new ThreadStart(this.Method_13));
			thread.Start();
		}
		private void Field_12_Click(object A_0, EventArgs A_1)
		{
			Process.Start("http://www.vidonn.com/en/user/getpassword.aspx");
		}
		[CompilerGenerated]
		private void Method_13()
		{
			this.Method_07();
		}
	}
	public class frmMain : Form
	{
		public const int WM_SYSCOMMAND = 274;
		public const int SC_MOVE = 61456;
		public const int Field_00 = 2;
		public bool syncFlag;
		public DateTime syncLastTime = Convert.ToDateTime("1901-01-01 0:00:00");
		public bool ctrCloseing;
		private int Field_01;
		public int FirmWare;
		public string BMacss = "";
		private IContainer Field_02;
		private PictureBox Field_03;
		private PictureBox Field_04;
		private Button Field_05;
		private Label Field_06;
		private LinkLabel Field_07;
		private Label Field_08;
		private Label Field_09;
		private Label Field_10;
		private Button Field_11;
		private LinkLabel Field_12;
		private System.Windows.Forms.Timer Field_13;
		private Label Field_14;
		public frmMain()
		{
			this.Method_17();
			new BitmapRegion();
			BitmapRegion.Method_00(this, Class_04.imgoth);
		}
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll")]
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
		[DllImport("pm.dll")]
		public static extern bool pm_init(int port);
		[DllImport("pm.dll")]
		public static extern bool pm_exit();
		private bool Method_00()
		{
			bool result = false;
			this.Field_10.Visible = true;
			this.Field_09.Visible = true;
			this.Field_07.Enabled = false;
			string name = "Hardware\\\\DeviceMap\\\\SerialComm";
			RegistryKey localMachine = Registry.LocalMachine;
			try
			{
				RegistryKey registryKey = localMachine.OpenSubKey(name);
				string[] valueNames = registryKey.GetValueNames();
				Class_05.Field_03 = "";
				SPLib sPLib = new SPLib();
				string[] array = valueNames;
				for (int i = 0; i < array.Length; i++)
				{
					string name2 = array[i];
					string text = registryKey.GetValue(name2).ToString();
					Convert.ToInt32(text.Replace("COM", ""));
					sPLib.MyPortName = text;
					string text2 = sPLib.CheckVers();
					if (text2 != "")
					{
						this.FirmWare = Convert.ToInt32(text2);
						Class_05.Field_03 = text;
						this.Field_14.Text = "FW:0" + this.FirmWare.ToString();
						this.Field_08.Visible = false;
						this.Field_06.Visible = true;
						this.Field_11.Visible = false;
						this.Field_05.Visible = true;
						this.Field_07.Enabled = true;
						result = true;
						sPLib.Close();
						IL_149:
						if (Class_05.Field_03 == "")
						{
							this.Field_08.Visible = true;
							this.Field_06.Visible = false;
							this.Field_11.Visible = true;
							this.Field_05.Visible = false;
						}
						this.Field_10.Visible = false;
						this.Field_09.Visible = false;
						registryKey.Close();
						goto IL_1D9;
					}
					sPLib.Close();
				}
				goto IL_149;
			}
			catch
			{
				this.Field_10.Visible = false;
				this.Field_09.Visible = false;
				MessageBox.Show("SmartBand is not found, make sure the SmartBand has been linked to the US恡 por婗 of y之ur 䙃omputer,or to check whether the؃driver is installed correctly!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			IL_1D9:
			localMachine.Close();
			return result;
		}
		private void Field_03_Click(object A_0, EventArgs A_1)
		{
			Application.Exit();
		}
		private void Method_02(object A_0, MouseEventArgs A_1)
		{
			frmMain.ReleaseCapture();
			frmMain.SendMessage(base.Handle, 274, 61458, 0);
		}
		private void Method_03(object A_0, LinkLabelLinkClickedEventArgs A_1)
		{
			try
			{
				if (this.FirmWare == 2)
				{
					frmConfigNew frmConfigNew = new frmConfigNew();
					frmConfigNew.ShowDialog();
				}
				else
				{
					Class_00 class_ = new Class_00();
					class_.ShowDialog();
				}
			}
			catch
			{
			}
		}
		private void Method_04(object A_0, FormClosingEventArgs A_1)
		{
			if (!this.ctrCloseing)
			{
				DialogResult dialogResult = MessageBox.Show("Are you sure to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.No)
				{
					A_1.Cancel = true;
					return;
				}
				GC.Collect();
			}
		}
		private void Method_05(object A_0, EventArgs A_1)
		{
			this.Method_06();
		}
		private void Method_06()
		{
			try
			{
				if (this.Method_00())
				{
					this.Field_07.Enabled = false;
					if (this.FirmWare == 2)
					{
						SPLib sPLib = new SPLib();
						sPLib.MyPortName = Class_05.Field_03;
						string time = sPLib.GetTime();
						sPLib.Close();
						if (time.Substring(0, 3) == "200" || Convert.ToDateTime(time).ToShortDateString() != DateTime.Now.ToShortDateString())
						{
							MessageBox.Show("The date and time on your SmartBand is wrong, Please click the button 'OK' 兒o e䥊t䕆r the Configuration Page to synchronize your computer's time as the current time!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							frmConfigNew frmConfigNew = new frmConfigNew();
							frmConfigNew.ShowDialog();
						}
					}
					else
					{
						int port = Convert.ToInt32(Class_05.Field_03.Replace("COM", ""));
						frmMain.pm_init(port);
						PM_Time pM_Time = default(PM_Time);
						ImportHelper.GetTime(out pM_Time);
						frmMain.pm_exit();
						if (pM_Time.year.ToString() != DateTime.Now.ToString("yy") || ((int)(pM_Time.month + 1)).ToString() != DateTime.Now.Month.ToString() || ((int)(pM_Time.day + 1)).ToString() != DateTime.Now.Day.ToString())
						{
							MessageBox.Show("The date and time on your SmartBand is wrong, Please click the button 'OK' 兒o e䥊t䕆r the Configuration Page to synchronize your computer's time as the current time!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							Class_00 class_ = new Class_00();
							class_.ShowDialog();
						}
					}
					this.Field_07.Enabled = true;
				}
			}
			catch
			{
				frmMain.pm_exit();
			}
		}
		private void Field_05_Click(object A_0, EventArgs A_1)
		{
			int minutes = (DateTime.Now - this.syncLastTime).Minutes;
			if (minutes < 1)
			{
				MessageBox.Show("You have successfully synchronized the data of your SmartBand.\r\n For synchronizing ag䅂in, unplug the SmartBand and doĂsome exercise with the SmartBand.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			this.Field_05.Enabled = false;
			if (!this.Method_00())
			{
				this.Field_05.Enabled = true;
				return;
			}
			this.Field_05.Enabled = true;
			if (this.FirmWare == 2)
			{
				SPLib sPLib = new SPLib();
				sPLib.MyPortName = Class_05.Field_03;
				string bmac = sPLib.getBmac();
				if (bmac != "" && this.Method_14(bmac))
				{
					DialogResult dialogResult = MessageBox.Show("The system detects that you have changed an other SmartBand to synchroni彜e da兒a, t䭈䕆 data will be synchronized to theĂcurrent account:" + Class_05.Field_00 + "! \r\n Click 'OK' to continue , or click 'Cancel' to switch another account. ", "SmartBand Changed", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
					if (dialogResult == DialogResult.Cancel)
					{
						frmLogin frmLogin = new frmLogin();
						frmLogin.Show();
						this.ctrCloseing = true;
						base.Close();
						return;
					}
				}
				this.Field_05.Enabled = false;
				this.Field_10.Visible = true;
				this.Field_09.Visible = true;
				try
				{
					if (File.Exists(Environment.CurrentDirectory + "\\Sportdata.dll"))
					{
						File.Delete(Environment.CurrentDirectory + "\\Sportdata.dll");
					}
					string[,] sptdata = sPLib.getSptdata();
					for (int i = 0; i < 168; i++)
					{
						string a_ = string.Concat(new string[]
						{
							sptdata[i, 0],
							" ",
							sptdata[i, 1],
							":00:00|",
							sptdata[i, 2],
							"|",
							sptdata[i, 3],
							"|",
							sptdata[i, 4],
							"|0"
						});
						if ((Convert.ToInt32(sptdata[i, 2]) + Convert.ToInt32(sptdata[i, 3])).ToString() != "0" && Convert.ToDateTime(sptdata[i, 0]) > Convert.ToDateTime("2012-01-01 0:00:00"))
						{
							this.Method_08(a_);
						}
					}
				}
				catch
				{
					MessageBox.Show("Data read errors,please try again!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				sPLib.Close();
			}
			else
			{
				int port = Convert.ToInt32(Class_05.Field_03.Replace("COM", ""));
				frmMain.pm_init(port);
				if (this.Method_13())
				{
					DialogResult dialogResult2 = MessageBox.Show("The system detects that you have changed an other SmartBand to synchroni彜e da兒a, t䭈䕆 data will be synchronized to theĂcurrent account:" + Class_05.Field_00 + "! \r\n Click 'OK' to continue , or click 'Cancel' to switch another account. ", "SmartBand Changed", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
					if (dialogResult2 == DialogResult.Cancel)
					{
						frmMain.pm_exit();
						frmLogin frmLogin2 = new frmLogin();
						frmLogin2.Show();
						this.ctrCloseing = true;
						base.Close();
						return;
					}
				}
				this.Field_05.Enabled = false;
				this.Field_10.Visible = true;
				this.Field_09.Visible = true;
				try
				{
					string b = this.Method_09();
					while (true)
					{
						PM_Stat pM_Stat = default(PM_Stat);
						ImportHelper.GetPMStat(out pM_Stat);
						string text = string.Concat(new string[]
						{
							"20",
							pM_Stat.year.ToString(),
							"-",
							((int)(pM_Stat.month + 1)).ToString(),
							"-",
							((int)(pM_Stat.day + 1)).ToString(),
							" ",
							pM_Stat.hour.ToString(),
							":00:00|",
							(Convert.ToInt32(pM_Stat.hourSteps1) * 256 + Convert.ToInt32(pM_Stat.hourSteps0)).ToString(),
							"|",
							(Convert.ToInt32(pM_Stat.hourDistance1) * 256 + Convert.ToInt32(pM_Stat.hourDistance0)).ToString(),
							"|",
							(Convert.ToInt32(pM_Stat.hourCalorie1) * 256 + Convert.ToInt32(pM_Stat.hourCalorie0)).ToString(),
							"|0"
						});
						if (text == b)
						{
							break;
						}
						if ((Convert.ToInt32(pM_Stat.hourCalorie1) * 256 + Convert.ToInt32(pM_Stat.hourCalorie0) + (Convert.ToInt32(pM_Stat.hourSteps1) * 256 + Convert.ToInt32(pM_Stat.hourSteps0))).ToString() != "0" && pM_Stat.year.ToString() != "0" && pM_Stat.year.ToString() != "48")
						{
							this.Method_08(text);
						}
						b = text;
					}
				}
				catch
				{
					MessageBox.Show("Data read errors,please try again!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				finally
				{
					frmMain.pm_exit();
				}
			}
			try
			{
				string text2 = "<?xml version=\"1.0\" encoding=\"utf-8\" ?><root>";
				string text3 = this.Method_10();
				if (text3 == "")
				{
					this.Field_05.Enabled = true;
					this.Field_10.Visible = false;
					this.Field_09.Visible = false;
					MessageBox.Show("The SmartBand has no valid data. The time on your SmartBand may be wrong.\r\n Chec佌 th䝄 time on your SmartBand or do some exercise with your SmartBand,then try again!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				text2 += text3;
				text2 += "</root>";
				VidonnSync.com.vidonn.www.Service service = new VidonnSync.com.vidonn.www.Service();
				string text4 = service.SyncData(Class_05.Field_00, "PCSYNC_" + this.BMacss, text2, "VD2013");
				if (text4 == "true")
				{
					File.Delete(Environment.CurrentDirectory + "\\Sportdata.dll");
					MessageBox.Show("Data synchronization success! \r\n You can click the 'User Center' link on the bott䥊䭈 o䅂 this page to view your data onĂthe Vidonn website!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					this.syncFlag = true;
					this.syncLastTime = DateTime.Now;
				}
				else
				{
					MessageBox.Show(text4);
				}
			}
			catch
			{
				MessageBox.Show("Data synchronization failed!\r\n Please check the network and try again!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			this.Field_05.Enabled = true;
			this.Field_10.Visible = false;
			this.Field_09.Visible = false;
		}
		private void Method_08(string A_0)
		{
			try
			{
				using (StreamWriter streamWriter = File.AppendText(Environment.CurrentDirectory + "\\Sportdata.dll"))
				{
					streamWriter.WriteLine(A_0);
					streamWriter.Flush();
					streamWriter.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private string Method_09()
		{
			string path = Environment.CurrentDirectory + "\\Sportdata.dll";
			if (File.Exists(path))
			{
				string result;
				using (StreamReader streamReader = new StreamReader(path))
				{
					string text = "";
					try
					{
						string text2 = streamReader.ReadLine();
						if (text2 != null)
						{
							text = text2;
						}
						while (text2 != null)
						{
							text2 = streamReader.ReadLine();
							if (text2 != null)
							{
								text = text2;
							}
						}
					}
					catch
					{
					}
					streamReader.Close();
					result = text;
				}
				return result;
			}
			return "";
		}
		private string Method_10()
		{
			string text = "";
			string path = Environment.CurrentDirectory + "\\Sportdata.dll";
			try
			{
				using (StreamReader streamReader = new StreamReader(path))
				{
					string b = "";
					string oldValue = "";
					string text2 = streamReader.ReadLine();
					if (text2 != null)
					{
						string[] array = text2.Split(new char[]
						{
							'|'
						});
						string text3 = text;
						text = string.Concat(new string[]
						{
							text3,
							"<item><step>",
							array[1],
							"</step><distance>",
							array[2],
							"</distance><calorie>",
							array[3],
							"</calorie><storey>0</storey><sleep>0</sleep><acttime>",
							array[0],
							"</acttime></item>"
						});
						b = array[0];
						oldValue = string.Concat(new string[]
						{
							"<item><step>",
							array[1],
							"</step><distance>",
							array[2],
							"</distance><calorie>",
							array[3],
							"</calorie><storey>0</storey><sleep>0</sleep><acttime>",
							array[0],
							"</acttime></item>"
						});
					}
					while (text2 != null)
					{
						text2 = streamReader.ReadLine();
						if (text2 != null)
						{
							string[] array2 = text2.Split(new char[]
							{
								'|'
							});
							if (array2[0] == b)
							{
								text = text.Replace(oldValue, "");
							}
							string text4 = text;
							text = string.Concat(new string[]
							{
								text4,
								"<item><step>",
								array2[1],
								"</step><distance>",
								array2[2],
								"</distance><calorie>",
								array2[3],
								"</calorie><storey>0</storey><sleep>0</sleep><acttime>",
								array2[0],
								"</acttime></item>"
							});
							b = array2[0];
							oldValue = string.Concat(new string[]
							{
								"<item><step>",
								array2[1],
								"</step><distance>",
								array2[2],
								"</distance><calorie>",
								array2[3],
								"</calorie><storey>0</storey><sleep>0</sleep><acttime>",
								array2[0],
								"</acttime></item>"
							});
						}
					}
					streamReader.Close();
				}
			}
			catch
			{
			}
			return text;
		}
		private void Field_11_Click(object A_0, EventArgs A_1)
		{
			this.Field_11.Enabled = false;
			this.Method_06();
			this.Field_11.Enabled = true;
		}
		private void Method_12(object A_0, LinkLabelLinkClickedEventArgs A_1)
		{
			string text = DateTime.Now.ToString("yyyyMMddHHmmss");
			string text2 = "VDPCODE" + text;
			text2 = frmMain.GetMD5(text2);
			VidonnSync.com.vidonn.www.Service service = new VidonnSync.com.vidonn.www.Service();
			service.FormCheckLog(Class_05.Field_00, text2, "VD2013");
			Process.Start(string.Concat(new string[]
			{
				"http://www.vidonn.com/en/user/checkformlogin.aspx?loginid=",
				Class_05.Field_00,
				"&scode=",
				text2,
				"&stamp=",
				text
			}));
		}
		public static string GetMD5(string str)
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(str));
			for (int i = 0; i < array.Length; i++)
			{
				byte b = array[i];
				stringBuilder.Append(b.ToString("X2"));
			}
			return stringBuilder.ToString().ToLower();
		}
		private bool Method_13()
		{
			bool result = false;
			string text = "";
			try
			{
				PM_Bmac pM_Bmac = default(PM_Bmac);
				bool bMac = ImportHelper.GetBMac(out pM_Bmac);
				text = string.Concat(new string[]
				{
					pM_Bmac.btmac.ToString(),
					pM_Bmac.btmac1.ToString(),
					pM_Bmac.btmac2.ToString(),
					pM_Bmac.btmac3.ToString(),
					pM_Bmac.btmac4.ToString(),
					pM_Bmac.btmac5.ToString()
				});
				if (bMac && text != "")
				{
					this.BMacss = text;
					string text2 = "";
					string path = Environment.CurrentDirectory + "\\UDvice.dll";
					using (StreamReader streamReader = new StreamReader(path))
					{
						text2 = streamReader.ReadLine();
						streamReader.Close();
					}
					int num = -1;
					int num2 = 0;
					if (text2 != null)
					{
						num = text2.IndexOf(Class_05.Field_00);
						num2 = num + Class_05.Field_00.Length + 2;
					}
					if (num >= 0)
					{
						string text3 = text2.Substring(num2, text2.IndexOf("||", num2) - num2);
						if (text != text3)
						{
							result = true;
							if (text != "" && text3 != "")
							{
								text2 = text2.Replace(text3, text);
							}
							this.Method_15(text2);
						}
					}
					else
					{
						string text4 = text2;
						text2 = string.Concat(new string[]
						{
							text4,
							Class_05.Field_00,
							"$$",
							text,
							"||"
						});
						this.Method_15(text2);
					}
				}
			}
			catch
			{
				if (text != "")
				{
					string a_ = Class_05.Field_00 + "$$" + text + "||";
					this.Method_15(a_);
				}
			}
			return result;
		}
		private bool Method_14(string A_0)
		{
			bool result = false;
			string text = "";
			try
			{
				text = A_0;
				if (text != "")
				{
					this.BMacss = text;
					string text2 = "";
					string path = Environment.CurrentDirectory + "\\UDvice.dll";
					using (StreamReader streamReader = new StreamReader(path))
					{
						text2 = streamReader.ReadLine();
						streamReader.Close();
					}
					int num = -1;
					int num2 = 0;
					if (text2 != null)
					{
						num = text2.IndexOf(Class_05.Field_00);
						num2 = num + Class_05.Field_00.Length + 2;
					}
					if (num >= 0)
					{
						string text3 = text2.Substring(num2, text2.IndexOf("||", num2) - num2);
						if (text != text3)
						{
							result = true;
							if (text != "" && text3 != "")
							{
								text2 = text2.Replace(text3, text);
							}
							this.Method_15(text2);
						}
					}
					else
					{
						string text4 = text2;
						text2 = string.Concat(new string[]
						{
							text4,
							Class_05.Field_00,
							"$$",
							text,
							"||"
						});
						this.Method_15(text2);
					}
				}
			}
			catch
			{
				if (text != "")
				{
					string a_ = Class_05.Field_00 + "$$" + text + "||";
					this.Method_15(a_);
				}
			}
			return result;
		}
		private void Method_15(string A_0)
		{
			try
			{
				using (StreamWriter streamWriter = new StreamWriter(Environment.CurrentDirectory + "\\UDvice.dll"))
				{
					streamWriter.Write(A_0);
					streamWriter.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void Field_13_Tick(object A_0, EventArgs A_1)
		{
			this.Field_01++;
			if (this.Field_01 == 30)
			{
				this.Field_01 = 0;
				this.Field_07.Enabled = true;
				this.Field_13.Enabled = false;
			}
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.Field_02 != null)
			{
				this.Field_02.Dispose();
			}
			base.Dispose(disposing);
		}
		private void Method_17()
		{
			this.Field_02 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
			this.Field_03 = new PictureBox();
			this.Field_04 = new PictureBox();
			this.Field_05 = new Button();
			this.Field_06 = new Label();
			this.Field_07 = new LinkLabel();
			this.Field_08 = new Label();
			this.Field_09 = new Label();
			this.Field_10 = new Label();
			this.Field_11 = new Button();
			this.Field_12 = new LinkLabel();
			this.Field_13 = new System.Windows.Forms.Timer(this.Field_02);
			this.Field_14 = new Label();
			((ISupportInitialize)this.Field_03).BeginInit();
			((ISupportInitialize)this.Field_04).BeginInit();
			base.SuspendLayout();
			this.Field_03.BackColor = Color.Transparent;
			this.Field_03.Cursor = Cursors.Hand;
			this.Field_03.Location = new Point(290, 6);
			this.Field_03.Name = "pictureBox1";
			this.Field_03.Size = new Size(22, 20);
			this.Field_03.TabIndex = 1;
			this.Field_03.TabStop = false;
			this.Field_03.Click += new EventHandler(this.Field_03_Click);
			this.Field_04.BackColor = Color.Transparent;
			this.Field_04.Image = Class_04.imgsearch;
			this.Field_04.Location = new Point(50, 43);
			this.Field_04.Name = "pictureBox2";
			this.Field_04.Size = new Size(224, 242);
			this.Field_04.TabIndex = 2;
			this.Field_04.TabStop = false;
			this.Field_05.BackgroundImage = Class_04.btsync;
			this.Field_05.Location = new Point(44, 346);
			this.Field_05.Name = "button1";
			this.Field_05.Size = new Size(240, 50);
			this.Field_05.TabIndex = 3;
			this.Field_05.UseVisualStyleBackColor = true;
			this.Field_05.Visible = false;
			this.Field_05.Click += new EventHandler(this.Field_05_Click);
			this.Field_06.AutoSize = true;
			this.Field_06.BackColor = Color.Transparent;
			this.Field_06.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, 134);
			this.Field_06.ForeColor = Color.Yellow;
			this.Field_06.Location = new Point(62, 288);
			this.Field_06.Name = "lbl_DeviceFound";
			this.Field_06.Size = new Size(218, 25);
			this.Field_06.TabIndex = 4;
			this.Field_06.Text = "Connection Success!";
			this.Field_06.Visible = false;
			this.Field_07.AutoSize = true;
			this.Field_07.BackColor = Color.Transparent;
			this.Field_07.Enabled = false;
			this.Field_07.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_07.ForeColor = Color.Red;
			this.Field_07.LinkBehavior = LinkBehavior.HoverUnderline;
			this.Field_07.LinkColor = Color.FromArgb(192, 255, 255);
			this.Field_07.Location = new Point(220, 439);
			this.Field_07.Name = "linkLabel1";
			this.Field_07.Size = new Size(92, 17);
			this.Field_07.TabIndex = 5;
			this.Field_07.TabStop = true;
			this.Field_07.Text = "Configuration";
			this.Field_07.VisitedLinkColor = Color.FromArgb(192, 255, 255);
			this.Field_07.LinkClicked += new LinkLabelLinkClickedEventHandler(this.Method_03);
			this.Field_08.AutoSize = true;
			this.Field_08.BackColor = Color.Transparent;
			this.Field_08.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Field_08.ForeColor = Color.Yellow;
			this.Field_08.Location = new Point(74, 288);
			this.Field_08.Name = "lbl_DeviceNotFund";
			this.Field_08.Size = new Size(182, 25);
			this.Field_08.TabIndex = 6;
			this.Field_08.Text = "Connection Error!";
			this.Field_09.BackColor = Color.Transparent;
			this.Field_09.Image = Class_04.waiting;
			this.Field_09.Location = new Point(155, 326);
			this.Field_09.Name = "lbl_Waitting";
			this.Field_09.Size = new Size(119, 16);
			this.Field_09.TabIndex = 7;
			this.Field_09.Text = "     ";
			this.Field_09.Visible = false;
			this.Field_10.AutoSize = true;
			this.Field_10.BackColor = Color.Transparent;
			this.Field_10.Font = new Font("Microsoft Sans Serif", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_10.ForeColor = Color.White;
			this.Field_10.Location = new Point(41, 323);
			this.Field_10.Name = "lbl_Syncstatus";
			this.Field_10.Size = new Size(110, 17);
			this.Field_10.TabIndex = 8;
			this.Field_10.Text = "Please waiting...";
			this.Field_10.Visible = false;
			this.Field_11.BackgroundImage = Class_04.btsearch;
			this.Field_11.Location = new Point(44, 346);
			this.Field_11.Name = "button2";
			this.Field_11.Size = new Size(240, 50);
			this.Field_11.TabIndex = 9;
			this.Field_11.UseVisualStyleBackColor = true;
			this.Field_11.Click += new EventHandler(this.Field_11_Click);
			this.Field_12.AutoSize = true;
			this.Field_12.BackColor = Color.Transparent;
			this.Field_12.Font = new Font("Microsoft Sans Serif", 10.5f);
			this.Field_12.ForeColor = Color.Red;
			this.Field_12.LinkBehavior = LinkBehavior.HoverUnderline;
			this.Field_12.LinkColor = Color.FromArgb(192, 255, 255);
			this.Field_12.Location = new Point(11, 439);
			this.Field_12.Name = "linkLabel2";
			this.Field_12.Size = new Size(84, 17);
			this.Field_12.TabIndex = 10;
			this.Field_12.TabStop = true;
			this.Field_12.Text = "User Center";
			this.Field_12.VisitedLinkColor = Color.FromArgb(192, 255, 255);
			this.Field_12.LinkClicked += new LinkLabelLinkClickedEventHandler(this.Method_12);
			this.Field_13.Interval = 1000;
			this.Field_13.Tick += new EventHandler(this.Field_13_Tick);
			this.Field_14.AutoSize = true;
			this.Field_14.BackColor = Color.Transparent;
			this.Field_14.Font = new Font("Arial", 7.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.Field_14.ForeColor = Color.FromArgb(224, 224, 224);
			this.Field_14.Location = new Point(274, 421);
			this.Field_14.Name = "lbl_Fw";
			this.Field_14.Size = new Size(0, 10);
			this.Field_14.TabIndex = 11;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackgroundImage = Class_04.imgoth;
			base.ClientSize = new Size(320, 480);
			base.ControlBox = false;
			base.Controls.Add(this.Field_14);
			base.Controls.Add(this.Field_12);
			base.Controls.Add(this.Field_11);
			base.Controls.Add(this.Field_10);
			base.Controls.Add(this.Field_09);
			base.Controls.Add(this.Field_08);
			base.Controls.Add(this.Field_07);
			base.Controls.Add(this.Field_06);
			base.Controls.Add(this.Field_05);
			base.Controls.Add(this.Field_04);
			base.Controls.Add(this.Field_03);
			this.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmMain";
			base.StartPosition = FormStartPosition.CenterScreen;
			base.Load += new EventHandler(this.Method_05);
			base.MouseDown += new MouseEventHandler(this.Method_02);
			base.FormClosing += new FormClosingEventHandler(this.Method_04);
			((ISupportInitialize)this.Field_03).EndInit();
			((ISupportInitialize)this.Field_04).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
namespace VidonnSync.com.vidonn.www
{
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class ChangePasswordCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.Field_00[0];
			}
		}
		internal ChangePasswordCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void ChangePasswordCompletedEventHandler(object sender, ChangePasswordCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class CheckLoginCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.Field_00[0];
			}
		}
		internal CheckLoginCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void CheckLoginCompletedEventHandler(object sender, CheckLoginCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class FinishUserInfoCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.Field_00[0];
			}
		}
		internal FinishUserInfoCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void FinishUserInfoCompletedEventHandler(object sender, FinishUserInfoCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class FormCheckLogCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.Field_00[0];
			}
		}
		internal FormCheckLogCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void FormCheckLogCompletedEventHandler(object sender, FormCheckLogCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class FriendAddCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.Field_00[0];
			}
		}
		internal FriendAddCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void FriendAddCompletedEventHandler(object sender, FriendAddCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class FriendApplyListCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public XmlNode Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (XmlNode)this.Field_00[0];
			}
		}
		internal FriendApplyListCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void FriendApplyListCompletedEventHandler(object sender, FriendApplyListCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class FriendConfirmCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.Field_00[0];
			}
		}
		internal FriendConfirmCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void FriendConfirmCompletedEventHandler(object sender, FriendConfirmCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class FriendDeleteCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.Field_00[0];
			}
		}
		internal FriendDeleteCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void FriendDeleteCompletedEventHandler(object sender, FriendDeleteCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class FriendListCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public XmlNode Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (XmlNode)this.Field_00[0];
			}
		}
		internal FriendListCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void FriendListCompletedEventHandler(object sender, FriendListCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class FriendSearchCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public XmlNode Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (XmlNode)this.Field_00[0];
			}
		}
		internal FriendSearchCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void FriendSearchCompletedEventHandler(object sender, FriendSearchCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetUserInfoCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public XmlNode Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (XmlNode)this.Field_00[0];
			}
		}
		internal GetUserInfoCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void GetUserInfoCompletedEventHandler(object sender, GetUserInfoCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class HelloWorldCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.Field_00[0];
			}
		}
		internal HelloWorldCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class PKAddCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.Field_00[0];
			}
		}
		internal PKAddCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void PKAddCompletedEventHandler(object sender, PKAddCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class PKItemListCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public XmlNode Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (XmlNode)this.Field_00[0];
			}
		}
		internal PKItemListCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void PKItemListCompletedEventHandler(object sender, PKItemListCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class PKUserAddCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.Field_00[0];
			}
		}
		internal PKUserAddCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void PKUserAddCompletedEventHandler(object sender, PKUserAddCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class PKUserDeleteCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.Field_00[0];
			}
		}
		internal PKUserDeleteCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void PKUserDeleteCompletedEventHandler(object sender, PKUserDeleteCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class PKUserListCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public XmlNode Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (XmlNode)this.Field_00[0];
			}
		}
		internal PKUserListCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void PKUserListCompletedEventHandler(object sender, PKUserListCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class ReguserCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.Field_00[0];
			}
		}
		internal ReguserCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void ReguserCompletedEventHandler(object sender, ReguserCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Namespace = "http://tempuri.org/", Name = "ServiceSoap")]
	public class Service : SoapHttpClientProtocol
	{
		private SendOrPostCallback Field_00;
		private SendOrPostCallback Field_01;
		private SendOrPostCallback Field_02;
		private SendOrPostCallback Field_03;
		private SendOrPostCallback Field_04;
		private SendOrPostCallback Field_05;
		private SendOrPostCallback Field_06;
		private SendOrPostCallback Field_07;
		private SendOrPostCallback Field_08;
		private SendOrPostCallback Field_09;
		private SendOrPostCallback Field_10;
		private SendOrPostCallback Field_11;
		private SendOrPostCallback Field_12;
		private SendOrPostCallback Field_13;
		private SendOrPostCallback Field_14;
		private SendOrPostCallback Field_15;
		private SendOrPostCallback Field_16;
		private SendOrPostCallback Field_17;
		private SendOrPostCallback Field_18;
		private SendOrPostCallback Field_19;
		private SendOrPostCallback Field_20;
		private SendOrPostCallback Field_21;
		private bool Field_22;
		private HelloWorldCompletedEventHandler Field_23;
		private ReguserCompletedEventHandler Field_24;
		private CheckLoginCompletedEventHandler Field_25;
		private FinishUserInfoCompletedEventHandler Field_26;
		private UploadHeadCompletedEventHandler Field_27;
		private GetUserInfoCompletedEventHandler Field_28;
		private ChangePasswordCompletedEventHandler Field_29;
		private PKAddCompletedEventHandler Field_30;
		private PKUserAddCompletedEventHandler Field_31;
		private PKUserDeleteCompletedEventHandler Field_32;
		private PKItemListCompletedEventHandler Field_33;
		private PKUserListCompletedEventHandler Field_34;
		private FriendSearchCompletedEventHandler Field_35;
		private FriendAddCompletedEventHandler Field_36;
		private FriendListCompletedEventHandler Field_37;
		private FriendConfirmCompletedEventHandler Field_38;
		private FriendDeleteCompletedEventHandler Field_39;
		private FriendApplyListCompletedEventHandler Field_40;
		private SyncDataCompletedEventHandler Field_41;
		private UserSportsDataCompletedEventHandler Field_42;
		private SuggesSendCompletedEventHandler Field_43;
		private FormCheckLogCompletedEventHandler Field_44;
		public event HelloWorldCompletedEventHandler HelloWorldCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_23 = (HelloWorldCompletedEventHandler)Delegate.Combine(this.Field_23, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_23 = (HelloWorldCompletedEventHandler)Delegate.Remove(this.Field_23, value);
			}
		}
		public event ReguserCompletedEventHandler ReguserCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_24 = (ReguserCompletedEventHandler)Delegate.Combine(this.Field_24, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_24 = (ReguserCompletedEventHandler)Delegate.Remove(this.Field_24, value);
			}
		}
		public event CheckLoginCompletedEventHandler CheckLoginCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_25 = (CheckLoginCompletedEventHandler)Delegate.Combine(this.Field_25, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_25 = (CheckLoginCompletedEventHandler)Delegate.Remove(this.Field_25, value);
			}
		}
		public event FinishUserInfoCompletedEventHandler FinishUserInfoCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_26 = (FinishUserInfoCompletedEventHandler)Delegate.Combine(this.Field_26, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_26 = (FinishUserInfoCompletedEventHandler)Delegate.Remove(this.Field_26, value);
			}
		}
		public event UploadHeadCompletedEventHandler UploadHeadCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_27 = (UploadHeadCompletedEventHandler)Delegate.Combine(this.Field_27, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_27 = (UploadHeadCompletedEventHandler)Delegate.Remove(this.Field_27, value);
			}
		}
		public event GetUserInfoCompletedEventHandler GetUserInfoCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_28 = (GetUserInfoCompletedEventHandler)Delegate.Combine(this.Field_28, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_28 = (GetUserInfoCompletedEventHandler)Delegate.Remove(this.Field_28, value);
			}
		}
		public event ChangePasswordCompletedEventHandler ChangePasswordCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_29 = (ChangePasswordCompletedEventHandler)Delegate.Combine(this.Field_29, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_29 = (ChangePasswordCompletedEventHandler)Delegate.Remove(this.Field_29, value);
			}
		}
		public event PKAddCompletedEventHandler PKAddCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_30 = (PKAddCompletedEventHandler)Delegate.Combine(this.Field_30, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_30 = (PKAddCompletedEventHandler)Delegate.Remove(this.Field_30, value);
			}
		}
		public event PKUserAddCompletedEventHandler PKUserAddCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_31 = (PKUserAddCompletedEventHandler)Delegate.Combine(this.Field_31, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_31 = (PKUserAddCompletedEventHandler)Delegate.Remove(this.Field_31, value);
			}
		}
		public event PKUserDeleteCompletedEventHandler PKUserDeleteCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_32 = (PKUserDeleteCompletedEventHandler)Delegate.Combine(this.Field_32, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_32 = (PKUserDeleteCompletedEventHandler)Delegate.Remove(this.Field_32, value);
			}
		}
		public event PKItemListCompletedEventHandler PKItemListCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_33 = (PKItemListCompletedEventHandler)Delegate.Combine(this.Field_33, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_33 = (PKItemListCompletedEventHandler)Delegate.Remove(this.Field_33, value);
			}
		}
		public event PKUserListCompletedEventHandler PKUserListCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_34 = (PKUserListCompletedEventHandler)Delegate.Combine(this.Field_34, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_34 = (PKUserListCompletedEventHandler)Delegate.Remove(this.Field_34, value);
			}
		}
		public event FriendSearchCompletedEventHandler FriendSearchCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_35 = (FriendSearchCompletedEventHandler)Delegate.Combine(this.Field_35, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_35 = (FriendSearchCompletedEventHandler)Delegate.Remove(this.Field_35, value);
			}
		}
		public event FriendAddCompletedEventHandler FriendAddCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_36 = (FriendAddCompletedEventHandler)Delegate.Combine(this.Field_36, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_36 = (FriendAddCompletedEventHandler)Delegate.Remove(this.Field_36, value);
			}
		}
		public event FriendListCompletedEventHandler FriendListCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_37 = (FriendListCompletedEventHandler)Delegate.Combine(this.Field_37, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_37 = (FriendListCompletedEventHandler)Delegate.Remove(this.Field_37, value);
			}
		}
		public event FriendConfirmCompletedEventHandler FriendConfirmCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_38 = (FriendConfirmCompletedEventHandler)Delegate.Combine(this.Field_38, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_38 = (FriendConfirmCompletedEventHandler)Delegate.Remove(this.Field_38, value);
			}
		}
		public event FriendDeleteCompletedEventHandler FriendDeleteCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_39 = (FriendDeleteCompletedEventHandler)Delegate.Combine(this.Field_39, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_39 = (FriendDeleteCompletedEventHandler)Delegate.Remove(this.Field_39, value);
			}
		}
		public event FriendApplyListCompletedEventHandler FriendApplyListCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_40 = (FriendApplyListCompletedEventHandler)Delegate.Combine(this.Field_40, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_40 = (FriendApplyListCompletedEventHandler)Delegate.Remove(this.Field_40, value);
			}
		}
		public event SyncDataCompletedEventHandler SyncDataCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_41 = (SyncDataCompletedEventHandler)Delegate.Combine(this.Field_41, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_41 = (SyncDataCompletedEventHandler)Delegate.Remove(this.Field_41, value);
			}
		}
		public event UserSportsDataCompletedEventHandler UserSportsDataCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_42 = (UserSportsDataCompletedEventHandler)Delegate.Combine(this.Field_42, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_42 = (UserSportsDataCompletedEventHandler)Delegate.Remove(this.Field_42, value);
			}
		}
		public event SuggesSendCompletedEventHandler SuggesSendCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_43 = (SuggesSendCompletedEventHandler)Delegate.Combine(this.Field_43, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_43 = (SuggesSendCompletedEventHandler)Delegate.Remove(this.Field_43, value);
			}
		}
		public event FormCheckLogCompletedEventHandler FormCheckLogCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Field_44 = (FormCheckLogCompletedEventHandler)Delegate.Combine(this.Field_44, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Field_44 = (FormCheckLogCompletedEventHandler)Delegate.Remove(this.Field_44, value);
			}
		}
		public new string Url
		{
			get
			{
				return base.Url;
			}
			set
			{
				if (this.Method_33(base.Url) && !this.Field_22 && !this.Method_33(value))
				{
					base.UseDefaultCredentials = false;
				}
				base.Url = value;
			}
		}
		public new bool UseDefaultCredentials
		{
			get
			{
				return base.UseDefaultCredentials;
			}
			set
			{
				base.UseDefaultCredentials = value;
				this.Field_22 = true;
			}
		}
		public Service()
		{
			this.Url = Settings.Default.VidonnSync_com_vidonn_www_Service;
			if (this.Method_33(this.Url))
			{
				this.UseDefaultCredentials = true;
				this.Field_22 = false;
				return;
			}
			this.Field_22 = true;
		}
		[SoapDocumentMethod("http://tempuri.org/HelloWorld", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string HelloWorld()
		{
			object[] array = base.Invoke("HelloWorld", new object[0]);
			return (string)array[0];
		}
		public void HelloWorldAsync()
		{
			this.HelloWorldAsync(null);
		}
		public void HelloWorldAsync(object userState)
		{
			if (this.Field_00 == null)
			{
				this.Field_00 = new SendOrPostCallback(this.Method_01);
			}
			base.InvokeAsync("HelloWorld", new object[0], this.Field_00, userState);
		}
		private void Method_01(object A_0)
		{
			if (this.Field_23 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_23(this, new HelloWorldCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/Reguser", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string Reguser(string LoginID, string Password, string Nicname, string verCode)
		{
			object[] array = base.Invoke("Reguser", new object[]
			{
				LoginID,
				Password,
				Nicname,
				verCode
			});
			return (string)array[0];
		}
		public void ReguserAsync(string LoginID, string Password, string Nicname, string verCode)
		{
			this.ReguserAsync(LoginID, Password, Nicname, verCode, null);
		}
		public void ReguserAsync(string LoginID, string Password, string Nicname, string verCode, object userState)
		{
			if (this.Field_01 == null)
			{
				this.Field_01 = new SendOrPostCallback(this.Method_02);
			}
			base.InvokeAsync("Reguser", new object[]
			{
				LoginID,
				Password,
				Nicname,
				verCode
			}, this.Field_01, userState);
		}
		private void Method_02(object A_0)
		{
			if (this.Field_24 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_24(this, new ReguserCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/CheckLogin", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string CheckLogin(string LoginID, string Password, string MobileIMEI, string verCode)
		{
			object[] array = base.Invoke("CheckLogin", new object[]
			{
				LoginID,
				Password,
				MobileIMEI,
				verCode
			});
			return (string)array[0];
		}
		public void CheckLoginAsync(string LoginID, string Password, string MobileIMEI, string verCode)
		{
			this.CheckLoginAsync(LoginID, Password, MobileIMEI, verCode, null);
		}
		public void CheckLoginAsync(string LoginID, string Password, string MobileIMEI, string verCode, object userState)
		{
			if (this.Field_02 == null)
			{
				this.Field_02 = new SendOrPostCallback(this.Method_03);
			}
			base.InvokeAsync("CheckLogin", new object[]
			{
				LoginID,
				Password,
				MobileIMEI,
				verCode
			}, this.Field_02, userState);
		}
		private void Method_03(object A_0)
		{
			if (this.Field_25 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_25(this, new CheckLoginCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/FinishUserInfo", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string FinishUserInfo(string LoginID, string Email, string Mobile, string Nicname, string Usex, string Birthday, string Uheight, string Uweight, string DeviceID, string Introduce, string verCode)
		{
			object[] array = base.Invoke("FinishUserInfo", new object[]
			{
				LoginID,
				Email,
				Mobile,
				Nicname,
				Usex,
				Birthday,
				Uheight,
				Uweight,
				DeviceID,
				Introduce,
				verCode
			});
			return (string)array[0];
		}
		public void Method_04(string LoginID, string Email, string Mobile, string Nicname, string Usex, string Birthday, string Uheight, string Uweight, string DeviceID, string Introduce, string verCode)
		{
			this.Method_05(LoginID, Email, Mobile, Nicname, Usex, Birthday, Uheight, Uweight, DeviceID, Introduce, verCode, null);
		}
		public void Method_05(string LoginID, string Email, string Mobile, string Nicname, string Usex, string Birthday, string Uheight, string Uweight, string DeviceID, string Introduce, string verCode, object userState)
		{
			if (this.Field_03 == null)
			{
				this.Field_03 = new SendOrPostCallback(this.Method_06);
			}
			base.InvokeAsync("FinishUserInfo", new object[]
			{
				LoginID,
				Email,
				Mobile,
				Nicname,
				Usex,
				Birthday,
				Uheight,
				Uweight,
				DeviceID,
				Introduce,
				verCode
			}, this.Field_03, userState);
		}
		private void Method_06(object A_0)
		{
			if (this.Field_26 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_26(this, new FinishUserInfoCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/UploadHead", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string UploadHead([XmlElement(DataType = "base64Binary")] byte[] ImgHead, string LoginID, string verCode)
		{
			object[] array = base.Invoke("UploadHead", new object[]
			{
				ImgHead,
				LoginID,
				verCode
			});
			return (string)array[0];
		}
		public void UploadHeadAsync(byte[] ImgHead, string LoginID, string verCode)
		{
			this.UploadHeadAsync(ImgHead, LoginID, verCode, null);
		}
		public void UploadHeadAsync(byte[] ImgHead, string LoginID, string verCode, object userState)
		{
			if (this.Field_04 == null)
			{
				this.Field_04 = new SendOrPostCallback(this.Method_07);
			}
			base.InvokeAsync("UploadHead", new object[]
			{
				ImgHead,
				LoginID,
				verCode
			}, this.Field_04, userState);
		}
		private void Method_07(object A_0)
		{
			if (this.Field_27 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_27(this, new UploadHeadCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/GetUserInfo", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public XmlNode GetUserInfo(string LoginID, string verCode)
		{
			object[] array = base.Invoke("GetUserInfo", new object[]
			{
				LoginID,
				verCode
			});
			return (XmlNode)array[0];
		}
		public void GetUserInfoAsync(string LoginID, string verCode)
		{
			this.GetUserInfoAsync(LoginID, verCode, null);
		}
		public void GetUserInfoAsync(string LoginID, string verCode, object userState)
		{
			if (this.Field_05 == null)
			{
				this.Field_05 = new SendOrPostCallback(this.Method_08);
			}
			base.InvokeAsync("GetUserInfo", new object[]
			{
				LoginID,
				verCode
			}, this.Field_05, userState);
		}
		private void Method_08(object A_0)
		{
			if (this.Field_28 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_28(this, new GetUserInfoCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/ChangePassword", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string ChangePassword(string LoginID, string Password, string OldPassword, string verCode)
		{
			object[] array = base.Invoke("ChangePassword", new object[]
			{
				LoginID,
				Password,
				OldPassword,
				verCode
			});
			return (string)array[0];
		}
		public void Method_09(string LoginID, string Password, string OldPassword, string verCode)
		{
			this.Method_10(LoginID, Password, OldPassword, verCode, null);
		}
		public void Method_10(string LoginID, string Password, string OldPassword, string verCode, object userState)
		{
			if (this.Field_06 == null)
			{
				this.Field_06 = new SendOrPostCallback(this.Method_11);
			}
			base.InvokeAsync("ChangePassword", new object[]
			{
				LoginID,
				Password,
				OldPassword,
				verCode
			}, this.Field_06, userState);
		}
		private void Method_11(object A_0)
		{
			if (this.Field_29 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_29(this, new ChangePasswordCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/PKAdd", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string PKAdd(string LoginID, string ActScore, string StartTime, string EndTime, string InviteUser, string Passcode, string PKType, string PKName, string verCode)
		{
			object[] array = base.Invoke("PKAdd", new object[]
			{
				LoginID,
				ActScore,
				StartTime,
				EndTime,
				InviteUser,
				Passcode,
				PKType,
				PKName,
				verCode
			});
			return (string)array[0];
		}
		public void PKAddAsync(string LoginID, string ActScore, string StartTime, string EndTime, string InviteUser, string Passcode, string PKType, string PKName, string verCode)
		{
			this.PKAddAsync(LoginID, ActScore, StartTime, EndTime, InviteUser, Passcode, PKType, PKName, verCode, null);
		}
		public void PKAddAsync(string LoginID, string ActScore, string StartTime, string EndTime, string InviteUser, string Passcode, string PKType, string PKName, string verCode, object userState)
		{
			if (this.Field_07 == null)
			{
				this.Field_07 = new SendOrPostCallback(this.Method_12);
			}
			base.InvokeAsync("PKAdd", new object[]
			{
				LoginID,
				ActScore,
				StartTime,
				EndTime,
				InviteUser,
				Passcode,
				PKType,
				PKName,
				verCode
			}, this.Field_07, userState);
		}
		private void Method_12(object A_0)
		{
			if (this.Field_30 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_30(this, new PKAddCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/PKUserAdd", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string Method_13(string PKID, string AddUserID, string UStatus, string verCode)
		{
			object[] array = base.Invoke("PKUserAdd", new object[]
			{
				PKID,
				AddUserID,
				UStatus,
				verCode
			});
			return (string)array[0];
		}
		public void PKUserAddAsync(string PKID, string AddUserID, string UStatus, string verCode)
		{
			this.PKUserAddAsync(PKID, AddUserID, UStatus, verCode, null);
		}
		public void PKUserAddAsync(string PKID, string AddUserID, string UStatus, string verCode, object userState)
		{
			if (this.Field_08 == null)
			{
				this.Field_08 = new SendOrPostCallback(this.Method_14);
			}
			base.InvokeAsync("PKUserAdd", new object[]
			{
				PKID,
				AddUserID,
				UStatus,
				verCode
			}, this.Field_08, userState);
		}
		private void Method_14(object A_0)
		{
			if (this.Field_31 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_31(this, new PKUserAddCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/PKUserDelete", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string PKUserDelete(string PKID, string DeleteUserID, string verCode)
		{
			object[] array = base.Invoke("PKUserDelete", new object[]
			{
				PKID,
				DeleteUserID,
				verCode
			});
			return (string)array[0];
		}
		public void PKUserDeleteAsync(string PKID, string DeleteUserID, string verCode)
		{
			this.PKUserDeleteAsync(PKID, DeleteUserID, verCode, null);
		}
		public void PKUserDeleteAsync(string PKID, string DeleteUserID, string verCode, object userState)
		{
			if (this.Field_09 == null)
			{
				this.Field_09 = new SendOrPostCallback(this.Method_15);
			}
			base.InvokeAsync("PKUserDelete", new object[]
			{
				PKID,
				DeleteUserID,
				verCode
			}, this.Field_09, userState);
		}
		private void Method_15(object A_0)
		{
			if (this.Field_32 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_32(this, new PKUserDeleteCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/PKItemList", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public XmlNode PKItemList(string LoginID, string ListType, string verCode)
		{
			object[] array = base.Invoke("PKItemList", new object[]
			{
				LoginID,
				ListType,
				verCode
			});
			return (XmlNode)array[0];
		}
		public void PKItemListAsync(string LoginID, string ListType, string verCode)
		{
			this.PKItemListAsync(LoginID, ListType, verCode, null);
		}
		public void PKItemListAsync(string LoginID, string ListType, string verCode, object userState)
		{
			if (this.Field_10 == null)
			{
				this.Field_10 = new SendOrPostCallback(this.Method_16);
			}
			base.InvokeAsync("PKItemList", new object[]
			{
				LoginID,
				ListType,
				verCode
			}, this.Field_10, userState);
		}
		private void Method_16(object A_0)
		{
			if (this.Field_33 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_33(this, new PKItemListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/PKUserList", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public XmlNode PKUserList(string PKID, string verCode)
		{
			object[] array = base.Invoke("PKUserList", new object[]
			{
				PKID,
				verCode
			});
			return (XmlNode)array[0];
		}
		public void PKUserListAsync(string PKID, string verCode)
		{
			this.PKUserListAsync(PKID, verCode, null);
		}
		public void PKUserListAsync(string PKID, string verCode, object userState)
		{
			if (this.Field_11 == null)
			{
				this.Field_11 = new SendOrPostCallback(this.Method_17);
			}
			base.InvokeAsync("PKUserList", new object[]
			{
				PKID,
				verCode
			}, this.Field_11, userState);
		}
		private void Method_17(object A_0)
		{
			if (this.Field_34 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_34(this, new PKUserListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/FriendSearch", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public XmlNode FriendSearch(string SearchKey, string verCode)
		{
			object[] array = base.Invoke("FriendSearch", new object[]
			{
				SearchKey,
				verCode
			});
			return (XmlNode)array[0];
		}
		public void FriendSearchAsync(string SearchKey, string verCode)
		{
			this.FriendSearchAsync(SearchKey, verCode, null);
		}
		public void FriendSearchAsync(string SearchKey, string verCode, object userState)
		{
			if (this.Field_12 == null)
			{
				this.Field_12 = new SendOrPostCallback(this.Method_18);
			}
			base.InvokeAsync("FriendSearch", new object[]
			{
				SearchKey,
				verCode
			}, this.Field_12, userState);
		}
		private void Method_18(object A_0)
		{
			if (this.Field_35 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_35(this, new FriendSearchCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/FriendAdd", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string Method_19(string LoginID, string FriendLoginID, string verCode)
		{
			object[] array = base.Invoke("FriendAdd", new object[]
			{
				LoginID,
				FriendLoginID,
				verCode
			});
			return (string)array[0];
		}
		public void FriendAddAsync(string LoginID, string FriendLoginID, string verCode)
		{
			this.FriendAddAsync(LoginID, FriendLoginID, verCode, null);
		}
		public void FriendAddAsync(string LoginID, string FriendLoginID, string verCode, object userState)
		{
			if (this.Field_13 == null)
			{
				this.Field_13 = new SendOrPostCallback(this.Method_20);
			}
			base.InvokeAsync("FriendAdd", new object[]
			{
				LoginID,
				FriendLoginID,
				verCode
			}, this.Field_13, userState);
		}
		private void Method_20(object A_0)
		{
			if (this.Field_36 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_36(this, new FriendAddCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/FriendList", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public XmlNode FriendList(string LoginID, string verCode)
		{
			object[] array = base.Invoke("FriendList", new object[]
			{
				LoginID,
				verCode
			});
			return (XmlNode)array[0];
		}
		public void FriendListAsync(string LoginID, string verCode)
		{
			this.FriendListAsync(LoginID, verCode, null);
		}
		public void FriendListAsync(string LoginID, string verCode, object userState)
		{
			if (this.Field_14 == null)
			{
				this.Field_14 = new SendOrPostCallback(this.Method_21);
			}
			base.InvokeAsync("FriendList", new object[]
			{
				LoginID,
				verCode
			}, this.Field_14, userState);
		}
		private void Method_21(object A_0)
		{
			if (this.Field_37 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_37(this, new FriendListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/FriendConfirm", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string FriendConfirm(string LoginID, string FriendUID, string CType, string verCode)
		{
			object[] array = base.Invoke("FriendConfirm", new object[]
			{
				LoginID,
				FriendUID,
				CType,
				verCode
			});
			return (string)array[0];
		}
		public void Method_22(string LoginID, string FriendUID, string CType, string verCode)
		{
			this.Method_23(LoginID, FriendUID, CType, verCode, null);
		}
		public void Method_23(string LoginID, string FriendUID, string CType, string verCode, object userState)
		{
			if (this.Field_15 == null)
			{
				this.Field_15 = new SendOrPostCallback(this.Method_24);
			}
			base.InvokeAsync("FriendConfirm", new object[]
			{
				LoginID,
				FriendUID,
				CType,
				verCode
			}, this.Field_15, userState);
		}
		private void Method_24(object A_0)
		{
			if (this.Field_38 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_38(this, new FriendConfirmCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/FriendDelete", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string FriendDelete(string LoginID, string FriendUID, string CType, string verCode)
		{
			object[] array = base.Invoke("FriendDelete", new object[]
			{
				LoginID,
				FriendUID,
				CType,
				verCode
			});
			return (string)array[0];
		}
		public void FriendDeleteAsync(string LoginID, string FriendUID, string CType, string verCode)
		{
			this.FriendDeleteAsync(LoginID, FriendUID, CType, verCode, null);
		}
		public void FriendDeleteAsync(string LoginID, string FriendUID, string CType, string verCode, object userState)
		{
			if (this.Field_16 == null)
			{
				this.Field_16 = new SendOrPostCallback(this.Method_25);
			}
			base.InvokeAsync("FriendDelete", new object[]
			{
				LoginID,
				FriendUID,
				CType,
				verCode
			}, this.Field_16, userState);
		}
		private void Method_25(object A_0)
		{
			if (this.Field_39 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_39(this, new FriendDeleteCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/FriendApplyList", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public XmlNode FriendApplyList(string LoginID, string verCode)
		{
			object[] array = base.Invoke("FriendApplyList", new object[]
			{
				LoginID,
				verCode
			});
			return (XmlNode)array[0];
		}
		public void FriendApplyListAsync(string LoginID, string verCode)
		{
			this.FriendApplyListAsync(LoginID, verCode, null);
		}
		public void FriendApplyListAsync(string LoginID, string verCode, object userState)
		{
			if (this.Field_17 == null)
			{
				this.Field_17 = new SendOrPostCallback(this.Method_26);
			}
			base.InvokeAsync("FriendApplyList", new object[]
			{
				LoginID,
				verCode
			}, this.Field_17, userState);
		}
		private void Method_26(object A_0)
		{
			if (this.Field_40 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_40(this, new FriendApplyListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/SyncData", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string SyncData(string LoginID, string DeviceID, string DataXML, string verCode)
		{
			object[] array = base.Invoke("SyncData", new object[]
			{
				LoginID,
				DeviceID,
				DataXML,
				verCode
			});
			return (string)array[0];
		}
		public void SyncDataAsync(string LoginID, string DeviceID, string DataXML, string verCode)
		{
			this.SyncDataAsync(LoginID, DeviceID, DataXML, verCode, null);
		}
		public void SyncDataAsync(string LoginID, string DeviceID, string DataXML, string verCode, object userState)
		{
			if (this.Field_18 == null)
			{
				this.Field_18 = new SendOrPostCallback(this.Method_27);
			}
			base.InvokeAsync("SyncData", new object[]
			{
				LoginID,
				DeviceID,
				DataXML,
				verCode
			}, this.Field_18, userState);
		}
		private void Method_27(object A_0)
		{
			if (this.Field_41 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_41(this, new SyncDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/UserSportsData", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public XmlNode UserSportsData(string LoginID, string StartDate, string EndDate, string sType, string verCode)
		{
			object[] array = base.Invoke("UserSportsData", new object[]
			{
				LoginID,
				StartDate,
				EndDate,
				sType,
				verCode
			});
			return (XmlNode)array[0];
		}
		public void Method_28(string LoginID, string StartDate, string EndDate, string sType, string verCode)
		{
			this.Method_29(LoginID, StartDate, EndDate, sType, verCode, null);
		}
		public void Method_29(string LoginID, string StartDate, string EndDate, string sType, string verCode, object userState)
		{
			if (this.Field_19 == null)
			{
				this.Field_19 = new SendOrPostCallback(this.Method_30);
			}
			base.InvokeAsync("UserSportsData", new object[]
			{
				LoginID,
				StartDate,
				EndDate,
				sType,
				verCode
			}, this.Field_19, userState);
		}
		private void Method_30(object A_0)
		{
			if (this.Field_42 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_42(this, new UserSportsDataCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/SuggesSend", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string SuggesSend(string LoginID, string ContactWay, string Contents, string verCode)
		{
			object[] array = base.Invoke("SuggesSend", new object[]
			{
				LoginID,
				ContactWay,
				Contents,
				verCode
			});
			return (string)array[0];
		}
		public void SuggesSendAsync(string LoginID, string ContactWay, string Contents, string verCode)
		{
			this.SuggesSendAsync(LoginID, ContactWay, Contents, verCode, null);
		}
		public void SuggesSendAsync(string LoginID, string ContactWay, string Contents, string verCode, object userState)
		{
			if (this.Field_20 == null)
			{
				this.Field_20 = new SendOrPostCallback(this.Method_31);
			}
			base.InvokeAsync("SuggesSend", new object[]
			{
				LoginID,
				ContactWay,
				Contents,
				verCode
			}, this.Field_20, userState);
		}
		private void Method_31(object A_0)
		{
			if (this.Field_43 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_43(this, new SuggesSendCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://tempuri.org/FormCheckLog", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
		public string FormCheckLog(string LoginID, string myStpnm, string verCode)
		{
			object[] array = base.Invoke("FormCheckLog", new object[]
			{
				LoginID,
				myStpnm,
				verCode
			});
			return (string)array[0];
		}
		public void FormCheckLogAsync(string LoginID, string myStpnm, string verCode)
		{
			this.FormCheckLogAsync(LoginID, myStpnm, verCode, null);
		}
		public void FormCheckLogAsync(string LoginID, string myStpnm, string verCode, object userState)
		{
			if (this.Field_21 == null)
			{
				this.Field_21 = new SendOrPostCallback(this.Method_32);
			}
			base.InvokeAsync("FormCheckLog", new object[]
			{
				LoginID,
				myStpnm,
				verCode
			}, this.Field_21, userState);
		}
		private void Method_32(object A_0)
		{
			if (this.Field_44 != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)A_0;
				this.Field_44(this, new FormCheckLogCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		public new void CancelAsync(object userState)
		{
			base.CancelAsync(userState);
		}
		private bool Method_33(string A_0)
		{
			if (A_0 != null && !(A_0 == string.Empty))
			{
				Uri uri = new Uri(A_0);
				return uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
			}
			return false;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class SuggesSendCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.Field_00[0];
			}
		}
		internal SuggesSendCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void SuggesSendCompletedEventHandler(object sender, SuggesSendCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class SyncDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.Field_00[0];
			}
		}
		internal SyncDataCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void SyncDataCompletedEventHandler(object sender, SyncDataCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class UploadHeadCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.Field_00[0];
			}
		}
		internal UploadHeadCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void UploadHeadCompletedEventHandler(object sender, UploadHeadCompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "2.0.50727.5420"), DesignerCategory("code"), DebuggerStepThrough]
	public class UserSportsDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] Field_00;
		public XmlNode Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (XmlNode)this.Field_00[0];
			}
		}
		internal UserSportsDataCompletedEventArgs(object[] A_0, Exception A_1, bool A_2, object A_3) : base(A_1, A_2, A_3)
		{
			this.Field_00 = A_0;
		}
	}
	[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
	public delegate void UserSportsDataCompletedEventHandler(object sender, UserSportsDataCompletedEventArgs e);
}
namespace VidonnSync.Properties
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	internal class Class_04
	{
		private static ResourceManager Field_00;
		private static CultureInfo Field_01;
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Class_04.Field_00, null))
				{
					ResourceManager field_ = new ResourceManager("VidonnSync.Properties.Resources", typeof(Class_04).Assembly);
					Class_04.Field_00 = field_;
				}
				return Class_04.Field_00;
			}
		}
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Class_04.Field_01;
			}
			set
			{
				Class_04.Field_01 = value;
			}
		}
		internal static Bitmap btlogin
		{
			get
			{
				object @object = Class_04.ResourceManager.GetObject("btlogin", Class_04.Field_01);
				return (Bitmap)@object;
			}
		}
		internal static Bitmap btok
		{
			get
			{
				object @object = Class_04.ResourceManager.GetObject("btok", Class_04.Field_01);
				return (Bitmap)@object;
			}
		}
		internal static Bitmap btsearch
		{
			get
			{
				object @object = Class_04.ResourceManager.GetObject("btsearch", Class_04.Field_01);
				return (Bitmap)@object;
			}
		}
		internal static Bitmap btsync
		{
			get
			{
				object @object = Class_04.ResourceManager.GetObject("btsync", Class_04.Field_01);
				return (Bitmap)@object;
			}
		}
		internal static Bitmap imglogin
		{
			get
			{
				object @object = Class_04.ResourceManager.GetObject("imglogin", Class_04.Field_01);
				return (Bitmap)@object;
			}
		}
		internal static Bitmap imgoth
		{
			get
			{
				object @object = Class_04.ResourceManager.GetObject("imgoth", Class_04.Field_01);
				return (Bitmap)@object;
			}
		}
		internal static Bitmap imgsearch
		{
			get
			{
				object @object = Class_04.ResourceManager.GetObject("imgsearch", Class_04.Field_01);
				return (Bitmap)@object;
			}
		}
		internal static Bitmap waiting
		{
			get
			{
				object @object = Class_04.ResourceManager.GetObject("waiting", Class_04.Field_01);
				return (Bitmap)@object;
			}
		}
		internal Class_04()
		{
		}
	}
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0"), CompilerGenerated]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings Field_00 = (Settings)SettingsBase.Synchronized(new Settings());
		public static Settings Default
		{
			get
			{
				return Settings.Field_00;
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("http://www.vidonn.com/webservice/service.asmx"), SpecialSetting(SpecialSetting.WebServiceUrl), DebuggerNonUserCode]
		public string VidonnSync_com_vidonn_www_Service
		{
			get
			{
				return (string)this["VidonnSync_com_vidonn_www_Service"];
			}
		}
	}
}
