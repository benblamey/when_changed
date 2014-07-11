using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace when_changed
{
    enum State
    {
        Watching,
        WaitingToExecute,
        Executing,
        ExecutingDirty,
    }
}
