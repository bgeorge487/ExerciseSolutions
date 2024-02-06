using System;
static class LogLine
{
    /*
     This was my solution to exercism.org's C# version of "Log Levels" which can be found
    here: https://exercism.org/tracks/csharp/exercises/log-levels

    The instructions were as follows:
    In this exercise you'll be processing log-lines.

    Each log line is a string formatted as follows: "[<LEVEL>]: <MESSAGE>".

    There are three different log levels:

        INFO
        WARNING
        ERROR

    You have three tasks, each of which will take a log line 
    and ask you to do something with it.
     */

    //Task 1:
    /*
     Implement the (static) LogLine.Message() method to return a log line's message:

            LogLine.Message("[ERROR]: Invalid operation")
            // => "Invalid operation"
     
         Any leading or trailing white space should be removed:

            LogLine.Message("[WARNING]:  Disk almost full\r\n")
            // => "Disk almost full"
     */
    public static string Message(string logLine)
    {
        int index = logLine.IndexOf(":") + ":".Length;
        string logLineMessage = logLine.Substring(index);
        return logLineMessage.Trim();
    }

    //Task 2:
    /*
      Get log level from a log line
 
        Implement the (static) LogLine.LogLevel() method to return a log line's log level, 
        which should be returned in lowercase:

            LogLine.LogLevel("[ERROR]: Invalid operation")
            // => "error"     
     */
    public static string LogLevel(string logLine)
    {
        int first = logLine.IndexOf("[") + 1;
        int last = logLine.LastIndexOf("]") - 1;
        string logLevelReturn = logLine.Substring(first, last);
        return logLevelReturn.ToLower();
    }

    //Task 3
    /*
     Reformat a log line

        Implement the (static) LogLine.Reformat() method that reformats the log line,
        putting the message first and the log level after it in parentheses:

            LogLine.Reformat("[INFO]: Operation completed")
            // => "Operation completed (info)"     
     */

    public static string Reformat(string logLine)
    {
        int messageIndex = logLine.IndexOf(":") + ":".Length;
        int first = logLine.IndexOf("[") + 1;
        int last = logLine.LastIndexOf("]") - 1;
        string logLevel = logLine.Substring(first, last).ToLower();
        string message = logLine.Substring(messageIndex).Trim();
        string reformatedMessage = $"{message} ({logLevel})";
        return reformatedMessage;
    }
}