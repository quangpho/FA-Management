using DAL.Migrations;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class FAMContext : DbContext
	{
		public FAMContext() : base("name=FAMDbContext")
		{
			Database.SetInitializer<FAMContext>(new MigrateDatabaseToLatestVersion<FAMContext, Configuration>());
		}

		public virtual DbSet<Channel> Channels { get; set; }
		public virtual DbSet<EntryTest> EntryTests { get; set; }
		public virtual DbSet<Offer> Offers { get; set; }
		public virtual DbSet<Interview> Interviews { get; set; }
		public virtual DbSet<Candidate> Candidates { get; set; }
		public virtual DbSet<Faculty> Faculties { get; set; }
		public virtual DbSet<University> Universities { get; set; }
		public virtual DbSet<TraineeCandidateProfile> TraineeCandidateProfiles { get; set; }

		//G3
		public virtual DbSet<Allowance> Allowances { get; set; }
		public virtual DbSet<AllowanceGroup> AllowanceGroups { get; set; }
		public virtual DbSet<AttendantStatus> AttendantStatus { get; set; }
		public virtual DbSet<GPA> GPAs { get; set; }
		public virtual DbSet<Guarantee> Guarantees { get; set; }
		public virtual DbSet<InterviewValuation> InterviewValuations { get; set; }
		public virtual DbSet<MilestoneConfiguration> MilestoneConfigurations { get; set; }
		public virtual DbSet<RewardPenalty> RewardPenalties { get; set; }
		public virtual DbSet<Status> Status { get; set; }

		public virtual DbSet<StatusInClass> StatusInClass { get; set; }
		public virtual DbSet<Topic> Topics { get; set; }
		public virtual DbSet<Trainee> Trainees { get; set; }

		//G1
		public virtual DbSet<ClassBatch> ClassBatchs { get; set; }
		public virtual DbSet<Location> Locations { get; set; }
		public virtual DbSet<SubjectType> SubjectTypes { get; set; }
		public virtual DbSet<Sub_SubjectType> Sub_SubjectTypes { get; set; }
		public virtual DbSet<DelivaryType> DeliveryTypes { get; set; }
		public virtual DbSet<FormatType> FormatType { get; set; }
		public virtual DbSet<Scope> Scopes { get; set; }
		public virtual DbSet<SupplierPartner> SupplierPartners { get; set; }
		public virtual DbSet<Budget> Buggets { get; set; }

		public virtual DbSet<Trainer> Trainers { get; set; }
		public virtual DbSet<TrainerProfile> TrainerProfiles { get; set; }
		public virtual DbSet<Audit> Audits { get; set; }
		public virtual DbSet<LearningPath> LearningPath { get; set; }
		public virtual DbSet<ClassAdmin> ClassAdmins { get; set; }
		//public DbSet<ClassAdminProfile> ClassAdminProfiles { get; set; }
		public virtual DbSet<EventCatagory> EventCatagories { get; set; }
		public virtual DbSet<User> Users { get; set; }
	}
}
