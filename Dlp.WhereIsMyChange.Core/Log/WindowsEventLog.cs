﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Dlp.WhereIsMyChange.Core.Enums;

namespace Dlp.WhereIsMyChange.Core.Log {
    public class WindowsEventLog : AbstractLog {

        public WindowsEventLog() { }

        public override void Log(object logData, LogTypeEnum logType) {
            EventLog eventLog = new EventLog();

            string serializedLogData =  Framework.Serializer.JsonSerialize(logData);

            eventLog.Source = "Dlp.WhereIsMyChange";

            eventLog.WriteEntry(serializedLogData, EventLogEntryType.Information);
        }
    }
}
