﻿using System;
using System.Collections.Generic;
using System.Linq;

using LinqToDB;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Settings;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.DataModels.Applications;

namespace TransferLogger.BusinessLogic.Models
{
    public class EvaluationModel : IIdentifiable
    {
        public int              Id                { get; set; }
        public EvaluationStatus Status            { get; set; }
        public string           StatusDisplayName { get; set; }
        public int              ApplicationId     { get; set; }
        public DateTime         ApplicationDt     { get; set; }
        public int              StudentId         { get; set; }
        public string           Student           { get; set; }
        public string           Organization      { get; set; }
        public int              CourseId          { get; set; }
        public string           CourseCode        { get; set; }
        public string           Course            { get; set; }
        public int?             MatchedCourseId   { get; set; }
        public string           MatchedCourse     { get; set; }
        public int?             SuggestedCourseId { get; set; }
        public string           SuggestedCourse   { get; set; }
        public int              InstructorId      { get; set; }
        public string           Instructor        { get; set; }
        public string           Comment           { get; set; }

        public EvaluationModel(Evaluation evaluation, Application app)
        {
            Id                = evaluation.EvaluationId;
            Status            = evaluation.EvaluationStatus;
            StatusDisplayName = evaluation.EvaluationStatus.GetDisplayName();
            ApplicationId     = evaluation.ApplicationId;
            ApplicationDt     = app.CreatedAt.ToLocalTime();
            StudentId         = app.Student.StudentId;
            Student           = app.Student.DisplayString;
            Organization      = app.SourceOrganization.DisplayString;
            CourseId          = evaluation.CourseId;
            CourseCode        = evaluation.Course.CourseCode;
            Course            = evaluation.Course.DisplayString;
            MatchedCourseId   = evaluation.MatchedCourseId;
            MatchedCourse     = evaluation.MatchedCourse?.DisplayString ?? string.Empty;
            SuggestedCourseId = evaluation.SuggestedCourseId;
            SuggestedCourse   = evaluation.SuggestedCourse?.DisplayString ?? string.Empty;
            InstructorId      = evaluation.InstructorId;
            Instructor        = evaluation.Instructor.DisplayString;
            Comment           = evaluation.Comment;
        }

        public EvaluationModel(Evaluation evaluation) : this(evaluation, evaluation.Application) {}

        public static List<EvaluationModel> GetHistoricalEvaluations(int courseId)
        {
            using var dc = new Dc();

            return dc.GetEvaluations()
                .Where(e => e.CourseId == courseId)
                .Where(e => e.Application.SourceOrganizationId != AppSettings.Instance.OrganizationId)
                .Where(e => e.EvaluationStatus == EvaluationStatus.Matched || e.EvaluationStatus == EvaluationStatus.NotMatched)
                .Select(e => new EvaluationModel(e))
                .ToList();
        }
    }
}
