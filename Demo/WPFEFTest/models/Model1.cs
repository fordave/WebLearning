namespace WPFEFTest.models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=regions")
        {
            Database.Log = s =>
            {
                Console.WriteLine("************sql start*************");
                Console.WriteLine(s);
                Console.WriteLine("************sql end***************");    
            };
        }

        public virtual DbSet<BaseBillPush> BaseBillPushes { get; set; }
        public virtual DbSet<BaseComment> BaseComments { get; set; }
        public virtual DbSet<BaseContact> BaseContacts { get; set; }
        public virtual DbSet<BaseContactDetail> BaseContactDetails { get; set; }
        public virtual DbSet<BaseException> BaseExceptions { get; set; }
        public virtual DbSet<BaseExportData> BaseExportDatas { get; set; }
        public virtual DbSet<BaseFile> BaseFiles { get; set; }
        public virtual DbSet<BaseFolder> BaseFolders { get; set; }
        public virtual DbSet<BaseHoliday> BaseHolidays { get; set; }
        public virtual DbSet<BaseItemDetail> BaseItemDetails { get; set; }
        public virtual DbSet<BaseItem> BaseItems { get; set; }
        public virtual DbSet<BaseKnowledge> BaseKnowledges { get; set; }
        public virtual DbSet<BaseLog> BaseLogs { get; set; }
        public virtual DbSet<BaseLoginLog> BaseLoginLogs { get; set; }
        public virtual DbSet<BaseMessage> BaseMessages { get; set; }
        public virtual DbSet<BaseMessageRecent> BaseMessageRecents { get; set; }
        public virtual DbSet<BaseModifyRecord> BaseModifyRecords { get; set; }
        public virtual DbSet<BaseModule> BaseModules { get; set; }
        public virtual DbSet<BaseNew> BaseNews { get; set; }
        public virtual DbSet<BaseOrganize> BaseOrganizes { get; set; }
        public virtual DbSet<BaseOrganizeScope> BaseOrganizeScopes { get; set; }
        public virtual DbSet<BaseParameter> BaseParameters { get; set; }
        public virtual DbSet<BasePermission> BasePermissions { get; set; }
        public virtual DbSet<BasePermissionScope> BasePermissionScopes { get; set; }
        public virtual DbSet<BaseRole> BaseRoles { get; set; }
        public virtual DbSet<BaseRoleDeleted> BaseRoleDeleteds { get; set; }
        public virtual DbSet<BaseRoleOrganize> BaseRoleOrganizes { get; set; }
        public virtual DbSet<BaseSequence> BaseSequences { get; set; }
        public virtual DbSet<BaseStaff> BaseStaffs { get; set; }
        public virtual DbSet<BaseStaffOrganize> BaseStaffOrganizes { get; set; }
        public virtual DbSet<BaseTableColumn> BaseTableColumns { get; set; }
        public virtual DbSet<BaseUser> BaseUsers { get; set; }
        public virtual DbSet<BaseUserAddress> BaseUserAddresses { get; set; }
        public virtual DbSet<BaseUserContact> BaseUserContacts { get; set; }
        public virtual DbSet<BaseUserLogOn> BaseUserLogOns { get; set; }
        public virtual DbSet<BaseUserOrganize> BaseUserOrganizes { get; set; }
        public virtual DbSet<BaseUserRole> BaseUserRoles { get; set; }
        public virtual DbSet<BaseUserScore> BaseUserScores { get; set; }
        public virtual DbSet<BusinessCard> BusinessCards { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<FriendFan> FriendFans { get; set; }
        public virtual DbSet<FriendItem> FriendItems { get; set; }
        public virtual DbSet<FriendModule> FriendModules { get; set; }
        public virtual DbSet<FriendPermission> FriendPermissions { get; set; }
        public virtual DbSet<FriendPermissionScope> FriendPermissionScopes { get; set; }
        public virtual DbSet<FriendRole> FriendRoles { get; set; }
        public virtual DbSet<FriendSupport> FriendSupports { get; set; }
        public virtual DbSet<FriendUserRole> FriendUserRoles { get; set; }
        public virtual DbSet<HeadhuntingItem> HeadhuntingItems { get; set; }
        public virtual DbSet<HeadhuntingModule> HeadhuntingModules { get; set; }
        public virtual DbSet<HeadhuntingOrganizeScope> HeadhuntingOrganizeScopes { get; set; }
        public virtual DbSet<HeadhuntingPermission> HeadhuntingPermissions { get; set; }
        public virtual DbSet<HeadhuntingPermissionScope> HeadhuntingPermissionScopes { get; set; }
        public virtual DbSet<HeadhuntingRole> HeadhuntingRoles { get; set; }
        public virtual DbSet<HeadhuntingUserRole> HeadhuntingUserRoles { get; set; }
        public virtual DbSet<ItemsAllowDelete> ItemsAllowDeletes { get; set; }
        public virtual DbSet<ItemsAllowEdit> ItemsAllowEdits { get; set; }
        public virtual DbSet<ItemsAuditIdea> ItemsAuditIdeas { get; set; }
        public virtual DbSet<ItemsAuditStatu> ItemsAuditStatus { get; set; }
        public virtual DbSet<ItemsBugCategory> ItemsBugCategories { get; set; }
        public virtual DbSet<ItemsBugLevel> ItemsBugLevels { get; set; }
        public virtual DbSet<ItemsCondition> ItemsConditions { get; set; }
        public virtual DbSet<ItemsDegree> ItemsDegrees { get; set; }
        public virtual DbSet<ItemsDeletionStateCode> ItemsDeletionStateCodes { get; set; }
        public virtual DbSet<ItemsDuty> ItemsDuties { get; set; }
        public virtual DbSet<ItemsEditField> ItemsEditFields { get; set; }
        public virtual DbSet<ItemsEducation> ItemsEducations { get; set; }
        public virtual DbSet<ItemsEnabled> ItemsEnableds { get; set; }
        public virtual DbSet<ItemsGender> ItemsGenders { get; set; }
        public virtual DbSet<ItemsIndustry> ItemsIndustries { get; set; }
        public virtual DbSet<ItemsLeaveCategory> ItemsLeaveCategories { get; set; }
        public virtual DbSet<ItemsLink> ItemsLinks { get; set; }
        public virtual DbSet<ItemsLockWaitMinute> ItemsLockWaitMinutes { get; set; }
        public virtual DbSet<ItemsMarriage> ItemsMarriages { get; set; }
        public virtual DbSet<ItemsNationality> ItemsNationalities { get; set; }
        public virtual DbSet<ItemsNewsCategory> ItemsNewsCategories { get; set; }
        public virtual DbSet<ItemsOrganizeCategory> ItemsOrganizeCategories { get; set; }
        public virtual DbSet<ItemsParty> ItemsParties { get; set; }
        public virtual DbSet<ItemsPriority> ItemsPriorities { get; set; }
        public virtual DbSet<ItemsRoleCategory> ItemsRoleCategories { get; set; }
        public virtual DbSet<ItemsSecurityLevel> ItemsSecurityLevels { get; set; }
        public virtual DbSet<ItemsSystem> ItemsSystems { get; set; }
        public virtual DbSet<ItemsTablePermissionScope> ItemsTablePermissionScopes { get; set; }
        public virtual DbSet<ItemsTitle> ItemsTitles { get; set; }
        public virtual DbSet<ItemsTrueFalse> ItemsTrueFalses { get; set; }
        public virtual DbSet<ItemsUnit> ItemsUnits { get; set; }
        public virtual DbSet<ItemsWorkCategory> ItemsWorkCategories { get; set; }
        public virtual DbSet<ItemsWorkFlowActivityCategory> ItemsWorkFlowActivityCategories { get; set; }
        public virtual DbSet<ItemsWorkFlowActivityName> ItemsWorkFlowActivityNames { get; set; }
        public virtual DbSet<ItemsWorkFlowCategory> ItemsWorkFlowCategories { get; set; }
        public virtual DbSet<ItemsWorkingProperty> ItemsWorkingProperties { get; set; }
        public virtual DbSet<ItemsWorkStatu> ItemsWorkStatus { get; set; }
        public virtual DbSet<ItemsYesNo> ItemsYesNoes { get; set; }
        public virtual DbSet<OptionItemsComputerCategory> OptionItemsComputerCategories { get; set; }
        public virtual DbSet<OptionItemsDisability> OptionItemsDisabilities { get; set; }
        public virtual DbSet<OptionItemsExpress> OptionItemsExpresses { get; set; }
        public virtual DbSet<OptionItemsFaPiaoShuXing> OptionItemsFaPiaoShuXings { get; set; }
        public virtual DbSet<OptionItemsFuKuanShuXing> OptionItemsFuKuanShuXings { get; set; }
        public virtual DbSet<OptionItemsHousehold> OptionItemsHouseholds { get; set; }
        public virtual DbSet<OptionItemsOilAlarmFiltering> OptionItemsOilAlarmFilterings { get; set; }
        public virtual DbSet<OptionItemsOilDataSource> OptionItemsOilDataSources { get; set; }
        public virtual DbSet<OptionItemsOilEventGroup> OptionItemsOilEventGroups { get; set; }
        public virtual DbSet<OptionItemsOilEventType> OptionItemsOilEventTypes { get; set; }
        public virtual DbSet<OptionItemsOilEventType_Old> OptionItemsOilEventType_Old { get; set; }
        public virtual DbSet<OptionItemsOilInstallation> OptionItemsOilInstallations { get; set; }
        public virtual DbSet<OptionItemsOnSale> OptionItemsOnSales { get; set; }
        public virtual DbSet<OptionItemsPayCategory> OptionItemsPayCategories { get; set; }
        public virtual DbSet<OptionItemsPostCategory> OptionItemsPostCategories { get; set; }
        public virtual DbSet<OptionItemsSalaryItemCategory> OptionItemsSalaryItemCategories { get; set; }
        public virtual DbSet<OptionItemsSendCategory> OptionItemsSendCategories { get; set; }
        public virtual DbSet<OptionItemsShouFeiLeiXing> OptionItemsShouFeiLeiXings { get; set; }
        public virtual DbSet<WorkFlowItem> WorkFlowItems { get; set; }
        public virtual DbSet<WorkFlowModule> WorkFlowModules { get; set; }
        public virtual DbSet<WorkFlowOrganizeScope> WorkFlowOrganizeScopes { get; set; }
        public virtual DbSet<WorkFlowPermission> WorkFlowPermissions { get; set; }
        public virtual DbSet<WorkFlowPermissionScope> WorkFlowPermissionScopes { get; set; }
        public virtual DbSet<WorkFlowRole> WorkFlowRoles { get; set; }
        public virtual DbSet<WorkFlowUserRole> WorkFlowUserRoles { get; set; }
        public virtual DbSet<BaseArea> BaseAreas { get; set; }
        public virtual DbSet<district_area> district_area { get; set; }
        public virtual DbSet<district_city> district_city { get; set; }
        public virtual DbSet<district_province> district_province { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseBillPush>()
                .Property(e => e.SubscriptionCategory)
                .HasPrecision(2, 0);

            modelBuilder.Entity<BaseBillPush>()
                .Property(e => e.SubscriptionStatus)
                .HasPrecision(1, 0);

            modelBuilder.Entity<BaseComment>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BaseExportData>()
                .Property(e => e.ExportSql)
                .IsUnicode(false);

            modelBuilder.Entity<BaseHoliday>()
                .Property(e => e.Holiday)
                .IsFixedLength();

            modelBuilder.Entity<BaseKnowledge>()
                .Property(e => e.PriorityId)
                .IsUnicode(false);

            modelBuilder.Entity<BaseKnowledge>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BaseMessage>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BaseNew>()
                .Property(e => e.Contents)
                .IsUnicode(false);

            modelBuilder.Entity<BaseTableColumn>()
                .Property(e => e.TableCode)
                .IsUnicode(false);

            modelBuilder.Entity<BaseTableColumn>()
                .Property(e => e.ColumnCode)
                .IsUnicode(false);

            modelBuilder.Entity<BaseTableColumn>()
                .Property(e => e.ColumnName)
                .IsUnicode(false);

            modelBuilder.Entity<BaseTableColumn>()
                .Property(e => e.DataType)
                .IsUnicode(false);

            modelBuilder.Entity<BaseTableColumn>()
                .Property(e => e.TargetTable)
                .IsUnicode(false);

            modelBuilder.Entity<BaseTableColumn>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<BaseUser>()
                .HasOptional(e => e.BaseUserContact)
                .WithRequired(e => e.BaseUser)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BaseUser>()
                .HasOptional(e => e.BaseUserLogOn)
                .WithRequired(e => e.BaseUser)
                .WillCascadeOnDelete();

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<OptionItemsExpress>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<OptionItemsExpress>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<OptionItemsPayCategory>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<OptionItemsPayCategory>()
                .Property(e => e.ItemName)
                .IsUnicode(false);
        }
    }
}
