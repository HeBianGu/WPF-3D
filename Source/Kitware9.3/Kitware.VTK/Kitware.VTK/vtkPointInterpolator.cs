using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointInterpolator
	/// </summary>
	/// <remarks>
	///    interpolate over point cloud using various kernels
	///
	///
	/// vtkPointInterpolator probes a point cloud Pc (the filter Source) with a
	/// set of points P (the filter Input), interpolating the data values from Pc
	/// onto P. Note however that the descriptive phrase "point cloud" is a
	/// misnomer: Pc can be represented by any vtkDataSet type, with the points of
	/// the dataset forming Pc. Similarly, the output P can also be represented by
	/// any vtkDataSet type; and the topology/geometry structure of P is passed
	/// through to the output along with the newly interpolated arrays.
	///
	/// A key input to this filter is the specification of the interpolation
	/// kernel, and the parameters which control the associated interpolation
	/// process. Interpolation kernels include Voronoi, Gaussian, Shepard, and SPH
	/// (smoothed particle hydrodynamics), with additional kernels to be added in
	/// the future.
	///
	/// An overview of the algorithm is as follows. For each p from P, Np "close"
	/// points to p are found. (The meaning of what is "close" can be specified as
	/// either the N closest points, or all points within a given radius Rp. This
	/// depends on how the kernel is defined.) Once the Np close points are found,
	/// then the interpolation kernel is applied to compute new data values
	/// located on p. Note that for reasonable performance, finding the Np closest
	/// points requires a point locator. The locator may be specified as input to
	/// the algorithm. (By default, a vtkStaticPointLocator is used because
	/// generally it is much faster to build, delete, and search with. However,
	/// with highly non-uniform point distributions, octree- or kd-tree based
	/// locators may perform better.)
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// @warning
	/// For widely spaced points in Pc, or when p is located outside the bounding
	/// region of Pc, the interpolation may behave badly and the interpolation
	/// process will adapt as necessary to produce output. For example, if the N
	/// closest points within R are requested to interpolate p, if N=0 then the
	/// interpolation will switch to a different strategy (which can be controlled
	/// as in the NullPointsStrategy).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointInterpolator2D vtkProbeFilter vtkGaussianSplatter
	/// vtkCheckerboardSplatter vtkShepardMethod vtkVoronoiKernel vtkShepardKernel
	/// vtkGaussianKernel vtkSPHKernel
	/// </seealso>
	// Token: 0x0200044F RID: 1103
	public class vtkPointInterpolator : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CD59 RID: 52569 RVA: 0x0011DA55 File Offset: 0x0011BC55
		static vtkPointInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CD5A RID: 52570 RVA: 0x0011DA7D File Offset: 0x0011BC7D
		public vtkPointInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CD5B RID: 52571
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CD5C RID: 52572 RVA: 0x0011DA8C File Offset: 0x0011BC8C
		public new static vtkPointInterpolator New()
		{
			vtkPointInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointInterpolator.vtkPointInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CD5D RID: 52573 RVA: 0x0011DAE0 File Offset: 0x0011BCE0
		public vtkPointInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointInterpolator.vtkPointInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CD5E RID: 52574 RVA: 0x0011DB24 File Offset: 0x0011BD24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CD5F RID: 52575
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_AddExcludedArray_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string excludedArray);

		/// <summary>
		/// Adds an array to the list of arrays which are to be excluded from the
		/// interpolation process.
		/// </summary>
		// Token: 0x0600CD60 RID: 52576 RVA: 0x0011DB2F File Offset: 0x0011BD2F
		public void AddExcludedArray(string excludedArray)
		{
			vtkPointInterpolator.vtkPointInterpolator_AddExcludedArray_01(base.GetCppThis(), excludedArray);
		}

		// Token: 0x0600CD61 RID: 52577
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_ClearExcludedArrays_02(HandleRef pThis);

		/// <summary>
		/// Clears the contents of excluded array list.
		/// </summary>
		// Token: 0x0600CD62 RID: 52578 RVA: 0x0011DB3F File Offset: 0x0011BD3F
		public void ClearExcludedArrays()
		{
			vtkPointInterpolator.vtkPointInterpolator_ClearExcludedArrays_02(base.GetCppThis());
		}

		// Token: 0x0600CD63 RID: 52579
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointInterpolator_GetExcludedArray_03(HandleRef pThis, int i);

		/// <summary>
		/// Return the name of the ith excluded array.
		/// </summary>
		// Token: 0x0600CD64 RID: 52580 RVA: 0x0011DB50 File Offset: 0x0011BD50
		public string GetExcludedArray(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkPointInterpolator.vtkPointInterpolator_GetExcludedArray_03(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600CD65 RID: 52581
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointInterpolator_GetKernel_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify an interpolation kernel. By default a vtkLinearKernel is used
		/// (i.e., linear combination of closest points). The interpolation kernel
		/// changes the basis of the interpolation.
		/// </summary>
		// Token: 0x0600CD66 RID: 52582 RVA: 0x0011DB8C File Offset: 0x0011BD8C
		public virtual vtkInterpolationKernel GetKernel()
		{
			vtkInterpolationKernel vtkInterpolationKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointInterpolator.vtkPointInterpolator_GetKernel_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInterpolationKernel = (vtkInterpolationKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInterpolationKernel.Register(null);
				}
			}
			return vtkInterpolationKernel;
		}

		// Token: 0x0600CD67 RID: 52583
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointInterpolator_GetLocator_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate near a
		/// specified interpolation position.
		/// </summary>
		// Token: 0x0600CD68 RID: 52584 RVA: 0x0011DBFC File Offset: 0x0011BDFC
		public virtual vtkAbstractPointLocator GetLocator()
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointInterpolator.vtkPointInterpolator_GetLocator_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600CD69 RID: 52585
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPointInterpolator_GetMTime_06(HandleRef pThis);

		/// <summary>
		/// Get the MTime of this object also considering the locator and kernel.
		/// </summary>
		// Token: 0x0600CD6A RID: 52586 RVA: 0x0011DC6C File Offset: 0x0011BE6C
		public override ulong GetMTime()
		{
			return vtkPointInterpolator.vtkPointInterpolator_GetMTime_06(base.GetCppThis());
		}

		// Token: 0x0600CD6B RID: 52587
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointInterpolator_GetNullPointsStrategy_07(HandleRef pThis);

		/// <summary>
		/// Specify a strategy to use when encountering a "null" point during the
		/// interpolation process. Null points occur when the local neighborhood (of
		/// nearby points to interpolate from) is empty. If the strategy is set to
		/// MaskPoints, then an output array is created that marks points as being
		/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
		/// the strategy is set to NullValue (this is the default), then the output
		/// data value(s) are set to the NullPoint value (specified in the output
		/// point data). Finally, the strategy ClosestPoint is to simply use the
		/// closest point to perform the interpolation.
		/// </summary>
		// Token: 0x0600CD6C RID: 52588 RVA: 0x0011DC8C File Offset: 0x0011BE8C
		public virtual int GetNullPointsStrategy()
		{
			return vtkPointInterpolator.vtkPointInterpolator_GetNullPointsStrategy_07(base.GetCppThis());
		}

		// Token: 0x0600CD6D RID: 52589
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointInterpolator_GetNullValue_08(HandleRef pThis);

		/// <summary>
		/// Specify the null point value. When a null point is encountered then all
		/// components of each null tuple are set to this value. By default the
		/// null value is set to zero.
		/// </summary>
		// Token: 0x0600CD6E RID: 52590 RVA: 0x0011DCAC File Offset: 0x0011BEAC
		public virtual double GetNullValue()
		{
			return vtkPointInterpolator.vtkPointInterpolator_GetNullValue_08(base.GetCppThis());
		}

		// Token: 0x0600CD6F RID: 52591
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointInterpolator_GetNumberOfExcludedArrays_09(HandleRef pThis);

		/// <summary>
		/// Return the number of excluded arrays.
		/// </summary>
		// Token: 0x0600CD70 RID: 52592 RVA: 0x0011DCCC File Offset: 0x0011BECC
		public int GetNumberOfExcludedArrays()
		{
			return vtkPointInterpolator.vtkPointInterpolator_GetNumberOfExcludedArrays_09(base.GetCppThis());
		}

		// Token: 0x0600CD71 RID: 52593
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointInterpolator_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CD72 RID: 52594 RVA: 0x0011DCEC File Offset: 0x0011BEEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointInterpolator.vtkPointInterpolator_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0600CD73 RID: 52595
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointInterpolator_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CD74 RID: 52596 RVA: 0x0011DD0C File Offset: 0x0011BF0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointInterpolator.vtkPointInterpolator_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0600CD75 RID: 52597
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointInterpolator_GetPassCellArrays_12(HandleRef pThis);

		/// <summary>
		/// Indicate whether to shallow copy the input cell data arrays to the
		/// output.  On by default.
		/// </summary>
		// Token: 0x0600CD76 RID: 52598 RVA: 0x0011DD28 File Offset: 0x0011BF28
		public virtual bool GetPassCellArrays()
		{
			return vtkPointInterpolator.vtkPointInterpolator_GetPassCellArrays_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CD77 RID: 52599
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointInterpolator_GetPassFieldArrays_13(HandleRef pThis);

		/// <summary>
		/// Indicate whether to pass the field-data arrays from the input to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600CD78 RID: 52600 RVA: 0x0011DD50 File Offset: 0x0011BF50
		public virtual bool GetPassFieldArrays()
		{
			return vtkPointInterpolator.vtkPointInterpolator_GetPassFieldArrays_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CD79 RID: 52601
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointInterpolator_GetPassPointArrays_14(HandleRef pThis);

		/// <summary>
		/// Indicate whether to shallow copy the input point data arrays to the
		/// output.  On by default.
		/// </summary>
		// Token: 0x0600CD7A RID: 52602 RVA: 0x0011DD78 File Offset: 0x0011BF78
		public virtual bool GetPassPointArrays()
		{
			return vtkPointInterpolator.vtkPointInterpolator_GetPassPointArrays_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CD7B RID: 52603
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointInterpolator_GetPromoteOutputArrays_15(HandleRef pThis);

		/// <summary>
		/// If enabled, then input arrays that are non-real types (i.e., not float
		/// or double) are promoted to float type on output. This is because the
		/// interpolation process may not be well behaved when integral types are
		/// combined using interpolation weights.
		/// </summary>
		// Token: 0x0600CD7C RID: 52604 RVA: 0x0011DDA0 File Offset: 0x0011BFA0
		public virtual bool GetPromoteOutputArrays()
		{
			return vtkPointInterpolator.vtkPointInterpolator_GetPromoteOutputArrays_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CD7D RID: 52605
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointInterpolator_GetSource_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the dataset Pc that will be probed by the input points P.  The
		/// Input P defines the dataset structure (the points and cells) for the
		/// output, while the Source Pc is probed (interpolated) to generate the
		/// scalars, vectors, etc. for the output points based on the point
		/// locations.
		/// </summary>
		// Token: 0x0600CD7E RID: 52606 RVA: 0x0011DDC8 File Offset: 0x0011BFC8
		public vtkDataObject GetSource()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointInterpolator.vtkPointInterpolator_GetSource_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0600CD7F RID: 52607
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPointInterpolator_GetValidPointsMaskArrayName_17(HandleRef pThis);

		/// <summary>
		/// If the NullPointsStrategy == MASK_POINTS, then an array is generated for
		/// each input point. This vtkCharArray is placed into the output of the filter,
		/// with a non-zero value for a valid point, and zero otherwise. The name of
		/// this masking array is specified here.
		/// </summary>
		// Token: 0x0600CD80 RID: 52608 RVA: 0x0011DE38 File Offset: 0x0011C038
		public virtual string GetValidPointsMaskArrayName()
		{
			return vtkPointInterpolator.vtkPointInterpolator_GetValidPointsMaskArrayName_17(base.GetCppThis());
		}

		// Token: 0x0600CD81 RID: 52609
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointInterpolator_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CD82 RID: 52610 RVA: 0x0011DE58 File Offset: 0x0011C058
		public override int IsA(string type)
		{
			return vtkPointInterpolator.vtkPointInterpolator_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0600CD83 RID: 52611
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointInterpolator_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CD84 RID: 52612 RVA: 0x0011DE78 File Offset: 0x0011C078
		public new static int IsTypeOf(string type)
		{
			return vtkPointInterpolator.vtkPointInterpolator_IsTypeOf_19(type);
		}

		// Token: 0x0600CD85 RID: 52613
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointInterpolator_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CD86 RID: 52614 RVA: 0x0011DE94 File Offset: 0x0011C094
		public new vtkPointInterpolator NewInstance()
		{
			vtkPointInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointInterpolator.vtkPointInterpolator_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CD87 RID: 52615
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_PassCellArraysOff_22(HandleRef pThis);

		/// <summary>
		/// Indicate whether to shallow copy the input cell data arrays to the
		/// output.  On by default.
		/// </summary>
		// Token: 0x0600CD88 RID: 52616 RVA: 0x0011DEEE File Offset: 0x0011C0EE
		public virtual void PassCellArraysOff()
		{
			vtkPointInterpolator.vtkPointInterpolator_PassCellArraysOff_22(base.GetCppThis());
		}

		// Token: 0x0600CD89 RID: 52617
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_PassCellArraysOn_23(HandleRef pThis);

		/// <summary>
		/// Indicate whether to shallow copy the input cell data arrays to the
		/// output.  On by default.
		/// </summary>
		// Token: 0x0600CD8A RID: 52618 RVA: 0x0011DEFD File Offset: 0x0011C0FD
		public virtual void PassCellArraysOn()
		{
			vtkPointInterpolator.vtkPointInterpolator_PassCellArraysOn_23(base.GetCppThis());
		}

		// Token: 0x0600CD8B RID: 52619
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_PassFieldArraysOff_24(HandleRef pThis);

		/// <summary>
		/// Indicate whether to pass the field-data arrays from the input to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600CD8C RID: 52620 RVA: 0x0011DF0C File Offset: 0x0011C10C
		public virtual void PassFieldArraysOff()
		{
			vtkPointInterpolator.vtkPointInterpolator_PassFieldArraysOff_24(base.GetCppThis());
		}

		// Token: 0x0600CD8D RID: 52621
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_PassFieldArraysOn_25(HandleRef pThis);

		/// <summary>
		/// Indicate whether to pass the field-data arrays from the input to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600CD8E RID: 52622 RVA: 0x0011DF1B File Offset: 0x0011C11B
		public virtual void PassFieldArraysOn()
		{
			vtkPointInterpolator.vtkPointInterpolator_PassFieldArraysOn_25(base.GetCppThis());
		}

		// Token: 0x0600CD8F RID: 52623
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_PassPointArraysOff_26(HandleRef pThis);

		/// <summary>
		/// Indicate whether to shallow copy the input point data arrays to the
		/// output.  On by default.
		/// </summary>
		// Token: 0x0600CD90 RID: 52624 RVA: 0x0011DF2A File Offset: 0x0011C12A
		public virtual void PassPointArraysOff()
		{
			vtkPointInterpolator.vtkPointInterpolator_PassPointArraysOff_26(base.GetCppThis());
		}

		// Token: 0x0600CD91 RID: 52625
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_PassPointArraysOn_27(HandleRef pThis);

		/// <summary>
		/// Indicate whether to shallow copy the input point data arrays to the
		/// output.  On by default.
		/// </summary>
		// Token: 0x0600CD92 RID: 52626 RVA: 0x0011DF39 File Offset: 0x0011C139
		public virtual void PassPointArraysOn()
		{
			vtkPointInterpolator.vtkPointInterpolator_PassPointArraysOn_27(base.GetCppThis());
		}

		// Token: 0x0600CD93 RID: 52627
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_PromoteOutputArraysOff_28(HandleRef pThis);

		/// <summary>
		/// If enabled, then input arrays that are non-real types (i.e., not float
		/// or double) are promoted to float type on output. This is because the
		/// interpolation process may not be well behaved when integral types are
		/// combined using interpolation weights.
		/// </summary>
		// Token: 0x0600CD94 RID: 52628 RVA: 0x0011DF48 File Offset: 0x0011C148
		public virtual void PromoteOutputArraysOff()
		{
			vtkPointInterpolator.vtkPointInterpolator_PromoteOutputArraysOff_28(base.GetCppThis());
		}

		// Token: 0x0600CD95 RID: 52629
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_PromoteOutputArraysOn_29(HandleRef pThis);

		/// <summary>
		/// If enabled, then input arrays that are non-real types (i.e., not float
		/// or double) are promoted to float type on output. This is because the
		/// interpolation process may not be well behaved when integral types are
		/// combined using interpolation weights.
		/// </summary>
		// Token: 0x0600CD96 RID: 52630 RVA: 0x0011DF57 File Offset: 0x0011C157
		public virtual void PromoteOutputArraysOn()
		{
			vtkPointInterpolator.vtkPointInterpolator_PromoteOutputArraysOn_29(base.GetCppThis());
		}

		// Token: 0x0600CD97 RID: 52631
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointInterpolator_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CD98 RID: 52632 RVA: 0x0011DF68 File Offset: 0x0011C168
		public new static vtkPointInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkPointInterpolator vtkPointInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointInterpolator.vtkPointInterpolator_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointInterpolator = (vtkPointInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointInterpolator.Register(null);
				}
			}
			return vtkPointInterpolator;
		}

		// Token: 0x0600CD99 RID: 52633
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_SetKernel_31(HandleRef pThis, HandleRef kernel);

		/// <summary>
		/// Specify an interpolation kernel. By default a vtkLinearKernel is used
		/// (i.e., linear combination of closest points). The interpolation kernel
		/// changes the basis of the interpolation.
		/// </summary>
		// Token: 0x0600CD9A RID: 52634 RVA: 0x0011DFE8 File Offset: 0x0011C1E8
		public void SetKernel(vtkInterpolationKernel kernel)
		{
			vtkPointInterpolator.vtkPointInterpolator_SetKernel_31(base.GetCppThis(), (kernel == null) ? default(HandleRef) : kernel.GetCppThis());
		}

		// Token: 0x0600CD9B RID: 52635
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_SetLocator_32(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate near a
		/// specified interpolation position.
		/// </summary>
		// Token: 0x0600CD9C RID: 52636 RVA: 0x0011E018 File Offset: 0x0011C218
		public void SetLocator(vtkAbstractPointLocator locator)
		{
			vtkPointInterpolator.vtkPointInterpolator_SetLocator_32(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600CD9D RID: 52637
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_SetNullPointsStrategy_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify a strategy to use when encountering a "null" point during the
		/// interpolation process. Null points occur when the local neighborhood (of
		/// nearby points to interpolate from) is empty. If the strategy is set to
		/// MaskPoints, then an output array is created that marks points as being
		/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
		/// the strategy is set to NullValue (this is the default), then the output
		/// data value(s) are set to the NullPoint value (specified in the output
		/// point data). Finally, the strategy ClosestPoint is to simply use the
		/// closest point to perform the interpolation.
		/// </summary>
		// Token: 0x0600CD9E RID: 52638 RVA: 0x0011E047 File Offset: 0x0011C247
		public virtual void SetNullPointsStrategy(int _arg)
		{
			vtkPointInterpolator.vtkPointInterpolator_SetNullPointsStrategy_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CD9F RID: 52639
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_SetNullPointsStrategyToClosestPoint_34(HandleRef pThis);

		/// <summary>
		/// Specify a strategy to use when encountering a "null" point during the
		/// interpolation process. Null points occur when the local neighborhood (of
		/// nearby points to interpolate from) is empty. If the strategy is set to
		/// MaskPoints, then an output array is created that marks points as being
		/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
		/// the strategy is set to NullValue (this is the default), then the output
		/// data value(s) are set to the NullPoint value (specified in the output
		/// point data). Finally, the strategy ClosestPoint is to simply use the
		/// closest point to perform the interpolation.
		/// </summary>
		// Token: 0x0600CDA0 RID: 52640 RVA: 0x0011E057 File Offset: 0x0011C257
		public void SetNullPointsStrategyToClosestPoint()
		{
			vtkPointInterpolator.vtkPointInterpolator_SetNullPointsStrategyToClosestPoint_34(base.GetCppThis());
		}

		// Token: 0x0600CDA1 RID: 52641
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_SetNullPointsStrategyToMaskPoints_35(HandleRef pThis);

		/// <summary>
		/// Specify a strategy to use when encountering a "null" point during the
		/// interpolation process. Null points occur when the local neighborhood (of
		/// nearby points to interpolate from) is empty. If the strategy is set to
		/// MaskPoints, then an output array is created that marks points as being
		/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
		/// the strategy is set to NullValue (this is the default), then the output
		/// data value(s) are set to the NullPoint value (specified in the output
		/// point data). Finally, the strategy ClosestPoint is to simply use the
		/// closest point to perform the interpolation.
		/// </summary>
		// Token: 0x0600CDA2 RID: 52642 RVA: 0x0011E066 File Offset: 0x0011C266
		public void SetNullPointsStrategyToMaskPoints()
		{
			vtkPointInterpolator.vtkPointInterpolator_SetNullPointsStrategyToMaskPoints_35(base.GetCppThis());
		}

		// Token: 0x0600CDA3 RID: 52643
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_SetNullPointsStrategyToNullValue_36(HandleRef pThis);

		/// <summary>
		/// Specify a strategy to use when encountering a "null" point during the
		/// interpolation process. Null points occur when the local neighborhood (of
		/// nearby points to interpolate from) is empty. If the strategy is set to
		/// MaskPoints, then an output array is created that marks points as being
		/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
		/// the strategy is set to NullValue (this is the default), then the output
		/// data value(s) are set to the NullPoint value (specified in the output
		/// point data). Finally, the strategy ClosestPoint is to simply use the
		/// closest point to perform the interpolation.
		/// </summary>
		// Token: 0x0600CDA4 RID: 52644 RVA: 0x0011E075 File Offset: 0x0011C275
		public void SetNullPointsStrategyToNullValue()
		{
			vtkPointInterpolator.vtkPointInterpolator_SetNullPointsStrategyToNullValue_36(base.GetCppThis());
		}

		// Token: 0x0600CDA5 RID: 52645
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_SetNullValue_37(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the null point value. When a null point is encountered then all
		/// components of each null tuple are set to this value. By default the
		/// null value is set to zero.
		/// </summary>
		// Token: 0x0600CDA6 RID: 52646 RVA: 0x0011E084 File Offset: 0x0011C284
		public virtual void SetNullValue(double _arg)
		{
			vtkPointInterpolator.vtkPointInterpolator_SetNullValue_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CDA7 RID: 52647
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_SetPassCellArrays_38(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to shallow copy the input cell data arrays to the
		/// output.  On by default.
		/// </summary>
		// Token: 0x0600CDA8 RID: 52648 RVA: 0x0011E094 File Offset: 0x0011C294
		public virtual void SetPassCellArrays(bool _arg)
		{
			vtkPointInterpolator.vtkPointInterpolator_SetPassCellArrays_38(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CDA9 RID: 52649
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_SetPassFieldArrays_39(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to pass the field-data arrays from the input to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600CDAA RID: 52650 RVA: 0x0011E0AC File Offset: 0x0011C2AC
		public virtual void SetPassFieldArrays(bool _arg)
		{
			vtkPointInterpolator.vtkPointInterpolator_SetPassFieldArrays_39(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CDAB RID: 52651
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_SetPassPointArrays_40(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to shallow copy the input point data arrays to the
		/// output.  On by default.
		/// </summary>
		// Token: 0x0600CDAC RID: 52652 RVA: 0x0011E0C4 File Offset: 0x0011C2C4
		public virtual void SetPassPointArrays(bool _arg)
		{
			vtkPointInterpolator.vtkPointInterpolator_SetPassPointArrays_40(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CDAD RID: 52653
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_SetPromoteOutputArrays_41(HandleRef pThis, byte _arg);

		/// <summary>
		/// If enabled, then input arrays that are non-real types (i.e., not float
		/// or double) are promoted to float type on output. This is because the
		/// interpolation process may not be well behaved when integral types are
		/// combined using interpolation weights.
		/// </summary>
		// Token: 0x0600CDAE RID: 52654 RVA: 0x0011E0DC File Offset: 0x0011C2DC
		public virtual void SetPromoteOutputArrays(bool _arg)
		{
			vtkPointInterpolator.vtkPointInterpolator_SetPromoteOutputArrays_41(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CDAF RID: 52655
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_SetSourceConnection_42(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the dataset Pc that will be probed by the input points P.  The
		/// Input P defines the structure (the points and cells) for the output,
		/// while the Source Pc is probed (interpolated) to generate the scalars,
		/// vectors, etc. for the output points based on the point locations.
		/// </summary>
		// Token: 0x0600CDB0 RID: 52656 RVA: 0x0011E0F4 File Offset: 0x0011C2F4
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkPointInterpolator.vtkPointInterpolator_SetSourceConnection_42(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600CDB1 RID: 52657
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_SetSourceData_43(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the dataset Pc that will be probed by the input points P.  The
		/// Input P defines the dataset structure (the points and cells) for the
		/// output, while the Source Pc is probed (interpolated) to generate the
		/// scalars, vectors, etc. for the output points based on the point
		/// locations.
		/// </summary>
		// Token: 0x0600CDB2 RID: 52658 RVA: 0x0011E124 File Offset: 0x0011C324
		public void SetSourceData(vtkDataObject source)
		{
			vtkPointInterpolator.vtkPointInterpolator_SetSourceData_43(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0600CDB3 RID: 52659
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator_SetValidPointsMaskArrayName_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// If the NullPointsStrategy == MASK_POINTS, then an array is generated for
		/// each input point. This vtkCharArray is placed into the output of the filter,
		/// with a non-zero value for a valid point, and zero otherwise. The name of
		/// this masking array is specified here.
		/// </summary>
		// Token: 0x0600CDB4 RID: 52660 RVA: 0x0011E153 File Offset: 0x0011C353
		public virtual void SetValidPointsMaskArrayName(string _arg)
		{
			vtkPointInterpolator.vtkPointInterpolator_SetValidPointsMaskArrayName_44(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F2F RID: 3887
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F30 RID: 3888
		public new static readonly string MRClassNameKey = "class vtkPointInterpolator";

		/// <summary>
		/// Specify an interpolation kernel. By default a vtkLinearKernel is used
		/// (i.e., linear combination of closest points). The interpolation kernel
		/// changes the basis of the interpolation.
		/// </summary>
		// Token: 0x02000450 RID: 1104
		public enum Strategy
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F32 RID: 3890
			CLOSEST_POINT = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000F33 RID: 3891
			MASK_POINTS = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000F34 RID: 3892
			NULL_VALUE
		}
	}
}
