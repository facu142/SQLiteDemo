using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo.Models
{
    // [Table("NombreDeLaTabla")] Para poner un nombre de tabla distinto
    public class StudentModel
    {
        [PrimaryKey, AutoIncrement]
        public int StudentID { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
