using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFitImplicitFunction
	/// </summary>
	/// <remarks>
	///    extract points on the surface of an implicit function
	///
	///
	/// vtkFitImplicitFunction extract points that are on the surface of an
	/// implicit function (within some threshold). Implicit functions in VTK are
	/// any function of the form f(x,y,z)=c, where values c==0 are considered the
	/// surface of the implicit function. Typical examples of implicit functions
	/// include planes, spheres, cylinders, cones, etc. plus boolean combinations
	/// of these functions. In this implementation, a threshold is used to create
	/// a fuzzy region considered "on" the surface. In essence, this is a very
	/// poor man's RANSAC algorithm, where the user picks a function on which to
	/// fit some points. Thus it is possible to use this filter to define a
	/// proposed model and place it into an optimization loop to best fit it to a
	/// set of points.
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
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointCloudFilter vtkExtractPoints vtkImplicitFunction
	/// </seealso>
	// Token: 0x02000444 RID: 1092
	public class vtkFitImplicitFunction : vtkPointCloudFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CBDF RID: 52191 RVA: 0x0011B96B File Offset: 0x00119B6B
		static vtkFitImplicitFunction()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFitImplicitFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFitImplicitFunction"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CBE0 RID: 52192 RVA: 0x0011B993 File Offset: 0x00119B93
		public vtkFitImplicitFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CBE1 RID: 52193
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFitImplicitFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CBE2 RID: 52194 RVA: 0x0011B9A4 File Offset: 0x00119BA4
		public new static vtkFitImplicitFunction New()
		{
			vtkFitImplicitFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFitImplicitFunction.vtkFitImplicitFunction_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFitImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CBE3 RID: 52195 RVA: 0x0011B9F8 File Offset: 0x00119BF8
		public vtkFitImplicitFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFitImplicitFunction.vtkFitImplicitFunction_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CBE4 RID: 52196 RVA: 0x0011BA3C File Offset: 0x00119C3C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CBE5 RID: 52197
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFitImplicitFunction_GetImplicitFunction_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function defining a surface on which points
		/// are to be extracted.
		/// </summary>
		// Token: 0x0600CBE6 RID: 52198 RVA: 0x0011BA48 File Offset: 0x00119C48
		public virtual vtkImplicitFunction GetImplicitFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFitImplicitFunction.vtkFitImplicitFunction_GetImplicitFunction_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600CBE7 RID: 52199
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkFitImplicitFunction_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// Return the MTime taking into account changes to the implicit function.
		/// </summary>
		// Token: 0x0600CBE8 RID: 52200 RVA: 0x0011BAB8 File Offset: 0x00119CB8
		public override ulong GetMTime()
		{
			return vtkFitImplicitFunction.vtkFitImplicitFunction_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x0600CBE9 RID: 52201
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFitImplicitFunction_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CBEA RID: 52202 RVA: 0x0011BAD8 File Offset: 0x00119CD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFitImplicitFunction.vtkFitImplicitFunction_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600CBEB RID: 52203
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFitImplicitFunction_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CBEC RID: 52204 RVA: 0x0011BAF8 File Offset: 0x00119CF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFitImplicitFunction.vtkFitImplicitFunction_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600CBED RID: 52205
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFitImplicitFunction_GetThreshold_05(HandleRef pThis);

		/// <summary>
		/// Specify a threshold value which defines a fuzzy extraction surface.
		/// Since in this filter the implicit surface is defined as f(x,y,z)=0;
		/// the extracted points are (-Threshold &lt;= f(x,y,z) &lt; Threshold).
		/// </summary>
		// Token: 0x0600CBEE RID: 52206 RVA: 0x0011BB14 File Offset: 0x00119D14
		public virtual double GetThreshold()
		{
			return vtkFitImplicitFunction.vtkFitImplicitFunction_GetThreshold_05(base.GetCppThis());
		}

		// Token: 0x0600CBEF RID: 52207
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFitImplicitFunction_GetThresholdMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Specify a threshold value which defines a fuzzy extraction surface.
		/// Since in this filter the implicit surface is defined as f(x,y,z)=0;
		/// the extracted points are (-Threshold &lt;= f(x,y,z) &lt; Threshold).
		/// </summary>
		// Token: 0x0600CBF0 RID: 52208 RVA: 0x0011BB34 File Offset: 0x00119D34
		public virtual double GetThresholdMaxValue()
		{
			return vtkFitImplicitFunction.vtkFitImplicitFunction_GetThresholdMaxValue_06(base.GetCppThis());
		}

		// Token: 0x0600CBF1 RID: 52209
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFitImplicitFunction_GetThresholdMinValue_07(HandleRef pThis);

		/// <summary>
		/// Specify a threshold value which defines a fuzzy extraction surface.
		/// Since in this filter the implicit surface is defined as f(x,y,z)=0;
		/// the extracted points are (-Threshold &lt;= f(x,y,z) &lt; Threshold).
		/// </summary>
		// Token: 0x0600CBF2 RID: 52210 RVA: 0x0011BB54 File Offset: 0x00119D54
		public virtual double GetThresholdMinValue()
		{
			return vtkFitImplicitFunction.vtkFitImplicitFunction_GetThresholdMinValue_07(base.GetCppThis());
		}

		// Token: 0x0600CBF3 RID: 52211
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFitImplicitFunction_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CBF4 RID: 52212 RVA: 0x0011BB74 File Offset: 0x00119D74
		public override int IsA(string type)
		{
			return vtkFitImplicitFunction.vtkFitImplicitFunction_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600CBF5 RID: 52213
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFitImplicitFunction_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CBF6 RID: 52214 RVA: 0x0011BB94 File Offset: 0x00119D94
		public new static int IsTypeOf(string type)
		{
			return vtkFitImplicitFunction.vtkFitImplicitFunction_IsTypeOf_09(type);
		}

		// Token: 0x0600CBF7 RID: 52215
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFitImplicitFunction_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CBF8 RID: 52216 RVA: 0x0011BBB0 File Offset: 0x00119DB0
		public new vtkFitImplicitFunction NewInstance()
		{
			vtkFitImplicitFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFitImplicitFunction.vtkFitImplicitFunction_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFitImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CBF9 RID: 52217
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFitImplicitFunction_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CBFA RID: 52218 RVA: 0x0011BC0C File Offset: 0x00119E0C
		public new static vtkFitImplicitFunction SafeDownCast(vtkObjectBase o)
		{
			vtkFitImplicitFunction vtkFitImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFitImplicitFunction.vtkFitImplicitFunction_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFitImplicitFunction = (vtkFitImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFitImplicitFunction.Register(null);
				}
			}
			return vtkFitImplicitFunction;
		}

		// Token: 0x0600CBFB RID: 52219
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFitImplicitFunction_SetImplicitFunction_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function defining a surface on which points
		/// are to be extracted.
		/// </summary>
		// Token: 0x0600CBFC RID: 52220 RVA: 0x0011BC8C File Offset: 0x00119E8C
		public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
		{
			vtkFitImplicitFunction.vtkFitImplicitFunction_SetImplicitFunction_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600CBFD RID: 52221
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFitImplicitFunction_SetThreshold_14(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a threshold value which defines a fuzzy extraction surface.
		/// Since in this filter the implicit surface is defined as f(x,y,z)=0;
		/// the extracted points are (-Threshold &lt;= f(x,y,z) &lt; Threshold).
		/// </summary>
		// Token: 0x0600CBFE RID: 52222 RVA: 0x0011BCBB File Offset: 0x00119EBB
		public virtual void SetThreshold(double _arg)
		{
			vtkFitImplicitFunction.vtkFitImplicitFunction_SetThreshold_14(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F15 RID: 3861
		public new const string MRFullTypeName = "Kitware.VTK.vtkFitImplicitFunction";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F16 RID: 3862
		public new static readonly string MRClassNameKey = "class vtkFitImplicitFunction";
	}
}
