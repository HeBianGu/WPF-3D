using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUncertaintyTubeFilter
	/// </summary>
	/// <remarks>
	///    generate uncertainty tubes along a polyline
	///
	/// vtkUncertaintyTubeFilter is a filter that generates ellipsoidal (in cross
	/// section) tubes that follows a polyline. The input is a vtkPolyData with
	/// polylines that have associated vector point data. The vector data represents
	/// the uncertainty of the polyline in the x-y-z directions.
	///
	/// @warning
	/// The vector uncertainty values define an axis-aligned ellipsoid at each
	/// polyline point. The uncertainty tubes can be envisioned as the
	/// interpolation of these ellipsoids between the points defining the
	/// polyline (or rather, the interpolation of the cross section of the
	/// ellipsoids along the polyline).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTensorGlyph vtkStreamTracer
	/// </seealso>
	// Token: 0x020008F5 RID: 2293
	public class vtkUncertaintyTubeFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017B09 RID: 97033 RVA: 0x0021375B File Offset: 0x0021195B
		static vtkUncertaintyTubeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUncertaintyTubeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUncertaintyTubeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017B0A RID: 97034 RVA: 0x00213783 File Offset: 0x00211983
		public vtkUncertaintyTubeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017B0B RID: 97035
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUncertaintyTubeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Object factory method to instantiate this class.
		/// </summary>
		// Token: 0x06017B0C RID: 97036 RVA: 0x00213794 File Offset: 0x00211994
		public new static vtkUncertaintyTubeFilter New()
		{
			vtkUncertaintyTubeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUncertaintyTubeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Object factory method to instantiate this class.
		/// </summary>
		// Token: 0x06017B0D RID: 97037 RVA: 0x002137E8 File Offset: 0x002119E8
		public vtkUncertaintyTubeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017B0E RID: 97038 RVA: 0x0021382C File Offset: 0x00211A2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017B0F RID: 97039
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUncertaintyTubeFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and obtaining type information for instances of this class.
		/// </summary>
		// Token: 0x06017B10 RID: 97040 RVA: 0x00213838 File Offset: 0x00211A38
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06017B11 RID: 97041
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUncertaintyTubeFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and obtaining type information for instances of this class.
		/// </summary>
		// Token: 0x06017B12 RID: 97042 RVA: 0x00213858 File Offset: 0x00211A58
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06017B13 RID: 97043
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUncertaintyTubeFilter_GetNumberOfSides_03(HandleRef pThis);

		/// <summary>
		/// Set / get the number of sides for the tube. At a minimum,
		/// the number of sides is 3.
		/// </summary>
		// Token: 0x06017B14 RID: 97044 RVA: 0x00213874 File Offset: 0x00211A74
		public virtual int GetNumberOfSides()
		{
			return vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_GetNumberOfSides_03(base.GetCppThis());
		}

		// Token: 0x06017B15 RID: 97045
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUncertaintyTubeFilter_GetNumberOfSidesMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set / get the number of sides for the tube. At a minimum,
		/// the number of sides is 3.
		/// </summary>
		// Token: 0x06017B16 RID: 97046 RVA: 0x00213894 File Offset: 0x00211A94
		public virtual int GetNumberOfSidesMaxValue()
		{
			return vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_GetNumberOfSidesMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06017B17 RID: 97047
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUncertaintyTubeFilter_GetNumberOfSidesMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set / get the number of sides for the tube. At a minimum,
		/// the number of sides is 3.
		/// </summary>
		// Token: 0x06017B18 RID: 97048 RVA: 0x002138B4 File Offset: 0x00211AB4
		public virtual int GetNumberOfSidesMinValue()
		{
			return vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_GetNumberOfSidesMinValue_05(base.GetCppThis());
		}

		// Token: 0x06017B19 RID: 97049
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUncertaintyTubeFilter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and obtaining type information for instances of this class.
		/// </summary>
		// Token: 0x06017B1A RID: 97050 RVA: 0x002138D4 File Offset: 0x00211AD4
		public override int IsA(string type)
		{
			return vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06017B1B RID: 97051
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUncertaintyTubeFilter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and obtaining type information for instances of this class.
		/// </summary>
		// Token: 0x06017B1C RID: 97052 RVA: 0x002138F4 File Offset: 0x00211AF4
		public new static int IsTypeOf(string type)
		{
			return vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_IsTypeOf_07(type);
		}

		// Token: 0x06017B1D RID: 97053
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUncertaintyTubeFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for printing and obtaining type information for instances of this class.
		/// </summary>
		// Token: 0x06017B1E RID: 97054 RVA: 0x00213910 File Offset: 0x00211B10
		public new vtkUncertaintyTubeFilter NewInstance()
		{
			vtkUncertaintyTubeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUncertaintyTubeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017B1F RID: 97055
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUncertaintyTubeFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for printing and obtaining type information for instances of this class.
		/// </summary>
		// Token: 0x06017B20 RID: 97056 RVA: 0x0021396C File Offset: 0x00211B6C
		public new static vtkUncertaintyTubeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkUncertaintyTubeFilter vtkUncertaintyTubeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUncertaintyTubeFilter = (vtkUncertaintyTubeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUncertaintyTubeFilter.Register(null);
				}
			}
			return vtkUncertaintyTubeFilter;
		}

		// Token: 0x06017B21 RID: 97057
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUncertaintyTubeFilter_SetNumberOfSides_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Set / get the number of sides for the tube. At a minimum,
		/// the number of sides is 3.
		/// </summary>
		// Token: 0x06017B22 RID: 97058 RVA: 0x002139EB File Offset: 0x00211BEB
		public virtual void SetNumberOfSides(int _arg)
		{
			vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_SetNumberOfSides_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A69 RID: 6761
		public new const string MRFullTypeName = "Kitware.VTK.vtkUncertaintyTubeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A6A RID: 6762
		public new static readonly string MRClassNameKey = "class vtkUncertaintyTubeFilter";
	}
}
