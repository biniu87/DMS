using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class Extension
    {
        /// <summary>
        /// Rozszerzenie pozwalające przygotować stringa do wprowadzenia go do bazy przez insert
        /// </summary>
        /// <param name="insertString"></param>
        /// <returns></returns>
        public static string ToInsert(this string insertString)
        {
            return insertString.Replace("'", "''");
        }
    }
}
