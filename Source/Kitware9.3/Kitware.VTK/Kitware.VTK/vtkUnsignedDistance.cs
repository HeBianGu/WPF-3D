using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnsignedDistance
	/// </summary>
	/// <remarks>
	///    compute unsigned (i.e., non-negative) distances from an input point cloud
	///
	/// vtkUnsignedDistance is a filter that computes non-negative (i.e., unsigned)
	/// distances over a volume from an input point cloud. This filter is distinct
	/// from vtkSignedDistance in that it does not require point normals. However,
	/// isocontouring a zero-valued distance function (e.g., trying to fit a
	/// surface will produce unsatisfactory results). Rather this filter, when
	/// combined with an isocontouring filter such as vtkFlyingEdges3D, can
	/// produce an offset, bounding surface surrounding the input point cloud.
	///
	/// To use this filter, specify the input vtkPolyData (which represents the
	/// point cloud); define the sampling volume; specify a radius (which limits
	/// the radius of influence of each point); and set an optional point locator
	/// (to accelerate proximity operations, a vtkStaticPointLocator is used by
	/// default). Note that large radius values may have significant impact on
	/// performance. The volume is defined by specifying dimensions in the x-y-z
	/// directions, as well as a domain bounds. By default the model bounds are
	/// defined from the input points, but the user can also manually specify
	/// them. Finally, because the radius data member limits the influence of the
	/// distance calculation, some voxels may receive no contribution. These voxel
	/// values are set to the CapValue.
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
	/// @warning
	/// Note that multiple, non-connected surfaces may be produced. For example,
	/// if the point cloud is from the surface of the sphere, it is possible to
	/// generate two surfaces (with isocontouring): one inside the sphere, one
	/// outside the sphere. It is sometimes possible to select the surface you
	/// want from the output of the contouring filter by using
	/// vtkPolyDataConnectivityFilter.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSignedDistance vtkExtractSurface vtkImplicitModeller
	/// </seealso>
	// Token: 0x02000465 RID: 1125
	public class vtkUnsignedDistance : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D0F2 RID: 53490 RVA: 0x001229B3 File Offset: 0x00120BB3
		static vtkUnsignedDistance()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnsignedDistance.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnsignedDistance"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D0F3 RID: 53491 RVA: 0x001229DB File Offset: 0x00120BDB
		public vtkUnsignedDistance(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D0F4 RID: 53492
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedDistance_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D0F5 RID: 53493 RVA: 0x001229EC File Offset: 0x00120BEC
		public new static vtkUnsignedDistance New()
		{
			vtkUnsignedDistance result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedDistance.vtkUnsignedDistance_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D0F6 RID: 53494 RVA: 0x00122A40 File Offset: 0x00120C40
		public vtkUnsignedDistance() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnsignedDistance.vtkUnsignedDistance_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D0F7 RID: 53495 RVA: 0x00122A84 File Offset: 0x00120C84
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D0F8 RID: 53496
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_AdjustBoundsOff_01(HandleRef pThis);

		/// <summary>
		/// Control how the model bounds are computed. If the ivar AdjustBounds
		/// is set, then the bounds specified (or computed automatically) is modified
		/// by the fraction given by AdjustDistance. This means that the model
		/// bounds is expanded in each of the x-y-z directions.
		/// </summary>
		// Token: 0x0600D0F9 RID: 53497 RVA: 0x00122A8F File Offset: 0x00120C8F
		public virtual void AdjustBoundsOff()
		{
			vtkUnsignedDistance.vtkUnsignedDistance_AdjustBoundsOff_01(base.GetCppThis());
		}

		// Token: 0x0600D0FA RID: 53498
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_AdjustBoundsOn_02(HandleRef pThis);

		/// <summary>
		/// Control how the model bounds are computed. If the ivar AdjustBounds
		/// is set, then the bounds specified (or computed automatically) is modified
		/// by the fraction given by AdjustDistance. This means that the model
		/// bounds is expanded in each of the x-y-z directions.
		/// </summary>
		// Token: 0x0600D0FB RID: 53499 RVA: 0x00122A9E File Offset: 0x00120C9E
		public virtual void AdjustBoundsOn()
		{
			vtkUnsignedDistance.vtkUnsignedDistance_AdjustBoundsOn_02(base.GetCppThis());
		}

		// Token: 0x0600D0FC RID: 53500
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_Append_03(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Append a data set to the existing output. To use this function,
		/// you'll have to invoke the StartAppend() method before doing
		/// successive appends. It's also a good idea to specify the model
		/// bounds; otherwise the input model bounds is used. When you've
		/// finished appending, use the EndAppend() method.
		/// </summary>
		// Token: 0x0600D0FD RID: 53501 RVA: 0x00122AB0 File Offset: 0x00120CB0
		public void Append(vtkPolyData input)
		{
			vtkUnsignedDistance.vtkUnsignedDistance_Append_03(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0600D0FE RID: 53502
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_CappingOff_04(HandleRef pThis);

		/// <summary>
		/// The outer boundary of the volume can be assigned a particular value
		/// after distances are computed. This can be used to close or "cap" all
		/// surfaces during isocontouring.
		/// </summary>
		// Token: 0x0600D0FF RID: 53503 RVA: 0x00122ADF File Offset: 0x00120CDF
		public virtual void CappingOff()
		{
			vtkUnsignedDistance.vtkUnsignedDistance_CappingOff_04(base.GetCppThis());
		}

		// Token: 0x0600D100 RID: 53504
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_CappingOn_05(HandleRef pThis);

		/// <summary>
		/// The outer boundary of the volume can be assigned a particular value
		/// after distances are computed. This can be used to close or "cap" all
		/// surfaces during isocontouring.
		/// </summary>
		// Token: 0x0600D101 RID: 53505 RVA: 0x00122AEE File Offset: 0x00120CEE
		public virtual void CappingOn()
		{
			vtkUnsignedDistance.vtkUnsignedDistance_CappingOn_05(base.GetCppThis());
		}

		// Token: 0x0600D102 RID: 53506
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_EndAppend_06(HandleRef pThis);

		/// <summary>
		/// Method completes the append process.
		/// </summary>
		// Token: 0x0600D103 RID: 53507 RVA: 0x00122AFD File Offset: 0x00120CFD
		public void EndAppend()
		{
			vtkUnsignedDistance.vtkUnsignedDistance_EndAppend_06(base.GetCppThis());
		}

		// Token: 0x0600D104 RID: 53508
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnsignedDistance_GetAdjustBounds_07(HandleRef pThis);

		/// <summary>
		/// Control how the model bounds are computed. If the ivar AdjustBounds
		/// is set, then the bounds specified (or computed automatically) is modified
		/// by the fraction given by AdjustDistance. This means that the model
		/// bounds is expanded in each of the x-y-z directions.
		/// </summary>
		// Token: 0x0600D105 RID: 53509 RVA: 0x00122B0C File Offset: 0x00120D0C
		public virtual int GetAdjustBounds()
		{
			return vtkUnsignedDistance.vtkUnsignedDistance_GetAdjustBounds_07(base.GetCppThis());
		}

		// Token: 0x0600D106 RID: 53510
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkUnsignedDistance_GetAdjustDistance_08(HandleRef pThis);

		/// <summary>
		/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
		/// is set). The value is a fraction of the maximum length of the sides
		/// of the box specified by the model bounds.
		/// </summary>
		// Token: 0x0600D107 RID: 53511 RVA: 0x00122B2C File Offset: 0x00120D2C
		public virtual double GetAdjustDistance()
		{
			return vtkUnsignedDistance.vtkUnsignedDistance_GetAdjustDistance_08(base.GetCppThis());
		}

		// Token: 0x0600D108 RID: 53512
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkUnsignedDistance_GetAdjustDistanceMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
		/// is set). The value is a fraction of the maximum length of the sides
		/// of the box specified by the model bounds.
		/// </summary>
		// Token: 0x0600D109 RID: 53513 RVA: 0x00122B4C File Offset: 0x00120D4C
		public virtual double GetAdjustDistanceMaxValue()
		{
			return vtkUnsignedDistance.vtkUnsignedDistance_GetAdjustDistanceMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0600D10A RID: 53514
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkUnsignedDistance_GetAdjustDistanceMinValue_10(HandleRef pThis);

		/// <summary>
		/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
		/// is set). The value is a fraction of the maximum length of the sides
		/// of the box specified by the model bounds.
		/// </summary>
		// Token: 0x0600D10B RID: 53515 RVA: 0x00122B6C File Offset: 0x00120D6C
		public virtual double GetAdjustDistanceMinValue()
		{
			return vtkUnsignedDistance.vtkUnsignedDistance_GetAdjustDistanceMinValue_10(base.GetCppThis());
		}

		// Token: 0x0600D10C RID: 53516
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedDistance_GetBounds_11(HandleRef pThis);

		/// <summary>
		/// Set / get the region in space in which to perform the sampling. If
		/// not specified, it will be computed automatically.
		/// </summary>
		// Token: 0x0600D10D RID: 53517 RVA: 0x00122B8C File Offset: 0x00120D8C
		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkUnsignedDistance.vtkUnsignedDistance_GetBounds_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D10E RID: 53518
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_GetBounds_12(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the region in space in which to perform the sampling. If
		/// not specified, it will be computed automatically.
		/// </summary>
		// Token: 0x0600D10F RID: 53519 RVA: 0x00122BD4 File Offset: 0x00120DD4
		public virtual void GetBounds(IntPtr data)
		{
			vtkUnsignedDistance.vtkUnsignedDistance_GetBounds_12(base.GetCppThis(), data);
		}

		// Token: 0x0600D110 RID: 53520
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkUnsignedDistance_GetCapValue_13(HandleRef pThis);

		/// <summary>
		/// Specify the capping value to use. The CapValue is also used as an
		/// initial distance value at each point in the dataset. By default, the
		/// CapValue is VTK_FLOAT_MAX;
		/// </summary>
		// Token: 0x0600D111 RID: 53521 RVA: 0x00122BE4 File Offset: 0x00120DE4
		public virtual double GetCapValue()
		{
			return vtkUnsignedDistance.vtkUnsignedDistance_GetCapValue_13(base.GetCppThis());
		}

		// Token: 0x0600D112 RID: 53522
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnsignedDistance_GetCapping_14(HandleRef pThis);

		/// <summary>
		/// The outer boundary of the volume can be assigned a particular value
		/// after distances are computed. This can be used to close or "cap" all
		/// surfaces during isocontouring.
		/// </summary>
		// Token: 0x0600D113 RID: 53523 RVA: 0x00122C04 File Offset: 0x00120E04
		public virtual int GetCapping()
		{
			return vtkUnsignedDistance.vtkUnsignedDistance_GetCapping_14(base.GetCppThis());
		}

		// Token: 0x0600D114 RID: 53524
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedDistance_GetDimensions_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the i-j-k dimensions on which to computer the distance function.
		/// </summary>
		// Token: 0x0600D115 RID: 53525 RVA: 0x00122C24 File Offset: 0x00120E24
		public virtual int[] GetDimensions()
		{
			IntPtr intPtr = vtkUnsignedDistance.vtkUnsignedDistance_GetDimensions_15(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D116 RID: 53526
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_GetDimensions_16(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the i-j-k dimensions on which to computer the distance function.
		/// </summary>
		// Token: 0x0600D117 RID: 53527 RVA: 0x00122C6C File Offset: 0x00120E6C
		public virtual void GetDimensions(IntPtr data)
		{
			vtkUnsignedDistance.vtkUnsignedDistance_GetDimensions_16(base.GetCppThis(), data);
		}

		// Token: 0x0600D118 RID: 53528
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedDistance_GetLocator_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate points
		/// surrounding a voxel (within the specified radius).
		/// </summary>
		// Token: 0x0600D119 RID: 53529 RVA: 0x00122C7C File Offset: 0x00120E7C
		public virtual vtkAbstractPointLocator GetLocator()
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedDistance.vtkUnsignedDistance_GetLocator_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600D11A RID: 53530
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnsignedDistance_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D11B RID: 53531 RVA: 0x00122CEC File Offset: 0x00120EEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnsignedDistance.vtkUnsignedDistance_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x0600D11C RID: 53532
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnsignedDistance_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D11D RID: 53533 RVA: 0x00122D0C File Offset: 0x00120F0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnsignedDistance.vtkUnsignedDistance_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x0600D11E RID: 53534
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnsignedDistance_GetOutputScalarType_20(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type. Currently only real types are
		/// supported. By default, VTK_FLOAT scalars are created.
		/// </summary>
		// Token: 0x0600D11F RID: 53535 RVA: 0x00122D28 File Offset: 0x00120F28
		public virtual int GetOutputScalarType()
		{
			return vtkUnsignedDistance.vtkUnsignedDistance_GetOutputScalarType_20(base.GetCppThis());
		}

		// Token: 0x0600D120 RID: 53536
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkUnsignedDistance_GetRadius_21(HandleRef pThis);

		/// <summary>
		/// Set / get the radius of influence of each point. Smaller values
		/// generally improve performance markedly.
		/// </summary>
		// Token: 0x0600D121 RID: 53537 RVA: 0x00122D48 File Offset: 0x00120F48
		public virtual double GetRadius()
		{
			return vtkUnsignedDistance.vtkUnsignedDistance_GetRadius_21(base.GetCppThis());
		}

		// Token: 0x0600D122 RID: 53538
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkUnsignedDistance_GetRadiusMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Set / get the radius of influence of each point. Smaller values
		/// generally improve performance markedly.
		/// </summary>
		// Token: 0x0600D123 RID: 53539 RVA: 0x00122D68 File Offset: 0x00120F68
		public virtual double GetRadiusMaxValue()
		{
			return vtkUnsignedDistance.vtkUnsignedDistance_GetRadiusMaxValue_22(base.GetCppThis());
		}

		// Token: 0x0600D124 RID: 53540
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkUnsignedDistance_GetRadiusMinValue_23(HandleRef pThis);

		/// <summary>
		/// Set / get the radius of influence of each point. Smaller values
		/// generally improve performance markedly.
		/// </summary>
		// Token: 0x0600D125 RID: 53541 RVA: 0x00122D88 File Offset: 0x00120F88
		public virtual double GetRadiusMinValue()
		{
			return vtkUnsignedDistance.vtkUnsignedDistance_GetRadiusMinValue_23(base.GetCppThis());
		}

		// Token: 0x0600D126 RID: 53542
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnsignedDistance_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D127 RID: 53543 RVA: 0x00122DA8 File Offset: 0x00120FA8
		public override int IsA(string type)
		{
			return vtkUnsignedDistance.vtkUnsignedDistance_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0600D128 RID: 53544
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnsignedDistance_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D129 RID: 53545 RVA: 0x00122DC8 File Offset: 0x00120FC8
		public new static int IsTypeOf(string type)
		{
			return vtkUnsignedDistance.vtkUnsignedDistance_IsTypeOf_25(type);
		}

		// Token: 0x0600D12A RID: 53546
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedDistance_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D12B RID: 53547 RVA: 0x00122DE4 File Offset: 0x00120FE4
		public new vtkUnsignedDistance NewInstance()
		{
			vtkUnsignedDistance result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedDistance.vtkUnsignedDistance_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D12C RID: 53548
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedDistance_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600D12D RID: 53549 RVA: 0x00122E40 File Offset: 0x00121040
		public new static vtkUnsignedDistance SafeDownCast(vtkObjectBase o)
		{
			vtkUnsignedDistance vtkUnsignedDistance = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedDistance.vtkUnsignedDistance_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedDistance = (vtkUnsignedDistance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedDistance.Register(null);
				}
			}
			return vtkUnsignedDistance;
		}

		// Token: 0x0600D12E RID: 53550
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_SetAdjustBounds_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how the model bounds are computed. If the ivar AdjustBounds
		/// is set, then the bounds specified (or computed automatically) is modified
		/// by the fraction given by AdjustDistance. This means that the model
		/// bounds is expanded in each of the x-y-z directions.
		/// </summary>
		// Token: 0x0600D12F RID: 53551 RVA: 0x00122EBF File Offset: 0x001210BF
		public virtual void SetAdjustBounds(int _arg)
		{
			vtkUnsignedDistance.vtkUnsignedDistance_SetAdjustBounds_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D130 RID: 53552
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_SetAdjustDistance_30(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
		/// is set). The value is a fraction of the maximum length of the sides
		/// of the box specified by the model bounds.
		/// </summary>
		// Token: 0x0600D131 RID: 53553 RVA: 0x00122ECF File Offset: 0x001210CF
		public virtual void SetAdjustDistance(double _arg)
		{
			vtkUnsignedDistance.vtkUnsignedDistance_SetAdjustDistance_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D132 RID: 53554
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_SetBounds_31(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set / get the region in space in which to perform the sampling. If
		/// not specified, it will be computed automatically.
		/// </summary>
		// Token: 0x0600D133 RID: 53555 RVA: 0x00122EDF File Offset: 0x001210DF
		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkUnsignedDistance.vtkUnsignedDistance_SetBounds_31(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600D134 RID: 53556
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_SetBounds_32(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / get the region in space in which to perform the sampling. If
		/// not specified, it will be computed automatically.
		/// </summary>
		// Token: 0x0600D135 RID: 53557 RVA: 0x00122EF7 File Offset: 0x001210F7
		public virtual void SetBounds(IntPtr _arg)
		{
			vtkUnsignedDistance.vtkUnsignedDistance_SetBounds_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D136 RID: 53558
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_SetCapValue_33(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the capping value to use. The CapValue is also used as an
		/// initial distance value at each point in the dataset. By default, the
		/// CapValue is VTK_FLOAT_MAX;
		/// </summary>
		// Token: 0x0600D137 RID: 53559 RVA: 0x00122F07 File Offset: 0x00121107
		public virtual void SetCapValue(double _arg)
		{
			vtkUnsignedDistance.vtkUnsignedDistance_SetCapValue_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D138 RID: 53560
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_SetCapping_34(HandleRef pThis, int _arg);

		/// <summary>
		/// The outer boundary of the volume can be assigned a particular value
		/// after distances are computed. This can be used to close or "cap" all
		/// surfaces during isocontouring.
		/// </summary>
		// Token: 0x0600D139 RID: 53561 RVA: 0x00122F17 File Offset: 0x00121117
		public virtual void SetCapping(int _arg)
		{
			vtkUnsignedDistance.vtkUnsignedDistance_SetCapping_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D13A RID: 53562
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_SetDimensions_35(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Set/Get the i-j-k dimensions on which to computer the distance function.
		/// </summary>
		// Token: 0x0600D13B RID: 53563 RVA: 0x00122F27 File Offset: 0x00121127
		public void SetDimensions(int i, int j, int k)
		{
			vtkUnsignedDistance.vtkUnsignedDistance_SetDimensions_35(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0600D13C RID: 53564
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_SetDimensions_36(HandleRef pThis, IntPtr dim);

		/// <summary>
		/// Set/Get the i-j-k dimensions on which to computer the distance function.
		/// </summary>
		// Token: 0x0600D13D RID: 53565 RVA: 0x00122F39 File Offset: 0x00121139
		public void SetDimensions(IntPtr dim)
		{
			vtkUnsignedDistance.vtkUnsignedDistance_SetDimensions_36(base.GetCppThis(), dim);
		}

		// Token: 0x0600D13E RID: 53566
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_SetLocator_37(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate points
		/// surrounding a voxel (within the specified radius).
		/// </summary>
		// Token: 0x0600D13F RID: 53567 RVA: 0x00122F4C File Offset: 0x0012114C
		public void SetLocator(vtkAbstractPointLocator locator)
		{
			vtkUnsignedDistance.vtkUnsignedDistance_SetLocator_37(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600D140 RID: 53568
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_SetOutputScalarType_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the desired output scalar type. Currently only real types are
		/// supported. By default, VTK_FLOAT scalars are created.
		/// </summary>
		// Token: 0x0600D141 RID: 53569 RVA: 0x00122F7B File Offset: 0x0012117B
		public virtual void SetOutputScalarType(int _arg)
		{
			vtkUnsignedDistance.vtkUnsignedDistance_SetOutputScalarType_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D142 RID: 53570
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_SetOutputScalarTypeToDouble_39(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type. Currently only real types are
		/// supported. By default, VTK_FLOAT scalars are created.
		/// </summary>
		// Token: 0x0600D143 RID: 53571 RVA: 0x00122F8B File Offset: 0x0012118B
		public void SetOutputScalarTypeToDouble()
		{
			vtkUnsignedDistance.vtkUnsignedDistance_SetOutputScalarTypeToDouble_39(base.GetCppThis());
		}

		// Token: 0x0600D144 RID: 53572
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_SetOutputScalarTypeToFloat_40(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type. Currently only real types are
		/// supported. By default, VTK_FLOAT scalars are created.
		/// </summary>
		// Token: 0x0600D145 RID: 53573 RVA: 0x00122F9A File Offset: 0x0012119A
		public void SetOutputScalarTypeToFloat()
		{
			vtkUnsignedDistance.vtkUnsignedDistance_SetOutputScalarTypeToFloat_40(base.GetCppThis());
		}

		// Token: 0x0600D146 RID: 53574
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_SetRadius_41(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the radius of influence of each point. Smaller values
		/// generally improve performance markedly.
		/// </summary>
		// Token: 0x0600D147 RID: 53575 RVA: 0x00122FA9 File Offset: 0x001211A9
		public virtual void SetRadius(double _arg)
		{
			vtkUnsignedDistance.vtkUnsignedDistance_SetRadius_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D148 RID: 53576
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnsignedDistance_StartAppend_42(HandleRef pThis);

		/// <summary>
		/// Initialize the filter for appending data. You must invoke the
		/// StartAppend() method before doing successive Appends(). It's also a
		/// good idea to manually specify the model bounds; otherwise the input
		/// bounds for the data will be used.
		/// </summary>
		// Token: 0x0600D149 RID: 53577 RVA: 0x00122FB9 File Offset: 0x001211B9
		public void StartAppend()
		{
			vtkUnsignedDistance.vtkUnsignedDistance_StartAppend_42(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F69 RID: 3945
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnsignedDistance";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F6A RID: 3946
		public new static readonly string MRClassNameKey = "class vtkUnsignedDistance";
	}
}
