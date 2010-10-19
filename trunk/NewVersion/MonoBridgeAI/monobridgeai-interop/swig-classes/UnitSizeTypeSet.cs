/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class UnitSizeTypeSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<UnitSizeType>
#endif
 {
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


  
  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get { 
      return false; 
    }
  }

#if !SWIG_DOTNET_1
 public System.Collections.Generic.ICollection<UnitSizeType> Values {
    get {
      System.Collections.Generic.ICollection<UnitSizeType> values = new System.Collections.Generic.List<UnitSizeType>();
      IntPtr iter = create_iterator_begin();
      try {
        while (true) {
          values.Add(get_next_key(iter));
        }
      } catch (ArgumentOutOfRangeException) {
      }
      return values;
    }
  }
 
  public bool Contains(UnitSizeType item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(UnitSizeType[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( UnitSizeType[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<UnitSizeType> keyList = new System.Collections.Generic.List<UnitSizeType>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      UnitSizeType currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< UnitSizeType> System.Collections.Generic.IEnumerable<UnitSizeType>.GetEnumerator() {
    return new UnitSizeTypeSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new UnitSizeTypeSetEnumerator(this);
  }

  public UnitSizeTypeSetEnumerator GetEnumerator() {
    return new UnitSizeTypeSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class UnitSizeTypeSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< UnitSizeType>
  {
    private UnitSizeTypeSet collectionRef;
    private System.Collections.Generic.IList<UnitSizeType> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public UnitSizeTypeSetEnumerator(UnitSizeTypeSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<UnitSizeType>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  UnitSizeType Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( UnitSizeType)currentObject;
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
        UnitSizeType currentKey = keyCollection[currentIndex];
        currentObject = currentKey;
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

    public void Dispose() {
      currentIndex = -1;
      currentObject = null;
    }
  }
#endif
  

  public UnitSizeTypeSet() : this(bridgePINVOKE.new_UnitSizeTypeSet__SWIG_0(), true) {
  }

  public UnitSizeTypeSet(UnitSizeTypeSet other) : this(bridgePINVOKE.new_UnitSizeTypeSet__SWIG_1(UnitSizeTypeSet.getCPtr(other)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bridgePINVOKE.UnitSizeTypeSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bridgePINVOKE.UnitSizeTypeSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bridgePINVOKE.UnitSizeTypeSet_Clear(swigCPtr);
  }

  public UnitSizeType getitem(UnitSizeType key) {
    UnitSizeType ret = new UnitSizeType(bridgePINVOKE.UnitSizeTypeSet_getitem(swigCPtr, UnitSizeType.getCPtr(key)), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(UnitSizeType key) {
    bool ret = bridgePINVOKE.UnitSizeTypeSet_ContainsKey(swigCPtr, UnitSizeType.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(UnitSizeType key) {
    bridgePINVOKE.UnitSizeTypeSet_Add(swigCPtr, UnitSizeType.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(UnitSizeType key) {
    bool ret = bridgePINVOKE.UnitSizeTypeSet_Remove(swigCPtr, UnitSizeType.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bridgePINVOKE.UnitSizeTypeSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public UnitSizeType get_next_key(IntPtr swigiterator) {
    UnitSizeType ret = new UnitSizeType(bridgePINVOKE.UnitSizeTypeSet_get_next_key(swigCPtr, swigiterator), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
