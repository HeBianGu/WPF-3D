using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInterpolationKernel
	/// </summary>
	/// <remarks>
	///    base class for interpolation kernels
	///
	///
	/// vtkInterpolationKernel specifies an abstract interface for interpolation
	/// kernels. An interpolation kernel is used to produce an interpolated data
	/// value at a point X from the points + data in a local neighborhood
	/// surrounding X. For example, given the N nearest points surrounding X, the
	/// interpolation kernel provides N weights, which when combined with the N
	/// data values associated with these nearest points, produces an interpolated
	/// data value at point X.
	///
	/// Note that various kernel initialization methods are provided. The basic
	/// method requires providing a point locator to accelerate neighborhood
	/// queries. Some kernels may refer back to the original dataset, or the point
	/// attribute data associated with the dataset. The initialization method
	/// enables different styles of initialization and is kernel-dependent.
	///
	/// Typically the kernels are invoked in two parts: first, the basis is
	/// computed using the supplied point locator and dataset. This basis is a
	/// local footprint of point surrounding a poitnX. In this footprint are the
	/// neighboring points used to compute the interpolation weights. Then, the
	/// weights are computed from points forming the basis. However, advanced
	/// users can develop their own basis, skipping the ComputeBasis() method, and
	/// then invoke ComputeWeights() directly.
	///
	/// @warning
	/// The ComputeBasis() and ComputeWeights() methods must be thread safe as they
	/// are used in threaded algorithms.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointInterpolator vtkPointInterpolator2D vtkGeneralizedKernel
	/// vtkGaussianKernel vtkSPHKernel vtkShepardKernel vtkVoronoiKernel
	/// </seealso>
	// Token: 0x02000439 RID: 1081
	public abstract class vtkInterpolationKernel : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CA0E RID: 51726 RVA: 0x0011933D File Offset: 0x0011753D
		static vtkInterpolationKernel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInterpolationKernel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInterpolationKernel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CA0F RID: 51727 RVA: 0x00119365 File Offset: 0x00117565
		public vtkInterpolationKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CA10 RID: 51728 RVA: 0x00119373 File Offset: 0x00117573
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CA11 RID: 51729
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInterpolationKernel_ComputeBasis_01(HandleRef pThis, IntPtr x, HandleRef pIds, long ptId);

		/// <summary>
		/// Given a point x (and optional associated point id), determine the points
		/// around x which form an interpolation basis. The user must provide the
		/// vtkIdList pIds, which will be dynamically resized as necessary. The
		/// method returns the number of points in the basis. Typically this method
		/// is called before ComputeWeights(). Note that ptId is optional in most
		/// cases, although in some kernels it is used to facilitate basis
		/// computation.
		/// </summary>
		// Token: 0x0600CA12 RID: 51730 RVA: 0x00119380 File Offset: 0x00117580
		public virtual long ComputeBasis(IntPtr x, vtkIdList pIds, long ptId)
		{
			return vtkInterpolationKernel.vtkInterpolationKernel_ComputeBasis_01(base.GetCppThis(), x, (pIds == null) ? default(HandleRef) : pIds.GetCppThis(), ptId);
		}

		// Token: 0x0600CA13 RID: 51731
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInterpolationKernel_ComputeWeights_02(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef weights);

		/// <summary>
		/// Given a point x, and a list of basis points pIds, compute interpolation
		/// weights associated with these basis points.  Note that both the nearby
		/// basis points list pIds and the weights array are provided by the caller
		/// of the method, and may be dynamically resized as necessary. The method
		/// returns the number of weights (pIds may be resized in some
		/// cases). Typically this method is called after ComputeBasis(), although
		/// advanced users can invoke ComputeWeights() and provide the interpolation
		/// basis points pIds directly.
		/// </summary>
		// Token: 0x0600CA14 RID: 51732 RVA: 0x001193B8 File Offset: 0x001175B8
		public virtual long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray weights)
		{
			return vtkInterpolationKernel.vtkInterpolationKernel_ComputeWeights_02(base.GetCppThis(), x, (pIds == null) ? default(HandleRef) : pIds.GetCppThis(), (weights == null) ? default(HandleRef) : weights.GetCppThis());
		}

		// Token: 0x0600CA15 RID: 51733
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInterpolationKernel_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard method for type and printing.
		/// </summary>
		// Token: 0x0600CA16 RID: 51734 RVA: 0x00119404 File Offset: 0x00117604
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInterpolationKernel.vtkInterpolationKernel_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600CA17 RID: 51735
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInterpolationKernel_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard method for type and printing.
		/// </summary>
		// Token: 0x0600CA18 RID: 51736 RVA: 0x00119424 File Offset: 0x00117624
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInterpolationKernel.vtkInterpolationKernel_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600CA19 RID: 51737
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInterpolationKernel_GetRequiresInitialization_05(HandleRef pThis);

		/// <summary>
		/// Indicate whether the kernel needs initialization. By default this data
		/// member is true, and using classes will invoke Initialize() on the
		/// kernel. However, if the user takes over initialization manually, then
		/// set RequiresInitialization to false (0).
		/// </summary>
		// Token: 0x0600CA1A RID: 51738 RVA: 0x00119440 File Offset: 0x00117640
		public virtual bool GetRequiresInitialization()
		{
			return vtkInterpolationKernel.vtkInterpolationKernel_GetRequiresInitialization_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CA1B RID: 51739
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInterpolationKernel_Initialize_06(HandleRef pThis, HandleRef loc, HandleRef ds, HandleRef pd);

		/// <summary>
		/// Initialize the kernel. Pass information into the kernel that is
		/// necessary to subsequently perform evaluation. The locator refers to the
		/// points that are to be interpolated from; these points (ds) and the
		/// associated point data (pd) are provided as well. Note that some kernels
		/// may require manual setup / initialization, in which case set
		/// RequiresInitialization to false, do not call Initialize(), and of course
		/// manually initialize the kernel.
		/// </summary>
		// Token: 0x0600CA1C RID: 51740 RVA: 0x00119468 File Offset: 0x00117668
		public virtual void Initialize(vtkAbstractPointLocator loc, vtkDataSet ds, vtkPointData pd)
		{
			vtkInterpolationKernel.vtkInterpolationKernel_Initialize_06(base.GetCppThis(), (loc == null) ? default(HandleRef) : loc.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600CA1D RID: 51741
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInterpolationKernel_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard method for type and printing.
		/// </summary>
		// Token: 0x0600CA1E RID: 51742 RVA: 0x001194C4 File Offset: 0x001176C4
		public override int IsA(string type)
		{
			return vtkInterpolationKernel.vtkInterpolationKernel_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600CA1F RID: 51743
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInterpolationKernel_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard method for type and printing.
		/// </summary>
		// Token: 0x0600CA20 RID: 51744 RVA: 0x001194E4 File Offset: 0x001176E4
		public new static int IsTypeOf(string type)
		{
			return vtkInterpolationKernel.vtkInterpolationKernel_IsTypeOf_08(type);
		}

		// Token: 0x0600CA21 RID: 51745
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInterpolationKernel_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard method for type and printing.
		/// </summary>
		// Token: 0x0600CA22 RID: 51746 RVA: 0x00119500 File Offset: 0x00117700
		public new vtkInterpolationKernel NewInstance()
		{
			vtkInterpolationKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInterpolationKernel.vtkInterpolationKernel_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInterpolationKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CA23 RID: 51747
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInterpolationKernel_RequiresInitializationOff_10(HandleRef pThis);

		/// <summary>
		/// Indicate whether the kernel needs initialization. By default this data
		/// member is true, and using classes will invoke Initialize() on the
		/// kernel. However, if the user takes over initialization manually, then
		/// set RequiresInitialization to false (0).
		/// </summary>
		// Token: 0x0600CA24 RID: 51748 RVA: 0x0011955A File Offset: 0x0011775A
		public virtual void RequiresInitializationOff()
		{
			vtkInterpolationKernel.vtkInterpolationKernel_RequiresInitializationOff_10(base.GetCppThis());
		}

		// Token: 0x0600CA25 RID: 51749
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInterpolationKernel_RequiresInitializationOn_11(HandleRef pThis);

		/// <summary>
		/// Indicate whether the kernel needs initialization. By default this data
		/// member is true, and using classes will invoke Initialize() on the
		/// kernel. However, if the user takes over initialization manually, then
		/// set RequiresInitialization to false (0).
		/// </summary>
		// Token: 0x0600CA26 RID: 51750 RVA: 0x00119569 File Offset: 0x00117769
		public virtual void RequiresInitializationOn()
		{
			vtkInterpolationKernel.vtkInterpolationKernel_RequiresInitializationOn_11(base.GetCppThis());
		}

		// Token: 0x0600CA27 RID: 51751
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInterpolationKernel_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard method for type and printing.
		/// </summary>
		// Token: 0x0600CA28 RID: 51752 RVA: 0x00119578 File Offset: 0x00117778
		public new static vtkInterpolationKernel SafeDownCast(vtkObjectBase o)
		{
			vtkInterpolationKernel vtkInterpolationKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInterpolationKernel.vtkInterpolationKernel_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600CA29 RID: 51753
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInterpolationKernel_SetRequiresInitialization_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether the kernel needs initialization. By default this data
		/// member is true, and using classes will invoke Initialize() on the
		/// kernel. However, if the user takes over initialization manually, then
		/// set RequiresInitialization to false (0).
		/// </summary>
		// Token: 0x0600CA2A RID: 51754 RVA: 0x001195F7 File Offset: 0x001177F7
		public virtual void SetRequiresInitialization(bool _arg)
		{
			vtkInterpolationKernel.vtkInterpolationKernel_SetRequiresInitialization_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EFE RID: 3838
		public new const string MRFullTypeName = "Kitware.VTK.vtkInterpolationKernel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EFF RID: 3839
		public new static readonly string MRClassNameKey = "class vtkInterpolationKernel";
	}
}
