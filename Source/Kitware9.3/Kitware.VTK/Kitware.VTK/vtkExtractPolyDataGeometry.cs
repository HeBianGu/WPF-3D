using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractPolyDataGeometry
	/// </summary>
	/// <remarks>
	///    extract vtkPolyData cells that lies either entirely inside or outside of a specified
	/// implicit function
	///
	///
	/// vtkExtractPolyDataGeometry extracts from its input vtkPolyData all cells
	/// that are either completely inside or outside of a specified implicit
	/// function. This filter is specialized to vtkPolyData. On output the
	/// filter generates vtkPolyData.
	///
	/// To use this filter you must specify an implicit function. You must also
	/// specify whether to extract cells laying inside or outside of the implicit
	/// function. (The inside of an implicit function is the negative values
	/// region.) An option exists to extract cells that are neither inside nor
	/// outside (i.e., boundary).
	///
	/// Note that this filter also has the option to directly pass all points or cull
	/// the points that do not satisfy the implicit function test. Passing all points
	/// is a tad faster, but then points remain that do not pass the test and may mess
	/// up subsequent glyphing operations and so on. By default points are culled.
	///
	/// A more general version of this filter is available for arbitrary
	/// vtkDataSet input (see vtkExtractGeometry).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExtractGeometry vtkClipPolyData vtkImplicitFunction
	/// </seealso>
	// Token: 0x020006AF RID: 1711
	public class vtkExtractPolyDataGeometry : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012486 RID: 74886 RVA: 0x00199DF3 File Offset: 0x00197FF3
		static vtkExtractPolyDataGeometry()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractPolyDataGeometry.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractPolyDataGeometry"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012487 RID: 74887 RVA: 0x00199E1B File Offset: 0x0019801B
		public vtkExtractPolyDataGeometry(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012488 RID: 74888
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPolyDataGeometry_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with ExtractInside turned on.
		/// </summary>
		// Token: 0x06012489 RID: 74889 RVA: 0x00199E2C File Offset: 0x0019802C
		public new static vtkExtractPolyDataGeometry New()
		{
			vtkExtractPolyDataGeometry result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractPolyDataGeometry)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with ExtractInside turned on.
		/// </summary>
		// Token: 0x0601248A RID: 74890 RVA: 0x00199E80 File Offset: 0x00198080
		public vtkExtractPolyDataGeometry() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601248B RID: 74891 RVA: 0x00199EC4 File Offset: 0x001980C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601248C RID: 74892
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPolyDataGeometry_ExtractBoundaryCellsOff_01(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract cells that are partially inside.
		/// By default, ExtractBoundaryCells is off.
		/// </summary>
		// Token: 0x0601248D RID: 74893 RVA: 0x00199ECF File Offset: 0x001980CF
		public virtual void ExtractBoundaryCellsOff()
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_ExtractBoundaryCellsOff_01(base.GetCppThis());
		}

		// Token: 0x0601248E RID: 74894
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPolyDataGeometry_ExtractBoundaryCellsOn_02(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract cells that are partially inside.
		/// By default, ExtractBoundaryCells is off.
		/// </summary>
		// Token: 0x0601248F RID: 74895 RVA: 0x00199EDE File Offset: 0x001980DE
		public virtual void ExtractBoundaryCellsOn()
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_ExtractBoundaryCellsOn_02(base.GetCppThis());
		}

		// Token: 0x06012490 RID: 74896
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPolyDataGeometry_ExtractInsideOff_03(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract cells that are inside of implicit
		/// function (ExtractInside == 1) or outside of implicit function
		/// (ExtractInside == 0).
		/// </summary>
		// Token: 0x06012491 RID: 74897 RVA: 0x00199EED File Offset: 0x001980ED
		public virtual void ExtractInsideOff()
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_ExtractInsideOff_03(base.GetCppThis());
		}

		// Token: 0x06012492 RID: 74898
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPolyDataGeometry_ExtractInsideOn_04(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract cells that are inside of implicit
		/// function (ExtractInside == 1) or outside of implicit function
		/// (ExtractInside == 0).
		/// </summary>
		// Token: 0x06012493 RID: 74899 RVA: 0x00199EFC File Offset: 0x001980FC
		public virtual void ExtractInsideOn()
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_ExtractInsideOn_04(base.GetCppThis());
		}

		// Token: 0x06012494 RID: 74900
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractPolyDataGeometry_GetExtractBoundaryCells_05(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract cells that are partially inside.
		/// By default, ExtractBoundaryCells is off.
		/// </summary>
		// Token: 0x06012495 RID: 74901 RVA: 0x00199F0C File Offset: 0x0019810C
		public virtual int GetExtractBoundaryCells()
		{
			return vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_GetExtractBoundaryCells_05(base.GetCppThis());
		}

		// Token: 0x06012496 RID: 74902
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractPolyDataGeometry_GetExtractInside_06(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract cells that are inside of implicit
		/// function (ExtractInside == 1) or outside of implicit function
		/// (ExtractInside == 0).
		/// </summary>
		// Token: 0x06012497 RID: 74903 RVA: 0x00199F2C File Offset: 0x0019812C
		public virtual int GetExtractInside()
		{
			return vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_GetExtractInside_06(base.GetCppThis());
		}

		// Token: 0x06012498 RID: 74904
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPolyDataGeometry_GetImplicitFunction_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function for inside/outside checks.
		/// </summary>
		// Token: 0x06012499 RID: 74905 RVA: 0x00199F4C File Offset: 0x0019814C
		public virtual vtkImplicitFunction GetImplicitFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_GetImplicitFunction_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601249A RID: 74906
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkExtractPolyDataGeometry_GetMTime_08(HandleRef pThis);

		/// <summary>
		/// Return the MTime taking into account changes to the implicit function
		/// </summary>
		// Token: 0x0601249B RID: 74907 RVA: 0x00199FBC File Offset: 0x001981BC
		public override ulong GetMTime()
		{
			return vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_GetMTime_08(base.GetCppThis());
		}

		// Token: 0x0601249C RID: 74908
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractPolyDataGeometry_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601249D RID: 74909 RVA: 0x00199FDC File Offset: 0x001981DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0601249E RID: 74910
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractPolyDataGeometry_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601249F RID: 74911 RVA: 0x00199FFC File Offset: 0x001981FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x060124A0 RID: 74912
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractPolyDataGeometry_GetPassPoints_11(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether points are culled or simply passed through
		/// to the output.
		/// </summary>
		// Token: 0x060124A1 RID: 74913 RVA: 0x0019A018 File Offset: 0x00198218
		public virtual int GetPassPoints()
		{
			return vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_GetPassPoints_11(base.GetCppThis());
		}

		// Token: 0x060124A2 RID: 74914
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractPolyDataGeometry_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124A3 RID: 74915 RVA: 0x0019A038 File Offset: 0x00198238
		public override int IsA(string type)
		{
			return vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x060124A4 RID: 74916
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractPolyDataGeometry_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124A5 RID: 74917 RVA: 0x0019A058 File Offset: 0x00198258
		public new static int IsTypeOf(string type)
		{
			return vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_IsTypeOf_13(type);
		}

		// Token: 0x060124A6 RID: 74918
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPolyDataGeometry_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124A7 RID: 74919 RVA: 0x0019A074 File Offset: 0x00198274
		public new vtkExtractPolyDataGeometry NewInstance()
		{
			vtkExtractPolyDataGeometry result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractPolyDataGeometry)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060124A8 RID: 74920
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPolyDataGeometry_PassPointsOff_16(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether points are culled or simply passed through
		/// to the output.
		/// </summary>
		// Token: 0x060124A9 RID: 74921 RVA: 0x0019A0CE File Offset: 0x001982CE
		public virtual void PassPointsOff()
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_PassPointsOff_16(base.GetCppThis());
		}

		// Token: 0x060124AA RID: 74922
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPolyDataGeometry_PassPointsOn_17(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether points are culled or simply passed through
		/// to the output.
		/// </summary>
		// Token: 0x060124AB RID: 74923 RVA: 0x0019A0DD File Offset: 0x001982DD
		public virtual void PassPointsOn()
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_PassPointsOn_17(base.GetCppThis());
		}

		// Token: 0x060124AC RID: 74924
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPolyDataGeometry_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124AD RID: 74925 RVA: 0x0019A0EC File Offset: 0x001982EC
		public new static vtkExtractPolyDataGeometry SafeDownCast(vtkObjectBase o)
		{
			vtkExtractPolyDataGeometry vtkExtractPolyDataGeometry = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractPolyDataGeometry = (vtkExtractPolyDataGeometry)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractPolyDataGeometry.Register(null);
				}
			}
			return vtkExtractPolyDataGeometry;
		}

		// Token: 0x060124AE RID: 74926
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPolyDataGeometry_SetExtractBoundaryCells_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether to extract cells that are partially inside.
		/// By default, ExtractBoundaryCells is off.
		/// </summary>
		// Token: 0x060124AF RID: 74927 RVA: 0x0019A16B File Offset: 0x0019836B
		public virtual void SetExtractBoundaryCells(int _arg)
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_SetExtractBoundaryCells_19(base.GetCppThis(), _arg);
		}

		// Token: 0x060124B0 RID: 74928
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPolyDataGeometry_SetExtractInside_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether to extract cells that are inside of implicit
		/// function (ExtractInside == 1) or outside of implicit function
		/// (ExtractInside == 0).
		/// </summary>
		// Token: 0x060124B1 RID: 74929 RVA: 0x0019A17B File Offset: 0x0019837B
		public virtual void SetExtractInside(int _arg)
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_SetExtractInside_20(base.GetCppThis(), _arg);
		}

		// Token: 0x060124B2 RID: 74930
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPolyDataGeometry_SetImplicitFunction_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function for inside/outside checks.
		/// </summary>
		// Token: 0x060124B3 RID: 74931 RVA: 0x0019A18C File Offset: 0x0019838C
		public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_SetImplicitFunction_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060124B4 RID: 74932
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPolyDataGeometry_SetPassPoints_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether points are culled or simply passed through
		/// to the output.
		/// </summary>
		// Token: 0x060124B5 RID: 74933 RVA: 0x0019A1BB File Offset: 0x001983BB
		public virtual void SetPassPoints(int _arg)
		{
			vtkExtractPolyDataGeometry.vtkExtractPolyDataGeometry_SetPassPoints_22(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400150C RID: 5388
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractPolyDataGeometry";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400150D RID: 5389
		public new static readonly string MRClassNameKey = "class vtkExtractPolyDataGeometry";
	}
}
