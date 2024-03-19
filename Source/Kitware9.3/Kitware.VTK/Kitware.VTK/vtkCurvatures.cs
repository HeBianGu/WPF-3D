using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCurvatures
	/// </summary>
	/// <remarks>
	///    compute curvatures (Gauss and mean) of a Polydata object
	///
	/// vtkCurvatures takes a polydata input and computes the curvature of the
	/// mesh at each point. Four possible methods of computation are available :
	///
	/// Gauss Curvature discrete Gauss curvature (\f$ K \f$),
	/// \f$K_v = 2\pi-n_vf_v(\alpha)\f$, where \f$K_v\f$ is the curvature
	/// at vertex \f$v\f$, \f$n_v\f$ the facet neighbours of the vertex \f$v\f$
	/// and \f$f_v(\alpha)\f$ is the angle of \f$f\f$ at vertex \f$v\f$.
	/// The contribution of every facet is for the moment weighted by the
	/// (area of each facet)/3 The units of Gaussian Curvature are \f$m^{-2}\f$.
	///
	/// Mean Curvature \f$H_v = \overline{H_e}\f$, where \f$\overline{H_e}\f$ is
	/// the average over the edge neighbours of \f$H_e\f$.
	/// \f$H_e = l(e)*\alpha(e)\f$ where \f$e\f$ is an edge, \f$l\f$ is the length
	/// and \f$\alpha\f$ is the dihederal angle such that
	/// \f$-\pi &lt; \alpha &lt; \pi\f$. This means that the surface is assumed to
	/// be orientable and the computation creates the orientation. The units of
	/// Mean Curvature are \f$m^{-1}\f$.
	///
	/// Maximum (\f$k_{max}\f$) and Minimum (\f$k_{min}\f$) Principal Curvatures
	///  are \f$k_{max} = H + \sqrt{H^2 - K}\f$ and
	/// \f$k_{min} = H - \sqrt{H^2 - K}\f$.
	/// Excepting spherical and planar surfaces which have equal
	/// principal curvatures, the curvature at a point on a surface varies with
	/// the direction one "sets off" from the point. For all directions, the
	/// curvature will pass through two extrema: a minimum (\f$k_{min}\f$) and a
	/// maximum (\f$k_{max}\f$) which occur at mutually orthogonal directions
	/// to each other.
	///
	/// The sign of the Gauss curvature is a geometric ivariant, it should be
	/// positive when the surface looks like a sphere, negative when it looks
	/// like a saddle, however, the sign of the Mean curvature is not, it depends
	/// on the convention for normals, This code assumes that normals point
	/// outwards (ie from the surface of a sphere outwards). If a given mesh
	/// produces curvatures of opposite senses then the flag InvertMeanCurvature
	///  can be set and the Curvature reported by the Mean calculation will
	/// be inverted.
	///
	/// For a little more information see
	/// &lt;a href="https://public.kitware.com/pipermail/vtkusers/2002-July/012198.html"
	/// &gt;Computing curvature of a surface&lt;/a&gt;
	///
	/// @par Thanks:
	/// &lt;a href="https://en.wikipedia.org/wiki/Philip_Batchelor"&gt;Philip Batchelor&lt;/a&gt;
	/// for creating and contributing the class and Andrew Maclean for cleanups and
	/// fixes. Thanks also to John Biddiscombe for adding the class and
	/// Goodwin Lawlor for contributing a patch to calculate principal curvatures
	///
	/// </remarks>
	// Token: 0x0200088B RID: 2187
	public class vtkCurvatures : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016BA4 RID: 93092 RVA: 0x001FF437 File Offset: 0x001FD637
		static vtkCurvatures()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCurvatures.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCurvatures"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016BA5 RID: 93093 RVA: 0x001FF45F File Offset: 0x001FD65F
		public vtkCurvatures(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016BA6 RID: 93094
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCurvatures_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with curvature type set to Gauss
		/// </summary>
		// Token: 0x06016BA7 RID: 93095 RVA: 0x001FF470 File Offset: 0x001FD670
		public new static vtkCurvatures New()
		{
			vtkCurvatures result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCurvatures.vtkCurvatures_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCurvatures)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with curvature type set to Gauss
		/// </summary>
		// Token: 0x06016BA8 RID: 93096 RVA: 0x001FF4C4 File Offset: 0x001FD6C4
		public vtkCurvatures() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCurvatures.vtkCurvatures_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016BA9 RID: 93097 RVA: 0x001FF508 File Offset: 0x001FD708
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016BAA RID: 93098
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurvatures_GetCurvatureType_01(HandleRef pThis);

		/// <summary>
		/// Set/Get Curvature type
		/// VTK_CURVATURE_GAUSS: Gaussian curvature, stored as
		/// DataArray "Gauss_Curvature"
		/// VTK_CURVATURE_MEAN : Mean curvature, stored as
		/// DataArray "Mean_Curvature"
		/// </summary>
		// Token: 0x06016BAB RID: 93099 RVA: 0x001FF514 File Offset: 0x001FD714
		public virtual int GetCurvatureType()
		{
			return vtkCurvatures.vtkCurvatures_GetCurvatureType_01(base.GetCppThis());
		}

		// Token: 0x06016BAC RID: 93100
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurvatures_GetInvertMeanCurvature_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which inverts the mean curvature calculation for
		/// meshes with inward pointing normals (default false)
		/// </summary>
		// Token: 0x06016BAD RID: 93101 RVA: 0x001FF534 File Offset: 0x001FD734
		public virtual int GetInvertMeanCurvature()
		{
			return vtkCurvatures.vtkCurvatures_GetInvertMeanCurvature_02(base.GetCppThis());
		}

		// Token: 0x06016BAE RID: 93102
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCurvatures_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BAF RID: 93103 RVA: 0x001FF554 File Offset: 0x001FD754
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCurvatures.vtkCurvatures_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06016BB0 RID: 93104
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCurvatures_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BB1 RID: 93105 RVA: 0x001FF574 File Offset: 0x001FD774
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCurvatures.vtkCurvatures_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06016BB2 RID: 93106
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurvatures_InvertMeanCurvatureOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which inverts the mean curvature calculation for
		/// meshes with inward pointing normals (default false)
		/// </summary>
		// Token: 0x06016BB3 RID: 93107 RVA: 0x001FF58E File Offset: 0x001FD78E
		public virtual void InvertMeanCurvatureOff()
		{
			vtkCurvatures.vtkCurvatures_InvertMeanCurvatureOff_05(base.GetCppThis());
		}

		// Token: 0x06016BB4 RID: 93108
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurvatures_InvertMeanCurvatureOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which inverts the mean curvature calculation for
		/// meshes with inward pointing normals (default false)
		/// </summary>
		// Token: 0x06016BB5 RID: 93109 RVA: 0x001FF59D File Offset: 0x001FD79D
		public virtual void InvertMeanCurvatureOn()
		{
			vtkCurvatures.vtkCurvatures_InvertMeanCurvatureOn_06(base.GetCppThis());
		}

		// Token: 0x06016BB6 RID: 93110
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurvatures_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BB7 RID: 93111 RVA: 0x001FF5AC File Offset: 0x001FD7AC
		public override int IsA(string type)
		{
			return vtkCurvatures.vtkCurvatures_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06016BB8 RID: 93112
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCurvatures_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BB9 RID: 93113 RVA: 0x001FF5CC File Offset: 0x001FD7CC
		public new static int IsTypeOf(string type)
		{
			return vtkCurvatures.vtkCurvatures_IsTypeOf_08(type);
		}

		// Token: 0x06016BBA RID: 93114
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCurvatures_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BBB RID: 93115 RVA: 0x001FF5E8 File Offset: 0x001FD7E8
		public new vtkCurvatures NewInstance()
		{
			vtkCurvatures result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCurvatures.vtkCurvatures_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCurvatures)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016BBC RID: 93116
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCurvatures_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016BBD RID: 93117 RVA: 0x001FF644 File Offset: 0x001FD844
		public new static vtkCurvatures SafeDownCast(vtkObjectBase o)
		{
			vtkCurvatures vtkCurvatures = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCurvatures.vtkCurvatures_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCurvatures = (vtkCurvatures)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCurvatures.Register(null);
				}
			}
			return vtkCurvatures;
		}

		// Token: 0x06016BBE RID: 93118
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurvatures_SetCurvatureType_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get Curvature type
		/// VTK_CURVATURE_GAUSS: Gaussian curvature, stored as
		/// DataArray "Gauss_Curvature"
		/// VTK_CURVATURE_MEAN : Mean curvature, stored as
		/// DataArray "Mean_Curvature"
		/// </summary>
		// Token: 0x06016BBF RID: 93119 RVA: 0x001FF6C3 File Offset: 0x001FD8C3
		public virtual void SetCurvatureType(int _arg)
		{
			vtkCurvatures.vtkCurvatures_SetCurvatureType_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06016BC0 RID: 93120
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurvatures_SetCurvatureTypeToGaussian_13(HandleRef pThis);

		/// <summary>
		/// Set/Get Curvature type
		/// VTK_CURVATURE_GAUSS: Gaussian curvature, stored as
		/// DataArray "Gauss_Curvature"
		/// VTK_CURVATURE_MEAN : Mean curvature, stored as
		/// DataArray "Mean_Curvature"
		/// </summary>
		// Token: 0x06016BC1 RID: 93121 RVA: 0x001FF6D3 File Offset: 0x001FD8D3
		public void SetCurvatureTypeToGaussian()
		{
			vtkCurvatures.vtkCurvatures_SetCurvatureTypeToGaussian_13(base.GetCppThis());
		}

		// Token: 0x06016BC2 RID: 93122
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurvatures_SetCurvatureTypeToMaximum_14(HandleRef pThis);

		/// <summary>
		/// Set/Get Curvature type
		/// VTK_CURVATURE_GAUSS: Gaussian curvature, stored as
		/// DataArray "Gauss_Curvature"
		/// VTK_CURVATURE_MEAN : Mean curvature, stored as
		/// DataArray "Mean_Curvature"
		/// </summary>
		// Token: 0x06016BC3 RID: 93123 RVA: 0x001FF6E2 File Offset: 0x001FD8E2
		public void SetCurvatureTypeToMaximum()
		{
			vtkCurvatures.vtkCurvatures_SetCurvatureTypeToMaximum_14(base.GetCppThis());
		}

		// Token: 0x06016BC4 RID: 93124
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurvatures_SetCurvatureTypeToMean_15(HandleRef pThis);

		/// <summary>
		/// Set/Get Curvature type
		/// VTK_CURVATURE_GAUSS: Gaussian curvature, stored as
		/// DataArray "Gauss_Curvature"
		/// VTK_CURVATURE_MEAN : Mean curvature, stored as
		/// DataArray "Mean_Curvature"
		/// </summary>
		// Token: 0x06016BC5 RID: 93125 RVA: 0x001FF6F1 File Offset: 0x001FD8F1
		public void SetCurvatureTypeToMean()
		{
			vtkCurvatures.vtkCurvatures_SetCurvatureTypeToMean_15(base.GetCppThis());
		}

		// Token: 0x06016BC6 RID: 93126
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurvatures_SetCurvatureTypeToMinimum_16(HandleRef pThis);

		/// <summary>
		/// Set/Get Curvature type
		/// VTK_CURVATURE_GAUSS: Gaussian curvature, stored as
		/// DataArray "Gauss_Curvature"
		/// VTK_CURVATURE_MEAN : Mean curvature, stored as
		/// DataArray "Mean_Curvature"
		/// </summary>
		// Token: 0x06016BC7 RID: 93127 RVA: 0x001FF700 File Offset: 0x001FD900
		public void SetCurvatureTypeToMinimum()
		{
			vtkCurvatures.vtkCurvatures_SetCurvatureTypeToMinimum_16(base.GetCppThis());
		}

		// Token: 0x06016BC8 RID: 93128
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCurvatures_SetInvertMeanCurvature_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag which inverts the mean curvature calculation for
		/// meshes with inward pointing normals (default false)
		/// </summary>
		// Token: 0x06016BC9 RID: 93129 RVA: 0x001FF70F File Offset: 0x001FD90F
		public virtual void SetInvertMeanCurvature(int _arg)
		{
			vtkCurvatures.vtkCurvatures_SetInvertMeanCurvature_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001977 RID: 6519
		public new const string MRFullTypeName = "Kitware.VTK.vtkCurvatures";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001978 RID: 6520
		public new static readonly string MRClassNameKey = "class vtkCurvatures";
	}
}
