using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTupleInterpolator
	/// </summary>
	/// <remarks>
	///    interpolate a tuple of arbitrary size
	///
	/// This class is used to interpolate a tuple which may have an arbitrary
	/// number of components (but at least one component). The interpolation may
	/// be linear in form, or via a subclasses of vtkSpline.
	///
	/// To use this class, begin by specifying the number of components of the
	/// tuple and the interpolation function to use. Then specify at least one
	/// pair of (t,tuple) with the AddTuple() method.  Next interpolate the
	/// tuples with the InterpolateTuple(t,tuple) method, where "t" must be in the
	/// range of (t_min,t_max) parameter values specified by the AddTuple() method
	/// (if not then t is clamped), and tuple[] is filled in by the method (make
	/// sure that tuple [] is long enough to hold the interpolated data).
	///
	/// You can control the type of interpolation to use. By default, the
	/// interpolation is based on a Kochanek spline. However, other types of
	/// splines can be specified. You can also set the interpolation method
	/// to linear, in which case the specified spline has no effect on the
	/// interpolation.
	///
	/// @warning
	/// Setting the number of components or changing the type of interpolation
	/// causes the list of tuples to be reset, so any data inserted up to that
	/// point is lost. Bisection methods are used to speed up the search for the
	/// interpolation interval.
	/// </remarks>
	// Token: 0x02000804 RID: 2052
	public class vtkTupleInterpolator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601513F RID: 86335 RVA: 0x001DD457 File Offset: 0x001DB657
		static vtkTupleInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTupleInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTupleInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015140 RID: 86336 RVA: 0x001DD47F File Offset: 0x001DB67F
		public vtkTupleInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015141 RID: 86337
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTupleInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06015142 RID: 86338 RVA: 0x001DD490 File Offset: 0x001DB690
		public new static vtkTupleInterpolator New()
		{
			vtkTupleInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTupleInterpolator.vtkTupleInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06015143 RID: 86339 RVA: 0x001DD4E4 File Offset: 0x001DB6E4
		public vtkTupleInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTupleInterpolator.vtkTupleInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015144 RID: 86340 RVA: 0x001DD528 File Offset: 0x001DB728
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015145 RID: 86341
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTupleInterpolator_AddTuple_01(HandleRef pThis, double t, IntPtr tuple);

		/// <summary>
		/// Add another tuple to the list of tuples to be interpolated.  Note that
		/// using the same time t value more than once replaces the previous tuple
		/// value at t.  At least two tuples must be added to define an
		/// interpolation function.
		/// </summary>
		// Token: 0x06015146 RID: 86342 RVA: 0x001DD533 File Offset: 0x001DB733
		public void AddTuple(double t, IntPtr tuple)
		{
			vtkTupleInterpolator.vtkTupleInterpolator_AddTuple_01(base.GetCppThis(), t, tuple);
		}

		// Token: 0x06015147 RID: 86343
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTupleInterpolator_GetInterpolatingSpline_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the InterpolationType is set to spline, then this method applies. By
		/// default Kochanek interpolation is used, but you can specify any instance
		/// of vtkSpline to use. Note that the actual interpolating splines are
		/// created by invoking NewInstance() followed by DeepCopy() on the
		/// interpolating spline specified here, for each tuple component to
		/// interpolate.
		/// </summary>
		// Token: 0x06015148 RID: 86344 RVA: 0x001DD544 File Offset: 0x001DB744
		public virtual vtkSpline GetInterpolatingSpline()
		{
			vtkSpline vtkSpline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTupleInterpolator.vtkTupleInterpolator_GetInterpolatingSpline_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpline = (vtkSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpline.Register(null);
				}
			}
			return vtkSpline;
		}

		// Token: 0x06015149 RID: 86345
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTupleInterpolator_GetInterpolationType_03(HandleRef pThis);

		/// <summary>
		/// Specify which type of function to use for interpolation. By default
		/// spline interpolation (SetInterpolationTypeToSpline()) is used
		/// (i.e., a Kochanek spline) and the InterpolatingSpline instance variable
		/// is used to birth the actual interpolation splines via a combination of
		/// NewInstance() and DeepCopy(). You may also choose to use linear
		/// interpolation by invoking SetInterpolationTypeToLinear(). Note that
		/// changing the type of interpolation causes previously inserted data
		/// to be discarded.
		/// </summary>
		// Token: 0x0601514A RID: 86346 RVA: 0x001DD5B4 File Offset: 0x001DB7B4
		public virtual int GetInterpolationType()
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_GetInterpolationType_03(base.GetCppThis());
		}

		// Token: 0x0601514B RID: 86347
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTupleInterpolator_GetMaximumT_04(HandleRef pThis);

		/// <summary>
		/// Obtain some information about the interpolation range. The numbers
		/// returned (corresponding to parameter t, usually thought of as time)
		/// are undefined if the list of transforms is empty. This is a convenience
		/// method for interpolation.
		/// </summary>
		// Token: 0x0601514C RID: 86348 RVA: 0x001DD5D4 File Offset: 0x001DB7D4
		public double GetMaximumT()
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_GetMaximumT_04(base.GetCppThis());
		}

		// Token: 0x0601514D RID: 86349
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTupleInterpolator_GetMinimumT_05(HandleRef pThis);

		/// <summary>
		/// Obtain some information about the interpolation range. The numbers
		/// returned (corresponding to parameter t, usually thought of as time)
		/// are undefined if the list of transforms is empty. This is a convenience
		/// method for interpolation.
		/// </summary>
		// Token: 0x0601514E RID: 86350 RVA: 0x001DD5F4 File Offset: 0x001DB7F4
		public double GetMinimumT()
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_GetMinimumT_05(base.GetCppThis());
		}

		// Token: 0x0601514F RID: 86351
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTupleInterpolator_GetNumberOfComponents_06(HandleRef pThis);

		/// <summary>
		/// Specify the number of tuple components to interpolate. Note that setting
		/// this value discards any previously inserted data.
		/// </summary>
		// Token: 0x06015150 RID: 86352 RVA: 0x001DD614 File Offset: 0x001DB814
		public virtual int GetNumberOfComponents()
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_GetNumberOfComponents_06(base.GetCppThis());
		}

		// Token: 0x06015151 RID: 86353
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTupleInterpolator_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015152 RID: 86354 RVA: 0x001DD634 File Offset: 0x001DB834
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06015153 RID: 86355
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTupleInterpolator_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015154 RID: 86356 RVA: 0x001DD654 File Offset: 0x001DB854
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06015155 RID: 86357
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTupleInterpolator_GetNumberOfTuples_09(HandleRef pThis);

		/// <summary>
		/// Return the number of tuples in the list of tuples to be
		/// interpolated.
		/// </summary>
		// Token: 0x06015156 RID: 86358 RVA: 0x001DD670 File Offset: 0x001DB870
		public int GetNumberOfTuples()
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_GetNumberOfTuples_09(base.GetCppThis());
		}

		// Token: 0x06015157 RID: 86359
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTupleInterpolator_Initialize_10(HandleRef pThis);

		/// <summary>
		/// Reset the class so that it contains no (t,tuple) information.
		/// </summary>
		// Token: 0x06015158 RID: 86360 RVA: 0x001DD68F File Offset: 0x001DB88F
		public void Initialize()
		{
			vtkTupleInterpolator.vtkTupleInterpolator_Initialize_10(base.GetCppThis());
		}

		// Token: 0x06015159 RID: 86361
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTupleInterpolator_InterpolateTuple_11(HandleRef pThis, double t, IntPtr tuple);

		/// <summary>
		/// Interpolate the list of tuples and determine a new tuple (i.e.,
		/// fill in the tuple provided). If t is outside the range of
		/// (min,max) values, then t is clamped. Note that each component
		/// of tuple[] is interpolated independently.
		/// </summary>
		// Token: 0x0601515A RID: 86362 RVA: 0x001DD69E File Offset: 0x001DB89E
		public void InterpolateTuple(double t, IntPtr tuple)
		{
			vtkTupleInterpolator.vtkTupleInterpolator_InterpolateTuple_11(base.GetCppThis(), t, tuple);
		}

		// Token: 0x0601515B RID: 86363
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTupleInterpolator_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601515C RID: 86364 RVA: 0x001DD6B0 File Offset: 0x001DB8B0
		public override int IsA(string type)
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601515D RID: 86365
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTupleInterpolator_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601515E RID: 86366 RVA: 0x001DD6D0 File Offset: 0x001DB8D0
		public new static int IsTypeOf(string type)
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_IsTypeOf_13(type);
		}

		// Token: 0x0601515F RID: 86367
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTupleInterpolator_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015160 RID: 86368 RVA: 0x001DD6EC File Offset: 0x001DB8EC
		public new vtkTupleInterpolator NewInstance()
		{
			vtkTupleInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTupleInterpolator.vtkTupleInterpolator_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015161 RID: 86369
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTupleInterpolator_RemoveTuple_16(HandleRef pThis, double t);

		/// <summary>
		/// Delete the tuple at a particular parameter t. If there is no
		/// tuple defined at t, then the method does nothing.
		/// </summary>
		// Token: 0x06015162 RID: 86370 RVA: 0x001DD746 File Offset: 0x001DB946
		public void RemoveTuple(double t)
		{
			vtkTupleInterpolator.vtkTupleInterpolator_RemoveTuple_16(base.GetCppThis(), t);
		}

		// Token: 0x06015163 RID: 86371
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTupleInterpolator_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015164 RID: 86372 RVA: 0x001DD758 File Offset: 0x001DB958
		public new static vtkTupleInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTupleInterpolator.vtkTupleInterpolator_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTupleInterpolator = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTupleInterpolator.Register(null);
				}
			}
			return vtkTupleInterpolator;
		}

		// Token: 0x06015165 RID: 86373
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTupleInterpolator_SetInterpolatingSpline_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// If the InterpolationType is set to spline, then this method applies. By
		/// default Kochanek interpolation is used, but you can specify any instance
		/// of vtkSpline to use. Note that the actual interpolating splines are
		/// created by invoking NewInstance() followed by DeepCopy() on the
		/// interpolating spline specified here, for each tuple component to
		/// interpolate.
		/// </summary>
		// Token: 0x06015166 RID: 86374 RVA: 0x001DD7D8 File Offset: 0x001DB9D8
		public void SetInterpolatingSpline(vtkSpline arg0)
		{
			vtkTupleInterpolator.vtkTupleInterpolator_SetInterpolatingSpline_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06015167 RID: 86375
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTupleInterpolator_SetInterpolationType_19(HandleRef pThis, int type);

		/// <summary>
		/// Specify which type of function to use for interpolation. By default
		/// spline interpolation (SetInterpolationTypeToSpline()) is used
		/// (i.e., a Kochanek spline) and the InterpolatingSpline instance variable
		/// is used to birth the actual interpolation splines via a combination of
		/// NewInstance() and DeepCopy(). You may also choose to use linear
		/// interpolation by invoking SetInterpolationTypeToLinear(). Note that
		/// changing the type of interpolation causes previously inserted data
		/// to be discarded.
		/// </summary>
		// Token: 0x06015168 RID: 86376 RVA: 0x001DD807 File Offset: 0x001DBA07
		public void SetInterpolationType(int type)
		{
			vtkTupleInterpolator.vtkTupleInterpolator_SetInterpolationType_19(base.GetCppThis(), type);
		}

		// Token: 0x06015169 RID: 86377
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTupleInterpolator_SetInterpolationTypeToLinear_20(HandleRef pThis);

		/// <summary>
		/// Specify which type of function to use for interpolation. By default
		/// spline interpolation (SetInterpolationTypeToSpline()) is used
		/// (i.e., a Kochanek spline) and the InterpolatingSpline instance variable
		/// is used to birth the actual interpolation splines via a combination of
		/// NewInstance() and DeepCopy(). You may also choose to use linear
		/// interpolation by invoking SetInterpolationTypeToLinear(). Note that
		/// changing the type of interpolation causes previously inserted data
		/// to be discarded.
		/// </summary>
		// Token: 0x0601516A RID: 86378 RVA: 0x001DD817 File Offset: 0x001DBA17
		public void SetInterpolationTypeToLinear()
		{
			vtkTupleInterpolator.vtkTupleInterpolator_SetInterpolationTypeToLinear_20(base.GetCppThis());
		}

		// Token: 0x0601516B RID: 86379
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTupleInterpolator_SetInterpolationTypeToSpline_21(HandleRef pThis);

		/// <summary>
		/// Specify which type of function to use for interpolation. By default
		/// spline interpolation (SetInterpolationTypeToSpline()) is used
		/// (i.e., a Kochanek spline) and the InterpolatingSpline instance variable
		/// is used to birth the actual interpolation splines via a combination of
		/// NewInstance() and DeepCopy(). You may also choose to use linear
		/// interpolation by invoking SetInterpolationTypeToLinear(). Note that
		/// changing the type of interpolation causes previously inserted data
		/// to be discarded.
		/// </summary>
		// Token: 0x0601516C RID: 86380 RVA: 0x001DD826 File Offset: 0x001DBA26
		public void SetInterpolationTypeToSpline()
		{
			vtkTupleInterpolator.vtkTupleInterpolator_SetInterpolationTypeToSpline_21(base.GetCppThis());
		}

		// Token: 0x0601516D RID: 86381
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTupleInterpolator_SetNumberOfComponents_22(HandleRef pThis, int numComp);

		/// <summary>
		/// Specify the number of tuple components to interpolate. Note that setting
		/// this value discards any previously inserted data.
		/// </summary>
		// Token: 0x0601516E RID: 86382 RVA: 0x001DD835 File Offset: 0x001DBA35
		public void SetNumberOfComponents(int numComp)
		{
			vtkTupleInterpolator.vtkTupleInterpolator_SetNumberOfComponents_22(base.GetCppThis(), numComp);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400184E RID: 6222
		public new const string MRFullTypeName = "Kitware.VTK.vtkTupleInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400184F RID: 6223
		public new static readonly string MRClassNameKey = "class vtkTupleInterpolator";

		/// <summary>
		/// Enums to control the type of interpolation to use.
		/// </summary>
		// Token: 0x02000805 RID: 2053
		public enum INTERPOLATION_TYPE_LINEAR_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001851 RID: 6225
			INTERPOLATION_TYPE_LINEAR,
			/// <summary>enum member</summary>
			// Token: 0x04001852 RID: 6226
			INTERPOLATION_TYPE_SPLINE
		}
	}
}
