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

public class AttackType : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AttackType(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AttackType obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~AttackType() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_AttackType(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public AttackType() : this(bridgePINVOKE.new_AttackType__SWIG_0(), true) {
  }

  public AttackType(int id) : this(bridgePINVOKE.new_AttackType__SWIG_1(id), true) {
  }

  public AttackType(AttackType other) : this(bridgePINVOKE.new_AttackType__SWIG_2(AttackType.getCPtr(other)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public AttackType opAssign(AttackType other) {
    AttackType ret = new AttackType(bridgePINVOKE.AttackType_opAssign(swigCPtr, AttackType.getCPtr(other)), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opEquals(AttackType other) {
    bool ret = bridgePINVOKE.AttackType_opEquals(swigCPtr, AttackType.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(AttackType other) {
    bool ret = bridgePINVOKE.AttackType_opNotEquals(swigCPtr, AttackType.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(AttackType other) {
    bool ret = bridgePINVOKE.AttackType_opLessThan(swigCPtr, AttackType.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getID() {
    int ret = bridgePINVOKE.AttackType_getID(swigCPtr);
    return ret;
  }

  public string getName() {
    string ret = bridgePINVOKE.AttackType_getName(swigCPtr);
    return ret;
  }

}

}
