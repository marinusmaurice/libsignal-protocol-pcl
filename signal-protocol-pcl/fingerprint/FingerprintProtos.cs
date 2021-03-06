// Generated by ProtoGen, Version=2.4.1.555, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace libsignal.fingerprint {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class FingerprintProtos {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    private static pbd::MessageDescriptor internal__static_FingerprintData__Descriptor;
    private static pb::FieldAccess.FieldAccessorTable<global::libsignal.fingerprint.FingerprintProtos.FingerprintData, global::libsignal.fingerprint.FingerprintProtos.FingerprintData.Builder> internal__static_FingerprintData__FieldAccessorTable;
    private static pbd::MessageDescriptor internal__static_CombinedFingerprint__Descriptor;
    private static pb::FieldAccess.FieldAccessorTable<global::libsignal.fingerprint.FingerprintProtos.CombinedFingerprint, global::libsignal.fingerprint.FingerprintProtos.CombinedFingerprint.Builder> internal__static_CombinedFingerprint__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static FingerprintProtos() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlGaW5nZXJwcmludFByb3RvY29sLnByb3RvIjgKD0ZpbmdlcnByaW50RGF0", 
            "YRIRCglwdWJsaWNLZXkYASABKAwSEgoKaWRlbnRpZmllchgCIAEoDCJ/ChND", 
            "b21iaW5lZEZpbmdlcnByaW50Eg8KB3ZlcnNpb24YASABKA0SKgoQbG9jYWxG", 
            "aW5nZXJwcmludBgCIAEoCzIQLkZpbmdlcnByaW50RGF0YRIrChFyZW1vdGVG", 
          "aW5nZXJwcmludBgDIAEoCzIQLkZpbmdlcnByaW50RGF0YQ=="));
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_FingerprintData__Descriptor = Descriptor.MessageTypes[0];
        internal__static_FingerprintData__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::libsignal.fingerprint.FingerprintProtos.FingerprintData, global::libsignal.fingerprint.FingerprintProtos.FingerprintData.Builder>(internal__static_FingerprintData__Descriptor,
                new string[] { "PublicKey", "Identifier", });
        internal__static_CombinedFingerprint__Descriptor = Descriptor.MessageTypes[1];
        internal__static_CombinedFingerprint__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::libsignal.fingerprint.FingerprintProtos.CombinedFingerprint, global::libsignal.fingerprint.FingerprintProtos.CombinedFingerprint.Builder>(internal__static_CombinedFingerprint__Descriptor,
                new string[] { "Version", "LocalFingerprint", "RemoteFingerprint", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion
    
    #region Messages
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class FingerprintData : pb::GeneratedMessage<FingerprintData, FingerprintData.Builder> {
      private FingerprintData() { }
      private static readonly FingerprintData defaultInstance = new FingerprintData().MakeReadOnly();
      private static readonly string[] _fingerprintDataFieldNames = new string[] { "identifier", "publicKey" };
      private static readonly uint[] _fingerprintDataFieldTags = new uint[] { 18, 10 };
      public static FingerprintData DefaultInstance {
        get { return defaultInstance; }
      }
      
      public override FingerprintData DefaultInstanceForType {
        get { return DefaultInstance; }
      }
      
      protected override FingerprintData ThisMessage {
        get { return this; }
      }
      
      public static pbd::MessageDescriptor Descriptor {
        get { return global::libsignal.fingerprint.FingerprintProtos.internal__static_FingerprintData__Descriptor; }
      }
      
      protected override pb::FieldAccess.FieldAccessorTable<FingerprintData, FingerprintData.Builder> InternalFieldAccessors {
        get { return global::libsignal.fingerprint.FingerprintProtos.internal__static_FingerprintData__FieldAccessorTable; }
      }
      
      public const int PublicKeyFieldNumber = 1;
      private bool hasPublicKey;
      private pb::ByteString publicKey_ = pb::ByteString.Empty;
      public bool HasPublicKey {
        get { return hasPublicKey; }
      }
      public pb::ByteString PublicKey {
        get { return publicKey_; }
      }
      
      public const int IdentifierFieldNumber = 2;
      private bool hasIdentifier;
      private pb::ByteString identifier_ = pb::ByteString.Empty;
      public bool HasIdentifier {
        get { return hasIdentifier; }
      }
      public pb::ByteString Identifier {
        get { return identifier_; }
      }
      
      public override bool IsInitialized {
        get {
          return true;
        }
      }
      
      public override void WriteTo(pb::ICodedOutputStream output) {
        CalcSerializedSize();
        string[] field_names = _fingerprintDataFieldNames;
        if (hasPublicKey) {
          output.WriteBytes(1, field_names[1], PublicKey);
        }
        if (hasIdentifier) {
          output.WriteBytes(2, field_names[0], Identifier);
        }
        UnknownFields.WriteTo(output);
      }
      
      private int memoizedSerializedSize = -1;
      public override int SerializedSize {
        get {
          int size = memoizedSerializedSize;
          if (size != -1) return size;
          return CalcSerializedSize();
        }
      }
      
      private int CalcSerializedSize() {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasPublicKey) {
          size += pb::CodedOutputStream.ComputeBytesSize(1, PublicKey);
        }
        if (hasIdentifier) {
          size += pb::CodedOutputStream.ComputeBytesSize(2, Identifier);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
      public static FingerprintData ParseFrom(pb::ByteString data) {
        return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
      }
      public static FingerprintData ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
      }
      public static FingerprintData ParseFrom(byte[] data) {
        return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
      }
      public static FingerprintData ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
      }
      public static FingerprintData ParseFrom(global::System.IO.Stream input) {
        return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
      }
      public static FingerprintData ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
      }
      public static FingerprintData ParseDelimitedFrom(global::System.IO.Stream input) {
        return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
      }
      public static FingerprintData ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
        return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
      }
      public static FingerprintData ParseFrom(pb::ICodedInputStream input) {
        return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
      }
      public static FingerprintData ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
      }
      private FingerprintData MakeReadOnly() {
        return this;
      }
      
      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }
      public static Builder CreateBuilder(FingerprintData prototype) {
        return new Builder(prototype);
      }
      
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class Builder : pb::GeneratedBuilder<FingerprintData, Builder> {
        protected override Builder ThisBuilder {
          get { return this; }
        }
        public Builder() {
          result = DefaultInstance;
          resultIsReadOnly = true;
        }
        internal Builder(FingerprintData cloneFrom) {
          result = cloneFrom;
          resultIsReadOnly = true;
        }
        
        private bool resultIsReadOnly;
        private FingerprintData result;
        
        private FingerprintData PrepareBuilder() {
          if (resultIsReadOnly) {
            FingerprintData original = result;
            result = new FingerprintData();
            resultIsReadOnly = false;
            MergeFrom(original);
          }
          return result;
        }
        
        public override bool IsInitialized {
          get { return result.IsInitialized; }
        }
        
        protected override FingerprintData MessageBeingBuilt {
          get { return PrepareBuilder(); }
        }
        
        public override Builder Clear() {
          result = DefaultInstance;
          resultIsReadOnly = true;
          return this;
        }
        
        public override Builder Clone() {
          if (resultIsReadOnly) {
            return new Builder(result);
          } else {
            return new Builder().MergeFrom(result);
          }
        }
        
        public override pbd::MessageDescriptor DescriptorForType {
          get { return global::libsignal.fingerprint.FingerprintProtos.FingerprintData.Descriptor; }
        }
        
        public override FingerprintData DefaultInstanceForType {
          get { return global::libsignal.fingerprint.FingerprintProtos.FingerprintData.DefaultInstance; }
        }
        
        public override FingerprintData BuildPartial() {
          if (resultIsReadOnly) {
            return result;
          }
          resultIsReadOnly = true;
          return result.MakeReadOnly();
        }
        
        public override Builder MergeFrom(pb::IMessage other) {
          if (other is FingerprintData) {
            return MergeFrom((FingerprintData) other);
          } else {
            base.MergeFrom(other);
            return this;
          }
        }
        
        public override Builder MergeFrom(FingerprintData other) {
          if (other == global::libsignal.fingerprint.FingerprintProtos.FingerprintData.DefaultInstance) return this;
          PrepareBuilder();
          if (other.HasPublicKey) {
            PublicKey = other.PublicKey;
          }
          if (other.HasIdentifier) {
            Identifier = other.Identifier;
          }
          this.MergeUnknownFields(other.UnknownFields);
          return this;
        }
        
        public override Builder MergeFrom(pb::ICodedInputStream input) {
          return MergeFrom(input, pb::ExtensionRegistry.Empty);
        }
        
        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          PrepareBuilder();
          pb::UnknownFieldSet.Builder unknownFields = null;
          uint tag;
          string field_name;
          while (input.ReadTag(out tag, out field_name)) {
            if(tag == 0 && field_name != null) {
              int field_ordinal = global::System.Array.BinarySearch(_fingerprintDataFieldNames, field_name, global::System.StringComparer.Ordinal);
              if(field_ordinal >= 0)
                tag = _fingerprintDataFieldTags[field_ordinal];
              else {
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                continue;
              }
            }
            switch (tag) {
              case 0: {
                throw pb::InvalidProtocolBufferException.InvalidTag();
              }
              default: {
                if (pb::WireFormat.IsEndGroupTag(tag)) {
                  if (unknownFields != null) {
                    this.UnknownFields = unknownFields.Build();
                  }
                  return this;
                }
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                break;
              }
              case 10: {
                result.hasPublicKey = input.ReadBytes(ref result.publicKey_);
                break;
              }
              case 18: {
                result.hasIdentifier = input.ReadBytes(ref result.identifier_);
                break;
              }
            }
          }
          
          if (unknownFields != null) {
            this.UnknownFields = unknownFields.Build();
          }
          return this;
        }
        
        
        public bool HasPublicKey {
          get { return result.hasPublicKey; }
        }
        public pb::ByteString PublicKey {
          get { return result.PublicKey; }
          set { SetPublicKey(value); }
        }
        public Builder SetPublicKey(pb::ByteString value) {
          pb::ThrowHelper.ThrowIfNull(value, "value");
          PrepareBuilder();
          result.hasPublicKey = true;
          result.publicKey_ = value;
          return this;
        }
        public Builder ClearPublicKey() {
          PrepareBuilder();
          result.hasPublicKey = false;
          result.publicKey_ = pb::ByteString.Empty;
          return this;
        }
        
        public bool HasIdentifier {
          get { return result.hasIdentifier; }
        }
        public pb::ByteString Identifier {
          get { return result.Identifier; }
          set { SetIdentifier(value); }
        }
        public Builder SetIdentifier(pb::ByteString value) {
          pb::ThrowHelper.ThrowIfNull(value, "value");
          PrepareBuilder();
          result.hasIdentifier = true;
          result.identifier_ = value;
          return this;
        }
        public Builder ClearIdentifier() {
          PrepareBuilder();
          result.hasIdentifier = false;
          result.identifier_ = pb::ByteString.Empty;
          return this;
        }
      }
      static FingerprintData() {
        object.ReferenceEquals(global::libsignal.fingerprint.FingerprintProtos.Descriptor, null);
      }
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class CombinedFingerprint : pb::GeneratedMessage<CombinedFingerprint, CombinedFingerprint.Builder> {
      private CombinedFingerprint() { }
      private static readonly CombinedFingerprint defaultInstance = new CombinedFingerprint().MakeReadOnly();
      private static readonly string[] _combinedFingerprintFieldNames = new string[] { "localFingerprint", "remoteFingerprint", "version" };
      private static readonly uint[] _combinedFingerprintFieldTags = new uint[] { 18, 26, 8 };
      public static CombinedFingerprint DefaultInstance {
        get { return defaultInstance; }
      }
      
      public override CombinedFingerprint DefaultInstanceForType {
        get { return DefaultInstance; }
      }
      
      protected override CombinedFingerprint ThisMessage {
        get { return this; }
      }
      
      public static pbd::MessageDescriptor Descriptor {
        get { return global::libsignal.fingerprint.FingerprintProtos.internal__static_CombinedFingerprint__Descriptor; }
      }
      
      protected override pb::FieldAccess.FieldAccessorTable<CombinedFingerprint, CombinedFingerprint.Builder> InternalFieldAccessors {
        get { return global::libsignal.fingerprint.FingerprintProtos.internal__static_CombinedFingerprint__FieldAccessorTable; }
      }
      
      public const int VersionFieldNumber = 1;
      private bool hasVersion;
      private uint version_;
      public bool HasVersion {
        get { return hasVersion; }
      }
      [global::System.CLSCompliant(false)]
      public uint Version {
        get { return version_; }
      }
      
      public const int LocalFingerprintFieldNumber = 2;
      private bool hasLocalFingerprint;
      private global::libsignal.fingerprint.FingerprintProtos.FingerprintData localFingerprint_;
      public bool HasLocalFingerprint {
        get { return hasLocalFingerprint; }
      }
      public global::libsignal.fingerprint.FingerprintProtos.FingerprintData LocalFingerprint {
        get { return localFingerprint_ ?? global::libsignal.fingerprint.FingerprintProtos.FingerprintData.DefaultInstance; }
      }
      
      public const int RemoteFingerprintFieldNumber = 3;
      private bool hasRemoteFingerprint;
      private global::libsignal.fingerprint.FingerprintProtos.FingerprintData remoteFingerprint_;
      public bool HasRemoteFingerprint {
        get { return hasRemoteFingerprint; }
      }
      public global::libsignal.fingerprint.FingerprintProtos.FingerprintData RemoteFingerprint {
        get { return remoteFingerprint_ ?? global::libsignal.fingerprint.FingerprintProtos.FingerprintData.DefaultInstance; }
      }
      
      public override bool IsInitialized {
        get {
          return true;
        }
      }
      
      public override void WriteTo(pb::ICodedOutputStream output) {
        CalcSerializedSize();
        string[] field_names = _combinedFingerprintFieldNames;
        if (hasVersion) {
          output.WriteUInt32(1, field_names[2], Version);
        }
        if (hasLocalFingerprint) {
          output.WriteMessage(2, field_names[0], LocalFingerprint);
        }
        if (hasRemoteFingerprint) {
          output.WriteMessage(3, field_names[1], RemoteFingerprint);
        }
        UnknownFields.WriteTo(output);
      }
      
      private int memoizedSerializedSize = -1;
      public override int SerializedSize {
        get {
          int size = memoizedSerializedSize;
          if (size != -1) return size;
          return CalcSerializedSize();
        }
      }
      
      private int CalcSerializedSize() {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasVersion) {
          size += pb::CodedOutputStream.ComputeUInt32Size(1, Version);
        }
        if (hasLocalFingerprint) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, LocalFingerprint);
        }
        if (hasRemoteFingerprint) {
          size += pb::CodedOutputStream.ComputeMessageSize(3, RemoteFingerprint);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
      public static CombinedFingerprint ParseFrom(pb::ByteString data) {
        return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
      }
      public static CombinedFingerprint ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
      }
      public static CombinedFingerprint ParseFrom(byte[] data) {
        return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
      }
      public static CombinedFingerprint ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
      }
      public static CombinedFingerprint ParseFrom(global::System.IO.Stream input) {
        return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
      }
      public static CombinedFingerprint ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
      }
      public static CombinedFingerprint ParseDelimitedFrom(global::System.IO.Stream input) {
        return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
      }
      public static CombinedFingerprint ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
        return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
      }
      public static CombinedFingerprint ParseFrom(pb::ICodedInputStream input) {
        return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
      }
      public static CombinedFingerprint ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
      }
      private CombinedFingerprint MakeReadOnly() {
        return this;
      }
      
      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }
      public static Builder CreateBuilder(CombinedFingerprint prototype) {
        return new Builder(prototype);
      }
      
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class Builder : pb::GeneratedBuilder<CombinedFingerprint, Builder> {
        protected override Builder ThisBuilder {
          get { return this; }
        }
        public Builder() {
          result = DefaultInstance;
          resultIsReadOnly = true;
        }
        internal Builder(CombinedFingerprint cloneFrom) {
          result = cloneFrom;
          resultIsReadOnly = true;
        }
        
        private bool resultIsReadOnly;
        private CombinedFingerprint result;
        
        private CombinedFingerprint PrepareBuilder() {
          if (resultIsReadOnly) {
            CombinedFingerprint original = result;
            result = new CombinedFingerprint();
            resultIsReadOnly = false;
            MergeFrom(original);
          }
          return result;
        }
        
        public override bool IsInitialized {
          get { return result.IsInitialized; }
        }
        
        protected override CombinedFingerprint MessageBeingBuilt {
          get { return PrepareBuilder(); }
        }
        
        public override Builder Clear() {
          result = DefaultInstance;
          resultIsReadOnly = true;
          return this;
        }
        
        public override Builder Clone() {
          if (resultIsReadOnly) {
            return new Builder(result);
          } else {
            return new Builder().MergeFrom(result);
          }
        }
        
        public override pbd::MessageDescriptor DescriptorForType {
          get { return global::libsignal.fingerprint.FingerprintProtos.CombinedFingerprint.Descriptor; }
        }
        
        public override CombinedFingerprint DefaultInstanceForType {
          get { return global::libsignal.fingerprint.FingerprintProtos.CombinedFingerprint.DefaultInstance; }
        }
        
        public override CombinedFingerprint BuildPartial() {
          if (resultIsReadOnly) {
            return result;
          }
          resultIsReadOnly = true;
          return result.MakeReadOnly();
        }
        
        public override Builder MergeFrom(pb::IMessage other) {
          if (other is CombinedFingerprint) {
            return MergeFrom((CombinedFingerprint) other);
          } else {
            base.MergeFrom(other);
            return this;
          }
        }
        
        public override Builder MergeFrom(CombinedFingerprint other) {
          if (other == global::libsignal.fingerprint.FingerprintProtos.CombinedFingerprint.DefaultInstance) return this;
          PrepareBuilder();
          if (other.HasVersion) {
            Version = other.Version;
          }
          if (other.HasLocalFingerprint) {
            MergeLocalFingerprint(other.LocalFingerprint);
          }
          if (other.HasRemoteFingerprint) {
            MergeRemoteFingerprint(other.RemoteFingerprint);
          }
          this.MergeUnknownFields(other.UnknownFields);
          return this;
        }
        
        public override Builder MergeFrom(pb::ICodedInputStream input) {
          return MergeFrom(input, pb::ExtensionRegistry.Empty);
        }
        
        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          PrepareBuilder();
          pb::UnknownFieldSet.Builder unknownFields = null;
          uint tag;
          string field_name;
          while (input.ReadTag(out tag, out field_name)) {
            if(tag == 0 && field_name != null) {
              int field_ordinal = global::System.Array.BinarySearch(_combinedFingerprintFieldNames, field_name, global::System.StringComparer.Ordinal);
              if(field_ordinal >= 0)
                tag = _combinedFingerprintFieldTags[field_ordinal];
              else {
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                continue;
              }
            }
            switch (tag) {
              case 0: {
                throw pb::InvalidProtocolBufferException.InvalidTag();
              }
              default: {
                if (pb::WireFormat.IsEndGroupTag(tag)) {
                  if (unknownFields != null) {
                    this.UnknownFields = unknownFields.Build();
                  }
                  return this;
                }
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                break;
              }
              case 8: {
                result.hasVersion = input.ReadUInt32(ref result.version_);
                break;
              }
              case 18: {
                global::libsignal.fingerprint.FingerprintProtos.FingerprintData.Builder subBuilder = global::libsignal.fingerprint.FingerprintProtos.FingerprintData.CreateBuilder();
                if (result.hasLocalFingerprint) {
                  subBuilder.MergeFrom(LocalFingerprint);
                }
                input.ReadMessage(subBuilder, extensionRegistry);
                LocalFingerprint = subBuilder.BuildPartial();
                break;
              }
              case 26: {
                global::libsignal.fingerprint.FingerprintProtos.FingerprintData.Builder subBuilder = global::libsignal.fingerprint.FingerprintProtos.FingerprintData.CreateBuilder();
                if (result.hasRemoteFingerprint) {
                  subBuilder.MergeFrom(RemoteFingerprint);
                }
                input.ReadMessage(subBuilder, extensionRegistry);
                RemoteFingerprint = subBuilder.BuildPartial();
                break;
              }
            }
          }
          
          if (unknownFields != null) {
            this.UnknownFields = unknownFields.Build();
          }
          return this;
        }
        
        
        public bool HasVersion {
          get { return result.hasVersion; }
        }
        [global::System.CLSCompliant(false)]
        public uint Version {
          get { return result.Version; }
          set { SetVersion(value); }
        }
        [global::System.CLSCompliant(false)]
        public Builder SetVersion(uint value) {
          PrepareBuilder();
          result.hasVersion = true;
          result.version_ = value;
          return this;
        }
        public Builder ClearVersion() {
          PrepareBuilder();
          result.hasVersion = false;
          result.version_ = 0;
          return this;
        }
        
        public bool HasLocalFingerprint {
         get { return result.hasLocalFingerprint; }
        }
        public global::libsignal.fingerprint.FingerprintProtos.FingerprintData LocalFingerprint {
          get { return result.LocalFingerprint; }
          set { SetLocalFingerprint(value); }
        }
        public Builder SetLocalFingerprint(global::libsignal.fingerprint.FingerprintProtos.FingerprintData value) {
          pb::ThrowHelper.ThrowIfNull(value, "value");
          PrepareBuilder();
          result.hasLocalFingerprint = true;
          result.localFingerprint_ = value;
          return this;
        }
        public Builder SetLocalFingerprint(global::libsignal.fingerprint.FingerprintProtos.FingerprintData.Builder builderForValue) {
          pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
          PrepareBuilder();
          result.hasLocalFingerprint = true;
          result.localFingerprint_ = builderForValue.Build();
          return this;
        }
        public Builder MergeLocalFingerprint(global::libsignal.fingerprint.FingerprintProtos.FingerprintData value) {
          pb::ThrowHelper.ThrowIfNull(value, "value");
          PrepareBuilder();
          if (result.hasLocalFingerprint &&
              result.localFingerprint_ != global::libsignal.fingerprint.FingerprintProtos.FingerprintData.DefaultInstance) {
              result.localFingerprint_ = global::libsignal.fingerprint.FingerprintProtos.FingerprintData.CreateBuilder(result.localFingerprint_).MergeFrom(value).BuildPartial();
          } else {
            result.localFingerprint_ = value;
          }
          result.hasLocalFingerprint = true;
          return this;
        }
        public Builder ClearLocalFingerprint() {
          PrepareBuilder();
          result.hasLocalFingerprint = false;
          result.localFingerprint_ = null;
          return this;
        }
        
        public bool HasRemoteFingerprint {
         get { return result.hasRemoteFingerprint; }
        }
        public global::libsignal.fingerprint.FingerprintProtos.FingerprintData RemoteFingerprint {
          get { return result.RemoteFingerprint; }
          set { SetRemoteFingerprint(value); }
        }
        public Builder SetRemoteFingerprint(global::libsignal.fingerprint.FingerprintProtos.FingerprintData value) {
          pb::ThrowHelper.ThrowIfNull(value, "value");
          PrepareBuilder();
          result.hasRemoteFingerprint = true;
          result.remoteFingerprint_ = value;
          return this;
        }
        public Builder SetRemoteFingerprint(global::libsignal.fingerprint.FingerprintProtos.FingerprintData.Builder builderForValue) {
          pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
          PrepareBuilder();
          result.hasRemoteFingerprint = true;
          result.remoteFingerprint_ = builderForValue.Build();
          return this;
        }
        public Builder MergeRemoteFingerprint(global::libsignal.fingerprint.FingerprintProtos.FingerprintData value) {
          pb::ThrowHelper.ThrowIfNull(value, "value");
          PrepareBuilder();
          if (result.hasRemoteFingerprint &&
              result.remoteFingerprint_ != global::libsignal.fingerprint.FingerprintProtos.FingerprintData.DefaultInstance) {
              result.remoteFingerprint_ = global::libsignal.fingerprint.FingerprintProtos.FingerprintData.CreateBuilder(result.remoteFingerprint_).MergeFrom(value).BuildPartial();
          } else {
            result.remoteFingerprint_ = value;
          }
          result.hasRemoteFingerprint = true;
          return this;
        }
        public Builder ClearRemoteFingerprint() {
          PrepareBuilder();
          result.hasRemoteFingerprint = false;
          result.remoteFingerprint_ = null;
          return this;
        }
      }
      static CombinedFingerprint() {
        object.ReferenceEquals(global::libsignal.fingerprint.FingerprintProtos.Descriptor, null);
      }
    }
    
    #endregion
    
  }
}

#endregion Designer generated code
