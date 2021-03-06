namespace QuickNSmart.Logic.Controllers.Persistence.Account
{
	sealed partial class LoginSessionController : GenericController<QuickNSmart.Contracts.Persistence.Account.ILoginSession, Entities.Persistence.Account.LoginSession>
	{
		static LoginSessionController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public LoginSessionController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public LoginSessionController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
namespace QuickNSmart.Logic.Controllers.Persistence.Account
{
	sealed partial class RoleController : GenericController<QuickNSmart.Contracts.Persistence.Account.IRole, Entities.Persistence.Account.Role>
	{
		static RoleController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public RoleController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public RoleController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
namespace QuickNSmart.Logic.Controllers.Persistence.Account
{
	sealed partial class UserController : GenericController<QuickNSmart.Contracts.Persistence.Account.IUser, Entities.Persistence.Account.User>
	{
		static UserController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public UserController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public UserController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
namespace QuickNSmart.Logic.Controllers.Persistence.Account
{
	sealed partial class UserXRoleController : GenericController<QuickNSmart.Contracts.Persistence.Account.IUserXRole, Entities.Persistence.Account.UserXRole>
	{
		static UserXRoleController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public UserXRoleController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public UserXRoleController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
