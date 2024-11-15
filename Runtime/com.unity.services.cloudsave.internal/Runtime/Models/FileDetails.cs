//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.CloudSave.Internal.Http;



namespace Unity.Services.CloudSave.Internal.Models
{
    /// <summary>
    /// FileDetails model
    /// </summary>
    [Preserve]
    [DataContract(Name = "FileDetails")]
    internal class FileDetails
    {
        /// <summary>
        /// Creates an instance of FileDetails.
        /// </summary>
        /// <param name="contentType">The MIME type of the file that will be uploaded</param>
        /// <param name="contentLength">The content length in bytes of the file that will be uploaded</param>
        /// <param name="contentMd5">The base64 encoded MD5 checksum of the file contents that will be uploaded</param>
        /// <param name="writeLock">The expected writeLock value of the currently stored file</param>
        [Preserve]
        public FileDetails(string contentType, long contentLength, string contentMd5, string writeLock = default)
        {
            ContentType = contentType;
            ContentLength = contentLength;
            ContentMd5 = contentMd5;
            WriteLock = writeLock;
        }

        /// <summary>
        /// The MIME type of the file that will be uploaded
        /// </summary>
        [Preserve]
        [DataMember(Name = "contentType", IsRequired = true, EmitDefaultValue = true)]
        public string ContentType{ get; }

        /// <summary>
        /// The content length in bytes of the file that will be uploaded
        /// </summary>
        [Preserve]
        [DataMember(Name = "contentLength", IsRequired = true, EmitDefaultValue = true)]
        public long ContentLength{ get; }

        /// <summary>
        /// The base64 encoded MD5 checksum of the file contents that will be uploaded
        /// </summary>
        [Preserve]
        [DataMember(Name = "contentMd5", IsRequired = true, EmitDefaultValue = true)]
        public string ContentMd5{ get; }

        /// <summary>
        /// The expected writeLock value of the currently stored file
        /// </summary>
        [Preserve]
        [DataMember(Name = "writeLock", EmitDefaultValue = false)]
        public string WriteLock{ get; }

        /// <summary>
        /// Formats a FileDetails into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (ContentType != null)
            {
                serializedModel += "contentType," + ContentType + ",";
            }
            serializedModel += "contentLength," + ContentLength.ToString() + ",";
            if (ContentMd5 != null)
            {
                serializedModel += "contentMd5," + ContentMd5;
            }
            if (WriteLock != null)
            {
                serializedModel += "writeLock," + WriteLock;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a FileDetails as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (ContentType != null)
            {
                var contentTypeStringValue = ContentType.ToString();
                dictionary.Add("contentType", contentTypeStringValue);
            }

            var contentLengthStringValue = ContentLength.ToString();
            dictionary.Add("contentLength", contentLengthStringValue);

            if (ContentMd5 != null)
            {
                var contentMd5StringValue = ContentMd5.ToString();
                dictionary.Add("contentMd5", contentMd5StringValue);
            }

            if (WriteLock != null)
            {
                var writeLockStringValue = WriteLock.ToString();
                dictionary.Add("writeLock", writeLockStringValue);
            }

            return dictionary;
        }
    }
}
