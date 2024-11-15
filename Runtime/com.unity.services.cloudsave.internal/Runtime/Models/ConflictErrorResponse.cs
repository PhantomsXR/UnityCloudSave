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
    /// An error sent back upon resource conflict.
    /// </summary>
    [Preserve]
    [DataContract(Name = "ConflictErrorResponse")]
    internal class ConflictErrorResponse
    {
        /// <summary>
        /// An error sent back upon resource conflict.
        /// </summary>
        /// <param name="type">A URI reference [RFC3986] that identifies the problem type. This specification encourages that, when dereferenced, it provide human-readable documentation for the problem type (e.g., using HTML [W3C.REC-html5-20141028]). When this member is not present, its value is assumed to be \&quot;about:blank\&quot;.</param>
        /// <param name="title">A short, human-readable summary of the problem type. It SHOULD NOT change from occurrence to occurrence of the problem, except for purposes of localization (e.g., using proactive content negotiation; see [RFC7231], Section 3.4).</param>
        /// <param name="status">The HTTP status code ([RFC7231], Section 6) generated by the origin server for this occurrence of the problem.</param>
        /// <param name="code">Service specific error code</param>
        /// <param name="detail">A human-readable explanation specific to this occurrence of the problem.</param>
        /// <param name="data">data param</param>
        /// <param name="instance">A URI reference that identifies the specific occurrence of the problem. It may or may not yield further information if dereferenced.</param>
        [Preserve]
        public ConflictErrorResponse(string type, string title, int status, int code, string detail, ConflictErrorResponseData data, string instance = default)
        {
            Type = type;
            Title = title;
            Status = status;
            Code = code;
            Detail = detail;
            Instance = instance;
            Data = data;
        }

        /// <summary>
        /// A URI reference [RFC3986] that identifies the problem type. This specification encourages that, when dereferenced, it provide human-readable documentation for the problem type (e.g., using HTML [W3C.REC-html5-20141028]). When this member is not present, its value is assumed to be \&quot;about:blank\&quot;.
        /// </summary>
        [Preserve]
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type{ get; }
        
        /// <summary>
        /// A short, human-readable summary of the problem type. It SHOULD NOT change from occurrence to occurrence of the problem, except for purposes of localization (e.g., using proactive content negotiation; see [RFC7231], Section 3.4).
        /// </summary>
        [Preserve]
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title{ get; }
        
        /// <summary>
        /// The HTTP status code ([RFC7231], Section 6) generated by the origin server for this occurrence of the problem.
        /// </summary>
        [Preserve]
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public int Status{ get; }
        
        /// <summary>
        /// Service specific error code
        /// </summary>
        [Preserve]
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public int Code{ get; }
        
        /// <summary>
        /// A human-readable explanation specific to this occurrence of the problem.
        /// </summary>
        [Preserve]
        [DataMember(Name = "detail", IsRequired = true, EmitDefaultValue = true)]
        public string Detail{ get; }
        
        /// <summary>
        /// A URI reference that identifies the specific occurrence of the problem. It may or may not yield further information if dereferenced.
        /// </summary>
        [Preserve]
        [DataMember(Name = "instance", EmitDefaultValue = false)]
        public string Instance{ get; }
        
        /// <summary>
        /// Parameter data of ConflictErrorResponse
        /// </summary>
        [Preserve]
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public ConflictErrorResponseData Data{ get; }
    
        /// <summary>
        /// Formats a ConflictErrorResponse into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Type != null)
            {
                serializedModel += "type," + Type + ",";
            }
            if (Title != null)
            {
                serializedModel += "title," + Title + ",";
            }
            serializedModel += "status," + Status.ToString() + ",";
            serializedModel += "code," + Code.ToString() + ",";
            if (Detail != null)
            {
                serializedModel += "detail," + Detail + ",";
            }
            if (Instance != null)
            {
                serializedModel += "instance," + Instance + ",";
            }
            if (Data != null)
            {
                serializedModel += "data," + Data.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a ConflictErrorResponse as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Type != null)
            {
                var typeStringValue = Type.ToString();
                dictionary.Add("type", typeStringValue);
            }
            
            if (Title != null)
            {
                var titleStringValue = Title.ToString();
                dictionary.Add("title", titleStringValue);
            }
            
            var statusStringValue = Status.ToString();
            dictionary.Add("status", statusStringValue);
            
            var codeStringValue = Code.ToString();
            dictionary.Add("code", codeStringValue);
            
            if (Detail != null)
            {
                var detailStringValue = Detail.ToString();
                dictionary.Add("detail", detailStringValue);
            }
            
            if (Instance != null)
            {
                var instanceStringValue = Instance.ToString();
                dictionary.Add("instance", instanceStringValue);
            }
            
            return dictionary;
        }
    }
}
