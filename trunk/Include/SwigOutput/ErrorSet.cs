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

public class ErrorSet : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ErrorSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ErrorSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ErrorSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_ErrorSet(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ErrorSet(SWIGTYPE_p_std__setT_BWAPI__Error_t original) : this(bridgePINVOKE.new_ErrorSet(SWIGTYPE_p_std__setT_BWAPI__Error_t.getCPtr(original)), true) {
  }

  public int size() {
    int ret = bridgePINVOKE.ErrorSet_size(swigCPtr);
    return ret;
  }

  public bool contains(Error item) {
    bool ret = bridgePINVOKE.ErrorSet_contains(swigCPtr, Error.getCPtr(item));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool add(Error item) {
    bool ret = bridgePINVOKE.ErrorSet_add(swigCPtr, Error.getCPtr(item));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void clear() {
    bridgePINVOKE.ErrorSet_clear(swigCPtr);
  }

  public bool remove(Error item) {
    bool ret = bridgePINVOKE.ErrorSet_remove(swigCPtr, Error.getCPtr(item));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
