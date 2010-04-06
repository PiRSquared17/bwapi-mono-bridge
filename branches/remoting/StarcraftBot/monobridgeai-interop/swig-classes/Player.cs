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

public partial class Player : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Player(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Player obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Player() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_Player(swigCPtr);
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
    if (obj is Player)
      equal = (((Player)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(Player obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(Player obj1, Player obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(Player obj1, Player obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public virtual int getID() {
    int ret = bridgePINVOKE.Player_getID(swigCPtr);
    return ret;
  }

  public virtual string getName() {
    string ret = bridgePINVOKE.Player_getName(swigCPtr);
    return ret;
  }

  public virtual UnitSet getUnits() {
    UnitSet ret = new UnitSet(bridgePINVOKE.Player_getUnits(swigCPtr), false);
    return ret;
  }

  public virtual Race getRace() {
    Race ret = new Race(bridgePINVOKE.Player_getRace(swigCPtr), true);
    return ret;
  }

  public virtual PlayerType playerType() {
    PlayerType ret = new PlayerType(bridgePINVOKE.Player_playerType(swigCPtr), true);
    return ret;
  }

  public virtual Force getForce() {
    IntPtr cPtr = bridgePINVOKE.Player_getForce(swigCPtr);
    Force ret = (cPtr == IntPtr.Zero) ? null : new Force(cPtr, false);
    return ret;
  }

  public virtual bool isAlly(Player player) {
    bool ret = bridgePINVOKE.Player_isAlly(swigCPtr, Player.getCPtr(player));
    return ret;
  }

  public virtual bool isEnemy(Player player) {
    bool ret = bridgePINVOKE.Player_isEnemy(swigCPtr, Player.getCPtr(player));
    return ret;
  }

  public virtual bool isNeutral() {
    bool ret = bridgePINVOKE.Player_isNeutral(swigCPtr);
    return ret;
  }

  public virtual TilePosition getStartLocation() {
    TilePosition ret = new TilePosition(bridgePINVOKE.Player_getStartLocation(swigCPtr), true);
    return ret;
  }

  public virtual bool isVictorious() {
    bool ret = bridgePINVOKE.Player_isVictorious(swigCPtr);
    return ret;
  }

  public virtual bool isDefeated() {
    bool ret = bridgePINVOKE.Player_isDefeated(swigCPtr);
    return ret;
  }

  public virtual bool leftGame() {
    bool ret = bridgePINVOKE.Player_leftGame(swigCPtr);
    return ret;
  }

  public virtual int minerals() {
    int ret = bridgePINVOKE.Player_minerals(swigCPtr);
    return ret;
  }

  public virtual int gas() {
    int ret = bridgePINVOKE.Player_gas(swigCPtr);
    return ret;
  }

  public virtual int cumulativeMinerals() {
    int ret = bridgePINVOKE.Player_cumulativeMinerals(swigCPtr);
    return ret;
  }

  public virtual int cumulativeGas() {
    int ret = bridgePINVOKE.Player_cumulativeGas(swigCPtr);
    return ret;
  }

  public virtual int supplyTotal() {
    int ret = bridgePINVOKE.Player_supplyTotal__SWIG_0(swigCPtr);
    return ret;
  }

  public virtual int supplyUsed() {
    int ret = bridgePINVOKE.Player_supplyUsed__SWIG_0(swigCPtr);
    return ret;
  }

  public virtual int supplyTotal(Race race) {
    int ret = bridgePINVOKE.Player_supplyTotal__SWIG_1(swigCPtr, Race.getCPtr(race));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int supplyUsed(Race race) {
    int ret = bridgePINVOKE.Player_supplyUsed__SWIG_1(swigCPtr, Race.getCPtr(race));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int allUnitCount(UnitType unit) {
    int ret = bridgePINVOKE.Player_allUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int completedUnitCount(UnitType unit) {
    int ret = bridgePINVOKE.Player_completedUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int incompleteUnitCount(UnitType unit) {
    int ret = bridgePINVOKE.Player_incompleteUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int deadUnitCount(UnitType unit) {
    int ret = bridgePINVOKE.Player_deadUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int killedUnitCount(UnitType unit) {
    int ret = bridgePINVOKE.Player_killedUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int getUpgradeLevel(UpgradeType upgrade) {
    int ret = bridgePINVOKE.Player_getUpgradeLevel(swigCPtr, UpgradeType.getCPtr(upgrade));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool hasResearched(TechType tech) {
    bool ret = bridgePINVOKE.Player_hasResearched(swigCPtr, TechType.getCPtr(tech));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isResearching(TechType tech) {
    bool ret = bridgePINVOKE.Player_isResearching(swigCPtr, TechType.getCPtr(tech));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isUpgrading(UpgradeType upgrade) {
    bool ret = bridgePINVOKE.Player_isUpgrading(swigCPtr, UpgradeType.getCPtr(upgrade));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
