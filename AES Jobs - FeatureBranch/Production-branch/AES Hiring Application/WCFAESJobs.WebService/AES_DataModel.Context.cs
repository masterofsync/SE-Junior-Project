﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFAESJobs.WebService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_9E5950_aes01Entities2 : DbContext
    {
        public DB_9E5950_aes01Entities2()
            : base("name=DB_9E5950_aes01Entities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AnswerTable> AnswerTables { get; set; }
        public virtual DbSet<ApplicantTable> ApplicantTables { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AvailableJob> AvailableJobs { get; set; }
        public virtual DbSet<JobApplication> JobApplications { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<MultipleChoiceAnswer> MultipleChoiceAnswers { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<QuestionList> QuestionLists { get; set; }
        public virtual DbSet<StageTable> StageTables { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<WorkHistory> WorkHistories { get; set; }
    }
}
