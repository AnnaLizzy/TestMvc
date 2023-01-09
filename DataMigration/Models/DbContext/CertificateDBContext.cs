using Data.Migration.DataSeed;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Data.Migration.Models.DbContext
{
    public partial class CertificateDBContext : IdentityDbContext<UserBeforeLoding, AdminRole, int>
    {
        public CertificateDBContext()
        {
        }

        public CertificateDBContext(DbContextOptions<CertificateDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ATestTable> ATestTables { get; set; } = null!;
        public virtual DbSet<Acc> Accs { get; set; } = null!;
        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<AdminRole> AdminRoles { get; set; } = null!;
        public virtual DbSet<AllEmployeeNo> AllEmployeeNos { get; set; } = null!;
        public virtual DbSet<AndroidUserLoading> AndroidUserLoadings { get; set; } = null!;
        public virtual DbSet<ApexsqlLogConnectionMonitorSession> ApexsqlLogConnectionMonitorSessions { get; set; } = null!;
        public virtual DbSet<ApexsqlLogLogin> ApexsqlLogLogins { get; set; } = null!;
        public virtual DbSet<ApexsqlLogString> ApexsqlLogStrings { get; set; } = null!;
        public virtual DbSet<AppUserBeforeLoding> AppUserBeforeLodings { get; set; } = null!;
        public virtual DbSet<ApplicationDoor> ApplicationDoors { get; set; } = null!;
        public virtual DbSet<ApplicationSignoff> ApplicationSignoffs { get; set; } = null!;
        public virtual DbSet<AppointPerson> AppointPeople { get; set; } = null!;
        public virtual DbSet<AppointmentAddress> AppointmentAddresses { get; set; } = null!;
        public virtual DbSet<AppointmentCount> AppointmentCounts { get; set; } = null!;
        public virtual DbSet<AppointmentDate> AppointmentDates { get; set; } = null!;
        public virtual DbSet<AppointmentDateTime> AppointmentDateTimes { get; set; } = null!;
        public virtual DbSet<AppointmentLog> AppointmentLogs { get; set; } = null!;
        public virtual DbSet<AppointmentPerson> AppointmentPeople { get; set; } = null!;
        public virtual DbSet<AppointmentTime> AppointmentTimes { get; set; } = null!;
        public virtual DbSet<Area> Areas { get; set; } = null!;
        public virtual DbSet<AreaCard> AreaCards { get; set; } = null!;
        public virtual DbSet<AreaDetail> AreaDetails { get; set; } = null!;
        public virtual DbSet<AreaPowerManager> AreaPowerManagers { get; set; } = null!;
        public virtual DbSet<AreaPowerManagerApplication> AreaPowerManagerApplications { get; set; } = null!;
        public virtual DbSet<AreaPowerManagerApprove> AreaPowerManagerApproves { get; set; } = null!;
        public virtual DbSet<AreaPowerManagerProc> AreaPowerManagerProcs { get; set; } = null!;
        public virtual DbSet<AreaPowerManagerStatus> AreaPowerManagerStatuses { get; set; } = null!;
        public virtual DbSet<AreaPowerManagerType> AreaPowerManagerTypes { get; set; } = null!;
        public virtual DbSet<AreaRegion> AreaRegions { get; set; } = null!;
        public virtual DbSet<AreaRegionCertificate> AreaRegionCertificates { get; set; } = null!;
        public virtual DbSet<AreaRegionHistory> AreaRegionHistories { get; set; } = null!;
        public virtual DbSet<AreaRegionValid> AreaRegionValids { get; set; } = null!;
        public virtual DbSet<AreaRegionVehiclePeriod> AreaRegionVehiclePeriods { get; set; } = null!;
        public virtual DbSet<AreaRelation> AreaRelations { get; set; } = null!;
        public virtual DbSet<AreaforImExProduct> AreaforImExProducts { get; set; } = null!;
        public virtual DbSet<AuditProcess> AuditProcesses { get; set; } = null!;
        public virtual DbSet<Bg> Bgs { get; set; } = null!;
        public virtual DbSet<Bgmatch> Bgmatches { get; set; } = null!;
        public virtual DbSet<BlackList> BlackLists { get; set; } = null!;
        public virtual DbSet<Building> Buildings { get; set; } = null!;
        public virtual DbSet<Byf> Byfs { get; set; } = null!;
        public virtual DbSet<Byf1> Byf1s { get; set; } = null!;
        public virtual DbSet<Byf2> Byf2s { get; set; } = null!;
        public virtual DbSet<Byf3> Byf3s { get; set; } = null!;
        public virtual DbSet<Camera> Cameras { get; set; } = null!;
        public virtual DbSet<CameraStatus> CameraStatuses { get; set; } = null!;
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<CarInoutRecord> CarInoutRecords { get; set; } = null!;
        public virtual DbSet<CarPass> CarPasses { get; set; } = null!;
        public virtual DbSet<CarPassBill> CarPassBills { get; set; } = null!;
        public virtual DbSet<CarPassProc> CarPassProcs { get; set; } = null!;
        public virtual DbSet<CarPassStatus> CarPassStatuses { get; set; } = null!;
        public virtual DbSet<CarToStop> CarToStops { get; set; } = null!;
        public virtual DbSet<CarToStop01> CarToStop01s { get; set; } = null!;
        public virtual DbSet<CarTypePass> CarTypePasses { get; set; } = null!;
        public virtual DbSet<CarVip> CarVips { get; set; } = null!;
        public virtual DbSet<CarVipProc> CarVipProcs { get; set; } = null!;
        public virtual DbSet<CarVipStatus> CarVipStatuses { get; set; } = null!;
        public virtual DbSet<Card> Cards { get; set; } = null!;
        public virtual DbSet<CardAdded> CardAddeds { get; set; } = null!;
        public virtual DbSet<CardBorrow> CardBorrows { get; set; } = null!;
        public virtual DbSet<CardChangeHistory> CardChangeHistories { get; set; } = null!;
        public virtual DbSet<CardCompanyHistory> CardCompanyHistories { get; set; } = null!;
        public virtual DbSet<CardCreateTable> CardCreateTables { get; set; } = null!;
        public virtual DbSet<CardHistoryDatum> CardHistoryData { get; set; } = null!;
        public virtual DbSet<CardModel> CardModels { get; set; } = null!;
        public virtual DbSet<CardSwipe> CardSwipes { get; set; } = null!;
        public virtual DbSet<CardTest> CardTests { get; set; } = null!;
        public virtual DbSet<CardText> CardTexts { get; set; } = null!;
        public virtual DbSet<CardVendor> CardVendors { get; set; } = null!;
        public virtual DbSet<CertificateDb> CertificateDbs { get; set; } = null!;
        public virtual DbSet<CertificateDelay> CertificateDelays { get; set; } = null!;
        public virtual DbSet<CertificatesDelay> CertificatesDelays { get; set; } = null!;
        public virtual DbSet<ChargeRecord> ChargeRecords { get; set; } = null!;
        public virtual DbSet<CheckTemp> CheckTemps { get; set; } = null!;
        public virtual DbSet<CheckTime> CheckTimes { get; set; } = null!;
        public virtual DbSet<ChemistryAuthorityChangeEmail> ChemistryAuthorityChangeEmails { get; set; } = null!;
        public virtual DbSet<ChemistryAuthorityHistory> ChemistryAuthorityHistories { get; set; } = null!;
        public virtual DbSet<ChemistryDocforMaterial> ChemistryDocforMaterials { get; set; } = null!;
        public virtual DbSet<ChemistryForm> ChemistryForms { get; set; } = null!;
        public virtual DbSet<ChemistryForm1> ChemistryForms1 { get; set; } = null!;
        public virtual DbSet<ChemistryFormAuthority> ChemistryFormAuthorities { get; set; } = null!;
        public virtual DbSet<ChrCode> ChrCodes { get; set; } = null!;
        public virtual DbSet<ChrEmpCardinfo> ChrEmpCardinfos { get; set; } = null!;
        public virtual DbSet<ChrEmpCardinfoTemp> ChrEmpCardinfoTemps { get; set; } = null!;
        public virtual DbSet<ChrEmployee> ChrEmployees { get; set; } = null!;
        public virtual DbSet<ChrEmployee0228> ChrEmployee0228s { get; set; } = null!;
        public virtual DbSet<ChrEmployeeImage> ChrEmployeeImages { get; set; } = null!;
        public virtual DbSet<ChrEmployeeSwitch> ChrEmployeeSwitches { get; set; } = null!;
        public virtual DbSet<ChrEmployeeTmp> ChrEmployeeTmps { get; set; } = null!;
        public virtual DbSet<ChrEmployeeTransit> ChrEmployeeTransits { get; set; } = null!;
        public virtual DbSet<ChrEmployeeUpdate> ChrEmployeeUpdates { get; set; } = null!;
        public virtual DbSet<ChrEmployeeVv> ChrEmployeeVvs { get; set; } = null!;
        public virtual DbSet<ChrEmployeeVvc> ChrEmployeeVvcs { get; set; } = null!;
        public virtual DbSet<ChrInFactoryImage> ChrInFactoryImages { get; set; } = null!;
        public virtual DbSet<CivetIntentList> CivetIntentLists { get; set; } = null!;
        public virtual DbSet<CivetIntentListMail> CivetIntentListMails { get; set; } = null!;
        public virtual DbSet<CivetListMail> CivetListMails { get; set; } = null!;
        public virtual DbSet<CivetSendMess> CivetSendMesses { get; set; } = null!;
        public virtual DbSet<Cmc812log> Cmc812logs { get; set; } = null!;
        public virtual DbSet<Code> Codes { get; set; } = null!;
        public virtual DbSet<ColorTypeCard> ColorTypeCards { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<CompanyControlHistory> CompanyControlHistories { get; set; } = null!;
        public virtual DbSet<Construction> Constructions { get; set; } = null!;
        public virtual DbSet<ContolstatusInformation> ContolstatusInformations { get; set; } = null!;
        public virtual DbSet<ControlCar> ControlCars { get; set; } = null!;
        public virtual DbSet<ControlCarN> ControlCarNs { get; set; } = null!;
        public virtual DbSet<ControlPeopleBackup> ControlPeopleBackups { get; set; } = null!;
        public virtual DbSet<ControlPeopleN> ControlPeopleNs { get; set; } = null!;
        public virtual DbSet<ControlPerson> ControlPeople { get; set; } = null!;
        public virtual DbSet<ControlRecord> ControlRecords { get; set; } = null!;
        public virtual DbSet<ContrucProc> ContrucProcs { get; set; } = null!;
        public virtual DbSet<ContrucStatus> ContrucStatuses { get; set; } = null!;
        public virtual DbSet<CostSign> CostSigns { get; set; } = null!;
        public virtual DbSet<CredentialContinu> CredentialContinus { get; set; } = null!;
        public virtual DbSet<CredentialDelayNew> CredentialDelayNews { get; set; } = null!;
        public virtual DbSet<CredentialDelayNewSigStatus> CredentialDelayNewSigStatuses { get; set; } = null!;
        public virtual DbSet<CredentialDelaynewListCardNum> CredentialDelaynewListCardNums { get; set; } = null!;
        public virtual DbSet<CredentialDelaynewListCardNumNew> CredentialDelaynewListCardNumNews { get; set; } = null!;
        public virtual DbSet<CustCardRecord> CustCardRecords { get; set; } = null!;
        public virtual DbSet<CustList> CustLists { get; set; } = null!;
        public virtual DbSet<CustNotList> CustNotLists { get; set; } = null!;
        public virtual DbSet<CustTravel> CustTravels { get; set; } = null!;
        public virtual DbSet<CustTravelDetail> CustTravelDetails { get; set; } = null!;
        public virtual DbSet<CustWorCredentsLastInserted> CustWorCredentsLastInserteds { get; set; } = null!;
        public virtual DbSet<CustWorkCredential> CustWorkCredentials { get; set; } = null!;
        public virtual DbSet<CustWorkCredentialsDelay> CustWorkCredentialsDelays { get; set; } = null!;
        public virtual DbSet<CustWorkHistory> CustWorkHistories { get; set; } = null!;
        public virtual DbSet<CustWorkInFactory> CustWorkInFactories { get; set; } = null!;
        public virtual DbSet<CustWorkInFactoryAdminProc> CustWorkInFactoryAdminProcs { get; set; } = null!;
        public virtual DbSet<CustWorkInFactoryPerSon> CustWorkInFactoryPeople { get; set; } = null!;
        public virtual DbSet<CustWorkInFactoryProc> CustWorkInFactoryProcs { get; set; } = null!;
        public virtual DbSet<CustWorkInFactoryStatus> CustWorkInFactoryStatuses { get; set; } = null!;
        public virtual DbSet<CustWorkValid> CustWorkValids { get; set; } = null!;
        public virtual DbSet<CustWorkValidNew> CustWorkValidNews { get; set; } = null!;
        public virtual DbSet<DboChrEmployee2> DboChrEmployee2s { get; set; } = null!;
        public virtual DbSet<DealType> DealTypes { get; set; } = null!;
        public virtual DbSet<DefaultCardInfo> DefaultCardInfos { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<DepartmentAuditPerson> DepartmentAuditPeople { get; set; } = null!;
        public virtual DbSet<DietAttention> DietAttentions { get; set; } = null!;
        public virtual DbSet<DiffTimeLess> DiffTimeLesses { get; set; } = null!;
        public virtual DbSet<DiffTimeMore> DiffTimeMores { get; set; } = null!;
        public virtual DbSet<DimissionUserBeforeLoding> DimissionUserBeforeLodings { get; set; } = null!;
        public virtual DbSet<DispatchRecord> DispatchRecords { get; set; } = null!;
        public virtual DbSet<DoorPowerManage> DoorPowerManages { get; set; } = null!;
        public virtual DbSet<DoorPowerManageApplication> DoorPowerManageApplications { get; set; } = null!;
        public virtual DbSet<DoorPowerManageArea> DoorPowerManageAreas { get; set; } = null!;
        public virtual DbSet<DoorPowerManageAreaApplication> DoorPowerManageAreaApplications { get; set; } = null!;
        public virtual DbSet<DoorPowerManageAreaVer> DoorPowerManageAreaVers { get; set; } = null!;
        public virtual DbSet<DoorPowerManageBgsetup> DoorPowerManageBgsetups { get; set; } = null!;
        public virtual DbSet<DoorPowerManageBgsetupItem> DoorPowerManageBgsetupItems { get; set; } = null!;
        public virtual DbSet<DoorPowerManageBgsignSetup> DoorPowerManageBgsignSetups { get; set; } = null!;
        public virtual DbSet<DoorPowerManageBgsignSetupItem> DoorPowerManageBgsignSetupItems { get; set; } = null!;
        public virtual DbSet<DoorPowerManageModify> DoorPowerManageModifies { get; set; } = null!;
        public virtual DbSet<DoorPowerManageModifyList> DoorPowerManageModifyLists { get; set; } = null!;
        public virtual DbSet<DoorPowerManageType> DoorPowerManageTypes { get; set; } = null!;
        public virtual DbSet<DoorPowerManageTypeApplication> DoorPowerManageTypeApplications { get; set; } = null!;
        public virtual DbSet<DoorPowerManageTypeVer> DoorPowerManageTypeVers { get; set; } = null!;
        public virtual DbSet<DoorPowerManageVer> DoorPowerManageVers { get; set; } = null!;
        public virtual DbSet<DoorReplace> DoorReplaces { get; set; } = null!;
        public virtual DbSet<DoorReplaceBg> DoorReplaceBgs { get; set; } = null!;
        public virtual DbSet<DrawAllList> DrawAllLists { get; set; } = null!;
        public virtual DbSet<Driver> Drivers { get; set; } = null!;
        public virtual DbSet<DriverCompanyMatch> DriverCompanyMatches { get; set; } = null!;
        public virtual DbSet<DriverVehicleMatch> DriverVehicleMatches { get; set; } = null!;
        public virtual DbSet<EconConfig> EconConfigs { get; set; } = null!;
        public virtual DbSet<EhsSign> EhsSigns { get; set; } = null!;
        public virtual DbSet<ElectricUse> ElectricUses { get; set; } = null!;
        public virtual DbSet<EnviEnclosedSpace> EnviEnclosedSpaces { get; set; } = null!;
        public virtual DbSet<EnviHighAction> EnviHighActions { get; set; } = null!;
        public virtual DbSet<ExemptionCar> ExemptionCars { get; set; } = null!;
        public virtual DbSet<ExpCar> ExpCars { get; set; } = null!;
        public virtual DbSet<FingerPrint> FingerPrints { get; set; } = null!;
        public virtual DbSet<FireEngine> FireEngines { get; set; } = null!;
        public virtual DbSet<Form> Forms { get; set; } = null!;
        public virtual DbSet<FormBack> FormBacks { get; set; } = null!;
        public virtual DbSet<FormStatus> FormStatuses { get; set; } = null!;
        public virtual DbSet<FormWorkProc> FormWorkProcs { get; set; } = null!;
        public virtual DbSet<FormbackTest> FormbackTests { get; set; } = null!;
        public virtual DbSet<FourCompanyAll> FourCompanyAlls { get; set; } = null!;
        public virtual DbSet<FourVisitor> FourVisitors { get; set; } = null!;
        public virtual DbSet<FourVisitorAll> FourVisitorAlls { get; set; } = null!;
        public virtual DbSet<GoingOut> GoingOuts { get; set; } = null!;
        public virtual DbSet<Gongyingshang> Gongyingshangs { get; set; } = null!;
        public virtual DbSet<GroupChiefExecutive> GroupChiefExecutives { get; set; } = null!;
        public virtual DbSet<GroupType> GroupTypes { get; set; } = null!;
        public virtual DbSet<GuardStationAbout> GuardStationAbouts { get; set; } = null!;
        public virtual DbSet<GuiBinAudit> GuiBinAudits { get; set; } = null!;
        public virtual DbSet<GuiBinManage> GuiBinManages { get; set; } = null!;
        public virtual DbSet<GuiBinOutCall> GuiBinOutCalls { get; set; } = null!;
        public virtual DbSet<GuiBinReceive> GuiBinReceives { get; set; } = null!;
        public virtual DbSet<GuiBinReturnSin> GuiBinReturnSins { get; set; } = null!;
        public virtual DbSet<HandleResult> HandleResults { get; set; } = null!;
        public virtual DbSet<HandleTrouble> HandleTroubles { get; set; } = null!;
        public virtual DbSet<HangleSign> HangleSigns { get; set; } = null!;
        public virtual DbSet<Help> Helps { get; set; } = null!;
        public virtual DbSet<HgcarInfo> HgcarInfos { get; set; } = null!;
        public virtual DbSet<Hinhvv> Hinhvvs { get; set; } = null!;
        public virtual DbSet<HoanCong> HoanCongs { get; set; } = null!;
        public virtual DbSet<Hoisting> Hoistings { get; set; } = null!;
        public virtual DbSet<HouseLayer> HouseLayers { get; set; } = null!;
        public virtual DbSet<IcivetLogin> IcivetLogins { get; set; } = null!;
        public virtual DbSet<ImExPortProduct> ImExPortProducts { get; set; } = null!;
        public virtual DbSet<ImExPortProductDriverInfor> ImExPortProductDriverInfors { get; set; } = null!;
        public virtual DbSet<ImExPortProductProductInfor> ImExPortProductProductInfors { get; set; } = null!;
        public virtual DbSet<Intermittent> Intermittents { get; set; } = null!;
        public virtual DbSet<InteruptInfrared> InteruptInfrareds { get; set; } = null!;
        public virtual DbSet<InvalidRecord> InvalidRecords { get; set; } = null!;
        public virtual DbSet<ItDevice> ItDevices { get; set; } = null!;
        public virtual DbSet<ItDeviceInfo> ItDeviceInfos { get; set; } = null!;
        public virtual DbSet<ItdevicesListPass> ItdevicesListPasses { get; set; } = null!;
        public virtual DbSet<Itinerary> Itineraries { get; set; } = null!;
        public virtual DbSet<JoinDrawDatum> JoinDrawData { get; set; } = null!;
        public virtual DbSet<JurisdictionType> JurisdictionTypes { get; set; } = null!;
        public virtual DbSet<Layer> Layers { get; set; } = null!;
        public virtual DbSet<LeaseContract> LeaseContracts { get; set; } = null!;
        public virtual DbSet<Link> Links { get; set; } = null!;
        public virtual DbSet<List> Lists { get; set; } = null!;
        public virtual DbSet<ListCamera> ListCameras { get; set; } = null!;
        public virtual DbSet<ListCarMer> ListCarMers { get; set; } = null!;
        public virtual DbSet<ListCarPass> ListCarPasses { get; set; } = null!;
        public virtual DbSet<ListMer> ListMers { get; set; } = null!;
        public virtual DbSet<ListOutPl> ListOutPls { get; set; } = null!;
        public virtual DbSet<ListPosisionCar> ListPosisionCars { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;
        public virtual DbSet<Lodging> Lodgings { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<MachineIppairing> MachineIppairings { get; set; } = null!;
        public virtual DbSet<MachineIppairingInfo> MachineIppairingInfos { get; set; } = null!;
        public virtual DbSet<MakeCardArea> MakeCardAreas { get; set; } = null!;
        public virtual DbSet<MakeCardDataError> MakeCardDataErrors { get; set; } = null!;
        public virtual DbSet<MaterialforChemistry> MaterialforChemistries { get; set; } = null!;
        public virtual DbSet<MaterialforChemistry1> MaterialforChemistries1 { get; set; } = null!;
        public virtual DbSet<Meal> Meals { get; set; } = null!;
        public virtual DbSet<MerCheProc> MerCheProcs { get; set; } = null!;
        public virtual DbSet<MerCheStatus> MerCheStatuses { get; set; } = null!;
        public virtual DbSet<MerProc> MerProcs { get; set; } = null!;
        public virtual DbSet<MerStatus> MerStatuses { get; set; } = null!;
        public virtual DbSet<MerTransfer> MerTransfers { get; set; } = null!;
        public virtual DbSet<MerTransferProc> MerTransferProcs { get; set; } = null!;
        public virtual DbSet<MerTrasferStatus> MerTrasferStatuses { get; set; } = null!;
        public virtual DbSet<Merchandise> Merchandises { get; set; } = null!;
        public virtual DbSet<MessSenLog> MessSenLogs { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<MessageType> MessageTypes { get; set; } = null!;
        public virtual DbSet<MfCarRental> MfCarRentals { get; set; } = null!;
        public virtual DbSet<Mqq> Mqqs { get; set; } = null!;
        public virtual DbSet<Mqq1> Mqq1s { get; set; } = null!;
        public virtual DbSet<Mqq3> Mqq3s { get; set; } = null!;
        public virtual DbSet<NighAction> NighActions { get; set; } = null!;
        public virtual DbSet<NoJoinByCar> NoJoinByCars { get; set; } = null!;
        public virtual DbSet<NoJoinByMan> NoJoinByMen { get; set; } = null!;
        public virtual DbSet<NotesSendLog> NotesSendLogs { get; set; } = null!;
        public virtual DbSet<NvipcardFrom165> NvipcardFrom165s { get; set; } = null!;
        public virtual DbSet<OilRecord> OilRecords { get; set; } = null!;
        public virtual DbSet<OndutyForAttwApprove> OndutyForAttwApproves { get; set; } = null!;
        public virtual DbSet<OndutyForAttwListAuthor> OndutyForAttwListAuthors { get; set; } = null!;
        public virtual DbSet<OndutyForAttwListLocation> OndutyForAttwListLocations { get; set; } = null!;
        public virtual DbSet<OndutyForAttwListLocationsSign> OndutyForAttwListLocationsSigns { get; set; } = null!;
        public virtual DbSet<OndutyForAttwRulesForAllLocation> OndutyForAttwRulesForAllLocations { get; set; } = null!;
        public virtual DbSet<OndutyForAttwStatusSign> OndutyForAttwStatusSigns { get; set; } = null!;
        public virtual DbSet<OndutyListLocation> OndutyListLocations { get; set; } = null!;
        public virtual DbSet<OndutyOfAttwDepart> OndutyOfAttwDeparts { get; set; } = null!;
        public virtual DbSet<OndutyOfAttwDepartFrameTime> OndutyOfAttwDepartFrameTimes { get; set; } = null!;
        public virtual DbSet<OndutySign> OndutySigns { get; set; } = null!;
        public virtual DbSet<OndutySignArea> OndutySignAreas { get; set; } = null!;
        public virtual DbSet<OndutySignForAttwArea> OndutySignForAttwAreas { get; set; } = null!;
        public virtual DbSet<OndutySignLocationSign> OndutySignLocationSigns { get; set; } = null!;
        public virtual DbSet<OndutySignLocationSignHistoryAll> OndutySignLocationSignHistoryAlls { get; set; } = null!;
        public virtual DbSet<OndutySignOfAttwListEmpNo> OndutySignOfAttwListEmpNos { get; set; } = null!;
        public virtual DbSet<OtherCarInfo> OtherCarInfos { get; set; } = null!;
        public virtual DbSet<Othercar> Othercars { get; set; } = null!;
        public virtual DbSet<ParkProfileChart> ParkProfileCharts { get; set; } = null!;
        public virtual DbSet<PassForm> PassForms { get; set; } = null!;
        public virtual DbSet<PeoPleList> PeoPleLists { get; set; } = null!;
        public virtual DbSet<PersonalDocument> PersonalDocuments { get; set; } = null!;
        public virtual DbSet<PersonalItemImage> PersonalItemImages { get; set; } = null!;
        public virtual DbSet<PersonalItemListItem> PersonalItemListItems { get; set; } = null!;
        public virtual DbSet<PersonalItemsAuthority> PersonalItemsAuthorities { get; set; } = null!;
        public virtual DbSet<PersonalItemsForm> PersonalItemsForms { get; set; } = null!;
        public virtual DbSet<PersonalItemsItem> PersonalItemsItems { get; set; } = null!;
        public virtual DbSet<PersonalItemsSigStatus> PersonalItemsSigStatuses { get; set; } = null!;
        public virtual DbSet<PersonalItemsView> PersonalItemsViews { get; set; } = null!;
        public virtual DbSet<PhotoIdmatch> PhotoIdmatches { get; set; } = null!;
        public virtual DbSet<Plapplication> Plapplications { get; set; } = null!;
        public virtual DbSet<Pllist> Pllists { get; set; } = null!;
        public virtual DbSet<PllistOut> PllistOuts { get; set; } = null!;
        public virtual DbSet<PllistOutProtectorReset> PllistOutProtectorResets { get; set; } = null!;
        public virtual DbSet<PllistValid> PllistValids { get; set; } = null!;
        public virtual DbSet<PosisionCarVip> PosisionCarVips { get; set; } = null!;
        public virtual DbSet<PossionCar> PossionCars { get; set; } = null!;
        public virtual DbSet<PowerAdmin> PowerAdmins { get; set; } = null!;
        public virtual DbSet<PowerList> PowerLists { get; set; } = null!;
        public virtual DbSet<PowerRole> PowerRoles { get; set; } = null!;
        public virtual DbSet<PrintCard> PrintCards { get; set; } = null!;
        public virtual DbSet<ProcMer> ProcMers { get; set; } = null!;
        public virtual DbSet<ProcessCarPass> ProcessCarPasses { get; set; } = null!;
        public virtual DbSet<ProductOpportunitiesCust> ProductOpportunitiesCusts { get; set; } = null!;
        public virtual DbSet<ProductOpportunity> ProductOpportunities { get; set; } = null!;
        public virtual DbSet<Profier2013051010> Profier2013051010s { get; set; } = null!;
        public virtual DbSet<Profiler2013050922> Profiler2013050922s { get; set; } = null!;
        public virtual DbSet<QiMeiEmployeeExamine> QiMeiEmployeeExamines { get; set; } = null!;
        public virtual DbSet<QiMeiTwEmloyeeUpdate> QiMeiTwEmloyeeUpdates { get; set; } = null!;
        public virtual DbSet<QuitApply> QuitApplies { get; set; } = null!;
        public virtual DbSet<ReceivingCarPass> ReceivingCarPasses { get; set; } = null!;
        public virtual DbSet<ReceivingRecord> ReceivingRecords { get; set; } = null!;
        public virtual DbSet<ReceptionProgram> ReceptionPrograms { get; set; } = null!;
        public virtual DbSet<ReceptionProgramGovernment> ReceptionProgramGovernments { get; set; } = null!;
        public virtual DbSet<RecovertRecord> RecovertRecords { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<RegionHouse> RegionHouses { get; set; } = null!;
        public virtual DbSet<RemandRecord> RemandRecords { get; set; } = null!;
        public virtual DbSet<Request114> Request114s { get; set; } = null!;
        public virtual DbSet<Request114Sign> Request114Signs { get; set; } = null!;
        public virtual DbSet<RequestProc114> RequestProc114s { get; set; } = null!;
        public virtual DbSet<RequestStatus114> RequestStatus114s { get; set; } = null!;
        public virtual DbSet<SchedulePlan> SchedulePlans { get; set; } = null!;
        public virtual DbSet<ScrapCar> ScrapCars { get; set; } = null!;
        public virtual DbSet<ScrapCarAuthority> ScrapCarAuthorities { get; set; } = null!;
        public virtual DbSet<ScrapCarContructorAuthority> ScrapCarContructorAuthorities { get; set; } = null!;
        public virtual DbSet<ScrapCarGaReject> ScrapCarGaRejects { get; set; } = null!;
        public virtual DbSet<ScrapCarHistoryCheckPass> ScrapCarHistoryCheckPasses { get; set; } = null!;
        public virtual DbSet<ScrapCarIn> ScrapCarIns { get; set; } = null!;
        public virtual DbSet<ScrapContructorIn> ScrapContructorIns { get; set; } = null!;
        public virtual DbSet<ScrapContructorInListDriver> ScrapContructorInListDrivers { get; set; } = null!;
        public virtual DbSet<ScrapInconstant> ScrapInconstants { get; set; } = null!;
        public virtual DbSet<ScrapInconstantAuthor> ScrapInconstantAuthors { get; set; } = null!;
        public virtual DbSet<ScrapList> ScrapLists { get; set; } = null!;
        public virtual DbSet<ScrapOut> ScrapOuts { get; set; } = null!;
        public virtual DbSet<ScrapOutProc> ScrapOutProcs { get; set; } = null!;
        public virtual DbSet<ScrapOutStatus> ScrapOutStatuses { get; set; } = null!;
        public virtual DbSet<SeMerTransfer> SeMerTransfers { get; set; } = null!;
        public virtual DbSet<SecuretyTable> SecuretyTables { get; set; } = null!;
        public virtual DbSet<SecurityError> SecurityErrors { get; set; } = null!;
        public virtual DbSet<SecurityInfor> SecurityInfors { get; set; } = null!;
        public virtual DbSet<SecurityList> SecurityLists { get; set; } = null!;
        public virtual DbSet<SecurityProcess> SecurityProcesses { get; set; } = null!;
        public virtual DbSet<SecurityReport> SecurityReports { get; set; } = null!;
        public virtual DbSet<SecurityReportSigner> SecurityReportSigners { get; set; } = null!;
        public virtual DbSet<SecurityTrain> SecurityTrains { get; set; } = null!;
        public virtual DbSet<SendSm> SendSms { get; set; } = null!;
        public virtual DbSet<SerialNumber> SerialNumbers { get; set; } = null!;
        public virtual DbSet<Sheet1> Sheet1s { get; set; } = null!;
        public virtual DbSet<ShuttleVisitor> ShuttleVisitors { get; set; } = null!;
        public virtual DbSet<SigStatusChemistry> SigStatusChemistries { get; set; } = null!;
        public virtual DbSet<SigStatusChemistry1> SigStatusChemistries1 { get; set; } = null!;
        public virtual DbSet<SignLog> SignLogs { get; set; } = null!;
        public virtual DbSet<SignProcess> SignProcesses { get; set; } = null!;
        public virtual DbSet<SignRole> SignRoles { get; set; } = null!;
        public virtual DbSet<SignStatus> SignStatuses { get; set; } = null!;
        public virtual DbSet<SpareCar> SpareCars { get; set; } = null!;
        public virtual DbSet<SpareCarReport> SpareCarReports { get; set; } = null!;
        public virtual DbSet<StatusMer> StatusMers { get; set; } = null!;
        public virtual DbSet<SupplementaryInfo> SupplementaryInfos { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<TempContact> TempContacts { get; set; } = null!;
        public virtual DbSet<TemporaryCredential> TemporaryCredentials { get; set; } = null!;
        public virtual DbSet<TestTable> TestTables { get; set; } = null!;
        public virtual DbSet<TestTableSentdata1> TestTableSentdata1s { get; set; } = null!;
        public virtual DbSet<TestTableSentdata2> TestTableSentdata2s { get; set; } = null!;
        public virtual DbSet<TestUploadImage> TestUploadImages { get; set; } = null!;
        public virtual DbSet<ToPrint> ToPrints { get; set; } = null!;
        public virtual DbSet<TotalType> TotalTypes { get; set; } = null!;
        public virtual DbSet<TroubleImage> TroubleImages { get; set; } = null!;
        public virtual DbSet<TroubleType> TroubleTypes { get; set; } = null!;
        public virtual DbSet<TtCorona2019ByBg> TtCorona2019ByBgs { get; set; } = null!;
        public virtual DbSet<TtDichCorona2020> TtDichCorona2020s { get; set; } = null!;
        public virtual DbSet<Ttt> Ttts { get; set; } = null!;
        public virtual DbSet<Twemployee> Twemployees { get; set; } = null!;
        public virtual DbSet<TwemployeeBack> TwemployeeBacks { get; set; } = null!;
        public virtual DbSet<TwemployeeUpdate> TwemployeeUpdates { get; set; } = null!;
        public virtual DbSet<TwemployeeUpdateBack> TwemployeeUpdateBacks { get; set; } = null!;
        public virtual DbSet<TypeConfig> TypeConfigs { get; set; } = null!;
        public virtual DbSet<UnderWriteFlow> UnderWriteFlows { get; set; } = null!;
        public virtual DbSet<UnderWriteModel> UnderWriteModels { get; set; } = null!;
        public virtual DbSet<UnderWriteNoClosed> UnderWriteNoCloseds { get; set; } = null!;
        public virtual DbSet<UnderWriteRecord> UnderWriteRecords { get; set; } = null!;
        public virtual DbSet<UnderWriteType> UnderWriteTypes { get; set; } = null!;
        public virtual DbSet<Untitled3> Untitled3s { get; set; } = null!;
        public virtual DbSet<UpdateScrap> UpdateScraps { get; set; } = null!;
        public virtual DbSet<Url> Urls { get; set; } = null!;
        public virtual DbSet<UserBeforeLoding> UserBeforeLodings { get; set; } = null!;
        public virtual DbSet<UserIdzalo> UserIdzalos { get; set; } = null!;
        public virtual DbSet<UserMember> UserMembers { get; set; } = null!;
        public virtual DbSet<VCarWhiteInfo> VCarWhiteInfos { get; set; } = null!;
        public virtual DbSet<VNewNcarToDriver> VNewNcarToDrivers { get; set; } = null!;
        public virtual DbSet<VeQuestionnaire> VeQuestionnaires { get; set; } = null!;
        public virtual DbSet<VehicleCardRecord> VehicleCardRecords { get; set; } = null!;
        public virtual DbSet<VehicleImportRecordFstTier> VehicleImportRecordFstTiers { get; set; } = null!;
        public virtual DbSet<VehicleImportRecordFstTierHistory> VehicleImportRecordFstTierHistories { get; set; } = null!;
        public virtual DbSet<VehicleImportRecordFstTierTemp> VehicleImportRecordFstTierTemps { get; set; } = null!;
        public virtual DbSet<VehicleImportRecordLhaqdm> VehicleImportRecordLhaqdms { get; set; } = null!;
        public virtual DbSet<VehiclePeriod> VehiclePeriods { get; set; } = null!;
        public virtual DbSet<VehiclePermit> VehiclePermits { get; set; } = null!;
        public virtual DbSet<VehiclePermitAppend> VehiclePermitAppends { get; set; } = null!;
        public virtual DbSet<VehiclePermitEmployee> VehiclePermitEmployees { get; set; } = null!;
        public virtual DbSet<VehiclePermitHistory> VehiclePermitHistories { get; set; } = null!;
        public virtual DbSet<VehiclePermitPhoto> VehiclePermitPhotos { get; set; } = null!;
        public virtual DbSet<VehiclePermitValid> VehiclePermitValids { get; set; } = null!;
        public virtual DbSet<VehiclePersonnel> VehiclePersonnel { get; set; } = null!;
        public virtual DbSet<VehiclesEmployee> VehiclesEmployees { get; set; } = null!;
        public virtual DbSet<VendorCardView> VendorCardViews { get; set; } = null!;
        public virtual DbSet<ViTest> ViTests { get; set; } = null!;
        public virtual DbSet<ViewAllCredential> ViewAllCredentials { get; set; } = null!;
        public virtual DbSet<ViewAreaRegionByCard> ViewAreaRegionByCards { get; set; } = null!;
        public virtual DbSet<ViewAreaRegionByCrendential> ViewAreaRegionByCrendentials { get; set; } = null!;
        public virtual DbSet<ViewBg> ViewBgs { get; set; } = null!;
        public virtual DbSet<ViewCapassForScrapCaIn> ViewCapassForScrapCaIns { get; set; } = null!;
        public virtual DbSet<ViewCarPass> ViewCarPasses { get; set; } = null!;
        public virtual DbSet<ViewCardChange> ViewCardChanges { get; set; } = null!;
        public virtual DbSet<ViewCardNumber> ViewCardNumbers { get; set; } = null!;
        public virtual DbSet<ViewCardWithCardId> ViewCardWithCardIds { get; set; } = null!;
        public virtual DbSet<ViewColorTypeCard> ViewColorTypeCards { get; set; } = null!;
        public virtual DbSet<ViewControlCar> ViewControlCars { get; set; } = null!;
        public virtual DbSet<ViewControlPerson> ViewControlPeople { get; set; } = null!;
        public virtual DbSet<ViewContruc> ViewContrucs { get; set; } = null!;
        public virtual DbSet<ViewCredential> ViewCredentials { get; set; } = null!;
        public virtual DbSet<ViewCredential1> ViewCredentials1 { get; set; } = null!;
        public virtual DbSet<ViewCredentialListCardNumAll> ViewCredentialListCardNumAlls { get; set; } = null!;
        public virtual DbSet<ViewCustWorkCredential> ViewCustWorkCredentials { get; set; } = null!;
        public virtual DbSet<ViewCustomerCard> ViewCustomerCards { get; set; } = null!;
        public virtual DbSet<ViewDoorPowerManageBguser> ViewDoorPowerManageBgusers { get; set; } = null!;
        public virtual DbSet<ViewDriverCardMatch> ViewDriverCardMatches { get; set; } = null!;
        public virtual DbSet<ViewDriverCardMatch1> ViewDriverCardMatch1s { get; set; } = null!;
        public virtual DbSet<ViewDriverCardMatchTemp> ViewDriverCardMatchTemps { get; set; } = null!;
        public virtual DbSet<ViewEmployeeCar> ViewEmployeeCars { get; set; } = null!;
        public virtual DbSet<ViewExternalCar> ViewExternalCars { get; set; } = null!;
        public virtual DbSet<ViewIntent> ViewIntents { get; set; } = null!;
        public virtual DbSet<ViewNblacklist> ViewNblacklists { get; set; } = null!;
        public virtual DbSet<ViewNcarBlackList> ViewNcarBlackLists { get; set; } = null!;
        public virtual DbSet<ViewNote> ViewNotes { get; set; } = null!;
        public virtual DbSet<ViewOldClcard> ViewOldClcards { get; set; } = null!;
        public virtual DbSet<ViewOldNcomeuser> ViewOldNcomeusers { get; set; } = null!;
        public virtual DbSet<ViewOldNcomeuserTemp> ViewOldNcomeuserTemps { get; set; } = null!;
        public virtual DbSet<ViewOldNcomeuserTemp1> ViewOldNcomeuserTemp1s { get; set; } = null!;
        public virtual DbSet<ViewOldNcomeuserTemp20141211old> ViewOldNcomeuserTemp20141211olds { get; set; } = null!;
        public virtual DbSet<ViewOldNusercard> ViewOldNusercards { get; set; } = null!;
        public virtual DbSet<ViewOldNusercardTemp> ViewOldNusercardTemps { get; set; } = null!;
        public virtual DbSet<ViewOldNusercardTemp1> ViewOldNusercardTemp1s { get; set; } = null!;
        public virtual DbSet<ViewOldZccard> ViewOldZccards { get; set; } = null!;
        public virtual DbSet<ViewOndytyApprove> ViewOndytyApproves { get; set; } = null!;
        public virtual DbSet<ViewPeopleList> ViewPeopleLists { get; set; } = null!;
        public virtual DbSet<ViewPllistScrapOut> ViewPllistScrapOuts { get; set; } = null!;
        public virtual DbSet<ViewRentalCar> ViewRentalCars { get; set; } = null!;
        public virtual DbSet<ViewSafeCheckHistoryCheck> ViewSafeCheckHistoryChecks { get; set; } = null!;
        public virtual DbSet<ViewSafeCheckHistorycheckByPlant> ViewSafeCheckHistorycheckByPlants { get; set; } = null!;
        public virtual DbSet<ViewSafeCheckResultCheckP> ViewSafeCheckResultCheckPs { get; set; } = null!;
        public virtual DbSet<ViewSafeCheckUser> ViewSafeCheckUsers { get; set; } = null!;
        public virtual DbSet<ViewScrapCarReceiveMesZalo> ViewScrapCarReceiveMesZalos { get; set; } = null!;
        public virtual DbSet<ViewSearchSign> ViewSearchSigns { get; set; } = null!;
        public virtual DbSet<ViewSmartList> ViewSmartLists { get; set; } = null!;
        public virtual DbSet<ViewSupplierCard> ViewSupplierCards { get; set; } = null!;
        public virtual DbSet<ViewSwipingCardCheck> ViewSwipingCardChecks { get; set; } = null!;
        public virtual DbSet<ViewSwipingCardCheckTemp> ViewSwipingCardCheckTemps { get; set; } = null!;
        public virtual DbSet<ViewSwipingCardCheckTemp1> ViewSwipingCardCheckTemp1s { get; set; } = null!;
        public virtual DbSet<ViewTest01kk> ViewTest01kks { get; set; } = null!;
        public virtual DbSet<ViewTest01kkBuf> ViewTest01kkBufs { get; set; } = null!;
        public virtual DbSet<ViewUser> ViewUsers { get; set; } = null!;
        public virtual DbSet<ViewVehicleCardCheck> ViewVehicleCardChecks { get; set; } = null!;
        public virtual DbSet<ViewVehicleCardCheck1> ViewVehicleCardCheck1s { get; set; } = null!;
        public virtual DbSet<ViewVehicleCardCheckTemp> ViewVehicleCardCheckTemps { get; set; } = null!;
        public virtual DbSet<ViewVehiclePermitEmployee> ViewVehiclePermitEmployees { get; set; } = null!;
        public virtual DbSet<ViewVendorCard> ViewVendorCards { get; set; } = null!;
        public virtual DbSet<ViewVipCardApp> ViewVipCardApps { get; set; } = null!;
        public virtual DbSet<ViheWeight> ViheWeights { get; set; } = null!;
        public virtual DbSet<VipCarIsOpen> VipCarIsOpens { get; set; } = null!;
        public virtual DbSet<VipCard> VipCards { get; set; } = null!;
        public virtual DbSet<VipCardNum> VipCardNums { get; set; } = null!;
        public virtual DbSet<VipCardReceive> VipCardReceives { get; set; } = null!;
        public virtual DbSet<VipDisable> VipDisables { get; set; } = null!;
        public virtual DbSet<VipOutCall> VipOutCalls { get; set; } = null!;
        public virtual DbSet<VipcardApplication> VipcardApplications { get; set; } = null!;
        public virtual DbSet<VisitArrangement> VisitArrangements { get; set; } = null!;
        public virtual DbSet<VisitCar> VisitCars { get; set; } = null!;
        public virtual DbSet<VisitCard> VisitCards { get; set; } = null!;
        public virtual DbSet<VisitCredential> VisitCredentials { get; set; } = null!;
        public virtual DbSet<VisitCredentialsProc> VisitCredentialsProcs { get; set; } = null!;
        public virtual DbSet<VisitCredentialsStatus> VisitCredentialsStatuses { get; set; } = null!;
        public virtual DbSet<VisitCustomer> VisitCustomers { get; set; } = null!;
        public virtual DbSet<VisitFactory> VisitFactories { get; set; } = null!;
        public virtual DbSet<VisitGovernment> VisitGovernments { get; set; } = null!;
        public virtual DbSet<VisitGovernmentAdvanced> VisitGovernmentAdvanceds { get; set; } = null!;
        public virtual DbSet<VisitGovernmentAdvancedList> VisitGovernmentAdvancedLists { get; set; } = null!;
        public virtual DbSet<VisitGovernmentList> VisitGovernmentLists { get; set; } = null!;
        public virtual DbSet<VisitHistory> VisitHistories { get; set; } = null!;
        public virtual DbSet<VisitList> VisitLists { get; set; } = null!;
        public virtual DbSet<VisitNature> VisitNatures { get; set; } = null!;
        public virtual DbSet<VisitNatureCust> VisitNatureCusts { get; set; } = null!;
        public virtual DbSet<VisitNotCust> VisitNotCusts { get; set; } = null!;
        public virtual DbSet<VisitStatus> VisitStatuses { get; set; } = null!;
        public virtual DbSet<VisitTimeOutForm> VisitTimeOutForms { get; set; } = null!;
        public virtual DbSet<VisitantCertificate> VisitantCertificates { get; set; } = null!;
        public virtual DbSet<Visitor> Visitors { get; set; } = null!;
        public virtual DbSet<VwCarInfo> VwCarInfos { get; set; } = null!;
        public virtual DbSet<VwEmpAndCustInfo> VwEmpAndCustInfos { get; set; } = null!;
        public virtual DbSet<VwGuiBingCarInfo> VwGuiBingCarInfos { get; set; } = null!;
        public virtual DbSet<WebVerson> WebVersons { get; set; } = null!;
        public virtual DbSet<WebVisitRecord> WebVisitRecords { get; set; } = null!;
        public virtual DbSet<WeeklyReport> WeeklyReports { get; set; } = null!;
        public virtual DbSet<WeiCall> WeiCalls { get; set; } = null!;
        public virtual DbSet<WeightApi> WeightApis { get; set; } = null!;
        public virtual DbSet<WeightApi1> WeightApi1s { get; set; } = null!;
        public virtual DbSet<WeightPo> WeightPos { get; set; } = null!;
        public virtual DbSet<WorkNote> WorkNotes { get; set; } = null!;
        public virtual DbSet<WorkTypeInFac> WorkTypeInFacs { get; set; } = null!;
        public virtual DbSet<Yhuhu> Yhuhus { get; set; } = null!;

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Seed();
            modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("UserLogin").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserRole<int>>().ToTable("UserRoles")
                .HasKey(x => new
                {
                    x.RoleId,
                    x.UserId
                });
            modelBuilder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserToken<int>>().ToTable("UserTokens")
                .HasKey(x => x.UserId);

            modelBuilder.Entity<ATestTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("A_TestTable");

                entity.Property(e => e.Char1)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Acc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("acc");

                entity.Property(e => e.F1).HasMaxLength(255);
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Admin");

                entity.Property(e => e.AdminId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AdminID");

                entity.Property(e => e.AdminRoleId).HasColumnName("AdminRoleID");

                entity.Property(e => e.Annex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bgid)
                    .HasColumnName("BGID")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.Ext)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdminRole>(entity =>
            {
                entity.ToTable("AdminRole");

                entity.Property(e => e.AdminRoleId).HasColumnName("AdminRoleID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AllEmployeeNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllEmployeeNo");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AndroidUserLoading>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Android_UserLoading");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Passworld)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApexsqlLogConnectionMonitorSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK__APEXSQL_LOG_CONN__34ADA24A");

                entity.ToTable("APEXSQL_LOG_CONNECTION_MONITOR_SESSION");

                entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(256)
                    .HasColumnName("SERVER_NAME");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("START_TIME");

                entity.Property(e => e.StopTime)
                    .HasColumnType("datetime")
                    .HasColumnName("STOP_TIME");
            });

            modelBuilder.Entity<ApexsqlLogLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("APEXSQL_LOG_LOGIN");

                entity.HasIndex(e => new { e.Spid, e.LoginTime, e.ServerName }, "IX_APEXSQL_LOG_LOGIN_2010")
                    .IsClustered();

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(256)
                    .HasColumnName("APPLICATION_NAME");

                entity.Property(e => e.ClientHost)
                    .HasMaxLength(256)
                    .HasColumnName("CLIENT_HOST");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(256)
                    .HasColumnName("LOGIN_NAME");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("LOGIN_TIME");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(256)
                    .HasColumnName("SERVER_NAME");

                entity.Property(e => e.Spid).HasColumnName("SPID");
            });

            modelBuilder.Entity<ApexsqlLogString>(entity =>
            {
                entity.HasKey(e => new { e.ColType, e.ColName });

                entity.ToTable("APEXSQL_LOG_STRINGS");

                entity.Property(e => e.ColType).HasColumnName("COL_TYPE");

                entity.Property(e => e.ColName)
                    .HasMaxLength(256)
                    .HasColumnName("COL_NAME");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(256)
                    .HasColumnName("SERVER_NAME");
            });

            modelBuilder.Entity<AppUserBeforeLoding>(entity =>
            {
                entity.ToTable("App_UserBeforeLoding");

                entity.Property(e => e.AppUserBeforeLodingId).HasColumnName("App_UserBeforeLodingID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationDoor>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK_APPLICATIONDOOR");

                entity.ToTable("ApplicationDoor");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.BgledName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BGLedName");

                entity.Property(e => e.BgledNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BGLedNo");

                entity.Property(e => e.Bgpost)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BGPost");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.File)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationSignoff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApplicationSignoff");

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.ApplicationEmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ApplicationEmployeeNO");

                entity.Property(e => e.ApplicationSignoffId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ApplicationSignoffID");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppointPerson>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ApplicationNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuditName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AuditNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuditNote)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppointmentAddress>(entity =>
            {
                entity.HasKey(e => e.AppointmentAddressGuid);

                entity.ToTable("AppointmentAddress");

                entity.Property(e => e.AppointmentAddressGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("AppointmentAddressGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AppointmentAddressId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AppointmentAddressID");

                entity.Property(e => e.AppointmentAddressName).HasMaxLength(50);
            });

            modelBuilder.Entity<AppointmentCount>(entity =>
            {
                entity.HasKey(e => e.AppointmentCountGuid);

                entity.ToTable("AppointmentCount");

                entity.Property(e => e.AppointmentCountGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("AppointmentCountGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AppointmentCount1).HasColumnName("AppointmentCount");

                entity.Property(e => e.AppointmentCountId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AppointmentCountID");

                entity.Property(e => e.AppointmentPeopleNo).HasMaxLength(50);
            });

            modelBuilder.Entity<AppointmentDate>(entity =>
            {
                entity.HasKey(e => e.AppointmentDateGuid);

                entity.ToTable("AppointmentDate");

                entity.Property(e => e.AppointmentDateGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("AppointmentDateGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AppointmentDateId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AppointmentDateID");

                entity.Property(e => e.AppointmentDateName).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppointmentDateTime>(entity =>
            {
                entity.HasKey(e => e.AppointmentDateTimeGuid);

                entity.ToTable("AppointmentDateTime");

                entity.Property(e => e.AppointmentDateTimeGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("AppointmentDateTimeGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AppointmentAddressGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("AppointmentAddressGUID");

                entity.Property(e => e.AppointmentDateGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("AppointmentDateGUID");

                entity.Property(e => e.AppointmentDateTimeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AppointmentDateTimeID");

                entity.Property(e => e.AppointmentTimeGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("AppointmentTimeGUID");
            });

            modelBuilder.Entity<AppointmentLog>(entity =>
            {
                entity.ToTable("AppointmentLog");

                entity.Property(e => e.AppointmentLogId).HasColumnName("AppointmentLogID");

                entity.Property(e => e.AppointmentAddressName).HasMaxLength(50);

                entity.Property(e => e.AppointmentDateName).HasColumnType("datetime");

                entity.Property(e => e.AppointmentPeopleNo).HasMaxLength(50);

                entity.Property(e => e.AppointmentStatus).HasMaxLength(50);

                entity.Property(e => e.AppointmentTimeName).HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AppointmentPerson>(entity =>
            {
                entity.HasKey(e => e.AppointmentPeopleGuid);

                entity.Property(e => e.AppointmentPeopleGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("AppointmentPeopleGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AppointmentDateTimeGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("AppointmentDateTimeGUID");

                entity.Property(e => e.AppointmentPeopleId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AppointmentPeopleID");

                entity.Property(e => e.AppointmentPeopleNo)
                    .HasMaxLength(50)
                    .HasComment("Mã số công việc");

                entity.Property(e => e.AppointmentStatus).HasComment("Trạng thái cuộc hẹn: 0 đã đặt trước, 3 đã hủy");
            });

            modelBuilder.Entity<AppointmentTime>(entity =>
            {
                entity.HasKey(e => e.AppointmentTimeGuid);

                entity.ToTable("AppointmentTime");

                entity.Property(e => e.AppointmentTimeGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("AppointmentTimeGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AppointmentTimeBeginTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Thời gian bắt đầu thời điểm cuộc hẹn");

                entity.Property(e => e.AppointmentTimeEndTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Thời gian kết thúc thời điểm cuộc hẹn");

                entity.Property(e => e.AppointmentTimeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AppointmentTimeID");

                entity.Property(e => e.AppointmentTimeName)
                    .HasMaxLength(100)
                    .HasComment("\r\nTên vị trí cuộc hẹn");

                entity.Property(e => e.PeopleCount).HasComment("Số người");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Area");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaMeno).HasMaxLength(250);

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AreaCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AreaCard");

                entity.Property(e => e.AreaCard1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AreaCard");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Meno)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AreaDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AreaDetail");

                entity.Property(e => e.AreaRegionId).HasColumnName("AreaRegionID");

                entity.Property(e => e.DetailAreaName).HasMaxLength(300);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<AreaPowerManager>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AreaPowerManager");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.AreaId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AreaID");

                entity.Property(e => e.AreaName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.BuCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuName).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExtTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.M02a).HasColumnName("M02A");

                entity.Property(e => e.M02b).HasColumnName("M02B");

                entity.Property(e => e.M02c).HasColumnName("M02C");

                entity.Property(e => e.M02d).HasColumnName("M02D");

                entity.Property(e => e.M02e).HasColumnName("M02E");

                entity.Property(e => e.M02f).HasColumnName("M02F");

                entity.Property(e => e.M02g).HasColumnName("M02G");

                entity.Property(e => e.Notes)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.W01a).HasColumnName("W01A");

                entity.Property(e => e.W01b).HasColumnName("W01B");

                entity.Property(e => e.W01c).HasColumnName("W01C");

                entity.Property(e => e.W01d).HasColumnName("W01D");

                entity.Property(e => e.W02a).HasColumnName("W02A");

                entity.Property(e => e.W02b).HasColumnName("W02B");

                entity.Property(e => e.W02c).HasColumnName("W02C");

                entity.Property(e => e.W02d).HasColumnName("W02D");

                entity.Property(e => e.W02e).HasColumnName("W02E");

                entity.Property(e => e.W03a).HasColumnName("W03A");

                entity.Property(e => e.W03b).HasColumnName("W03B");
            });

            modelBuilder.Entity<AreaPowerManagerApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AreaPowerManagerApplication");

                entity.Property(e => e.ApplicationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ApplicationID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AreaPowerManagerApprove>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AreaPowerManagerApprove");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.AreaId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AreaID");

                entity.Property(e => e.AreaName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.BuCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuName).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExtTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.M02a).HasColumnName("M02A");

                entity.Property(e => e.M02b).HasColumnName("M02B");

                entity.Property(e => e.M02c).HasColumnName("M02C");

                entity.Property(e => e.M02d).HasColumnName("M02D");

                entity.Property(e => e.M02e).HasColumnName("M02E");

                entity.Property(e => e.M02f).HasColumnName("M02F");

                entity.Property(e => e.M02g).HasColumnName("M02G");

                entity.Property(e => e.Notes)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.W01a).HasColumnName("W01A");

                entity.Property(e => e.W01b).HasColumnName("W01B");

                entity.Property(e => e.W01c).HasColumnName("W01C");

                entity.Property(e => e.W01d).HasColumnName("W01D");

                entity.Property(e => e.W02a).HasColumnName("W02A");

                entity.Property(e => e.W02b).HasColumnName("W02B");

                entity.Property(e => e.W02c).HasColumnName("W02C");

                entity.Property(e => e.W02d).HasColumnName("W02D");

                entity.Property(e => e.W02e).HasColumnName("W02E");

                entity.Property(e => e.W03a).HasColumnName("W03A");

                entity.Property(e => e.W03b).HasColumnName("W03B");
            });

            modelBuilder.Entity<AreaPowerManagerProc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AreaPowerManagerProc");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.ProcId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProcID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.WordTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AreaPowerManagerStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AreaPowerManagerStatus");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("StatusID");

                entity.Property(e => e.WordDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AreaPowerManagerType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AreaPowerManagerType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JurisdisctionTypeId).HasColumnName("JurisdisctionTypeID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AreaRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AreaRegion");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaRegionId).HasColumnName("AreaRegionID");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<AreaRegionCertificate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AreaRegionCertificate");

                entity.Property(e => e.AreaRegionId).HasColumnName("AreaRegionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Meno).HasMaxLength(50);
            });

            modelBuilder.Entity<AreaRegionHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AreaRegionHistory");

                entity.Property(e => e.AreaRegionId).HasColumnName("AreaRegionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Meno)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AreaRegionValid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AreaRegionValid");

                entity.Property(e => e.AreaRegionId).HasColumnName("AreaRegionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Meno).HasMaxLength(50);
            });

            modelBuilder.Entity<AreaRegionVehiclePeriod>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AreaRegionVehiclePeriod");

                entity.Property(e => e.AreaRegionId).HasColumnName("AreaRegionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Meno)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AreaRelation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AreaRelation");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaRid).HasColumnName("AreaRID");
            });

            modelBuilder.Entity<AreaforImExProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Areafor_ImExProduct");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.AreaNameT).HasMaxLength(100);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditProcess>(entity =>
            {
                entity.HasKey(e => e.AuditId);

                entity.ToTable("AuditProcess");

                entity.Property(e => e.AuditId).HasColumnName("AuditID");

                entity.Property(e => e.AuditMeno)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AuditPeople)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuditResult)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.Employee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Leavel).HasColumnName("leavel");
            });

            modelBuilder.Entity<Bg>(entity =>
            {
                entity.ToTable("BG");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bgname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BGName");
            });

            modelBuilder.Entity<Bgmatch>(entity =>
            {
                entity.ToTable("BGMatch");

                entity.Property(e => e.BgmatchId).HasColumnName("BGMatchID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.BgmatchName)
                    .HasMaxLength(100)
                    .HasColumnName("BGMatchName");
            });

            modelBuilder.Entity<BlackList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BlackList");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NumberCar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PeopleID");

                entity.Property(e => e.TimeApplication).HasColumnType("datetime");

                entity.Property(e => e.TimeBlock).HasColumnType("datetime");
            });

            modelBuilder.Entity<Building>(entity =>
            {
                entity.ToTable("Building");

                entity.Property(e => e.BuildingId).HasColumnName("BuildingID");

                entity.Property(e => e.BuildingName).HasMaxLength(50);
            });

            modelBuilder.Entity<Byf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("byf");

                entity.Property(e => e.Carlicense)
                    .HasMaxLength(255)
                    .HasColumnName("carlicense");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<Byf1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("byf_1");

                entity.Property(e => e.Audittime)
                    .HasColumnType("datetime")
                    .HasColumnName("audittime");

                entity.Property(e => e.Carlicense)
                    .HasMaxLength(255)
                    .HasColumnName("carlicense");

                entity.Property(e => e.Cause)
                    .HasMaxLength(50)
                    .HasColumnName("cause");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Num).HasColumnName("num");
            });

            modelBuilder.Entity<Byf2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("byf_2");

                entity.Property(e => e.Carlicense)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("carlicense");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone1");

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone2");
            });

            modelBuilder.Entity<Byf3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("byf_3");

                entity.Property(e => e.Audittime)
                    .HasColumnType("datetime")
                    .HasColumnName("audittime");

                entity.Property(e => e.Carlicense)
                    .HasMaxLength(255)
                    .HasColumnName("carlicense");

                entity.Property(e => e.Cause)
                    .HasMaxLength(50)
                    .HasColumnName("cause");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Num).HasColumnName("num");
            });

            modelBuilder.Entity<Camera>(entity =>
            {
                entity.ToTable("Camera");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.CheckData).HasMaxLength(200);

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmpTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoiDung).HasMaxLength(200);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeApplication).HasColumnType("datetime");

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<CameraStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CameraStatus");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("Car");

                entity.Property(e => e.CarId).HasColumnName("CarID");

                entity.Property(e => e.CarColor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CarType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemandTime).HasColumnType("datetime");

                entity.Property(e => e.VisitorsId).HasColumnName("VisitorsID");
            });

            modelBuilder.Entity<CarInoutRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("car_inout_record");

                entity.Property(e => e.Bak)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bak");

                entity.Property(e => e.CarNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("car_no");

                entity.Property(e => e.CarNum)
                    .HasMaxLength(4000)
                    .HasColumnName("car_num");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("imagepath");

                entity.Property(e => e.Place)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.Property(e => e.SDir)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("s_dir");

                entity.Property(e => e.Stime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stime");

                entity.Property(e => e.Style)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("style");
            });

            modelBuilder.Entity<CarPass>(entity =>
            {
                entity.HasKey(e => e.Idve);

                entity.ToTable("CarPass");

                entity.Property(e => e.Idve).HasColumnName("IDVe");

                entity.Property(e => e.CapBac).HasMaxLength(50);

                entity.Property(e => e.CarColor).HasMaxLength(50);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CarTypeOther).HasMaxLength(50);

                entity.Property(e => e.CardArea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.FileAddendum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idlicer)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDLicer");

                entity.Property(e => e.Idpeople)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDPeople");

                entity.Property(e => e.ImageCar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameCn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NameCN");

                entity.Property(e => e.NameVn)
                    .HasMaxLength(50)
                    .HasColumnName("NameVN");

                entity.Property(e => e.PosisionCar).HasMaxLength(50);

                entity.Property(e => e.TimeApplication).HasColumnType("datetime");
            });

            modelBuilder.Entity<CarPassBill>(entity =>
            {
                entity.HasKey(e => e.Idbill);

                entity.ToTable("CarPassBill");

                entity.Property(e => e.Idbill)
                    .ValueGeneratedNever()
                    .HasColumnName("IDBill");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileBill)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(50);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<CarPassProc>(entity =>
            {
                entity.HasKey(e => e.ProcId);

                entity.ToTable("CarPassProc");

                entity.Property(e => e.ProcId).HasColumnName("ProcID");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.ParaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CarPassStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("CarPassStatus");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Memo).HasMaxLength(50);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CarToStop>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CarToStop");

                entity.Property(e => e.CarBrand)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CarCardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CarType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarToStop01>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CarToStop01");

                entity.Property(e => e.CarBrand)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CarCardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CarType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarTypePass>(entity =>
            {
                entity.HasKey(e => e.CarType);

                entity.ToTable("CarTypePass");

                entity.Property(e => e.TypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<CarVip>(entity =>
            {
                entity.ToTable("CarVip");

                entity.Property(e => e.CarVipId).HasColumnName("CarVipID");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DepartMent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Meno)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TelePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarVipProc>(entity =>
            {
                entity.HasKey(e => e.ProcId);

                entity.ToTable("CarVipProc");

                entity.Property(e => e.ProcId).HasColumnName("ProcID");

                entity.Property(e => e.Act)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Meno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CarVipStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("CarVipStatus");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Meno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Worktime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.HasKey(e => e.CardId)
                    .HasName("PK_CARD");

                entity.ToTable("Card");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CardGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CardGUID")
                    .HasComment("證件補辦使用，相同的CardGuID表示同一個證件的卡");

                entity.Property(e => e.CardModelId).HasColumnName("CardModelID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MadeTime).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CardAdded>(entity =>
            {
                entity.ToTable("CardAdded");

                entity.Property(e => e.CardAddedId).HasColumnName("CardAddedID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CardAddedStatus).HasComment("1 待收取資料，2待審核，3產生新卡");

                entity.Property(e => e.CardAddedType).HasComment("1 卡損壞補辦，2卡遺失補辦");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Ext)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAC");

                entity.Property(e => e.Reasons)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CardBorrow>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardBorrow");

                entity.Property(e => e.CardBorrowId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CardBorrowID");

                entity.Property(e => e.CardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CardID");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CardChangeHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardChangeHistory");

                entity.Property(e => e.CardChangeId).HasColumnName("CardChangeID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TimeChange).HasColumnType("datetime");
            });

            modelBuilder.Entity<CardCompanyHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardCompanyHistory");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyIdnew).HasColumnName("CompanyIDnew");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateId).HasColumnName("CreateID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CardCreateTable>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TableName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CardHistoryDatum>(entity =>
            {
                entity.HasKey(e => e.CardHistoryDataId)
                    .HasName("PK_SwipingCadrData");

                entity.Property(e => e.CardHistoryDataId).HasColumnName("CardHistoryDataID");

                entity.Property(e => e.CardStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EcardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ECardNo");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Mac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAC");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TransferTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CardModel>(entity =>
            {
                entity.ToTable("CardModel");

                entity.Property(e => e.CardModelId).HasColumnName("CardModelID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModelImg)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModelName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<CardSwipe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CardSwipe");

                entity.Property(e => e.AreaId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AreaID");

                entity.Property(e => e.DateSwipe).HasColumnType("date");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Images)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longtitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.TimeSwipe).HasColumnType("datetime");
            });

            modelBuilder.Entity<CardTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Card_Test");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CardGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CardGUID");

                entity.Property(e => e.CardId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CardID");

                entity.Property(e => e.CardModelId).HasColumnName("CardModelID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MadeTime).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CardText>(entity =>
            {
                entity.ToTable("CardText");

                entity.Property(e => e.CardTextId).HasColumnName("CardTextID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.TextName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CardVendor>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.ToTable("CardVendor");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CardArea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateChange).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FileBill)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<CertificateDb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CertificateDB");

                entity.Property(e => e.Area)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bgid).HasColumnName("BGid");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dvsn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DVSN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RaKtx).HasColumnName("RaKTX");

                entity.Property(e => e.TheodoiKtx).HasColumnName("TheodoiKTX");
            });

            modelBuilder.Entity<CertificateDelay>(entity =>
            {
                entity.HasKey(e => e.DelayApplyId);

                entity.ToTable("Certificate_Delay");

                entity.Property(e => e.DelayApplyId).HasColumnName("DelayApplyID");

                entity.Property(e => e.Certificate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Certificate_Type");

                entity.Property(e => e.DelayDate).HasColumnType("datetime");

                entity.Property(e => e.NewExpirationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("New_ExpirationDate");

                entity.Property(e => e.OldExpirationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Old_ExpirationDate");

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CertificatesDelay>(entity =>
            {
                entity.ToTable("CertificatesDelay");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplyPeople)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeDate).HasColumnType("datetime");

                entity.Property(e => e.OnworkFile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<ChargeRecord>(entity =>
            {
                entity.HasKey(e => e.ChargeId)
                    .HasName("PK_CHARGERECORDS");

                entity.Property(e => e.ChargeId).HasColumnName("ChargeID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.Bill)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BillNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("billNumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CardId)
                    .HasColumnName("CardID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DamageCard)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Meno)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Receipts)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SenderPeople)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SenderTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SenderUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CheckTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CheckTemp");

                entity.Property(e => e.Comfromtime)
                    .HasColumnType("datetime")
                    .HasColumnName("comfromtime");

                entity.Property(e => e.Controlname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("controlname");

                entity.Property(e => e.Credentialsnumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("credentialsnumber");

                entity.Property(e => e.Reason)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("reason");
            });

            modelBuilder.Entity<CheckTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CheckTime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MerId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MerID");

                entity.Property(e => e.TimeIn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOut).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChemistryAuthorityChangeEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChemistryAuthority_ChangeEmail");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.Email1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeesId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeesID");

                entity.Property(e => e.EmployeesId2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeesName2).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChemistryAuthorityHistory>(entity =>
            {
                entity.ToTable("Chemistry_Authority_History");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.AuthorityId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeparmentSnid).HasColumnName("DeparmentSNID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeesId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmployeesID");

                entity.Property(e => e.EmployeesNameT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeesNameV).HasMaxLength(50);
            });

            modelBuilder.Entity<ChemistryDocforMaterial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Chemistry_DocforMaterial");

                entity.Property(e => e.ChemistryFormId).HasColumnName("ChemistryFormID");

                entity.Property(e => e.GpVanchuyen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gpkinhdoanh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GPKinhdoanh");

                entity.Property(e => e.GpsxKinhdoanh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MaterialId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaterialID");

                entity.Property(e => e.Msds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSDS");

                entity.Property(e => e.TlThue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TucachngVanchuyen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.XacnhanttHoachat)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChemistryForm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChemistryForm");

                entity.Property(e => e.Applicant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.DateOfApplication).HasColumnType("datetime");

                entity.Property(e => e.DateOfExpectedEnd).HasColumnType("datetime");

                entity.Property(e => e.DateOfExpectedStart).HasColumnType("datetime");

                entity.Property(e => e.DepartmentBuy).HasMaxLength(50);

                entity.Property(e => e.DepartmentRequitision)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentSn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DepartmentSN");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmployeeBuy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryGate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LocationAndTech)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinistrySn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MinistrySN");

                entity.Property(e => e.PhoneofEmpBuy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StoreLocation)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChemistryForm1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChemistryForm", "faceid");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DateOfApplication).HasColumnType("date");

                entity.Property(e => e.DateOfExpectedEnd).HasColumnType("date");

                entity.Property(e => e.DateOfExpectedStart).HasColumnType("date");

                entity.Property(e => e.DepartmentBuy).HasMaxLength(50);

                entity.Property(e => e.DepartmentRequitision)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentSn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DepartmentSN");

                entity.Property(e => e.EmployeeBuy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LocationAndTech)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinistrySn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MinistrySN");

                entity.Property(e => e.StoreLocation)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChemistryFormAuthority>(entity =>
            {
                entity.ToTable("ChemistryForm_Authority");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AuthorityId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeparmentSnid).HasColumnName("DeparmentSNID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeesId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmployeesID");

                entity.Property(e => e.EmployeesNameT).HasMaxLength(50);

                entity.Property(e => e.EmployeesNameV).HasMaxLength(50);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.PositionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChrCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Chr_Code");

                entity.Property(e => e.CodeDesc)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("code_desc");

                entity.Property(e => e.CodeGroup)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("code_group");

                entity.Property(e => e.CodeId)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("code_id");

                entity.Property(e => e.CodeStatus)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("code_status");

                entity.Property(e => e.CodeType)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("code_type");

                entity.Property(e => e.Lasteditby)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("lasteditby");

                entity.Property(e => e.Lasteditdt)
                    .HasColumnType("datetime")
                    .HasColumnName("lasteditdt");
            });

            modelBuilder.Entity<ChrEmpCardinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Chr_EmpCardinfo");

                entity.Property(e => e.Cardid)
                    .HasMaxLength(50)
                    .HasColumnName("cardid");

                entity.Property(e => e.Empmemo)
                    .HasMaxLength(50)
                    .HasColumnName("empmemo");

                entity.Property(e => e.Empno)
                    .HasMaxLength(15)
                    .HasColumnName("empno");

                entity.Property(e => e.Softno)
                    .HasMaxLength(50)
                    .HasColumnName("softno");
            });

            modelBuilder.Entity<ChrEmpCardinfoTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Chr_EmpCardinfo_temp");

                entity.Property(e => e.Cardid)
                    .HasMaxLength(50)
                    .HasColumnName("cardid");

                entity.Property(e => e.Empmemo)
                    .HasMaxLength(50)
                    .HasColumnName("empmemo");

                entity.Property(e => e.Empno)
                    .HasMaxLength(15)
                    .HasColumnName("empno");

                entity.Property(e => e.Softno)
                    .HasMaxLength(50)
                    .HasColumnName("softno");
            });

            modelBuilder.Entity<ChrEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Chr_Employee");

                entity.HasIndex(e => e.EmpNo, "IX_Chr_employee_No");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BgCode)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("bg_code");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.ClassNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("class_no");

                entity.Property(e => e.Cos)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("cos");

                entity.Property(e => e.DepartNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("depart_no");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("emp_no");

                entity.Property(e => e.EmpType)
                    .HasMaxLength(10)
                    .HasColumnName("emp_type");

                entity.Property(e => e.FactoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("factory_code");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InDate)
                    .HasColumnType("datetime")
                    .HasColumnName("in_date");

                entity.Property(e => e.InitSiteid)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("init_siteid");

                entity.Property(e => e.JobCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("job_code");

                entity.Property(e => e.JobSituation)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("job_situation");

                entity.Property(e => e.KeyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("key_date");

                entity.Property(e => e.Lasteditdt)
                    .HasColumnType("datetime")
                    .HasColumnName("lasteditdt");

                entity.Property(e => e.LevDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lev_date");

                entity.Property(e => e.Married)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("married");

                entity.Property(e => e.Oldhome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("oldhome");

                entity.Property(e => e.Photo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sex");

                entity.Property(e => e.Siteid)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("siteid");

                entity.Property(e => e.StatusNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("status_no");

                entity.Property(e => e.TransferDate)
                    .HasColumnType("datetime")
                    .HasColumnName("transfer_date");

                entity.Property(e => e.Urgtel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("urgtel");
            });

            modelBuilder.Entity<ChrEmployee0228>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Chr_Employee0228");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BgCode)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("bg_code");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.ClassNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("class_no");

                entity.Property(e => e.Cos)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("cos");

                entity.Property(e => e.DepartNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("depart_no");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("emp_no");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InDate)
                    .HasColumnType("datetime")
                    .HasColumnName("in_date");

                entity.Property(e => e.InitSiteid)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("init_siteid");

                entity.Property(e => e.JobSituation)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("job_situation");

                entity.Property(e => e.KeyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("key_date");

                entity.Property(e => e.Lasteditdt)
                    .HasColumnType("datetime")
                    .HasColumnName("lasteditdt");

                entity.Property(e => e.LevDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lev_date");

                entity.Property(e => e.Married)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("married");

                entity.Property(e => e.Oldhome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("oldhome");

                entity.Property(e => e.Photo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sex");

                entity.Property(e => e.Siteid)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("siteid");

                entity.Property(e => e.StatusNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("status_no");

                entity.Property(e => e.TransferDate)
                    .HasColumnType("datetime")
                    .HasColumnName("transfer_date");

                entity.Property(e => e.Urgtel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("urgtel");
            });

            modelBuilder.Entity<ChrEmployeeImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Chr_Employee_Image");

                entity.Property(e => e.BgCode).HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EmpIdentity).HasMaxLength(20);

                entity.Property(e => e.EmployeeName).HasMaxLength(30);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.ImgUpTime).HasColumnType("datetime");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.Md5val)
                    .HasMaxLength(2000)
                    .HasColumnName("MD5Val");

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(2000);
            });

            modelBuilder.Entity<ChrEmployeeSwitch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("chr_employee_switch");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BgCode)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("bg_code");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.ClassNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("class_no");

                entity.Property(e => e.Cos)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("cos");

                entity.Property(e => e.DepartNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("depart_no");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("emp_no");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InDate)
                    .HasColumnType("datetime")
                    .HasColumnName("in_date");

                entity.Property(e => e.InitSiteid)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("init_siteid");

                entity.Property(e => e.JobSituation)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("job_situation");

                entity.Property(e => e.KeyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("key_date");

                entity.Property(e => e.Lasteditdt)
                    .HasColumnType("datetime")
                    .HasColumnName("lasteditdt");

                entity.Property(e => e.LevDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lev_date");

                entity.Property(e => e.Married)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("married");

                entity.Property(e => e.Oldhome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("oldhome");

                entity.Property(e => e.Photo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sex");

                entity.Property(e => e.Siteid)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("siteid");

                entity.Property(e => e.StatusNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("status_no");

                entity.Property(e => e.TransferDate)
                    .HasColumnType("datetime")
                    .HasColumnName("transfer_date");

                entity.Property(e => e.Urgtel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("urgtel");
            });

            modelBuilder.Entity<ChrEmployeeTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("chr_employee_tmp");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BgCode)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("bg_code");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.ClassNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("class_no");

                entity.Property(e => e.Cos)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("cos");

                entity.Property(e => e.DepartNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("depart_no");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("emp_no");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InDate)
                    .HasColumnType("datetime")
                    .HasColumnName("in_date");

                entity.Property(e => e.InitSiteid)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("init_siteid");

                entity.Property(e => e.JobSituation)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("job_situation");

                entity.Property(e => e.KeyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("key_date");

                entity.Property(e => e.Lasteditdt)
                    .HasColumnType("datetime")
                    .HasColumnName("lasteditdt");

                entity.Property(e => e.LevDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lev_date");

                entity.Property(e => e.Married)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("married");

                entity.Property(e => e.Oldhome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("oldhome");

                entity.Property(e => e.Photo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sex");

                entity.Property(e => e.Siteid)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("siteid");

                entity.Property(e => e.StatusNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("status_no");

                entity.Property(e => e.TransferDate)
                    .HasColumnType("datetime")
                    .HasColumnName("transfer_date");

                entity.Property(e => e.Urgtel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("urgtel");
            });

            modelBuilder.Entity<ChrEmployeeTransit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Chr_employee_Transit");

                entity.HasIndex(e => e.EmpNo, "IX_Chr_employee_Transit_NO");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BgCode)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("bg_code");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.ClassNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("class_no");

                entity.Property(e => e.Cos)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("cos");

                entity.Property(e => e.DepartNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("depart_no");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("emp_no");

                entity.Property(e => e.EmpType)
                    .HasMaxLength(10)
                    .HasColumnName("emp_type");

                entity.Property(e => e.FactoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("factory_code");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InDate)
                    .HasColumnType("datetime")
                    .HasColumnName("in_date");

                entity.Property(e => e.InitSiteid)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("init_siteid");

                entity.Property(e => e.JobCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("job_code");

                entity.Property(e => e.JobSituation)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("job_situation");

                entity.Property(e => e.KeyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("key_date");

                entity.Property(e => e.Lasteditdt)
                    .HasColumnType("datetime")
                    .HasColumnName("lasteditdt");

                entity.Property(e => e.LevDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lev_date");

                entity.Property(e => e.Married)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("married");

                entity.Property(e => e.Oldhome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("oldhome");

                entity.Property(e => e.Photo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sex");

                entity.Property(e => e.Siteid)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("siteid");

                entity.Property(e => e.StatusNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("status_no");

                entity.Property(e => e.TransferDate)
                    .HasColumnType("datetime")
                    .HasColumnName("transfer_date");

                entity.Property(e => e.Urgtel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("urgtel");
            });

            modelBuilder.Entity<ChrEmployeeUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Chr_EmployeeUpdate");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BgCode)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("bg_code");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.ClassNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("class_no");

                entity.Property(e => e.Cos)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("cos");

                entity.Property(e => e.DepartNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("depart_no");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("emp_no");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InDate)
                    .HasColumnType("datetime")
                    .HasColumnName("in_date");

                entity.Property(e => e.InitSiteid)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("init_siteid");

                entity.Property(e => e.JobSituation)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("job_situation");

                entity.Property(e => e.KeyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("key_date");

                entity.Property(e => e.Lasteditdt)
                    .HasColumnType("datetime")
                    .HasColumnName("lasteditdt");

                entity.Property(e => e.LevDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lev_date");

                entity.Property(e => e.Married)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("married");

                entity.Property(e => e.Oldhome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("oldhome");

                entity.Property(e => e.Photo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sex");

                entity.Property(e => e.Siteid)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("siteid");

                entity.Property(e => e.StatusNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("status_no");

                entity.Property(e => e.TransferDate)
                    .HasColumnType("datetime")
                    .HasColumnName("transfer_date");

                entity.Property(e => e.Urgtel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("urgtel");
            });

            modelBuilder.Entity<ChrEmployeeVv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("chr_employee_vv");

                entity.Property(e => e.Address)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BgCode)
                    .HasMaxLength(164)
                    .IsUnicode(false)
                    .HasColumnName("bg_code");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.ClassNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("class_no");

                entity.Property(e => e.Cos)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("cos");

                entity.Property(e => e.DepartNo)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("depart_no");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_no");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.InDate)
                    .HasColumnType("datetime")
                    .HasColumnName("in_date");

                entity.Property(e => e.InitSiteId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Init_SiteID");

                entity.Property(e => e.JobSituation)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("job_situation");

                entity.Property(e => e.KeyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("key_date");

                entity.Property(e => e.Lasteditdt)
                    .HasColumnType("datetime")
                    .HasColumnName("lasteditdt");

                entity.Property(e => e.LevDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lev_date");

                entity.Property(e => e.Married)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("married");

                entity.Property(e => e.Oldhome)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("oldhome");

                entity.Property(e => e.Photo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Sex)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sex");

                entity.Property(e => e.SiteId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("siteID");

                entity.Property(e => e.StatusNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("status_no");

                entity.Property(e => e.TransferDate)
                    .HasColumnType("datetime")
                    .HasColumnName("transfer_date");

                entity.Property(e => e.Urgtel)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("urgtel");
            });

            modelBuilder.Entity<ChrEmployeeVvc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("chr_employee_vvc");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BgCode)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("bg_code");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.ClassNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("class_no");

                entity.Property(e => e.Cos)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("cos");

                entity.Property(e => e.DepartNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("depart_no");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("emp_no");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InDate)
                    .HasColumnType("datetime")
                    .HasColumnName("in_date");

                entity.Property(e => e.InitSiteid)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("init_siteid");

                entity.Property(e => e.JobSituation)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("job_situation");

                entity.Property(e => e.KeyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("key_date");

                entity.Property(e => e.Lasteditdt)
                    .HasColumnType("datetime")
                    .HasColumnName("lasteditdt");

                entity.Property(e => e.LevDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lev_date");

                entity.Property(e => e.Married)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("married");

                entity.Property(e => e.Oldhome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("oldhome");

                entity.Property(e => e.Photo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sex");

                entity.Property(e => e.Siteid)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("siteid");

                entity.Property(e => e.StatusNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("status_no");

                entity.Property(e => e.TransferDate)
                    .HasColumnType("datetime")
                    .HasColumnName("transfer_date");

                entity.Property(e => e.Urgtel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("urgtel");
            });

            modelBuilder.Entity<ChrInFactoryImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Chr_InFactory_Image");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InFactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("InFactoryID");

                entity.Property(e => e.InFactoryName).HasMaxLength(30);

                entity.Property(e => e.InFactoryNo).HasMaxLength(20);

                entity.Property(e => e.Md5val)
                    .HasMaxLength(2000)
                    .HasColumnName("MD5Val");

                entity.Property(e => e.Url).HasMaxLength(2000);
            });

            modelBuilder.Entity<CivetIntentList>(entity =>
            {
                entity.ToTable("CivetIntentList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bu)
                    .HasMaxLength(50)
                    .HasColumnName("BU");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.NameSend).HasMaxLength(50);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Posision).HasMaxLength(50);
            });

            modelBuilder.Entity<CivetIntentListMail>(entity =>
            {
                entity.ToTable("CivetIntentListMail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(200);

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bu)
                    .HasMaxLength(50)
                    .HasColumnName("BU");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.NameSend).HasMaxLength(50);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Posision).HasMaxLength(50);
            });

            modelBuilder.Entity<CivetListMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CivetListMail");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ListMail)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CivetSendMess>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CivetSendMess");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.FormType).HasMaxLength(400);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Idapp).HasColumnName("IDApp");

                entity.Property(e => e.Subject).HasMaxLength(800);

                entity.Property(e => e.TimeAdd).HasColumnType("datetime");

                entity.Property(e => e.TimeSend).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cmc812log>(entity =>
            {
                entity.ToTable("CMC812log");

                entity.Property(e => e.Cmc812logId).HasColumnName("CMC812logID");

                entity.Property(e => e.Cmc812logCreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CMC812logCreateTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cmc812logMsg).HasColumnName("CMC812logMsg");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("IP");

                entity.Property(e => e.Mac)
                    .HasMaxLength(50)
                    .HasColumnName("MAC");
            });

            modelBuilder.Entity<Code>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("code");

                entity.Property(e => e.CodeDesc)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("code_desc");

                entity.Property(e => e.CodeGroup)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("code_group");

                entity.Property(e => e.CodeId)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("code_id");

                entity.Property(e => e.CodeStatus)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("code_status");

                entity.Property(e => e.CodeType)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("code_type");

                entity.Property(e => e.Lasteditby)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("lasteditby");

                entity.Property(e => e.Lasteditdt)
                    .HasColumnType("datetime")
                    .HasColumnName("lasteditdt");
            });

            modelBuilder.Entity<ColorTypeCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ColorTypeCard");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Idcard).HasColumnName("IDCard");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Acknowledgment)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyAddress).HasMaxLength(200);

                entity.Property(e => e.CompanyCheckingFile)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ControlMsg).HasMaxLength(100);

                entity.Property(e => e.ControlTag).HasDefaultValueSql("((0))");

                entity.Property(e => e.CooperationProjects).HasMaxLength(1000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.File)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.NameAbbreviation).HasMaxLength(60);

                entity.Property(e => e.Reason)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Responsible)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanyControlHistory>(entity =>
            {
                entity.ToTable("CompanyControlHistory");

                entity.Property(e => e.CompanyControlHistoryId).HasColumnName("CompanyControlHistoryID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ControlMsg).HasMaxLength(100);

                entity.Property(e => e.OperatTime).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyControlHistories)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_COMPANYC_REFERENCE_COMPANY");
            });

            modelBuilder.Entity<Construction>(entity =>
            {
                entity.ToTable("Construction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuditVendor).HasMaxLength(50);

                entity.Property(e => e.Can).HasMaxLength(50);

                entity.Property(e => e.Chemistry).HasMaxLength(100);

                entity.Property(e => e.Condition).HasMaxLength(50);

                entity.Property(e => e.DeffType).HasMaxLength(50);

                entity.Property(e => e.Ehsin).HasColumnName("EHSIN");

                entity.Property(e => e.Ehsout).HasColumnName("EHSOUT");

                entity.Property(e => e.EmpNameApp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNoApp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExtTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileBvmt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FileBVMT");

                entity.Property(e => e.FileUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileVendor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageAtld)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImageATLD");

                entity.Property(e => e.ImageAudit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberAudit).HasMaxLength(50);

                entity.Property(e => e.Moc).HasMaxLength(100);

                entity.Property(e => e.NameContrus).HasMaxLength(200);

                entity.Property(e => e.NoAtld)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NoATLD");

                entity.Property(e => e.NotesApp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Office).HasMaxLength(100);

                entity.Property(e => e.PeoPleList)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Special).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TimeApplication).HasColumnType("datetime");

                entity.Property(e => e.UnitApplication).HasMaxLength(100);

                entity.Property(e => e.VendorName).HasMaxLength(100);
            });

            modelBuilder.Entity<ContolstatusInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("contolstatus_information");

                entity.Property(e => e.Contolstatus).HasColumnName("contolstatus");

                entity.Property(e => e.Information)
                    .HasMaxLength(255)
                    .HasColumnName("information");
            });

            modelBuilder.Entity<ControlCar>(entity =>
            {
                entity.ToTable("ControlCar");

                entity.Property(e => e.ControlCarId).HasColumnName("ControlCarID");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ControlCarN>(entity =>
            {
                entity.HasKey(e => e.ControlCarId);

                entity.ToTable("ControlCarN");

                entity.Property(e => e.ControlCarId).HasColumnName("ControlCarID");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ControlPeopleBackup>(entity =>
            {
                entity.HasKey(e => e.ControlPeopleId)
                    .HasName("PK__ControlP__6F1719A0E93D13E2");

                entity.ToTable("ControlPeopleBackup");

                entity.Property(e => e.ControlPeopleId).HasColumnName("ControlPeopleID");

                entity.Property(e => e.ComfromTime).HasColumnType("datetime");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SourceTag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Source_tag");
            });

            modelBuilder.Entity<ControlPeopleN>(entity =>
            {
                entity.ToTable("ControlPeopleN");

                entity.Property(e => e.ControlPeopleNid).HasColumnName("ControlPeopleNID");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ControlPerson>(entity =>
            {
                entity.HasKey(e => e.ControlPeopleId)
                    .HasName("PK_CONTROLPEOPLE");

                entity.HasIndex(e => e.ControlPeopleId, "NIDX_CONTROLPEOPLEID01");

                entity.HasIndex(e => e.CredentialsNumber, "NIDX_CREDENTIALSNUMBER01");

                entity.Property(e => e.ControlPeopleId).HasColumnName("ControlPeopleID");

                entity.Property(e => e.ComfromTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SourceTag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Source_tag")
                    .HasDefaultValueSql("('CertificateDB')");
            });

            modelBuilder.Entity<ControlRecord>(entity =>
            {
                entity.HasKey(e => e.ControlRecordId);

                entity.ToTable("ControlRecord");

                entity.Property(e => e.ControlRecordId).HasColumnName("ControlRecordID");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlMsg).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContrucProc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContrucProc");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Memo).HasMaxLength(400);

                entity.Property(e => e.ProcId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProcID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.WorkTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ContrucStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContrucStatus");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(400);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Para)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("StatusID");

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CostSign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CostSign");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CredentialContinu>(entity =>
            {
                entity.ToTable("CredentialContinu");

                entity.Property(e => e.CredentialContinuId).HasColumnName("CredentialContinuID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.Annex)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.Property(e => e.CredentialId).HasColumnName("CredentialID");
            });

            modelBuilder.Entity<CredentialDelayNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Credential_DelayNew");

                entity.Property(e => e.Applicant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactDeparmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContactDeparmentID");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContactPersonID");

                entity.Property(e => e.DocforCredentialDelay)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndTimeNew).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<CredentialDelayNewSigStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CredentialDelayNew_SigStatus");

                entity.Property(e => e.CredentialDelayNewId).HasColumnName("CredentialDelayNewID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Meno).HasMaxLength(500);

                entity.Property(e => e.Paracode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignedStDate).HasColumnType("datetime");

                entity.Property(e => e.SignerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SignerID");

                entity.Property(e => e.SignerName).HasMaxLength(50);
            });

            modelBuilder.Entity<CredentialDelaynewListCardNum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CredentialDelaynew_ListCardNum");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.AreaCard)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialdelayNewId).HasColumnName("CredentialdelayNewID");

                entity.Property(e => e.EndTimeNew).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CredentialDelaynewListCardNumNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CredentialDelaynew_ListCardNum_New");

                entity.Property(e => e.AdminCreateCardTime).HasColumnType("datetime");

                entity.Property(e => e.AdminSignTime).HasColumnType("datetime");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.AreaCard)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AreaCardNew)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyNewName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyOldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialdelayNewId).HasColumnName("CredentialdelayNewID");

                entity.Property(e => e.EndTimeNew).HasColumnType("datetime");

                entity.Property(e => e.FileAttack)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ImageFile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NotesForSign).HasMaxLength(100);

                entity.Property(e => e.ReceivedName).HasMaxLength(100);

                entity.Property(e => e.ReceivedTime).HasColumnType("datetime");

                entity.Property(e => e.Signer)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustCardRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustCardRecord");

                entity.Property(e => e.Applyname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("applyname");

                entity.Property(e => e.Areaname)
                    .HasMaxLength(50)
                    .HasColumnName("areaname");

                entity.Property(e => e.Cardno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cardno");

                entity.Property(e => e.Cardstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cardstatus");

                entity.Property(e => e.Datatime)
                    .HasColumnType("datetime")
                    .HasColumnName("datatime");

                entity.Property(e => e.Ecardno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ecardno");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fullname");

                entity.Property(e => e.Machinename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("machinename");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("reason");

                entity.Property(e => e.Type)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<CustList>(entity =>
            {
                entity.ToTable("CustList");

                entity.Property(e => e.CustListId).HasColumnName("CustListID");

                entity.Property(e => e.DiscussMatters)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Position)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.ReceiverNo)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.ReceiverTime).HasColumnType("datetime");

                entity.Property(e => e.Relationship)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RemandTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

                entity.Property(e => e.ReturnReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTime).HasColumnType("datetime");

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");

                entity.Property(e => e.VisitImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VisitTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustNotList>(entity =>
            {
                entity.ToTable("CustNotList");

                entity.Property(e => e.CustNotListId).HasColumnName("CustNotListID");

                entity.Property(e => e.DiscussItem)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Position)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.ReceiverNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverTime).HasColumnType("datetime");

                entity.Property(e => e.RemandTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

                entity.Property(e => e.ReturnReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTime).HasColumnType("datetime");

                entity.Property(e => e.Specialty)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VisitImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitNotCustId).HasColumnName("VisitNotCustID");

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustTravel>(entity =>
            {
                entity.ToTable("CustTravel");

                entity.Property(e => e.CustTravelId).HasColumnName("CustTravelID");

                entity.Property(e => e.ArrivalTime).HasColumnType("datetime");

                entity.Property(e => e.Flight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoBackFlight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveTime).HasColumnType("datetime");

                entity.Property(e => e.StartPlace)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");
            });

            modelBuilder.Entity<CustTravelDetail>(entity =>
            {
                entity.ToTable("CustTravelDetail");

                entity.Property(e => e.CustTravelDetailId).HasColumnName("CustTravelDetailID");

                entity.Property(e => e.CustTravelId).HasColumnName("CustTravelID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TravelAim)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CustTravel)
                    .WithMany(p => p.CustTravelDetails)
                    .HasForeignKey(d => d.CustTravelId)
                    .HasConstraintName("FK_CUSTTRAV_REFERENCE_CUSTTRAV");
            });

            modelBuilder.Entity<CustWorCredentsLastInserted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustWorCredentsLastInserted", "faceid");

                entity.Property(e => e.CustWorCredentsLastInsertId).HasColumnName("CustWorCredentsLastInsertID");

                entity.Property(e => e.IdlastInsert).HasColumnName("IDLastInsert");
            });

            modelBuilder.Entity<CustWorkCredential>(entity =>
            {
                entity.HasKey(e => e.CustWorkCredentialsId)
                    .HasName("PK_CUSTWORKCREDENTIALS");

                entity.Property(e => e.CustWorkCredentialsId).HasColumnName("CustWorkCredentialsID");

                entity.Property(e => e.AreaCard)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CensusAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitExtension)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactUnitPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactUnitPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.File)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameCn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NameCN");

                entity.Property(e => e.NowAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCaption)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustWorkCredentialsDelay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustWorkCredentialsDelay");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPersonEmployee)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitExtension)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitPersonBg)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ContactUnitPersonBG");

                entity.Property(e => e.ContactUnitPersonName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitPersonphone)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CustWorkCredentialId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CustWorkCredentialID");

                entity.Property(e => e.DelDate).HasColumnType("datetime");

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Emergencyphone)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IndureEndate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nation)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nation");

                entity.Property(e => e.NewAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OnWorkFile)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.VeNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCaption)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Zid).HasColumnName("ZID");
            });

            modelBuilder.Entity<CustWorkHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustWorkHistory");

                entity.Property(e => e.AreaCard)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CensusAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitExtension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustWorkCredentialsId).HasColumnName("CustWorkCredentialsID");

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.File)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameCn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NameCN");

                entity.Property(e => e.NowAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCaption)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustWorkInFactory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustWorkInFactory");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.CreateBuname)
                    .HasMaxLength(50)
                    .HasColumnName("CreateBUName");

                entity.Property(e => e.CreateEmpName).HasMaxLength(100);

                entity.Property(e => e.CreateEmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndValidTimeFirst).HasColumnType("date");

                entity.Property(e => e.ExcTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileExcel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(100);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustWorkInFactoryAdminProc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustWorkInFactoryAdmin_Proc");

                entity.Property(e => e.CustInfacPersonId).HasColumnName("CustInfacPersonID");

                entity.Property(e => e.EmpName).HasMaxLength(100);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.ProcAdminId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProcAdminID");

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustWorkInFactoryPerSon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustWorkInFactory_PerSon");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.AreaCard)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDay).HasColumnType("datetime");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.ComanyId).HasColumnName("ComanyID");

                entity.Property(e => e.CustWorkInFactoryId).HasColumnName("CustWorkInFactoryID");

                entity.Property(e => e.EndValidDate).HasColumnType("datetime");

                entity.Property(e => e.FileAttach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ImagePeople)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(100);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NameAbeviation).HasMaxLength(60);

                entity.Property(e => e.NameCn)
                    .HasMaxLength(50)
                    .HasColumnName("NameCN");

                entity.Property(e => e.NameVn)
                    .HasMaxLength(50)
                    .HasColumnName("NameVN");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PeoPleId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PeoPleID");

                entity.Property(e => e.Receipt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartValidDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.WorkTypeId).HasColumnName("WorkTypeID");
            });

            modelBuilder.Entity<CustWorkInFactoryProc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustWorkInFactoryProc");

                entity.Property(e => e.EmpName).HasMaxLength(100);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.ParaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProcID");

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustWorkInFactoryStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustWorkInFactoryStatus");

                entity.Property(e => e.EmpName).HasMaxLength(100);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(50);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.StatusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("StatusID");

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustWorkValid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustWorkValid");

                entity.Property(e => e.AreaCard)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CardId)
                    .HasColumnName("CardID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CensusAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitExtension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustWorkCredentialsId).HasColumnName("CustWorkCredentialsID");

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.File)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameCn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NameCN");

                entity.Property(e => e.NowAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCaption)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustWorkValidNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustWorkValidNew", "faceid");

                entity.Property(e => e.AreaCard)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CensusAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitExtension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustWorkCredentialsId).HasColumnName("CustWorkCredentialsID");

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.File)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NowAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCaption)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DboChrEmployee2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dbo.Chr_employee2");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BgCode)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("bg_code");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.ClassNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("class_no")
                    .IsFixedLength();

                entity.Property(e => e.Cos)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cos")
                    .IsFixedLength();

                entity.Property(e => e.EmpId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_id")
                    .IsFixedLength();

                entity.Property(e => e.EmpName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_no");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.InDate)
                    .HasColumnType("datetime")
                    .HasColumnName("in_date");

                entity.Property(e => e.InitSiteId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Init_SiteID")
                    .IsFixedLength();

                entity.Property(e => e.JobSituation)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("job_situation")
                    .IsFixedLength();

                entity.Property(e => e.KeyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("key_date");

                entity.Property(e => e.Lasteditdt)
                    .HasColumnType("datetime")
                    .HasColumnName("lasteditdt");

                entity.Property(e => e.LevDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lev_date");

                entity.Property(e => e.Married)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("married")
                    .IsFixedLength();

                entity.Property(e => e.Oldhome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("oldhome");

                entity.Property(e => e.Photo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Sex)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sex")
                    .IsFixedLength();

                entity.Property(e => e.SiteId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("siteID")
                    .IsFixedLength();

                entity.Property(e => e.StatusNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("status_no")
                    .IsFixedLength();

                entity.Property(e => e.TransferDate)
                    .HasColumnType("datetime")
                    .HasColumnName("transfer_date");

                entity.Property(e => e.Urgtel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("urgtel");
            });

            modelBuilder.Entity<DealType>(entity =>
            {
                entity.ToTable("DealType");

                entity.Property(e => e.DealTypeId).HasColumnName("DealTypeID");

                entity.Property(e => e.DealType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DealType");

                entity.Property(e => e.Meno)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DefaultCardInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DefaultCardInfo");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Information)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DepartmentAuditPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DepartmentAuditPerson");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.DepartmentAuditId).HasColumnName("DepartmentAuditID");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DietAttention>(entity =>
            {
                entity.ToTable("DietAttention");

                entity.Property(e => e.DietAttentionId).HasColumnName("DietAttentionID");

                entity.Property(e => e.Eat)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Other)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Preferences)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");
            });

            modelBuilder.Entity<DiffTimeLess>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DiffTimeLess");

                entity.Property(e => e.Extention)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveCards)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiffTimeMore>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DiffTimeMore");

                entity.Property(e => e.Extention)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveCards)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimissionUserBeforeLoding>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DimissionUserBeforeLoding");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserBeforeLodingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UserBeforeLodingID");
            });

            modelBuilder.Entity<DispatchRecord>(entity =>
            {
                entity.HasKey(e => e.DispatchRecordsId)
                    .HasName("PK_DISPATCHRECORDS");

                entity.Property(e => e.DispatchRecordsId).HasColumnName("DispatchRecordsID");

                entity.Property(e => e.BackTime).HasColumnType("datetime");

                entity.Property(e => e.Destination)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dispatcher)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.Meno)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.SpareCarId).HasColumnName("SpareCarID");

                entity.Property(e => e.UsePeople)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.SpareCar)
                    .WithMany(p => p.DispatchRecords)
                    .HasForeignKey(d => d.SpareCarId)
                    .HasConstraintName("FK_DISPATCH_REFERENCE_SPARECAR");
            });

            modelBuilder.Entity<DoorPowerManage>(entity =>
            {
                entity.ToTable("DoorPowerManage");

                entity.Property(e => e.DoorPowerManageId).HasColumnName("DoorPowerManageID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bu)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EnglishPicture)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.File)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsFind)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MailSendDate).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldApplicationId).HasColumnName("Old_Application_ID");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RePwdTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WhetherJob)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DoorPowerManageApplication>(entity =>
            {
                entity.HasKey(e => e.DoorPowerManageId)
                    .HasName("PK_DOORPOWERMANAGEAPPLICATION");

                entity.ToTable("DoorPowerManageApplication");

                entity.Property(e => e.DoorPowerManageId).HasColumnName("DoorPowerManageID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BackMeno)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bu)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.EnglishPicture)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.File)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsFind)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.DoorPowerManageApplications)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_DOORPOWE_REFERENCE_APPLICAT");
            });

            modelBuilder.Entity<DoorPowerManageArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DoorPowerManageArea");

                entity.Property(e => e.AreaRegionId).HasColumnName("AreaRegionID");

                entity.Property(e => e.DoorPowerManageId).HasColumnName("DoorPowerManageID");

                entity.HasOne(d => d.DoorPowerManage)
                    .WithMany()
                    .HasForeignKey(d => d.DoorPowerManageId)
                    .HasConstraintName("FK_DOORPOWE_TT_DOORPOWE");
            });

            modelBuilder.Entity<DoorPowerManageAreaApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DoorPowerManageAreaApplication");

                entity.Property(e => e.AreaRegionId).HasColumnName("AreaRegionID");

                entity.Property(e => e.DoorPowerManageId).HasColumnName("DoorPowerManageID");

                entity.HasOne(d => d.DoorPowerManage)
                    .WithMany()
                    .HasForeignKey(d => d.DoorPowerManageId)
                    .HasConstraintName("FK_DOORPOWE_RR_DOORPOWE");
            });

            modelBuilder.Entity<DoorPowerManageAreaVer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DoorPowerManageAreaVer");

                entity.Property(e => e.AreaRegionId).HasColumnName("AreaRegionID");

                entity.Property(e => e.DoorPowerManageVerId).HasColumnName("DoorPowerManageVerID");

                entity.HasOne(d => d.DoorPowerManageVer)
                    .WithMany()
                    .HasForeignKey(d => d.DoorPowerManageVerId)
                    .HasConstraintName("FK_DOORPOWE_LT_DOORPOWE");
            });

            modelBuilder.Entity<DoorPowerManageBgsetup>(entity =>
            {
                entity.HasKey(e => e.BgsetupId);

                entity.ToTable("DoorPowerManageBGSetup");

                entity.Property(e => e.BgsetupId).HasColumnName("BGSetupID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.DelDate).HasColumnType("datetime");

                entity.Property(e => e.DelUserId).HasColumnName("DelUserID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DoorPowerManageBgsetupItem>(entity =>
            {
                entity.HasKey(e => e.BgsetupItemId);

                entity.ToTable("DoorPowerManageBGSetupItem");

                entity.Property(e => e.BgsetupItemId).HasColumnName("BGSetupItemID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");

                entity.Property(e => e.DelDate).HasColumnType("datetime");

                entity.Property(e => e.DelUserId).HasColumnName("DelUserID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserId).HasColumnName("ModifyUserID");

                entity.Property(e => e.PowerAdminId).HasColumnName("PowerAdminID");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<DoorPowerManageBgsignSetup>(entity =>
            {
                entity.HasKey(e => e.BgsignSetupId);

                entity.ToTable("DoorPowerManageBGSignSetup");

                entity.Property(e => e.BgsignSetupId).HasColumnName("BGSignSetupID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FirstSignDate).HasColumnType("datetime");

                entity.Property(e => e.FirstSignMeno)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FirstSignUserId).HasColumnName("FirstSignUserID");

                entity.Property(e => e.IsUse).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DoorPowerManageBgsignSetupItem>(entity =>
            {
                entity.HasKey(e => e.BgsignSetupItemId);

                entity.ToTable("DoorPowerManageBGSignSetupItem");

                entity.Property(e => e.BgsignSetupItemId).HasColumnName("BGSignSetupItemID");

                entity.Property(e => e.BgsignSetupId).HasColumnName("BGSignSetupID");

                entity.Property(e => e.IsSign).HasDefaultValueSql("((0))");

                entity.Property(e => e.SignAdminId).HasColumnName("SignAdminID");

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.SignMeno).HasMaxLength(500);

                entity.Property(e => e.SignOrderId).HasColumnName("SignOrderID");

                entity.Property(e => e.SignRole)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignStatusId).HasColumnName("SignStatusID");

                entity.HasOne(d => d.BgsignSetup)
                    .WithMany(p => p.DoorPowerManageBgsignSetupItems)
                    .HasForeignKey(d => d.BgsignSetupId)
                    .HasConstraintName("FK_DoorPowerManageBGSignSetupItem_DoorPowerManageBGSignSetup");
            });

            modelBuilder.Entity<DoorPowerManageModify>(entity =>
            {
                entity.ToTable("DoorPowerManageModify");

                entity.Property(e => e.DoorPowerManageModifyId).HasColumnName("DoorPowerManageModifyID");

                entity.Property(e => e.ActionAdminId).HasColumnName("ActionAdminID");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionMeno)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DoorPowerManageId).HasColumnName("DoorPowerManageID");

                entity.Property(e => e.Files)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Mac)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DoorPowerManageModifyList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DoorPowerManageModifyList");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaRegionId).HasColumnName("AreaRegionID");

                entity.Property(e => e.DoorPowerManageId).HasColumnName("DoorPowerManageID");

                entity.Property(e => e.DoorPowerManageModifyId).HasColumnName("DoorPowerManageModifyID");

                entity.Property(e => e.JurisdictionTypeId).HasColumnName("JurisdictionTypeID");

                entity.Property(e => e.Meno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DoorPowerManageModify)
                    .WithMany()
                    .HasForeignKey(d => d.DoorPowerManageModifyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoorPowerManageModifyList_DoorPowerManageModify");
            });

            modelBuilder.Entity<DoorPowerManageType>(entity =>
            {
                entity.ToTable("DoorPowerManageType");

                entity.Property(e => e.DoorPowerManageTypeId).HasColumnName("DoorPowerManageTypeID");

                entity.Property(e => e.DoorPowerManageId).HasColumnName("DoorPowerManageID");

                entity.Property(e => e.JurisdictionTypeId).HasColumnName("JurisdictionTypeID");

                entity.Property(e => e.Meno)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.DoorPowerManage)
                    .WithMany(p => p.DoorPowerManageTypes)
                    .HasForeignKey(d => d.DoorPowerManageId)
                    .HasConstraintName("FK_DOORPOWE_UU_DOORPOWE");
            });

            modelBuilder.Entity<DoorPowerManageTypeApplication>(entity =>
            {
                entity.HasKey(e => e.DoorPowerManageTypeId)
                    .HasName("PK_DOORPOWERMANAGETYPEAPPLICAT");

                entity.ToTable("DoorPowerManageTypeApplication");

                entity.Property(e => e.DoorPowerManageTypeId).HasColumnName("DoorPowerManageTypeID");

                entity.Property(e => e.DoorPowerManageId).HasColumnName("DoorPowerManageID");

                entity.Property(e => e.JurisdictionTypeId).HasColumnName("JurisdictionTypeID");

                entity.Property(e => e.Meno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DoorPowerManage)
                    .WithMany(p => p.DoorPowerManageTypeApplications)
                    .HasForeignKey(d => d.DoorPowerManageId)
                    .HasConstraintName("FK_DOORPOWE_PP_DOORPOWE");
            });

            modelBuilder.Entity<DoorPowerManageTypeVer>(entity =>
            {
                entity.HasKey(e => e.DoorPowerManageTypeId)
                    .HasName("PK_DOORPOWERMANAGETYPEVER");

                entity.ToTable("DoorPowerManageTypeVer");

                entity.Property(e => e.DoorPowerManageTypeId).HasColumnName("DoorPowerManageTypeID");

                entity.Property(e => e.DoorPowerManageVerId).HasColumnName("DoorPowerManageVerID");

                entity.Property(e => e.JurisdictionTypeId).HasColumnName("JurisdictionTypeID");

                entity.Property(e => e.Meno)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.DoorPowerManageVer)
                    .WithMany(p => p.DoorPowerManageTypeVers)
                    .HasForeignKey(d => d.DoorPowerManageVerId)
                    .HasConstraintName("FK_DOORPOWE_PS_DOORPOWE");
            });

            modelBuilder.Entity<DoorPowerManageVer>(entity =>
            {
                entity.ToTable("DoorPowerManageVer");

                entity.Property(e => e.DoorPowerManageVerId).HasColumnName("DoorPowerManageVerID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bu)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeleteAdminId).HasColumnName("DeleteAdminID");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteReason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DoorPowerManageId).HasColumnName("DoorPowerManageID");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.EnglishPicture)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.File)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilesForDelete)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsFind)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldApplicationId).HasColumnName("Old_Application_ID");

                entity.Property(e => e.Picture)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DoorReplace>(entity =>
            {
                entity.ToTable("DoorReplace");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNameReplace)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNoReplace)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Extel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExtelReplace)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mobi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobiReplace)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NotesReplace)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DoorReplaceBg>(entity =>
            {
                entity.ToTable("DoorReplaceBG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNameReplace)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNoReplace)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NotesReplace)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DrawAllList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DrawAllList");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ArrangeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrangeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrangeTelephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Caption)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CarBrand)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CarType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContractEndDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DriverEmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DriverName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ext)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.File)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotNumberDate).HasColumnType("datetime");

                entity.Property(e => e.OrtherContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoId).HasColumnName("PhotoID");

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehiclePeriodId).HasColumnName("VehiclePeriodID");

                entity.Property(e => e.VehiclePeriodNo).HasMaxLength(10);

                entity.Property(e => e.VehiclePermitId).HasColumnName("VehiclePermitID");

                entity.Property(e => e.WorkType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.HasKey(e => e.DriverGuid);

                entity.ToTable("Driver");

                entity.Property(e => e.DriverGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DriverGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CredentialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DriverID");

                entity.Property(e => e.EmployeeCardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DriverCompanyMatch>(entity =>
            {
                entity.HasKey(e => e.DriverCompanyMatchGuid);

                entity.ToTable("DriverCompanyMatch");

                entity.Property(e => e.DriverCompanyMatchGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("DriverCompanyMatchGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverCompanyMatchId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DriverCompanyMatchID");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.MatchDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DriverVehicleMatch>(entity =>
            {
                entity.HasKey(e => e.VehicleDriverMatchGuid);

                entity.ToTable("DriverVehicleMatch");

                entity.Property(e => e.VehicleDriverMatchGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("VehicleDriverMatchGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DeleteMeno)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.DriverVehicleMatchId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DriverVehicleMatchID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MatchDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VehiclePermitId).HasColumnName("VehiclePermitID");
            });

            modelBuilder.Entity<EconConfig>(entity =>
            {
                entity.ToTable("EconConfig");

                entity.Property(e => e.EconConfigId).HasColumnName("EconConfigID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EhsSign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EhsSign");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNameV).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ElectricUse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ElectricUse");

                entity.Property(e => e.ActionMember).HasMaxLength(50);

                entity.Property(e => e.Af1).HasColumnName("AF1");

                entity.Property(e => e.Af2).HasColumnName("AF2");

                entity.Property(e => e.Atld3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATLD3");

                entity.Property(e => e.Bf1).HasColumnName("BF1");

                entity.Property(e => e.Bf2).HasColumnName("BF2");

                entity.Property(e => e.Bf3).HasColumnName("BF3");

                entity.Property(e => e.Bf4).HasColumnName("BF4");

                entity.Property(e => e.Bf5).HasColumnName("BF5");

                entity.Property(e => e.Bf6).HasColumnName("BF6");

                entity.Property(e => e.Bf7).HasColumnName("BF7");

                entity.Property(e => e.ContentAction).HasMaxLength(200);

                entity.Property(e => e.Defer).HasMaxLength(50);

                entity.Property(e => e.ElecId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ElecID");

                entity.Property(e => e.EmpNameApp).HasMaxLength(50);

                entity.Property(e => e.EmpNoApp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExtTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FacAudit).HasMaxLength(50);

                entity.Property(e => e.FileClother)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileDevices)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileFac)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileMember)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileVendor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.In1).HasColumnName("IN1");

                entity.Property(e => e.In2).HasColumnName("IN2");

                entity.Property(e => e.In3).HasColumnName("IN3");

                entity.Property(e => e.In4).HasColumnName("IN4");

                entity.Property(e => e.In5).HasColumnName("IN5");

                entity.Property(e => e.In6).HasColumnName("IN6");

                entity.Property(e => e.NameConstruc).HasMaxLength(200);

                entity.Property(e => e.NameVendor).HasMaxLength(200);

                entity.Property(e => e.NotesApp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Office).HasMaxLength(100);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TimeAplication).HasColumnType("datetime");

                entity.Property(e => e.UnitApplication).HasMaxLength(200);

                entity.Property(e => e.VendorAudit).HasMaxLength(50);
            });

            modelBuilder.Entity<EnviEnclosedSpace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Envi_EnclosedSpace");

                entity.Property(e => e.ActionPossition).HasMaxLength(100);

                entity.Property(e => e.Applicant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ContructionId).HasColumnName("ContructionID");

                entity.Property(e => e.ContructorName).HasMaxLength(200);

                entity.Property(e => e.DepartApplicant).HasMaxLength(200);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FileClother)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileDevices)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileUploadMccatldn2gsnt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FileUpload_Mccatldn2gsnt");

                entity.Property(e => e.FileUploadMccgstc1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FileUpload_Mccgstc1");

                entity.Property(e => e.FileUploadMccgstc2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FileUpload_Mccgstc2");

                entity.Property(e => e.FileUploadNvgsdv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FileUpload_Nvgsdv");

                entity.Property(e => e.FileUploadNvgsnt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FileUpload_Nvgsnt");

                entity.Property(e => e.FileVendor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Mccatldn2gsnt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mccgstc1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mccgstc2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameNvgsnt).HasMaxLength(50);

                entity.Property(e => e.Ndthct).HasMaxLength(200);

                entity.Property(e => e.NongdoCh4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NongdoCH4");

                entity.Property(e => e.NongdoCo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NongdoCO");

                entity.Property(e => e.NongdoH2s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NongdoH2S");

                entity.Property(e => e.NongdoO2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nvgsdvx)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nvtntcnt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName).HasMaxLength(200);

                entity.Property(e => e.Quanche)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Vttnct).HasMaxLength(200);
            });

            modelBuilder.Entity<EnviHighAction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EnviHighAction");

                entity.Property(e => e.Anhmccatld)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Anhmccgstc1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Anhmccgstc2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Anhnvgscnt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Anhnvgsdvx)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Applicant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Dvxin).HasMaxLength(100);

                entity.Property(e => e.Endtime).HasColumnType("datetime");

                entity.Property(e => e.FileClother)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileDevices)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Maccantoanld)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Machungchigsthicong1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Machungchigsthicong2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nhanviengscuanhathau).HasMaxLength(50);

                entity.Property(e => e.Nhanviengsdvx).HasMaxLength(50);

                entity.Property(e => e.Nhanvientntcnhathau).HasMaxLength(50);

                entity.Property(e => e.Noidungtnct).HasMaxLength(200);

                entity.Property(e => e.Starttime).HasColumnType("datetime");

                entity.Property(e => e.Tencongtrinh).HasMaxLength(200);

                entity.Property(e => e.Tennhathau).HasMaxLength(100);

                entity.Property(e => e.Vitritacnghiep).HasMaxLength(100);

                entity.Property(e => e.Vitritacnghiepcuthe).HasMaxLength(200);

                entity.Property(e => e.Vitritoanha).HasMaxLength(200);
            });

            modelBuilder.Entity<ExemptionCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Exemption_Car");

                entity.Property(e => e.Bgname).HasMaxLength(255);

                entity.Property(e => e.CarColor).HasMaxLength(255);

                entity.Property(e => e.CarNumber).HasMaxLength(255);

                entity.Property(e => e.CarType).HasMaxLength(255);

                entity.Property(e => e.DeleteDdate).HasMaxLength(255);

                entity.Property(e => e.DeleteDseason).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<ExpCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ExpCar");

                entity.Property(e => e.Carnumber).HasMaxLength(50);

                entity.Property(e => e.ExpCarid).ValueGeneratedOnAdd();

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.TravelEndTime).HasColumnType("datetime");

                entity.Property(e => e.TravelStartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FingerPrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FingerPrint");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FingerPrintId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FingerPrintID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<FireEngine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FireEngine");

                entity.Property(e => e.Af1).HasColumnName("AF1");

                entity.Property(e => e.Af2).HasColumnName("AF2");

                entity.Property(e => e.Af3).HasColumnName("AF3");

                entity.Property(e => e.Af4).HasColumnName("AF4");

                entity.Property(e => e.Af5).HasColumnName("AF5");

                entity.Property(e => e.Atld3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATLD3");

                entity.Property(e => e.AuditFile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuditVendor).HasMaxLength(50);

                entity.Property(e => e.Bf1).HasColumnName("BF1");

                entity.Property(e => e.Bf10).HasColumnName("BF10");

                entity.Property(e => e.Bf11).HasColumnName("BF11");

                entity.Property(e => e.Bf2).HasColumnName("BF2");

                entity.Property(e => e.Bf3).HasColumnName("BF3");

                entity.Property(e => e.Bf4).HasColumnName("BF4");

                entity.Property(e => e.Bf5).HasColumnName("BF5");

                entity.Property(e => e.Bf6).HasColumnName("BF6");

                entity.Property(e => e.Bf7).HasColumnName("BF7");

                entity.Property(e => e.Bf8).HasColumnName("BF8");

                entity.Property(e => e.Bf9).HasColumnName("BF9");

                entity.Property(e => e.ContenAction).HasMaxLength(200);

                entity.Property(e => e.Defer).HasMaxLength(50);

                entity.Property(e => e.EmpNameApp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNoApp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExtTel)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FileClother)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileDevices)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilePeople)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileVenDor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FireId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FireID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idatld)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDATLD");

                entity.Property(e => e.ImageAtld)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImageATLD");

                entity.Property(e => e.ImageAudit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.In1).HasColumnName("IN1");

                entity.Property(e => e.In2).HasColumnName("IN2");

                entity.Property(e => e.In3).HasColumnName("IN3");

                entity.Property(e => e.In4).HasColumnName("IN4");

                entity.Property(e => e.In5).HasColumnName("IN5");

                entity.Property(e => e.MemberAudit).HasMaxLength(50);

                entity.Property(e => e.MemberFire)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameConstruc).HasMaxLength(200);

                entity.Property(e => e.NameVendor).HasMaxLength(100);

                entity.Property(e => e.NotesApp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Office).HasMaxLength(100);

                entity.Property(e => e.PeopleAction).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TimeAplication).HasColumnType("datetime");

                entity.Property(e => e.UnitApplication).HasMaxLength(100);
            });

            modelBuilder.Entity<Form>(entity =>
            {
                entity.ToTable("Form");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormTable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KeyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FormBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FormBack", "faceid");

                entity.Property(e => e.FormIdback).HasColumnName("FormIDback");

                entity.Property(e => e.FormNameback)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormTableback)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KeyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Urlback)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FormStatus>(entity =>
            {
                entity.HasKey(e => e.FormStatusId)
                    .HasName("PK_FORMSTATUS");

                entity.ToTable("FormStatus");

                entity.Property(e => e.FormStatusId).HasColumnName("FormStatusID");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlowImage)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FlowNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.FormMeno)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToZc).HasColumnName("ToZC");

                entity.Property(e => e.WorkTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<FormWorkProc>(entity =>
            {
                entity.HasKey(e => e.FormWorkProcId)
                    .HasName("PK_FORMWORKPROC");

                entity.ToTable("FormWorkProc");

                entity.Property(e => e.FormWorkProcId).HasColumnName("FormWorkProcID");

                entity.Property(e => e.Act)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.FormStatusId).HasColumnName("FormStatusID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Meno)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FormbackTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FormbackTest", "faceid");

                entity.Property(e => e.FormIdback).HasColumnName("FormIDback");

                entity.Property(e => e.FormNameback)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Formtableback)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KeyNameback)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Urlback)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FourCompanyAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FourCompanyAll");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.ApplicationUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VipCardId).HasColumnName("VipCardID");

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");

                entity.Property(e => e.VisitUnits)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FourVisitor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FourVisitors");

                entity.Property(e => e.CustListId).HasColumnName("CustListID");

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FourVisitorAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FourVisitorAll");

                entity.Property(e => e.CustListId).HasColumnName("CustListID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.ReceiverTime).HasColumnType("datetime");

                entity.Property(e => e.RemandTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

                entity.Property(e => e.ReturnTime).HasColumnType("datetime");

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoingOut>(entity =>
            {
                entity.ToTable("GoingOut");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaRegionId).HasColumnName("AreaRegionID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bu)
                    .HasMaxLength(200)
                    .HasColumnName("BU");

                entity.Property(e => e.Destination).HasMaxLength(200);

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNameApp).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNoApp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NotesApp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneApp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimeApplication).HasColumnType("datetime");

                entity.Property(e => e.TimeInPlan).HasColumnType("datetime");

                entity.Property(e => e.TimeInReal).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");
            });

            modelBuilder.Entity<Gongyingshang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gongyingshang");

                entity.Property(e => e.CorpName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NChnname)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("N_CHNName");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("StatusID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.VendorCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GroupChiefExecutive>(entity =>
            {
                entity.ToTable("GroupChiefExecutive");

                entity.Property(e => e.GroupChiefExecutiveId).HasColumnName("GroupChiefExecutiveID");

                entity.Property(e => e.AuthorizationFile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureFile)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GroupType>(entity =>
            {
                entity.ToTable("GroupType");

                entity.Property(e => e.GroupTypeId).HasColumnName("GroupTypeID");

                entity.Property(e => e.AreaGroupId).HasColumnName("AreaGroupID");

                entity.Property(e => e.GroupTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GuardStationAbout>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GuardStationAbout");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArriveTime).HasColumnType("datetime");

                entity.Property(e => e.Azimuth)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Building)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FirstId).HasColumnName("FirstID");

                entity.Property(e => e.Floor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GuardServerReportTwoId).HasColumnName("GuardServerReportTwoID");

                entity.Property(e => e.GuardStationAboutId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("GuardStationAboutID");

                entity.Property(e => e.OldId).HasColumnName("OldID");

                entity.Property(e => e.Other)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Place)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PostAdminId).HasColumnName("PostAdmin_id");

                entity.Property(e => e.PostAdminSelect)
                    .HasMaxLength(50)
                    .HasColumnName("PostAdmin_Select")
                    .IsFixedLength();

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StationLeavel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationMeno)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GuiBinAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GuiBinAudit");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.ApplicationUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AreaHh)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AreaHH");

                entity.Property(e => e.Bgname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BGName");

                entity.Property(e => e.Extension)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptionBg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ReceptionBG");

                entity.Property(e => e.ReceptionPeople)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VisitEndTime).HasColumnType("datetime");

                entity.Property(e => e.VisitStartTime).HasColumnType("datetime");

                entity.Property(e => e.VisitUnits)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GuiBinManage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GuiBinManage");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.ApplicationUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CardNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustListId).HasColumnName("CustListID");

                entity.Property(e => e.EcardNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ECardNum");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.ReceiverNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverTime).HasColumnType("datetime");

                entity.Property(e => e.RemandTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

                entity.Property(e => e.ReturnTime).HasColumnType("datetime");

                entity.Property(e => e.VipCardId).HasColumnName("VipCardID");

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VisitUnits)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GuiBinOutCall>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GuiBinOutCall");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.ApplicationUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bgname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BGName");

                entity.Property(e => e.Calldate)
                    .HasColumnType("datetime")
                    .HasColumnName("calldate");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.Extension)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptionBg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ReceptionBG");

                entity.Property(e => e.ReceptionPeople)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VisitEndTime).HasColumnType("datetime");

                entity.Property(e => e.VisitStartTime).HasColumnType("datetime");

                entity.Property(e => e.VisitUnits)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GuiBinReceive>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GuiBinReceive");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.ApplicationUnit).HasMaxLength(200);

                entity.Property(e => e.AreaHh)
                    .HasMaxLength(100)
                    .HasColumnName("AreaHH");

                entity.Property(e => e.Bgname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BGName");

                entity.Property(e => e.Extention)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveCards)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.ReceptionPeople).HasMaxLength(50);

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VipCardId).HasColumnName("VipCardID");

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");

                entity.Property(e => e.VisitEndTime).HasColumnType("datetime");

                entity.Property(e => e.VisitStartTime).HasColumnType("datetime");

                entity.Property(e => e.VisitUnits).HasMaxLength(200);
            });

            modelBuilder.Entity<GuiBinReturnSin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GuiBinReturnSin");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.ApplicationUnit).HasMaxLength(200);

                entity.Property(e => e.AreaHh)
                    .HasMaxLength(100)
                    .HasColumnName("AreaHH");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bgname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BGName");

                entity.Property(e => e.CardNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustListId).HasColumnName("CustListID");

                entity.Property(e => e.EcardNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ECardNum");

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.ReceiverTime).HasColumnType("datetime");

                entity.Property(e => e.ReceptionDept).HasMaxLength(100);

                entity.Property(e => e.ReceptionPeople).HasMaxLength(50);

                entity.Property(e => e.RemandTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

                entity.Property(e => e.ReturnTime).HasColumnType("datetime");

                entity.Property(e => e.SubmitName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");

                entity.Property(e => e.VisitEndTime).HasColumnType("datetime");

                entity.Property(e => e.VisitStartTime).HasColumnType("datetime");

                entity.Property(e => e.VisitUnits).HasMaxLength(200);

                entity.Property(e => e.VisitorCardId).HasColumnName("VisitorCardID");
            });

            modelBuilder.Entity<HandleResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HandleResult");

                entity.Property(e => e.ContentResult).HasMaxLength(500);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Idtrouble).HasColumnName("IDTrouble");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.TimeHandle)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HandleTrouble>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HandleTrouble");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.EmpNameApp).HasMaxLength(50);

                entity.Property(e => e.EmpNameArr).HasMaxLength(50);

                entity.Property(e => e.EmpNameRece).HasMaxLength(50);

                entity.Property(e => e.EmpNoApp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNoArr).HasMaxLength(50);

                entity.Property(e => e.EmpNoRece).HasMaxLength(50);

                entity.Property(e => e.HandEmpNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HandExt)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HandMemo).HasMaxLength(300);

                entity.Property(e => e.HandMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HandNameCn)
                    .HasMaxLength(50)
                    .HasColumnName("HandNameCN");

                entity.Property(e => e.HandNameVn)
                    .HasMaxLength(50)
                    .HasColumnName("HandNameVN");

                entity.Property(e => e.HandNotes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HandResult).HasMaxLength(500);

                entity.Property(e => e.HandTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(300);

                entity.Property(e => e.MethodRece).HasMaxLength(50);

                entity.Property(e => e.MothodArr).HasMaxLength(50);

                entity.Property(e => e.OtherTrouble).HasMaxLength(50);

                entity.Property(e => e.ReceTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeSend).HasColumnType("datetime");

                entity.Property(e => e.TroubleContent).HasMaxLength(500);
            });

            modelBuilder.Entity<HangleSign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HangleSign");

                entity.Property(e => e.AreaId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AreaID");

                entity.Property(e => e.EmpNameCn)
                    .HasMaxLength(50)
                    .HasColumnName("EmpNameCN");

                entity.Property(e => e.EmpNameVn)
                    .HasMaxLength(50)
                    .HasColumnName("EmpNameVN");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ext)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Help>(entity =>
            {
                entity.ToTable("Help");

                entity.Property(e => e.HelpId).HasColumnName("HelpID");

                entity.Property(e => e.Arrangement).HasDefaultValueSql("((0))");

                entity.Property(e => e.HelpContent)
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.HelpTitle).HasMaxLength(100);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HgcarInfo>(entity =>
            {
                entity.HasKey(e => e.HgcarId);

                entity.ToTable("HGCarInfo");

                entity.Property(e => e.HgcarId).HasColumnName("HGCarID");

                entity.Property(e => e.CarNumber).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.Idno)
                    .HasMaxLength(50)
                    .HasColumnName("IDNO");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.TranCom).HasMaxLength(50);
            });

            modelBuilder.Entity<Hinhvv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Hinhvv");

                entity.Property(e => e.Hello)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Test)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HoanCong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HoanCong");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Para)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Hoisting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Hoisting");

                entity.Property(e => e.Af1).HasColumnName("AF1");

                entity.Property(e => e.Af2).HasColumnName("AF2");

                entity.Property(e => e.Atld2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATLD2");

                entity.Property(e => e.Atld3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATLD3");

                entity.Property(e => e.AuditFile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bf1).HasColumnName("BF1");

                entity.Property(e => e.Bf2).HasColumnName("BF2");

                entity.Property(e => e.Bf3).HasColumnName("BF3");

                entity.Property(e => e.Bf4).HasColumnName("BF4");

                entity.Property(e => e.Bf5).HasColumnName("BF5");

                entity.Property(e => e.ContentAction).HasMaxLength(200);

                entity.Property(e => e.EmpNameApp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNoApp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExtTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileClother)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileDevices)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileVendor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoiId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HoiID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImageAtld2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImageATLD2");

                entity.Property(e => e.ImageAudit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageChart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageCheck)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageDriving)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageMember)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.In1).HasColumnName("IN1");

                entity.Property(e => e.In10).HasColumnName("IN10");

                entity.Property(e => e.In11).HasColumnName("IN11");

                entity.Property(e => e.In2).HasColumnName("IN2");

                entity.Property(e => e.In3).HasColumnName("IN3");

                entity.Property(e => e.In4).HasColumnName("IN4");

                entity.Property(e => e.In5).HasColumnName("IN5");

                entity.Property(e => e.In6).HasColumnName("IN6");

                entity.Property(e => e.In7).HasColumnName("IN7");

                entity.Property(e => e.In8).HasColumnName("IN8");

                entity.Property(e => e.In9).HasColumnName("IN9");

                entity.Property(e => e.MemberAudit).HasMaxLength(50);

                entity.Property(e => e.NameContruc).HasMaxLength(200);

                entity.Property(e => e.NameDriver).HasMaxLength(50);

                entity.Property(e => e.NameTie).HasMaxLength(50);

                entity.Property(e => e.NameTurn).HasMaxLength(50);

                entity.Property(e => e.NameVendor).HasMaxLength(200);

                entity.Property(e => e.NotesApp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberCar)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Office).HasMaxLength(50);

                entity.Property(e => e.PositionAction).HasMaxLength(200);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TimeApplication).HasColumnType("datetime");

                entity.Property(e => e.UnitApplication).HasMaxLength(100);

                entity.Property(e => e.VendorAudit).HasMaxLength(50);

                entity.Property(e => e.Weight).HasMaxLength(30);
            });

            modelBuilder.Entity<HouseLayer>(entity =>
            {
                entity.ToTable("HouseLayer");

                entity.Property(e => e.HouseLayerId).HasColumnName("HouseLayerID");

                entity.Property(e => e.LayerId).HasColumnName("LayerID");

                entity.Property(e => e.RegionHouseId).HasColumnName("RegionHouseID");
            });

            modelBuilder.Entity<IcivetLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IcivetLogin");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImExPortProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ImExPortProduct");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CardID");

                entity.Property(e => e.ComporationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ComporationID");

                entity.Property(e => e.DatetimeUse).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ImExPortProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImExPortProductID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.MacId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MacID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PartPass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weights)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImExPortProductDriverInfor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ImExPortProduct_DriverInfor");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComporationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ComporationID");

                entity.Property(e => e.DriverId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DriverID");

                entity.Property(e => e.DriverName).HasMaxLength(100);

                entity.Property(e => e.ImExPortProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImExPortProductID");

                entity.Property(e => e.TransportType).HasMaxLength(200);
            });

            modelBuilder.Entity<ImExPortProductProductInfor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ImExPortProduct_ProductInfor");

                entity.Property(e => e.ComporationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ComporationID");

                entity.Property(e => e.ImExPortProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImExPortProductID");

                entity.Property(e => e.ProductType).HasMaxLength(500);

                entity.Property(e => e.UnitType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Intermittent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Intermittent");

                entity.Property(e => e.Af1).HasColumnName("AF1");

                entity.Property(e => e.Af2).HasColumnName("AF2");

                entity.Property(e => e.Af3).HasColumnName("AF3");

                entity.Property(e => e.Atld2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATLD2");

                entity.Property(e => e.Atld3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATLD3");

                entity.Property(e => e.AuditFile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuditVendor).HasMaxLength(50);

                entity.Property(e => e.Bf1).HasColumnName("BF1");

                entity.Property(e => e.Bf2).HasColumnName("BF2");

                entity.Property(e => e.Bf3).HasColumnName("BF3");

                entity.Property(e => e.Bf4).HasColumnName("BF4");

                entity.Property(e => e.Bf5).HasColumnName("BF5");

                entity.Property(e => e.ConDefe).HasMaxLength(50);

                entity.Property(e => e.ContentInter).HasMaxLength(500);

                entity.Property(e => e.EmpNameApp).HasMaxLength(50);

                entity.Property(e => e.EmpNoApp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExtTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileClother)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileDevices)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idinter)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDInter");

                entity.Property(e => e.ImageAtld2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImageATLD2");

                entity.Property(e => e.ImageAudit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageMember)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.In1).HasColumnName("IN1");

                entity.Property(e => e.In2).HasColumnName("IN2");

                entity.Property(e => e.In3).HasColumnName("IN3");

                entity.Property(e => e.In4).HasColumnName("IN4");

                entity.Property(e => e.In5).HasColumnName("IN5");

                entity.Property(e => e.MemberAudit).HasMaxLength(50);

                entity.Property(e => e.NameContruc).HasMaxLength(500);

                entity.Property(e => e.NameVendor).HasMaxLength(500);

                entity.Property(e => e.NotesApp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Office).HasMaxLength(500);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TimeApplication).HasColumnType("datetime");

                entity.Property(e => e.TypeDefe).HasMaxLength(200);

                entity.Property(e => e.UnitApplication).HasMaxLength(200);
            });

            modelBuilder.Entity<InteruptInfrared>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InteruptInfrared");

                entity.Property(e => e.ActionContent).HasMaxLength(200);

                entity.Property(e => e.ActionDepartment).HasMaxLength(50);

                entity.Property(e => e.ActionLocation).HasMaxLength(100);

                entity.Property(e => e.ActionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicantEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicantExt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationDepart).HasMaxLength(50);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ContructionId).HasColumnName("ContructionID");

                entity.Property(e => e.EmpIdcreate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmpIDCreate");

                entity.Property(e => e.FromDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Reason).HasMaxLength(200);

                entity.Property(e => e.SpecialPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Todate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvalidRecord>(entity =>
            {
                entity.HasKey(e => e.InvalidId)
                    .HasName("PK_INVALIDRECORDS");

                entity.Property(e => e.InvalidId).HasColumnName("InvalidID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.Effective)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Invalid).HasColumnType("datetime");

                entity.Property(e => e.InvalidReasons)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.QuitApplyId).HasColumnName("QuitApplyID");

                entity.Property(e => e.RecoveryType).HasComment("0為作廢未處理，1為證件收回，2為交賠償金，3為補卡");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.InvalidRecords)
                    .HasForeignKey(d => d.CardId)
                    .HasConstraintName("FK_INVALIDR_REFERENCE_CARD");
            });

            modelBuilder.Entity<ItDevice>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.BgIduse).HasColumnName("BgIDUse");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreaterDepartment).HasMaxLength(50);

                entity.Property(e => e.CreaterEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreaterEmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CreaterEmpID");

                entity.Property(e => e.CreaterName).HasMaxLength(100);

                entity.Property(e => e.CreaterPhoneNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreaterSpecialPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IpPass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationDetail).HasMaxLength(200);

                entity.Property(e => e.PartPass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UseDepartment).HasMaxLength(50);

                entity.Property(e => e.UseEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseEmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UseEmpID");

                entity.Property(e => e.UseName).HasMaxLength(100);

                entity.Property(e => e.UsePhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseSpecialPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UseTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ItDeviceInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ItDevice_Info");

                entity.Property(e => e.AssetType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItDeviceId).HasColumnName("ItDeviceID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProductID");

                entity.Property(e => e.Sn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SN");

                entity.Property(e => e.Specifications)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItdevicesListPass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ITDevices_ListPass");

                entity.Property(e => e.IpPass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItdeviceId).HasColumnName("ItdeviceID");

                entity.Property(e => e.MacPass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartPass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimePass).HasColumnType("datetime");
            });

            modelBuilder.Entity<Itinerary>(entity =>
            {
                entity.ToTable("Itinerary");

                entity.Property(e => e.ItineraryId).HasColumnName("ItineraryID");

                entity.Property(e => e.BriefAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BriefMeno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BriefType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LtineraryStress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Person)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");
            });

            modelBuilder.Entity<JoinDrawDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("JoinDrawData");

                entity.Property(e => e.VehiclePeriodNo).HasMaxLength(10);

                entity.Property(e => e.VehiclePermitId).HasColumnName("VehiclePermitID");
            });

            modelBuilder.Entity<JurisdictionType>(entity =>
            {
                entity.ToTable("JurisdictionType");

                entity.Property(e => e.JurisdictionTypeId).HasColumnName("JurisdictionTypeID");

                entity.Property(e => e.Arrangement)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsBegin).HasDefaultValueSql("((0))");

                entity.Property(e => e.JurisdictionType1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("JurisdictionType");

                entity.Property(e => e.Meno)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Layer>(entity =>
            {
                entity.ToTable("Layer");

                entity.Property(e => e.LayerId).HasColumnName("LayerID");

                entity.Property(e => e.LayerName).HasMaxLength(50);
            });

            modelBuilder.Entity<LeaseContract>(entity =>
            {
                entity.ToTable("LeaseContract");

                entity.Property(e => e.LeaseContractId).HasColumnName("LeaseContractID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FactoryName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.File)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HouseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PayStatus).HasComment("0 未交  1 未交清  2 已交清");

                entity.Property(e => e.PayYear)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status).HasComment("0 在租  1 停租  2 續租");

                entity.Property(e => e.Tel)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tenant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasComment("內部 \r\n   外部");
            });

            modelBuilder.Entity<Link>(entity =>
            {
                entity.Property(e => e.LinkId).HasColumnName("LinkID");

                entity.Property(e => e.CreatTime).HasColumnType("datetime");

                entity.Property(e => e.LinkName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.ToTable("List");

                entity.Property(e => e.ListId).HasColumnName("ListID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.File)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ListName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListCamera>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ListCamera");

                entity.Property(e => e.Area).HasMaxLength(200);

                entity.Property(e => e.Floor).HasMaxLength(50);

                entity.Property(e => e.House).HasMaxLength(200);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idlist)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDList");

                entity.Property(e => e.Kvcc)
                    .HasMaxLength(100)
                    .HasColumnName("KVCC");

                entity.Property(e => e.Position).HasMaxLength(100);

                entity.Property(e => e.Time)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListCarMer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ListCarMer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idcar)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCar");

                entity.Property(e => e.ImageCar)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumberCar)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListCarPass>(entity =>
            {
                entity.ToTable("ListCarPass");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExtTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileExcel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(100);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeApplication).HasColumnType("datetime");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListMer>(entity =>
            {
                entity.HasKey(e => e.IdItem);

                entity.ToTable("ListMer");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direct).HasMaxLength(200);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameMer).HasMaxLength(100);

                entity.Property(e => e.Relation).HasMaxLength(200);

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<ListOutPl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ListOutPL");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Mac)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOut).HasColumnType("datetime");
            });

            modelBuilder.Entity<ListPosisionCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ListPosisionCar");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PossionName).HasMaxLength(50);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Location");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LocationDetail).HasMaxLength(200);

                entity.Property(e => e.LocationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LocationID");

                entity.Property(e => e.LocationName).HasMaxLength(100);
            });

            modelBuilder.Entity<Lodging>(entity =>
            {
                entity.ToTable("lodging");

                entity.Property(e => e.LodgingId).HasColumnName("lodgingID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LodgingNum).HasColumnName("lodgingNum");

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_LOG");

                entity.ToTable("log");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Mac)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.New).IsUnicode(false);

                entity.Property(e => e.Old).IsUnicode(false);

                entity.Property(e => e.OperTime).HasColumnType("datetime");

                entity.Property(e => e.OperType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineIppairing>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MachineIPPairing");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Mac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAC");

                entity.Property(e => e.MachineIppairingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MachineIPPairingID");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineIppairingInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MachineIPPairingInfo");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MakeCardArea>(entity =>
            {
                entity.ToTable("MakeCardArea");

                entity.Property(e => e.MakeCardAreaId).HasColumnName("MakeCardAreaID");

                entity.Property(e => e.AreaId)
                    .HasColumnName("AreaID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Meno)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MakeCardDataError>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MakeCardDataError");

                entity.Property(e => e.ErrorDate)
                    .HasColumnType("datetime")
                    .HasComment("出錯異常記錄時間");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("證件ID,");

                entity.Property(e => e.Meno)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("備註");

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .HasComment("證件類型,1表車輛通行證,2表客戶駐廠證或駐廠工作證");
            });

            modelBuilder.Entity<MaterialforChemistry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MaterialforChemistry");

                entity.Property(e => e.Amount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryUnit).HasMaxLength(20);

                entity.Property(e => e.ChemistryFormId).HasColumnName("ChemistryFormID");

                entity.Property(e => e.Doccument).HasMaxLength(50);

                entity.Property(e => e.FireTemp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Mass)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MassUsingofMaterialeveryday)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MassofAllMaterialInStore)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MassofMaterialInStore)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaterialID");

                entity.Property(e => e.MaterialName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreMaxCapacity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalMass)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaterialforChemistry1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MaterialforChemistry", "faceid");

                entity.Property(e => e.CategoryUnit)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ChemistryFormId).HasColumnName("ChemistryFormID");

                entity.Property(e => e.Doccument).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MaterialId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaterialID");

                entity.Property(e => e.MaterialName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Meal>(entity =>
            {
                entity.ToTable("Meal");

                entity.Property(e => e.MealId).HasColumnName("MealID");

                entity.Property(e => e.AccompanyManagers)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccompanyManagers1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccompanyManagers2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DiningTime).HasColumnType("datetime");

                entity.Property(e => e.MealAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MealLeavel)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");
            });

            modelBuilder.Entity<MerCheProc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MerCheProc");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProcID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MerCheStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MerCheStatus");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Para)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("StatusID");

                entity.Property(e => e.WordTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MerProc>(entity =>
            {
                entity.HasKey(e => e.ProcId);

                entity.ToTable("MerProc");

                entity.Property(e => e.ProcId).HasColumnName("ProcID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(50);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MerStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("MerStatus");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Emp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(50);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MerTransfer>(entity =>
            {
                entity.ToTable("MerTransfer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Applicationtime).HasColumnType("datetime");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CarType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EmployeeNameApp).HasMaxLength(50);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNoApp)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ExtTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameTool)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MerTransferProc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MerTransferProc");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProcID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.WordDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MerTrasferStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MerTrasferStatus");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Para)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("StatusID");

                entity.Property(e => e.WorkTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Merchandise>(entity =>
            {
                entity.ToTable("Merchandise");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.Bg).HasColumnName("BG");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CarType).HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EmployeeNameApp).HasMaxLength(50);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNoApp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExtTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Image1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image1Bye).HasColumnType("image");

                entity.Property(e => e.Image2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image2Bye).HasColumnType("image");

                entity.Property(e => e.Image3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image3Bye).HasColumnType("image");

                entity.Property(e => e.Image4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image4Bye).HasColumnType("image");

                entity.Property(e => e.ImageIn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageInBye).HasColumnType("image");

                entity.Property(e => e.ImageOut)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageOutBye).HasColumnType("image");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NameTool).HasMaxLength(200);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UserTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MessSenLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MessSenLog");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.FormType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MessId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MessID");

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.Property(e => e.TimeAdd).HasColumnType("datetime");

                entity.Property(e => e.TimeSend).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.CreatTime).HasColumnType("datetime");

                entity.Property(e => e.MessageTypeId).HasColumnName("MessageTypeID");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<MessageType>(entity =>
            {
                entity.ToTable("MessageType");

                entity.Property(e => e.MessageTypeId).HasColumnName("MessageTypeID");

                entity.Property(e => e.IsDleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MessageType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MessageType");
            });

            modelBuilder.Entity<MfCarRental>(entity =>
            {
                entity.ToTable("MfCarRental");

                entity.Property(e => e.MfCarRentalId).HasColumnName("MfCarRentalID");

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contacter)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContacterPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CredentalsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Enddate).HasColumnType("datetime");

                entity.Property(e => e.MfAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MfCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Mqq>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mqq");

                entity.Property(e => e.Areaid).HasColumnName("areaid");

                entity.Property(e => e.Buildingname)
                    .HasMaxLength(255)
                    .HasColumnName("buildingname");

                entity.Property(e => e.F10).HasMaxLength(255);

                entity.Property(e => e.F7).HasMaxLength(255);

                entity.Property(e => e.F8).HasMaxLength(255);

                entity.Property(e => e.F9).HasMaxLength(255);

                entity.Property(e => e.Layer)
                    .HasMaxLength(255)
                    .HasColumnName("layer");

                entity.Property(e => e.No).HasColumnName("NO");

                entity.Property(e => e.Region)
                    .HasMaxLength(255)
                    .HasColumnName("region");

                entity.Property(e => e.Regionname)
                    .HasMaxLength(255)
                    .HasColumnName("regionname");
            });

            modelBuilder.Entity<Mqq1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mqq1");
            });

            modelBuilder.Entity<Mqq3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mqq3");

                entity.Property(e => e.LayerId).HasColumnName("LayerID");

                entity.Property(e => e.RegionHouseId).HasColumnName("RegionHouseID");
            });

            modelBuilder.Entity<NighAction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NighAction");

                entity.Property(e => e.ContenAction).HasMaxLength(200);

                entity.Property(e => e.EmpNameApp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNoApp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExtTel)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idnight)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNight");

                entity.Property(e => e.NameContrucs).HasMaxLength(200);

                entity.Property(e => e.NameRes).HasMaxLength(200);

                entity.Property(e => e.NameVendor).HasMaxLength(100);

                entity.Property(e => e.Normal).HasMaxLength(200);

                entity.Property(e => e.NotesApp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Office).HasMaxLength(100);

                entity.Property(e => e.Special).HasMaxLength(200);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TelRes)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TimeAplication).HasColumnType("datetime");

                entity.Property(e => e.UnitApplication).HasMaxLength(100);

                entity.Property(e => e.UnitAuditName).HasMaxLength(50);

                entity.Property(e => e.UnitAuditNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnitAuditTc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UnitAuditTC");

                entity.Property(e => e.UnitAuditTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAuditName).HasMaxLength(50);

                entity.Property(e => e.VendorAuditTc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("VendorAuditTC");

                entity.Property(e => e.VendorAuditTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NoJoinByCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NoJoinByCar");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("carNumber");

                entity.Property(e => e.Num).HasColumnName("num");
            });

            modelBuilder.Entity<NoJoinByMan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NoJoinByMen");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Num).HasColumnName("num");
            });

            modelBuilder.Entity<NotesSendLog>(entity =>
            {
                entity.HasKey(e => e.NotesLogId)
                    .HasName("PK_NOTESSENDLOG");

                entity.ToTable("NotesSendLog");

                entity.Property(e => e.BccaddressList)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("BCCAddressList");

                entity.Property(e => e.CcaddressList)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CCAddressList");

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormstatusId).HasColumnName("FormstatusID");

                entity.Property(e => e.FromDisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('FOXCONN110')");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NotesTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('未發送')");

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.Property(e => e.SysTime).HasColumnType("datetime");

                entity.Property(e => e.ToAddressList)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NvipcardFrom165>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nvipcard_From165");

                entity.Property(e => e.Cardname)
                    .HasMaxLength(255)
                    .HasColumnName("cardname");

                entity.Property(e => e.Cardno)
                    .HasMaxLength(255)
                    .HasColumnName("cardno");

                entity.Property(e => e.Carid)
                    .HasMaxLength(255)
                    .HasColumnName("carid");

                entity.Property(e => e.Depart)
                    .HasMaxLength(255)
                    .HasColumnName("depart");

                entity.Property(e => e.Ecardno)
                    .HasMaxLength(255)
                    .HasColumnName("ecardno");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MsreplTranVersion).HasColumnName("msrepl_tran_version");

                entity.Property(e => e.Tel)
                    .HasMaxLength(255)
                    .HasColumnName("tel");
            });

            modelBuilder.Entity<OilRecord>(entity =>
            {
                entity.HasKey(e => e.OilRecordsId)
                    .HasName("PK_OILRECORDS");

                entity.Property(e => e.OilRecordsId).HasColumnName("OilRecordsID");

                entity.Property(e => e.FuelDate).HasColumnType("datetime");

                entity.Property(e => e.FuelPeople)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpareCarId).HasColumnName("SpareCarID");

                entity.HasOne(d => d.SpareCar)
                    .WithMany(p => p.OilRecords)
                    .HasForeignKey(d => d.SpareCarId)
                    .HasConstraintName("FK_OILRECOR_REFERENCE_SPARECAR");
            });

            modelBuilder.Entity<OndutyForAttwApprove>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OndutyForATTW_Approve");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DateSign).HasColumnType("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.NameCheck).HasMaxLength(100);

                entity.Property(e => e.TimeUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OndutyForAttwListAuthor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OndutyForATTW_ListAuthor");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OndutyForAttwListLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("OndutyForAttw_ListLocations");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LocationID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.LocationAbrevationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationDetailName).HasMaxLength(2000);

                entity.Property(e => e.Longitude).HasColumnName("longitude");
            });

            modelBuilder.Entity<OndutyForAttwListLocationsSign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OndutyForAttw_ListLocationsSign");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LocationID");

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.OndutyOfAttwDepartId).HasColumnName("OndutyOfAttwDepartID");

                entity.Property(e => e.TimeCheck).HasColumnType("datetime");
            });

            modelBuilder.Entity<OndutyForAttwRulesForAllLocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OndutyForAttw_RulesForAllLocation");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LocationId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LocationID");

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.RuleDetailName).HasMaxLength(2000);

                entity.Property(e => e.RuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RuleID");

                entity.Property(e => e.Timeupdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OndutyForAttwStatusSign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OndutyForATTW_StatusSign");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.WorkTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OndutyListLocation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LocationAbrevationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationDetailName).HasMaxLength(100);

                entity.Property(e => e.LocationId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LocationID");
            });

            modelBuilder.Entity<OndutyOfAttwDepart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OndutyOfAttwDepart");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DateSing).HasColumnType("date");

                entity.Property(e => e.EmpName).HasMaxLength(200);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<OndutyOfAttwDepartFrameTime>(entity =>
            {
                entity.HasKey(e => e.FrameId);

                entity.ToTable("OndutyOfAttwDepart_FrameTime");

                entity.Property(e => e.FrameId)
                    .ValueGeneratedNever()
                    .HasColumnName("FrameID");

                entity.Property(e => e.DatetimeUpdate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.FrameTimeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("time(0)");
            });

            modelBuilder.Entity<OndutySign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OndutySign");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bgname)
                    .HasMaxLength(50)
                    .HasColumnName("BGName");

                entity.Property(e => e.DateSign).HasColumnType("date");

                entity.Property(e => e.EmpName).HasMaxLength(100);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTimeValid).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.StartTimeValid).HasColumnType("datetime");
            });

            modelBuilder.Entity<OndutySignArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OndutySign_Area");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.AreaShortName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<OndutySignForAttwArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OndutySignForAttw_Area");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.AreaShortName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<OndutySignLocationSign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OndutySign_LocationSign");

                entity.Property(e => e.DepartMentName).HasMaxLength(50);

                entity.Property(e => e.EmpName).HasMaxLength(100);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LocationID");

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.OndutySignId).HasColumnName("OndutySignID");

                entity.Property(e => e.ReceivedEmpNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedTime).HasColumnType("datetime");

                entity.Property(e => e.TimeSign).HasColumnType("datetime");
            });

            modelBuilder.Entity<OndutySignLocationSignHistoryAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OndutySign_LocationSign_HistoryAll");

                entity.Property(e => e.DepartMentName).HasMaxLength(50);

                entity.Property(e => e.EmpName).HasMaxLength(100);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LocationID");

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.OndutySignId).HasColumnName("OndutySignID");

                entity.Property(e => e.ReceivedEmpNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedTime).HasColumnType("datetime");

                entity.Property(e => e.TimeSign).HasColumnType("datetime");
            });

            modelBuilder.Entity<OndutySignOfAttwListEmpNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OndutySignOfAttw_ListEmpNo");

                entity.Property(e => e.EmpName).HasMaxLength(200);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.TimeUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OtherCarInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OtherCarInfo");

                entity.Property(e => e.CarColor).HasMaxLength(255);

                entity.Property(e => e.CarNumber).HasMaxLength(255);

                entity.Property(e => e.CarType).HasMaxLength(255);

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.DocumentsNum).HasMaxLength(255);

                entity.Property(e => e.DriverName).HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Othercar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("othercar");

                entity.Property(e => e.Carcolor)
                    .HasMaxLength(255)
                    .HasColumnName("carcolor");

                entity.Property(e => e.Carnumber)
                    .HasMaxLength(255)
                    .HasColumnName("carnumber");

                entity.Property(e => e.Cartype)
                    .HasMaxLength(255)
                    .HasColumnName("cartype");

                entity.Property(e => e.Companyname).HasMaxLength(255);

                entity.Property(e => e.Documentsnum)
                    .HasMaxLength(255)
                    .HasColumnName("documentsnum");

                entity.Property(e => e.Drivername)
                    .HasMaxLength(255)
                    .HasColumnName("drivername");

                entity.Property(e => e.Driverphone).HasColumnName("driverphone");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<ParkProfileChart>(entity =>
            {
                entity.HasKey(e => e.ParkProfileId);

                entity.ToTable("ParkProfileChart");

                entity.Property(e => e.ParkProfileId).HasColumnName("ParkProfileID");

                entity.Property(e => e.ParkProfileArea).HasMaxLength(500);

                entity.Property(e => e.ParkProfileName).HasMaxLength(500);

                entity.Property(e => e.ParkProfileTime).HasColumnType("datetime");

                entity.Property(e => e.ParkprofileCreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PassForm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PassForm");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartPass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PeoPleList>(entity =>
            {
                entity.HasKey(e => e.Idlist);

                entity.ToTable("PeoPleList");

                entity.Property(e => e.Idlist).HasColumnName("IDList");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.FileCreType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilePre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idatld)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDATLD");

                entity.Property(e => e.IdcreType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDCreType");

                entity.Property(e => e.Idno)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDNo");

                entity.Property(e => e.Idpre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDPre");

                entity.Property(e => e.ImageAtld)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImageATLD");

                entity.Property(e => e.ImagePeople)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<PersonalDocument>(entity =>
            {
                entity.HasKey(e => e.PersonalDocumentsGuid)
                    .HasName("PK_PersonalDocuments_1");

                entity.Property(e => e.PersonalDocumentsGuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("PersonalDocumentsGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.BitImage).HasColumnType("image");

                entity.Property(e => e.CardId)
                    .HasMaxLength(50)
                    .HasColumnName("CardID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creator)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.Deletor)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DepartMent).HasMaxLength(200);

                entity.Property(e => e.EditTime).HasColumnType("datetime");

                entity.Property(e => e.Editor)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Idcode)
                    .HasMaxLength(50)
                    .HasColumnName("IDCode");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nation).HasMaxLength(50);

                entity.Property(e => e.PersonalDocumentsId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PersonalDocumentsID");

                entity.Property(e => e.Sex).HasDefaultValueSql("((0))");

                entity.Property(e => e.ValidDate).HasMaxLength(50);

                entity.Property(e => e.Xszguid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("XSZGUID");

                entity.Property(e => e.Xsztype)
                    .HasColumnName("XSZType")
                    .HasDefaultValueSql("((-1))")
                    .HasComment("行駛證類型：0行駛證反面，1小型車，其它為行駛證正面，默認為2：>0都是正面,-1不是行駛證類型");
            });

            modelBuilder.Entity<PersonalItemImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PersonalItem_Images");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Image)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PersionalId).HasColumnName("PersionalID");
            });

            modelBuilder.Entity<PersonalItemListItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PersonalItem_ListItems");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ItemsName).HasMaxLength(100);

                entity.Property(e => e.PersonItemsFormId).HasColumnName("PersonItemsFormID");

                entity.Property(e => e.Reason).HasMaxLength(200);
            });

            modelBuilder.Entity<PersonalItemsAuthority>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PersonalItems_Authority");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AuthorityId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthorityID");

                entity.Property(e => e.DepartMentSnid).HasColumnName("DepartMentSNID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeNameT).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<PersonalItemsForm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PersonalItemsForm");

                entity.Property(e => e.Applicant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.BedNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Building)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DocFile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.RoomMateId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RoomMateID");

                entity.Property(e => e.RoomMateName).HasMaxLength(50);

                entity.Property(e => e.RoomNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimePassKt).HasColumnType("datetime");

                entity.Property(e => e.TimePassMajorPart).HasColumnType("datetime");

                entity.Property(e => e.TimeUse).HasColumnType("datetime");
            });

            modelBuilder.Entity<PersonalItemsItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PersonalItemsItems");

                entity.Property(e => e.Applicant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.BedNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Building)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DocFile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RoomMateId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RoomMateID");

                entity.Property(e => e.RoomMateName).HasMaxLength(50);

                entity.Property(e => e.RoomNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimePassKt).HasColumnType("datetime");

                entity.Property(e => e.TimePassMajorPart).HasColumnType("datetime");

                entity.Property(e => e.TimeUse).HasColumnType("datetime");
            });

            modelBuilder.Entity<PersonalItemsSigStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PersonalItems_SigStatus");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Meno).HasMaxLength(500);

                entity.Property(e => e.PersonalItemsFormId).HasColumnName("PersonalItemsFormID");

                entity.Property(e => e.SignerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SignerID");

                entity.Property(e => e.SignerName).HasMaxLength(50);

                entity.Property(e => e.TimeSigne).HasColumnType("datetime");
            });

            modelBuilder.Entity<PersonalItemsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PersonalItemsView");

                entity.Property(e => e.Applicant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.BedNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Building)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DocFile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RoomMateId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RoomMateID");

                entity.Property(e => e.RoomMateName).HasMaxLength(50);

                entity.Property(e => e.RoomNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimePassKt).HasColumnType("datetime");

                entity.Property(e => e.TimePassMajorPart).HasColumnType("datetime");

                entity.Property(e => e.TimeUse).HasColumnType("datetime");
            });

            modelBuilder.Entity<PhotoIdmatch>(entity =>
            {
                entity.HasKey(e => e.PhotoIdmatchId);

                entity.ToTable("PhotoIDMatch");

                entity.Property(e => e.PhotoIdmatchId).HasColumnName("PhotoIDMatchID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PhotoId).HasColumnName("PhotoID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<Plapplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PLApplication");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bu)
                    .HasMaxLength(50)
                    .HasColumnName("BU");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pllist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PLList");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.CodePl)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodePL")
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.NamePl)
                    .HasMaxLength(200)
                    .HasColumnName("NamePL");

                entity.Property(e => e.Unit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PllistOut>(entity =>
            {
                entity.HasKey(e => e.Idlist);

                entity.ToTable("PLListOut");

                entity.Property(e => e.Idlist).HasColumnName("IDList");

                entity.Property(e => e.BagId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BagID");

                entity.Property(e => e.Idcode).HasColumnName("IDCode");

                entity.Property(e => e.Idpl).HasColumnName("IDPL");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeUp).HasColumnType("datetime");

                entity.Property(e => e.WeightPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PllistOutProtectorReset>(entity =>
            {
                entity.ToTable("PLListOut_ProtectorReset");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idpl).HasColumnName("IDPL");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.TimeReset).HasColumnType("datetime");
            });

            modelBuilder.Entity<PllistValid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PLListValid");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.CodePl)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CodePL")
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Idlist).HasColumnName("IDList");

                entity.Property(e => e.NamePl)
                    .HasMaxLength(200)
                    .HasColumnName("NamePL");

                entity.Property(e => e.OldId).HasColumnName("OldID");

                entity.Property(e => e.Unit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PosisionCarVip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PosisionCarVip");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PosisionName).HasMaxLength(50);
            });

            modelBuilder.Entity<PossionCar>(entity =>
            {
                entity.ToTable("PossionCar");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppEmpName).HasMaxLength(50);

                entity.Property(e => e.AppEmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberCar)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PossionCar1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PossionCar");

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimeApplication).HasColumnType("datetime");

                entity.Property(e => e.TimeIn)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOut)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UnitApplication).HasMaxLength(50);
            });

            modelBuilder.Entity<PowerAdmin>(entity =>
            {
                entity.ToTable("PowerAdmin");

                entity.Property(e => e.PowerAdminId).HasColumnName("PowerAdminID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.PowerListId).HasColumnName("PowerListID");
            });

            modelBuilder.Entity<PowerList>(entity =>
            {
                entity.ToTable("PowerList");

                entity.Property(e => e.PowerListId).HasColumnName("PowerListID");

                entity.Property(e => e.PowerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PowerNum)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PowerRole>(entity =>
            {
                entity.ToTable("PowerRole");

                entity.Property(e => e.PowerRoleId).HasColumnName("PowerRoleID");

                entity.Property(e => e.AdminRoleId).HasColumnName("AdminRoleID");

                entity.Property(e => e.PowerListId).HasColumnName("PowerListID");
            });

            modelBuilder.Entity<PrintCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PrintCard");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idprint)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDPrint");

                entity.Property(e => e.NamePrint).HasMaxLength(50);

                entity.Property(e => e.TimePrint).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProcMer>(entity =>
            {
                entity.HasKey(e => e.ProcId);

                entity.ToTable("ProcMer");

                entity.Property(e => e.ProcId).HasColumnName("ProcID");

                entity.Property(e => e.Act)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(50);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ProcessCarPass>(entity =>
            {
                entity.HasKey(e => e.Idpress);

                entity.ToTable("ProcessCarPass");

                entity.Property(e => e.Idpress).HasColumnName("IDPress");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Memo).HasMaxLength(100);

                entity.Property(e => e.ParaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductOpportunitiesCust>(entity =>
            {
                entity.ToTable("ProductOpportunitiesCust");

                entity.Property(e => e.ProductOpportunitiesCustId).HasColumnName("ProductOpportunitiesCustID");

                entity.Property(e => e.Other)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductOppId).HasColumnName("ProductOppID");

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");
            });

            modelBuilder.Entity<ProductOpportunity>(entity =>
            {
                entity.HasKey(e => e.ProductOppId)
                    .HasName("PK_PRODUCTOPPORTUNITIES");

                entity.Property(e => e.ProductOppId).HasColumnName("ProductOppID");

                entity.Property(e => e.ProductOpportunitiesName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profier2013051010>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__Profier201305101__5F0DF06A");

                entity.ToTable("Profier2013051010");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasMaxLength(128)
                    .HasColumnName("NTUserName");

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<Profiler2013050922>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__Profiler20130509__5C3183BF");

                entity.ToTable("Profiler2013050922");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasMaxLength(128)
                    .HasColumnName("NTUserName");

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<QiMeiEmployeeExamine>(entity =>
            {
                entity.HasKey(e => e.TwemployeeId);

                entity.ToTable("QiMeiEmployeeExamine");

                entity.Property(e => e.TwemployeeId).HasColumnName("TWEmployeeID");

                entity.Property(e => e.Bg)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BG");

                entity.Property(e => e.Bu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BU");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.EnterDate).HasColumnType("datetime");

                entity.Property(e => e.Leavel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Legal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Post)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QiMeiTwEmloyeeUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QiMeiTwEmloyeeUpdate");

                entity.Property(e => e.Code)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.EnterDate).HasColumnType("datetime");

                entity.Property(e => e.Leavel)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Legal)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.MingZi)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Post)
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.WhetherJob)
                    .HasMaxLength(46)
                    .IsUnicode(false);

                entity.Property(e => e.XingShi)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QuitApply>(entity =>
            {
                entity.ToTable("QuitApply");

                entity.Property(e => e.QuitApplyId).HasColumnName("QuitApplyID");

                entity.Property(e => e.Annex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.Property(e => e.ApplyPeople)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CredNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReceivingCarPass>(entity =>
            {
                entity.HasKey(e => e.ReceiveId);

                entity.ToTable("ReceivingCarPass");

                entity.Property(e => e.ReceiveId).HasColumnName("ReceiveID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivePeople)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReceivingRecord>(entity =>
            {
                entity.HasKey(e => e.ReceiveId)
                    .HasName("PK_RECEIVINGRECORDS");

                entity.Property(e => e.ReceiveId).HasColumnName("ReceiveID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivePeople)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReceptionProgram>(entity =>
            {
                entity.HasKey(e => e.ReceptionId)
                    .HasName("PK_RECEPTIONPROGRAM");

                entity.ToTable("ReceptionProgram");

                entity.Property(e => e.ReceptionId).HasColumnName("ReceptionID");

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.ReceptionContent).HasMaxLength(500);

                entity.Property(e => e.ReceptionPeople).HasMaxLength(50);

                entity.Property(e => e.ReceptionTime).HasColumnType("datetime");

                entity.Property(e => e.VisitNotCustId).HasColumnName("VisitNotCustID");
            });

            modelBuilder.Entity<ReceptionProgramGovernment>(entity =>
            {
                entity.HasKey(e => e.ReceptionId)
                    .HasName("PK_RECEPTIONPROGRAMGOVERNMENT");

                entity.ToTable("ReceptionProgramGovernment");

                entity.Property(e => e.ReceptionId).HasColumnName("ReceptionID");

                entity.Property(e => e.ReceptionManagePosition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptionPlace)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptionPosition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptionTime).HasColumnType("datetime");

                entity.Property(e => e.VisitGlistId).HasColumnName("VisitGListID");
            });

            modelBuilder.Entity<RecovertRecord>(entity =>
            {
                entity.HasKey(e => e.RecovertId)
                    .HasName("PK_RECOVERTRECORDS");

                entity.Property(e => e.RecovertId).HasColumnName("RecovertID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.InvalidId).HasColumnName("InvalidID");

                entity.Property(e => e.Reasons)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RecovertTime).HasColumnType("datetime");

                entity.HasOne(d => d.Invalid)
                    .WithMany(p => p.RecovertRecords)
                    .HasForeignKey(d => d.InvalidId)
                    .HasConstraintName("FK_RECOVERT_REFERENCE_INVALIDR");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Region");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.RegionName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RegionHouse>(entity =>
            {
                entity.ToTable("RegionHouse");

                entity.Property(e => e.RegionHouseId).HasColumnName("RegionHouseID");

                entity.Property(e => e.AreaRegionId).HasColumnName("AreaRegionID");

                entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            });

            modelBuilder.Entity<RemandRecord>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.Dept)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuitApplyId).HasColumnName("QuitApplyID");

                entity.Property(e => e.Reasons)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemandId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RemandID");

                entity.Property(e => e.RemandTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Request114>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Request114");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.BuCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContentRequest).HasMaxLength(300);

                entity.Property(e => e.EmpNameApp).HasMaxLength(50);

                entity.Property(e => e.EmpNoApp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NotesApp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Posision).HasMaxLength(50);

                entity.Property(e => e.UnitApp).HasMaxLength(50);
            });

            modelBuilder.Entity<Request114Sign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Request114Sign");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<RequestProc114>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RequestProc114");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProcID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.WorkTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<RequestStatus114>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RequestStatus114");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("StatusID");

                entity.Property(e => e.WorkTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SchedulePlan>(entity =>
            {
                entity.HasKey(e => e.ScheduleId)
                    .HasName("PK_SCHEDULEPLAN");

                entity.ToTable("SchedulePlan");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.Dept).HasMaxLength(100);

                entity.Property(e => e.Preparation).HasMaxLength(100);

                entity.Property(e => e.ReceptionPeople).HasMaxLength(50);

                entity.Property(e => e.ScheduleTime).HasColumnType("datetime");

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");

                entity.Property(e => e.VisitLeavel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitStress).HasMaxLength(200);
            });

            modelBuilder.Entity<ScrapCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ScrapCar");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.BgId).HasColumnName("BgID");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardChange)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateEmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CreateEmpID");

                entity.Property(e => e.CreateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatePhoneNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DateTimeIn).HasColumnType("datetime");

                entity.Property(e => e.DriverId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DriverID");

                entity.Property(e => e.DriverName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndTimeValid).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LocationDetail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.StartTimeValid).HasColumnType("datetime");
            });

            modelBuilder.Entity<ScrapCarAuthority>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ScrapCarAuthority");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.BgId).HasColumnName("BgID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmpID");

                entity.Property(e => e.EmpNameT).HasMaxLength(100);

                entity.Property(e => e.EmpNameV).HasMaxLength(100);

                entity.Property(e => e.EmpNoUpdate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Endtime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.ParaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RuleName).HasMaxLength(100);

                entity.Property(e => e.ScrapAuthorityId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ScrapAuthorityID");
            });

            modelBuilder.Entity<ScrapCarContructorAuthority>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ScrapCarContructor_Authority");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AuthorityId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AuthorityID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.EmLoyeeNameV)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpLoyeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.NameAbevation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZaloId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZaloID");
            });

            modelBuilder.Entity<ScrapCarGaReject>(entity =>
            {
                entity.ToTable("ScrapCar_GaReject");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.EmpNoId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmpNoID");

                entity.Property(e => e.Idpl).HasColumnName("IDPL");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScrapCarHistoryCheckPass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ScrapCar_HistoryCheckPass");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Idpl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDPL");

                entity.Property(e => e.PartPass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Passtime).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScrapCarIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ScrapCarIn");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.CarImage01)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardChange)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreaatePhoneNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDepartment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateEmail).HasMaxLength(100);

                entity.Property(e => e.CreateEmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CreateEmpID");

                entity.Property(e => e.CreateName).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DatetimeUpdate).HasColumnType("datetime");

                entity.Property(e => e.DatetimeUse).HasColumnType("datetime");

                entity.Property(e => e.DetailLocation).HasMaxLength(200);

                entity.Property(e => e.DriverId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DriverID");

                entity.Property(e => e.DriverName).HasMaxLength(100);

                entity.Property(e => e.EndTimeValid).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.PartParaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartPass).HasMaxLength(50);

                entity.Property(e => e.ScrapCarContructorId).HasColumnName("ScrapCarContructorID");

                entity.Property(e => e.StartTimeValid).HasColumnType("datetime");

                entity.Property(e => e.WeightsImage01)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScrapContructorIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ScrapContructorIn");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ContructorId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContructorID");

                entity.Property(e => e.ContructorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CreateID");

                entity.Property(e => e.CreateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatePhoneNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DatetimeSign).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IpSign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoteSign)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TimeUse).HasColumnType("date");
            });

            modelBuilder.Entity<ScrapContructorInListDriver>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ScrapContructorIn_ListDriver");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DriverID");

                entity.Property(e => e.DriverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ScrapContructorId).HasColumnName("ScrapContructorID");
            });

            modelBuilder.Entity<ScrapInconstant>(entity =>
            {
                entity.ToTable("ScrapInconstant");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmpNameApp).HasMaxLength(50);

                entity.Property(e => e.EmpNoApp)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileInc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idpl).HasColumnName("IDPL");

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.TimeApplication).HasColumnType("datetime");
            });

            modelBuilder.Entity<ScrapInconstantAuthor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ScrapInconstantAuthor");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.TimeAdd).HasColumnType("datetime");

                entity.Property(e => e.TimeDelete).HasColumnType("datetime");
            });

            modelBuilder.Entity<ScrapList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ScrapList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idlist)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDList");

                entity.Property(e => e.Plcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PLCode")
                    .IsFixedLength();

                entity.Property(e => e.Plname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PLName");

                entity.Property(e => e.Unit)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScrapOut>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ScrapOut");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.EndTimePutToScalse).HasColumnType("datetime");

                entity.Property(e => e.FilePdf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idin).HasColumnName("IDIN");

                entity.Property(e => e.Idpl)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDPL");

                entity.Property(e => e.Image1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageScrap)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTimePutToScale).HasColumnType("datetime");

                entity.Property(e => e.UserTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScrapOutProc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ScrapOutProc");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Idpl).HasColumnName("IDPL");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.ProcId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProcID");

                entity.Property(e => e.RuleName).HasMaxLength(100);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ScrapOutStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ScrapOutStatus");

                entity.Property(e => e.EmpName).HasMaxLength(100);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Idpl).HasColumnName("IDPL");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RuleName).HasMaxLength(100);

                entity.Property(e => e.StatusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("StatusID");

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SeMerTransfer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SeMerTransfer");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SeID");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");
            });

            modelBuilder.Entity<SecuretyTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SecuretyTable");

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(50);

                entity.Property(e => e.SecuretyId).ValueGeneratedOnAdd();

                entity.Property(e => e.TimeIn).HasColumnType("datetime");
            });

            modelBuilder.Entity<SecurityError>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SecurityError");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ider)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDEr");

                entity.Property(e => e.NameEr).HasMaxLength(300);

                entity.Property(e => e.PeopleWork).HasMaxLength(50);

                entity.Property(e => e.PosisionErr).HasMaxLength(300);

                entity.Property(e => e.SecurityName).HasMaxLength(100);

                entity.Property(e => e.TimeEr).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(200);
            });

            modelBuilder.Entity<SecurityInfor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SecurityInfor");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.BirthDay).HasColumnType("datetime");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.DateIn).HasColumnType("datetime");

                entity.Property(e => e.FileAtt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Idpeople)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDPeople");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PosisionWork).HasMaxLength(100);
            });

            modelBuilder.Entity<SecurityList>(entity =>
            {
                entity.ToTable("SecurityList");

                entity.Property(e => e.SecurityListId).HasColumnName("SecurityListID");

                entity.Property(e => e.AccidentContent)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AccidentDept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccidentPeople)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccidentPlace)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccidentTime).HasColumnType("datetime");

                entity.Property(e => e.AccidentTypeId).HasColumnName("AccidentTypeID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BG");

                entity.Property(e => e.DealType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fileupload).HasMaxLength(100);

                entity.Property(e => e.Information)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Progress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsePeople)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SecurityProcess>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SecurityProcess");

                entity.Property(e => e.Forfeit).HasMaxLength(50);

                entity.Property(e => e.Ider).HasColumnName("IDEr");

                entity.Property(e => e.Idsol)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDSol");

                entity.Property(e => e.Purpose).HasMaxLength(100);

                entity.Property(e => e.SolutionName).HasMaxLength(300);
            });

            modelBuilder.Entity<SecurityReport>(entity =>
            {
                entity.ToTable("SecurityReport");

                entity.Property(e => e.SecurityReportId).HasColumnName("SecurityReportID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.SignMail)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SignMeno)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SignName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SecurityReportSigner>(entity =>
            {
                entity.ToTable("SecurityReportSigner");

                entity.Property(e => e.SecurityReportSignerId).HasColumnName("SecurityReportSignerID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Meno).IsUnicode(false);

                entity.Property(e => e.SignEmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SignName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SecurityTrain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SecurityTrain");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idtr)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDTr");

                entity.Property(e => e.PeopleTrain).HasMaxLength(50);

                entity.Property(e => e.TimeTrain).HasColumnType("datetime");

                entity.Property(e => e.TrainContent).HasMaxLength(400);

                entity.Property(e => e.Type).HasMaxLength(100);
            });

            modelBuilder.Entity<SendSm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SendSMS");

                entity.Property(e => e.Content).HasMaxLength(200);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber).HasMaxLength(15);

                entity.Property(e => e.SendFlagMemo).HasMaxLength(100);

                entity.Property(e => e.SendSmsid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SendSMSID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SerialNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SerialNumber");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SerialNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SerialNumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<Sheet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet1$");

                entity.Property(e => e.Arearegionid).HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.Meno)
                    .HasMaxLength(255)
                    .HasColumnName("meno");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ShuttleVisitor>(entity =>
            {
                entity.HasKey(e => e.ShuttleVisitorsId)
                    .HasName("PK_SHUTTLEVISITORS");

                entity.Property(e => e.ShuttleVisitorsId).HasColumnName("ShuttleVisitorsID");

                entity.Property(e => e.Destination)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShuttleEndTime).HasColumnType("datetime");

                entity.Property(e => e.ShuttlePeople)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShuttleStartTime).HasColumnType("datetime");

                entity.Property(e => e.ShuttleTime).HasColumnType("datetime");

                entity.Property(e => e.StartJourney)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");
            });

            modelBuilder.Entity<SigStatusChemistry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SigStatusChemistry");

                entity.Property(e => e.ChemistryFormId).HasColumnName("ChemistryFormID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Meno).HasMaxLength(500);

                entity.Property(e => e.SignedStDate).HasColumnType("datetime");

                entity.Property(e => e.SignerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SignerID");

                entity.Property(e => e.SignerName).HasMaxLength(50);

                entity.Property(e => e.SignerNameV).HasMaxLength(50);
            });

            modelBuilder.Entity<SigStatusChemistry1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SigStatusChemistry", "faceid");

                entity.Property(e => e.ChemistryFormId).HasColumnName("ChemistryFormID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Meno).HasMaxLength(500);

                entity.Property(e => e.SignedStDate).HasColumnType("date");

                entity.Property(e => e.SignerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SignerID");

                entity.Property(e => e.SignerName).HasMaxLength(50);
            });

            modelBuilder.Entity<SignLog>(entity =>
            {
                entity.ToTable("SignLog");

                entity.Property(e => e.SignLogId).HasColumnName("SignLogID");

                entity.Property(e => e.FormstatusId).HasColumnName("FormstatusID");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Meno)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RollbackId).HasColumnName("RollbackID");

                entity.Property(e => e.SignDae).HasColumnType("datetime");

                entity.Property(e => e.SignResult)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SignProcess>(entity =>
            {
                entity.HasKey(e => e.SignProcessId)
                    .HasName("PK_SIGNPROCESS");

                entity.ToTable("SignProcess");

                entity.HasIndex(e => e.Id, "NIDX_ID01");

                entity.HasIndex(e => e.IsDeleted, "NIDX_IsDeleted01");

                entity.HasIndex(e => e.IsUnderWriteFlow, "NIDX_IsUnderWriteFlow01");

                entity.HasIndex(e => e.TypeId, "NIDX_TypeID01");

                entity.Property(e => e.SignProcessId).HasColumnName("SignProcessID");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SignAct)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SignMeno)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SignTime).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<SignRole>(entity =>
            {
                entity.ToTable("SignRole");

                entity.Property(e => e.SignRoleId).HasColumnName("SignRoleID");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleEmp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SignStatus>(entity =>
            {
                entity.HasKey(e => e.SignStatusId)
                    .HasName("PK_SIGNSTATUS");

                entity.ToTable("SignStatus");

                entity.Property(e => e.SignStatusId).HasColumnName("SignStatusID");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Meno)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RandomNum)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SignPicture)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SignTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SpareCar>(entity =>
            {
                entity.ToTable("SpareCar");

                entity.Property(e => e.SpareCarId).HasColumnName("SpareCarID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DriverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpareCarReport>(entity =>
            {
                entity.ToTable("SpareCarReport");

                entity.Property(e => e.SpareCarReportId).HasColumnName("SpareCarReportID");

                entity.Property(e => e.CreatTime).HasColumnType("datetime");

                entity.Property(e => e.SpareCarId).HasColumnName("SpareCarID");

                entity.HasOne(d => d.SpareCar)
                    .WithMany(p => p.SpareCarReports)
                    .HasForeignKey(d => d.SpareCarId)
                    .HasConstraintName("FK_SPARECAR_REFERENCE_SPARECAR");
            });

            modelBuilder.Entity<StatusMer>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("StatusMer");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(50);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<SupplementaryInfo>(entity =>
            {
                entity.ToTable("SupplementaryInfo");

                entity.Property(e => e.SupplementaryInfoId).HasColumnName("SupplementaryInfoID");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bu)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BU");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.EnglishName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Files)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasComment("1車輛，2為門禁簽核權限");

                entity.HasOne(d => d.Bg)
                    .WithMany(p => p.SupplementaryInfos)
                    .HasForeignKey(d => d.Bgid)
                    .HasConstraintName("FK_SUPPLEME_REFERENCE_BG");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Supplier");

                entity.Property(e => e.BitImage).HasColumnType("image");

                entity.Property(e => e.NChNname)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("N_ChNName");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.VendorCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Contact");

                entity.Property(e => e.ContactBg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContactBG");

                entity.Property(e => e.ContactPeople)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitExtension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewApplyPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.Zid).HasColumnName("ZID");
            });

            modelBuilder.Entity<TemporaryCredential>(entity =>
            {
                entity.HasKey(e => e.TemporaryCredentialsId)
                    .HasName("PK_TemporaryCredentials_1");

                entity.Property(e => e.TemporaryCredentialsId).HasColumnName("TemporaryCredentialsID");

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.ApplicationType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AreaRegionId).HasColumnName("AreaRegionID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bu)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Build)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Content)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Dept)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FactoryDoor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Floor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LedPeople)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Office)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptionDept)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptionExt)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptionPeople)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UserMemberId).HasColumnName("UserMemberID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TemporaryCredentials)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_TEMPORAR_REFERENCE_COMPANY");
            });

            modelBuilder.Entity<TestTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_table");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Mathe)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(200);

                entity.Property(e => e.Thoigian).HasColumnType("datetime");
            });

            modelBuilder.Entity<TestTableSentdata1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_Table_Sentdata1");

                entity.Property(e => e.Data)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data");

                entity.Property(e => e.DataDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dataDate");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TestTableSentdata2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_Table_Sentdata2");

                entity.Property(e => e.Data)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<TestUploadImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TestUploadImage");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TestImage).HasColumnType("image");
            });

            modelBuilder.Entity<ToPrint>(entity =>
            {
                entity.HasKey(e => e.ToPrintId);

                entity.ToTable("ToPrint");

                entity.Property(e => e.ToPrintId).HasColumnName("ToPrintID");

                entity.Property(e => e.ApplyMeno)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SignAction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.SignMeno)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<TotalType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("TotalType");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.Meno)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TroubleImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TroubleImage");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Idtrouble).HasColumnName("IDTrouble");

                entity.Property(e => e.ImageTrouble)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TroubleType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TroubleType");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TroubleNameCn)
                    .HasMaxLength(50)
                    .HasColumnName("TroubleNameCN");

                entity.Property(e => e.TroubleNameVn)
                    .HasMaxLength(100)
                    .HasColumnName("TroubleNameVN");
            });

            modelBuilder.Entity<TtCorona2019ByBg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TT_Corona2019ByBG");

                entity.Property(e => e.Area)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bgid).HasColumnName("BGid");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dvsn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DVSN");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.RaKtx).HasColumnName("RaKTX");

                entity.Property(e => e.TheodoiKtx).HasColumnName("TheodoiKTX");
            });

            modelBuilder.Entity<TtDichCorona2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TT_DichCorona2020");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.RaKtx).HasColumnName("RaKTX");

                entity.Property(e => e.TheodoiKtx).HasColumnName("TheodoiKTX");
            });

            modelBuilder.Entity<Ttt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TTT");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DoorPowerManageId).HasColumnName("DoorPowerManageID");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Twemployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TWEmployee");

                entity.Property(e => e.Bg)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BG");

                entity.Property(e => e.Bu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BU");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dept).HasMaxLength(120);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.EnterDate).HasColumnType("datetime");

                entity.Property(e => e.Leavel)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Legal)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(240);

                entity.Property(e => e.Post)
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TwemployeeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TWEmployeeID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TwemployeeBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TWEmployeeBack");

                entity.Property(e => e.Bg)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BG");

                entity.Property(e => e.Bu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BU");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.EnterDate).HasColumnType("datetime");

                entity.Property(e => e.Leavel)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Legal)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.Post)
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TwemployeeId).HasColumnName("TWEmployeeID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TwemployeeUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TWEmployeeUpdate");

                entity.Property(e => e.Bg)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BG");

                entity.Property(e => e.Bu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BU");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.EnterDate).HasColumnType("datetime");

                entity.Property(e => e.Leavel)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Legal)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.Post)
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TwemployeeId).HasColumnName("TWEmployeeID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TwemployeeUpdateBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TWEmployeeUpdateBack");

                entity.Property(e => e.Bg)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BG");

                entity.Property(e => e.Bu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BU");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.EnterDate).HasColumnType("datetime");

                entity.Property(e => e.Leavel)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Legal)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.Post)
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TwemployeeId).HasColumnName("TWEmployeeID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TypeConfig>(entity =>
            {
                entity.ToTable("TypeConfig");

                entity.Property(e => e.TypeConfigId).HasColumnName("TypeConfigID");

                entity.Property(e => e.Meno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeConfigName).HasMaxLength(50);
            });

            modelBuilder.Entity<UnderWriteFlow>(entity =>
            {
                entity.HasKey(e => e.UnderWriteFlowId)
                    .HasName("PK_UNDERWRITEFLOW");

                entity.ToTable("UnderWriteFlow");

                entity.Property(e => e.UnderWriteFlowId).HasColumnName("UnderWriteFlowID");

                entity.Property(e => e.CreateEmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Leavel).HasColumnName("leavel");

                entity.Property(e => e.Meno)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.ParameterCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.UnderWriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UnderWriteModel>(entity =>
            {
                entity.ToTable("UnderWriteModel");

                entity.Property(e => e.UnderWriteModelId).HasColumnName("UnderWriteModelID");

                entity.Property(e => e.ModeMeno)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModelName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnderWriteFlowId).HasColumnName("UnderWriteFlowID");
            });

            modelBuilder.Entity<UnderWriteNoClosed>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UnderWriteNoClosed");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("carNumber");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CertifiCateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.WorkType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnderWriteRecord>(entity =>
            {
                entity.ToTable("UnderWriteRecord");

                entity.Property(e => e.UnderWriteRecordId).HasColumnName("UnderWriteRecordID");

                entity.Property(e => e.Meno)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.Result)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.UnderWriteFlowId).HasColumnName("UnderWriteFlowID");
            });

            modelBuilder.Entity<UnderWriteType>(entity =>
            {
                entity.ToTable("UnderWriteType");

                entity.Property(e => e.UnderWriteTypeId).HasColumnName("UnderWriteTypeID");

                entity.Property(e => e.UnderWriteTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Untitled3>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__Untitled - 3__473666D9");

                entity.ToTable("Untitled - 3", "db_owner");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasMaxLength(128)
                    .HasColumnName("NTUserName");

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<UpdateScrap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UpdateScrap");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Idin).HasColumnName("IDIn");

                entity.Property(e => e.Image1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Url>(entity =>
            {
                entity.HasKey(e => e.UrlLid)
                    .HasName("PK_URL");

                entity.ToTable("Url");

                entity.Property(e => e.UrlLid).HasColumnName("UrlLID");

                entity.Property(e => e.Url1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Url");

                entity.Property(e => e.UrlTitel)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserBeforeLoding>(entity =>
            {
                entity.ToTable("UserBeforeLoding");

                entity.Property(e => e.UserBeforeLodingId).HasColumnName("UserBeforeLodingID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bucode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUCode");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<UserIdzalo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserIDZalo");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<UserMember>(entity =>
            {
                entity.ToTable("UserMember");

                entity.Property(e => e.UserMemberId).HasColumnName("UserMemberID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.Ext)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RePwdTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<VCarWhiteInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CarWhiteInfo");

                entity.Property(e => e.CarNumber).HasMaxLength(255);

                entity.Property(e => e.Credentialstype)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("credentialstype");
            });

            modelBuilder.Entity<VNewNcarToDriver>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_NewNCarToDriver");

                entity.Property(e => e.Carcardid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("carcardid");

                entity.Property(e => e.Carcardno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("carcardno");

                entity.Property(e => e.Carlicense)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("carlicense");

                entity.Property(e => e.Driveridno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("driveridno");

                entity.Property(e => e.Drivername)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("drivername");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Fp1).HasColumnName("fp1");

                entity.Property(e => e.Fp2).HasColumnName("fp2");

                entity.Property(e => e.Fp3).HasColumnName("fp3");

                entity.Property(e => e.Fp4).HasColumnName("fp4");

                entity.Property(e => e.Usercardid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usercardid");

                entity.Property(e => e.Usercardno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usercardno");
            });

            modelBuilder.Entity<VeQuestionnaire>(entity =>
            {
                entity.HasKey(e => e.QuestionnaireId);

                entity.ToTable("VeQuestionnaire");

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.Building).HasMaxLength(50);

                entity.Property(e => e.CarNumber).HasMaxLength(50);

                entity.Property(e => e.EmployeeNo).HasMaxLength(50);

                entity.Property(e => e.Filepath).HasMaxLength(500);

                entity.Property(e => e.Isdelete).HasColumnName("ISDelete");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Reason).HasMaxLength(500);

                entity.Property(e => e.Result).HasMaxLength(50);
            });

            modelBuilder.Entity<VehicleCardRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VehicleCardRecord");

                entity.Property(e => e.Bak)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BAK");

                entity.Property(e => e.CarBrand)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CarType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DriverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleImportRecordFstTier>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VehicleImportRecord_FstTier");

                entity.Property(e => e.Bak)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("BAK");

                entity.Property(e => e.CarNum)
                    .HasMaxLength(4000)
                    .HasColumnName("car_num");

                entity.Property(e => e.Id)
                    .HasMaxLength(16)
                    .HasColumnName("ID");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("imagePath");

                entity.Property(e => e.OpenState).HasColumnName("openState");

                entity.Property(e => e.SDir)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("S_DIR");

                entity.Property(e => e.Stime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleImportRecordFstTierHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VehicleImportRecord_FstTier_History");

                entity.Property(e => e.Bak)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("BAK");

                entity.Property(e => e.CarNum)
                    .HasMaxLength(4000)
                    .HasColumnName("car_num");

                entity.Property(e => e.Id)
                    .HasMaxLength(16)
                    .HasColumnName("ID");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("imagePath");

                entity.Property(e => e.OpenState).HasColumnName("openState");

                entity.Property(e => e.SDir)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("S_DIR");

                entity.Property(e => e.Stime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleImportRecordFstTierTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VehicleImportRecord_FstTier_Temp");

                entity.Property(e => e.Bak)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("BAK");

                entity.Property(e => e.CarNum)
                    .HasMaxLength(4000)
                    .HasColumnName("car_num");

                entity.Property(e => e.Id)
                    .HasMaxLength(16)
                    .HasColumnName("ID");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("imagePath");

                entity.Property(e => e.OpenState).HasColumnName("openState");

                entity.Property(e => e.SDir)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("S_DIR");

                entity.Property(e => e.Stime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleImportRecordLhaqdm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VehicleImportRecord_LHAQDM");

                entity.Property(e => e.Bak)
                    .HasMaxLength(20)
                    .HasColumnName("BAK");

                entity.Property(e => e.CarNum)
                    .HasMaxLength(4000)
                    .HasColumnName("car_num");

                entity.Property(e => e.Id)
                    .HasMaxLength(16)
                    .HasColumnName("ID");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .HasColumnName("imagePath");

                entity.Property(e => e.OpenState).HasColumnName("openState");

                entity.Property(e => e.SDir)
                    .HasMaxLength(50)
                    .HasColumnName("S_DIR");

                entity.Property(e => e.Stime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehiclePeriod>(entity =>
            {
                entity.ToTable("VehiclePeriod");

                entity.Property(e => e.VehiclePeriodId).HasColumnName("VehiclePeriodID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.IsBeChecked).HasDefaultValueSql("((0))");

                entity.Property(e => e.LotNumberDate).HasColumnType("datetime");

                entity.Property(e => e.VehiclePeriodNo).HasMaxLength(10);

                entity.Property(e => e.VehiclePermitId).HasColumnName("VehiclePermitID");
            });

            modelBuilder.Entity<VehiclePermit>(entity =>
            {
                entity.ToTable("VehiclePermit");

                entity.Property(e => e.VehiclePermitId).HasColumnName("VehiclePermitID");

                entity.Property(e => e.AreaCard)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId)
                    .HasColumnName("AreaID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ArrangeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrangeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrangeTelephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Caption)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CarBrand)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CarType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContractEndDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DriverEmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DriverName).HasMaxLength(50);

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ext)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.File)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameCn)
                    .HasMaxLength(50)
                    .HasColumnName("NameCN");

                entity.Property(e => e.OrtherContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoId).HasColumnName("PhotoID");

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehiclePermitAppend>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VehiclePermitAppend");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ArrangeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrangeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrangeTelephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Caption)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CarBrand)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CarType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContractEndDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DriverEmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DriverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ext)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.File)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrtherContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoId).HasColumnName("PhotoID");

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehiclePermitId).HasColumnName("VehiclePermitID");

                entity.Property(e => e.WorkType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehiclePermitEmployee>(entity =>
            {
                entity.HasKey(e => e.VehiclePermitEid)
                    .HasName("PK_VEHICLEPERMITEMPLOYEE");

                entity.ToTable("VehiclePermitEmployee");

                entity.Property(e => e.VehiclePermitEid).HasColumnName("VehiclePermitEID");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehiclePermitHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VehiclePermitHistory");

                entity.Property(e => e.AreaCard)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ArrangeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrangeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrangeTelephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Caption)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CarBrand)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CarType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContractEndDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DriverEmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DriverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ext)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.File)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameCn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NameCN");

                entity.Property(e => e.OrtherContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoId).HasColumnName("PhotoID");

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehiclePermitId).HasColumnName("VehiclePermitID");

                entity.Property(e => e.WorkType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehiclePermitPhoto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VehiclePermitPhoto");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.PhotoId).HasColumnName("PhotoID");

                entity.Property(e => e.VehiclePermitId).HasColumnName("VehiclePermitID");

                entity.Property(e => e.VehiclePermitPhotoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("VehiclePermitPhotoID");
            });

            modelBuilder.Entity<VehiclePermitValid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VehiclePermitValid");

                entity.Property(e => e.AreaCard)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ArrangeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrangeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArrangeTelephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Caption)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CarBrand)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CarType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardId)
                    .HasColumnName("CardID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContractEndDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DriverEmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DriverName).HasMaxLength(50);

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ext)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.File)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameCn)
                    .HasMaxLength(50)
                    .HasColumnName("NameCN");

                entity.Property(e => e.OrtherContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoId).HasColumnName("PhotoID");

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehiclePermitId).HasColumnName("VehiclePermitID");

                entity.Property(e => e.WorkType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehiclePersonnel>(entity =>
            {
                entity.HasKey(e => e.VehiclePid)
                    .HasName("PK_VEHICLEPERSONNEL");

                entity.Property(e => e.VehiclePid).HasColumnName("VehiclePID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MatchTime).HasColumnType("datetime");

                entity.Property(e => e.RemoveTime).HasColumnType("datetime");

                entity.Property(e => e.VehiclePermitId).HasColumnName("VehiclePermitID");

                entity.HasOne(d => d.VehiclePermit)
                    .WithMany(p => p.VehiclePersonnel)
                    .HasForeignKey(d => d.VehiclePermitId)
                    .HasConstraintName("FK_VEHICLEP_REFERENCE_VEHICLEP");
            });

            modelBuilder.Entity<VehiclesEmployee>(entity =>
            {
                entity.ToTable("VehiclesEmployee");

                entity.Property(e => e.VehiclesEmployeeId).HasColumnName("VehiclesEmployeeID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VendorCardView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VendorCardView");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bill)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CarColor).HasMaxLength(50);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CarTypeOther).HasMaxLength(50);

                entity.Property(e => e.CardArea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CertifiCateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.EmpName).HasMaxLength(100);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExcTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idpeople)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDPeople");

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.ItemImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameAbbreviation)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NameCn)
                    .HasMaxLength(50)
                    .HasColumnName("NameCN");

                entity.Property(e => e.NameVn)
                    .HasMaxLength(50)
                    .HasColumnName("NameVN");

                entity.Property(e => e.TimeApplication).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.WorkTypeName).HasMaxLength(200);
            });

            modelBuilder.Entity<ViTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vi_Test");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Reasons)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemandId).HasColumnName("RemandID");
            });

            modelBuilder.Entity<ViewAllCredential>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AllCredentials");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameAbbreviation)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<ViewAreaRegionByCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AreaRegionByCard");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ViewAreaRegionByCrendential>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AreaRegionByCrendentials");

                entity.Property(e => e.Aidarid)
                    .HasMaxLength(41)
                    .IsUnicode(false)
                    .HasColumnName("AIDARID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ShortRegion)
                    .HasMaxLength(71)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewBg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_BG");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bgname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BGName");
            });

            modelBuilder.Entity<ViewCapassForScrapCaIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CapassForScrapCaIn");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverName).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewCarPass>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewCarPass");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bill)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CarColor).HasMaxLength(50);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CardArea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CertifiCateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExcTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idpeople)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDPeople");

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameAbbreviation)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NameCn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NameCN");

                entity.Property(e => e.NameVn)
                    .HasMaxLength(50)
                    .HasColumnName("NameVN");

                entity.Property(e => e.TimeApplication).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.WorkTypeName)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCardChange>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewCardChange");

                entity.Property(e => e.Applicant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.AreaCard)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialdelayNewId).HasColumnName("CredentialdelayNewID");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTimeNew).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCardNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewCardNumber");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaDon)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCardWithCardId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewCardWithCardID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bill)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CarColor).HasMaxLength(50);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CardArea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CertifiCateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName).HasMaxLength(100);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExcTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idpeople)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDPeople");

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameAbbreviation)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NameCn)
                    .HasMaxLength(50)
                    .HasColumnName("NameCN");

                entity.Property(e => e.NameVn)
                    .HasMaxLength(50)
                    .HasColumnName("NameVN");

                entity.Property(e => e.TimeApplication).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.WorkTypeName).HasMaxLength(200);
            });

            modelBuilder.Entity<ViewColorTypeCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ColorTypeCard");

                entity.Property(e => e.AreaCard)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Idcard).HasColumnName("IDCard");

                entity.Property(e => e.ImageFile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NameCn)
                    .HasMaxLength(50)
                    .HasColumnName("NameCN");

                entity.Property(e => e.WorkTypeNameC).HasMaxLength(200);

                entity.Property(e => e.WorkTypeNameV).HasMaxLength(200);
            });

            modelBuilder.Entity<ViewControlCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ControlCar");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ControlName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(511)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewControlPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ControlPeople");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SourceTag)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("source_tag");
            });

            modelBuilder.Entity<ViewContruc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Contruc");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ContenAction).HasMaxLength(500);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NameConstruc).HasMaxLength(500);

                entity.Property(e => e.Office).HasMaxLength(500);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TimeApplication).HasColumnType("datetime");

                entity.Property(e => e.UnitApplication).HasMaxLength(100);

                entity.Property(e => e.VendorName).HasMaxLength(500);
            });

            modelBuilder.Entity<ViewCredential>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Credentials");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Bill)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("carNumber");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CertifiCateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.WorkType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCredential1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewCredentials");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameAbbreviation)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<ViewCredentialListCardNumAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CredentialListCardNumAll");

                entity.Property(e => e.AdminCreateCardTime).HasColumnType("datetime");

                entity.Property(e => e.AdminSignTime).HasColumnType("datetime");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.AreaCard)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AreaCardNew)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyNewName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyOldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialdelayNewId).HasColumnName("CredentialdelayNewID");

                entity.Property(e => e.EndTimeNew).HasColumnType("datetime");

                entity.Property(e => e.FileAttack)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImageFile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NotesForSign).HasMaxLength(100);

                entity.Property(e => e.ReceivedName).HasMaxLength(100);

                entity.Property(e => e.ReceivedTime).HasColumnType("datetime");

                entity.Property(e => e.Signer)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCustWorkCredential>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CustWorkCredentials");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CensusAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitExtension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnitPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustWorkCredentialsId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CustWorkCredentialsID");

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeNO");

                entity.Property(e => e.File)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.InureStartDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NowAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCaption)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCustomerCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CustomerCard");

                entity.Property(e => e.BitImage).HasColumnType("image");

                entity.Property(e => e.CertifiCateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameAbbreviation)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDoorPowerManageBguser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DoorPowerManageBGUser");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bgname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BGName");

                entity.Property(e => e.BgsetupItemId).HasColumnName("BGSetupItemID");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PowerAdminId).HasColumnName("PowerAdminID");

                entity.Property(e => e.PowerListId).HasColumnName("PowerListID");

                entity.Property(e => e.PowerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PowerNum)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewDriverCardMatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("View_DriverCardMatch");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("UPdateTime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ViewDriverCardMatch1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DriverCardMatch1");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDriverCardMatchTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("View_DriverCardMatchTemp");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewEmployeeCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_EmployeeCar");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CertifiCateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameAbbreviation)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelPhone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("telPhone");
            });

            modelBuilder.Entity<ViewExternalCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ExternalCar");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("carNumber");

                entity.Property(e => e.CertifiCateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameAbbreviation)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelPhone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("telPhone");
            });

            modelBuilder.Entity<ViewIntent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Intent");

                entity.Property(e => e.AuditName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContenAction).HasMaxLength(500);

                entity.Property(e => e.EmpNameApp).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Ida).HasColumnName("IDA");

                entity.Property(e => e.NameAcc)
                    .HasMaxLength(72)
                    .IsUnicode(false);

                entity.Property(e => e.NameConstruc).HasMaxLength(500);

                entity.Property(e => e.NameVendor).HasMaxLength(500);

                entity.Property(e => e.Office).HasMaxLength(500);

                entity.Property(e => e.Posision).HasMaxLength(200);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TimeApplication).HasColumnType("datetime");

                entity.Property(e => e.Timesign)
                    .HasColumnType("datetime")
                    .HasColumnName("timesign");

                entity.Property(e => e.UnitApplication).HasMaxLength(200);
            });

            modelBuilder.Entity<ViewNblacklist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_nblacklist");

                entity.Property(e => e.Applyname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("applyname");

                entity.Property(e => e.Approver)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("approver");

                entity.Property(e => e.Blacktype)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("blacktype");

                entity.Property(e => e.Blid).HasColumnName("blid");

                entity.Property(e => e.Cardid).HasColumnName("cardid");

                entity.Property(e => e.Cardnumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cardnumber");

                entity.Property(e => e.Cardnumber1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cardnumber1");

                entity.Property(e => e.Cardtype)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cardtype");

                entity.Property(e => e.Cause)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cause");

                entity.Property(e => e.Explain)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("explain");

                entity.Property(e => e.Imgurl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("imgurl");

                entity.Property(e => e.Inuredate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("inuredate");

                entity.Property(e => e.Isright)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("isright")
                    .IsFixedLength();

                entity.Property(e => e.Lasteditby)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("lasteditby");

                entity.Property(e => e.Lasteditdt)
                    .HasColumnType("datetime")
                    .HasColumnName("lasteditdt");

                entity.Property(e => e.Oldcardstatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("oldcardstatus");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.Sex)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sex");

                entity.Property(e => e.SourceTag)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("source_tag");
            });

            modelBuilder.Entity<ViewNcarBlackList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_NCarBlackList");

                entity.Property(e => e.Approver)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("approver");

                entity.Property(e => e.Blacktype)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("blacktype");

                entity.Property(e => e.Blid).HasColumnName("blid");

                entity.Property(e => e.Carcolor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("carcolor");

                entity.Property(e => e.Cardid).HasColumnName("cardid");

                entity.Property(e => e.Carlicense)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("carlicense");

                entity.Property(e => e.Carmodel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("carmodel");

                entity.Property(e => e.Cause)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cause");

                entity.Property(e => e.Editdate)
                    .HasColumnType("datetime")
                    .HasColumnName("editdate");

                entity.Property(e => e.Edituser)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("edituser");

                entity.Property(e => e.Explain)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("explain");

                entity.Property(e => e.Inuredate)
                    .HasColumnType("datetime")
                    .HasColumnName("inuredate");

                entity.Property(e => e.Isdelete)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("isdelete");

                entity.Property(e => e.Iseffective)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("iseffective");

                entity.Property(e => e.Oldcardstatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("oldcardstatus");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("remark");
            });

            modelBuilder.Entity<ViewNote>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewNotes");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOldClcard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Old_CLCard");

                entity.Property(e => e.Cardname)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("cardname");

                entity.Property(e => e.Carlicense)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("carlicense");

                entity.Property(e => e.Idno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("idno");
            });

            modelBuilder.Entity<ViewOldNcomeuser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("View_Old_ncomeuser");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cardno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cardno");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ecardno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ecardno");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewOldNcomeuserTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Old_ncomeuserTemp");

                entity.Property(e => e.Cardno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARDNO");

                entity.Property(e => e.Cardnumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cardnumber");

                entity.Property(e => e.Companyname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("companyname");

                entity.Property(e => e.Ecardno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ecardno");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewOldNcomeuserTemp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("View_Old_ncomeuserTemp1");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cardno).HasColumnName("cardno");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ecardno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ecardno");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewOldNcomeuserTemp20141211old>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Old_ncomeuserTemp20141211old");

                entity.Property(e => e.Cardno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARDNO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Cardnumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cardnumber");

                entity.Property(e => e.Companyname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COMPANYNAME");

                entity.Property(e => e.Ecardno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ecardno");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<ViewOldNusercard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("View_Old_nusercard");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cardno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cardno");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ecardno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ecardno");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewOldNusercardTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Old_nusercardTemp");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cardno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cardno");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ecardno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ecardno");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewOldNusercardTemp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("View_Old_nusercardTemp1");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cardno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cardno");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ecardno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ecardno");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewOldZccard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Old_ZCCard");

                entity.Property(e => e.Cardname)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("cardname");

                entity.Property(e => e.Idno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("idno");
            });

            modelBuilder.Entity<ViewOndytyApprove>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OndytyApprove");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaShortName).HasMaxLength(50);

                entity.Property(e => e.EmpName).HasMaxLength(200);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idsign).HasColumnName("IDsign");

                entity.Property(e => e.LocationDetailName).HasMaxLength(2000);

                entity.Property(e => e.LocationId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LocationID");

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.RuleDetailName).HasMaxLength(2000);

                entity.Property(e => e.TimeCheck).HasColumnType("datetime");

                entity.Property(e => e.TrangThai).HasMaxLength(11);
            });

            modelBuilder.Entity<ViewPeopleList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PeopleList");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Idno)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDNo");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewPllistScrapOut>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PLListScrapOut");

                entity.Property(e => e.Idcode).HasColumnName("IDCode");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapId).HasColumnName("ScrapID");

                entity.Property(e => e.TimeUp).HasColumnType("datetime");

                entity.Property(e => e.TypeName).HasMaxLength(100);

                entity.Property(e => e.TypeNameAbre)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViewRentalCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RentalCar");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("carNumber");

                entity.Property(e => e.CertifiCateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameAbbreviation)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelPhone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("telPhone");
            });

            modelBuilder.Entity<ViewSafeCheckHistoryCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SafeCheck_HistoryCheck");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.HistoryCheckbyplantId).HasColumnName("HistoryCheckbyplantID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Image)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MacId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MacID");

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewSafeCheckHistorycheckByPlant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SafeCheck_HistorycheckByPlant");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ViewSafeCheckResultCheckP>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SafeCheck_ResultCheckP");

                entity.Property(e => e.HistoryCheckId).HasColumnName("HistoryCheckID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NameAbevation).HasMaxLength(100);

                entity.Property(e => e.RuleId).HasColumnName("RuleID");
            });

            modelBuilder.Entity<ViewSafeCheckUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SafeCheck_Users");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EditTime).HasColumnType("datetime");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNoCreate)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewScrapCarReceiveMesZalo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ScrapCarReceiveMesZalo");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.BgId).HasColumnName("BgID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmpID");

                entity.Property(e => e.EmpNameT).HasMaxLength(100);

                entity.Property(e => e.EmpNameV).HasMaxLength(100);

                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RuleName).HasMaxLength(100);

                entity.Property(e => e.ScrapAuthorityId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ScrapAuthorityID");

                entity.Property(e => e.ZaloId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ZaloID");
            });

            modelBuilder.Entity<ViewSearchSign>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewSearchSign");

                entity.Property(e => e.EmpNameSign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNoSign)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeApp).HasColumnType("datetime");

                entity.Property(e => e.TimeSign).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.Typename)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("typename");
            });

            modelBuilder.Entity<ViewSmartList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SmartList");

                entity.Property(e => e.EmpName).HasMaxLength(100);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSupplierCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SupplierCard");

                entity.Property(e => e.BitImage).HasColumnType("image");

                entity.Property(e => e.CertifiCateName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameAbbreviation)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSwipingCardCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("View_SwipingCardCheck");

                entity.Property(e => e.AreaId).HasColumnName("areaID");

                entity.Property(e => e.BitImage).HasColumnType("image");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ViewSwipingCardCheckTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SwipingCardCheckTemp");

                entity.Property(e => e.AreaId).HasColumnName("areaID");

                entity.Property(e => e.BitImage).HasColumnType("image");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSwipingCardCheckTemp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("View_SwipingCardCheckTemp1");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.BitImage).HasColumnType("image");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTest01kk>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_test01kk");

                entity.Property(e => e.ComporationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ComporationID");

                entity.Property(e => e.ImExPortProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImExPortProductID");

                entity.Property(e => e.Tatal).HasColumnName("tatal");
            });

            modelBuilder.Entity<ViewTest01kkBuf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_test01kkBuf");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComporationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ComporationID");

                entity.Property(e => e.DriverId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DriverID");

                entity.Property(e => e.DriverName).HasMaxLength(100);

                entity.Property(e => e.ImExPortProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImExPortProductID");
            });

            modelBuilder.Entity<ViewUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewUser");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewVehicleCardCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("View_VehicleCardCheck");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ViewVehicleCardCheck1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VehicleCardCheck1");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewVehicleCardCheckTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("View_VehicleCardCheckTemp");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InureEndDate).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewVehiclePermitEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewVehiclePermitEmployee");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewVendorCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VendorCard");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardArea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardId).HasColumnName("cardID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PersonID");

                entity.Property(e => e.PersonName).HasMaxLength(50);

                entity.Property(e => e.TableName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tableName");
            });

            modelBuilder.Entity<ViewVipCardApp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VipCardApp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.VisitEndTime).HasColumnType("datetime");

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VisitStartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViheWeight>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ViheWeight");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Weight)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VipCarIsOpen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VipCarIsOpen");

                entity.Property(e => e.CarCode).HasMaxLength(10);

                entity.Property(e => e.FormType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IsLimit)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastNo).HasMaxLength(1);

                entity.Property(e => e.Reason)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VipCard>(entity =>
            {
                entity.ToTable("VipCard");

                entity.Property(e => e.VipCardId).HasColumnName("VipCardID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VipCardNum>(entity =>
            {
                entity.ToTable("VipCardNum");

                entity.Property(e => e.VipCardNumId).HasColumnName("VipCardNumID");

                entity.Property(e => e.EndNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VipCardId).HasColumnName("VipCardID");

                entity.HasOne(d => d.VipCard)
                    .WithMany(p => p.VipCardNums)
                    .HasForeignKey(d => d.VipCardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VIPCARDN_REFERENCE_VIPCARDR");
            });

            modelBuilder.Entity<VipCardReceive>(entity =>
            {
                entity.HasKey(e => e.VipCardId)
                    .HasName("PK_VIPCARDRECEIVE");

                entity.ToTable("VipCardReceive");

                entity.Property(e => e.VipCardId).HasColumnName("VipCardID");

                entity.Property(e => e.Bg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BG");

                entity.Property(e => e.Extention)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveCards)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VipDisable>(entity =>
            {
                entity.ToTable("VipDisable");

                entity.Property(e => e.VipDisableId)
                    .ValueGeneratedNever()
                    .HasColumnName("VipDisableID");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteReason)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VipOutCall>(entity =>
            {
                entity.HasKey(e => e.CallId)
                    .HasName("PK_VipCallOut");

                entity.ToTable("VipOutCall");

                entity.Property(e => e.CallId).HasColumnName("CallID");

                entity.Property(e => e.CallTime).HasColumnType("datetime");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<VipcardApplication>(entity =>
            {
                entity.HasKey(e => e.Vipid)
                    .HasName("PK_VIPCARDAPPLICATION");

                entity.ToTable("VIPCardApplication");

                entity.Property(e => e.Vipid).HasColumnName("VIPID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.Extension)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Reason).HasMaxLength(200);

                entity.Property(e => e.ReceptionBg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ReceptionBG");

                entity.Property(e => e.ReceptionDept).HasMaxLength(100);

                entity.Property(e => e.ReceptionPeople).HasMaxLength(50);

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VisitEndTime).HasColumnType("datetime");

                entity.Property(e => e.VisitStartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VisitArrangement>(entity =>
            {
                entity.HasKey(e => e.VisitArrangementsId)
                    .HasName("PK_VISITARRANGEMENTS");

                entity.Property(e => e.VisitArrangementsId).HasColumnName("VisitArrangementsID");

                entity.Property(e => e.AccessContent).HasMaxLength(500);

                entity.Property(e => e.AccessMeno).HasMaxLength(500);

                entity.Property(e => e.AccessTime).HasColumnType("datetime");

                entity.Property(e => e.AccessUnit).HasMaxLength(100);

                entity.Property(e => e.Area)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.VisitNotCustId).HasColumnName("VisitNotCustID");
            });

            modelBuilder.Entity<VisitCar>(entity =>
            {
                entity.ToTable("VisitCar");

                entity.Property(e => e.VisitCarId).HasColumnName("VisitCarID");

                entity.Property(e => e.CarCode).HasMaxLength(10);

                entity.Property(e => e.CarColor).HasMaxLength(10);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.PassNumber).HasMaxLength(20);

                entity.Property(e => e.PassType).HasDefaultValueSql("((2))");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Tel).HasMaxLength(20);
            });

            modelBuilder.Entity<VisitCard>(entity =>
            {
                entity.HasKey(e => e.VisitorCardId);

                entity.ToTable("VisitCard");

                entity.Property(e => e.VisitorCardId)
                    .ValueGeneratedNever()
                    .HasColumnName("VisitorCardID");

                entity.Property(e => e.CardNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Deleteddate)
                    .HasColumnType("datetime")
                    .HasColumnName("deleteddate");

                entity.Property(e => e.Deletedseason)
                    .HasMaxLength(100)
                    .HasColumnName("deletedseason");

                entity.Property(e => e.EcardNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ECardNum");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VisitCredential>(entity =>
            {
                entity.HasKey(e => e.ApplicationId);

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.ApplicationName).HasMaxLength(50);

                entity.Property(e => e.ApplicationType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AreaRegionId).HasColumnName("AreaRegionID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.Bu)
                    .HasMaxLength(100)
                    .HasColumnName("BU");

                entity.Property(e => e.Build).HasMaxLength(50);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dept).HasMaxLength(100);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Filelist).HasMaxLength(50);

                entity.Property(e => e.Floor).HasMaxLength(50);

                entity.Property(e => e.GuideExt)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuideExt1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuideNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuideNo1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuidePeople).HasMaxLength(100);

                entity.Property(e => e.GuidePeople1).HasMaxLength(100);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Office).HasMaxLength(200);

                entity.Property(e => e.ReasonVisit).HasMaxLength(250);

                entity.Property(e => e.ReceptionDept).HasMaxLength(200);

                entity.Property(e => e.ReceptionExt)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptionNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptionPeople).HasMaxLength(100);

                entity.Property(e => e.SignMemo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnitVisit).HasMaxLength(100);
            });

            modelBuilder.Entity<VisitCredentialsProc>(entity =>
            {
                entity.HasKey(e => e.VisitProcId);

                entity.ToTable("VisitCredentialsProc");

                entity.Property(e => e.VisitProcId).HasColumnName("VisitProcID");

                entity.Property(e => e.Act)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.Meno).HasMaxLength(200);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.WorkDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VisitCredentialsStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("VisitCredentialsStatus");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.Emp)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormMeno).HasMaxLength(200);

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitId).HasColumnName("VisitID");

                entity.Property(e => e.WorkTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VisitCustomer>(entity =>
            {
                entity.HasKey(e => e.VisitCustId)
                    .HasName("PK_VISITCUSTOMER");

                entity.ToTable("VisitCustomer");

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");

                entity.Property(e => e.AdviceItem).HasMaxLength(2000);

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.ApplicationUnit).HasMaxLength(100);

                entity.Property(e => e.Filepath).HasMaxLength(1000);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNewCust).HasDefaultValueSql("((0))");

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PosisionCar).HasMaxLength(500);

                entity.Property(e => e.ProductOppId).HasColumnName("ProductOppID");

                entity.Property(e => e.ReceiverNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Traffic)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VipCardId).HasColumnName("VipCardID");

                entity.Property(e => e.VisitAim).HasMaxLength(2000);

                entity.Property(e => e.VisitNatureId).HasColumnName("VisitNatureID");

                entity.Property(e => e.VisitUnits).HasMaxLength(200);
            });

            modelBuilder.Entity<VisitFactory>(entity =>
            {
                entity.HasKey(e => e.FactId)
                    .HasName("PK_VISITFACTORY");

                entity.ToTable("VisitFactory");

                entity.Property(e => e.FactId).HasColumnName("FactID");

                entity.Property(e => e.Area).HasMaxLength(100);

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.ControlMeno).HasMaxLength(200);

                entity.Property(e => e.DetailAddress).HasMaxLength(200);

                entity.Property(e => e.FactoryName).HasMaxLength(50);

                entity.Property(e => e.Meno).HasMaxLength(300);

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");
            });

            modelBuilder.Entity<VisitGovernment>(entity =>
            {
                entity.ToTable("VisitGovernment");

                entity.Property(e => e.VisitGovernmentId).HasColumnName("VisitGovernmentID");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.ApplicationUnit).HasMaxLength(100);

                entity.Property(e => e.Filepath).HasMaxLength(1000);

                entity.Property(e => e.Isdeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalutatoryContent).HasMaxLength(200);

                entity.Property(e => e.SalutatoryPlace)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VipCardId).HasColumnName("VipCardID");

                entity.Property(e => e.VisitAim).HasMaxLength(2000);

                entity.Property(e => e.VisitIssues).HasMaxLength(200);

                entity.Property(e => e.VisitTime).HasColumnType("datetime");

                entity.Property(e => e.VisitUnits).HasMaxLength(200);
            });

            modelBuilder.Entity<VisitGovernmentAdvanced>(entity =>
            {
                entity.ToTable("VisitGovernmentAdvanced");

                entity.Property(e => e.VisitGovernmentAdvancedId).HasColumnName("VisitGovernmentAdvancedID");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.ApplicationUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Applicationleavel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiscussMatters)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Filepath).HasMaxLength(1000);

                entity.Property(e => e.Isdeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MeetingTime).HasColumnType("datetime");

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Problem)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalutatoryContent)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalutatoryPlace)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VipCardId).HasColumnName("VipCardID");

                entity.Property(e => e.VisitAim)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VisitTime).HasColumnType("datetime");

                entity.Property(e => e.VisitUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VisitGovernmentAdvancedList>(entity =>
            {
                entity.HasKey(e => e.VisitGadListId)
                    .HasName("PK_VISITGOVERNMENTADVANCEDLIST");

                entity.ToTable("VisitGovernmentAdvancedList");

                entity.Property(e => e.VisitGadListId).HasColumnName("VisitGAdListID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nature)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.ReceiverNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverTime).HasColumnType("datetime");

                entity.Property(e => e.RemandTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

                entity.Property(e => e.ReturnReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTime).HasColumnType("datetime");

                entity.Property(e => e.VisitAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VisitGovernmentAdvancedId).HasColumnName("VisitGovernmentAdvancedID");

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VisitTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VisitGovernmentList>(entity =>
            {
                entity.HasKey(e => e.VisitGlistId)
                    .HasName("PK_VISITGOVERNMENTLIST");

                entity.ToTable("VisitGovernmentList");

                entity.Property(e => e.VisitGlistId).HasColumnName("VisitGListID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.ReceiverNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverTime).HasColumnType("datetime");

                entity.Property(e => e.RemandTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

                entity.Property(e => e.ReturnReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnTime).HasColumnType("datetime");

                entity.Property(e => e.VisitGovernmentId).HasColumnName("VisitGovernmentID");

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VisitHistory>(entity =>
            {
                entity.ToTable("VisitHistory");

                entity.Property(e => e.VisitHistoryId).HasColumnName("VisitHistoryID");

                entity.Property(e => e.UnderstandDegree)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VisitGovernmentId).HasColumnName("VisitGovernmentID");

                entity.Property(e => e.VisitInformation)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VisitList>(entity =>
            {
                entity.HasKey(e => e.VisitId);

                entity.ToTable("VisitList");

                entity.Property(e => e.VisitId).HasColumnName("VisitID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CardNumer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileSupplie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageVisit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeciId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LeciID");

                entity.Property(e => e.NumberCar)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PassPostId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PassPostID");

                entity.Property(e => e.PeopleId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PeopleID");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Prc72)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRC72");

                entity.Property(e => e.ReasonSupp).HasMaxLength(200);

                entity.Property(e => e.Supplie).HasMaxLength(200);

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");

                entity.Property(e => e.VisitName).HasMaxLength(50);
            });

            modelBuilder.Entity<VisitNature>(entity =>
            {
                entity.ToTable("VisitNature");

                entity.Property(e => e.VisitNatureId).HasColumnName("VisitNatureID");

                entity.Property(e => e.VisitNatureName).HasMaxLength(50);
            });

            modelBuilder.Entity<VisitNatureCust>(entity =>
            {
                entity.ToTable("VisitNatureCust");

                entity.Property(e => e.VisitNatureCustId).HasColumnName("VisitNatureCustID");

                entity.Property(e => e.Other).HasMaxLength(100);

                entity.Property(e => e.VisitCustId).HasColumnName("VisitCustID");

                entity.Property(e => e.VisitNatureId).HasColumnName("VisitNatureID");
            });

            modelBuilder.Entity<VisitNotCust>(entity =>
            {
                entity.ToTable("VisitNotCust");

                entity.Property(e => e.VisitNotCustId).HasColumnName("VisitNotCustID");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.ApplicationUnit).HasMaxLength(200);

                entity.Property(e => e.Filepath).HasMaxLength(1000);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PosisionCar)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VipCardId).HasColumnName("VipCardID");

                entity.Property(e => e.VisitLeavel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VisitNatureId).HasColumnName("VisitNatureID");

                entity.Property(e => e.VisitTime).HasColumnType("datetime");

                entity.Property(e => e.VisitUnits).HasMaxLength(200);

                entity.Property(e => e.WorkItem).HasMaxLength(1000);

                entity.Property(e => e.WorkResult).HasMaxLength(1000);
            });

            modelBuilder.Entity<VisitStatus>(entity =>
            {
                entity.ToTable("VisitStatus");

                entity.Property(e => e.VisitStatusId).HasColumnName("VisitStatusID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WorkTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VisitTimeOutForm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VisitTimeOutForm");

                entity.Property(e => e.Extension)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ReceptionBg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ReceptionBG");

                entity.Property(e => e.ReceptionDept)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptionPeople)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vipid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("VIPID");

                entity.Property(e => e.VisitStartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VisitantCertificate>(entity =>
            {
                entity.ToTable("VisitantCertificate");

                entity.Property(e => e.VisitantCertificateId).HasColumnName("VisitantCertificateID");

                entity.Property(e => e.Bgid).HasColumnName("BGID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.File)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptionDept)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptionExt)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptionPeople)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptionPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Signoff)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.VisitingUnits)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.VisitantCertificates)
                    .HasForeignKey(d => d.CardId)
                    .HasConstraintName("FK_VISITANT_REFERENCE_CARD");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.VisitantCertificates)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_VISITANT_REFERENCE_COMPANY");
            });

            modelBuilder.Entity<Visitor>(entity =>
            {
                entity.HasKey(e => e.VisitorsId)
                    .HasName("PK_Visitors_1");

                entity.Property(e => e.VisitorsId).HasColumnName("VisitorsID");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialsType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Meno)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RemandTime).HasColumnType("datetime");

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.TemporaryCredentialsId).HasColumnName("TemporaryCredentialsID");

                entity.Property(e => e.VisitorsName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCarInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_car_info");

                entity.Property(e => e.CarBrand)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CAR_BRAND");

                entity.Property(e => e.CarColor)
                    .HasMaxLength(20)
                    .HasColumnName("CAR_COLOR");

                entity.Property(e => e.CarNumber).HasMaxLength(20);

                entity.Property(e => e.CardNo)
                    .HasMaxLength(255)
                    .HasColumnName("CARD_NO");

                entity.Property(e => e.CardType)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CARD_TYPE");

                entity.Property(e => e.Cardtype1).HasColumnName("CARDTYPE");

                entity.Property(e => e.Controlstatus).HasColumnName("CONTROLSTATUS");

                entity.Property(e => e.EmpImage)
                    .HasColumnType("image")
                    .HasColumnName("EMP_IMAGE");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .HasColumnName("EMP_NAME");

                entity.Property(e => e.EmpTel)
                    .HasMaxLength(30)
                    .HasColumnName("EMP_TEL");
            });

            modelBuilder.Entity<VwEmpAndCustInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_EmpAndCust_Info");

                entity.Property(e => e.Bg)
                    .HasMaxLength(128)
                    .HasColumnName("BG");

                entity.Property(e => e.Bu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BU");

                entity.Property(e => e.CarNo)
                    .HasMaxLength(10)
                    .HasColumnName("CAR_NO");

                entity.Property(e => e.CardId)
                    .HasMaxLength(384)
                    .HasColumnName("CARD_ID");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CARD_NO");

                entity.Property(e => e.Company)
                    .HasMaxLength(200)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Contrulstatus).HasColumnName("CONTRULSTATUS");

                entity.Property(e => e.Depart)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DEPART");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(240)
                    .HasColumnName("EMP_NAME");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(255)
                    .HasColumnName("EMP_NO");

                entity.Property(e => e.EmpSex)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("EMP_SEX");

                entity.Property(e => e.EnterReason)
                    .HasMaxLength(200)
                    .HasColumnName("ENTER_REASON");

                entity.Property(e => e.Imagedata)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEDATA");

                entity.Property(e => e.Type)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<VwGuiBingCarInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GuiBingCar_info");

                entity.Property(e => e.CarCode).HasMaxLength(10);

                entity.Property(e => e.CarColor).HasMaxLength(10);

                entity.Property(e => e.Cardno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cardno");

                entity.Property(e => e.Cardnumber)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cardnumber");

                entity.Property(e => e.Company)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Ecardno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ecardno");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Tel).HasMaxLength(20);
            });

            modelBuilder.Entity<WebVerson>(entity =>
            {
                entity.ToTable("WebVerson");

                entity.Property(e => e.WebVersonId).HasColumnName("WebVersonID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.WebVersonName).HasMaxLength(50);
            });

            modelBuilder.Entity<WebVisitRecord>(entity =>
            {
                entity.ToTable("WebVisitRecord");

                entity.Property(e => e.WebVisitRecordId).HasColumnName("WebVisitRecordID");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VisitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WeeklyReport>(entity =>
            {
                entity.ToTable("WeeklyReport");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileReport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.TimeUpload).HasColumnType("datetime");
            });

            modelBuilder.Entity<WeiCall>(entity =>
            {
                entity.HasKey(e => e.WeId);

                entity.ToTable("WeiCall");

                entity.Property(e => e.WeId).HasColumnName("WeID");

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.CallTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasMaxLength(300);

                entity.Property(e => e.NameCall).HasMaxLength(60);

                entity.Property(e => e.NameLis).HasMaxLength(60);

                entity.Property(e => e.Result).HasMaxLength(300);
            });

            modelBuilder.Entity<WeightApi>(entity =>
            {
                entity.ToTable("WeightAPI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CarType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idpl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDPL");

                entity.Property(e => e.ImageCar).IsUnicode(false);

                entity.Property(e => e.ImageCarOverall).IsUnicode(false);

                entity.Property(e => e.ImageOfScale)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePerson).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeWeight).HasColumnType("datetime");

                entity.Property(e => e.UnitWeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<WeightApi1>(entity =>
            {
                entity.ToTable("WeightAPI1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CarType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idpl).HasColumnName("IDPL");

                entity.Property(e => e.ImageCar).IsUnicode(false);

                entity.Property(e => e.ImagePerson).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeWeight).HasColumnType("datetime");

                entity.Property(e => e.UnitWeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WeightPo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WeightPO");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TimeAdd).HasColumnType("datetime");
            });

            modelBuilder.Entity<WorkNote>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ApplicationTime).HasColumnType("datetime");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<WorkTypeInFac>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WorkTypeInFac");

                entity.Property(e => e.Meno).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.WorkTypeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("WorkTypeID");

                entity.Property(e => e.WorkTypeNameC).HasMaxLength(200);

                entity.Property(e => e.WorkTypeNameV).HasMaxLength(200);
            });

            modelBuilder.Entity<Yhuhu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YHUHU");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
