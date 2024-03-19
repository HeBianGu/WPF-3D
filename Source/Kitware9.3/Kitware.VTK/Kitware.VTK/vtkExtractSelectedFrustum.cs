using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractSelectedFrustum
	/// </summary>
	/// <remarks>
	///    Returns the portion of the input dataset that
	/// lies within a selection frustum.
	///
	///
	/// This class intersects the input DataSet with a frustum and determines which
	/// cells and points lie within the frustum. The frustum is defined with a
	/// vtkPlanes containing six cutting planes. The output is a DataSet that is
	/// either a shallow copy of the input dataset with two new "vtkInsidedness"
	/// attribute arrays, or a completely new UnstructuredGrid that contains only
	/// the cells and points of the input that are inside the frustum. The
	/// PreserveTopology flag controls which occurs. When PreserveTopology is off
	/// this filter adds a scalar array called vtkOriginalCellIds that says what
	/// input cell produced each output cell. This is an example of a Pedigree ID
	/// which helps to trace back results.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExtractGeometry, vtkAreaPicker, vtkExtractSelection, vtkSelection
	/// </seealso>
	// Token: 0x0200089E RID: 2206
	public class vtkExtractSelectedFrustum : vtkExtractSelectionBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016E69 RID: 93801 RVA: 0x00202F23 File Offset: 0x00201123
		static vtkExtractSelectedFrustum()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedFrustum.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedFrustum"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016E6A RID: 93802 RVA: 0x00202F4B File Offset: 0x0020114B
		public vtkExtractSelectedFrustum(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016E6B RID: 93803
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedFrustum_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E6C RID: 93804 RVA: 0x00202F5C File Offset: 0x0020115C
		public new static vtkExtractSelectedFrustum New()
		{
			vtkExtractSelectedFrustum result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedFrustum)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E6D RID: 93805 RVA: 0x00202FB0 File Offset: 0x002011B0
		public vtkExtractSelectedFrustum() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016E6E RID: 93806 RVA: 0x00202FF4 File Offset: 0x002011F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016E6F RID: 93807
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedFrustum_CreateFrustum_01(HandleRef pThis, IntPtr vertices);

		/// <summary>
		/// Given eight vertices, creates a frustum.
		/// each pt is x,y,z,1
		/// in the following order
		/// near lower left, far lower left
		/// near upper left, far upper left
		/// near lower right, far lower right
		/// near upper right, far upper right
		/// </summary>
		// Token: 0x06016E70 RID: 93808 RVA: 0x00202FFF File Offset: 0x002011FF
		public void CreateFrustum(IntPtr vertices)
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_CreateFrustum_01(base.GetCppThis(), vertices);
		}

		// Token: 0x06016E71 RID: 93809
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedFrustum_GetClipPoints_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return eight points that define the selection frustum. Valid if
		/// create Frustum was used, invalid if SetFrustum was.
		/// </summary>
		// Token: 0x06016E72 RID: 93810 RVA: 0x00203010 File Offset: 0x00201210
		public virtual vtkPoints GetClipPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetClipPoints_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x06016E73 RID: 93811
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedFrustum_GetContainingCells_03(HandleRef pThis);

		/// <summary>
		/// Sets/gets the intersection test type. Only meaningful when fieldType is
		/// vtkSelection::POINT
		/// </summary>
		// Token: 0x06016E74 RID: 93812 RVA: 0x00203080 File Offset: 0x00201280
		public virtual int GetContainingCells()
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetContainingCells_03(base.GetCppThis());
		}

		// Token: 0x06016E75 RID: 93813
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedFrustum_GetFieldType_04(HandleRef pThis);

		/// <summary>
		/// Sets/gets the intersection test type.
		/// </summary>
		// Token: 0x06016E76 RID: 93814 RVA: 0x002030A0 File Offset: 0x002012A0
		public virtual int GetFieldType()
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetFieldType_04(base.GetCppThis());
		}

		// Token: 0x06016E77 RID: 93815
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedFrustum_GetFrustum_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the selection frustum. The planes object must contain six planes.
		/// </summary>
		// Token: 0x06016E78 RID: 93816 RVA: 0x002030C0 File Offset: 0x002012C0
		public virtual vtkPlanes GetFrustum()
		{
			vtkPlanes vtkPlanes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetFrustum_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlanes = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlanes.Register(null);
				}
			}
			return vtkPlanes;
		}

		// Token: 0x06016E79 RID: 93817
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedFrustum_GetInsideOut_06(HandleRef pThis);

		/// <summary>
		/// When on, extracts cells outside the frustum instead of inside.
		/// </summary>
		// Token: 0x06016E7A RID: 93818 RVA: 0x00203130 File Offset: 0x00201330
		public virtual int GetInsideOut()
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetInsideOut_06(base.GetCppThis());
		}

		// Token: 0x06016E7B RID: 93819
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkExtractSelectedFrustum_GetMTime_07(HandleRef pThis);

		/// <summary>
		/// Return the MTime taking into account changes to the Frustum
		/// </summary>
		// Token: 0x06016E7C RID: 93820 RVA: 0x00203150 File Offset: 0x00201350
		public override ulong GetMTime()
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetMTime_07(base.GetCppThis());
		}

		// Token: 0x06016E7D RID: 93821
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedFrustum_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E7E RID: 93822 RVA: 0x00203170 File Offset: 0x00201370
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06016E7F RID: 93823
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedFrustum_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E80 RID: 93824 RVA: 0x00203190 File Offset: 0x00201390
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06016E81 RID: 93825
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedFrustum_GetShowBounds_10(HandleRef pThis);

		/// <summary>
		/// When On, this returns an unstructured grid that outlines selection area.
		/// Off is the default.
		/// </summary>
		// Token: 0x06016E82 RID: 93826 RVA: 0x002031AC File Offset: 0x002013AC
		public virtual int GetShowBounds()
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_GetShowBounds_10(base.GetCppThis());
		}

		// Token: 0x06016E83 RID: 93827
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedFrustum_InsideOutOff_11(HandleRef pThis);

		/// <summary>
		/// When on, extracts cells outside the frustum instead of inside.
		/// </summary>
		// Token: 0x06016E84 RID: 93828 RVA: 0x002031CB File Offset: 0x002013CB
		public virtual void InsideOutOff()
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_InsideOutOff_11(base.GetCppThis());
		}

		// Token: 0x06016E85 RID: 93829
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedFrustum_InsideOutOn_12(HandleRef pThis);

		/// <summary>
		/// When on, extracts cells outside the frustum instead of inside.
		/// </summary>
		// Token: 0x06016E86 RID: 93830 RVA: 0x002031DA File Offset: 0x002013DA
		public virtual void InsideOutOn()
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_InsideOutOn_12(base.GetCppThis());
		}

		// Token: 0x06016E87 RID: 93831
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedFrustum_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E88 RID: 93832 RVA: 0x002031EC File Offset: 0x002013EC
		public override int IsA(string type)
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06016E89 RID: 93833
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedFrustum_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E8A RID: 93834 RVA: 0x0020320C File Offset: 0x0020140C
		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_IsTypeOf_14(type);
		}

		// Token: 0x06016E8B RID: 93835
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedFrustum_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E8C RID: 93836 RVA: 0x00203228 File Offset: 0x00201428
		public new vtkExtractSelectedFrustum NewInstance()
		{
			vtkExtractSelectedFrustum result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedFrustum)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016E8D RID: 93837
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedFrustum_OverallBoundsTest_17(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Does a quick test on the AABBox defined by the bounds.
		/// </summary>
		// Token: 0x06016E8E RID: 93838 RVA: 0x00203284 File Offset: 0x00201484
		public int OverallBoundsTest(IntPtr bounds)
		{
			return vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_OverallBoundsTest_17(base.GetCppThis(), bounds);
		}

		// Token: 0x06016E8F RID: 93839
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedFrustum_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E90 RID: 93840 RVA: 0x002032A4 File Offset: 0x002014A4
		public new static vtkExtractSelectedFrustum SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedFrustum vtkExtractSelectedFrustum = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedFrustum = (vtkExtractSelectedFrustum)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedFrustum.Register(null);
				}
			}
			return vtkExtractSelectedFrustum;
		}

		// Token: 0x06016E91 RID: 93841
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedFrustum_SetContainingCells_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Sets/gets the intersection test type. Only meaningful when fieldType is
		/// vtkSelection::POINT
		/// </summary>
		// Token: 0x06016E92 RID: 93842 RVA: 0x00203323 File Offset: 0x00201523
		public virtual void SetContainingCells(int _arg)
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_SetContainingCells_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06016E93 RID: 93843
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedFrustum_SetFieldType_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Sets/gets the intersection test type.
		/// </summary>
		// Token: 0x06016E94 RID: 93844 RVA: 0x00203333 File Offset: 0x00201533
		public virtual void SetFieldType(int _arg)
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_SetFieldType_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06016E95 RID: 93845
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedFrustum_SetFrustum_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the selection frustum. The planes object must contain six planes.
		/// </summary>
		// Token: 0x06016E96 RID: 93846 RVA: 0x00203344 File Offset: 0x00201544
		public virtual void SetFrustum(vtkPlanes arg0)
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_SetFrustum_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06016E97 RID: 93847
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedFrustum_SetInsideOut_22(HandleRef pThis, int _arg);

		/// <summary>
		/// When on, extracts cells outside the frustum instead of inside.
		/// </summary>
		// Token: 0x06016E98 RID: 93848 RVA: 0x00203373 File Offset: 0x00201573
		public virtual void SetInsideOut(int _arg)
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_SetInsideOut_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06016E99 RID: 93849
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedFrustum_SetShowBounds_23(HandleRef pThis, int _arg);

		/// <summary>
		/// When On, this returns an unstructured grid that outlines selection area.
		/// Off is the default.
		/// </summary>
		// Token: 0x06016E9A RID: 93850 RVA: 0x00203383 File Offset: 0x00201583
		public virtual void SetShowBounds(int _arg)
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_SetShowBounds_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06016E9B RID: 93851
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedFrustum_ShowBoundsOff_24(HandleRef pThis);

		/// <summary>
		/// When On, this returns an unstructured grid that outlines selection area.
		/// Off is the default.
		/// </summary>
		// Token: 0x06016E9C RID: 93852 RVA: 0x00203393 File Offset: 0x00201593
		public virtual void ShowBoundsOff()
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_ShowBoundsOff_24(base.GetCppThis());
		}

		// Token: 0x06016E9D RID: 93853
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedFrustum_ShowBoundsOn_25(HandleRef pThis);

		/// <summary>
		/// When On, this returns an unstructured grid that outlines selection area.
		/// Off is the default.
		/// </summary>
		// Token: 0x06016E9E RID: 93854 RVA: 0x002033A2 File Offset: 0x002015A2
		public virtual void ShowBoundsOn()
		{
			vtkExtractSelectedFrustum.vtkExtractSelectedFrustum_ShowBoundsOn_25(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400199D RID: 6557
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedFrustum";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400199E RID: 6558
		public new static readonly string MRClassNameKey = "class vtkExtractSelectedFrustum";
	}
}
