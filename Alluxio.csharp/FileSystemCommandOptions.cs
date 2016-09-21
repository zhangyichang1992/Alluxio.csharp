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
public partial class FileSystemCommandOptions : TBase
{
  private PersistCommandOptions _persistOptions;

  public PersistCommandOptions PersistOptions
  {
    get
    {
      return _persistOptions;
    }
    set
    {
      __isset.persistOptions = true;
      this._persistOptions = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool persistOptions;
  }

  public FileSystemCommandOptions() {
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
            if (field.Type == TType.Struct) {
              PersistOptions = new PersistCommandOptions();
              PersistOptions.Read(iprot);
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
      TStruct struc = new TStruct("FileSystemCommandOptions");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (PersistOptions != null && __isset.persistOptions) {
        field.Name = "persistOptions";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        PersistOptions.Write(oprot);
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
    StringBuilder __sb = new StringBuilder("FileSystemCommandOptions(");
    bool __first = true;
    if (PersistOptions != null && __isset.persistOptions) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("PersistOptions: ");
      __sb.Append(PersistOptions== null ? "<null>" : PersistOptions.ToString());
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}

