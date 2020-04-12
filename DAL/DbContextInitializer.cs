using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DbContextInitializer : DropCreateDatabaseIfModelChanges<FAMContext>
	{
        protected override void Seed(FAMContext context)
        {
            //Group 1
            #region 
            List<User> listUser = new List<User>()
            {
                new User() {Username="admin",Password="admin",Name="Tran Van Nam",IsActive=true,Email="123@gmail.com" },
                new User() {Username="admin1",Password="admin1",Name="Bui Cong Tien",IsActive=true,Email="234@gmail.com" },
                new User() {Username="admin2",Password="admin2",Name="Pho Duc Quang",IsActive=true,Email="456@gmail.com" },
                new User() {Username="admin3",Password="admin3",Name="Ha Duy Toan",IsActive=false,Email="789@gmail.com" },
            };
            context.Users.AddRange(listUser);
            context.SaveChanges();
            List<Trainer> trainer = new List<Trainer>()
            {
                new Trainer() {Type=1,Remark="" },
                new Trainer() {Type=2,Remark="" },
                new Trainer() {Type=3,Remark="" },
                 new Trainer() {Type=1,Remark="" }

            };
            context.Trainers.AddRange(trainer);
            context.SaveChanges();

            List<TrainerProfile> tp = new List<TrainerProfile>()
            {
                new TrainerProfile() {TrainerProfileID=1,Account="QuangPD",FullName="Pho Duc Quang",DateOfBirth=DateTime.Parse("2/2/1996"),Gender=true,Unit="FHO",Major="Dot Net",Phone="112-345-6789",Email="PDQ@gmail.com.vn",Experience="",Remark="" },
                new TrainerProfile() {TrainerProfileID=2,Account="TienBC",FullName="Bui Cong Tien",DateOfBirth=DateTime.Parse("3/3/1996"),Gender=true,Unit="FHO",Major="Dot Net",Phone="112-345-6789",Email="TBC@gmail.com.vn",Experience="",Remark="" },
                new TrainerProfile() {TrainerProfileID=3,Account="NamTV12",FullName="Tran Van Nam",DateOfBirth=DateTime.Parse("4/4/1996"),Gender=true,Unit="FHO",Major="Java",Phone="112-345-6789",Email="TVN@gmail.com.vn",Experience="",Remark="" },
                new TrainerProfile() {TrainerProfileID=4,Account="ToanHD",FullName="Ha Duy Toan",DateOfBirth=DateTime.Parse("5/5/1996"),Gender=true,Unit="FHO",Major="Java",Phone="112-345-6789",Email="HDT@gmail.com.vn",Experience="",Remark="" }

            };
            context.TrainerProfiles.AddRange(tp);
            context.SaveChanges();



            List<ClassAdmin> caclassadminp = new List<ClassAdmin>()
            {
                new ClassAdmin() { ClassAdminID=1,Account="MaiTTQ",FullName="Tran Thi Quynh Mai",DateOfBirth= DateTime.Parse("1/1/1996"),Gender=true,Phone="012-345-6789",Email="Mai@gmail.com.vn",Remark="" },
                new ClassAdmin() { ClassAdminID=2,Account="AnhCDT",FullName="Cao Duy Tuan Anh",DateOfBirth= DateTime.Parse("1/1/1996"),Gender=false,Phone="012-345-6789",Email="TuanAnh@gmail.com.vn",Remark="" },
                new ClassAdmin() { ClassAdminID=3,Account="HieuNV",FullName="Nguyen Van Hieu",DateOfBirth= DateTime.Parse("4/4/1996"),Gender=false,Phone="012-345-6789",Email="Hieu@gmail.com.vn",Remark="" },
                new ClassAdmin() { ClassAdminID=4,Account="MaiTTQ2",FullName="Tran Thi Quynh Mai",DateOfBirth= DateTime.Parse("1/1/1996"),Gender=true,Phone="012-345-6789",Email="Mai2@gmail.com.vn",Remark="" }
            };
            context.ClassAdmins.AddRange(caclassadminp);
            context.SaveChanges();
            List<Location> loca = new List<Location>()
            {
                new Location() { LocationName="Hà Nội",Acronym="HN" },
                 new Location() { LocationName="Ðà Nẵng",Acronym="DN" },
                  new Location() { LocationName="Hồ Chí Minh",Acronym="HCM" }
            };
            context.Locations.AddRange(loca);
            context.SaveChanges();

            List<SubjectType> subjectType = new List<SubjectType>()
            {
                new SubjectType() {SucjectName="It Technical"},
                 new SubjectType() {SucjectName="Non-It Technical"},
               new SubjectType() {SucjectName="Organizational Overview & Culture"},
                 new SubjectType() {SucjectName="Company Process"},
                  new SubjectType() {SucjectName="Standard Process"},
                 new SubjectType() {SucjectName="Foreign Language"},
                  new SubjectType() {SucjectName="Soft Skill."},
                 new SubjectType() {SucjectName="Management"}
            };
            context.SubjectTypes.AddRange(subjectType);
            context.SaveChanges();


            List<Sub_SubjectType> Sub = new List<Sub_SubjectType>()
            {
                new Sub_SubjectType() {Sub_SubjectTypeName="Other"},
                new Sub_SubjectType() {Sub_SubjectTypeName="Big Data"},
                 new Sub_SubjectType() {Sub_SubjectTypeName="CAD"},
                new Sub_SubjectType() {Sub_SubjectTypeName="CAE"},
                 new Sub_SubjectType() {Sub_SubjectTypeName="SAP"},
                new Sub_SubjectType() {Sub_SubjectTypeName="IT General"},
                 new Sub_SubjectType() {Sub_SubjectTypeName="Others"},
                new Sub_SubjectType() {Sub_SubjectTypeName="Test"}
            };
            context.Sub_SubjectTypes.AddRange(Sub);
            context.SaveChanges();

            List<FormatType> format = new List<FormatType>()
            {
                new FormatType() {FormatTypeName="Blended"},
                new FormatType() {FormatTypeName="Offline"},
                 new FormatType() {FormatTypeName="Online"}
            };
            context.FormatType.AddRange(format);
            context.SaveChanges();

            List<Scope> scope = new List<Scope>()
            {
                new Scope() {ScopeName="Company"},
                new Scope() {ScopeName="Outside"},
                 new Scope() {ScopeName="Unit"}
            };
            context.Scopes.AddRange(scope);
            context.SaveChanges();


            List<DelivaryType> de = new List<DelivaryType>()
            {
                new DelivaryType() {DeliveryName="Class"},
                 new DelivaryType() {DeliveryName="Seminar"},
                  new DelivaryType() {DeliveryName="Exam"},
                 new DelivaryType() {DeliveryName="Contest"},
                  new DelivaryType() {DeliveryName="Certificate"},
                 new DelivaryType() {DeliveryName="Club"},
                  new DelivaryType() {DeliveryName="OJT"},
                 new DelivaryType() {DeliveryName="Others"}
            };
            context.DeliveryTypes.AddRange(de);
            context.SaveChanges();

            List<Budget> bud = new List<Budget>()
            {
                new Budget() {BudgetName="CTC_Project_ADP" },
                new Budget() {BudgetName="CTC_Fresher_Allowance" },
                new Budget() {BudgetName="CTC_Fresher_Training" },
                new Budget() {BudgetName="CTC_Specific_Fresher_Allowance" },
                new Budget() {BudgetName="CTC_Specific_Fresher_Training" },
                new Budget() {BudgetName="CTC_Specific_Fresher_Training_Award" },
                new Budget() {BudgetName="CTC_FU" },
                new Budget() {BudgetName="CTC_Uni" }
            };
            context.Buggets.AddRange(bud);
            context.SaveChanges();

            List<ClassBatch> classBatch = new List<ClassBatch>()
            {
                new ClassBatch() {ClassCode="HN_FR_Java_18_01",ExpectedStartDate=new DateTime(2010,10,10),ClassName="Fresher Develop Java",DetailLocation="11F, FPT Buiding",BudgetsID=1,DelivaryTypeID=1,ScopeID=1,FormatTypeID=1,SubjectTypeID=1,Sub_SubjectTypeID=1,ClassAdminID=1,TrainerID=2,LocationId=1,PlanedTraineeNumber=10,EstimatedBudget=0,AcceptedTraineeNumber=10,ActualTraineeNumber=9,Milestones="",Curriculum="",Status="Draft",History="17-jan-2018 - Started by HangTTT2"},
                new ClassBatch() {ClassCode="HN_FR_NRI_18_01",ClassName="Fresher Develop NRI",DetailLocation="Fvilage 1,Hoa Lac",BudgetsID=1,DelivaryTypeID=1,ScopeID=1,FormatTypeID=1,SubjectTypeID=1,Sub_SubjectTypeID=1,ClassAdminID=1,TrainerID=2,LocationId=1,PlanedTraineeNumber=10,ActualStartDate=new DateTime(2018,1,30),ActualEndDate=new DateTime(2018,3,1),EstimatedBudget=0,AcceptedTraineeNumber=10,ActualTraineeNumber=9,Milestones="",Curriculum="",Status="In-progress",History="17-jan-2018 - Started by HangTTT2"},
                new ClassBatch() {ClassCode="HN_FR_Android_18_01",ClassName="Fresher Develop Java",DetailLocation="11F, FPT Buiding",BudgetsID=1,DelivaryTypeID=1,ScopeID=1,FormatTypeID=1,SubjectTypeID=1,Sub_SubjectTypeID=1,ClassAdminID=1,TrainerID=2,LocationId=1,PlanedTraineeNumber=10,ActualStartDate=new DateTime(2018,1,17),EstimatedBudget=0,AcceptedTraineeNumber=10,ActualTraineeNumber=9,Milestones="",Curriculum="",Status="Pending for review",History="17-jan-2018 - Requested  by HangTTT2"},
                new ClassBatch() {ClassCode="HN_FR_.NET_18_01",ClassName="Fresher Develop Java",DetailLocation="11F, FPT Buiding",BudgetsID=1,DelivaryTypeID=1,ScopeID=1,FormatTypeID=1,SubjectTypeID=1,Sub_SubjectTypeID=1,ClassAdminID=2,TrainerID=2,LocationId=3,PlanedTraineeNumber=10,EstimatedBudget=0,AcceptedTraineeNumber=10,ActualTraineeNumber=9,Milestones="",Curriculum="",Status="Draft",History="17-jan-2018 - Started by HangTTT2"},
                new ClassBatch() {ClassCode="HN_FR_EMB_18_01",ClassName="Fresher Develop Java",DetailLocation="Fvilage 1,Hoa Lac",BudgetsID=1,DelivaryTypeID=1,ScopeID=1,FormatTypeID=1,SubjectTypeID=1,Sub_SubjectTypeID=1,ClassAdminID=3,TrainerID=4,LocationId=1,PlanedTraineeNumber=10,ActualStartDate=new DateTime(2018,1,12),ActualEndDate=new DateTime(2018,3,12),EstimatedBudget=0,AcceptedTraineeNumber=10,ActualTraineeNumber=9,Milestones="",Curriculum="",Status="Closed",History="17-jan-2018 - Finished by HangTTT2"},
                new ClassBatch() {ClassCode="HN_FR_Java_18_02",ClassName="Fresher Develop Java",DetailLocation="11F, FPT Buiding",BudgetsID=1,DelivaryTypeID=1,ScopeID=1,FormatTypeID=1,SubjectTypeID=1,Sub_SubjectTypeID=1,ClassAdminID=4,TrainerID=4,LocationId=2,PlanedTraineeNumber=10,ActualStartDate=new DateTime(2018,1,16),EstimatedBudget=0,AcceptedTraineeNumber=10,ActualTraineeNumber=9,Milestones="",Curriculum="",Status="Waiting for more information",History="17-jan-2018 - Requested  by HangTTT2"},
                new ClassBatch() {ClassCode="HN_FR_Java_18_03",ClassName="Fresher Develop Java",DetailLocation="11F, FPT Buiding",BudgetsID=1,DelivaryTypeID=1,ScopeID=1,FormatTypeID=1,SubjectTypeID=1,Sub_SubjectTypeID=1,ClassAdminID=2,TrainerID=3,LocationId=2,PlanedTraineeNumber=10,EstimatedBudget=0,AcceptedTraineeNumber=10,ActualTraineeNumber=9,Milestones="",Curriculum="",Status="Rejected",History="17-jan-2018 - Acepted by HangTTT2"},
                new ClassBatch() {ClassCode="HN_FR_Java_18_04",ClassName="Fresher Develop Java",DetailLocation="Fvilage 1,Hoa Lac",BudgetsID=1,DelivaryTypeID=1,ScopeID=1,FormatTypeID=1,SubjectTypeID=1,Sub_SubjectTypeID=1,ClassAdminID=3,TrainerID=2,LocationId=1,PlanedTraineeNumber=10,EstimatedBudget=0,AcceptedTraineeNumber=10,ActualTraineeNumber=9,Milestones="",Curriculum="",Status="Declined",History="17-jan-2018 - Declined by HangTTT2"},
                new ClassBatch() {ClassCode="HN_FR_Java_19_01",ClassName="Fresher Develop Java",DetailLocation="Fvilage 1,Hoa Lac",BudgetsID=1,DelivaryTypeID=1,ScopeID=1,FormatTypeID=1,SubjectTypeID=1,Sub_SubjectTypeID=1,ClassAdminID=1,TrainerID=3,LocationId=1,PlanedTraineeNumber=10,ActualStartDate=new DateTime(2019,1,16),ActualEndDate=new DateTime(2018,2,16),EstimatedBudget=0,AcceptedTraineeNumber=10,ActualTraineeNumber=9,Milestones="",Curriculum="",Status="Closed",History="17-jan-2018 - Finished by HangTTT2"},
                new ClassBatch() {ClassCode="HN_FR_Java_19_02",ClassName="Fresher Develop Java",DetailLocation="Fvilage 2,Hoa Lac",BudgetsID=1,DelivaryTypeID=1,ScopeID=1,FormatTypeID=1,SubjectTypeID=1,Sub_SubjectTypeID=1,ClassAdminID=2,TrainerID=4,LocationId=1,PlanedTraineeNumber=10,ActualStartDate=new DateTime(2019,1,16),ActualEndDate=new DateTime(2018,3,16),EstimatedBudget=0,AcceptedTraineeNumber=10,ActualTraineeNumber=9,Milestones="",Curriculum="",Status="Draft",History="17-jan-2018 - Created by HangTTT2"}
            };
            context.ClassBatchs.AddRange(classBatch);
            context.SaveChanges();
            List<SupplierPartner> supplierPartners = new List<SupplierPartner>()
            {
                new SupplierPartner() {SupplierPartnerID=1,SupplierPartnerName="Tran Van A",Remark="" },
                 new SupplierPartner() {SupplierPartnerID=2,SupplierPartnerName="Tran Van A",Remark="" },
                  new SupplierPartner() {SupplierPartnerID=3,SupplierPartnerName="Tran Van A",Remark="" },
                   new SupplierPartner() {SupplierPartnerID=4,SupplierPartnerName="Tran Van A",Remark="" },
                    new SupplierPartner() {SupplierPartnerID=5,SupplierPartnerName="Tran Van A",Remark="" },
                     new SupplierPartner() {SupplierPartnerID=6,SupplierPartnerName="Tran Van A",Remark="" },
                      new SupplierPartner() {SupplierPartnerID=7,SupplierPartnerName="Tran Van A",Remark="" },
                       new SupplierPartner() {SupplierPartnerID=8,SupplierPartnerName="Tran Van A",Remark="" },
                        new SupplierPartner() {SupplierPartnerID=9,SupplierPartnerName="Tran Van A",Remark="" },
                         new SupplierPartner() {SupplierPartnerID=10,SupplierPartnerName="Tran Van A",Remark="" }
            };
            context.SupplierPartners.AddRange(supplierPartners);
            context.SaveChanges();
            List<LearningPath> learning = new List<LearningPath>()
            {
                new LearningPath() {LearningPathID=1,LearningPathName="Java Standard",RelatefInformation=""},
                 new LearningPath() {LearningPathID=2,LearningPathName="Java Standard",RelatefInformation=""},
                  new LearningPath() {LearningPathID=3,LearningPathName="Java Standard",RelatefInformation=""},
                   new LearningPath() {LearningPathID=4,LearningPathName="Java Standard",RelatefInformation=""},
                    new LearningPath() {LearningPathID=5,LearningPathName="Java Standard",RelatefInformation=""},
                     new LearningPath() {LearningPathID=6,LearningPathName="Java Standard",RelatefInformation=""},
                      new LearningPath() {LearningPathID=7,LearningPathName="Java Standard",RelatefInformation=""},
                       new LearningPath() {LearningPathID=8,LearningPathName="Java Standard",RelatefInformation=""},
                        new LearningPath() {LearningPathID=9,LearningPathName="Java Standard",RelatefInformation=""},
                         new LearningPath() {LearningPathID=10,LearningPathName="Java Standard",RelatefInformation=""}

            };
            context.LearningPath.AddRange(learning);
            context.SaveChanges();
            List<EventCatagory> eventcatagory = new List<EventCatagory>()
            {
                new EventCatagory() {EveCatagoryName="Trainer"},
                new EventCatagory() {EveCatagoryName="Trainee"},
                new EventCatagory() {EveCatagoryName="Courseware"},
                 new EventCatagory() {EveCatagoryName="Organization"},
                  new EventCatagory() {EveCatagoryName="Logistics"},
                  new EventCatagory() {EveCatagoryName="Management"},
                      new EventCatagory() {EveCatagoryName="Calendar"},
                       new EventCatagory() {EveCatagoryName="Others"}
            };

            context.EventCatagories.AddRange(eventcatagory);
            context.SaveChanges();

            List<Audit> Audit = new List<Audit>()
            {
                new Audit() {AuditID=1,ClassBatchID=1,Date=new DateTime(2018,1,16),EventCatogoryID=1,RelatedPatyPeople="VinhNV",Action="Hold Party",PIC="BinhD",Deadline=new DateTime(2018,1,17),Note=""},
                 new Audit() {AuditID=1,ClassBatchID=2,Date=new DateTime(2018,1,15),EventCatogoryID=1,RelatedPatyPeople="VinhNV",Action="Hold Party",PIC="BinhD",Deadline=new DateTime(2018,1,17),Note=""},
                  new Audit() {AuditID=1,ClassBatchID=3,Date=new DateTime(2018,1,16),EventCatogoryID=1,RelatedPatyPeople="VinhNV",Action="Hold Party",PIC="BinhD",Deadline=new DateTime(2018,1,17),Note=""},
                   new Audit() {AuditID=1,ClassBatchID=4,Date=new DateTime(2018,1,16),EventCatogoryID=2,RelatedPatyPeople="VinhNV",Action="Hold Party",PIC="BinhD",Deadline=new DateTime(2018,1,17),Note=""},
                    new Audit() {AuditID=1,ClassBatchID=5,Date=new DateTime(2018,1,16),EventCatogoryID=1,RelatedPatyPeople="VinhNV",Action="Hold Party",PIC="BinhD",Deadline=new DateTime(2018,1,17),Note=""},
                     new Audit() {AuditID=1,ClassBatchID=6,Date=new DateTime(2018,1,16),EventCatogoryID=3,RelatedPatyPeople="VinhNV",Action="Hold Party",PIC="BinhD",Deadline=new DateTime(2018,1,17),Note=""},
                      new Audit() {AuditID=1,ClassBatchID=7,Date=new DateTime(2018,1,16),EventCatogoryID=1,RelatedPatyPeople="VinhNV",Action="Hold Party",PIC="BinhD",Deadline=new DateTime(2018,1,17),Note=""},
                       new Audit() {AuditID=1,ClassBatchID=8,Date=new DateTime(2018,1,16),EventCatogoryID=4,RelatedPatyPeople="VinhNV",Action="Hold Party",PIC="BinhD",Deadline=new DateTime(2018,1,17),Note=""},
                        new Audit() {AuditID=1,ClassBatchID=9,Date=new DateTime(2018,1,16),EventCatogoryID=5,RelatedPatyPeople="VinhNV",Action="Hold Party",PIC="BinhD",Deadline=new DateTime(2018,1,17),Note=""},
                         new Audit() {AuditID=1,ClassBatchID=10,Date=new DateTime(2018,1,16),EventCatogoryID=6,RelatedPatyPeople="VinhNV",Action="Hold Party",PIC="BinhD",Deadline=new DateTime(2018,1,17),Note=""}
            };

            context.Audits.AddRange(Audit);
            context.SaveChanges();


            #endregion

            //Group 2
            #region
            List<Channel> lstchannel = new List<Channel>()
            {
                new Channel() { EmplId=1, ChannelName="FA.Net08.Chanel.01", Remarks="TienBC1" },
                new Channel() { EmplId=2, ChannelName="FA.Net08.Chanel.02", Remarks="TienBC2" },
                new Channel() { EmplId=3, ChannelName="FA.Net08.Chanel.03", Remarks="TienBC3" },
                new Channel() { EmplId=4, ChannelName="FA.Net08.Chanel.04", Remarks="TienBC4" },
                new Channel() { EmplId=5, ChannelName="FA.Net08.Chanel.05", Remarks="TienBC5" },
                new Channel() { EmplId=6, ChannelName="FA.Net08.Chanel.06", Remarks="TienBC6" },
                new Channel() { EmplId=7, ChannelName="FA.Net08.Chanel.07", Remarks="TienBC7" },
                new Channel() { EmplId=8, ChannelName="FA.Net08.Chanel.08", Remarks="TienBC8" },
                new Channel() { EmplId=9, ChannelName="FA.Net08.Chanel.09", Remarks="TienBC9" },
                new Channel() { EmplId=10, ChannelName="FA.Net08.Chanel.10", Remarks="TienBC10" }

            };
            context.Channels.AddRange(lstchannel);

            List<University> lstUniversity = new List<University>()
            {
                new University() { UniversityName ="Other", Remarks="Trường Khác" },
                new University() { UniversityName ="VIU", Remarks="Đại Học Công Nghiệp Việt Hung" },
                new University() { UniversityName ="MIT", Remarks="Học Viện Công Nghệ" },
                new University() { UniversityName ="HUST", Remarks="Đại Học Bách Khoa" },
                new University() { UniversityName ="FPT", Remarks="Đại Học FPT" }
            };
            context.Universities.AddRange(lstUniversity);

            List<Faculty> lstFaculty = new List<Faculty>()
            {
                new Faculty() { FacultyName="IT", Remarks="Công Nghệ Thông Tin" },
                new Faculty() { FacultyName="ĐTVT", Remarks="Điện Tử Viễn Thông" },
                new Faculty() { FacultyName="Other", Remarks="Khác" }
            };
            context.Faculties.AddRange(lstFaculty);
            context.SaveChanges();

            List<Candidate> lstCandidate = new List<Candidate>()
            {
                new Candidate() { ApplicationDate=new DateTime(2005,4,3),LocationId=1,Status="New", Remark="",ChannelId=1 },
                new Candidate() { ApplicationDate=new DateTime(2005,4,5),LocationId=2, Status="New", Remark="",ChannelId=1 },
                new Candidate() { ApplicationDate=new DateTime(2005,4,6),LocationId=3, Status="New", Remark="",ChannelId=1 },
                new Candidate() { ApplicationDate=new DateTime(2005,4,3),LocationId=1, Status="New", Remark="",ChannelId=2 },
                new Candidate() { ApplicationDate=new DateTime(2005,4,8),LocationId=2, Status="New", Remark="",ChannelId=2 },
                new Candidate() { ApplicationDate=new DateTime(2005,4,7),LocationId=3, Status="New", Remark="",ChannelId=5 },
                new Candidate() { ApplicationDate=new DateTime(2005,4,5),LocationId=1, Status="New", Remark="",ChannelId=6 },
                new Candidate() { ApplicationDate=new DateTime(2005,4,3),LocationId=2, Status="New", Remark="",ChannelId=4 },
                new Candidate() { ApplicationDate=new DateTime(2005,4,2),LocationId=3, Status="New", Remark="",ChannelId=8 },
                new Candidate() { ApplicationDate=new DateTime(2005,4,4),LocationId=1, Status="New", Remark="",ChannelId=2 },
                new Candidate() { ApplicationDate=new DateTime(2005,4,4),LocationId=1, Status="New", Remark="",ChannelId=2 }
            };
            context.Candidates.AddRange(lstCandidate);
            context.SaveChanges();

            List<TraineeCandidateProfile> lstProfile = new List<TraineeCandidateProfile>()
            {
                new TraineeCandidateProfile() {Id=1,FullName="Bùi Công Tiên",DOB=new DateTime(2000,12,31),Gender=true,GraduationDate=new DateTime(2018,01,01),Phone="0978021333",Email=@"TienBC@fsoft.com.vn",Type="Candidate",Skill=1,ForeignLangguage="English", Level=7,AllocationStatus="Not Allocated", History="", Remarks="",UniversityId=1,FacultyId=1},
                new TraineeCandidateProfile() {Id=2,FullName="Hàn Mạnh Dũng",DOB=new DateTime(1997,12,31),Gender=true,GraduationDate=new DateTime(2017,07,30),Phone="0978021334",Email=@"DungHM2@fsoft.com.vn",Type="Candidate",Skill=1,ForeignLangguage="English", Level=8,AllocationStatus="Not Allocated", History="", Remarks="",UniversityId=2,FacultyId=2 },
                new TraineeCandidateProfile() {Id=3,FullName="Vũ Ngọc Hiếu",DOB=new DateTime(1990,12,31),Gender=true,GraduationDate=new DateTime(2008,08,08),Phone="0978021335",Email=@"HieuNV1@fsoft.com.vn",Type="Candidate",Skill=1,ForeignLangguage="English", Level=8,AllocationStatus="Not Allocated", History="", Remarks="",UniversityId=3,FacultyId=3 },
                new TraineeCandidateProfile() {Id=4,FullName="Trần Văn Nam",DOB=new DateTime(2000,12,31),Gender=true,GraduationDate=new DateTime(2018,08,30),Phone="0978021336",Email=@"NamTV12@fsoft.com.vn",Type="Candidate",Skill=1,ForeignLangguage="English", Level=6,AllocationStatus="Not Allocated", History="", Remarks="",UniversityId=1,FacultyId=2 },
                new TraineeCandidateProfile() {Id=5,FullName="Nguyễn Anh Dũng",DOB=new DateTime(1998,12,31),Gender=true,GraduationDate=new DateTime(2017,02,02),Phone="0978021337",Email=@"DungNA11@fsoft.com.vn",Type="Candidate",Skill=1,ForeignLangguage="Japanese", Level=4,AllocationStatus="Not Allocated", History="", Remarks="",UniversityId=2,FacultyId=1 },
                new TraineeCandidateProfile() {Id=6,FullName="Phạm Trọng Võ",DOB=new DateTime(1995,12,31),Gender=true,GraduationDate=new DateTime(2018,08,30),Phone="0978021338",Email=@"VoPT1@fsoft.com.vn",Type="Candidate",Skill=1,ForeignLangguage="Japanese", Level=2,AllocationStatus="Not Allocated", History="", Remarks="",UniversityId=3,FacultyId=1 },
                new TraineeCandidateProfile() {Id=7,FullName="Cao Duy Tuấn Anh",DOB=new DateTime(1995,12,31),Gender=true,GraduationDate=new DateTime(2017,07,30),Phone="0978021339",Email=@"AnhCDT@fsoft.com.vn",Type="Candidate",Skill=1,ForeignLangguage="Japanese", Level=9,AllocationStatus="Not Allocated", History="", Remarks="",UniversityId=1,FacultyId=3 },
                new TraineeCandidateProfile() {Id=8,FullName="Phò Đức Quang",DOB=new DateTime(1994,12,31),Gender=true,GraduationDate=new DateTime(2018,05,30),Phone="0978021310",Email=@"QuangPD5@fsoft.com.vn",Type="Candidate",Skill=1,ForeignLangguage="Spanish", Level=5,AllocationStatus="Not Allocated", History="", Remarks="",UniversityId=2,FacultyId=2 },
                new TraineeCandidateProfile() {Id=9,FullName="Hà Duy Toàn",DOB=new DateTime(1990,12,31),Gender=true,GraduationDate=new DateTime(2015,05,30),Phone="0978021325",Email=@"ToanHD2@fsoft.com.vn",Type="Candidate",Skill=1,ForeignLangguage="Spanish", Level=5,AllocationStatus="Not Allocated", History="", Remarks="",UniversityId=4,FacultyId=1 },
                new TraineeCandidateProfile() {Id=10,FullName="Lê Trọng Tiến",DOB=new DateTime(1996,12,31),Gender=true,GraduationDate=new DateTime(2018,07,05),Phone="0978021399",Email=@"TienLT18@fsoft.com.vn",Type="Candidate",Skill=1,ForeignLangguage="Spanish", Level=5,AllocationStatus="Not Allocated", History="", Remarks="",UniversityId=5,FacultyId=3 },
                new TraineeCandidateProfile() {Id=11,FullName="Vũ Ngọc Tiến",DOB=new DateTime(1996,12,31),Gender=true,GraduationDate=new DateTime(2018,07,05),Phone="0938021399",Email=@"HieuAB2@fsoft.com.vn",Type="Candidate",Skill=1,ForeignLangguage="Spanish", Level=5,AllocationStatus="Not Allocated", History="", Remarks="",UniversityId=5,FacultyId=3 },
            };
            context.TraineeCandidateProfiles.AddRange(lstProfile);
            context.SaveChanges();
            #endregion

            //Group 3
            #region
            List<Status> listStatus = new List<Status>() {
                new Status() {StatusName ="Waiting for Class" },
                new Status() {StatusName ="Waiting for Allocation" },
                new Status() {StatusName ="Deferred" },
                new Status() {StatusName ="Drop-out" },
                new Status() {StatusName ="Enrolled" },
                new Status() {StatusName ="In-progress" },
                new Status() {StatusName ="Active" }
            };
            context.Status.AddRange(listStatus);
            context.SaveChanges();

            List<Trainee> listTrainee = new List<Trainee>()
            {
                new Trainee() {ClassID=1,TraineeCandidateID=1,Remarks="aaa",StatusID = 6,StatusInClassId=5},
                new Trainee() { ClassID = 2, TraineeCandidateID = 2, Remarks = "bbb",StatusID = 6,StatusInClassId=6 },
                new Trainee() {ClassID=3,TraineeCandidateID=3,Remarks="ccc", StatusID = 6,StatusInClassId=7},
                new Trainee() {ClassID=1,TraineeCandidateID=4,Remarks="ddd", StatusID = 6,StatusInClassId=5},
                new Trainee() {ClassID=2,TraineeCandidateID=5,Remarks="eee" , StatusID = 1,StatusInClassId=6},
                new Trainee() {ClassID=3,TraineeCandidateID=6,Remarks="hhh" , StatusID = 2,StatusInClassId=7},
                new Trainee() {ClassID=1,TraineeCandidateID=7,Remarks="iii" , StatusID = 1,StatusInClassId=5},
                new Trainee() {ClassID=2,TraineeCandidateID=8,Remarks="kkk" , StatusID = 4,StatusInClassId=6},
                new Trainee() {ClassID=3,TraineeCandidateID=9,Remarks="lll" , StatusID = 1,StatusInClassId=7},
                new Trainee() {ClassID=1,TraineeCandidateID=10,Remarks="mmm" , StatusID = 2,StatusInClassId=5},
                new Trainee() {ClassID=1,TraineeCandidateID=11,Remarks="abc" , StatusID = 3,StatusInClassId=5},

            };
            context.Trainees.AddRange(listTrainee);
            context.SaveChanges();

            List<Guarantee> guarantees = new List<Guarantee>()
            {
                new Guarantee() { FSU = "FSU2.J8" , Salary = 7000000 , StartDate = new DateTime(2018,5,1), TraineeID =1 , AllocationStatus ="Not Allocated"},
                new Guarantee() { FSU = "FSU2.J7" , Salary = 7000000 , StartDate = new DateTime(2018,6,1), TraineeID =2 , AllocationStatus ="Allocated"},
                new Guarantee() { FSU = "FSU2.J7" , Salary = 7000000 , StartDate = new DateTime(2018,6,1), TraineeID =3 , AllocationStatus ="Not Allocated"},
                new Guarantee() { FSU = "FSU2.J7" , Salary = 7000000 , StartDate = new DateTime(2018,6,1), TraineeID =4 , AllocationStatus ="Allocated"},
                new Guarantee() { FSU = "FSU2.J7" , Salary = 7000000 , StartDate = new DateTime(2018,6,1), TraineeID =5 , AllocationStatus ="Allocated"},
                new Guarantee() { FSU = "FSU2.J7" , Salary = 7000000 , StartDate = new DateTime(2018,6,1), TraineeID =6 , AllocationStatus ="Allocated"},
                new Guarantee() { FSU = "FSU2.J7" , Salary = 7000000 , StartDate = new DateTime(2018,6,1), TraineeID =7 , AllocationStatus ="Not Allocated"},
                new Guarantee() { FSU = "FSU2.J7" , Salary = 7000000 , StartDate = new DateTime(2018,6,1), TraineeID =8 , AllocationStatus ="Allocated"},
                new Guarantee() { FSU = "FSU2.J7" , Salary = 7000000 , StartDate = new DateTime(2018,6,1), TraineeID =9 , AllocationStatus ="Allocated"},
                new Guarantee() { FSU = "FSU2.J7" , Salary = 7000000 , StartDate = new DateTime(2018,6,1), TraineeID =10 , AllocationStatus ="Allocated"},
                new Guarantee() { FSU = "FSU2.J7" , Salary = 7000000 , StartDate = new DateTime(2018,6,1), TraineeID =11 , AllocationStatus ="Allocated"},
            };
            context.Guarantees.AddRange(guarantees);
            context.SaveChanges();

            List<MilestoneConfiguration> listMileStone = new List<MilestoneConfiguration>()
            {
                new MilestoneConfiguration() {MilestoneName="Thg2-18",SalaryPaid=true,StartDate =new DateTime(2018,02,01),EndDate= new DateTime(2018,03,01),TraineeID = 1 },
                new MilestoneConfiguration() {MilestoneName="Thg3-18",SalaryPaid=true,StartDate =new DateTime(2018,03,01),EndDate= new DateTime(2018,04,01),TraineeID = 1 },
                new MilestoneConfiguration() {MilestoneName="Thg4-18",SalaryPaid=true,StartDate =new DateTime(2018,04,01),EndDate= new DateTime(2018,05,01),TraineeID = 1 },
                new MilestoneConfiguration() {MilestoneName="Thg2-18",SalaryPaid=true,StartDate =new DateTime(2018,01,01),EndDate= new DateTime(2018,04,01),TraineeID = 2 },
                new MilestoneConfiguration() {MilestoneName="Thg2-18",SalaryPaid=true,StartDate =new DateTime(2018,01,01),EndDate= new DateTime(2018,04,01),TraineeID = 3 },
                new MilestoneConfiguration() {MilestoneName="Thg2-18",SalaryPaid=true,StartDate =new DateTime(2018,01,01),EndDate= new DateTime(2018,04,01),TraineeID = 4 },
                new MilestoneConfiguration() {MilestoneName="Thg2-18",SalaryPaid=true,StartDate =new DateTime(2018,01,01),EndDate= new DateTime(2018,04,01),TraineeID = 5 },
                new MilestoneConfiguration() {MilestoneName="Thg2-18",SalaryPaid=true,StartDate =new DateTime(2018,01,01),EndDate= new DateTime(2018,04,01),TraineeID = 6 },
                new MilestoneConfiguration() {MilestoneName="Thg2-18",SalaryPaid=true,StartDate =new DateTime(2018,01,01),EndDate= new DateTime(2018,04,01),TraineeID = 7 },
                new MilestoneConfiguration() {MilestoneName="Thg2-18",SalaryPaid=true,StartDate =new DateTime(2018,01,01),EndDate= new DateTime(2018,04,01),TraineeID = 8 },
                new MilestoneConfiguration() {MilestoneName="Thg2-18",SalaryPaid=true,StartDate =new DateTime(2018,01,01),EndDate= new DateTime(2018,04,01),TraineeID = 9 },
                new MilestoneConfiguration() {MilestoneName="Thg2-18",SalaryPaid=true,StartDate =new DateTime(2018,01,01),EndDate= new DateTime(2018,04,01),TraineeID = 10 },
                new MilestoneConfiguration() {MilestoneName="Thg2-18",SalaryPaid=true,StartDate =new DateTime(2018,01,01),EndDate= new DateTime(2018,04,01),TraineeID = 11 },
            };
            context.MilestoneConfigurations.AddRange(listMileStone);
            context.SaveChanges();

            foreach (var milestone in listMileStone)
            {
                List<int> listDay = GetDayOfMonth(milestone.StartDate);
                foreach (var item in listDay)
                {
                    AttendantStatus attendantStatus = new AttendantStatus();
                    attendantStatus.Milestones = milestone.MilestoneName;
                    attendantStatus.TraineeID = milestone.TraineeID;
                    attendantStatus.LearningDay = new DateTime(milestone.StartDate.Year, milestone.StartDate.Month, item);
                    attendantStatus.StatusDate = "P";
                    context.AttendantStatus.Add(attendantStatus);
                }

            }
            context.SaveChanges();

            List<Topic> listTopic = new List<Topic>()
            {
                new Topic() {TopicName = "ASQL" , MilestoneConfigurationId = 1, MaxScore = 10, PassingScore = 6,WeightedNumber = 40, TopicMark = 7 , LearningPathID = 1 },
                new Topic() {TopicName = "BTNB" , MilestoneConfigurationId = 1, MaxScore = 10, PassingScore = 6,WeightedNumber = 50, TopicMark = 8 , LearningPathID = 1},
                new Topic() {TopicName = "ATNB" , MilestoneConfigurationId = 2, MaxScore = 10, PassingScore = 6,WeightedNumber = 60, TopicMark = 7 , LearningPathID = 1 },
                new Topic() {TopicName = "Web" , MilestoneConfigurationId = 2, MaxScore = 10, PassingScore = 6,WeightedNumber = 40, TopicMark = 9 , LearningPathID = 1},
                new Topic() {TopicName = "Spring" , MilestoneConfigurationId = 3, MaxScore = 10, PassingScore = 6,WeightedNumber = 30, TopicMark = 10 , LearningPathID = 1},
                new Topic() {TopicName = "MVC" , MilestoneConfigurationId = 3, MaxScore = 10, PassingScore = 6,WeightedNumber = 70, TopicMark = 7 , LearningPathID = 1},
                new Topic() {TopicName = "ATNB" , MilestoneConfigurationId = 4, MaxScore = 10, PassingScore = 6,WeightedNumber = 40, TopicMark = 6 , LearningPathID = 2},
                new Topic() {TopicName = "ASQL" , MilestoneConfigurationId = 5, MaxScore = 10, PassingScore = 6,WeightedNumber = 50, TopicMark = 7 , LearningPathID = 3},
                new Topic() {TopicName = "BTNB" , MilestoneConfigurationId = 6, MaxScore = 10, PassingScore = 6,WeightedNumber = 40, TopicMark = 8 , LearningPathID = 1},
                new Topic() {TopicName = "Spring" , MilestoneConfigurationId = 7, MaxScore = 10, PassingScore = 6,WeightedNumber = 40, TopicMark = 7 , LearningPathID = 2},
                new Topic() {TopicName = "ASQL" , MilestoneConfigurationId = 8, MaxScore = 10, PassingScore = 6,WeightedNumber = 40, TopicMark = 7 , LearningPathID = 2},
                new Topic() {TopicName = "Web" , MilestoneConfigurationId = 9, MaxScore = 10, PassingScore = 6,WeightedNumber = 40, TopicMark = 7 , LearningPathID = 2},
                new Topic() {TopicName = "ASQL" , MilestoneConfigurationId = 10, MaxScore = 10, PassingScore = 6,WeightedNumber = 40, TopicMark = 7 , LearningPathID = 2},
            };
            context.Topics.AddRange(listTopic);
            context.SaveChanges();

            List<RewardPenalty> listRewardPenalty = new List<RewardPenalty>()
            {
                new RewardPenalty() {TraineeID=1,Milestone="Thg2-18",BonusPoint=2,PenaltyPoint =0, Date = new DateTime(2018,2,4) },
                new RewardPenalty() {TraineeID=1,Milestone="Thg2-18",BonusPoint=1,PenaltyPoint =0, Date = new DateTime(2018,2,5) },
                new RewardPenalty() {TraineeID=1,Milestone="Thg3-18",BonusPoint=2,PenaltyPoint =1, Date = new DateTime(2018,3,4) },
                new RewardPenalty() {TraineeID=2,Milestone="Thg3-18",BonusPoint=2,PenaltyPoint =0, Date = new DateTime(2018,3,4) },
                new RewardPenalty() {TraineeID=2,Milestone="Thg4-18",BonusPoint=2,PenaltyPoint =0, Date = new DateTime(2018,3,4) },
                new RewardPenalty() {TraineeID=3,Milestone="Thg2-18",BonusPoint=2,PenaltyPoint =0, Date = new DateTime(2018,3,4) },
                new RewardPenalty() {TraineeID=4,Milestone="Thg2-18",BonusPoint=2,PenaltyPoint =0, Date = new DateTime(2018,3,4) },
                new RewardPenalty() {TraineeID=5,Milestone="Thg2-18",BonusPoint=2,PenaltyPoint =0, Date = new DateTime(2018,3,4) },
                new RewardPenalty() {TraineeID=6,Milestone="Thg2-18",BonusPoint=2,PenaltyPoint =0, Date = new DateTime(2018,3,4) },
                new RewardPenalty() {TraineeID=7,Milestone="Thg2-18",BonusPoint=2,PenaltyPoint =0, Date = new DateTime(2018,3,4) },
                new RewardPenalty() {TraineeID=8,Milestone="Thg2-18",BonusPoint=2,PenaltyPoint =0, Date = new DateTime(2018,3,4) },
                new RewardPenalty() {TraineeID=9,Milestone="Thg2-18",BonusPoint=2,PenaltyPoint =0, Date = new DateTime(2018,3,4) },
                new RewardPenalty() {TraineeID=10,Milestone="Thg2-18",BonusPoint=2,PenaltyPoint =0, Date = new DateTime(2018,3,4) }

            };
            context.RewardPenalties.AddRange(listRewardPenalty);
            context.SaveChanges();

            //List<GPA> listGpa = new List<GPA>()
            //{
            //     new GPA() {GPA_ID = 1,TraineeID = 1,GPA_Result=67,AttentdantID=1},
            //     new GPA() {GPA_ID = 2 ,TraineeID = 1 ,GPA_Result = 73 , AttentdantID = 2},
            //     new GPA() {GPA_ID = 3 ,TraineeID = 1 ,GPA_Result = 79 , AttentdantID = 3},
            //     new GPA() {GPA_ID = 4 ,TraineeID = 1 ,GPA_Result = 76 , AttentdantID = 4},
            //};
            //context.GPAs.AddRange(listGpa);
            //context.SaveChanges();

            //List<Allowance> listAllowance = new List<Allowance>()
            //{
            //    new Allowance() {Group="Group1",TraineeID = 1,Remarks="",StandardAllowance=3000000 },
            //    new Allowance() {Group="Group2",TraineeID = 1,Remarks="",StandardAllowance=5000000 },
            //    new Allowance() {Group="Group3",TraineeID = 1,Remarks="",StandardAllowance=5000000 },
            //};
            //context.Allowances.AddRange(listAllowance);
            //context.SaveChanges();
            #endregion
        }

        public static List<int> GetDayOfMonth(DateTime date)
        {
            List<int> listDay = new List<int>();
            DateTime dateTime = new DateTime(date.Year, date.Month, 1);
            int totalDayOfMonth = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
            for (int i = 1; i <= totalDayOfMonth; i++)
            {
                if ((!dateTime.DayOfWeek.Equals(DayOfWeek.Saturday)) && (!dateTime.DayOfWeek.Equals(DayOfWeek.Sunday)))
                    listDay.Add(i);
                dateTime = dateTime.AddDays(1);
            }
            return listDay;
        }
    }
}
