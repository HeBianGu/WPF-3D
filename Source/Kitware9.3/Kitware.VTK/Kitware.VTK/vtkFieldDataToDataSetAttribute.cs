using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFieldDataToDataSetAttribute
	/// </summary>
	/// <remarks>
	///    map field data to other attribute data
	///
	/// vtkFieldDataToDataSetAttribute is a filter that copies field data arrays into
	/// another attribute data arrays.
	///
	/// This is done at very low memory cost by using the Implicit Array infrastructure.
	///
	/// NOTE: It copies only the first component of the first tuple into a vtkConstantArray.
	/// vtkStringArray are not supported.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFieldData vtkCellData
	/// </seealso>
	// Token: 0x02000968 RID: 2408
	public class vtkFieldDataToDataSetAttribute : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601912A RID: 102698 RVA: 0x0022F603 File Offset: 0x0022D803
		static vtkFieldDataToDataSetAttribute()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFieldDataToDataSetAttribute.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFieldDataToDataSetAttribute"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601912B RID: 102699 RVA: 0x0022F62B File Offset: 0x0022D82B
		public vtkFieldDataToDataSetAttribute(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601912C RID: 102700
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldDataToDataSetAttribute_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601912D RID: 102701 RVA: 0x0022F63C File Offset: 0x0022D83C
		public new static vtkFieldDataToDataSetAttribute New()
		{
			vtkFieldDataToDataSetAttribute result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFieldDataToDataSetAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601912E RID: 102702 RVA: 0x0022F690 File Offset: 0x0022D890
		public vtkFieldDataToDataSetAttribute() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601912F RID: 102703 RVA: 0x0022F6D4 File Offset: 0x0022D8D4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019130 RID: 102704
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToDataSetAttribute_AddFieldDataArray_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Adds an array to be processed.
		/// This only has an effect if ProcessAllArrays is off.
		/// If the name is already present, nothing happens.
		/// </summary>
		// Token: 0x06019131 RID: 102705 RVA: 0x0022F6DF File Offset: 0x0022D8DF
		public virtual void AddFieldDataArray(string name)
		{
			vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_AddFieldDataArray_01(base.GetCppThis(), name);
		}

		// Token: 0x06019132 RID: 102706
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToDataSetAttribute_ClearFieldDataArrays_02(HandleRef pThis);

		/// <summary>
		/// Removes all arrays to be processed from the list.
		/// This only has an effect if ProcessAllArrays is off.
		/// </summary>
		// Token: 0x06019133 RID: 102707 RVA: 0x0022F6EF File Offset: 0x0022D8EF
		public virtual void ClearFieldDataArrays()
		{
			vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_ClearFieldDataArrays_02(base.GetCppThis());
		}

		// Token: 0x06019134 RID: 102708
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFieldDataToDataSetAttribute_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019135 RID: 102709 RVA: 0x0022F700 File Offset: 0x0022D900
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06019136 RID: 102710
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFieldDataToDataSetAttribute_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019137 RID: 102711 RVA: 0x0022F720 File Offset: 0x0022D920
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06019138 RID: 102712
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToDataSetAttribute_GetOutputFieldType_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the output attribute type.
		/// </summary>
		// Token: 0x06019139 RID: 102713 RVA: 0x0022F73C File Offset: 0x0022D93C
		public virtual int GetOutputFieldType()
		{
			return vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_GetOutputFieldType_05(base.GetCppThis());
		}

		// Token: 0x0601913A RID: 102714
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFieldDataToDataSetAttribute_GetProcessAllArrays_06(HandleRef pThis);

		/// <summary>
		/// Activate whether to process all input arrays or only the selected ones.
		/// If false, only arrays selected by the user will be considered by this filter.
		/// The default is true.
		/// </summary>
		// Token: 0x0601913B RID: 102715 RVA: 0x0022F75C File Offset: 0x0022D95C
		public virtual bool GetProcessAllArrays()
		{
			return vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_GetProcessAllArrays_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0601913C RID: 102716
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToDataSetAttribute_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601913D RID: 102717 RVA: 0x0022F784 File Offset: 0x0022D984
		public override int IsA(string type)
		{
			return vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601913E RID: 102718
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToDataSetAttribute_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601913F RID: 102719 RVA: 0x0022F7A4 File Offset: 0x0022D9A4
		public new static int IsTypeOf(string type)
		{
			return vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_IsTypeOf_08(type);
		}

		// Token: 0x06019140 RID: 102720
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldDataToDataSetAttribute_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019141 RID: 102721 RVA: 0x0022F7C0 File Offset: 0x0022D9C0
		public new vtkFieldDataToDataSetAttribute NewInstance()
		{
			vtkFieldDataToDataSetAttribute result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFieldDataToDataSetAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019142 RID: 102722
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToDataSetAttribute_ProcessAllArraysOff_11(HandleRef pThis);

		/// <summary>
		/// Activate whether to process all input arrays or only the selected ones.
		/// If false, only arrays selected by the user will be considered by this filter.
		/// The default is true.
		/// </summary>
		// Token: 0x06019143 RID: 102723 RVA: 0x0022F81A File Offset: 0x0022DA1A
		public virtual void ProcessAllArraysOff()
		{
			vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_ProcessAllArraysOff_11(base.GetCppThis());
		}

		// Token: 0x06019144 RID: 102724
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToDataSetAttribute_ProcessAllArraysOn_12(HandleRef pThis);

		/// <summary>
		/// Activate whether to process all input arrays or only the selected ones.
		/// If false, only arrays selected by the user will be considered by this filter.
		/// The default is true.
		/// </summary>
		// Token: 0x06019145 RID: 102725 RVA: 0x0022F829 File Offset: 0x0022DA29
		public virtual void ProcessAllArraysOn()
		{
			vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_ProcessAllArraysOn_12(base.GetCppThis());
		}

		// Token: 0x06019146 RID: 102726
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToDataSetAttribute_RemoveFieldDataArray_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Removes an array to be processed.
		/// This only has an effect if ProcessAllArrays is off.
		/// If the name is not present, nothing happens.
		/// </summary>
		// Token: 0x06019147 RID: 102727 RVA: 0x0022F838 File Offset: 0x0022DA38
		public virtual void RemoveFieldDataArray(string name)
		{
			vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_RemoveFieldDataArray_13(base.GetCppThis(), name);
		}

		// Token: 0x06019148 RID: 102728
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldDataToDataSetAttribute_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019149 RID: 102729 RVA: 0x0022F848 File Offset: 0x0022DA48
		public new static vtkFieldDataToDataSetAttribute SafeDownCast(vtkObjectBase o)
		{
			vtkFieldDataToDataSetAttribute vtkFieldDataToDataSetAttribute = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldDataToDataSetAttribute = (vtkFieldDataToDataSetAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldDataToDataSetAttribute.Register(null);
				}
			}
			return vtkFieldDataToDataSetAttribute;
		}

		// Token: 0x0601914A RID: 102730
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToDataSetAttribute_SetOutputFieldType_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the output attribute type.
		/// </summary>
		// Token: 0x0601914B RID: 102731 RVA: 0x0022F8C7 File Offset: 0x0022DAC7
		public virtual void SetOutputFieldType(int _arg)
		{
			vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_SetOutputFieldType_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601914C RID: 102732
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToDataSetAttribute_SetProcessAllArrays_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// Activate whether to process all input arrays or only the selected ones.
		/// If false, only arrays selected by the user will be considered by this filter.
		/// The default is true.
		/// </summary>
		// Token: 0x0601914D RID: 102733 RVA: 0x0022F8D7 File Offset: 0x0022DAD7
		public virtual void SetProcessAllArrays(bool _arg)
		{
			vtkFieldDataToDataSetAttribute.vtkFieldDataToDataSetAttribute_SetProcessAllArrays_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B89 RID: 7049
		public new const string MRFullTypeName = "Kitware.VTK.vtkFieldDataToDataSetAttribute";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B8A RID: 7050
		public new static readonly string MRClassNameKey = "class vtkFieldDataToDataSetAttribute";
	}
}
