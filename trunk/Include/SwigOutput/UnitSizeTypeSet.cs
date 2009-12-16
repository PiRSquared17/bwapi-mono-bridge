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

public class UnitSizeTypeSet : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnitSizeTypeSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnitSizeTypeSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitSizeTypeSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_UnitSizeTypeSet(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public UnitSizeTypeSet(SWIGTYPE_p_std__setT_BWAPI__UnitSizeType_t original) : this(bridgePINVOKE.new_UnitSizeTypeSet(SWIGTYPE_p_std__setT_BWAPI__UnitSizeType_t.getCPtr(original)), true) {
  }

  public int size() {
    int ret = bridgePINVOKE.UnitSizeTypeSet_size(swigCPtr);
    return ret;
  }

  public bool contains(UnitSizeType item) {
    bool ret = bridgePINVOKE.UnitSizeTypeSet_contains(swigCPtr, UnitSizeType.getCPtr(item));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool add(UnitSizeType item) {
    bool ret = bridgePINVOKE.UnitSizeTypeSet_add(swigCPtr, UnitSizeType.getCPtr(item));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void clear() {
    bridgePINVOKE.UnitSizeTypeSet_clear(swigCPtr);
  }

  public bool remove(UnitSizeType item) {
    bool ret = bridgePINVOKE.UnitSizeTypeSet_remove(swigCPtr, UnitSizeType.getCPtr(item));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
