/*
 * Created by SharpDevelop.
 * User: Alex
 * Date: 18.06.14
 * Time: 21:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ClockWidget
{
	partial class WidgetForm
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
			this.components = new System.ComponentModel.Container();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.timerClock = new System.Windows.Forms.Timer(this.components);
			this.contextMenuWidget = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripFonts = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripDataFonts = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripTextColor = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripColor = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripQuit = new System.Windows.Forms.ToolStripTextBox();
			this.labelDayOfWeek = new System.Windows.Forms.Label();
			this.labelCurDate = new System.Windows.Forms.Label();
			this.ClockLabel = new System.Windows.Forms.Label();
			this.contextMenuWidget.SuspendLayout();
			this.SuspendLayout();
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
			this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.monthCalendar1.Location = new System.Drawing.Point(4, 150);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.ShowWeekNumbers = true;
			this.monthCalendar1.TabIndex = 1;
			// 
			// timerClock
			// 
			this.timerClock.Enabled = true;
			this.timerClock.Tick += new System.EventHandler(this.TimerClockTick);
			// 
			// contextMenuWidget
			// 
			this.contextMenuWidget.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripFonts,
									this.toolStripDataFonts,
									this.toolStripTextColor,
									this.toolStripColor,
									this.toolStripSeparator1,
									this.toolStripQuit});
			this.contextMenuWidget.Name = "contextMenuWidget";
			this.contextMenuWidget.ShowImageMargin = false;
			this.contextMenuWidget.Size = new System.Drawing.Size(136, 135);
			// 
			// toolStripFonts
			// 
			this.toolStripFonts.Name = "toolStripFonts";
			this.toolStripFonts.Size = new System.Drawing.Size(100, 23);
			this.toolStripFonts.Text = "Шрифт часов";
			this.toolStripFonts.Click += new System.EventHandler(this.ToolStripFontsClick);
			// 
			// toolStripDataFonts
			// 
			this.toolStripDataFonts.Name = "toolStripDataFonts";
			this.toolStripDataFonts.Size = new System.Drawing.Size(100, 23);
			this.toolStripDataFonts.Text = "Шрифт даты";
			this.toolStripDataFonts.Click += new System.EventHandler(this.ToolStripDataFontsClick);
			// 
			// toolStripTextColor
			// 
			this.toolStripTextColor.Name = "toolStripTextColor";
			this.toolStripTextColor.Size = new System.Drawing.Size(100, 23);
			this.toolStripTextColor.Text = "Цвет текста";
			this.toolStripTextColor.Click += new System.EventHandler(this.ToolStripTextColorClick);
			// 
			// toolStripColor
			// 
			this.toolStripColor.Name = "toolStripColor";
			this.toolStripColor.Size = new System.Drawing.Size(100, 23);
			this.toolStripColor.Text = "Цвет виджета";
			this.toolStripColor.Click += new System.EventHandler(this.ToolStripColorClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
			// 
			// toolStripQuit
			// 
			this.toolStripQuit.Name = "toolStripQuit";
			this.toolStripQuit.Size = new System.Drawing.Size(100, 23);
			this.toolStripQuit.Text = "Закрыть виджет";
			this.toolStripQuit.Click += new System.EventHandler(this.ToolStripQuitClick);
			// 
			// labelDayOfWeek
			// 
			this.labelDayOfWeek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.labelDayOfWeek.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDayOfWeek.ForeColor = System.Drawing.SystemColors.Control;
			this.labelDayOfWeek.Location = new System.Drawing.Point(4, 76);
			this.labelDayOfWeek.Name = "labelDayOfWeek";
			this.labelDayOfWeek.Size = new System.Drawing.Size(186, 35);
			this.labelDayOfWeek.TabIndex = 2;
			this.labelDayOfWeek.Text = "-";
			this.labelDayOfWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelCurDate
			// 
			this.labelCurDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.labelCurDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCurDate.ForeColor = System.Drawing.SystemColors.Control;
			this.labelCurDate.Location = new System.Drawing.Point(4, 109);
			this.labelCurDate.Name = "labelCurDate";
			this.labelCurDate.Size = new System.Drawing.Size(186, 34);
			this.labelCurDate.TabIndex = 3;
			this.labelCurDate.Text = "-";
			this.labelCurDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ClockLabel
			// 
			this.ClockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.ClockLabel.Font = new System.Drawing.Font("Segoe UI", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
			this.ClockLabel.ForeColor = System.Drawing.SystemColors.Control;
			this.ClockLabel.Location = new System.Drawing.Point(4, 9);
			this.ClockLabel.Name = "ClockLabel";
			this.ClockLabel.Size = new System.Drawing.Size(186, 67);
			this.ClockLabel.TabIndex = 4;
			this.ClockLabel.Text = ":";
			this.ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// WidgetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(194, 316);
			this.ContextMenuStrip = this.contextMenuWidget;
			this.Controls.Add(this.ClockLabel);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.labelCurDate);
			this.Controls.Add(this.labelDayOfWeek);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "WidgetForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "ClockWidget";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WidgetFormFormClosed);
			this.Load += new System.EventHandler(this.WidgetFormLoad);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WidgetFormMouseDown);
			this.contextMenuWidget.ResumeLayout(false);
			this.contextMenuWidget.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripTextBox toolStripTextColor;
		private System.Windows.Forms.ToolStripTextBox toolStripDataFonts;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripTextBox toolStripFonts;
		private System.Windows.Forms.ToolStripTextBox toolStripColor;
		private System.Windows.Forms.Label labelCurDate;
		private System.Windows.Forms.Label labelDayOfWeek;
		private System.Windows.Forms.ToolStripTextBox toolStripQuit;
		private System.Windows.Forms.ContextMenuStrip contextMenuWidget;
		private System.Windows.Forms.Timer timerClock;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Label ClockLabel;
	}
}
