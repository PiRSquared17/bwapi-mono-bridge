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

public class ChokepointSet : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChokepointSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ChokepointSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChokepointSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_ChokepointSet(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ChokepointSet(SWIGTYPE_p_std__setT_BWTA__Chokepoint_p_t original) : this(bridgePINVOKE.new_ChokepointSet(SWIGTYPE_p_std__setT_BWTA__Chokepoint_p_t.getCPtr(original)), true) {
  }

  public int size() {
    int ret = bridgePINVOKE.ChokepointSet_size(swigCPtr);
    return ret;
  }

  public bool contains(Chokepoint item) {
    bool ret = bridgePINVOKE.ChokepointSet_contains(swigCPtr, Chokepoint.getCPtr(item));
    return ret;
  }

  public bool add(Chokepoint item) {
    bool ret = bridgePINVOKE.ChokepointSet_add(swigCPtr, Chokepoint.getCPtr(item));
    return ret;
  }

  public void clear() {
    bridgePINVOKE.ChokepointSet_clear(swigCPtr);
  }

  public bool remove(Chokepoint item) {
    bool ret = bridgePINVOKE.ChokepointSet_remove(swigCPtr, Chokepoint.getCPtr(item));
    return ret;
  }

}

}
