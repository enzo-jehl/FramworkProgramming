using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace IUP_BMI_Calculator.Model
{
    [Table("BMIResult")]
    public class BMIResult
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        [MaxLength(250), Unique]
        public string Name { get; set; }

        [MaxLength(100), Unique]
        public  double height { get; set; }

        [MaxLength(100), Unique]
        public double weight { get; set; }

        [MaxLength(100), Unique]
        public double BMIScore { get; set; }

        [MaxLength(100), Unique]
        public string BMIresult { get; set; }
    }
}
