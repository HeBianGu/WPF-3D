using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFrustumCoverageCuller
	/// </summary>
	/// <remarks>
	///    cull props based on frustum coverage
	///
	/// vtkFrustumCoverageCuller will cull props based on the coverage in
	/// the view frustum. The coverage is computed by enclosing the prop in
	/// a bounding sphere, projecting that to the viewing coordinate system, then
	/// taking a slice through the view frustum at the center of the sphere. This
	/// results in a circle on the plane slice through the view frustum. This
	/// circle is enclosed in a squared, and the fraction of the plane slice that
	/// this square covers is the coverage. This is a number between 0 and 1.
	/// If the number is less than the MinimumCoverage, the allocated render time
	/// for that prop is set to zero. If it is greater than the MaximumCoverage,
	/// the allocated render time is set to 1.0. In between, a linear ramp is used
	/// to convert coverage into allocated render time.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCuller
	/// </seealso>
	// Token: 0x020007DF RID: 2015
	public class vtkFrustumCoverageCuller : vtkCuller
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014B1A RID: 84762 RVA: 0x001D4AC9 File Offset: 0x001D2CC9
		static vtkFrustumCoverageCuller()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFrustumCoverageCuller.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFrustumCoverageCuller"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014B1B RID: 84763 RVA: 0x001D4AF1 File Offset: 0x001D2CF1
		public vtkFrustumCoverageCuller(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014B1C RID: 84764
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFrustumCoverageCuller_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B1D RID: 84765 RVA: 0x001D4B00 File Offset: 0x001D2D00
		public new static vtkFrustumCoverageCuller New()
		{
			vtkFrustumCoverageCuller result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFrustumCoverageCuller)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B1E RID: 84766 RVA: 0x001D4B54 File Offset: 0x001D2D54
		public vtkFrustumCoverageCuller() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014B1F RID: 84767 RVA: 0x001D4B98 File Offset: 0x001D2D98
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014B20 RID: 84768
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFrustumCoverageCuller_GetMaximumCoverage_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum coverage - props with more coverage than this are
		/// given an allocated render time of 1.0 (the maximum)
		/// </summary>
		// Token: 0x06014B21 RID: 84769 RVA: 0x001D4BA4 File Offset: 0x001D2DA4
		public virtual double GetMaximumCoverage()
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_GetMaximumCoverage_01(base.GetCppThis());
		}

		// Token: 0x06014B22 RID: 84770
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFrustumCoverageCuller_GetMinimumCoverage_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum coverage - props with less coverage than this
		/// are given no time to render (they are culled)
		/// </summary>
		// Token: 0x06014B23 RID: 84771 RVA: 0x001D4BC4 File Offset: 0x001D2DC4
		public virtual double GetMinimumCoverage()
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_GetMinimumCoverage_02(base.GetCppThis());
		}

		// Token: 0x06014B24 RID: 84772
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFrustumCoverageCuller_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B25 RID: 84773 RVA: 0x001D4BE4 File Offset: 0x001D2DE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06014B26 RID: 84774
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFrustumCoverageCuller_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B27 RID: 84775 RVA: 0x001D4C04 File Offset: 0x001D2E04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06014B28 RID: 84776
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFrustumCoverageCuller_GetSortingStyle_05(HandleRef pThis);

		/// <summary>
		/// Set the sorting style - none, front-to-back or back-to-front
		/// The default is none
		/// </summary>
		// Token: 0x06014B29 RID: 84777 RVA: 0x001D4C20 File Offset: 0x001D2E20
		public virtual int GetSortingStyle()
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_GetSortingStyle_05(base.GetCppThis());
		}

		// Token: 0x06014B2A RID: 84778
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFrustumCoverageCuller_GetSortingStyleAsString_06(HandleRef pThis);

		/// <summary>
		/// Set the sorting style - none, front-to-back or back-to-front
		/// The default is none
		/// </summary>
		// Token: 0x06014B2B RID: 84779 RVA: 0x001D4C40 File Offset: 0x001D2E40
		public string GetSortingStyleAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_GetSortingStyleAsString_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014B2C RID: 84780
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFrustumCoverageCuller_GetSortingStyleMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Set the sorting style - none, front-to-back or back-to-front
		/// The default is none
		/// </summary>
		// Token: 0x06014B2D RID: 84781 RVA: 0x001D4C7C File Offset: 0x001D2E7C
		public virtual int GetSortingStyleMaxValue()
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_GetSortingStyleMaxValue_07(base.GetCppThis());
		}

		// Token: 0x06014B2E RID: 84782
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFrustumCoverageCuller_GetSortingStyleMinValue_08(HandleRef pThis);

		/// <summary>
		/// Set the sorting style - none, front-to-back or back-to-front
		/// The default is none
		/// </summary>
		// Token: 0x06014B2F RID: 84783 RVA: 0x001D4C9C File Offset: 0x001D2E9C
		public virtual int GetSortingStyleMinValue()
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_GetSortingStyleMinValue_08(base.GetCppThis());
		}

		// Token: 0x06014B30 RID: 84784
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFrustumCoverageCuller_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B31 RID: 84785 RVA: 0x001D4CBC File Offset: 0x001D2EBC
		public override int IsA(string type)
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06014B32 RID: 84786
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFrustumCoverageCuller_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B33 RID: 84787 RVA: 0x001D4CDC File Offset: 0x001D2EDC
		public new static int IsTypeOf(string type)
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_IsTypeOf_10(type);
		}

		// Token: 0x06014B34 RID: 84788
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFrustumCoverageCuller_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B35 RID: 84789 RVA: 0x001D4CF8 File Offset: 0x001D2EF8
		public new vtkFrustumCoverageCuller NewInstance()
		{
			vtkFrustumCoverageCuller result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFrustumCoverageCuller)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014B36 RID: 84790
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFrustumCoverageCuller_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B37 RID: 84791 RVA: 0x001D4D54 File Offset: 0x001D2F54
		public new static vtkFrustumCoverageCuller SafeDownCast(vtkObjectBase o)
		{
			vtkFrustumCoverageCuller vtkFrustumCoverageCuller = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFrustumCoverageCuller = (vtkFrustumCoverageCuller)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFrustumCoverageCuller.Register(null);
				}
			}
			return vtkFrustumCoverageCuller;
		}

		// Token: 0x06014B38 RID: 84792
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrustumCoverageCuller_SetMaximumCoverage_14(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the maximum coverage - props with more coverage than this are
		/// given an allocated render time of 1.0 (the maximum)
		/// </summary>
		// Token: 0x06014B39 RID: 84793 RVA: 0x001D4DD3 File Offset: 0x001D2FD3
		public virtual void SetMaximumCoverage(double _arg)
		{
			vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_SetMaximumCoverage_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06014B3A RID: 84794
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrustumCoverageCuller_SetMinimumCoverage_15(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the minimum coverage - props with less coverage than this
		/// are given no time to render (they are culled)
		/// </summary>
		// Token: 0x06014B3B RID: 84795 RVA: 0x001D4DE3 File Offset: 0x001D2FE3
		public virtual void SetMinimumCoverage(double _arg)
		{
			vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_SetMinimumCoverage_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06014B3C RID: 84796
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrustumCoverageCuller_SetSortingStyle_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the sorting style - none, front-to-back or back-to-front
		/// The default is none
		/// </summary>
		// Token: 0x06014B3D RID: 84797 RVA: 0x001D4DF3 File Offset: 0x001D2FF3
		public virtual void SetSortingStyle(int _arg)
		{
			vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_SetSortingStyle_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06014B3E RID: 84798
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrustumCoverageCuller_SetSortingStyleToBackToFront_17(HandleRef pThis);

		/// <summary>
		/// Set the sorting style - none, front-to-back or back-to-front
		/// The default is none
		/// </summary>
		// Token: 0x06014B3F RID: 84799 RVA: 0x001D4E03 File Offset: 0x001D3003
		public void SetSortingStyleToBackToFront()
		{
			vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_SetSortingStyleToBackToFront_17(base.GetCppThis());
		}

		// Token: 0x06014B40 RID: 84800
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrustumCoverageCuller_SetSortingStyleToFrontToBack_18(HandleRef pThis);

		/// <summary>
		/// Set the sorting style - none, front-to-back or back-to-front
		/// The default is none
		/// </summary>
		// Token: 0x06014B41 RID: 84801 RVA: 0x001D4E12 File Offset: 0x001D3012
		public void SetSortingStyleToFrontToBack()
		{
			vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_SetSortingStyleToFrontToBack_18(base.GetCppThis());
		}

		// Token: 0x06014B42 RID: 84802
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrustumCoverageCuller_SetSortingStyleToNone_19(HandleRef pThis);

		/// <summary>
		/// Set the sorting style - none, front-to-back or back-to-front
		/// The default is none
		/// </summary>
		// Token: 0x06014B43 RID: 84803 RVA: 0x001D4E21 File Offset: 0x001D3021
		public void SetSortingStyleToNone()
		{
			vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_SetSortingStyleToNone_19(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017EB RID: 6123
		public new const string MRFullTypeName = "Kitware.VTK.vtkFrustumCoverageCuller";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017EC RID: 6124
		public new static readonly string MRClassNameKey = "class vtkFrustumCoverageCuller";
	}
}
