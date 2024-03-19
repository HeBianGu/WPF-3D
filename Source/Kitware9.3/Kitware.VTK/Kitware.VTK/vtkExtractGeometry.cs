using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractGeometry
	/// </summary>
	/// <remarks>
	///    extract cells that lie either entirely inside or outside of a specified
	///          implicit function
	///
	/// vtkExtractGeometry extracts from its input dataset all cells that are either
	/// completely inside or outside of a specified implicit function. Any type of
	/// dataset can be input to this filter. On output the filter generates an
	/// unstructured grid.
	///
	/// To use this filter you must specify an implicit function. You must also
	/// specify whether to extract cells laying inside or outside of the implicit
	/// function. (The inside of an implicit function is the negative values
	/// region.) An option exists to extract cells that are neither inside or
	/// outside (i.e., boundary).
	///
	/// A more efficient version of this filter is available for vtkPolyData input.
	/// See vtkExtractPolyDataGeometry.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExtractPolyDataGeometry vtkGeometryFilter vtkExtractVOI
	/// </seealso>
	// Token: 0x020006AB RID: 1707
	public class vtkExtractGeometry : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060123FE RID: 74750 RVA: 0x001991C3 File Offset: 0x001973C3
		static vtkExtractGeometry()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractGeometry.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractGeometry"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060123FF RID: 74751 RVA: 0x001991EB File Offset: 0x001973EB
		public vtkExtractGeometry(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012400 RID: 74752
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractGeometry_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with ExtractInside turned on.
		/// </summary>
		// Token: 0x06012401 RID: 74753 RVA: 0x001991FC File Offset: 0x001973FC
		public new static vtkExtractGeometry New()
		{
			vtkExtractGeometry result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractGeometry.vtkExtractGeometry_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractGeometry)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with ExtractInside turned on.
		/// </summary>
		// Token: 0x06012402 RID: 74754 RVA: 0x00199250 File Offset: 0x00197450
		public vtkExtractGeometry() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractGeometry.vtkExtractGeometry_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012403 RID: 74755 RVA: 0x00199294 File Offset: 0x00197494
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012404 RID: 74756
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGeometry_ExtractBoundaryCellsOff_01(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract cells that are partially inside.
		/// By default, ExtractBoundaryCells is off.
		/// </summary>
		// Token: 0x06012405 RID: 74757 RVA: 0x0019929F File Offset: 0x0019749F
		public virtual void ExtractBoundaryCellsOff()
		{
			vtkExtractGeometry.vtkExtractGeometry_ExtractBoundaryCellsOff_01(base.GetCppThis());
		}

		// Token: 0x06012406 RID: 74758
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGeometry_ExtractBoundaryCellsOn_02(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract cells that are partially inside.
		/// By default, ExtractBoundaryCells is off.
		/// </summary>
		// Token: 0x06012407 RID: 74759 RVA: 0x001992AE File Offset: 0x001974AE
		public virtual void ExtractBoundaryCellsOn()
		{
			vtkExtractGeometry.vtkExtractGeometry_ExtractBoundaryCellsOn_02(base.GetCppThis());
		}

		// Token: 0x06012408 RID: 74760
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGeometry_ExtractInsideOff_03(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract cells that are inside of implicit
		/// function (ExtractInside == 1) or outside of implicit function
		/// (ExtractInside == 0).
		/// </summary>
		// Token: 0x06012409 RID: 74761 RVA: 0x001992BD File Offset: 0x001974BD
		public virtual void ExtractInsideOff()
		{
			vtkExtractGeometry.vtkExtractGeometry_ExtractInsideOff_03(base.GetCppThis());
		}

		// Token: 0x0601240A RID: 74762
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGeometry_ExtractInsideOn_04(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract cells that are inside of implicit
		/// function (ExtractInside == 1) or outside of implicit function
		/// (ExtractInside == 0).
		/// </summary>
		// Token: 0x0601240B RID: 74763 RVA: 0x001992CC File Offset: 0x001974CC
		public virtual void ExtractInsideOn()
		{
			vtkExtractGeometry.vtkExtractGeometry_ExtractInsideOn_04(base.GetCppThis());
		}

		// Token: 0x0601240C RID: 74764
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGeometry_ExtractOnlyBoundaryCellsOff_05(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract cells that are partially inside.
		/// By default, ExtractBoundaryCells is off.
		/// </summary>
		// Token: 0x0601240D RID: 74765 RVA: 0x001992DB File Offset: 0x001974DB
		public virtual void ExtractOnlyBoundaryCellsOff()
		{
			vtkExtractGeometry.vtkExtractGeometry_ExtractOnlyBoundaryCellsOff_05(base.GetCppThis());
		}

		// Token: 0x0601240E RID: 74766
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGeometry_ExtractOnlyBoundaryCellsOn_06(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract cells that are partially inside.
		/// By default, ExtractBoundaryCells is off.
		/// </summary>
		// Token: 0x0601240F RID: 74767 RVA: 0x001992EA File Offset: 0x001974EA
		public virtual void ExtractOnlyBoundaryCellsOn()
		{
			vtkExtractGeometry.vtkExtractGeometry_ExtractOnlyBoundaryCellsOn_06(base.GetCppThis());
		}

		// Token: 0x06012410 RID: 74768
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractGeometry_GetExtractBoundaryCells_07(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract cells that are partially inside.
		/// By default, ExtractBoundaryCells is off.
		/// </summary>
		// Token: 0x06012411 RID: 74769 RVA: 0x001992FC File Offset: 0x001974FC
		public virtual int GetExtractBoundaryCells()
		{
			return vtkExtractGeometry.vtkExtractGeometry_GetExtractBoundaryCells_07(base.GetCppThis());
		}

		// Token: 0x06012412 RID: 74770
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractGeometry_GetExtractInside_08(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract cells that are inside of implicit
		/// function (ExtractInside == 1) or outside of implicit function
		/// (ExtractInside == 0).
		/// </summary>
		// Token: 0x06012413 RID: 74771 RVA: 0x0019931C File Offset: 0x0019751C
		public virtual int GetExtractInside()
		{
			return vtkExtractGeometry.vtkExtractGeometry_GetExtractInside_08(base.GetCppThis());
		}

		// Token: 0x06012414 RID: 74772
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractGeometry_GetExtractOnlyBoundaryCells_09(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract cells that are partially inside.
		/// By default, ExtractBoundaryCells is off.
		/// </summary>
		// Token: 0x06012415 RID: 74773 RVA: 0x0019933C File Offset: 0x0019753C
		public virtual int GetExtractOnlyBoundaryCells()
		{
			return vtkExtractGeometry.vtkExtractGeometry_GetExtractOnlyBoundaryCells_09(base.GetCppThis());
		}

		// Token: 0x06012416 RID: 74774
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractGeometry_GetImplicitFunction_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function for inside/outside checks.
		/// </summary>
		// Token: 0x06012417 RID: 74775 RVA: 0x0019935C File Offset: 0x0019755C
		public virtual vtkImplicitFunction GetImplicitFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractGeometry.vtkExtractGeometry_GetImplicitFunction_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x06012418 RID: 74776
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkExtractGeometry_GetMTime_11(HandleRef pThis);

		/// <summary>
		/// Return the MTime taking into account changes to the implicit function
		/// </summary>
		// Token: 0x06012419 RID: 74777 RVA: 0x001993CC File Offset: 0x001975CC
		public override ulong GetMTime()
		{
			return vtkExtractGeometry.vtkExtractGeometry_GetMTime_11(base.GetCppThis());
		}

		// Token: 0x0601241A RID: 74778
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractGeometry_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601241B RID: 74779 RVA: 0x001993EC File Offset: 0x001975EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractGeometry.vtkExtractGeometry_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0601241C RID: 74780
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractGeometry_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601241D RID: 74781 RVA: 0x0019940C File Offset: 0x0019760C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractGeometry.vtkExtractGeometry_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0601241E RID: 74782
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractGeometry_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601241F RID: 74783 RVA: 0x00199428 File Offset: 0x00197628
		public override int IsA(string type)
		{
			return vtkExtractGeometry.vtkExtractGeometry_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06012420 RID: 74784
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractGeometry_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012421 RID: 74785 RVA: 0x00199448 File Offset: 0x00197648
		public new static int IsTypeOf(string type)
		{
			return vtkExtractGeometry.vtkExtractGeometry_IsTypeOf_15(type);
		}

		// Token: 0x06012422 RID: 74786
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractGeometry_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012423 RID: 74787 RVA: 0x00199464 File Offset: 0x00197664
		public new vtkExtractGeometry NewInstance()
		{
			vtkExtractGeometry result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractGeometry.vtkExtractGeometry_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractGeometry)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012424 RID: 74788
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractGeometry_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012425 RID: 74789 RVA: 0x001994C0 File Offset: 0x001976C0
		public new static vtkExtractGeometry SafeDownCast(vtkObjectBase o)
		{
			vtkExtractGeometry vtkExtractGeometry = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractGeometry.vtkExtractGeometry_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractGeometry = (vtkExtractGeometry)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractGeometry.Register(null);
				}
			}
			return vtkExtractGeometry;
		}

		// Token: 0x06012426 RID: 74790
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGeometry_SetExtractBoundaryCells_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether to extract cells that are partially inside.
		/// By default, ExtractBoundaryCells is off.
		/// </summary>
		// Token: 0x06012427 RID: 74791 RVA: 0x0019953F File Offset: 0x0019773F
		public virtual void SetExtractBoundaryCells(int _arg)
		{
			vtkExtractGeometry.vtkExtractGeometry_SetExtractBoundaryCells_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06012428 RID: 74792
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGeometry_SetExtractInside_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether to extract cells that are inside of implicit
		/// function (ExtractInside == 1) or outside of implicit function
		/// (ExtractInside == 0).
		/// </summary>
		// Token: 0x06012429 RID: 74793 RVA: 0x0019954F File Offset: 0x0019774F
		public virtual void SetExtractInside(int _arg)
		{
			vtkExtractGeometry.vtkExtractGeometry_SetExtractInside_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0601242A RID: 74794
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGeometry_SetExtractOnlyBoundaryCells_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether to extract cells that are partially inside.
		/// By default, ExtractBoundaryCells is off.
		/// </summary>
		// Token: 0x0601242B RID: 74795 RVA: 0x0019955F File Offset: 0x0019775F
		public virtual void SetExtractOnlyBoundaryCells(int _arg)
		{
			vtkExtractGeometry.vtkExtractGeometry_SetExtractOnlyBoundaryCells_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0601242C RID: 74796
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractGeometry_SetImplicitFunction_22(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function for inside/outside checks.
		/// </summary>
		// Token: 0x0601242D RID: 74797 RVA: 0x00199570 File Offset: 0x00197770
		public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
		{
			vtkExtractGeometry.vtkExtractGeometry_SetImplicitFunction_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001504 RID: 5380
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractGeometry";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001505 RID: 5381
		public new static readonly string MRClassNameKey = "class vtkExtractGeometry";
	}
}
