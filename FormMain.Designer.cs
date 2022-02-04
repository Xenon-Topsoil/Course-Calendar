namespace Course_Calendar {
  partial class FormMain {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.uxTableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.uxTextBoxCourseName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.uxDateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
      this.label3 = new System.Windows.Forms.Label();
      this.uxDateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
      this.label4 = new System.Windows.Forms.Label();
      this.uxDateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
      this.label5 = new System.Windows.Forms.Label();
      this.uxNumericUpDownNumberOfWeeks = new System.Windows.Forms.NumericUpDown();
      this.uxButtonAddToCalendar = new System.Windows.Forms.Button();
      this.uxToolTipMain = new System.Windows.Forms.ToolTip(this.components);
      this.label6 = new System.Windows.Forms.Label();
      this.uxNumericUpDownEvery = new System.Windows.Forms.NumericUpDown();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.uxLabelToDate = new System.Windows.Forms.Label();
      this.uxTableLayoutPanelMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownNumberOfWeeks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownEvery)).BeginInit();
      this.SuspendLayout();
      // 
      // uxTableLayoutPanelMain
      // 
      this.uxTableLayoutPanelMain.AutoSize = true;
      this.uxTableLayoutPanelMain.ColumnCount = 4;
      this.uxTableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.uxTableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.uxTableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.uxTableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.uxTableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.uxTableLayoutPanelMain.Controls.Add(this.label1, 0, 0);
      this.uxTableLayoutPanelMain.Controls.Add(this.uxTextBoxCourseName, 1, 0);
      this.uxTableLayoutPanelMain.Controls.Add(this.label2, 0, 1);
      this.uxTableLayoutPanelMain.Controls.Add(this.uxDateTimePickerStartDate, 1, 1);
      this.uxTableLayoutPanelMain.Controls.Add(this.label3, 0, 2);
      this.uxTableLayoutPanelMain.Controls.Add(this.uxDateTimePickerStartTime, 1, 2);
      this.uxTableLayoutPanelMain.Controls.Add(this.label5, 0, 3);
      this.uxTableLayoutPanelMain.Controls.Add(this.uxDateTimePickerEndTime, 1, 3);
      this.uxTableLayoutPanelMain.Controls.Add(this.label6, 0, 4);
      this.uxTableLayoutPanelMain.Controls.Add(this.uxNumericUpDownEvery, 1, 4);
      this.uxTableLayoutPanelMain.Controls.Add(this.label7, 2, 4);
      this.uxTableLayoutPanelMain.Controls.Add(this.label4, 0, 5);
      this.uxTableLayoutPanelMain.Controls.Add(this.uxNumericUpDownNumberOfWeeks, 1, 5);
      this.uxTableLayoutPanelMain.Controls.Add(this.label8, 2, 5);
      this.uxTableLayoutPanelMain.Controls.Add(this.uxLabelToDate, 3, 5);
      this.uxTableLayoutPanelMain.Controls.Add(this.uxButtonAddToCalendar, 1, 6);
      this.uxTableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Top;
      this.uxTableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
      this.uxTableLayoutPanelMain.Name = "uxTableLayoutPanelMain";
      this.uxTableLayoutPanelMain.RowCount = 7;
      this.uxTableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.uxTableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.uxTableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.uxTableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.uxTableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.uxTableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.uxTableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.uxTableLayoutPanelMain.Size = new System.Drawing.Size(378, 185);
      this.uxTableLayoutPanelMain.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Course name:";
      this.uxToolTipMain.SetToolTip(this.label1, "The name of the course. The app will append \" - Week n\" for each week.");
      // 
      // uxTextBoxCourseName
      // 
      this.uxTextBoxCourseName.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.uxTableLayoutPanelMain.SetColumnSpan(this.uxTextBoxCourseName, 3);
      this.uxTextBoxCourseName.Location = new System.Drawing.Point(81, 3);
      this.uxTextBoxCourseName.Name = "uxTextBoxCourseName";
      this.uxTextBoxCourseName.Size = new System.Drawing.Size(250, 20);
      this.uxTextBoxCourseName.TabIndex = 1;
      this.uxToolTipMain.SetToolTip(this.uxTextBoxCourseName, "The name of the course. The app will append \" - Week n\" for each week.");
      this.uxTextBoxCourseName.TextChanged += new System.EventHandler(this.uxTextBoxCourseName_TextChanged);
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(19, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Start date:";
      // 
      // uxDateTimePickerStartDate
      // 
      this.uxDateTimePickerStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.uxTableLayoutPanelMain.SetColumnSpan(this.uxDateTimePickerStartDate, 3);
      this.uxDateTimePickerStartDate.CustomFormat = "ddd dd-MM-yyyy";
      this.uxDateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.uxDateTimePickerStartDate.Location = new System.Drawing.Point(81, 29);
      this.uxDateTimePickerStartDate.Name = "uxDateTimePickerStartDate";
      this.uxDateTimePickerStartDate.Size = new System.Drawing.Size(120, 20);
      this.uxDateTimePickerStartDate.TabIndex = 3;
      this.uxDateTimePickerStartDate.ValueChanged += new System.EventHandler(this.uxDateTimePickerStartDate_ValueChanged);
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(21, 58);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(54, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Start time:";
      // 
      // uxDateTimePickerStartTime
      // 
      this.uxDateTimePickerStartTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.uxTableLayoutPanelMain.SetColumnSpan(this.uxDateTimePickerStartTime, 3);
      this.uxDateTimePickerStartTime.CustomFormat = "HH:mm";
      this.uxDateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.uxDateTimePickerStartTime.Location = new System.Drawing.Point(81, 55);
      this.uxDateTimePickerStartTime.Name = "uxDateTimePickerStartTime";
      this.uxDateTimePickerStartTime.ShowUpDown = true;
      this.uxDateTimePickerStartTime.Size = new System.Drawing.Size(120, 20);
      this.uxDateTimePickerStartTime.TabIndex = 5;
      this.uxDateTimePickerStartTime.Value = new System.DateTime(2022, 1, 27, 14, 0, 0, 0);
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(53, 136);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(22, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "For";
      // 
      // uxDateTimePickerEndTime
      // 
      this.uxDateTimePickerEndTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.uxTableLayoutPanelMain.SetColumnSpan(this.uxDateTimePickerEndTime, 3);
      this.uxDateTimePickerEndTime.CustomFormat = "HH:mm";
      this.uxDateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.uxDateTimePickerEndTime.Location = new System.Drawing.Point(81, 81);
      this.uxDateTimePickerEndTime.Name = "uxDateTimePickerEndTime";
      this.uxDateTimePickerEndTime.ShowUpDown = true;
      this.uxDateTimePickerEndTime.Size = new System.Drawing.Size(120, 20);
      this.uxDateTimePickerEndTime.TabIndex = 7;
      this.uxDateTimePickerEndTime.Value = new System.DateTime(2022, 1, 27, 16, 0, 0, 0);
      // 
      // label5
      // 
      this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(24, 84);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(51, 13);
      this.label5.TabIndex = 6;
      this.label5.Text = "End time:";
      // 
      // uxNumericUpDownNumberOfWeeks
      // 
      this.uxNumericUpDownNumberOfWeeks.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.uxNumericUpDownNumberOfWeeks.Location = new System.Drawing.Point(81, 133);
      this.uxNumericUpDownNumberOfWeeks.Name = "uxNumericUpDownNumberOfWeeks";
      this.uxNumericUpDownNumberOfWeeks.Size = new System.Drawing.Size(61, 20);
      this.uxNumericUpDownNumberOfWeeks.TabIndex = 12;
      this.uxNumericUpDownNumberOfWeeks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.uxNumericUpDownNumberOfWeeks.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.uxNumericUpDownNumberOfWeeks.ValueChanged += new System.EventHandler(this.uxNumericUpDownNumberOfWeeks_ValueChanged);
      // 
      // uxButtonAddToCalendar
      // 
      this.uxButtonAddToCalendar.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.uxButtonAddToCalendar.AutoSize = true;
      this.uxTableLayoutPanelMain.SetColumnSpan(this.uxButtonAddToCalendar, 3);
      this.uxButtonAddToCalendar.Enabled = false;
      this.uxButtonAddToCalendar.Location = new System.Drawing.Point(81, 159);
      this.uxButtonAddToCalendar.Name = "uxButtonAddToCalendar";
      this.uxButtonAddToCalendar.Size = new System.Drawing.Size(92, 23);
      this.uxButtonAddToCalendar.TabIndex = 15;
      this.uxButtonAddToCalendar.Text = "Add to calendar";
      this.uxToolTipMain.SetToolTip(this.uxButtonAddToCalendar, "Generate and run an iCalendar file (.ics) for import into Outlook.");
      this.uxButtonAddToCalendar.UseVisualStyleBackColor = true;
      this.uxButtonAddToCalendar.Click += new System.EventHandler(this.uxButtonAddToCalendar_Click);
      // 
      // label6
      // 
      this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(41, 110);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(34, 13);
      this.label6.TabIndex = 8;
      this.label6.Text = "Every";
      // 
      // uxNumericUpDownEvery
      // 
      this.uxNumericUpDownEvery.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.uxNumericUpDownEvery.Location = new System.Drawing.Point(81, 107);
      this.uxNumericUpDownEvery.Name = "uxNumericUpDownEvery";
      this.uxNumericUpDownEvery.Size = new System.Drawing.Size(61, 20);
      this.uxNumericUpDownEvery.TabIndex = 9;
      this.uxNumericUpDownEvery.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.uxNumericUpDownEvery.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.uxNumericUpDownEvery.ValueChanged += new System.EventHandler(this.uxNumericUpDownEvery_ValueChanged);
      // 
      // label7
      // 
      this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(148, 110);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(38, 13);
      this.label7.TabIndex = 10;
      this.label7.Text = "weeks";
      // 
      // label8
      // 
      this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(148, 136);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(66, 13);
      this.label8.TabIndex = 13;
      this.label8.Text = "occurrences";
      // 
      // uxLabelToDate
      // 
      this.uxLabelToDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.uxLabelToDate.AutoSize = true;
      this.uxLabelToDate.Enabled = false;
      this.uxLabelToDate.Location = new System.Drawing.Point(220, 136);
      this.uxLabelToDate.Name = "uxLabelToDate";
      this.uxLabelToDate.Size = new System.Drawing.Size(0, 13);
      this.uxLabelToDate.TabIndex = 14;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(378, 215);
      this.Controls.Add(this.uxTableLayoutPanelMain);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Course Calendar";
      this.uxTableLayoutPanelMain.ResumeLayout(false);
      this.uxTableLayoutPanelMain.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownNumberOfWeeks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownEvery)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel uxTableLayoutPanelMain;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox uxTextBoxCourseName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker uxDateTimePickerStartDate;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DateTimePicker uxDateTimePickerStartTime;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DateTimePicker uxDateTimePickerEndTime;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown uxNumericUpDownNumberOfWeeks;
    private System.Windows.Forms.Button uxButtonAddToCalendar;
    private System.Windows.Forms.ToolTip uxToolTipMain;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown uxNumericUpDownEvery;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label uxLabelToDate;
  }
}

