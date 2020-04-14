namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AllowanceGroup",
                c => new
                    {
                        Group = c.String(nullable: false, maxLength: 128),
                        Allowances = c.Int(),
                        Remarks = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Group);
            
            CreateTable(
                "dbo.Allowance",
                c => new
                    {
                        AllowanceId = c.Int(nullable: false, identity: true),
                        TraineeID = c.Int(),
                        ClassID = c.Int(),
                        AllowanceResult = c.Int(),
                        Milestone = c.String(),
                        SalaryPaid = c.Boolean(nullable: false),
                        Level = c.String(),
                        GPA = c.Int(nullable: false),
                        StandardAllowance = c.Int(nullable: false),
                        Remarks = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.AllowanceId)
                .ForeignKey("dbo.Trainee", t => t.TraineeID)
                .Index(t => t.TraineeID);
            
            CreateTable(
                "dbo.Trainee",
                c => new
                    {
                        TraineeCandidateID = c.Int(nullable: false),
                        ClassID = c.Int(),
                        Remarks = c.String(maxLength: 250),
                        StatusID = c.Int(nullable: false),
                        StatusInClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TraineeCandidateID)
                .ForeignKey("dbo.ClassBatches", t => t.ClassID)
                .ForeignKey("dbo.Status", t => t.StatusID, cascadeDelete: true)
                .ForeignKey("dbo.StatusInClasses", t => t.StatusInClassId, cascadeDelete: true)
                .ForeignKey("dbo.TraineeCandidateProfiles", t => t.TraineeCandidateID)
                .Index(t => t.TraineeCandidateID)
                .Index(t => t.ClassID)
                .Index(t => t.StatusID)
                .Index(t => t.StatusInClassId);
            
            CreateTable(
                "dbo.AttendantStatus",
                c => new
                    {
                        AttendantID = c.Int(nullable: false, identity: true),
                        TraineeID = c.Int(),
                        DisciplinePoint = c.Int(),
                        Milestones = c.String(maxLength: 50),
                        LearningDay = c.DateTime(),
                        StatusDate = c.String(),
                        Remarks = c.String(maxLength: 250),
                        Trainee_TraineeCandidateID = c.Int(),
                    })
                .PrimaryKey(t => t.AttendantID)
                .ForeignKey("dbo.Trainee", t => t.Trainee_TraineeCandidateID)
                .Index(t => t.Trainee_TraineeCandidateID);
            
            CreateTable(
                "dbo.ClassBatches",
                c => new
                    {
                        ClassID = c.Int(nullable: false, identity: true),
                        ClassName = c.String(nullable: false, maxLength: 50),
                        ClassCode = c.String(nullable: false, maxLength: 50),
                        ExpectedStartDate = c.DateTime(),
                        ExpectedEndDate = c.DateTime(),
                        DetailLocation = c.String(maxLength: 250),
                        TrainerID = c.Int(nullable: false),
                        ClassAdminID = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                        SubjectTypeID = c.Int(nullable: false),
                        Sub_SubjectTypeID = c.Int(nullable: false),
                        DelivaryTypeID = c.Int(),
                        FormatTypeID = c.Int(),
                        BudgetsID = c.Int(),
                        ScopeID = c.Int(),
                        PlanedTraineeNumber = c.Int(),
                        EstimatedBudget = c.Single(),
                        ActualStartDate = c.DateTime(),
                        ActualEndDate = c.DateTime(),
                        AcceptedTraineeNumber = c.Int(),
                        ActualTraineeNumber = c.Int(),
                        Milestones = c.String(maxLength: 20),
                        Curriculum = c.String(maxLength: 200),
                        Status = c.String(nullable: false, maxLength: 200),
                        Remark = c.String(),
                        History = c.String(),
                    })
                .PrimaryKey(t => t.ClassID)
                .ForeignKey("dbo.Budgets", t => t.BudgetsID)
                .ForeignKey("dbo.ClassAdmins", t => t.ClassAdminID, cascadeDelete: true)
                .ForeignKey("dbo.DelivaryTypes", t => t.DelivaryTypeID)
                .ForeignKey("dbo.FormatTypes", t => t.FormatTypeID)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.Scopes", t => t.ScopeID)
                .ForeignKey("dbo.Sub_SubjectType", t => t.Sub_SubjectTypeID, cascadeDelete: true)
                .ForeignKey("dbo.SubjectTypes", t => t.SubjectTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Trainers", t => t.TrainerID, cascadeDelete: true)
                .Index(t => t.TrainerID)
                .Index(t => t.ClassAdminID)
                .Index(t => t.LocationId)
                .Index(t => t.SubjectTypeID)
                .Index(t => t.Sub_SubjectTypeID)
                .Index(t => t.DelivaryTypeID)
                .Index(t => t.FormatTypeID)
                .Index(t => t.BudgetsID)
                .Index(t => t.ScopeID);
            
            CreateTable(
                "dbo.Audits",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        ClassBatchID = c.Int(nullable: false),
                        Date = c.DateTime(),
                        EventCatogoryID = c.Int(),
                        RelatedPatyPeople = c.String(maxLength: 50),
                        Action = c.String(maxLength: 50),
                        PIC = c.String(maxLength: 50),
                        Deadline = c.DateTime(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.AuditID)
                .ForeignKey("dbo.ClassBatches", t => t.ClassBatchID, cascadeDelete: true)
                .ForeignKey("dbo.EventCatagories", t => t.EventCatogoryID)
                .Index(t => t.ClassBatchID)
                .Index(t => t.EventCatogoryID);
            
            CreateTable(
                "dbo.EventCatagories",
                c => new
                    {
                        EventCatagoryID = c.Int(nullable: false, identity: true),
                        EveCatagoryName = c.String(),
                    })
                .PrimaryKey(t => t.EventCatagoryID);
            
            CreateTable(
                "dbo.Budgets",
                c => new
                    {
                        BudgetID = c.Int(nullable: false, identity: true),
                        BudgetName = c.String(nullable: false),
                        Remark = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.BudgetID);
            
            CreateTable(
                "dbo.ClassAdmins",
                c => new
                    {
                        ClassAdminID = c.Int(nullable: false, identity: true),
                        Account = c.String(maxLength: 10),
                        FullName = c.String(maxLength: 50),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        Phone = c.String(),
                        Email = c.String(maxLength: 60),
                        Remark = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ClassAdminID);
            
            CreateTable(
                "dbo.DelivaryTypes",
                c => new
                    {
                        DelivaryID = c.Int(nullable: false, identity: true),
                        DeliveryName = c.String(),
                        Remark = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.DelivaryID);
            
            CreateTable(
                "dbo.FormatTypes",
                c => new
                    {
                        FormatTypeID = c.Int(nullable: false, identity: true),
                        FormatTypeName = c.String(nullable: false),
                        Remark = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.FormatTypeID);
            
            CreateTable(
                "dbo.LearningPaths",
                c => new
                    {
                        LearningPathID = c.Int(nullable: false),
                        LearningPathName = c.String(nullable: false),
                        RelatefInformation = c.String(),
                    })
                .PrimaryKey(t => t.LearningPathID)
                .ForeignKey("dbo.ClassBatches", t => t.LearningPathID)
                .Index(t => t.LearningPathID);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationID = c.Int(nullable: false, identity: true),
                        Remark = c.String(maxLength: 500),
                        LocationName = c.String(nullable: false, maxLength: 20),
                        Acronym = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.LocationID);
            
            CreateTable(
                "dbo.Scopes",
                c => new
                    {
                        ScopeID = c.Int(nullable: false, identity: true),
                        ScopeName = c.String(nullable: false),
                        Remark = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ScopeID);
            
            CreateTable(
                "dbo.Sub_SubjectType",
                c => new
                    {
                        Sub_SubjectTypeID = c.Int(nullable: false, identity: true),
                        Sub_SubjectTypeName = c.String(nullable: false, maxLength: 50),
                        Remark = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Sub_SubjectTypeID);
            
            CreateTable(
                "dbo.SubjectTypes",
                c => new
                    {
                        SubjectTypeID = c.Int(nullable: false, identity: true),
                        SucjectName = c.String(nullable: false, maxLength: 50),
                        Remark = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.SubjectTypeID);
            
            CreateTable(
                "dbo.SupplierPartners",
                c => new
                    {
                        SupplierPartnerID = c.Int(nullable: false),
                        SupplierPartnerName = c.String(maxLength: 500),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.SupplierPartnerID)
                .ForeignKey("dbo.ClassBatches", t => t.SupplierPartnerID)
                .Index(t => t.SupplierPartnerID);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        TrainerID = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Remark = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.TrainerID);
            
            CreateTable(
                "dbo.TrainerProfiles",
                c => new
                    {
                        TrainerProfileID = c.Int(nullable: false),
                        FullName = c.String(nullable: false, maxLength: 50),
                        Account = c.String(maxLength: 10),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        Unit = c.String(maxLength: 50),
                        Major = c.String(maxLength: 250),
                        Phone = c.String(),
                        Email = c.String(maxLength: 60),
                        Experience = c.String(),
                        Remark = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.TrainerProfileID)
                .ForeignKey("dbo.Trainers", t => t.TrainerProfileID)
                .Index(t => t.TrainerProfileID);
            
            CreateTable(
                "dbo.GPA",
                c => new
                    {
                        GPA_ID = c.Int(nullable: false, identity: true),
                        TraineeID = c.Int(),
                        ClassID = c.Int(),
                        AttentdantID = c.Int(),
                        AllowanceID = c.Int(),
                        Milestone = c.String(),
                        AcademicMark = c.Int(nullable: false),
                        DisciplinaryPoint = c.Int(nullable: false),
                        Bonus = c.Int(nullable: false),
                        Penalty = c.Int(nullable: false),
                        GPA_Result = c.Int(),
                        Remarks = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.GPA_ID)
                .ForeignKey("dbo.Trainee", t => t.TraineeID)
                .Index(t => t.TraineeID);
            
            CreateTable(
                "dbo.Guarantee",
                c => new
                    {
                        GuaranteeID = c.Int(nullable: false, identity: true),
                        TraineeID = c.Int(),
                        FSU = c.String(maxLength: 20),
                        Comments = c.Int(),
                        Salary = c.Single(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        AllocationStatus = c.String(),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.GuaranteeID)
                .ForeignKey("dbo.Trainee", t => t.TraineeID)
                .Index(t => t.TraineeID);
            
            CreateTable(
                "dbo.InterviewValuation",
                c => new
                    {
                        InterviewValuation = c.Int(nullable: false, identity: true),
                        TraineeID = c.Int(),
                        Date = c.DateTime(storeType: "date"),
                        Interviewer = c.String(maxLength: 50),
                        Remarks = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.InterviewValuation)
                .ForeignKey("dbo.Trainee", t => t.TraineeID)
                .Index(t => t.TraineeID);
            
            CreateTable(
                "dbo.MilestoneConfiguration",
                c => new
                    {
                        MilestoneConfigurationId = c.Int(nullable: false, identity: true),
                        MilestoneName = c.String(),
                        TraineeID = c.Int(nullable: false),
                        SalaryPaid = c.Boolean(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        AverageScore = c.Int(),
                        TraineeCandidateID = c.Int(),
                    })
                .PrimaryKey(t => t.MilestoneConfigurationId)
                .ForeignKey("dbo.Trainee", t => t.TraineeCandidateID)
                .Index(t => t.TraineeCandidateID);
            
            CreateTable(
                "dbo.Topic",
                c => new
                    {
                        TopicID = c.Int(nullable: false, identity: true),
                        MilestoneConfigurationId = c.Int(nullable: false),
                        TopicMark = c.Double(),
                        LearningPathID = c.Int(),
                        Remarks = c.String(maxLength: 250),
                        TopicName = c.String(maxLength: 50),
                        MaxScore = c.Double(nullable: false),
                        PassingScore = c.Double(nullable: false),
                        WeightedNumber = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.TopicID)
                .ForeignKey("dbo.MilestoneConfiguration", t => t.MilestoneConfigurationId, cascadeDelete: true)
                .Index(t => t.MilestoneConfigurationId);
            
            CreateTable(
                "dbo.RewardPenalty",
                c => new
                    {
                        RewardPenaltyID = c.Int(nullable: false, identity: true),
                        TraineeID = c.Int(),
                        Milestone = c.String(maxLength: 50),
                        BonusPoint = c.Int(nullable: false),
                        PenaltyPoint = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Reason = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.RewardPenaltyID)
                .ForeignKey("dbo.Trainee", t => t.TraineeID)
                .Index(t => t.TraineeID);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusID = c.Int(nullable: false, identity: true),
                        StatusName = c.String(),
                        Remarks = c.String(maxLength: 250),
                        BatchClassID = c.Int(),
                    })
                .PrimaryKey(t => t.StatusID);
            
            CreateTable(
                "dbo.StatusInClasses",
                c => new
                    {
                        StatusInClassId = c.Int(nullable: false, identity: true),
                        StatusInClassName = c.String(),
                        Remarks = c.String(maxLength: 250),
                        BatchClassID = c.Int(),
                    })
                .PrimaryKey(t => t.StatusInClassId);
            
            CreateTable(
                "dbo.TraineeCandidateProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FullName = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        GraduationDate = c.DateTime(),
                        Phone = c.String(nullable: false, maxLength: 14),
                        Email = c.String(nullable: false, maxLength: 50),
                        Type = c.String(),
                        Skill = c.Int(),
                        ForeignLangguage = c.String(),
                        Level = c.Int(),
                        AllocationStatus = c.String(),
                        History = c.String(),
                        Remarks = c.String(),
                        UniversityId = c.Int(nullable: false),
                        FacultyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.Id)
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true)
                .ForeignKey("dbo.Universities", t => t.UniversityId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.Phone, unique: true)
                .Index(t => t.Email, unique: true)
                .Index(t => t.UniversityId)
                .Index(t => t.FacultyId);
            
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationDate = c.DateTime(),
                        LocationId = c.Int(),
                        Status = c.String(),
                        Remark = c.String(),
                        ChannelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Channels", t => t.ChannelId, cascadeDelete: true)
                .Index(t => t.ChannelId);
            
            CreateTable(
                "dbo.Channels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmplId = c.Int(nullable: false),
                        ChannelName = c.String(),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EntryTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        LangguageValuator = c.Int(nullable: false),
                        LangguageResult = c.Int(nullable: false),
                        TechnicalValuator = c.Int(nullable: false),
                        TechnicalResult = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                        Remarks = c.String(),
                        CandidateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: true)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.Interviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Interviewer = c.Int(nullable: false),
                        Comments = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                        Remarks = c.String(),
                        CandidateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: true)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.Offers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Jobrank = c.Int(nullable: false),
                        Technology = c.Int(nullable: false),
                        ContractType = c.Int(nullable: false),
                        OfferSalary = c.Int(nullable: false),
                        Remarks = c.String(),
                        CandidateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: true)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FacultyName = c.String(),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UniversityName = c.String(),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Allowance", "TraineeID", "dbo.Trainee");
            DropForeignKey("dbo.Trainee", "TraineeCandidateID", "dbo.TraineeCandidateProfiles");
            DropForeignKey("dbo.TraineeCandidateProfiles", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.TraineeCandidateProfiles", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.TraineeCandidateProfiles", "Id", "dbo.Candidates");
            DropForeignKey("dbo.Offers", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.Interviews", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.EntryTests", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.Candidates", "ChannelId", "dbo.Channels");
            DropForeignKey("dbo.Trainee", "StatusInClassId", "dbo.StatusInClasses");
            DropForeignKey("dbo.Trainee", "StatusID", "dbo.Status");
            DropForeignKey("dbo.RewardPenalty", "TraineeID", "dbo.Trainee");
            DropForeignKey("dbo.MilestoneConfiguration", "TraineeCandidateID", "dbo.Trainee");
            DropForeignKey("dbo.Topic", "MilestoneConfigurationId", "dbo.MilestoneConfiguration");
            DropForeignKey("dbo.InterviewValuation", "TraineeID", "dbo.Trainee");
            DropForeignKey("dbo.Guarantee", "TraineeID", "dbo.Trainee");
            DropForeignKey("dbo.GPA", "TraineeID", "dbo.Trainee");
            DropForeignKey("dbo.Trainee", "ClassID", "dbo.ClassBatches");
            DropForeignKey("dbo.ClassBatches", "TrainerID", "dbo.Trainers");
            DropForeignKey("dbo.TrainerProfiles", "TrainerProfileID", "dbo.Trainers");
            DropForeignKey("dbo.SupplierPartners", "SupplierPartnerID", "dbo.ClassBatches");
            DropForeignKey("dbo.ClassBatches", "SubjectTypeID", "dbo.SubjectTypes");
            DropForeignKey("dbo.ClassBatches", "Sub_SubjectTypeID", "dbo.Sub_SubjectType");
            DropForeignKey("dbo.ClassBatches", "ScopeID", "dbo.Scopes");
            DropForeignKey("dbo.ClassBatches", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.LearningPaths", "LearningPathID", "dbo.ClassBatches");
            DropForeignKey("dbo.ClassBatches", "FormatTypeID", "dbo.FormatTypes");
            DropForeignKey("dbo.ClassBatches", "DelivaryTypeID", "dbo.DelivaryTypes");
            DropForeignKey("dbo.ClassBatches", "ClassAdminID", "dbo.ClassAdmins");
            DropForeignKey("dbo.ClassBatches", "BudgetsID", "dbo.Budgets");
            DropForeignKey("dbo.Audits", "EventCatogoryID", "dbo.EventCatagories");
            DropForeignKey("dbo.Audits", "ClassBatchID", "dbo.ClassBatches");
            DropForeignKey("dbo.AttendantStatus", "Trainee_TraineeCandidateID", "dbo.Trainee");
            DropIndex("dbo.Offers", new[] { "CandidateId" });
            DropIndex("dbo.Interviews", new[] { "CandidateId" });
            DropIndex("dbo.EntryTests", new[] { "CandidateId" });
            DropIndex("dbo.Candidates", new[] { "ChannelId" });
            DropIndex("dbo.TraineeCandidateProfiles", new[] { "FacultyId" });
            DropIndex("dbo.TraineeCandidateProfiles", new[] { "UniversityId" });
            DropIndex("dbo.TraineeCandidateProfiles", new[] { "Email" });
            DropIndex("dbo.TraineeCandidateProfiles", new[] { "Phone" });
            DropIndex("dbo.TraineeCandidateProfiles", new[] { "Id" });
            DropIndex("dbo.RewardPenalty", new[] { "TraineeID" });
            DropIndex("dbo.Topic", new[] { "MilestoneConfigurationId" });
            DropIndex("dbo.MilestoneConfiguration", new[] { "TraineeCandidateID" });
            DropIndex("dbo.InterviewValuation", new[] { "TraineeID" });
            DropIndex("dbo.Guarantee", new[] { "TraineeID" });
            DropIndex("dbo.GPA", new[] { "TraineeID" });
            DropIndex("dbo.TrainerProfiles", new[] { "TrainerProfileID" });
            DropIndex("dbo.SupplierPartners", new[] { "SupplierPartnerID" });
            DropIndex("dbo.LearningPaths", new[] { "LearningPathID" });
            DropIndex("dbo.Audits", new[] { "EventCatogoryID" });
            DropIndex("dbo.Audits", new[] { "ClassBatchID" });
            DropIndex("dbo.ClassBatches", new[] { "ScopeID" });
            DropIndex("dbo.ClassBatches", new[] { "BudgetsID" });
            DropIndex("dbo.ClassBatches", new[] { "FormatTypeID" });
            DropIndex("dbo.ClassBatches", new[] { "DelivaryTypeID" });
            DropIndex("dbo.ClassBatches", new[] { "Sub_SubjectTypeID" });
            DropIndex("dbo.ClassBatches", new[] { "SubjectTypeID" });
            DropIndex("dbo.ClassBatches", new[] { "LocationId" });
            DropIndex("dbo.ClassBatches", new[] { "ClassAdminID" });
            DropIndex("dbo.ClassBatches", new[] { "TrainerID" });
            DropIndex("dbo.AttendantStatus", new[] { "Trainee_TraineeCandidateID" });
            DropIndex("dbo.Trainee", new[] { "StatusInClassId" });
            DropIndex("dbo.Trainee", new[] { "StatusID" });
            DropIndex("dbo.Trainee", new[] { "ClassID" });
            DropIndex("dbo.Trainee", new[] { "TraineeCandidateID" });
            DropIndex("dbo.Allowance", new[] { "TraineeID" });
            DropTable("dbo.Users");
            DropTable("dbo.Universities");
            DropTable("dbo.Faculties");
            DropTable("dbo.Offers");
            DropTable("dbo.Interviews");
            DropTable("dbo.EntryTests");
            DropTable("dbo.Channels");
            DropTable("dbo.Candidates");
            DropTable("dbo.TraineeCandidateProfiles");
            DropTable("dbo.StatusInClasses");
            DropTable("dbo.Status");
            DropTable("dbo.RewardPenalty");
            DropTable("dbo.Topic");
            DropTable("dbo.MilestoneConfiguration");
            DropTable("dbo.InterviewValuation");
            DropTable("dbo.Guarantee");
            DropTable("dbo.GPA");
            DropTable("dbo.TrainerProfiles");
            DropTable("dbo.Trainers");
            DropTable("dbo.SupplierPartners");
            DropTable("dbo.SubjectTypes");
            DropTable("dbo.Sub_SubjectType");
            DropTable("dbo.Scopes");
            DropTable("dbo.Locations");
            DropTable("dbo.LearningPaths");
            DropTable("dbo.FormatTypes");
            DropTable("dbo.DelivaryTypes");
            DropTable("dbo.ClassAdmins");
            DropTable("dbo.Budgets");
            DropTable("dbo.EventCatagories");
            DropTable("dbo.Audits");
            DropTable("dbo.ClassBatches");
            DropTable("dbo.AttendantStatus");
            DropTable("dbo.Trainee");
            DropTable("dbo.Allowance");
            DropTable("dbo.AllowanceGroup");
        }
    }
}
