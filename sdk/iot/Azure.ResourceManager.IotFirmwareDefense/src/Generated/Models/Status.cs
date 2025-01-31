// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> The status of firmware scan. </summary>
    public readonly partial struct Status : IEquatable<Status>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Status"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Status(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ExtractingValue = "Extracting";
        private const string AnalyzingValue = "Analyzing";
        private const string ReadyValue = "Ready";
        private const string ErrorValue = "Error";

        /// <summary> Pending. </summary>
        public static Status Pending { get; } = new Status(PendingValue);
        /// <summary> Extracting. </summary>
        public static Status Extracting { get; } = new Status(ExtractingValue);
        /// <summary> Analyzing. </summary>
        public static Status Analyzing { get; } = new Status(AnalyzingValue);
        /// <summary> Ready. </summary>
        public static Status Ready { get; } = new Status(ReadyValue);
        /// <summary> Error. </summary>
        public static Status Error { get; } = new Status(ErrorValue);
        /// <summary> Determines if two <see cref="Status"/> values are the same. </summary>
        public static bool operator ==(Status left, Status right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Status"/> values are not the same. </summary>
        public static bool operator !=(Status left, Status right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Status"/>. </summary>
        public static implicit operator Status(string value) => new Status(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Status other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Status other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
