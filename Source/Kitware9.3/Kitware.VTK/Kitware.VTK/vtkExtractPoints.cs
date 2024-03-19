using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractPoints
	/// </summary>
	/// <remarks>
	///    extract points within an implicit function
	///
	///
	/// vtkExtractPoints removes points that are either inside or outside of a
	/// vtkImplicitFunction. Implicit functions in VTK defined as function of the
	/// form f(x,y,z)=c, where values c&lt;=0 are interior values of the implicit
	/// function. Typical examples include planes, spheres, cylinders, cones,
	/// etc. plus boolean combinations of these functions. (This operation
	/// presumes closure on the set, so points on the boundary are also considered
	/// to be inside.)
	///
	/// Note that while any vtkPointSet type can be provided as input, the output is
	/// represented by an explicit representation of points via a
	/// vtkPolyData. This output polydata will populate its instance of vtkPoints,
	/// but no cells will be defined (i.e., no vtkVertex or vtkPolyVertex are
	/// contained in the output). Also, after filter execution, the user can
	/// request a vtkIdType* map which indicates how the input points were mapped
	/// to the output. A value of map[i] (where i is the ith input point) less
	/// than 0 means that the ith input point was removed. (See also the
	/// superclass documentation for accessing the removed points through the
	/// filter's second output.)
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// @warning
	/// The vtkExtractEnclosedPoints filter can be used to extract points inside of
	/// a volume defined by a manifold, closed polygonal surface. This filter
	/// however is much slower than methods based on implicit functions (like this
	/// filter).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExtractEnclosedPoints vtkSelectEnclosedPoints vtkPointCloudFilter
	/// vtkRadiusOutlierRemoval vtkStatisticalOutlierRemoval vtkThresholdPoints
	/// vtkImplicitFunction vtkExtractGeometry vtkFitImplicitFunction
	/// </seealso>
	// Token: 0x02000442 RID: 1090
	public class vtkExtractPoints : vtkPointCloudFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CB8D RID: 52109 RVA: 0x0011B27F File Offset: 0x0011947F
		static vtkExtractPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CB8E RID: 52110 RVA: 0x0011B2A7 File Offset: 0x001194A7
		public vtkExtractPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CB8F RID: 52111
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CB90 RID: 52112 RVA: 0x0011B2B8 File Offset: 0x001194B8
		public new static vtkExtractPoints New()
		{
			vtkExtractPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPoints.vtkExtractPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CB91 RID: 52113 RVA: 0x0011B30C File Offset: 0x0011950C
		public vtkExtractPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractPoints.vtkExtractPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CB92 RID: 52114 RVA: 0x0011B350 File Offset: 0x00119550
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CB93 RID: 52115
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPoints_ExtractInsideOff_01(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract points that are inside of implicit
		/// function (ExtractInside == true) or outside of implicit function
		/// (ExtractInside == false). By default, ExtractInside is true.
		/// </summary>
		// Token: 0x0600CB94 RID: 52116 RVA: 0x0011B35B File Offset: 0x0011955B
		public virtual void ExtractInsideOff()
		{
			vtkExtractPoints.vtkExtractPoints_ExtractInsideOff_01(base.GetCppThis());
		}

		// Token: 0x0600CB95 RID: 52117
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPoints_ExtractInsideOn_02(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract points that are inside of implicit
		/// function (ExtractInside == true) or outside of implicit function
		/// (ExtractInside == false). By default, ExtractInside is true.
		/// </summary>
		// Token: 0x0600CB96 RID: 52118 RVA: 0x0011B36A File Offset: 0x0011956A
		public virtual void ExtractInsideOn()
		{
			vtkExtractPoints.vtkExtractPoints_ExtractInsideOn_02(base.GetCppThis());
		}

		// Token: 0x0600CB97 RID: 52119
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractPoints_GetExtractInside_03(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to extract points that are inside of implicit
		/// function (ExtractInside == true) or outside of implicit function
		/// (ExtractInside == false). By default, ExtractInside is true.
		/// </summary>
		// Token: 0x0600CB98 RID: 52120 RVA: 0x0011B37C File Offset: 0x0011957C
		public virtual bool GetExtractInside()
		{
			return vtkExtractPoints.vtkExtractPoints_GetExtractInside_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CB99 RID: 52121
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPoints_GetImplicitFunction_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function for inside/outside checks.
		/// </summary>
		// Token: 0x0600CB9A RID: 52122 RVA: 0x0011B3A4 File Offset: 0x001195A4
		public virtual vtkImplicitFunction GetImplicitFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPoints.vtkExtractPoints_GetImplicitFunction_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600CB9B RID: 52123
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkExtractPoints_GetMTime_05(HandleRef pThis);

		/// <summary>
		/// Return the MTime taking into account changes to the implicit function
		/// </summary>
		// Token: 0x0600CB9C RID: 52124 RVA: 0x0011B414 File Offset: 0x00119614
		public override ulong GetMTime()
		{
			return vtkExtractPoints.vtkExtractPoints_GetMTime_05(base.GetCppThis());
		}

		// Token: 0x0600CB9D RID: 52125
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractPoints_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CB9E RID: 52126 RVA: 0x0011B434 File Offset: 0x00119634
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractPoints.vtkExtractPoints_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600CB9F RID: 52127
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractPoints_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CBA0 RID: 52128 RVA: 0x0011B454 File Offset: 0x00119654
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractPoints.vtkExtractPoints_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600CBA1 RID: 52129
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractPoints_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CBA2 RID: 52130 RVA: 0x0011B470 File Offset: 0x00119670
		public override int IsA(string type)
		{
			return vtkExtractPoints.vtkExtractPoints_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600CBA3 RID: 52131
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractPoints_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CBA4 RID: 52132 RVA: 0x0011B490 File Offset: 0x00119690
		public new static int IsTypeOf(string type)
		{
			return vtkExtractPoints.vtkExtractPoints_IsTypeOf_09(type);
		}

		// Token: 0x0600CBA5 RID: 52133
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPoints_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CBA6 RID: 52134 RVA: 0x0011B4AC File Offset: 0x001196AC
		public new vtkExtractPoints NewInstance()
		{
			vtkExtractPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPoints.vtkExtractPoints_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CBA7 RID: 52135
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPoints_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CBA8 RID: 52136 RVA: 0x0011B508 File Offset: 0x00119708
		public new static vtkExtractPoints SafeDownCast(vtkObjectBase o)
		{
			vtkExtractPoints vtkExtractPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPoints.vtkExtractPoints_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractPoints = (vtkExtractPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractPoints.Register(null);
				}
			}
			return vtkExtractPoints;
		}

		// Token: 0x0600CBA9 RID: 52137
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPoints_SetExtractInside_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// Boolean controls whether to extract points that are inside of implicit
		/// function (ExtractInside == true) or outside of implicit function
		/// (ExtractInside == false). By default, ExtractInside is true.
		/// </summary>
		// Token: 0x0600CBAA RID: 52138 RVA: 0x0011B587 File Offset: 0x00119787
		public virtual void SetExtractInside(bool _arg)
		{
			vtkExtractPoints.vtkExtractPoints_SetExtractInside_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CBAB RID: 52139
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPoints_SetImplicitFunction_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function for inside/outside checks.
		/// </summary>
		// Token: 0x0600CBAC RID: 52140 RVA: 0x0011B5A0 File Offset: 0x001197A0
		public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
		{
			vtkExtractPoints.vtkExtractPoints_SetImplicitFunction_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F11 RID: 3857
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F12 RID: 3858
		public new static readonly string MRClassNameKey = "class vtkExtractPoints";
	}
}
