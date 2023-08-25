using API.Data;
using API.Models;

namespace API._Repositories
{
    public class RepositoryAccessor : IRepositoryAccessor
    {
        private DBContext _context;
        public RepositoryAccessor(DBContext context)
        {
            _context = context;

            AreaLang = new Repository<AreaLang>(_context);
            Area = new Repository<Area>(_context);
            Building = new Repository<Building>(_context);
            BuildLang = new Repository<BuildLang>(_context);
            Category = new Repository<Category>(_context);
            CatLang = new Repository<CatLang>(_context);
            CommentArchive = new Repository<CommentArchive>(_context);
            Company = new Repository<Company>(_context);
            CountAll = new Repository<CountAll>(_context);
            CountArea = new Repository<CountArea>(_context);
            CountBuilding = new Repository<CountBuilding>(_context);
            CountDepartment = new Repository<CountDepartment>(_context);
            CountPart = new Repository<CountPart>(_context);
            DatePickerManager = new Repository<DatePickerManager>(_context);
            DefaultSetting = new Repository<DefaultSetting>(_context);
            Department = new Repository<Department>(_context);
            DetpLang = new Repository<DetpLang>(_context);
            EmailContent = new Repository<EmailContent>(_context);
            Employee = new Repository<Employee>(_context);
            ErrorLog = new Repository<ErrorLog>(_context);
            GroupBase = new Repository<GroupBase>(_context);
            GroupLang = new Repository<GroupLang>(_context);
            HistoryEmp = new Repository<HistoryEmp>(_context);
            Holiday = new Repository<Holiday>(_context);
            LeaveData = new Repository<LeaveData>(_context);
            LeaveLog = new Repository<LeaveLog>(_context);
            LoginDetect = new Repository<LoginDetect>(_context);
            PartLang = new Repository<PartLang>(_context);
            Part = new Repository<Part>(_context);
            Position = new Repository<Position>(_context);
            PosLang = new Repository<PosLang>(_context);
            ReportData = new Repository<ReportData>(_context);
            Roles = new Repository<Roles>(_context);
            RolesUser = new Repository<Roles_User>(_context);
            SetApproveGroupBase = new Repository<SetApproveGroupBase>(_context);
            TempData = new Repository<tempdata>(_context);
            TempUser = new Repository<tempuser>(_context);
            Users = new Repository<Users>(_context);
        }

        public IRepository<AreaLang> AreaLang { get; private set; }
        public IRepository<Area> Area { get; private set; }
        public IRepository<Building> Building { get; private set; }
        public IRepository<BuildLang> BuildLang { get; private set; }
        public IRepository<Category> Category { get; private set; }
        public IRepository<CatLang> CatLang { get; private set; }
        public IRepository<CommentArchive> CommentArchive { get; private set; }
        public IRepository<Company> Company { get; private set; }
        public IRepository<CountAll> CountAll { get; private set; }
        public IRepository<CountArea> CountArea { get; private set; }
        public IRepository<CountBuilding> CountBuilding { get; private set; }
        public IRepository<CountDepartment> CountDepartment { get; private set; }
        public IRepository<CountPart> CountPart { get; private set; }
        public IRepository<DatePickerManager> DatePickerManager { get; private set; }
        public IRepository<DefaultSetting> DefaultSetting { get; private set; }
        public IRepository<Department> Department { get; private set; }
        public IRepository<DetpLang> DetpLang { get; private set; }
        public IRepository<EmailContent> EmailContent { get; private set; }
        public IRepository<Employee> Employee { get; private set; }
        public IRepository<ErrorLog> ErrorLog { get; private set; }
        public IRepository<GroupBase> GroupBase { get; private set; }
        public IRepository<GroupLang> GroupLang { get; private set; }
        public IRepository<HistoryEmp> HistoryEmp { get; private set; }
        public IRepository<Holiday> Holiday { get; private set; }
        public IRepository<LeaveData> LeaveData { get; private set; }
        public IRepository<LeaveLog> LeaveLog { get; private set; }
        public IRepository<LoginDetect> LoginDetect { get; private set; }
        public IRepository<PartLang> PartLang { get; private set; }
        public IRepository<Part> Part { get; private set; }
        public IRepository<Position> Position { get; private set; }
        public IRepository<PosLang> PosLang { get; private set; }
        public IRepository<ReportData> ReportData { get; private set; }
        public IRepository<Roles> Roles { get; private set; }
        public IRepository<Roles_User> RolesUser { get; private set; }
        public IRepository<SetApproveGroupBase> SetApproveGroupBase { get; private set; }
        public IRepository<tempdata> TempData { get; private set; }
        public IRepository<tempuser> TempUser { get; private set; }
        public IRepository<Users> Users { get; private set; }
        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}