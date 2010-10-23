/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class Polygon : PositionVector {
  private HandleRef swigCPtr;

  internal Polygon(IntPtr cPtr, bool cMemoryOwn) : base(bridgePINVOKE.Polygon_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Polygon obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Polygon() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_Polygon(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
public override int GetHashCode()
{
   return this.swigCPtr.Handle.GetHashCode();
}

public override bool Equals(object obj)
{
    bool equal = false;
    if (obj is Polygon)
      equal = (((Polygon)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(Polygon obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(Polygon obj1, Polygon obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(Polygon obj1, Polygon obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public Polygon() : this(bridgePINVOKE.new_Polygon__SWIG_0(), true) {
  }

  public Polygon(Polygon b) : this(bridgePINVOKE.new_Polygon__SWIG_1(Polygon.getCPtr(b)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public double getArea() {
    double ret = bridgePINVOKE.Polygon_getArea(swigCPtr);
    return ret;
  }

  public double getPerimeter() {
    double ret = bridgePINVOKE.Polygon_getPerimeter(swigCPtr);
    return ret;
  }

  public Position getCenter() {
    Position ret = new Position(bridgePINVOKE.Polygon_getCenter(swigCPtr), true);
    return ret;
  }

  public bool isInside(Position p) {
    bool ret = bridgePINVOKE.Polygon_isInside(swigCPtr, Position.getCPtr(p));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Position getNearestPoint(Position p) {
    Position ret = new Position(bridgePINVOKE.Polygon_getNearestPoint(swigCPtr, Position.getCPtr(p)), true);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PolygonVector getHoles() {
    PolygonVector ret = new PolygonVector(bridgePINVOKE.Polygon_getHoles(swigCPtr), false);
    return ret;
  }

  public PolygonVector holes {
    set {
      bridgePINVOKE.Polygon_holes_set(swigCPtr, PolygonVector.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.Polygon_holes_get(swigCPtr);
      PolygonVector ret = (cPtr == IntPtr.Zero) ? null : new PolygonVector(cPtr, false);
      return ret;
    } 
  }

}

}
