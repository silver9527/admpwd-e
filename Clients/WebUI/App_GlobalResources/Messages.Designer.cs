//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option or rebuild the Visual Studio project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Web.Application.StronglyTypedResourceProxyBuilder", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.Messages", global::System.Reflection.Assembly.Load("App_GlobalResources"));
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encryption Keys Management.
        /// </summary>
        internal static string EKM_EncryptionKeysManagement {
            get {
                return ResourceManager.GetString("EKM_EncryptionKeysManagement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generate New Key.
        /// </summary>
        internal static string EKM_GenerateNewKey {
            get {
                return ResourceManager.GetString("EKM_GenerateNewKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key Size.
        /// </summary>
        internal static string EKM_KeySize {
            get {
                return ResourceManager.GetString("EKM_KeySize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No keys in storage.
        /// </summary>
        internal static string EKM_NoKeysInStorage {
            get {
                return ResourceManager.GetString("EKM_NoKeysInStorage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More than one entry for ComputerName has been found!.
        /// </summary>
        internal static string Errors_ADComputerObjectAmbiguousException {
            get {
                return ResourceManager.GetString("Errors_ADComputerObjectAmbiguousException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Computer object is not available for current User!.
        /// </summary>
        internal static string Errors_ADComputerObjectNotAvailableException {
            get {
                return ResourceManager.GetString("Errors_ADComputerObjectNotAvailableException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password is not stored for the Computer Object!.
        /// </summary>
        internal static string Errors_ADComputerPasswordAttributesAreNull {
            get {
                return ResourceManager.GetString("Errors_ADComputerPasswordAttributesAreNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Computer name has not been found in Active Directory!.
        /// </summary>
        internal static string Errors_ADNoComputerFoundException {
            get {
                return ResourceManager.GetString("Errors_ADNoComputerFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stored password is empty!.
        /// </summary>
        internal static string Errors_BlankPassword {
            get {
                return ResourceManager.GetString("Errors_BlankPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot reset password.
        /// </summary>
        internal static string Errors_CannotResetPassword {
            get {
                return ResourceManager.GetString("Errors_CannotResetPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot retrieve password.
        /// </summary>
        internal static string Errors_CannotRetrievePassword {
            get {
                return ResourceManager.GetString("Errors_CannotRetrievePassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error message.
        /// </summary>
        internal static string Errors_ErrorMessage {
            get {
                return ResourceManager.GetString("Errors_ErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Identificators of keys for the password are not matching..
        /// </summary>
        internal static string Errors_IdentificatorsOfKeysNotMatching {
            get {
                return ResourceManager.GetString("Errors_IdentificatorsOfKeysNotMatching", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot read current user on IIS. Most likely Windows Authentication is not configured on the website..
        /// </summary>
        internal static string Errors_IISAuthentication {
            get {
                return ResourceManager.GetString("Errors_IISAuthentication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified DC is not holding.
        /// </summary>
        internal static string Errors_LDAPGlobalCatalogNotAvailable {
            get {
                return ResourceManager.GetString("Errors_LDAPGlobalCatalogNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More than one entry for current user has been found!.
        /// </summary>
        internal static string Errors_LDAPMoreThanOneEntryFoundException {
            get {
                return ResourceManager.GetString("Errors_LDAPMoreThanOneEntryFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No entries for current user have been found!.
        /// </summary>
        internal static string Errors_LDAPNoEntryFoundException {
            get {
                return ResourceManager.GetString("Errors_LDAPNoEntryFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LDAP service not available.
        /// </summary>
        internal static string Errors_LDAPNotAvailable {
            get {
                return ResourceManager.GetString("Errors_LDAPNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple Computer objects found.
        /// </summary>
        internal static string Errors_MultipleComputerObjectsFound {
            get {
                return ResourceManager.GetString("Errors_MultipleComputerObjectsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are not authorized for this computer object! Full Control permissions are required..
        /// </summary>
        internal static string Errors_NoFullControlForUserOnComputerObject {
            get {
                return ResourceManager.GetString("Errors_NoFullControlForUserOnComputerObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are not authorized to Read Password on this computer.
        /// </summary>
        internal static string Errors_NoReadPasswordForUserOnComputerObject {
            get {
                return ResourceManager.GetString("Errors_NoReadPasswordForUserOnComputerObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are not authorized to Reset Password on this computer.
        /// </summary>
        internal static string Errors_NoResetPasswordForUserOnComputerObject {
            get {
                return ResourceManager.GetString("Errors_NoResetPasswordForUserOnComputerObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not found in LDAP.
        /// </summary>
        internal static string Errors_NotFoundInLDAP {
            get {
                return ResourceManager.GetString("Errors_NotFoundInLDAP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Appropriate Private key file for the password is not present in Portal!.
        /// </summary>
        internal static string Errors_PrivateKeyFileForPasswordNotInPortal {
            get {
                return ResourceManager.GetString("Errors_PrivateKeyFileForPasswordNotInPortal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service is not available.
        /// </summary>
        internal static string Errors_ServiceNotAvailable {
            get {
                return ResourceManager.GetString("Errors_ServiceNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to decrypt the password..
        /// </summary>
        internal static string Errors_UnableToDecrypt {
            get {
                return ResourceManager.GetString("Errors_UnableToDecrypt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to decrypt.
        /// </summary>
        internal static string Errors_UnableToDecryptShort {
            get {
                return ResourceManager.GetString("Errors_UnableToDecryptShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Back to New Password Request.
        /// </summary>
        internal static string Home_BackToNewRequest {
            get {
                return ResourceManager.GetString("Home_BackToNewRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is a web application to recover Admin password for the computer.
        /// </summary>
        internal static string Home_LandingText {
            get {
                return ResourceManager.GetString("Home_LandingText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manage Encryption Keys.
        /// </summary>
        internal static string Home_ManageEncryptionKeys {
            get {
                return ResourceManager.GetString("Home_ManageEncryptionKeys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Admin Password.
        /// </summary>
        internal static string RC_AdminPassword {
            get {
                return ResourceManager.GetString("RC_AdminPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Admin Password Recovery workflow.
        /// </summary>
        internal static string RC_AdminPasswordRecoveryWorkflow {
            get {
                return ResourceManager.GetString("RC_AdminPasswordRecoveryWorkflow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Computer DN.
        /// </summary>
        internal static string RC_ComputerDN {
            get {
                return ResourceManager.GetString("RC_ComputerDN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Computer name.
        /// </summary>
        internal static string RC_ComputerName {
            get {
                return ResourceManager.GetString("RC_ComputerName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expiration Date.
        /// </summary>
        internal static string RC_ExpirationDate {
            get {
                return ResourceManager.GetString("RC_ExpirationDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expiration Date change.
        /// </summary>
        internal static string RC_ExpirationDateChange {
            get {
                return ResourceManager.GetString("RC_ExpirationDateChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expiration date updated.
        /// </summary>
        internal static string RC_ExpirationDateUpdated {
            get {
                return ResourceManager.GetString("RC_ExpirationDateUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forest DNS Name.
        /// </summary>
        internal static string RC_ForestName {
            get {
                return ResourceManager.GetString("RC_ForestName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not valid expiration date.
        /// </summary>
        internal static string RC_NotValidExpirationDate {
            get {
                return ResourceManager.GetString("RC_NotValidExpirationDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password history.
        /// </summary>
        internal static string RC_PasswordHistory {
            get {
                return ResourceManager.GetString("RC_PasswordHistory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Regenerate password after this date.
        /// </summary>
        internal static string RC_RegeneratePasswordAfterDate {
            get {
                return ResourceManager.GetString("RC_RegeneratePasswordAfterDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Submit.
        /// </summary>
        internal static string RC_Submit {
            get {
                return ResourceManager.GetString("RC_Submit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update.
        /// </summary>
        internal static string RC_Update {
            get {
                return ResourceManager.GetString("RC_Update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field [Computer name] is required!.
        /// </summary>
        internal static string RC_Val_FieldComputerNameRequired {
            get {
                return ResourceManager.GetString("RC_Val_FieldComputerNameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Country.
        /// </summary>
        internal static string UIC_Country {
            get {
                return ResourceManager.GetString("UIC_Country", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current User Identification.
        /// </summary>
        internal static string UIC_CurrentUserIdentification {
            get {
                return ResourceManager.GetString("UIC_CurrentUserIdentification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Domain.
        /// </summary>
        internal static string UIC_Domain {
            get {
                return ResourceManager.GetString("UIC_Domain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email.
        /// </summary>
        internal static string UIC_Email {
            get {
                return ResourceManager.GetString("UIC_Email", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Full Name.
        /// </summary>
        internal static string UIC_FullName {
            get {
                return ResourceManager.GetString("UIC_FullName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mobile.
        /// </summary>
        internal static string UIC_Mobile {
            get {
                return ResourceManager.GetString("UIC_Mobile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Navigation.
        /// </summary>
        internal static string UIC_Navigation {
            get {
                return ResourceManager.GetString("UIC_Navigation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Phone.
        /// </summary>
        internal static string UIC_Phone {
            get {
                return ResourceManager.GetString("UIC_Phone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User.
        /// </summary>
        internal static string UIC_User {
            get {
                return ResourceManager.GetString("UIC_User", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User ID.
        /// </summary>
        internal static string UIC_UserID {
            get {
                return ResourceManager.GetString("UIC_UserID", resourceCulture);
            }
        }
    }
}