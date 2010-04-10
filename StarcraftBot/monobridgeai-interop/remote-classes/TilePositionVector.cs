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

public partial class TilePositionVector : IDisposable, System.Collections.IEnumerable
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerable<TilePosition>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TilePositionVector(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TilePositionVector obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TilePositionVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKEProxy.remote.delete_TilePositionVector(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public TilePositionVector(System.Collections.ICollection c) : this() {
    if (c == null)
      throw new ArgumentNullException("c");
    foreach (TilePosition element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public TilePosition this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array)
#else
  public void CopyTo(TilePosition[] array)
#endif
  {
    CopyTo(0, array, 0, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array, int arrayIndex)
#else
  public void CopyTo(TilePosition[] array, int arrayIndex)
#endif
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(int index, System.Array array, int arrayIndex, int count)
#else
  public void CopyTo(int index, TilePosition[] array, int arrayIndex, int count)
#endif
  {
    if (array == null)
      throw new ArgumentNullException("array");
    if (index < 0)
      throw new ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

#if !SWIG_DOTNET_1
  System.Collections.Generic.IEnumerator<TilePosition> System.Collections.Generic.IEnumerable<TilePosition>.GetEnumerator() {
    return new TilePositionVectorEnumerator(this);
  }
#endif

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new TilePositionVectorEnumerator(this);
  }

  public TilePositionVectorEnumerator GetEnumerator() {
    return new TilePositionVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class TilePositionVectorEnumerator : System.Collections.IEnumerator
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerator<TilePosition>
#endif
  {
    private TilePositionVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public TilePositionVectorEnumerator(TilePositionVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public TilePosition Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (TilePosition)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }

#if !SWIG_DOTNET_1
    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
#endif
  }

  public void Clear() {
    bridgePINVOKEProxy.remote.TilePositionVector_Clear(swigCPtr);
  }

  public void Add(TilePosition x) {
    bridgePINVOKEProxy.remote.TilePositionVector_Add(swigCPtr, TilePosition.getCPtr(x));
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bridgePINVOKEProxy.remote.TilePositionVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = bridgePINVOKEProxy.remote.TilePositionVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    bridgePINVOKEProxy.remote.TilePositionVector_reserve(swigCPtr, n);
  }

  public TilePositionVector() : this(bridgePINVOKEProxy.remote.new_TilePositionVector__SWIG_0(), true) {
  }

  public TilePositionVector(TilePositionVector other) : this(bridgePINVOKEProxy.remote.new_TilePositionVector__SWIG_1(TilePositionVector.getCPtr(other)), true) {
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
  }

  public TilePositionVector(int capacity) : this(bridgePINVOKEProxy.remote.new_TilePositionVector__SWIG_2(capacity), true) {
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
  }

  private TilePosition getitemcopy(int index) {
    TilePosition ret = new TilePosition(bridgePINVOKEProxy.remote.TilePositionVector_getitemcopy(swigCPtr, index), true);
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
    return ret;
  }

  private TilePosition getitem(int index) {
    TilePosition ret = new TilePosition(bridgePINVOKEProxy.remote.TilePositionVector_getitem(swigCPtr, index), false);
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, TilePosition val) {
    bridgePINVOKEProxy.remote.TilePositionVector_setitem(swigCPtr, index, TilePosition.getCPtr(val));
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
  }

  public void AddRange(TilePositionVector values) {
    bridgePINVOKEProxy.remote.TilePositionVector_AddRange(swigCPtr, TilePositionVector.getCPtr(values));
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
  }

  public TilePositionVector GetRange(int index, int count) {
    IntPtr cPtr = bridgePINVOKEProxy.remote.TilePositionVector_GetRange(swigCPtr, index, count);
    TilePositionVector ret = (cPtr == IntPtr.Zero) ? null : new TilePositionVector(cPtr, true);
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, TilePosition x) {
    bridgePINVOKEProxy.remote.TilePositionVector_Insert(swigCPtr, index, TilePosition.getCPtr(x));
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, TilePositionVector values) {
    bridgePINVOKEProxy.remote.TilePositionVector_InsertRange(swigCPtr, index, TilePositionVector.getCPtr(values));
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    bridgePINVOKEProxy.remote.TilePositionVector_RemoveAt(swigCPtr, index);
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    bridgePINVOKEProxy.remote.TilePositionVector_RemoveRange(swigCPtr, index, count);
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
  }

  public static TilePositionVector Repeat(TilePosition value, int count) {
    IntPtr cPtr = bridgePINVOKEProxy.remote.TilePositionVector_Repeat(TilePosition.getCPtr(value), count);
    TilePositionVector ret = (cPtr == IntPtr.Zero) ? null : new TilePositionVector(cPtr, true);
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    bridgePINVOKEProxy.remote.TilePositionVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    bridgePINVOKEProxy.remote.TilePositionVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, TilePositionVector values) {
    bridgePINVOKEProxy.remote.TilePositionVector_SetRange(swigCPtr, index, TilePositionVector.getCPtr(values));
    if (bridgePINVOKEProxy.remote.SWIGPendingException.Pending) throw bridgePINVOKEProxy.remote.SWIGPendingException.Retrieve();
  }

}

}
