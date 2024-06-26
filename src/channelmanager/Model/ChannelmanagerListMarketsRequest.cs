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
    /// ChannelmanagerListMarketsRequest
    /// </summary>
    [DataContract(Name = "channelmanagerListMarketsRequest")]
    public partial class ChannelmanagerListMarketsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelmanagerListMarketsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelmanagerListMarketsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelmanagerListMarketsRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId (required).</param>
        /// <param name="pageSize">The number of items to return per page. If not specified, it will returns all items..</param>
        /// <param name="pageToken">pageToken.</param>
        public ChannelmanagerListMarketsRequest(string tenantId = default(string), long pageSize = default(long), string pageToken = default(string))
        {
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for ChannelmanagerListMarketsRequest and cannot be null");
            }
            this.TenantId = tenantId;
            this.PageSize = pageSize;
            this.PageToken = pageToken;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// The number of items to return per page. If not specified, it will returns all items.
        /// </summary>
        /// <value>The number of items to return per page. If not specified, it will returns all items.</value>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public long PageSize { get; set; }

        /// <summary>
        /// Gets or Sets PageToken
        /// </summary>
        [DataMember(Name = "pageToken", EmitDefaultValue = false)]
        public string PageToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChannelmanagerListMarketsRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageToken: ").Append(PageToken).Append("\n");
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
