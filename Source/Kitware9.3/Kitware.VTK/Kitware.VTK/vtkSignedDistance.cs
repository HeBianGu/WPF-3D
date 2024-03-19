using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSignedDistance
	/// </summary>
	/// <remarks>
	///    compute signed distances from an input point cloud
	///
	/// vtkSignedDistance is a filter that computes signed distances over a volume
	/// from an input point cloud. The input point cloud must have point normals
	/// defined, as well as an optional weighting function (e.g., probabilities
	/// that the point measurements are accurate). Once the signed distance
	/// function is computed, then the output volume may be isocontoured to with
	/// vtkExtractSurface to extract a approximating surface to the point cloud.
	///
	/// To use this filter, specify the input vtkPolyData (which represents the
	/// point cloud); define the sampling volume; specify a radius (which limits
	/// the radius of influence of each point); and set an optional point locator
	/// (to accelerate proximity operations, a vtkStaticPointLocator is used by
	/// default). Note that large radius values may have significant impact on
	/// performance. The volume is defined by specifying dimensions in the x-y-z
	/// directions, as well as a domain bounds. By default the model bounds are
	/// defined from the input points, but the user can also manually specify
	/// them.
	///
	/// This filter has one other unusual capability: it is possible to append
	/// data in a sequence of operations to generate a single output. This is
	/// useful when you have multiple point clouds (e.g., possibly from multiple
	/// acquisition scans) and want to incrementally accumulate all the data.
	/// However, the user must be careful to either specify the Bounds or
	/// order the input such that the bounds of the first input completely
	/// contains all other input data.  This is because the geometry and topology
	/// of the output sampling volume cannot be changed after the initial Append
	/// operation.
	///
	/// This algorithm loosely follows the most excellent paper by Curless and
	/// Levoy: "A Volumetric Method for Building Complex Models from Range
	/// Images." As described in this paper it may produce a signed distance
	/// volume that may contain the three data states for each voxel: near
	/// surface, empty, or unseen (see vtkExtractSurface for additional
	/// information). Note in this implementation the initial values of the volume
	/// are set to &lt; this-&gt;Radius. This indicates that these voxels are
	/// "empty". Of course voxels with value -this-&gt;Radius &lt;= d &lt;= this-&gt;Radius
	/// are "near" the surface. (Voxels with values &gt; this-&gt;Radius are "unseen" --
	/// this filter does not produce such values.)
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// @warning
	/// Empty voxel values are set to -this-&gt;Radius.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExtractSurface vtkImplicitModeller
	/// </seealso>
	// Token: 0x02000463 RID: 1123
	public class vtkSignedDistance : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D088 RID: 53384 RVA: 0x0012209B File Offset: 0x0012029B
		static vtkSignedDistance()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSignedDistance.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSignedDistance"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D089 RID: 53385 RVA: 0x001220C3 File Offset: 0x001202C3
		public vtkSignedDistance(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D08A RID: 53386
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSignedDistance_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D08B RID: 53387 RVA: 0x001220D4 File Offset: 0x001202D4
		public new static vtkSignedDistance New()
		{
			vtkSignedDistance result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSignedDistance.vtkSignedDistance_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSignedDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D08C RID: 53388 RVA: 0x00122128 File Offset: 0x00120328
		public vtkSignedDistance() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSignedDistance.vtkSignedDistance_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D08D RID: 53389 RVA: 0x0012216C File Offset: 0x0012036C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D08E RID: 53390
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSignedDistance_Append_01(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Append a data set to the existing output. To use this function,
		/// you'll have to invoke the StartAppend() method before doing
		/// successive appends. It's also a good idea to specify the model
		/// bounds; otherwise the input model bounds is used. When you've
		/// finished appending, use the EndAppend() method.
		/// </summary>
		// Token: 0x0600D08F RID: 53391 RVA: 0x00122178 File Offset: 0x00120378
		public void Append(vtkPolyData input)
		{
			vtkSignedDistance.vtkSignedDistance_Append_01(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0600D090 RID: 53392
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSignedDistance_EndAppend_02(HandleRef pThis);

		/// <summary>
		/// Method completes the append process.
		/// </summary>
		// Token: 0x0600D091 RID: 53393 RVA: 0x001221A7 File Offset: 0x001203A7
		public void EndAppend()
		{
			vtkSignedDistance.vtkSignedDistance_EndAppend_02(base.GetCppThis());
		}

		// Token: 0x0600D092 RID: 53394
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSignedDistance_GetBounds_03(HandleRef pThis);

		/// <summary>
		/// Set / get the region in space in which to perform the sampling. If
		/// not specified, it will be computed automatically.
		/// </summary>
		// Token: 0x0600D093 RID: 53395 RVA: 0x001221B8 File Offset: 0x001203B8
		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkSignedDistance.vtkSignedDistance_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D094 RID: 53396
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSignedDistance_GetBounds_04(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the region in space in which to perform the sampling. If
		/// not specified, it will be computed automatically.
		/// </summary>
		// Token: 0x0600D095 RID: 53397 RVA: 0x00122200 File Offset: 0x00120400
		public virtual void GetBounds(IntPtr data)
		{
			vtkSignedDistance.vtkSignedDistance_GetBounds_04(base.GetCppThis(), data);
		}

		// Token: 0x0600D096 RID: 53398
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSignedDistance_GetDimensions_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the i-j-k dimensions on which to computer the distance function.
		/// </summary>
		// Token: 0x0600D097 RID: 53399 RVA: 0x00122210 File Offset: 0x00120410
		public virtual int[] GetDimensions()
		{
			IntPtr intPtr = vtkSignedDistance.vtkSignedDistance_GetDimensions_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D098 RID: 53400
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSignedDistance_GetDimensions_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the i-j-k dimensions on which to computer the distance function.
		/// </summary>
		// Token: 0x0600D099 RID: 53401 RVA: 0x00122258 File Offset: 0x00120458
		public virtual void GetDimensions(IntPtr data)
		{
			vtkSignedDistance.vtkSignedDistance_GetDimensions_06(base.GetCppThis(), data);
		}

		// Token: 0x0600D09A RID: 53402
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSignedDistance_GetLocator_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate points
		/// surrounding a voxel (within the specified radius).
		/// </summary>
		// Token: 0x0600D09B RID: 53403 RVA: 0x00122268 File Offset: 0x00120468
		public virtual vtkAbstractPointLocator GetLocator()
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSignedDistance.vtkSignedDistance_GetLocator_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPointLocator = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPointLocator.Register(null);
				}
			}
			return vtkAbstractPointLocator;
		}

		// Token: 0x0600D09C RID: 53404
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSignedDistance_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D09D RID: 53405 RVA: 0x001222D8 File Offset: 0x001204D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSignedDistance.vtkSignedDistance_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600D09E RID: 53406
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSignedDistance_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D09F RID: 53407 RVA: 0x001222F8 File Offset: 0x001204F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSignedDistance.vtkSignedDistance_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600D0A0 RID: 53408
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSignedDistance_GetRadius_10(HandleRef pThis);

		/// <summary>
		/// Set / get the radius of influence of each point. Smaller values
		/// generally improve performance markedly. Note that after the signed
		/// distance function is computed, any voxel taking on the value &gt;= Radius
		/// is presumed to be "unseen" or uninitialized.
		/// </summary>
		// Token: 0x0600D0A1 RID: 53409 RVA: 0x00122314 File Offset: 0x00120514
		public virtual double GetRadius()
		{
			return vtkSignedDistance.vtkSignedDistance_GetRadius_10(base.GetCppThis());
		}

		// Token: 0x0600D0A2 RID: 53410
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSignedDistance_GetRadiusMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set / get the radius of influence of each point. Smaller values
		/// generally improve performance markedly. Note that after the signed
		/// distance function is computed, any voxel taking on the value &gt;= Radius
		/// is presumed to be "unseen" or uninitialized.
		/// </summary>
		// Token: 0x0600D0A3 RID: 53411 RVA: 0x00122334 File Offset: 0x00120534
		public virtual double GetRadiusMaxValue()
		{
			return vtkSignedDistance.vtkSignedDistance_GetRadiusMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600D0A4 RID: 53412
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSignedDistance_GetRadiusMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set / get the radius of influence of each point. Smaller values
		/// generally improve performance markedly. Note that after the signed
		/// distance function is computed, any voxel taking on the value &gt;= Radius
		/// is presumed to be "unseen" or uninitialized.
		/// </summary>
		// Token: 0x0600D0A5 RID: 53413 RVA: 0x00122354 File Offset: 0x00120554
		public virtual double GetRadiusMinValue()
		{
			return vtkSignedDistance.vtkSignedDistance_GetRadiusMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600D0A6 RID: 53414
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSignedDistance_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D0A7 RID: 53415 RVA: 0x00122374 File Offset: 0x00120574
		public override int IsA(string type)
		{
			return vtkSignedDistance.vtkSignedDistance_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0600D0A8 RID: 53416
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSignedDistance_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D0A9 RID: 53417 RVA: 0x00122394 File Offset: 0x00120594
		public new static int IsTypeOf(string type)
		{
			return vtkSignedDistance.vtkSignedDistance_IsTypeOf_14(type);
		}

		// Token: 0x0600D0AA RID: 53418
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSignedDistance_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D0AB RID: 53419 RVA: 0x001223B0 File Offset: 0x001205B0
		public new vtkSignedDistance NewInstance()
		{
			vtkSignedDistance result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSignedDistance.vtkSignedDistance_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSignedDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D0AC RID: 53420
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSignedDistance_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D0AD RID: 53421 RVA: 0x0012240C File Offset: 0x0012060C
		public new static vtkSignedDistance SafeDownCast(vtkObjectBase o)
		{
			vtkSignedDistance vtkSignedDistance = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSignedDistance.vtkSignedDistance_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSignedDistance = (vtkSignedDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSignedDistance.Register(null);
				}
			}
			return vtkSignedDistance;
		}

		// Token: 0x0600D0AE RID: 53422
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSignedDistance_SetBounds_18(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set / get the region in space in which to perform the sampling. If
		/// not specified, it will be computed automatically.
		/// </summary>
		// Token: 0x0600D0AF RID: 53423 RVA: 0x0012248B File Offset: 0x0012068B
		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkSignedDistance.vtkSignedDistance_SetBounds_18(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600D0B0 RID: 53424
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSignedDistance_SetBounds_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / get the region in space in which to perform the sampling. If
		/// not specified, it will be computed automatically.
		/// </summary>
		// Token: 0x0600D0B1 RID: 53425 RVA: 0x001224A3 File Offset: 0x001206A3
		public virtual void SetBounds(IntPtr _arg)
		{
			vtkSignedDistance.vtkSignedDistance_SetBounds_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D0B2 RID: 53426
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSignedDistance_SetDimensions_20(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Set/Get the i-j-k dimensions on which to computer the distance function.
		/// </summary>
		// Token: 0x0600D0B3 RID: 53427 RVA: 0x001224B3 File Offset: 0x001206B3
		public void SetDimensions(int i, int j, int k)
		{
			vtkSignedDistance.vtkSignedDistance_SetDimensions_20(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0600D0B4 RID: 53428
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSignedDistance_SetDimensions_21(HandleRef pThis, IntPtr dim);

		/// <summary>
		/// Set/Get the i-j-k dimensions on which to computer the distance function.
		/// </summary>
		// Token: 0x0600D0B5 RID: 53429 RVA: 0x001224C5 File Offset: 0x001206C5
		public void SetDimensions(IntPtr dim)
		{
			vtkSignedDistance.vtkSignedDistance_SetDimensions_21(base.GetCppThis(), dim);
		}

		// Token: 0x0600D0B6 RID: 53430
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSignedDistance_SetLocator_22(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate points
		/// surrounding a voxel (within the specified radius).
		/// </summary>
		// Token: 0x0600D0B7 RID: 53431 RVA: 0x001224D8 File Offset: 0x001206D8
		public void SetLocator(vtkAbstractPointLocator locator)
		{
			vtkSignedDistance.vtkSignedDistance_SetLocator_22(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600D0B8 RID: 53432
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSignedDistance_SetRadius_23(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the radius of influence of each point. Smaller values
		/// generally improve performance markedly. Note that after the signed
		/// distance function is computed, any voxel taking on the value &gt;= Radius
		/// is presumed to be "unseen" or uninitialized.
		/// </summary>
		// Token: 0x0600D0B9 RID: 53433 RVA: 0x00122507 File Offset: 0x00120707
		public virtual void SetRadius(double _arg)
		{
			vtkSignedDistance.vtkSignedDistance_SetRadius_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D0BA RID: 53434
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSignedDistance_StartAppend_24(HandleRef pThis);

		/// <summary>
		/// Initialize the filter for appending data. You must invoke the
		/// StartAppend() method before doing successive Appends(). It's also a
		/// good idea to manually specify the model bounds; otherwise the input
		/// bounds for the data will be used.
		/// </summary>
		// Token: 0x0600D0BB RID: 53435 RVA: 0x00122517 File Offset: 0x00120717
		public void StartAppend()
		{
			vtkSignedDistance.vtkSignedDistance_StartAppend_24(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F65 RID: 3941
		public new const string MRFullTypeName = "Kitware.VTK.vtkSignedDistance";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F66 RID: 3942
		public new static readonly string MRClassNameKey = "class vtkSignedDistance";
	}
}
