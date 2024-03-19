using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointInterpolator2D
	/// </summary>
	/// <remarks>
	///    interpolate point cloud attribute data
	/// onto x-y plane using various kernels
	///
	///
	/// vtkPointInterpolator2D probes a point cloud Pc (the filter Source) with a
	/// set of points P (the filter Input), interpolating the data values from Pc
	/// onto P. Note however that the descriptive phrase "point cloud" is a
	/// misnomer: Pc can be represented by any vtkDataSet type, with the points of
	/// the dataset forming Pc. Similarly, the output P can also be represented by
	/// any vtkDataSet type; and the topology/geometry structure of P is passed
	/// through to the output along with the newly interpolated arrays. However,
	/// this filter presumes that P lies on a plane z=0.0, thus z-coordinates
	/// are set accordingly during the interpolation process.
	///
	/// The optional boolean flag InterpolateZ is provided for convenience. In
	/// effect it turns the source z coordinates into an additional array that is
	/// interpolated onto the output data. For example, if the source is a x-y-z
	/// LIDAR point cloud, then z can be interpolated onto the output dataset as a
	/// vertical elevation(z-coordinate).
	///
	/// A key input to this filter is the specification of the interpolation
	/// kernel, and the parameters which control the associated interpolation
	/// process. Interpolation kernels include Voronoi, Gaussian, Shepard, and SPH
	/// (smoothed particle hydrodynamics), with additional kernels to be added in
	/// the future. See vtkPointInterpolator for more information.
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
	/// vtkPointInterpolator
	/// </seealso>
	// Token: 0x02000451 RID: 1105
	public class vtkPointInterpolator2D : vtkPointInterpolator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CDB5 RID: 52661 RVA: 0x0011E163 File Offset: 0x0011C363
		static vtkPointInterpolator2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointInterpolator2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointInterpolator2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CDB6 RID: 52662 RVA: 0x0011E18B File Offset: 0x0011C38B
		public vtkPointInterpolator2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CDB7 RID: 52663
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointInterpolator2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CDB8 RID: 52664 RVA: 0x0011E19C File Offset: 0x0011C39C
		public new static vtkPointInterpolator2D New()
		{
			vtkPointInterpolator2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointInterpolator2D.vtkPointInterpolator2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointInterpolator2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CDB9 RID: 52665 RVA: 0x0011E1F0 File Offset: 0x0011C3F0
		public vtkPointInterpolator2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointInterpolator2D.vtkPointInterpolator2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CDBA RID: 52666 RVA: 0x0011E234 File Offset: 0x0011C434
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CDBB RID: 52667
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointInterpolator2D_GetInterpolateZ_01(HandleRef pThis);

		/// <summary>
		/// Specify whether to take the z-coordinate values of the source points as
		/// attributes to be interpolated. This is in addition to any other point
		/// attribute data associated with the source. By default this is enabled.
		/// </summary>
		// Token: 0x0600CDBC RID: 52668 RVA: 0x0011E240 File Offset: 0x0011C440
		public virtual bool GetInterpolateZ()
		{
			return vtkPointInterpolator2D.vtkPointInterpolator2D_GetInterpolateZ_01(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CDBD RID: 52669
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointInterpolator2D_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CDBE RID: 52670 RVA: 0x0011E268 File Offset: 0x0011C468
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointInterpolator2D.vtkPointInterpolator2D_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600CDBF RID: 52671
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointInterpolator2D_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CDC0 RID: 52672 RVA: 0x0011E288 File Offset: 0x0011C488
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointInterpolator2D.vtkPointInterpolator2D_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600CDC1 RID: 52673
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPointInterpolator2D_GetZArrayName_04(HandleRef pThis);

		/// <summary>
		/// Specify the name of the output array containing z values. This method is
		/// only applicable when InterpolateZ is enabled. By default the output
		/// array name is "Elevation".
		/// </summary>
		// Token: 0x0600CDC2 RID: 52674 RVA: 0x0011E2A4 File Offset: 0x0011C4A4
		public virtual string GetZArrayName()
		{
			return vtkPointInterpolator2D.vtkPointInterpolator2D_GetZArrayName_04(base.GetCppThis());
		}

		// Token: 0x0600CDC3 RID: 52675
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator2D_InterpolateZOff_05(HandleRef pThis);

		/// <summary>
		/// Specify whether to take the z-coordinate values of the source points as
		/// attributes to be interpolated. This is in addition to any other point
		/// attribute data associated with the source. By default this is enabled.
		/// </summary>
		// Token: 0x0600CDC4 RID: 52676 RVA: 0x0011E2C3 File Offset: 0x0011C4C3
		public virtual void InterpolateZOff()
		{
			vtkPointInterpolator2D.vtkPointInterpolator2D_InterpolateZOff_05(base.GetCppThis());
		}

		// Token: 0x0600CDC5 RID: 52677
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator2D_InterpolateZOn_06(HandleRef pThis);

		/// <summary>
		/// Specify whether to take the z-coordinate values of the source points as
		/// attributes to be interpolated. This is in addition to any other point
		/// attribute data associated with the source. By default this is enabled.
		/// </summary>
		// Token: 0x0600CDC6 RID: 52678 RVA: 0x0011E2D2 File Offset: 0x0011C4D2
		public virtual void InterpolateZOn()
		{
			vtkPointInterpolator2D.vtkPointInterpolator2D_InterpolateZOn_06(base.GetCppThis());
		}

		// Token: 0x0600CDC7 RID: 52679
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointInterpolator2D_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CDC8 RID: 52680 RVA: 0x0011E2E4 File Offset: 0x0011C4E4
		public override int IsA(string type)
		{
			return vtkPointInterpolator2D.vtkPointInterpolator2D_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600CDC9 RID: 52681
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointInterpolator2D_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CDCA RID: 52682 RVA: 0x0011E304 File Offset: 0x0011C504
		public new static int IsTypeOf(string type)
		{
			return vtkPointInterpolator2D.vtkPointInterpolator2D_IsTypeOf_08(type);
		}

		// Token: 0x0600CDCB RID: 52683
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointInterpolator2D_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CDCC RID: 52684 RVA: 0x0011E320 File Offset: 0x0011C520
		public new vtkPointInterpolator2D NewInstance()
		{
			vtkPointInterpolator2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointInterpolator2D.vtkPointInterpolator2D_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointInterpolator2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CDCD RID: 52685
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointInterpolator2D_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CDCE RID: 52686 RVA: 0x0011E37C File Offset: 0x0011C57C
		public new static vtkPointInterpolator2D SafeDownCast(vtkObjectBase o)
		{
			vtkPointInterpolator2D vtkPointInterpolator2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointInterpolator2D.vtkPointInterpolator2D_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointInterpolator2D = (vtkPointInterpolator2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointInterpolator2D.Register(null);
				}
			}
			return vtkPointInterpolator2D;
		}

		// Token: 0x0600CDCF RID: 52687
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator2D_SetInterpolateZ_12(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether to take the z-coordinate values of the source points as
		/// attributes to be interpolated. This is in addition to any other point
		/// attribute data associated with the source. By default this is enabled.
		/// </summary>
		// Token: 0x0600CDD0 RID: 52688 RVA: 0x0011E3FB File Offset: 0x0011C5FB
		public virtual void SetInterpolateZ(bool _arg)
		{
			vtkPointInterpolator2D.vtkPointInterpolator2D_SetInterpolateZ_12(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CDD1 RID: 52689
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointInterpolator2D_SetZArrayName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of the output array containing z values. This method is
		/// only applicable when InterpolateZ is enabled. By default the output
		/// array name is "Elevation".
		/// </summary>
		// Token: 0x0600CDD2 RID: 52690 RVA: 0x0011E413 File Offset: 0x0011C613
		public virtual void SetZArrayName(string _arg)
		{
			vtkPointInterpolator2D.vtkPointInterpolator2D_SetZArrayName_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F35 RID: 3893
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointInterpolator2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F36 RID: 3894
		public new static readonly string MRClassNameKey = "class vtkPointInterpolator2D";
	}
}
