using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAnnotationLayers
	/// </summary>
	/// <remarks>
	///    Stores a ordered collection of annotation sets
	///
	///
	/// vtkAnnotationLayers stores a vector of annotation layers. Each layer
	/// may contain any number of vtkAnnotation objects. The ordering of the
	/// layers introduces a prioritization of annotations. Annotations in
	/// higher layers may obscure annotations in lower layers.
	/// </remarks>
	// Token: 0x020009F8 RID: 2552
	public class vtkAnnotationLayers : vtkDataObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A794 RID: 108436 RVA: 0x0024C587 File Offset: 0x0024A787
		static vtkAnnotationLayers()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAnnotationLayers.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnnotationLayers"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A795 RID: 108437 RVA: 0x0024C5AF File Offset: 0x0024A7AF
		public vtkAnnotationLayers(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A796 RID: 108438
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLayers_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A797 RID: 108439 RVA: 0x0024C5C0 File Offset: 0x0024A7C0
		public new static vtkAnnotationLayers New()
		{
			vtkAnnotationLayers result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A798 RID: 108440 RVA: 0x0024C614 File Offset: 0x0024A814
		public vtkAnnotationLayers() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAnnotationLayers.vtkAnnotationLayers_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A799 RID: 108441 RVA: 0x0024C658 File Offset: 0x0024A858
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A79A RID: 108442
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotationLayers_AddAnnotation_01(HandleRef pThis, HandleRef ann);

		/// <summary>
		/// Add an annotation to a layer.
		/// </summary>
		// Token: 0x0601A79B RID: 108443 RVA: 0x0024C664 File Offset: 0x0024A864
		public void AddAnnotation(vtkAnnotation ann)
		{
			vtkAnnotationLayers.vtkAnnotationLayers_AddAnnotation_01(base.GetCppThis(), (ann == null) ? default(HandleRef) : ann.GetCppThis());
		}

		// Token: 0x0601A79C RID: 108444
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotationLayers_DeepCopy_02(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Copy data from another data object into this one,
		/// performing a deep copy of member annotations.
		/// </summary>
		// Token: 0x0601A79D RID: 108445 RVA: 0x0024C694 File Offset: 0x0024A894
		public override void DeepCopy(vtkDataObject other)
		{
			vtkAnnotationLayers.vtkAnnotationLayers_DeepCopy_02(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0601A79E RID: 108446
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLayers_GetAnnotation_03(HandleRef pThis, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an annotation from a layer.
		/// </summary>
		// Token: 0x0601A79F RID: 108447 RVA: 0x0024C6C4 File Offset: 0x0024A8C4
		public vtkAnnotation GetAnnotation(uint idx)
		{
			vtkAnnotation vtkAnnotation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_GetAnnotation_03(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A7A0 RID: 108448
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLayers_GetCurrentAnnotation_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The current annotation associated with this annotation link.
		/// </summary>
		// Token: 0x0601A7A1 RID: 108449 RVA: 0x0024C734 File Offset: 0x0024A934
		public virtual vtkAnnotation GetCurrentAnnotation()
		{
			vtkAnnotation vtkAnnotation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_GetCurrentAnnotation_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A7A2 RID: 108450
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLayers_GetCurrentSelection_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The current selection associated with this annotation link.
		/// This is simply the selection contained in the current annotation.
		/// </summary>
		// Token: 0x0601A7A3 RID: 108451 RVA: 0x0024C7A4 File Offset: 0x0024A9A4
		public virtual vtkSelection GetCurrentSelection()
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_GetCurrentSelection_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A7A4 RID: 108452
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLayers_GetData_06(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a vtkAnnotationLayers stored inside an information object.
		/// </summary>
		// Token: 0x0601A7A5 RID: 108453 RVA: 0x0024C814 File Offset: 0x0024AA14
		public new static vtkAnnotationLayers GetData(vtkInformation info)
		{
			vtkAnnotationLayers vtkAnnotationLayers = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_GetData_06((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLayers = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLayers.Register(null);
				}
			}
			return vtkAnnotationLayers;
		}

		// Token: 0x0601A7A6 RID: 108454
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLayers_GetData_07(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a vtkAnnotationLayers stored inside an information object.
		/// </summary>
		// Token: 0x0601A7A7 RID: 108455 RVA: 0x0024C894 File Offset: 0x0024AA94
		public new static vtkAnnotationLayers GetData(vtkInformationVector v, int i)
		{
			vtkAnnotationLayers vtkAnnotationLayers = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_GetData_07((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLayers = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLayers.Register(null);
				}
			}
			return vtkAnnotationLayers;
		}

		// Token: 0x0601A7A8 RID: 108456
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotationLayers_GetDataObjectType_08(HandleRef pThis);

		/// <summary>
		/// Returns `VTK_ANNOTATION`.
		/// </summary>
		// Token: 0x0601A7A9 RID: 108457 RVA: 0x0024C914 File Offset: 0x0024AB14
		public override int GetDataObjectType()
		{
			return vtkAnnotationLayers.vtkAnnotationLayers_GetDataObjectType_08(base.GetCppThis());
		}

		// Token: 0x0601A7AA RID: 108458
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAnnotationLayers_GetMTime_09(HandleRef pThis);

		/// <summary>
		/// The modified time for this object.
		/// </summary>
		// Token: 0x0601A7AB RID: 108459 RVA: 0x0024C934 File Offset: 0x0024AB34
		public override ulong GetMTime()
		{
			return vtkAnnotationLayers.vtkAnnotationLayers_GetMTime_09(base.GetCppThis());
		}

		// Token: 0x0601A7AC RID: 108460
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkAnnotationLayers_GetNumberOfAnnotations_10(HandleRef pThis);

		/// <summary>
		/// The number of annotations in a specific layer.
		/// </summary>
		// Token: 0x0601A7AD RID: 108461 RVA: 0x0024C954 File Offset: 0x0024AB54
		public uint GetNumberOfAnnotations()
		{
			return vtkAnnotationLayers.vtkAnnotationLayers_GetNumberOfAnnotations_10(base.GetCppThis());
		}

		// Token: 0x0601A7AE RID: 108462
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnnotationLayers_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7AF RID: 108463 RVA: 0x0024C974 File Offset: 0x0024AB74
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAnnotationLayers.vtkAnnotationLayers_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0601A7B0 RID: 108464
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnnotationLayers_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7B1 RID: 108465 RVA: 0x0024C994 File Offset: 0x0024AB94
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAnnotationLayers.vtkAnnotationLayers_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0601A7B2 RID: 108466
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotationLayers_Initialize_13(HandleRef pThis);

		/// <summary>
		/// Initialize the data structure to an empty state.
		/// </summary>
		// Token: 0x0601A7B3 RID: 108467 RVA: 0x0024C9AE File Offset: 0x0024ABAE
		public override void Initialize()
		{
			vtkAnnotationLayers.vtkAnnotationLayers_Initialize_13(base.GetCppThis());
		}

		// Token: 0x0601A7B4 RID: 108468
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotationLayers_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7B5 RID: 108469 RVA: 0x0024C9C0 File Offset: 0x0024ABC0
		public override int IsA(string type)
		{
			return vtkAnnotationLayers.vtkAnnotationLayers_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0601A7B6 RID: 108470
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotationLayers_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7B7 RID: 108471 RVA: 0x0024C9E0 File Offset: 0x0024ABE0
		public new static int IsTypeOf(string type)
		{
			return vtkAnnotationLayers.vtkAnnotationLayers_IsTypeOf_15(type);
		}

		// Token: 0x0601A7B8 RID: 108472
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLayers_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7B9 RID: 108473 RVA: 0x0024C9FC File Offset: 0x0024ABFC
		public new vtkAnnotationLayers NewInstance()
		{
			vtkAnnotationLayers result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A7BA RID: 108474
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotationLayers_RemoveAnnotation_18(HandleRef pThis, HandleRef ann);

		/// <summary>
		/// Remove an annotation from a layer.
		/// </summary>
		// Token: 0x0601A7BB RID: 108475 RVA: 0x0024CA58 File Offset: 0x0024AC58
		public void RemoveAnnotation(vtkAnnotation ann)
		{
			vtkAnnotationLayers.vtkAnnotationLayers_RemoveAnnotation_18(base.GetCppThis(), (ann == null) ? default(HandleRef) : ann.GetCppThis());
		}

		// Token: 0x0601A7BC RID: 108476
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLayers_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7BD RID: 108477 RVA: 0x0024CA88 File Offset: 0x0024AC88
		public new static vtkAnnotationLayers SafeDownCast(vtkObjectBase o)
		{
			vtkAnnotationLayers vtkAnnotationLayers = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLayers.vtkAnnotationLayers_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLayers = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLayers.Register(null);
				}
			}
			return vtkAnnotationLayers;
		}

		// Token: 0x0601A7BE RID: 108478
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotationLayers_SetCurrentAnnotation_20(HandleRef pThis, HandleRef ann);

		/// <summary>
		/// The current annotation associated with this annotation link.
		/// </summary>
		// Token: 0x0601A7BF RID: 108479 RVA: 0x0024CB08 File Offset: 0x0024AD08
		public virtual void SetCurrentAnnotation(vtkAnnotation ann)
		{
			vtkAnnotationLayers.vtkAnnotationLayers_SetCurrentAnnotation_20(base.GetCppThis(), (ann == null) ? default(HandleRef) : ann.GetCppThis());
		}

		// Token: 0x0601A7C0 RID: 108480
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotationLayers_SetCurrentSelection_21(HandleRef pThis, HandleRef sel);

		/// <summary>
		/// The current selection associated with this annotation link.
		/// This is simply the selection contained in the current annotation.
		/// </summary>
		// Token: 0x0601A7C1 RID: 108481 RVA: 0x0024CB38 File Offset: 0x0024AD38
		public virtual void SetCurrentSelection(vtkSelection sel)
		{
			vtkAnnotationLayers.vtkAnnotationLayers_SetCurrentSelection_21(base.GetCppThis(), (sel == null) ? default(HandleRef) : sel.GetCppThis());
		}

		// Token: 0x0601A7C2 RID: 108482
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotationLayers_ShallowCopy_22(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Copy data from another data object into this one
		/// which references the same member annotations.
		/// </summary>
		// Token: 0x0601A7C3 RID: 108483 RVA: 0x0024CB68 File Offset: 0x0024AD68
		public override void ShallowCopy(vtkDataObject other)
		{
			vtkAnnotationLayers.vtkAnnotationLayers_ShallowCopy_22(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CC8 RID: 7368
		public new const string MRFullTypeName = "Kitware.VTK.vtkAnnotationLayers";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CC9 RID: 7369
		public new static readonly string MRClassNameKey = "class vtkAnnotationLayers";
	}
}
