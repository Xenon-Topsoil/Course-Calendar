﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;

namespace Course_Calendar {
  public partial class FormMain : Form {

    public FormMain() {
      InitializeComponent();
      uxDateTimePickerStartDate.Value = DateTime.Now;
    }

    private void uxButtonAddToCalendar_Click(object sender, EventArgs e) {
      // Check the course name.
      if (string.IsNullOrEmpty(uxTextBoxCourseName.Text)) {
        MessageBoxExt.ShowError("Tou must supply a course name.");
        return;
      }

      // The course start is the date value from the course start date picker, plus the time value from the course start time picker.
      DateTime start = uxDateTimePickerStartDate.Value.Date + uxDateTimePickerStartTime.Value.TimeOfDay;

      // The course end is the date value from the course start date picker, plus the time value from the course end time picker.
      DateTime end = uxDateTimePickerStartDate.Value.Date + uxDateTimePickerEndTime.Value.TimeOfDay;

      // Generate and shell to a temp iCalendar file, for Outlook to import.
      bool success = CourseGenerator.GenerateCourseCalendar(uxTextBoxCourseName.Text, start, end, (int)uxNumericUpDownNumberOfWeeks.Value);

      // Show success or fail message.
      if (success) {
        MessageBoxExt.ShowInformation("Course event file created and run.");
      }
      else {
        MessageBoxExt.ShowError("Failed to create course event file.");
      }
    }

  }
}
