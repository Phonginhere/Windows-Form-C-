using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Score
    {
        public int ScoreID { get; set; }
        public String ScoreName { get; set; }
        public int ScoreMath { get; set; }
        public int ScoreLiterature { get; set; }
        public int ScoreEnglish { get; set; }
        public int studentId { get; set; }
        public Student students { get; set; }
    }
}