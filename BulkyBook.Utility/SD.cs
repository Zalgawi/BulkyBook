using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.Utility
{
    public static class SD
    {
        public const string Proc_CoverType_Create = "usp_CreateCovertype";
        public const string Proc_CoverType_Get = "usp_GetCovertype";
        public const string Proc_CoverType_GetAll = "usp_GetCovertypes";
        public const string Proc_CoverType_Update = "usp_UpdateCovertype";
        public const string Proc_CoverType_Delete = "usp_DeleteCovertype";

        public const string Role_User_Indi = "Individual Customer";
        public const string Role_User_Comp = "Company Customer";
        public const string Role_Admin = "Admin";
        public const string Role_Employee = "Employee";
    }
}
