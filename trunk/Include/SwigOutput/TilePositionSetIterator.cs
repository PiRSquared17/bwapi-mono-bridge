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

public class TilePositionSetIterator : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TilePositionSetIterator(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TilePositionSetIterator obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TilePositionSetIterator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_TilePositionSetIterator(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public TilePositionSetIterator(SWIGTYPE_p_std__setT_BWAPI__TilePosition_t original) : this(bridgePINVOKE.new_TilePositionSetIterator(SWIGTYPE_p_std__setT_BWAPI__TilePosition_t.getCPtr(original)), true) {
  }

  public bool hasNext() {
    bool ret = bridgePINVOKE.TilePositionSetIterator_hasNext(swigCPtr);
    return ret;
  }

  public TilePosition next() {
    TilePosition ret = new TilePosition(bridgePINVOKE.TilePositionSetIterator_next(swigCPtr), true);
    return ret;
  }

}

}
