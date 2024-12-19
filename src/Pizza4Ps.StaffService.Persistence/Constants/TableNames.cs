using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Persistence.Constants
{
    internal class TableNames
    {
        // *********** Plural Nouns *
        //internal const string Actions = nameof(Actions);
        //internal const string Functions = nameof(Functions);
        //internal const string ActionInFunctions = nameof(ActionInFunctions);
        //internal const string Permissions = nameof(Permissions);

        internal const string AppUsers = nameof(AppUsers);
        internal const string AppRoles = nameof(AppRoles);
        internal const string AppUserRoles = nameof(AppUserRoles);

        internal const string AppUserClaims = nameof(AppUserClaims); // IdentityUserClaim
        internal const string AppRoleClaims = nameof(AppRoleClaims); // IdentityRoleClaim
        internal const string AppUserLogins = nameof(AppUserLogins); // IdentityRoleClaim
        internal const string AppUserTokens = nameof(AppUserTokens); // IdentityUserToken

		internal const string HistorySchedule = nameof(HistorySchedule);
		internal const string IndividualSchedule = nameof(IndividualSchedule);
		internal const string ShiftExchange = nameof(ShiftExchange);
		internal const string Staff = nameof(Staff);
		internal const string Store = nameof(Store);
	}
}
