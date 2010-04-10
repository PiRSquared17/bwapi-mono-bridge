/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class PositionPair : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PositionPair(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PositionPair obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PositionPair() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKEProxy.remote.delete_PositionPair(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
public override int GetHashCode()
{
   return this.swigCPtr.Handle.GetHashCode();
}

public override bool Equals(object obj)
{
    bool equal = false;
    if (obj is PositionPair)
      equal = (((PositionPair)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(PositionPair obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(PositionPair obj1, PositionPair obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(PositionPair obj1, PositionPair obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public PositionPair() : this(bridgePINVOKEProxy.remote.new_PositionPair__SWIG_0(), true) {
  }

  public PositionPair(Position t, Position u) : this(bridgePINVOKEProxy.remote.new_PositionPair__SWIG_1(Position.getCPtr(t), Position.getCPtr(u)), true) {
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
  }

  public PositionPair(PositionPair p) : this(bridgePINVOKEProxy.remote.new_PositionPair__SWIG_2(PositionPair.getCPtr(p)), true) {
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
  }

  public Position first {
    set {
      bridgePINVOKEProxy.remote.PositionPair_first_set(swigCPtr, Position.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKEProxy.remote.PositionPair_first_get(swigCPtr);
      Position ret = (cPtr == IntPtr.Zero) ? null : new Position(cPtr, false);
      return ret;
    } 
  }

  public Position second {
    set {
      bridgePINVOKEProxy.remote.PositionPair_second_set(swigCPtr, Position.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKEProxy.remote.PositionPair_second_get(swigCPtr);
      Position ret = (cPtr == IntPtr.Zero) ? null : new Position(cPtr, false);
      return ret;
    } 
  }

}

}
