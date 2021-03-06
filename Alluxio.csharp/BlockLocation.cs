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


/// <summary>
/// Information about blocks.
/// </summary>
#if !SILVERLIGHT
[Serializable]
#endif
public partial class BlockLocation : TBase
{
  private long _workerId;
  private WorkerNetAddress _workerAddress;
  private string _tierAlias;

  public long WorkerId
  {
    get
    {
      return _workerId;
    }
    set
    {
      __isset.workerId = true;
      this._workerId = value;
    }
  }

  public WorkerNetAddress WorkerAddress
  {
    get
    {
      return _workerAddress;
    }
    set
    {
      __isset.workerAddress = true;
      this._workerAddress = value;
    }
  }

  public string TierAlias
  {
    get
    {
      return _tierAlias;
    }
    set
    {
      __isset.tierAlias = true;
      this._tierAlias = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool workerId;
    public bool workerAddress;
    public bool tierAlias;
  }

  public BlockLocation() {
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
              WorkerId = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              WorkerAddress = new WorkerNetAddress();
              WorkerAddress.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              TierAlias = iprot.ReadString();
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
      TStruct struc = new TStruct("BlockLocation");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.workerId) {
        field.Name = "workerId";
        field.Type = TType.I64;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(WorkerId);
        oprot.WriteFieldEnd();
      }
      if (WorkerAddress != null && __isset.workerAddress) {
        field.Name = "workerAddress";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        WorkerAddress.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (TierAlias != null && __isset.tierAlias) {
        field.Name = "tierAlias";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(TierAlias);
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
    StringBuilder __sb = new StringBuilder("BlockLocation(");
    bool __first = true;
    if (__isset.workerId) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("WorkerId: ");
      __sb.Append(WorkerId);
    }
    if (WorkerAddress != null && __isset.workerAddress) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("WorkerAddress: ");
      __sb.Append(WorkerAddress);
    }
    if (TierAlias != null && __isset.tierAlias) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("TierAlias: ");
      __sb.Append(TierAlias);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}

