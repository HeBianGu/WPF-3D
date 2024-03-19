using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVoronoiKernel
	/// </summary>
	/// <remarks>
	///    a Voronoi interpolation kernel
	///
	///
	/// vtkVoronoiKernel is an interpolation kernel that simply returns the
	/// closest point to a point to be interpolated. A single weight is returned
	/// with value=1.0.
	///
	/// @warning
	/// In degenerate cases (where a point x is equidistance from more than one
	/// point) the kernel basis arbitrarily chooses one of the equidistant points.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInterpolationKernel vtkGeneralizedKernel vtkProbabilisticVoronoiKernel
	/// </seealso>
	// Token: 0x02000466 RID: 1126
	public class vtkVoronoiKernel : vtkInterpolationKernel
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D14A RID: 53578 RVA: 0x00122FC8 File Offset: 0x001211C8
		static vtkVoronoiKernel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVoronoiKernel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoronoiKernel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D14B RID: 53579 RVA: 0x00122FF0 File Offset: 0x001211F0
		public vtkVoronoiKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D14C RID: 53580
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoronoiKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D14D RID: 53581 RVA: 0x00123000 File Offset: 0x00121200
		public new static vtkVoronoiKernel New()
		{
			vtkVoronoiKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoronoiKernel.vtkVoronoiKernel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoronoiKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D14E RID: 53582 RVA: 0x00123054 File Offset: 0x00121254
		public vtkVoronoiKernel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVoronoiKernel.vtkVoronoiKernel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D14F RID: 53583 RVA: 0x00123098 File Offset: 0x00121298
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D150 RID: 53584
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoronoiKernel_ComputeBasis_01(HandleRef pThis, IntPtr x, HandleRef pIds, long ptId);

		/// <summary>
		/// Given a point x (and optional associated ptId), determine the points
		/// around x which form an interpolation basis. The user must provide the
		/// vtkIdList pIds, which will be dynamically resized as necessary. The
		/// method returns the number of points in the basis. Typically this method
		/// is called before ComputeWeights().
		/// </summary>
		// Token: 0x0600D151 RID: 53585 RVA: 0x001230A4 File Offset: 0x001212A4
		public override long ComputeBasis(IntPtr x, vtkIdList pIds, long ptId)
		{
			return vtkVoronoiKernel.vtkVoronoiKernel_ComputeBasis_01(base.GetCppThis(), x, (pIds == null) ? default(HandleRef) : pIds.GetCppThis(), ptId);
		}

		// Token: 0x0600D152 RID: 53586
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoronoiKernel_ComputeWeights_02(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef weights);

		/// <summary>
		/// Given a point x, and a list of basis points pIds, compute interpolation
		/// weights associated with these basis points.  Note that both the nearby
		/// basis points list pIds and the weights array are provided by the caller
		/// of the method, and may be dynamically resized as necessary. Typically
		/// this method is called after ComputeBasis(), although advanced users can
		/// invoke ComputeWeights() and provide the interpolation basis points pIds
		/// directly.
		/// </summary>
		// Token: 0x0600D153 RID: 53587 RVA: 0x001230DC File Offset: 0x001212DC
		public override long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray weights)
		{
			return vtkVoronoiKernel.vtkVoronoiKernel_ComputeWeights_02(base.GetCppThis(), x, (pIds == null) ? default(HandleRef) : pIds.GetCppThis(), (weights == null) ? default(HandleRef) : weights.GetCppThis());
		}

		// Token: 0x0600D154 RID: 53588
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoronoiKernel_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D155 RID: 53589 RVA: 0x00123128 File Offset: 0x00121328
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVoronoiKernel.vtkVoronoiKernel_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600D156 RID: 53590
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoronoiKernel_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D157 RID: 53591 RVA: 0x00123148 File Offset: 0x00121348
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVoronoiKernel.vtkVoronoiKernel_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600D158 RID: 53592
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoronoiKernel_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D159 RID: 53593 RVA: 0x00123164 File Offset: 0x00121364
		public override int IsA(string type)
		{
			return vtkVoronoiKernel.vtkVoronoiKernel_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600D15A RID: 53594
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoronoiKernel_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D15B RID: 53595 RVA: 0x00123184 File Offset: 0x00121384
		public new static int IsTypeOf(string type)
		{
			return vtkVoronoiKernel.vtkVoronoiKernel_IsTypeOf_06(type);
		}

		// Token: 0x0600D15C RID: 53596
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoronoiKernel_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D15D RID: 53597 RVA: 0x001231A0 File Offset: 0x001213A0
		public new vtkVoronoiKernel NewInstance()
		{
			vtkVoronoiKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoronoiKernel.vtkVoronoiKernel_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoronoiKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D15E RID: 53598
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoronoiKernel_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D15F RID: 53599 RVA: 0x001231FC File Offset: 0x001213FC
		public new static vtkVoronoiKernel SafeDownCast(vtkObjectBase o)
		{
			vtkVoronoiKernel vtkVoronoiKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoronoiKernel.vtkVoronoiKernel_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVoronoiKernel = (vtkVoronoiKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVoronoiKernel.Register(null);
				}
			}
			return vtkVoronoiKernel;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F6B RID: 3947
		public new const string MRFullTypeName = "Kitware.VTK.vtkVoronoiKernel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F6C RID: 3948
		public new static readonly string MRClassNameKey = "class vtkVoronoiKernel";
	}
}
