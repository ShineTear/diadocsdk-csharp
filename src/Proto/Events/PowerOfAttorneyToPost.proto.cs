//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Events/PowerOfAttorneyToPost.proto
// Note: requires additional types generated from: PowersOfAttorney/PowerOfAttorney.proto
namespace Diadoc.Api.Proto.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyToPost")]
  public partial class PowerOfAttorneyToPost : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneyToPost() {}
    

    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyFullId _FullId = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"FullId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyFullId FullId
    {
      get { return _FullId; }
      set { _FullId = value; }
    }
    private bool _UseDefault;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"UseDefault", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool UseDefault
    {
      get { return _UseDefault; }
      set { _UseDefault = value; }
    }

    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneySignedContent _Content = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneySignedContent Content
    {
      get { return _Content; }
      set { _Content = value; }
    }

    private bool _SendAsFile = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"SendAsFile", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool SendAsFile
    {
      get { return _SendAsFile; }
      set { _SendAsFile = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneySignedContent> _Contents = new global::System.Collections.Generic.List<Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneySignedContent>();
    [global::ProtoBuf.ProtoMember(5, Name=@"Contents", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneySignedContent> Contents
    {
      get { return _Contents; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}