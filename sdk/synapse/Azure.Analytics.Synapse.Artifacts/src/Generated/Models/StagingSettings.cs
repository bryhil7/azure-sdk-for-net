// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Staging settings. </summary>
    public partial class StagingSettings : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of StagingSettings. </summary>
        /// <param name="linkedServiceName"> Staging linked service reference. </param>
        public StagingSettings(LinkedServiceReference linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            LinkedServiceName = linkedServiceName;
            AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary> Initializes a new instance of StagingSettings. </summary>
        /// <param name="linkedServiceName"> Staging linked service reference. </param>
        /// <param name="path"> The path to storage for storing the interim data. Type: string (or Expression with resultType string). </param>
        /// <param name="enableCompression"> Specifies whether to use compression when copying data via an interim staging. Default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> . </param>
        internal StagingSettings(LinkedServiceReference linkedServiceName, object path, object enableCompression, IDictionary<string, object> additionalProperties)
        {
            LinkedServiceName = linkedServiceName;
            Path = path;
            EnableCompression = enableCompression;
            AdditionalProperties = additionalProperties ?? new Dictionary<string, object>();
        }

        /// <summary> Staging linked service reference. </summary>
        public LinkedServiceReference LinkedServiceName { get; set; }
        /// <summary> The path to storage for storing the interim data. Type: string (or Expression with resultType string). </summary>
        public object Path { get; set; }
        /// <summary> Specifies whether to use compression when copying data via an interim staging. Default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public object EnableCompression { get; set; }
        internal IDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public ICollection<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}