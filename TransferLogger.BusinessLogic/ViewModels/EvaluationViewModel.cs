using System;
using System.Collections.Generic;
using System.Linq;

using LinqToDB;

using TransferLogger.BusinessLogic.Settings;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;

namespace TransferLogger.BusinessLogic.ViewModels
{
    public class EvaluationViewModel
    {
        public int              Id                { get; set; }
        public EvaluationStatus Status            { get; set; }
        public string           StatusDisplayName { get; set; }
        public int              ApplicationId     { get; set; }
        public DateTime         ApplicationDt     { get; set; }
        public int              StudentId         { get; set; }
        public string           Student           { get; set; }
        public int              CourseId          { get; set; }
        public string           Course            { get; set; }
        public string           Organization      { get; set; }
        public int?             MatchedCourseId   { get; set; }
        public string           MatchedCourse     { get; set; }
        public int              InstructorId      { get; set; }
        public string           Instructor        { get; set; }
        public string           Comment           { get; set; }

        public EvaluationViewModel(Evaluation evaluation)
        {
            Id                = evaluation.EvaluationId;
            Status            = evaluation.EvaluationStatus;
            StatusDisplayName = evaluation.EvaluationStatus.GetDisplayName();
            ApplicationId     = evaluation.ApplicationId;
            ApplicationDt     = evaluation.Application.CreatedAt.ToLocalTime();
            StudentId         = evaluation.Application.Student.StudentId;
            Student           = evaluation.Application.Student.DisplayString;
            CourseId          = evaluation.CourseId;
            Course            = evaluation.Course.DisplayString;
            MatchedCourseId   = evaluation.MatchedCourseId;
            MatchedCourse     = evaluation.MatchedCourse?.DisplayString ?? string.Empty;
            Organization      = evaluation.Application.SourceOrganization.DisplayString;
            InstructorId      = evaluation.InstructorId;
            Instructor        = evaluation.Instructor.DisplayString;
            Comment           = evaluation.Comment;
        }

        private static IQueryable<Evaluation> GetQuery(Dc dc)
        {
            return dc.Evaluations
                .LoadWith(e => e.Application)
                .LoadWith(e => e.Application.Student)
                .LoadWith(e => e.Application.SourceOrganization)
                .LoadWith(e => e.Course)
                .LoadWith(e => e.MatchedCourse)
                .LoadWith(e => e.Instructor);
        }

        public static List<EvaluationViewModel> GetHistoricalEvaluations(int courseId)
        {
            using var dc = new Dc();

            return GetQuery(dc)
                .Where(e => e.CourseId == courseId)
                .Where(e => e.Application.SourceOrganizationId != AppSettings.Instance.OrganizationId)
                .Where(e => e.EvaluationStatus != EvaluationStatus.InProcess)
                .Select(e => new EvaluationViewModel(e))
                .ToList();
        }
    }
}
