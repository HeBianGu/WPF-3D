using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageLaplacian
	/// </summary>
	/// <remarks>
	///    Computes divergence of gradient.
	///
	/// vtkImageLaplacian computes the Laplacian (like a second derivative)
	/// of a scalar image.  The operation is the same as taking the
	/// divergence after a gradient.  Boundaries are handled, so the input
	/// is the same as the output.
	/// Dimensionality determines how the input regions are interpreted.
	/// (images, or volumes). The Dimensionality defaults to two.
	/// </remarks>
	// Token: 0x02000489 RID: 1161
	public class vtkImageLaplacian : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D55D RID: 54621 RVA: 0x00128DBF File Offset: 0x00126FBF
		static vtkImageLaplacian()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageLaplacian.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageLaplacian"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D55E RID: 54622 RVA: 0x00128DE7 File Offset: 0x00126FE7
		public vtkImageLaplacian(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D55F RID: 54623
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageLaplacian_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D560 RID: 54624 RVA: 0x00128DF8 File Offset: 0x00126FF8
		public new static vtkImageLaplacian New()
		{
			vtkImageLaplacian result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageLaplacian.vtkImageLaplacian_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageLaplacian)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D561 RID: 54625 RVA: 0x00128E4C File Offset: 0x0012704C
		public vtkImageLaplacian() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageLaplacian.vtkImageLaplacian_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D562 RID: 54626 RVA: 0x00128E90 File Offset: 0x00127090
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D563 RID: 54627
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageLaplacian_GetDimensionality_01(HandleRef pThis);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...)
		/// </summary>
		// Token: 0x0600D564 RID: 54628 RVA: 0x00128E9C File Offset: 0x0012709C
		public virtual int GetDimensionality()
		{
			return vtkImageLaplacian.vtkImageLaplacian_GetDimensionality_01(base.GetCppThis());
		}

		// Token: 0x0600D565 RID: 54629
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageLaplacian_GetDimensionalityMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...)
		/// </summary>
		// Token: 0x0600D566 RID: 54630 RVA: 0x00128EBC File Offset: 0x001270BC
		public virtual int GetDimensionalityMaxValue()
		{
			return vtkImageLaplacian.vtkImageLaplacian_GetDimensionalityMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600D567 RID: 54631
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageLaplacian_GetDimensionalityMinValue_03(HandleRef pThis);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...)
		/// </summary>
		// Token: 0x0600D568 RID: 54632 RVA: 0x00128EDC File Offset: 0x001270DC
		public virtual int GetDimensionalityMinValue()
		{
			return vtkImageLaplacian.vtkImageLaplacian_GetDimensionalityMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600D569 RID: 54633
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageLaplacian_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D56A RID: 54634 RVA: 0x00128EFC File Offset: 0x001270FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageLaplacian.vtkImageLaplacian_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600D56B RID: 54635
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageLaplacian_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D56C RID: 54636 RVA: 0x00128F1C File Offset: 0x0012711C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageLaplacian.vtkImageLaplacian_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600D56D RID: 54637
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageLaplacian_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D56E RID: 54638 RVA: 0x00128F38 File Offset: 0x00127138
		public override int IsA(string type)
		{
			return vtkImageLaplacian.vtkImageLaplacian_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600D56F RID: 54639
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageLaplacian_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D570 RID: 54640 RVA: 0x00128F58 File Offset: 0x00127158
		public new static int IsTypeOf(string type)
		{
			return vtkImageLaplacian.vtkImageLaplacian_IsTypeOf_07(type);
		}

		// Token: 0x0600D571 RID: 54641
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageLaplacian_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D572 RID: 54642 RVA: 0x00128F74 File Offset: 0x00127174
		public new vtkImageLaplacian NewInstance()
		{
			vtkImageLaplacian result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageLaplacian.vtkImageLaplacian_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageLaplacian)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D573 RID: 54643
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageLaplacian_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D574 RID: 54644 RVA: 0x00128FD0 File Offset: 0x001271D0
		public new static vtkImageLaplacian SafeDownCast(vtkObjectBase o)
		{
			vtkImageLaplacian vtkImageLaplacian = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageLaplacian.vtkImageLaplacian_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageLaplacian = (vtkImageLaplacian)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageLaplacian.Register(null);
				}
			}
			return vtkImageLaplacian;
		}

		// Token: 0x0600D575 RID: 54645
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageLaplacian_SetDimensionality_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...)
		/// </summary>
		// Token: 0x0600D576 RID: 54646 RVA: 0x0012904F File Offset: 0x0012724F
		public virtual void SetDimensionality(int _arg)
		{
			vtkImageLaplacian.vtkImageLaplacian_SetDimensionality_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FBA RID: 4026
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageLaplacian";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FBB RID: 4027
		public new static readonly string MRClassNameKey = "class vtkImageLaplacian";
	}
}
