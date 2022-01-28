using System;
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
      CourseGenerator courseGenerator = new CourseGenerator();
      DateTime start = uxDateTimePickerStartDate.Value.Date + uxDateTimePickerStartTime.Value.TimeOfDay;
      DateTime end = uxDateTimePickerStartDate.Value.Date + uxDateTimePickerEndTime.Value.TimeOfDay;
      bool success = courseGenerator.GenerateCourseCalendar(uxTextBoxCourseName.Text, start, end, (int)uxNumericUpDownNumberOfWeeks.Value);
      if (success) {
        MessageBoxExt.ShowInformation("Course event file created and run.");
      }
      else {
        MessageBoxExt.ShowError("Failed to create course event file.");
      }
    }

  }
}
