using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkDataArraySelection
	/// </summary>
	/// <remarks>
	///  Store on/off settings for data arrays, etc.
	///
	/// vtkDataArraySelection is intended to be used by algorithms that want to
	/// expose a API that allow the user to enable/disable a collection of entities,
	/// such as arrays. Readers, for example, can use vtkDataArraySelection to let
	/// the user choose which array to read from the file.
	///
	/// Originally intended for selecting data arrays (hence the name), this class
	/// can be used for letting users choose other items too, for example,
	/// vtkIOSSReader uses vtkDataArraySelection to let users choose
	/// which blocks to read.
	///
	/// Unlike most other vtkObject subclasses, vtkDataArraySelection has public API
	/// that need not modify the MTime for the object. These M-Time non-modifying
	/// methods are typically intended for use within the algorithm or reader to
	/// populate the vtkDataArraySelection instance with available array names and
	/// their default values.
	/// </remarks>
	// Token: 0x02000B4E RID: 2894
	public class vtkDataArraySelection : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E3A6 RID: 123814 RVA: 0x002AC437 File Offset: 0x002AA637
		static vtkDataArraySelection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataArraySelection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataArraySelection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E3A7 RID: 123815 RVA: 0x002AC45F File Offset: 0x002AA65F
		public vtkDataArraySelection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E3A8 RID: 123816
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArraySelection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E3A9 RID: 123817 RVA: 0x002AC470 File Offset: 0x002AA670
		public new static vtkDataArraySelection New()
		{
			vtkDataArraySelection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArraySelection.vtkDataArraySelection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E3AA RID: 123818 RVA: 0x002AC4C4 File Offset: 0x002AA6C4
		public vtkDataArraySelection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataArraySelection.vtkDataArraySelection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E3AB RID: 123819 RVA: 0x002AC508 File Offset: 0x002AA708
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E3AC RID: 123820
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArraySelection_AddArray_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, byte state);

		/// <summary>
		/// Add to the list of arrays that have entries.  For arrays that
		/// already have entries, the settings are untouched.  For arrays
		/// that don't already have an entry, they are assumed to be enabled
		/// by default. The state can also be passed as the second argument.
		/// This method should be called only by the filter owning this
		/// object.
		///
		/// This method **does not** call `this-&gt;Modified()`.
		///
		/// Also note for arrays already known to this instance (i.e.
		/// `this-&gt;ArrayExists(name) == true`, this method has no effect.
		/// </summary>
		// Token: 0x0601E3AD RID: 123821 RVA: 0x002AC514 File Offset: 0x002AA714
		public int AddArray(string name, bool state)
		{
			return vtkDataArraySelection.vtkDataArraySelection_AddArray_01(base.GetCppThis(), name, state ? (byte)1 : (byte)0);
		}

		// Token: 0x0601E3AE RID: 123822
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArraySelection_ArrayExists_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return whether the array with the given name exists.
		/// </summary>
		// Token: 0x0601E3AF RID: 123823 RVA: 0x002AC540 File Offset: 0x002AA740
		public int ArrayExists(string name)
		{
			return vtkDataArraySelection.vtkDataArraySelection_ArrayExists_02(base.GetCppThis(), name);
		}

		// Token: 0x0601E3B0 RID: 123824
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArraySelection_ArrayIsEnabled_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return whether the array with the given name is enabled.  If
		/// there is no entry, the array is assumed to be disabled.
		/// </summary>
		// Token: 0x0601E3B1 RID: 123825 RVA: 0x002AC560 File Offset: 0x002AA760
		public int ArrayIsEnabled(string name)
		{
			return vtkDataArraySelection.vtkDataArraySelection_ArrayIsEnabled_03(base.GetCppThis(), name);
		}

		// Token: 0x0601E3B2 RID: 123826
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArraySelection_CopySelections_04(HandleRef pThis, HandleRef selections);

		/// <summary>
		/// Copy the selections from the given vtkDataArraySelection instance.
		///
		/// This method will call `this-&gt;Modified()` if the array selections changed.
		/// </summary>
		// Token: 0x0601E3B3 RID: 123827 RVA: 0x002AC580 File Offset: 0x002AA780
		public void CopySelections(vtkDataArraySelection selections)
		{
			vtkDataArraySelection.vtkDataArraySelection_CopySelections_04(base.GetCppThis(), (selections == null) ? default(HandleRef) : selections.GetCppThis());
		}

		// Token: 0x0601E3B4 RID: 123828
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArraySelection_DeepCopy_05(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Copy contents of other. The MTime for this instance is modified only if
		/// values are different.
		/// </summary>
		// Token: 0x0601E3B5 RID: 123829 RVA: 0x002AC5B0 File Offset: 0x002AA7B0
		public void DeepCopy(vtkDataArraySelection other)
		{
			vtkDataArraySelection.vtkDataArraySelection_DeepCopy_05(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0601E3B6 RID: 123830
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArraySelection_DisableAllArrays_06(HandleRef pThis);

		/// <summary>
		/// Disable all arrays that currently have an entry.
		///
		/// This method will call `this-&gt;Modified()` if the enable state for any of the known
		/// arrays is changed.
		/// </summary>
		// Token: 0x0601E3B7 RID: 123831 RVA: 0x002AC5DF File Offset: 0x002AA7DF
		public void DisableAllArrays()
		{
			vtkDataArraySelection.vtkDataArraySelection_DisableAllArrays_06(base.GetCppThis());
		}

		// Token: 0x0601E3B8 RID: 123832
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArraySelection_DisableArray_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Disable the array with the given name.  Creates a new entry if
		/// none exists.
		///
		/// This method will call `this-&gt;Modified()` if the enable state for the
		/// array changed.
		/// </summary>
		// Token: 0x0601E3B9 RID: 123833 RVA: 0x002AC5EE File Offset: 0x002AA7EE
		public void DisableArray(string name)
		{
			vtkDataArraySelection.vtkDataArraySelection_DisableArray_07(base.GetCppThis(), name);
		}

		// Token: 0x0601E3BA RID: 123834
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArraySelection_EnableAllArrays_08(HandleRef pThis);

		/// <summary>
		/// Enable all arrays that currently have an entry.
		///
		/// This method will call `this-&gt;Modified()` if the enable state for any of the known
		/// arrays is changed.
		/// </summary>
		// Token: 0x0601E3BB RID: 123835 RVA: 0x002AC5FE File Offset: 0x002AA7FE
		public void EnableAllArrays()
		{
			vtkDataArraySelection.vtkDataArraySelection_EnableAllArrays_08(base.GetCppThis());
		}

		// Token: 0x0601E3BC RID: 123836
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArraySelection_EnableArray_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Enable the array with the given name.  Creates a new entry if
		/// none exists.
		///
		/// This method will call `this-&gt;Modified()` if the enable state for the
		/// array changed.
		/// </summary>
		// Token: 0x0601E3BD RID: 123837 RVA: 0x002AC60D File Offset: 0x002AA80D
		public void EnableArray(string name)
		{
			vtkDataArraySelection.vtkDataArraySelection_EnableArray_09(base.GetCppThis(), name);
		}

		// Token: 0x0601E3BE RID: 123838
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArraySelection_GetArrayIndex_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get an index of the array with the given name.
		/// </summary>
		// Token: 0x0601E3BF RID: 123839 RVA: 0x002AC620 File Offset: 0x002AA820
		public int GetArrayIndex(string name)
		{
			return vtkDataArraySelection.vtkDataArraySelection_GetArrayIndex_10(base.GetCppThis(), name);
		}

		// Token: 0x0601E3C0 RID: 123840
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArraySelection_GetArrayName_11(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the array entry at the given index.
		/// </summary>
		// Token: 0x0601E3C1 RID: 123841 RVA: 0x002AC640 File Offset: 0x002AA840
		public string GetArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataArraySelection.vtkDataArraySelection_GetArrayName_11(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601E3C2 RID: 123842
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArraySelection_GetArraySetting_12(HandleRef pThis, int index);

		/// <summary>
		/// Get whether the array at the given index is enabled.
		/// </summary>
		// Token: 0x0601E3C3 RID: 123843 RVA: 0x002AC67C File Offset: 0x002AA87C
		public int GetArraySetting(int index)
		{
			return vtkDataArraySelection.vtkDataArraySelection_GetArraySetting_12(base.GetCppThis(), index);
		}

		// Token: 0x0601E3C4 RID: 123844
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArraySelection_GetArraySetting_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get whether the array is enabled/disable using its name.
		/// </summary>
		// Token: 0x0601E3C5 RID: 123845 RVA: 0x002AC69C File Offset: 0x002AA89C
		public int GetArraySetting(string name)
		{
			return vtkDataArraySelection.vtkDataArraySelection_GetArraySetting_13(base.GetCppThis(), name);
		}

		// Token: 0x0601E3C6 RID: 123846
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArraySelection_GetEnabledArrayIndex_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get the index of an array with the given name among those
		/// that are enabled.  Returns -1 if the array is not enabled.
		/// </summary>
		// Token: 0x0601E3C7 RID: 123847 RVA: 0x002AC6BC File Offset: 0x002AA8BC
		public int GetEnabledArrayIndex(string name)
		{
			return vtkDataArraySelection.vtkDataArraySelection_GetEnabledArrayIndex_14(base.GetCppThis(), name);
		}

		// Token: 0x0601E3C8 RID: 123848
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArraySelection_GetNumberOfArrays_15(HandleRef pThis);

		/// <summary>
		/// Get the number of arrays that currently have an entry.
		/// </summary>
		// Token: 0x0601E3C9 RID: 123849 RVA: 0x002AC6DC File Offset: 0x002AA8DC
		public int GetNumberOfArrays()
		{
			return vtkDataArraySelection.vtkDataArraySelection_GetNumberOfArrays_15(base.GetCppThis());
		}

		// Token: 0x0601E3CA RID: 123850
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArraySelection_GetNumberOfArraysEnabled_16(HandleRef pThis);

		/// <summary>
		/// Get the number of arrays that are enabled.
		/// </summary>
		// Token: 0x0601E3CB RID: 123851 RVA: 0x002AC6FC File Offset: 0x002AA8FC
		public int GetNumberOfArraysEnabled()
		{
			return vtkDataArraySelection.vtkDataArraySelection_GetNumberOfArraysEnabled_16(base.GetCppThis());
		}

		// Token: 0x0601E3CC RID: 123852
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataArraySelection_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E3CD RID: 123853 RVA: 0x002AC71C File Offset: 0x002AA91C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataArraySelection.vtkDataArraySelection_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0601E3CE RID: 123854
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataArraySelection_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E3CF RID: 123855 RVA: 0x002AC73C File Offset: 0x002AA93C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataArraySelection.vtkDataArraySelection_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0601E3D0 RID: 123856
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArraySelection_GetUnknownArraySetting_19(HandleRef pThis);

		/// <summary>
		/// Get/Set enabled state for any unknown arrays. Default is 0 i.e. not
		/// enabled. When set to 1, `ArrayIsEnabled` will return 1 for any
		/// array not explicitly specified.
		/// </summary>
		// Token: 0x0601E3D1 RID: 123857 RVA: 0x002AC758 File Offset: 0x002AA958
		public virtual int GetUnknownArraySetting()
		{
			return vtkDataArraySelection.vtkDataArraySelection_GetUnknownArraySetting_19(base.GetCppThis());
		}

		// Token: 0x0601E3D2 RID: 123858
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArraySelection_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E3D3 RID: 123859 RVA: 0x002AC778 File Offset: 0x002AA978
		public override int IsA(string type)
		{
			return vtkDataArraySelection.vtkDataArraySelection_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x0601E3D4 RID: 123860
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataArraySelection_IsEqual_21(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Returns true if the two array selections are equivalent.
		/// </summary>
		// Token: 0x0601E3D5 RID: 123861 RVA: 0x002AC798 File Offset: 0x002AA998
		public bool IsEqual(vtkDataArraySelection other)
		{
			return vtkDataArraySelection.vtkDataArraySelection_IsEqual_21(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis()) != 0;
		}

		// Token: 0x0601E3D6 RID: 123862
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArraySelection_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E3D7 RID: 123863 RVA: 0x002AC7D4 File Offset: 0x002AA9D4
		public new static int IsTypeOf(string type)
		{
			return vtkDataArraySelection.vtkDataArraySelection_IsTypeOf_22(type);
		}

		// Token: 0x0601E3D8 RID: 123864
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArraySelection_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E3D9 RID: 123865 RVA: 0x002AC7F0 File Offset: 0x002AA9F0
		public new vtkDataArraySelection NewInstance()
		{
			vtkDataArraySelection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArraySelection.vtkDataArraySelection_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E3DA RID: 123866
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArraySelection_RemoveAllArrays_25(HandleRef pThis);

		/// <summary>
		/// Remove all array entries.
		///
		/// This method will call `this-&gt;Modified()` if the arrays were cleared.
		/// </summary>
		// Token: 0x0601E3DB RID: 123867 RVA: 0x002AC84A File Offset: 0x002AAA4A
		public void RemoveAllArrays()
		{
			vtkDataArraySelection.vtkDataArraySelection_RemoveAllArrays_25(base.GetCppThis());
		}

		// Token: 0x0601E3DC RID: 123868
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArraySelection_RemoveArrayByIndex_26(HandleRef pThis, int index);

		/// <summary>
		/// Remove an array setting given its index.
		///
		/// This method **does not** call `this-&gt;Modified()`.
		/// </summary>
		// Token: 0x0601E3DD RID: 123869 RVA: 0x002AC859 File Offset: 0x002AAA59
		public void RemoveArrayByIndex(int index)
		{
			vtkDataArraySelection.vtkDataArraySelection_RemoveArrayByIndex_26(base.GetCppThis(), index);
		}

		// Token: 0x0601E3DE RID: 123870
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArraySelection_RemoveArrayByName_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Remove an array setting given its name.
		///
		/// This method **does not** call `this-&gt;Modified()`.
		/// </summary>
		// Token: 0x0601E3DF RID: 123871 RVA: 0x002AC869 File Offset: 0x002AAA69
		public void RemoveArrayByName(string name)
		{
			vtkDataArraySelection.vtkDataArraySelection_RemoveArrayByName_27(base.GetCppThis(), name);
		}

		// Token: 0x0601E3E0 RID: 123872
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArraySelection_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E3E1 RID: 123873 RVA: 0x002AC87C File Offset: 0x002AAA7C
		public new static vtkDataArraySelection SafeDownCast(vtkObjectBase o)
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArraySelection.vtkDataArraySelection_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x0601E3E2 RID: 123874
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArraySelection_SetArraySetting_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int setting);

		/// <summary>
		/// Set array setting given the name. If the array doesn't exist, it will be
		/// added.
		///
		/// This method will call `this-&gt;Modified()` if the enable state for the
		/// array changed.
		/// </summary>
		// Token: 0x0601E3E3 RID: 123875 RVA: 0x002AC8FB File Offset: 0x002AAAFB
		public void SetArraySetting(string name, int setting)
		{
			vtkDataArraySelection.vtkDataArraySelection_SetArraySetting_29(base.GetCppThis(), name, setting);
		}

		// Token: 0x0601E3E4 RID: 123876
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArraySelection_SetUnknownArraySetting_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set enabled state for any unknown arrays. Default is 0 i.e. not
		/// enabled. When set to 1, `ArrayIsEnabled` will return 1 for any
		/// array not explicitly specified.
		/// </summary>
		// Token: 0x0601E3E5 RID: 123877 RVA: 0x002AC90C File Offset: 0x002AAB0C
		public virtual void SetUnknownArraySetting(int _arg)
		{
			vtkDataArraySelection.vtkDataArraySelection_SetUnknownArraySetting_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0601E3E6 RID: 123878
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArraySelection_Union_31(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Update `this` to include values from `other`. For arrays that don't
		/// exist in `this` but exist in `other`, they will get added to `this` with
		/// the same array setting as in `other`. Array settings for arrays already in
		/// `this` are left unchanged.
		///
		/// This method will call `this-&gt;Modified()` if the array selections changed
		/// unless @a skipModified is set to true (default is false).
		/// </summary>
		// Token: 0x0601E3E7 RID: 123879 RVA: 0x002AC91C File Offset: 0x002AAB1C
		public void Union(vtkDataArraySelection other)
		{
			vtkDataArraySelection.vtkDataArraySelection_Union_31(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0601E3E8 RID: 123880
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArraySelection_Union_32(HandleRef pThis, HandleRef other, byte skipModified);

		/// <summary>
		/// Update `this` to include values from `other`. For arrays that don't
		/// exist in `this` but exist in `other`, they will get added to `this` with
		/// the same array setting as in `other`. Array settings for arrays already in
		/// `this` are left unchanged.
		///
		/// This method will call `this-&gt;Modified()` if the array selections changed
		/// unless @a skipModified is set to true (default is false).
		/// </summary>
		// Token: 0x0601E3E9 RID: 123881 RVA: 0x002AC94C File Offset: 0x002AAB4C
		public void Union(vtkDataArraySelection other, bool skipModified)
		{
			vtkDataArraySelection.vtkDataArraySelection_Union_32(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis(), skipModified ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002078 RID: 8312
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataArraySelection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002079 RID: 8313
		public new static readonly string MRClassNameKey = "class vtkDataArraySelection";
	}
}
