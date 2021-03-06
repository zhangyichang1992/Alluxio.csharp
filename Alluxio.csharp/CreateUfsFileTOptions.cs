/**
 * Autogenerated by Thrift Compiler (0.9.3)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;


#if !SILVERLIGHT
[Serializable]
#endif
public partial class CreateUfsFileTOptions : TBase
{
  private string _owner;
  private string _group;
  private short _mode;

  public string Owner
  {
    get
    {
      return _owner;
    }
    set
    {
      __isset.owner = true;
      this._owner = value;
    }
  }

  public string Group
  {
    get
    {
      return _group;
    }
    set
    {
      __isset.@group = true;
      this._group = value;
    }
  }

  public short Mode
  {
    get
    {
      return _mode;
    }
    set
    {
      __isset.mode = true;
      this._mode = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool owner;
    public bool @group;
    public bool mode;
  }

  public CreateUfsFileTOptions() {
  }

  public void Read (TProtocol iprot)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              Owner = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Group = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I16) {
              Mode = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }
    finally
    {
      iprot.DecrementRecursionDepth();
    }
  }

  public void Write(TProtocol oprot) {
    oprot.IncrementRecursionDepth();
    try
    {
      TStruct struc = new TStruct("CreateUfsFileTOptions");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Owner != null && __isset.owner) {
        field.Name = "owner";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Owner);
        oprot.WriteFieldEnd();
      }
      if (Group != null && __isset.@group) {
        field.Name = "group";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Group);
        oprot.WriteFieldEnd();
      }
      if (__isset.mode) {
        field.Name = "mode";
        field.Type = TType.I16;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Mode);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }
    finally
    {
      oprot.DecrementRecursionDepth();
    }
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("CreateUfsFileTOptions(");
    bool __first = true;
    if (Owner != null && __isset.owner) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Owner: ");
      __sb.Append(Owner);
    }
    if (Group != null && __isset.@group) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Group: ");
      __sb.Append(Group);
    }
    if (__isset.mode) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Mode: ");
      __sb.Append(Mode);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}

