/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SWIG.BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class Position : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Position(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Position obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Position() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_Position(swigCPtr);
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
    if (obj is Position)
      equal = (((Position)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(Position obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(Position obj1, Position obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(Position obj1, Position obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public Position() : this(bwapiPINVOKE.new_Position__SWIG_0(), true) {
  }

  public Position(TilePosition position) : this(bwapiPINVOKE.new_Position__SWIG_1(TilePosition.getCPtr(position)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public Position(int x, int y) : this(bwapiPINVOKE.new_Position__SWIG_2(x, y), true) {
  }

  public bool opEquals(Position position) {
    bool ret = bwapiPINVOKE.Position_opEquals(swigCPtr, Position.getCPtr(position));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(Position position) {
    bool ret = bwapiPINVOKE.Position_opNotEquals(swigCPtr, Position.getCPtr(position));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(Position position) {
    bool ret = bwapiPINVOKE.Position_opLessThan(swigCPtr, Position.getCPtr(position));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isValid() {
    bool ret = bwapiPINVOKE.Position_isValid(swigCPtr);
    return ret;
  }

  public Position opPlus(Position position) {
    Position ret = new Position(bwapiPINVOKE.Position_opPlus(swigCPtr, Position.getCPtr(position)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Position opMinus(Position position) {
    Position ret = new Position(bwapiPINVOKE.Position_opMinus(swigCPtr, Position.getCPtr(position)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Position makeValid() {
    Position ret = new Position(bwapiPINVOKE.Position_makeValid(swigCPtr), false);
    return ret;
  }

  public Position opAdd(Position position) {
    Position ret = new Position(bwapiPINVOKE.Position_opAdd(swigCPtr, Position.getCPtr(position)), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Position opSubtract(Position position) {
    Position ret = new Position(bwapiPINVOKE.Position_opSubtract(swigCPtr, Position.getCPtr(position)), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getDistance(Position position) {
    double ret = bwapiPINVOKE.Position_getDistance(swigCPtr, Position.getCPtr(position));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getApproxDistance(Position position) {
    int ret = bwapiPINVOKE.Position_getApproxDistance(swigCPtr, Position.getCPtr(position));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getLength() {
    double ret = bwapiPINVOKE.Position_getLength(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_int x() {
    SWIGTYPE_p_int ret = new SWIGTYPE_p_int(bwapiPINVOKE.Position_x(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_int y() {
    SWIGTYPE_p_int ret = new SWIGTYPE_p_int(bwapiPINVOKE.Position_y(swigCPtr), false);
    return ret;
  }

  public int xConst() {
    int ret = bwapiPINVOKE.Position_xConst(swigCPtr);
    return ret;
  }

  public int yConst() {
    int ret = bwapiPINVOKE.Position_yConst(swigCPtr);
    return ret;
  }

}

}
