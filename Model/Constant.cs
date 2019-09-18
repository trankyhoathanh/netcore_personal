using System;
using System.Collections.Generic;
using System.Text;

namespace MicroService.Model
{
    public static class JsonApiStatusCodes
    {
        #region Success
        public static int Default = 001;
        public static int Failed = 100;
        public static int Success = 200;
        public static int Accepted = 202;
        #endregion

        #region ClientErrors
        public static int SessionTimeOut = 701;
        public static int UnAuthorized = 401;
        public static int OtpFailedChecking = 402;
        public static int OtpCheckingSuccess = 999;
        public static int Forbidden = 403;
        public static int UnAcceptable = 406;

        public static int CreateMemberShipUserError = 601;
        #endregion

        #region ServerErrors
        public static int InternalServerError = 500;
        #endregion

        public static string MessageDefault = "Default";
        public static string MessageSucceed = "Succeed";
        public static string MessageSessionTimeOut = "Session Timeout";
        public static string MessageBarCodeValid = "Barcode Valid";
        public static string MessageBarCodeInvalid = "Barcode Invalid";
        public static string MessageVenueInvalid = "Venue Invalid";
        public static string MessageVenueItemsEmpty = "Venue have not products";
        public static string MessageVenueItemsSucceed = "List Products";
        public static string MessageScanSucceed = "Scan Succeed";
        public static string MessageUnAcceptable = "Exception";
    }
}
