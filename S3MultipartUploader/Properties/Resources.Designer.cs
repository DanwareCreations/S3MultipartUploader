﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S3MultipartUploader.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("S3MultipartUploader.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap add_profile {
            get {
                object obj = ResourceManager.GetObject("add_profile", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap advanced_options {
            get {
                object obj = ResourceManager.GetObject("advanced_options", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon aws_s3 {
            get {
                object obj = ResourceManager.GetObject("aws_s3", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap bucket {
            get {
                object obj = ResourceManager.GetObject("bucket", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bucket &quot;{0}&quot; selected..
        /// </summary>
        internal static string BucketSelected {
            get {
                return ResourceManager.GetString("BucketSelected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} buckets found..
        /// </summary>
        internal static string BucketsListed {
            get {
                return ResourceManager.GetString("BucketsListed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile Access Key IDs must contain exactly 20 uppercase letters and/or numbers..
        /// </summary>
        internal static string InvalidProfileAccessKeyID {
            get {
                return ResourceManager.GetString("InvalidProfileAccessKeyID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile names must only contain upper and lowercase alphanumeric characters with no spaces, and any of the following characters: =,.@-.
        /// </summary>
        internal static string InvalidProfileName {
            get {
                return ResourceManager.GetString("InvalidProfileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile Secret Access Keys must contain exactly 40 lower and/or uppercase alphanumeric characters with no spaces, forward slashes (&quot;/&quot;), and/or plus signs (&quot;+&quot;)..
        /// </summary>
        internal static string InvalidProfileSecretKey {
            get {
                return ResourceManager.GetString("InvalidProfileSecretKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile names must only contain upper and lowercase alphanumeric characters with no spaces, and any of the following characters:  !-_.*&apos;()/.
        /// </summary>
        internal static string InvalidS3Key {
            get {
                return ResourceManager.GetString("InvalidS3Key", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Listing S3 buckets available to profile {0}....
        /// </summary>
        internal static string ListingBuckets {
            get {
                return ResourceManager.GetString("ListingBuckets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Listing AWS credentials profiles stored on this machine....
        /// </summary>
        internal static string ListingProfiles {
            get {
                return ResourceManager.GetString("ListingProfiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Listing all AWS S3 regions....
        /// </summary>
        internal static string ListingS3Regions {
            get {
                return ResourceManager.GetString("ListingS3Regions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must provide an Access Key ID for the new AWS credentials profile..
        /// </summary>
        internal static string MissingAccessKeyID {
            get {
                return ResourceManager.GetString("MissingAccessKeyID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must select or add an AWS credentials profile..
        /// </summary>
        internal static string MissingProfile {
            get {
                return ResourceManager.GetString("MissingProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must provide a name for the new AWS credentials profile..
        /// </summary>
        internal static string MissingProfileName {
            get {
                return ResourceManager.GetString("MissingProfileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must select an AWS S3 region..
        /// </summary>
        internal static string MissingRegion {
            get {
                return ResourceManager.GetString("MissingRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must select an AWS S3 bucket..
        /// </summary>
        internal static string MissingS3Bucket {
            get {
                return ResourceManager.GetString("MissingS3Bucket", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must provide an S3 key to give this object in the selected bucket..
        /// </summary>
        internal static string MissingS3Key {
            get {
                return ResourceManager.GetString("MissingS3Key", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must provide a Secret Access Key for the new AWS credentials profile..
        /// </summary>
        internal static string MissingSecretAccessKey {
            get {
                return ResourceManager.GetString("MissingSecretAccessKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No files found..
        /// </summary>
        internal static string NoFilesFound {
            get {
                return ResourceManager.GetString("NoFilesFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} files found, but none of them were object parts..
        /// </summary>
        internal static string NoPartsFound {
            get {
                return ResourceManager.GetString("NoPartsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} object parts found..
        /// </summary>
        internal static string NPartsFound {
            get {
                return ResourceManager.GetString("NPartsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1 object part found..
        /// </summary>
        internal static string OnePartFound {
            get {
                return ResourceManager.GetString("OnePartFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} files found, but only {1} of them were object parts..
        /// </summary>
        internal static string OnlyNPartsFound {
            get {
                return ResourceManager.GetString("OnlyNPartsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1 file found, but it wasn&apos;t an object part..
        /// </summary>
        internal static string OnlyOneFileFound {
            get {
                return ResourceManager.GetString("OnlyOneFileFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} files found, but only 1 of them was an object part..
        /// </summary>
        internal static string OnlyOnePartFound {
            get {
                return ResourceManager.GetString("OnlyOnePartFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The selected directory must only contain object parts.  These files are expected to have a numeric extension, e.g. &quot;mydata.zip.003&quot;..
        /// </summary>
        internal static string OnlyPartsAllowed {
            get {
                return ResourceManager.GetString("OnlyPartsAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap pause_upload {
            get {
                object obj = ResourceManager.GetObject("pause_upload", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap profile {
            get {
                object obj = ResourceManager.GetObject("profile", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^[0-9A-Z]{20}$.
        /// </summary>
        internal static string ProfileAccessKeyIDRegex {
            get {
                return ResourceManager.GetString("ProfileAccessKeyIDRegex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile &quot;{0}&quot; added!.
        /// </summary>
        internal static string ProfileAdded {
            get {
                return ResourceManager.GetString("ProfileAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^[0-9a-zA-Z=,.@-]+$.
        /// </summary>
        internal static string ProfileNameRegex {
            get {
                return ResourceManager.GetString("ProfileNameRegex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^[0-9a-zA-Z/+]{40}$.
        /// </summary>
        internal static string ProfileSecretKeyRegex {
            get {
                return ResourceManager.GetString("ProfileSecretKeyRegex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile &quot;{0}&quot; selected..
        /// </summary>
        internal static string ProfileSelected {
            get {
                return ResourceManager.GetString("ProfileSelected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} profiles found..
        /// </summary>
        internal static string ProfilesListed {
            get {
                return ResourceManager.GetString("ProfilesListed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap regions {
            get {
                object obj = ResourceManager.GetObject("regions", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Region &quot;{0}&quot; selected..
        /// </summary>
        internal static string RegionSelected {
            get {
                return ResourceManager.GetString("RegionSelected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap s3_key {
            get {
                object obj = ResourceManager.GetObject("s3_key", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^[0-9a-zA-Z!\-_.*&apos;()/\\]+$.
        /// </summary>
        internal static string S3KeyRegex {
            get {
                return ResourceManager.GetString("S3KeyRegex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} regions listed..
        /// </summary>
        internal static string S3RegionsListed {
            get {
                return ResourceManager.GetString("S3RegionsListed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory selection cancelled..
        /// </summary>
        internal static string SelectDirectoryCancel {
            get {
                return ResourceManager.GetString("SelectDirectoryCancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selected Directory &quot;{0}&quot;..
        /// </summary>
        internal static string SelectDirectorySuccess {
            get {
                return ResourceManager.GetString("SelectDirectorySuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap start_resume_upload {
            get {
                object obj = ResourceManager.GetObject("start_resume_upload", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap stop_upload {
            get {
                object obj = ResourceManager.GetObject("stop_upload", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Before you can start uploading, you must select a credentials profile, region, and bucket, provide an object key, and select the directory with the object&apos;s parts..
        /// </summary>
        internal static string String1 {
            get {
                return ResourceManager.GetString("String1", resourceCulture);
            }
        }
    }
}
