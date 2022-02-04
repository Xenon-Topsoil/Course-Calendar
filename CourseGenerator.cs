using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Course_Calendar {
  internal static class CourseGenerator {

    /// <summary>
    /// Create a event series for a weekly course by generating and shelling to a temporary iCalendar file for Outlook to import from.
    /// </summary>
    /// <param name="courseName">Course name to use as the event summary. It gets appended with week number information.</param>
    /// <param name="start">Week 1 start date and time.</param>
    /// <param name="end">Week 1 end date and time.</param>
    /// <param name="weekInterval">Number of weeks between occurrences.</param>
    /// <param name="numberOfWeeks">Course length in weeks.</param>
    /// <returns>True on success.</returns>
    public static bool GenerateCourseCalendar(string courseName, DateTime start, DateTime end, int weekInterval, int numberOfOccurrences) {
      // We are creating a temp ics file using the (sanitized) course name.
      string filename = Path.Combine(Path.GetTempPath(), $"{SanitizeFilename(courseName, '_')}.ics");

      // Get the current timestamp to use for all the events.
      DateTime timestamp = DateTime.Now;

      // Use a GUID as the unique ID for the event series.
      Guid guid = Guid.NewGuid();

      using (StreamWriter writer = new StreamWriter(filename)) {
        // Write the calendar start lines. For the Product ID we use the application product name and the first two parts of the product version.
        writer.WriteLine("BEGIN:VCALENDAR");
        writer.WriteLine("VERSION:2.0");
        string[] productVersion = Application.ProductVersion.Split('.');
        writer.WriteLine("PRODID:{0} {1}.{2}", Application.ProductName, productVersion[0], productVersion[1]);

        // Write the event series lines.
        WriteFirstEvent(writer, timestamp, guid, start, end, courseName, 1, weekInterval, numberOfOccurrences);

        // For all the individual events except the first, write overriding event lines to modify the summary.
        TimeSpan interval = TimeSpan.FromDays(7 * weekInterval);
        start += interval;
        end += interval;
        for (int occurrenceNumber = 2; occurrenceNumber <= numberOfOccurrences; occurrenceNumber++) {
          WriteSubsequentEvent(writer, timestamp, guid, start, end, courseName, occurrenceNumber);
          start += interval;
          end += interval;
        }

        // Write the calendar end line.
        writer.WriteLine("END:VCALENDAR");
      }

      // Shell to the generated iCalendar file, so that Outlook can import it.
      return ShellToDocument(filename);
    }

    /// <summary>
    /// Sanitize the filename by replacing invalid characters with the specified replacement character.
    /// </summary>
    private static string SanitizeFilename(string filename, char replaceChar) {
      var invalid = Path.GetInvalidFileNameChars();
      return new string(filename.Select(ch => invalid.Contains(ch) ? replaceChar : ch).ToArray());
    }

    /// <summary>
    /// Write the event series data, including the recurrence information.
    /// </summary>
    private static void WriteFirstEvent(TextWriter writer, DateTime timestamp, Guid guid, DateTime start, DateTime end, string summary, int weekNumber, int weekInterval, int numberOfOccurrences) {
      WriteEventStart(writer);
      WriteEventCommon(writer, timestamp, guid, start, end, summary, weekNumber);
      writer.WriteLine("RRULE:FREQ=WEEKLY;COUNT={0};INTERVAL={1};BYDAY={2}", numberOfOccurrences, weekInterval, start.ToString("ddd").Substring(0,2).ToUpper());
      WriteEventEnd(writer);
    }

    /// <summary>
    /// Write the individual event overriding data, so that a different week number is set in the summary.
    /// </summary>
    private static void WriteSubsequentEvent(TextWriter writer, DateTime timestamp, Guid guid, DateTime start, DateTime end, string summary, int weekNumber) {
      WriteEventStart(writer);
      WriteEventCommon(writer, timestamp, guid, start, end, summary, weekNumber);
      writer.WriteLine("RECURRENCE-ID:{0}", ToIcsDateTime(start));
      WriteEventEnd(writer);
    }

    /// <summary>
    /// Write the common event start data.
    /// </summary>
    private static void WriteEventStart(TextWriter writer) {
      writer.WriteLine("BEGIN:VEVENT");
    }

    /// <summary>
    /// Write the common event end data.
    /// </summary>
    private static void WriteEventEnd(TextWriter writer) {
      writer.WriteLine("END:VEVENT");
    }

    /// <summary>
    /// Write data common to both the event series and the individual event overrides.
    /// </summary>
    private static void WriteEventCommon(TextWriter writer, DateTime timestamp, Guid guid, DateTime start, DateTime end, string summary, int weekNumber) {
      writer.WriteLine("DTSTAMP:{0}", ToIcsDateTime(timestamp));
      writer.WriteLine("UID:{0}", guid);
      writer.WriteLine("DTSTART:{0}", ToIcsDateTime(start));
      writer.WriteLine("DTEND:{0}", ToIcsDateTime(end));
      writer.WriteLine(@"DESCRIPTION: \n");
      writer.WriteLine("SUMMARY:{0} - Week {1}", summary, weekNumber);
    }

    private static string ToIcsDateTime(DateTime dateTime) {
      return dateTime.ToString("yyyyMMddTHHmmss");
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
