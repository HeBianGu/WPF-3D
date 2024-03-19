using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationKey
	/// </summary>
	/// <remarks>
	///    Superclass for vtkInformation keys.
	///
	/// vtkInformationKey is the superclass for all keys used to access the
	/// map represented by vtkInformation.  The vtkInformation::Set and
	/// vtkInformation::Get methods of vtkInformation are accessed by
	/// information keys.  A key is a pointer to an instance of a subclass
	/// of vtkInformationKey.  The type of the subclass determines the
	/// overload of Set/Get that is selected.  This ensures that the type
	/// of value stored in a vtkInformation instance corresponding to a
	/// given key matches the type expected for that key.
	/// </remarks>
	// Token: 0x020009D7 RID: 2519
	public abstract class vtkInformationKey : vtkObjectBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A3E6 RID: 107494 RVA: 0x00246537 File Offset: 0x00244737
		static vtkInformationKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A3E7 RID: 107495 RVA: 0x0024655F File Offset: 0x0024475F
		public vtkInformationKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A3E8 RID: 107496
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationKey_Register_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Prevent normal vtkObject reference counting behavior.
		/// </summary>
		// Token: 0x0601A3E9 RID: 107497 RVA: 0x00246570 File Offset: 0x00244770
		public override void Register(vtkObjectBase arg0)
		{
			vtkInformationKey.vtkInformationKey_Register_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601A3EA RID: 107498
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationKey_UnRegister_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Prevent normal vtkObject reference counting behavior.
		/// </summary>
		// Token: 0x0601A3EB RID: 107499 RVA: 0x002465A0 File Offset: 0x002447A0
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkInformationKey.vtkInformationKey_UnRegister_19(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0601A3EC RID: 107500
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationKey_CopyDefaultInformation_01(HandleRef pThis, HandleRef arg0, HandleRef arg1, HandleRef arg2);

		/// <summary>
		/// This function is only relevant when the pertaining key
		/// is used in a VTK pipeline. By overwriting this method, a
		/// key can decide if/how to copy itself downstream or upstream
		/// during a particular pipeline pass. For example, meta-data keys
		/// can copy themselves during REQUEST_INFORMATION whereas request
		/// keys can copy themselves during REQUEST_UPDATE_EXTENT.
		/// </summary>
		// Token: 0x0601A3ED RID: 107501 RVA: 0x002465FC File Offset: 0x002447FC
		public virtual void CopyDefaultInformation(vtkInformation arg0, vtkInformation arg1, vtkInformation arg2)
		{
			vtkInformationKey.vtkInformationKey_CopyDefaultInformation_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), (arg2 == null) ? default(HandleRef) : arg2.GetCppThis());
		}

		// Token: 0x0601A3EE RID: 107502
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationKey_DeepCopy_02(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Duplicate (new instance created) the entry associated with this key from
		/// one information object to another (new instances of any contained
		/// vtkInformation and vtkInformationVector objects are created).
		/// Default implementation simply calls ShallowCopy().
		/// </summary>
		// Token: 0x0601A3EF RID: 107503 RVA: 0x00246658 File Offset: 0x00244858
		public virtual void DeepCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationKey.vtkInformationKey_DeepCopy_02(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		// Token: 0x0601A3F0 RID: 107504
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationKey_GetLocation_03(HandleRef pThis);

		/// <summary>
		/// Get the location of the key.  This is the name of the class in
		/// which the key is defined.
		/// </summary>
		// Token: 0x0601A3F1 RID: 107505 RVA: 0x0024669C File Offset: 0x0024489C
		public string GetLocation()
		{
			string s = Marshal.PtrToStringAnsi(vtkInformationKey.vtkInformationKey_GetLocation_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601A3F2 RID: 107506
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationKey_GetName_04(HandleRef pThis);

		/// <summary>
		/// Get the name of the key.  This is not the type of the key, but
		/// the name of the key instance.
		/// </summary>
		// Token: 0x0601A3F3 RID: 107507 RVA: 0x002466D8 File Offset: 0x002448D8
		public string GetName()
		{
			string s = Marshal.PtrToStringAnsi(vtkInformationKey.vtkInformationKey_GetName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601A3F4 RID: 107508
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationKey_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3F5 RID: 107509 RVA: 0x00246714 File Offset: 0x00244914
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationKey.vtkInformationKey_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601A3F6 RID: 107510
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationKey_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3F7 RID: 107511 RVA: 0x00246734 File Offset: 0x00244934
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationKey.vtkInformationKey_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601A3F8 RID: 107512
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationKey_Has_07(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Check whether this key appears in the given information object.
		/// </summary>
		// Token: 0x0601A3F9 RID: 107513 RVA: 0x00246750 File Offset: 0x00244950
		public virtual int Has(vtkInformation info)
		{
			return vtkInformationKey.vtkInformationKey_Has_07(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601A3FA RID: 107514
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationKey_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3FB RID: 107515 RVA: 0x00246784 File Offset: 0x00244984
		public override int IsA(string type)
		{
			return vtkInformationKey.vtkInformationKey_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601A3FC RID: 107516
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationKey_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3FD RID: 107517 RVA: 0x002467A4 File Offset: 0x002449A4
		public new static int IsTypeOf(string type)
		{
			return vtkInformationKey.vtkInformationKey_IsTypeOf_09(type);
		}

		// Token: 0x0601A3FE RID: 107518
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInformationKey_NeedToExecute_10(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// This function is only relevant when the pertaining key
		/// is used in a VTK pipeline. Specific keys that handle
		/// pipeline data requests (for example, UPDATE_PIECE_NUMBER)
		/// can overwrite this method to notify the pipeline that a
		/// a filter should be (re-)executed because what is in
		/// the current output is different that what is being requested
		/// by the key. For example, DATA_PIECE_NUMBER != UPDATE_PIECE_NUMBER.
		/// </summary>
		// Token: 0x0601A3FF RID: 107519 RVA: 0x002467C0 File Offset: 0x002449C0
		public virtual bool NeedToExecute(vtkInformation arg0, vtkInformation arg1)
		{
			return vtkInformationKey.vtkInformationKey_NeedToExecute_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis()) != 0;
		}

		// Token: 0x0601A400 RID: 107520
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationKey_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A401 RID: 107521 RVA: 0x00246810 File Offset: 0x00244A10
		public vtkInformationKey NewInstance()
		{
			vtkInformationKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationKey.vtkInformationKey_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A402 RID: 107522
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationKey_Print_12(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Print the key's value in an information object to a stream.
		/// </summary>
		// Token: 0x0601A403 RID: 107523 RVA: 0x0024686C File Offset: 0x00244A6C
		public void Print(vtkInformation info)
		{
			vtkInformationKey.vtkInformationKey_Print_12(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601A404 RID: 107524
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationKey_Remove_14(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Remove this key from the given information object.
		/// </summary>
		// Token: 0x0601A405 RID: 107525 RVA: 0x0024689C File Offset: 0x00244A9C
		public virtual void Remove(vtkInformation info)
		{
			vtkInformationKey.vtkInformationKey_Remove_14(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601A406 RID: 107526
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationKey_Report_15(HandleRef pThis, HandleRef info, HandleRef collector);

		/// <summary>
		/// Report a reference this key has in the given information object.
		/// </summary>
		// Token: 0x0601A407 RID: 107527 RVA: 0x002468CC File Offset: 0x00244ACC
		public virtual void Report(vtkInformation info, vtkGarbageCollector collector)
		{
			vtkInformationKey.vtkInformationKey_Report_15(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (collector == null) ? default(HandleRef) : collector.GetCppThis());
		}

		// Token: 0x0601A408 RID: 107528
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationKey_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A409 RID: 107529 RVA: 0x00246910 File Offset: 0x00244B10
		public static vtkInformationKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationKey.vtkInformationKey_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601A40A RID: 107530
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationKey_ShallowCopy_17(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601A40B RID: 107531 RVA: 0x00246990 File Offset: 0x00244B90
		public virtual void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationKey.vtkInformationKey_ShallowCopy_17(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		// Token: 0x0601A40C RID: 107532
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationKey_StoreMetaData_18(HandleRef pThis, HandleRef arg0, HandleRef arg1, HandleRef arg2);

		/// <summary>
		/// This function is only relevant when the pertaining key
		/// is used in a VTK pipeline. Specific keys that handle
		/// pipeline data requests (for example, UPDATE_PIECE_NUMBER)
		/// can overwrite this method to store in the data information
		/// meta-data about the request that led to the current filter
		/// execution. This meta-data can later be used to compare what
		/// is being requested to decide whether the filter needs to
		/// re-execute. For example, a filter may store the current
		/// UPDATE_PIECE_NUMBER in the data object's information as
		/// the DATA_PIECE_NUMBER. DATA_PIECE_NUMBER can later be compared
		/// to a new UPDATA_PIECE_NUMBER to decide whether a filter should
		/// re-execute.
		/// </summary>
		// Token: 0x0601A40D RID: 107533 RVA: 0x002469D4 File Offset: 0x00244BD4
		public virtual void StoreMetaData(vtkInformation arg0, vtkInformation arg1, vtkInformation arg2)
		{
			vtkInformationKey.vtkInformationKey_StoreMetaData_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), (arg2 == null) ? default(HandleRef) : arg2.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C7E RID: 7294
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C7F RID: 7295
		public new static readonly string MRClassNameKey = "class vtkInformationKey";
	}
}
