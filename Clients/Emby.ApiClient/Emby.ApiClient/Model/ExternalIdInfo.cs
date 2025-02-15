// <copyright file="ExternalIdInfo.cs" company="Emby LLC">
// Emby.ApiClient. Autogenerated Code. No license applied. 
// </copyright>
// <autogenerated />
namespace Emby.ApiClient.Model
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Text;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Runtime.Serialization;

    /// <summary>
    /// ExternalIdInfo.
    /// </summary>
    /// <seealso>MediaBrowser.Model.Providers.ExternalIdInfo</seealso>
    public partial class ExternalIdInfo :  IEquatable<ExternalIdInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalIdInfo" /> class.
        /// </summary>
        public ExternalIdInfo()
        {
        }
        
        /// <summary>
        /// The name.
        /// </summary>
        /// <value>The Name.</value>
        public string Name { get; set; }

        /// <summary>
        /// The key.
        /// </summary>
        /// <value>The Key.</value>
        public string Key { get; set; }

        /// <summary>
        /// The URL format string.
        /// </summary>
        /// <value>The UrlFormatString.</value>
        public string UrlFormatString { get; set; }

        /// <summary>
        /// Gets or Sets IsSupportedAsIdentifier
        /// </summary>
        /// <value>The IsSupportedAsIdentifier.</value>
        public bool? IsSupportedAsIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalIdInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  UrlFormatString: ").Append(UrlFormatString).Append("\n");
            sb.Append("  IsSupportedAsIdentifier: ").Append(IsSupportedAsIdentifier).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExternalIdInfo);
        }

        /// <summary>
        /// Returns true if ExternalIdInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalIdInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalIdInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.UrlFormatString == input.UrlFormatString ||
                    (this.UrlFormatString != null &&
                    this.UrlFormatString.Equals(input.UrlFormatString))
                ) && 
                (
                    this.IsSupportedAsIdentifier == input.IsSupportedAsIdentifier ||
                    (this.IsSupportedAsIdentifier != null &&
                    this.IsSupportedAsIdentifier.Equals(input.IsSupportedAsIdentifier))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.UrlFormatString != null)
                    hashCode = hashCode * 59 + this.UrlFormatString.GetHashCode();
                if (this.IsSupportedAsIdentifier != null)
                    hashCode = hashCode * 59 + this.IsSupportedAsIdentifier.GetHashCode();
                return hashCode;
            }
        }
    }
}