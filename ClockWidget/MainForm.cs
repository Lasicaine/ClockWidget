using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ClockWidget.Properties;

namespace ClockWidget
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class WidgetForm : Form
	{
		[DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);
 
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();
 
        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        const uint DOSIZE = 0xF008;
        
		public WidgetForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += new MouseEventHandler(WidgetFormMouseDown);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public static string NameMonthPropis(DateTime date)
		{
		  string[] d = new string[]
			 { "Января", 
			   "Февраля",
			   "Марта",
			   "Апреля",
			   "Мая",
			   "Июня",
			   "Июля",
			   "Августа",
			   "Сентября",
			   "Октября",
			   "Ноября",
			   "Декабря"
			};
		  return Convert.ToString(date.Day) + " " +
          d[Convert.ToUInt32(date.Month-1)] + " " +
          Convert.ToString(date.Year);
		}
		
		void TimerClockTick(object sender, EventArgs e)
		{
			ClockLabel.Text=DateTime.Now.ToString("HH:mm");
			labelDayOfWeek.Text=DateTime.Now.ToString("dddd");
			labelCurDate.Text=NameMonthPropis(DateTime.Now);
		}
		
		void WidgetFormMouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
		}
		
		void ToolStripQuitClick(object sender, EventArgs e)
		{
			Close();
		}
		
		
		void WidgetFormLoad(object sender, EventArgs e)
		{
			this.Top = Settings.Default.Top;
			this.Left = Settings.Default.Left;
			this.BackColor = Settings.Default.BColor;
			ClockLabel.Font = Settings.Default.CFont;
			labelDayOfWeek.Font = Settings.Default.DFont;
			labelCurDate.Font = Settings.Default.DFont;
			ClockLabel.ForeColor = Settings.Default.TColor;
			labelDayOfWeek.ForeColor = Settings.Default.TColor;
			labelCurDate.ForeColor = Settings.Default.TColor;
		}
		
		void WidgetFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Default.Top = this.Top;
			Settings.Default.Left = this.Left;
			Settings.Default.BColor = this.BackColor;
			Settings.Default.CFont = ClockLabel.Font;
			Settings.Default.DFont = labelDayOfWeek.Font;
			Settings.Default.TColor = ClockLabel.ForeColor;
			Settings.Default.Save();
		}
		
		void ToolStripColorClick(object sender, EventArgs e)
		{			
			ColorDialog MyDialog = new ColorDialog();
    		MyDialog.Color = this.BackColor;

    	if (MyDialog.ShowDialog() == DialogResult.OK)
	        this.BackColor =  MyDialog.Color;
	   		contextMenuWidget.Close();
		}
		
		void ToolStripFontsClick(object sender, EventArgs e)
		{
			FontDialog FDialog = new FontDialog();
			FDialog.Font = ClockLabel.Font;
			
			if (FDialog.ShowDialog() == DialogResult.OK)
	        ClockLabel.Font =  FDialog.Font;
	   		contextMenuWidget.Close();
		}
		
		void ToolStripDataFontsClick(object sender, EventArgs e)
		{
			FontDialog FDialog = new FontDialog();
			FDialog.Font = labelDayOfWeek.Font;
			
			if (FDialog.ShowDialog() == DialogResult.OK)
			labelDayOfWeek.Font =  FDialog.Font;
			labelCurDate.Font =  FDialog.Font;
	   		contextMenuWidget.Close();
		}
		
		void ToolStripTextColorClick(object sender, EventArgs e)
		{
			ColorDialog CTDialog = new ColorDialog();
    		CTDialog.Color = ClockLabel.ForeColor;

    	if (CTDialog.ShowDialog() == DialogResult.OK)
	        ClockLabel.ForeColor =  CTDialog.Color;
    		labelDayOfWeek.ForeColor =  CTDialog.Color;
    		labelCurDate.ForeColor =  CTDialog.Color;
	   		contextMenuWidget.Close();
		}
	}
}
