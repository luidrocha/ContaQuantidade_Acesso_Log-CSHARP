using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContantoQuantidadeDeacessosLog.Entities
{
    class LogRecord
    {
        public string UserName { get; set; }
        public DateTime Data { get; set; }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LogRecord))
            {
                return false;
            }

            LogRecord reg = obj as LogRecord;

            return UserName.Equals(reg.UserName);
        }
    }
}
