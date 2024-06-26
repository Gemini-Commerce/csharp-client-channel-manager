/*
 * Channel Manager Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = channelmanager.Client.OpenAPIDateConverter;

namespace channelmanager.Model
{
    /// <summary>
    /// ChannelmanagerGetChannelWithAssociationsRequest
    /// </summary>
    [DataContract(Name = "channelmanagerGetChannelWithAssociationsRequest")]
    public partial class ChannelmanagerGetChannelWithAssociationsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelmanagerGetChannelWithAssociationsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelmanagerGetChannelWithAssociationsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelmanagerGetChannelWithAssociationsRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId (required).</param>
        /// <param name="id">id (required).</param>
        public ChannelmanagerGetChannelWithAssociationsRequest(string tenantId = default(string), string id = default(string))
        {
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for ChannelmanagerGetChannelWithAssociationsRequest and cannot be null");
            }
            this.TenantId = tenantId;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ChannelmanagerGetChannelWithAssociationsRequest and cannot be null");
            }
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChannelmanagerGetChannelWithAssociationsRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
