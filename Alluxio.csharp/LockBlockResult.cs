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
public partial class LockBlockResult : TBase
{
  private long _lockId;
  private string _blockPath;

  public long LockId
  {
    get
    {
      return _lockId;
    }
    set
    {
      __isset.lockId = true;
      this._lockId = value;
    }
  }

  public string BlockPath
  {
    get
    {
      return _blockPath;
    }
    set
    {
      __isset.blockPath = true;
      this._blockPath = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool lockId;
    public bool blockPath;
  }

  public LockBlockResult() {
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
            if (field.Type == TType.I64) {
              LockId = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              BlockPath = iprot.ReadString();
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
      TStruct struc = new TStruct("LockBlockResult");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.lockId) {
        field.Name = "lockId";
        field.Type = TType.I64;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(LockId);
        oprot.WriteFieldEnd();
      }
      if (BlockPath != null && __isset.blockPath) {
        field.Name = "blockPath";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(BlockPath);
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
    StringBuilder __sb = new StringBuilder("LockBlockResult(");
    bool __first = true;
    if (__isset.lockId) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("LockId: ");
      __sb.Append(LockId);
    }
    if (BlockPath != null && __isset.blockPath) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("BlockPath: ");
      __sb.Append(BlockPath);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}

