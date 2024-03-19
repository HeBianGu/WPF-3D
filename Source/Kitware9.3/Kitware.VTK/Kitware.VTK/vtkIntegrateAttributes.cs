using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIntegrateAttributes
	/// </summary>
	/// <remarks>
	///    Integrates lines, surfaces and volume.
	///
	/// Integrates all point and cell data attributes while computing
	/// length, area or volume.  Works for 1D, 2D or 3D.  Only one dimensionality
	/// at a time.  For volume, this filter ignores all but 3D cells.  It
	/// will not compute the volume contained in a closed surface.
	/// The output of this filter is a single point and vertex.  The attributes
	/// for this point and cell will contain the integration results
	/// for the corresponding input attributes.
	/// </remarks>
	// Token: 0x02000508 RID: 1288
	public class vtkIntegrateAttributes : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E76A RID: 59242 RVA: 0x001425DB File Offset: 0x001407DB
		static vtkIntegrateAttributes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIntegrateAttributes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIntegrateAttributes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E76B RID: 59243 RVA: 0x00142603 File Offset: 0x00140803
		public vtkIntegrateAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E76C RID: 59244
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIntegrateAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E76D RID: 59245 RVA: 0x00142614 File Offset: 0x00140814
		public new static vtkIntegrateAttributes New()
		{
			vtkIntegrateAttributes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIntegrateAttributes.vtkIntegrateAttributes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIntegrateAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E76E RID: 59246 RVA: 0x00142668 File Offset: 0x00140868
		public vtkIntegrateAttributes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIntegrateAttributes.vtkIntegrateAttributes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E76F RID: 59247 RVA: 0x001426AC File Offset: 0x001408AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E770 RID: 59248
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIntegrateAttributes_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the parallel controller to use. By default, set to.
		/// `vtkMultiProcessController::GlobalController`.
		/// </summary>
		// Token: 0x0600E771 RID: 59249 RVA: 0x001426B8 File Offset: 0x001408B8
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIntegrateAttributes.vtkIntegrateAttributes_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x0600E772 RID: 59250
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIntegrateAttributes_GetDivideAllCellDataByVolume_02(HandleRef pThis);

		/// <summary>
		/// If set to true then the filter will divide all output cell data arrays (the integrated values)
		/// by the computed volume/area of the dataset.  Defaults to false.
		/// </summary>
		// Token: 0x0600E773 RID: 59251 RVA: 0x00142728 File Offset: 0x00140928
		public virtual bool GetDivideAllCellDataByVolume()
		{
			return vtkIntegrateAttributes.vtkIntegrateAttributes_GetDivideAllCellDataByVolume_02(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E774 RID: 59252
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIntegrateAttributes_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E775 RID: 59253 RVA: 0x00142750 File Offset: 0x00140950
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIntegrateAttributes.vtkIntegrateAttributes_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E776 RID: 59254
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIntegrateAttributes_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E777 RID: 59255 RVA: 0x00142770 File Offset: 0x00140970
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIntegrateAttributes.vtkIntegrateAttributes_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600E778 RID: 59256
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntegrateAttributes_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E779 RID: 59257 RVA: 0x0014278C File Offset: 0x0014098C
		public override int IsA(string type)
		{
			return vtkIntegrateAttributes.vtkIntegrateAttributes_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600E77A RID: 59258
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntegrateAttributes_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E77B RID: 59259 RVA: 0x001427AC File Offset: 0x001409AC
		public new static int IsTypeOf(string type)
		{
			return vtkIntegrateAttributes.vtkIntegrateAttributes_IsTypeOf_06(type);
		}

		// Token: 0x0600E77C RID: 59260
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIntegrateAttributes_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E77D RID: 59261 RVA: 0x001427C8 File Offset: 0x001409C8
		public new vtkIntegrateAttributes NewInstance()
		{
			vtkIntegrateAttributes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIntegrateAttributes.vtkIntegrateAttributes_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIntegrateAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E77E RID: 59262
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIntegrateAttributes_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E77F RID: 59263 RVA: 0x00142824 File Offset: 0x00140A24
		public new static vtkIntegrateAttributes SafeDownCast(vtkObjectBase o)
		{
			vtkIntegrateAttributes vtkIntegrateAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIntegrateAttributes.vtkIntegrateAttributes_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntegrateAttributes = (vtkIntegrateAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntegrateAttributes.Register(null);
				}
			}
			return vtkIntegrateAttributes;
		}

		// Token: 0x0600E780 RID: 59264
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntegrateAttributes_SetController_10(HandleRef pThis, HandleRef controller);

		/// <summary>
		/// Get/Set the parallel controller to use. By default, set to.
		/// `vtkMultiProcessController::GlobalController`.
		/// </summary>
		// Token: 0x0600E781 RID: 59265 RVA: 0x001428A4 File Offset: 0x00140AA4
		public void SetController(vtkMultiProcessController controller)
		{
			vtkIntegrateAttributes.vtkIntegrateAttributes_SetController_10(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		// Token: 0x0600E782 RID: 59266
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIntegrateAttributes_SetDivideAllCellDataByVolume_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// If set to true then the filter will divide all output cell data arrays (the integrated values)
		/// by the computed volume/area of the dataset.  Defaults to false.
		/// </summary>
		// Token: 0x0600E783 RID: 59267 RVA: 0x001428D3 File Offset: 0x00140AD3
		public virtual void SetDivideAllCellDataByVolume(bool _arg)
		{
			vtkIntegrateAttributes.vtkIntegrateAttributes_SetDivideAllCellDataByVolume_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010F7 RID: 4343
		public new const string MRFullTypeName = "Kitware.VTK.vtkIntegrateAttributes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010F8 RID: 4344
		public new static readonly string MRClassNameKey = "class vtkIntegrateAttributes";

		/// <summary>
		/// If set to true then the filter will divide all output cell data arrays (the integrated values)
		/// by the computed volume/area of the dataset.  Defaults to false.
		/// </summary>
		// Token: 0x02000509 RID: 1289
		public enum CommunicationIds
		{
			/// <summary>enum member</summary>
			// Token: 0x040010FA RID: 4346
			IntegrateAttrData = 2001,
			/// <summary>enum member</summary>
			// Token: 0x040010FB RID: 4347
			IntegrateAttrInfo = 2000
		}
	}
}
