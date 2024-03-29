﻿using System;
using System.Collections.Generic;
using System.Linq;

using LinqToDB;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels.Applications;

namespace TransferLogger.BusinessLogic.Models
{
    public class ApplicationModel : IIdentifiable
    {
        public int                   Id                { get; set; }
        public ApplicationStatus     Status            { get; set; }
        public string                StatusDisplayName { get; set; }
        public string                Student           { get; set; }
        public string                Organization      { get; set; }
        public string                TargetProgram     { get; set; }
        public DateTime              CreatedAt         { get; set; }
        public DateTime?             UpdatedAt         { get; set; }
        public DateTime?             CompletedAt       { get; set; }
        public List<EvaluationModel> Evaluations       { get; set; }

        public string CreatedAtDisplay => CreatedAt.ToDisplayString();

        public ApplicationModel(Application app)
        {
            Id                = app.ApplicationId;
            Status            = app.ApplicationStatus;
            StatusDisplayName = app.ApplicationStatus.GetDisplayName();
            Student           = app.Student.DisplayString;
            Organization      = app.SourceOrganization.DisplayString;
            TargetProgram     = app.TargetProgram.DisplayString;
            CreatedAt         = app.CreatedAt.ToLocalTime();
            UpdatedAt         = app.UpdatedAt?.ToLocalTime() ?? null;
            CompletedAt       = app.CompletedAt?.ToLocalTime() ?? null;

            Evaluations = app.Evaluations
                .Select(e => new EvaluationModel(e, app))
                .ToList();
        }

        public static List<ApplicationModel> GetList(string studentName = "", int organizationId = 0, ApplicationStatus? status = null, DateTime? from = null, DateTime? to = null)
        {
            using var dc = new Dc();

            var query = dc.Applications.AsQueryable();

            studentName = studentName.Replace(" ", string.Empty);

            if (!string.IsNullOrEmpty(studentName))
                query = query.Where(a => $"{a.Student.Name}{a.Student.Middle}{a.Student.Surname}"
                    .Replace(" ", string.Empty)
                    .Contains(studentName));

            if (organizationId > 0)
                query = query.Where(a => a.SourceOrganizationId == organizationId);

            if (status.HasValue)
                query = query.Where(a => a.ApplicationStatus == status.Value);

            if (from.HasValue)
                query = query.Where(a => a.CreatedAt > from.Value);

            if (to.HasValue)
                query = query.Where(a => a.CreatedAt < to.Value);

            return query
                .LoadWith(a => a.Student)
                .LoadWith(a => a.SourceOrganization)
                .LoadWith(a => a.TargetProgram)
                .LoadWith(a => a.Evaluations)
                .ThenLoad(e => e.Course)
                .LoadWith(a => a.Evaluations)
                .ThenLoad(e => e.Instructor)
                .OrderByDescending(a => a.ApplicationId)
                .Select(a => new ApplicationModel(a))
                .ToList();
        }
    }
}
