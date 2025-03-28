﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using school_hub.Models.Users;
namespace school_hub.Models.Exam
{
    public class StudentExam
    {
        public int StudentExamId { get; set; }
        public int StudentId { get; set; }
        public short ExamId { get; set; }
        //public bool IsPassed { get; set; }
        public DateOnly ExamDate { get; set; }
        public TimeOnly TimeToComlete { get; set; }
        //public byte CountCorrentAnswer { get; set; }
        public ICollection<StudentAnswer> StudentAnswers { get; set; }
        public Student Student { get; set; }
        public Exam Exam { get; set; }
    }
}

