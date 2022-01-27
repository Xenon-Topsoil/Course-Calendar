using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Calendar {
  internal class CourseGenerator {

    private const string _dateTimeFormat = "yyyyMMddTHHmmss";
    private readonly static TimeSpan _oneWeek = TimeSpan.FromDays(7);

    public bool GenerateCourseCalendar(string courseName, DateTime start, DateTime end, int numberOfWeeks) {
      string filename = Path.Combine(Path.GetTempPath(), $"{SanitizeFilename(courseName, '_')}.ics");
      DateTime timestamp = DateTime.Now;
      Guid guid = Guid.NewGuid();

      //using (StringWriter writer = new StringWriter()) {
      using (StreamWriter writer = new StreamWriter(filename)) {
        writer.WriteLine("BEGIN:VCALENDAR");
        writer.WriteLine("VERSION:2.0");
        writer.WriteLine("CourseGenerator");
        WriteFirstEvent(writer, timestamp, guid, start, end, courseName, 1, numberOfWeeks);
        start += _oneWeek;
        end += _oneWeek;
        for (int weekNumber = 2; weekNumber <= numberOfWeeks; weekNumber++) {
          WriteSubsequentEvent(writer, timestamp, guid, start, end, courseName, weekNumber);
          start += _oneWeek;
          end += _oneWeek;
        }
        writer.WriteLine("END:VCALENDAR");
        Clipboard.SetText(writer.ToString());
      }

      return ShellToDocument(filename);
      //return true;
    }

    private static string SanitizeFilename(string filename, char replaceChar) {
      var invalid = Path.GetInvalidFileNameChars();
      return new string(filename.Select(ch => invalid.Contains(ch) ? replaceChar : ch).ToArray());
    }

    private static void WriteFirstEvent(TextWriter writer, DateTime timestamp, Guid guid, DateTime start, DateTime end, string summary, int weekNumber, int numberOfWeeks) {
      WriteEventStart(writer);
      WriteEventCommon(writer, timestamp, guid, start, end, summary, weekNumber);
      writer.WriteLine("RRULE:FREQ=WEEKLY;COUNT={0};BYDAY={1}", numberOfWeeks, start.ToString("ddd").Substring(0,2).ToUpper());
      WriteEventEnd(writer);
    }

    private static void WriteSubsequentEvent(TextWriter writer, DateTime timestamp, Guid guid, DateTime start, DateTime end, string summary, int weekNumber) {
      WriteEventStart(writer);
      WriteEventCommon(writer, timestamp, guid, start, end, summary, weekNumber);
      writer.WriteLine("RECURRENCE-ID:{0:yyyyMMddTHHmmss}", start);
      WriteEventEnd(writer);
    }

    private static void WriteEventStart(TextWriter writer) {
      writer.WriteLine("BEGIN:VEVENT");
    }

    private static void WriteEventEnd(TextWriter writer) {
      writer.WriteLine("END:VEVENT");
    }

    private static void WriteEventCommon(TextWriter writer, DateTime timestamp, Guid guid, DateTime start, DateTime end, string summary, int weekNumber) {
      writer.WriteLine("DTSTAMP:{0:yyyyMMddTHHmmss}", timestamp);
      writer.WriteLine("UID:{0}", guid);
      writer.WriteLine("DTSTART:{0:yyyyMMddTHHmmss}", start);
      writer.WriteLine("DTEND:{0:yyyyMMddTHHmmss}", end);
      writer.WriteLine(@"DESCRIPTION: \n");
      writer.WriteLine("SUMMARY:{0} - Week {1}", summary, weekNumber);
    }

    /// <summary>
    /// Shell to a file if it exists. File is opened with application registered for its extension.
    /// </summary>
    /// <returns>True if file exists, else false.</returns>
    public static bool ShellToDocument(string filename) {
      bool fileExists = File.Exists(filename);
      if (fileExists == true) {
        System.Diagnostics.Process proc = new System.Diagnostics.Process { EnableRaisingEvents = false };
        proc.StartInfo.FileName = filename;
        proc.Start();
      }
      return fileExists;
    }

  }
}
