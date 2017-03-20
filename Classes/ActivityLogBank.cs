using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MPosInfoManagementSystem
{
    class ActivityLogBank
    {
        SelectDeleteFunctions SF = new SelectDeleteFunctions();
        InsertUpdateFunctions IF = new InsertUpdateFunctions();
     

        public void ActivityLogging(int personnelID, string logAbout)
        {
            int logNo = SF.RecentLogNo() + 1;
            IF.InsertActivities(logNo, personnelID, logAbout, DateTime.Now);
        }
    }
}
