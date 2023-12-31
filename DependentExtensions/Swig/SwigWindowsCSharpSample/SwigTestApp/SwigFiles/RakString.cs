/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;
#pragma warning disable 0660

public class RakString : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RakString(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RakString obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RakString() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_RakString(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }


	public override int GetHashCode()
	{
		return this.C_String().GetHashCode();
	}

	public static bool operator ==(RakString a, RakString b)
	{
 	   	// If both are null, or both are same instance, return true.
 		if (System.Object.ReferenceEquals(a, b))
 		{
 	       		return true;
 	   	}

  		// If one is null, but not both, return false.
   	 	if (((object)a == null) || ((object)b == null))
    		{
       		 	return false;
    		}

		    return a.Equals(b);//Equals should be overloaded as well
	}

	public static bool operator ==(RakString a, string b)
	{
 	   	// If both are null, or both are same instance, return true.
 		if (System.Object.ReferenceEquals(a, b))
 		{
 	       		return true;
 	   	}

  		// If one is null, but not both, return false.
   	 	if (((object)a == null) || ((object)b == null))
    		{
       		 	return false;
    		}

		    return a.Equals(b);//Equals should be overloaded as well
	}

	public static bool operator ==(RakString a, char b)
	{
 	   	// If both are null, or both are same instance, return true.
 		if (System.Object.ReferenceEquals(a, b))
 		{
 	       		return true;
 	   	}

  		// If one is null, but not both, return false.
   	 	if (((object)a == null) || ((object)b == null))
    		{
       		 	return false;
    		}

		    return a.Equals(b);//Equals should be overloaded as well
	}

	public static bool operator !=(RakString a, char b)
	{
   		 return !(a==b);
	}

	public static bool operator !=(RakString a, RakString b)
	{
   		 return a.OpNotEqual(b);
	}

	public static bool operator !=(RakString a, string b)
	{
   		 return a.OpNotEqual(b);
	}

	public static bool operator < (RakString a, RakString b)
	{
    		return a.OpLess(b);
	}

	public static bool operator >(RakString a, RakString b)
	{
		return a.OpGreater(b);
	}

	public static bool operator <=(RakString a, RakString b)
	{
		return a.OpLessEquals(b);
	}

	public static bool operator >=(RakString a, RakString b)
	{
		return a.OpGreaterEquals(b);
	}

	public char this[int index]  
 	{  
		get   
		{
			 return (char)OpArray((uint)index); // use indexto retrieve and return another value.    
		}  
		set   
		{
        		Replace((uint)index,1,(byte)value);// use index and value to set the value somewhere.   
		}  
	}  

	public static RakString operator +(RakString a, RakString b)
	{
		return RakNet.OpPlus(a,b);
	}

	public static implicit operator RakString(String s)
	{
		return new RakString(s);
	} 

	public static implicit operator RakString(char c)
	{
		return new RakString(c);
	} 

	public static implicit operator RakString(byte c)
	{
		return new RakString(c);
	} 
	
	public override string ToString()
	{
		return C_String();
	}

	public void SetChar(uint index, char inChar)
	{
		SetChar(index,(byte)inChar);
	}

	public void Replace(uint index, uint count, char inChar)
	{
		Replace(index,count,(byte)inChar);
	}

  public RakString() : this(RakNetPINVOKE.new_RakString__SWIG_0(), true) {
  }

  public RakString(char input) : this(RakNetPINVOKE.new_RakString__SWIG_1(input), true) {
  }

  public RakString(byte input) : this(RakNetPINVOKE.new_RakString__SWIG_2(input), true) {
  }

  public RakString(string format) : this(RakNetPINVOKE.new_RakString__SWIG_3(format), true) {
  }

  public RakString(RakString rhs) : this(RakNetPINVOKE.new_RakString__SWIG_4(RakString.getCPtr(rhs)), true) {
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public string C_String() {
    string ret = RakNetPINVOKE.RakString_C_String(swigCPtr);
    return ret;
  }

  public string C_StringUnsafe() {
    string ret = RakNetPINVOKE.RakString_C_StringUnsafe(swigCPtr);
    return ret;
  }

  public RakString CopyData(RakString rhs) {
    RakString ret = new RakString(RakNetPINVOKE.RakString_CopyData__SWIG_0(swigCPtr, RakString.getCPtr(rhs)), false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RakString CopyData(string str) {
    RakString ret = new RakString(RakNetPINVOKE.RakString_CopyData__SWIG_1(swigCPtr, str), false);
    return ret;
  }

  public RakString CopyData(SWIGTYPE_p_unsigned_char str) {
    RakString ret = new RakString(RakNetPINVOKE.RakString_CopyData__SWIG_2(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(str)), false);
    return ret;
  }

  public RakString CopyData(char c) {
    RakString ret = new RakString(RakNetPINVOKE.RakString_CopyData__SWIG_4(swigCPtr, c), false);
    return ret;
  }

  private byte OpArray(uint position) {
    byte ret = RakNetPINVOKE.RakString_OpArray(swigCPtr, position);
    return ret;
  }

  public uint Find(string stringToFind, uint pos) {
    uint ret = RakNetPINVOKE.RakString_Find__SWIG_0(swigCPtr, stringToFind, pos);
    return ret;
  }

  public uint Find(string stringToFind) {
    uint ret = RakNetPINVOKE.RakString_Find__SWIG_1(swigCPtr, stringToFind);
    return ret;
  }

  public bool Equals(RakString rhs) {
    bool ret = RakNetPINVOKE.RakString_Equals__SWIG_0(swigCPtr, RakString.getCPtr(rhs));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equals(string str) {
    bool ret = RakNetPINVOKE.RakString_Equals__SWIG_1(swigCPtr, str);
    return ret;
  }

  private bool OpLess(RakString right) {
    bool ret = RakNetPINVOKE.RakString_OpLess(swigCPtr, RakString.getCPtr(right));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool OpLessEquals(RakString right) {
    bool ret = RakNetPINVOKE.RakString_OpLessEquals(swigCPtr, RakString.getCPtr(right));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool OpGreater(RakString right) {
    bool ret = RakNetPINVOKE.RakString_OpGreater(swigCPtr, RakString.getCPtr(right));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool OpGreaterEquals(RakString right) {
    bool ret = RakNetPINVOKE.RakString_OpGreaterEquals(swigCPtr, RakString.getCPtr(right));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool OpNotEqual(RakString rhs) {
    bool ret = RakNetPINVOKE.RakString_OpNotEqual__SWIG_0(swigCPtr, RakString.getCPtr(rhs));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool OpNotEqual(string str) {
    bool ret = RakNetPINVOKE.RakString_OpNotEqual__SWIG_1(swigCPtr, str);
    return ret;
  }

  public string ToLower() {
    string ret = RakNetPINVOKE.RakString_ToLower(swigCPtr);
    return ret;
  }

  public string ToUpper() {
    string ret = RakNetPINVOKE.RakString_ToUpper(swigCPtr);
    return ret;
  }

  public void Set(string format) {
    RakNetPINVOKE.RakString_Set(swigCPtr, format);
  }

  public RakString Assign(string str, uint pos, uint n) {
    RakString ret = new RakString(RakNetPINVOKE.RakString_Assign(swigCPtr, str, pos, n), true);
    return ret;
  }

  public bool IsEmpty() {
    bool ret = RakNetPINVOKE.RakString_IsEmpty(swigCPtr);
    return ret;
  }

  public uint GetLength() {
    uint ret = RakNetPINVOKE.RakString_GetLength(swigCPtr);
    return ret;
  }

  public void Replace(uint index, uint count, byte c) {
    RakNetPINVOKE.RakString_Replace(swigCPtr, index, count, c);
  }

  public void SetChar(uint index, byte c) {
    RakNetPINVOKE.RakString_SetChar__SWIG_0(swigCPtr, index, c);
  }

  public void SetChar(uint index, RakString s) {
    RakNetPINVOKE.RakString_SetChar__SWIG_1(swigCPtr, index, RakString.getCPtr(s));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Truncate(uint length) {
    RakNetPINVOKE.RakString_Truncate(swigCPtr, length);
  }

  public RakString SubStr(uint index, uint count) {
    RakString ret = new RakString(RakNetPINVOKE.RakString_SubStr(swigCPtr, index, count), true);
    return ret;
  }

  public void Erase(uint index, uint count) {
    RakNetPINVOKE.RakString_Erase(swigCPtr, index, count);
  }

  public void TerminateAtFirstCharacter(char c) {
    RakNetPINVOKE.RakString_TerminateAtFirstCharacter(swigCPtr, c);
  }

  public void TerminateAtLastCharacter(char c) {
    RakNetPINVOKE.RakString_TerminateAtLastCharacter(swigCPtr, c);
  }

  public void RemoveCharacter(char c) {
    RakNetPINVOKE.RakString_RemoveCharacter(swigCPtr, c);
  }

  public static RakString NonVariadic(string str) {
    RakString ret = new RakString(RakNetPINVOKE.RakString_NonVariadic(str), true);
    return ret;
  }

  public static uint ToInteger(string str) {
    uint ret = RakNetPINVOKE.RakString_ToInteger__SWIG_0(str);
    return ret;
  }

  public static uint ToInteger(RakString rs) {
    uint ret = RakNetPINVOKE.RakString_ToInteger__SWIG_1(RakString.getCPtr(rs));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int StrCmp(RakString rhs) {
    int ret = RakNetPINVOKE.RakString_StrCmp(swigCPtr, RakString.getCPtr(rhs));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int StrICmp(RakString rhs) {
    int ret = RakNetPINVOKE.RakString_StrICmp(swigCPtr, RakString.getCPtr(rhs));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Clear() {
    RakNetPINVOKE.RakString_Clear(swigCPtr);
  }

  public void Printf() {
    RakNetPINVOKE.RakString_Printf(swigCPtr);
  }

  public bool IPAddressMatch(string IP) {
    bool ret = RakNetPINVOKE.RakString_IPAddressMatch(swigCPtr, IP);
    return ret;
  }

  public bool ContainsNonprintableExceptSpaces() {
    bool ret = RakNetPINVOKE.RakString_ContainsNonprintableExceptSpaces(swigCPtr);
    return ret;
  }

  public bool IsEmailAddress() {
    bool ret = RakNetPINVOKE.RakString_IsEmailAddress(swigCPtr);
    return ret;
  }

  public RakString URLEncode() {
    RakString ret = new RakString(RakNetPINVOKE.RakString_URLEncode(swigCPtr), false);
    return ret;
  }

  public RakString URLDecode() {
    RakString ret = new RakString(RakNetPINVOKE.RakString_URLDecode(swigCPtr), false);
    return ret;
  }

  public void SplitURI(RakString header, RakString domain, RakString path) {
    RakNetPINVOKE.RakString_SplitURI(swigCPtr, RakString.getCPtr(header), RakString.getCPtr(domain), RakString.getCPtr(path));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public RakString SQLEscape() {
    RakString ret = new RakString(RakNetPINVOKE.RakString_SQLEscape(swigCPtr), false);
    return ret;
  }

  public RakString MakeFilePath() {
    RakString ret = new RakString(RakNetPINVOKE.RakString_MakeFilePath(swigCPtr), false);
    return ret;
  }

  public static void FreeMemory() {
    RakNetPINVOKE.RakString_FreeMemory();
  }

  public static void FreeMemoryNoMutex() {
    RakNetPINVOKE.RakString_FreeMemoryNoMutex();
  }

  public void Serialize(BitStream bs) {
    RakNetPINVOKE.RakString_Serialize__SWIG_0(swigCPtr, BitStream.getCPtr(bs));
  }

  public static void Serialize(string str, BitStream bs) {
    RakNetPINVOKE.RakString_Serialize__SWIG_1(str, BitStream.getCPtr(bs));
  }

  public void SerializeCompressed(BitStream bs, int languageId, bool writeLanguageId) {
    RakNetPINVOKE.RakString_SerializeCompressed__SWIG_0(swigCPtr, BitStream.getCPtr(bs), languageId, writeLanguageId);
  }

  public void SerializeCompressed(BitStream bs, int languageId) {
    RakNetPINVOKE.RakString_SerializeCompressed__SWIG_1(swigCPtr, BitStream.getCPtr(bs), languageId);
  }

  public void SerializeCompressed(BitStream bs) {
    RakNetPINVOKE.RakString_SerializeCompressed__SWIG_2(swigCPtr, BitStream.getCPtr(bs));
  }

  public static void SerializeCompressed(string str, BitStream bs, int languageId, bool writeLanguageId) {
    RakNetPINVOKE.RakString_SerializeCompressed__SWIG_3(str, BitStream.getCPtr(bs), languageId, writeLanguageId);
  }

  public static void SerializeCompressed(string str, BitStream bs, int languageId) {
    RakNetPINVOKE.RakString_SerializeCompressed__SWIG_4(str, BitStream.getCPtr(bs), languageId);
  }

  public static void SerializeCompressed(string str, BitStream bs) {
    RakNetPINVOKE.RakString_SerializeCompressed__SWIG_5(str, BitStream.getCPtr(bs));
  }

  public bool Deserialize(BitStream bs) {
    bool ret = RakNetPINVOKE.RakString_Deserialize__SWIG_0(swigCPtr, BitStream.getCPtr(bs));
    return ret;
  }

  public static bool Deserialize(string str, BitStream bs) {
    bool ret = RakNetPINVOKE.RakString_Deserialize__SWIG_1(str, BitStream.getCPtr(bs));
    return ret;
  }

  public bool DeserializeCompressed(BitStream bs, bool readLanguageId) {
    bool ret = RakNetPINVOKE.RakString_DeserializeCompressed__SWIG_0(swigCPtr, BitStream.getCPtr(bs), readLanguageId);
    return ret;
  }

  public bool DeserializeCompressed(BitStream bs) {
    bool ret = RakNetPINVOKE.RakString_DeserializeCompressed__SWIG_1(swigCPtr, BitStream.getCPtr(bs));
    return ret;
  }

  public static bool DeserializeCompressed(string str, BitStream bs, bool readLanguageId) {
    bool ret = RakNetPINVOKE.RakString_DeserializeCompressed__SWIG_2(str, BitStream.getCPtr(bs), readLanguageId);
    return ret;
  }

  public static bool DeserializeCompressed(string str, BitStream bs) {
    bool ret = RakNetPINVOKE.RakString_DeserializeCompressed__SWIG_3(str, BitStream.getCPtr(bs));
    return ret;
  }

  public static string ToString(long i) {
    string ret = RakNetPINVOKE.RakString_ToString__SWIG_0(i);
    return ret;
  }

  public static string ToString(ulong i) {
    string ret = RakNetPINVOKE.RakString_ToString__SWIG_1(i);
    return ret;
  }

  public static uint GetSizeToAllocate(uint bytes) {
    uint ret = RakNetPINVOKE.RakString_GetSizeToAllocate(bytes);
    return ret;
  }

  public static int RakStringComp(RakString key, RakString data) {
    int ret = RakNetPINVOKE.RakString_RakStringComp(RakString.getCPtr(key), RakString.getCPtr(data));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void LockMutex() {
    RakNetPINVOKE.RakString_LockMutex();
  }

  public static void UnlockMutex() {
    RakNetPINVOKE.RakString_UnlockMutex();
  }

  public void AppendBytes(byte[] inByteArray, uint count) {
    RakNetPINVOKE.RakString_AppendBytes(swigCPtr, inByteArray, count);
  }

}

}
