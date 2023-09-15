﻿using System.Collections.Generic;

namespace BindOpen.Kernel.Logging.Events
{
    /// <summary>
    /// This interface represents a log event.
    /// </summary>
    public interface IBdoLogEvent : IBdoEvent, ITChild<IBdoCompleteLog>, ITChildClonable<IBdoLogEvent, IBdoCompleteLog>
    {
        /// <summary>
        /// The log.
        /// </summary>
        IBdoCompleteLog Log { get; set; }

        /// <summary>
        /// The result code.
        /// </summary>
        string ResultCode { get; set; }

        /// <summary>
        /// The source.
        /// </summary>
        string Source { get; set; }

        /// <summary>
        /// The stack traces.
        /// </summary>
        IList<IBdoLogEventStackTrace> StackTraces { get; set; }
    }
}