using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAnnotation
	/// </summary>
	/// <remarks>
	///    Stores a collection of annotation artifacts.
	///
	///
	/// vtkAnnotation is a collection of annotation properties along with
	/// an associated selection indicating the portion of data the annotation
	/// refers to.
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories
	/// contributed code to this class.
	/// </seealso>
	// Token: 0x020009F7 RID: 2551
	public class vtkAnnotation : vtkDataObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A762 RID: 108386 RVA: 0x0024BE18 File Offset: 0x0024A018
		static vtkAnnotation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAnnotation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnnotation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A763 RID: 108387 RVA: 0x0024BE40 File Offset: 0x0024A040
		public vtkAnnotation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A764 RID: 108388
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A765 RID: 108389 RVA: 0x0024BE50 File Offset: 0x0024A050
		public new static vtkAnnotation New()
		{
			vtkAnnotation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotation.vtkAnnotation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A766 RID: 108390 RVA: 0x0024BEA4 File Offset: 0x0024A0A4
		public vtkAnnotation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAnnotation.vtkAnnotation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A767 RID: 108391 RVA: 0x0024BEE8 File Offset: 0x0024A0E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A768 RID: 108392
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotation_COLOR_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The color for this annotation.
		/// This is stored as an RGB triple with values between 0 and 1.
		/// </summary>
		// Token: 0x0601A769 RID: 108393 RVA: 0x0024BEF4 File Offset: 0x0024A0F4
		public static vtkInformationDoubleVectorKey COLOR()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotation.vtkAnnotation_COLOR_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x0601A76A RID: 108394
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotation_DATA_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Associate a vtkDataObject with this annotation
		/// </summary>
		// Token: 0x0601A76B RID: 108395 RVA: 0x0024BF60 File Offset: 0x0024A160
		public static vtkInformationDataObjectKey DATA()
		{
			vtkInformationDataObjectKey vtkInformationDataObjectKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotation.vtkAnnotation_DATA_02(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDataObjectKey = (vtkInformationDataObjectKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDataObjectKey.Register(null);
				}
			}
			return vtkInformationDataObjectKey;
		}

		// Token: 0x0601A76C RID: 108396
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotation_DeepCopy_03(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Make this annotation have the same properties and have
		/// a copy of the selection of another annotation.
		/// </summary>
		// Token: 0x0601A76D RID: 108397 RVA: 0x0024BFCC File Offset: 0x0024A1CC
		public override void DeepCopy(vtkDataObject other)
		{
			vtkAnnotation.vtkAnnotation_DeepCopy_03(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0601A76E RID: 108398
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotation_ENABLE_04(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Whether or not this annotation is enabled.
		/// A value of 1 means enabled, 0 disabled.
		/// </summary>
		// Token: 0x0601A76F RID: 108399 RVA: 0x0024BFFC File Offset: 0x0024A1FC
		public static vtkInformationIntegerKey ENABLE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotation.vtkAnnotation_ENABLE_04(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601A770 RID: 108400
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotation_GetData_05(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a vtkAnnotation stored inside an information object.
		/// </summary>
		// Token: 0x0601A771 RID: 108401 RVA: 0x0024C068 File Offset: 0x0024A268
		public new static vtkAnnotation GetData(vtkInformation info)
		{
			vtkAnnotation vtkAnnotation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotation.vtkAnnotation_GetData_05((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotation = (vtkAnnotation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotation.Register(null);
				}
			}
			return vtkAnnotation;
		}

		// Token: 0x0601A772 RID: 108402
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotation_GetData_06(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a vtkAnnotation stored inside an information object.
		/// </summary>
		// Token: 0x0601A773 RID: 108403 RVA: 0x0024C0E8 File Offset: 0x0024A2E8
		public new static vtkAnnotation GetData(vtkInformationVector v, int i)
		{
			vtkAnnotation vtkAnnotation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotation.vtkAnnotation_GetData_06((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotation = (vtkAnnotation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotation.Register(null);
				}
			}
			return vtkAnnotation;
		}

		// Token: 0x0601A774 RID: 108404
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotation_GetDataObjectType_07(HandleRef pThis);

		/// <summary>
		/// Returns `VTK_ANNOTATION`.
		/// </summary>
		// Token: 0x0601A775 RID: 108405 RVA: 0x0024C168 File Offset: 0x0024A368
		public override int GetDataObjectType()
		{
			return vtkAnnotation.vtkAnnotation_GetDataObjectType_07(base.GetCppThis());
		}

		// Token: 0x0601A776 RID: 108406
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAnnotation_GetMTime_08(HandleRef pThis);

		/// <summary>
		/// Get the modified time of this object.
		/// </summary>
		// Token: 0x0601A777 RID: 108407 RVA: 0x0024C188 File Offset: 0x0024A388
		public override ulong GetMTime()
		{
			return vtkAnnotation.vtkAnnotation_GetMTime_08(base.GetCppThis());
		}

		// Token: 0x0601A778 RID: 108408
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnnotation_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A779 RID: 108409 RVA: 0x0024C1A8 File Offset: 0x0024A3A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAnnotation.vtkAnnotation_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0601A77A RID: 108410
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnnotation_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A77B RID: 108411 RVA: 0x0024C1C8 File Offset: 0x0024A3C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAnnotation.vtkAnnotation_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0601A77C RID: 108412
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotation_GetSelection_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The selection to which this set of annotations will apply.
		/// </summary>
		// Token: 0x0601A77D RID: 108413 RVA: 0x0024C1E4 File Offset: 0x0024A3E4
		public virtual vtkSelection GetSelection()
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotation.vtkAnnotation_GetSelection_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x0601A77E RID: 108414
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotation_HIDE_12(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Whether or not this annotation is visible.
		/// </summary>
		// Token: 0x0601A77F RID: 108415 RVA: 0x0024C254 File Offset: 0x0024A454
		public static vtkInformationIntegerKey HIDE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotation.vtkAnnotation_HIDE_12(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601A780 RID: 108416
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotation_ICON_INDEX_13(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// An icon index for this annotation.
		/// </summary>
		// Token: 0x0601A781 RID: 108417 RVA: 0x0024C2C0 File Offset: 0x0024A4C0
		public static vtkInformationIntegerKey ICON_INDEX()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotation.vtkAnnotation_ICON_INDEX_13(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601A782 RID: 108418
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotation_Initialize_14(HandleRef pThis);

		/// <summary>
		/// Initialize the annotation to an empty state.
		/// </summary>
		// Token: 0x0601A783 RID: 108419 RVA: 0x0024C329 File Offset: 0x0024A529
		public override void Initialize()
		{
			vtkAnnotation.vtkAnnotation_Initialize_14(base.GetCppThis());
		}

		// Token: 0x0601A784 RID: 108420
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotation_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A785 RID: 108421 RVA: 0x0024C338 File Offset: 0x0024A538
		public override int IsA(string type)
		{
			return vtkAnnotation.vtkAnnotation_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x0601A786 RID: 108422
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotation_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A787 RID: 108423 RVA: 0x0024C358 File Offset: 0x0024A558
		public new static int IsTypeOf(string type)
		{
			return vtkAnnotation.vtkAnnotation_IsTypeOf_16(type);
		}

		// Token: 0x0601A788 RID: 108424
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotation_LABEL_17(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The label for this annotation.
		/// </summary>
		// Token: 0x0601A789 RID: 108425 RVA: 0x0024C374 File Offset: 0x0024A574
		public static vtkInformationStringKey LABEL()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotation.vtkAnnotation_LABEL_17(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		// Token: 0x0601A78A RID: 108426
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotation_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A78B RID: 108427 RVA: 0x0024C3E0 File Offset: 0x0024A5E0
		public new vtkAnnotation NewInstance()
		{
			vtkAnnotation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotation.vtkAnnotation_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A78C RID: 108428
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotation_OPACITY_20(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The color for this annotation.
		/// This is stored as a value between 0 and 1.
		/// </summary>
		// Token: 0x0601A78D RID: 108429 RVA: 0x0024C43C File Offset: 0x0024A63C
		public static vtkInformationDoubleKey OPACITY()
		{
			vtkInformationDoubleKey vtkInformationDoubleKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotation.vtkAnnotation_OPACITY_20(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleKey = (vtkInformationDoubleKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleKey.Register(null);
				}
			}
			return vtkInformationDoubleKey;
		}

		// Token: 0x0601A78E RID: 108430
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotation_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A78F RID: 108431 RVA: 0x0024C4A8 File Offset: 0x0024A6A8
		public new static vtkAnnotation SafeDownCast(vtkObjectBase o)
		{
			vtkAnnotation vtkAnnotation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotation.vtkAnnotation_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotation = (vtkAnnotation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotation.Register(null);
				}
			}
			return vtkAnnotation;
		}

		// Token: 0x0601A790 RID: 108432
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotation_SetSelection_22(HandleRef pThis, HandleRef selection);

		/// <summary>
		/// The selection to which this set of annotations will apply.
		/// </summary>
		// Token: 0x0601A791 RID: 108433 RVA: 0x0024C528 File Offset: 0x0024A728
		public virtual void SetSelection(vtkSelection selection)
		{
			vtkAnnotation.vtkAnnotation_SetSelection_22(base.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis());
		}

		// Token: 0x0601A792 RID: 108434
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotation_ShallowCopy_23(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Make this annotation have the same properties and have
		/// the same selection of another annotation.
		/// </summary>
		// Token: 0x0601A793 RID: 108435 RVA: 0x0024C558 File Offset: 0x0024A758
		public override void ShallowCopy(vtkDataObject other)
		{
			vtkAnnotation.vtkAnnotation_ShallowCopy_23(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CC6 RID: 7366
		public new const string MRFullTypeName = "Kitware.VTK.vtkAnnotation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CC7 RID: 7367
		public new static readonly string MRClassNameKey = "class vtkAnnotation";
	}
}
