using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSplineGraphEdges
	/// </summary>
	/// <remarks>
	///    subsample graph edges to make smooth curves
	///
	///
	/// vtkSplineGraphEdges uses a vtkSpline to make edges into nicely sampled
	/// splines. By default, the filter will use an optimized b-spline.
	/// Otherwise, it will use a custom vtkSpline instance set by the user.
	/// </remarks>
	// Token: 0x0200029D RID: 669
	public class vtkSplineGraphEdges : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060078E2 RID: 30946 RVA: 0x000AE3AF File Offset: 0x000AC5AF
		static vtkSplineGraphEdges()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSplineGraphEdges.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplineGraphEdges"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060078E3 RID: 30947 RVA: 0x000AE3D7 File Offset: 0x000AC5D7
		public vtkSplineGraphEdges(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060078E4 RID: 30948
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineGraphEdges_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078E5 RID: 30949 RVA: 0x000AE3E8 File Offset: 0x000AC5E8
		public new static vtkSplineGraphEdges New()
		{
			vtkSplineGraphEdges result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineGraphEdges.vtkSplineGraphEdges_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineGraphEdges)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078E6 RID: 30950 RVA: 0x000AE43C File Offset: 0x000AC63C
		public vtkSplineGraphEdges() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSplineGraphEdges.vtkSplineGraphEdges_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060078E7 RID: 30951 RVA: 0x000AE480 File Offset: 0x000AC680
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060078E8 RID: 30952
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplineGraphEdges_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078E9 RID: 30953 RVA: 0x000AE48C File Offset: 0x000AC68C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSplineGraphEdges.vtkSplineGraphEdges_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060078EA RID: 30954
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplineGraphEdges_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078EB RID: 30955 RVA: 0x000AE4AC File Offset: 0x000AC6AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSplineGraphEdges.vtkSplineGraphEdges_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060078EC RID: 30956
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplineGraphEdges_GetNumberOfSubdivisions_03(HandleRef pThis);

		/// <summary>
		/// The number of subdivisions in the spline.
		/// </summary>
		// Token: 0x060078ED RID: 30957 RVA: 0x000AE4C8 File Offset: 0x000AC6C8
		public virtual long GetNumberOfSubdivisions()
		{
			return vtkSplineGraphEdges.vtkSplineGraphEdges_GetNumberOfSubdivisions_03(base.GetCppThis());
		}

		// Token: 0x060078EE RID: 30958
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineGraphEdges_GetSpline_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If SplineType is CUSTOM, uses this spline.
		/// </summary>
		// Token: 0x060078EF RID: 30959 RVA: 0x000AE4E8 File Offset: 0x000AC6E8
		public virtual vtkSpline GetSpline()
		{
			vtkSpline vtkSpline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineGraphEdges.vtkSplineGraphEdges_GetSpline_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060078F0 RID: 30960
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineGraphEdges_GetSplineType_05(HandleRef pThis);

		/// <summary>
		/// Spline type used by the filter.
		/// BSPLINE (0) - Use optimized b-spline (default).
		/// CUSTOM (1) - Use spline set with SetSpline.
		/// </summary>
		// Token: 0x060078F1 RID: 30961 RVA: 0x000AE558 File Offset: 0x000AC758
		public virtual int GetSplineType()
		{
			return vtkSplineGraphEdges.vtkSplineGraphEdges_GetSplineType_05(base.GetCppThis());
		}

		// Token: 0x060078F2 RID: 30962
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineGraphEdges_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078F3 RID: 30963 RVA: 0x000AE578 File Offset: 0x000AC778
		public override int IsA(string type)
		{
			return vtkSplineGraphEdges.vtkSplineGraphEdges_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060078F4 RID: 30964
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineGraphEdges_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078F5 RID: 30965 RVA: 0x000AE598 File Offset: 0x000AC798
		public new static int IsTypeOf(string type)
		{
			return vtkSplineGraphEdges.vtkSplineGraphEdges_IsTypeOf_07(type);
		}

		// Token: 0x060078F6 RID: 30966
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineGraphEdges_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078F7 RID: 30967 RVA: 0x000AE5B4 File Offset: 0x000AC7B4
		public new vtkSplineGraphEdges NewInstance()
		{
			vtkSplineGraphEdges result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineGraphEdges.vtkSplineGraphEdges_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineGraphEdges)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060078F8 RID: 30968
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineGraphEdges_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060078F9 RID: 30969 RVA: 0x000AE610 File Offset: 0x000AC810
		public new static vtkSplineGraphEdges SafeDownCast(vtkObjectBase o)
		{
			vtkSplineGraphEdges vtkSplineGraphEdges = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineGraphEdges.vtkSplineGraphEdges_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSplineGraphEdges = (vtkSplineGraphEdges)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSplineGraphEdges.Register(null);
				}
			}
			return vtkSplineGraphEdges;
		}

		// Token: 0x060078FA RID: 30970
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineGraphEdges_SetNumberOfSubdivisions_11(HandleRef pThis, long _arg);

		/// <summary>
		/// The number of subdivisions in the spline.
		/// </summary>
		// Token: 0x060078FB RID: 30971 RVA: 0x000AE68F File Offset: 0x000AC88F
		public virtual void SetNumberOfSubdivisions(long _arg)
		{
			vtkSplineGraphEdges.vtkSplineGraphEdges_SetNumberOfSubdivisions_11(base.GetCppThis(), _arg);
		}

		// Token: 0x060078FC RID: 30972
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineGraphEdges_SetSpline_12(HandleRef pThis, HandleRef s);

		/// <summary>
		/// If SplineType is CUSTOM, uses this spline.
		/// </summary>
		// Token: 0x060078FD RID: 30973 RVA: 0x000AE6A0 File Offset: 0x000AC8A0
		public virtual void SetSpline(vtkSpline s)
		{
			vtkSplineGraphEdges.vtkSplineGraphEdges_SetSpline_12(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		// Token: 0x060078FE RID: 30974
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineGraphEdges_SetSplineType_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Spline type used by the filter.
		/// BSPLINE (0) - Use optimized b-spline (default).
		/// CUSTOM (1) - Use spline set with SetSpline.
		/// </summary>
		// Token: 0x060078FF RID: 30975 RVA: 0x000AE6CF File Offset: 0x000AC8CF
		public virtual void SetSplineType(int _arg)
		{
			vtkSplineGraphEdges.vtkSplineGraphEdges_SetSplineType_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A49 RID: 2633
		public new const string MRFullTypeName = "Kitware.VTK.vtkSplineGraphEdges";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A4A RID: 2634
		public new static readonly string MRClassNameKey = "class vtkSplineGraphEdges";

		/// <summary>
		/// If SplineType is CUSTOM, uses this spline.
		/// </summary>
		// Token: 0x0200029E RID: 670
		public enum BSPLINE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000A4C RID: 2636
			BSPLINE,
			/// <summary>enum member</summary>
			// Token: 0x04000A4D RID: 2637
			CUSTOM
		}
	}
}
