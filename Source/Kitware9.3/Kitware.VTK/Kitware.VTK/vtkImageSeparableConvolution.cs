using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageSeparableConvolution
	/// </summary>
	/// <remarks>
	///     3 1D convolutions on an image
	///
	/// vtkImageSeparableConvolution performs a convolution along the X, Y,
	/// and Z axes of an image, based on the three different 1D convolution
	/// kernels.  The kernels must be of odd size, and are considered to be
	/// centered at (int)((kernelsize - 1) / 2.0 ).  If a kernel is nullptr,
	/// that dimension is skipped.  This filter is designed to efficiently
	/// convolve separable filters that can be decomposed into 1 or more 1D
	/// convolutions.  It also handles arbitrarily large kernel sizes, and
	/// uses edge replication to handle boundaries.
	/// </remarks>
	// Token: 0x0200048D RID: 1165
	public class vtkImageSeparableConvolution : vtkImageDecomposeFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D5B3 RID: 54707 RVA: 0x00129731 File Offset: 0x00127931
		static vtkImageSeparableConvolution()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSeparableConvolution.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSeparableConvolution"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D5B4 RID: 54708 RVA: 0x00129759 File Offset: 0x00127959
		public vtkImageSeparableConvolution(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D5B5 RID: 54709
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSeparableConvolution_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5B6 RID: 54710 RVA: 0x00129768 File Offset: 0x00127968
		public new static vtkImageSeparableConvolution New()
		{
			vtkImageSeparableConvolution result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSeparableConvolution.vtkImageSeparableConvolution_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSeparableConvolution)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5B7 RID: 54711 RVA: 0x001297BC File Offset: 0x001279BC
		public vtkImageSeparableConvolution() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageSeparableConvolution.vtkImageSeparableConvolution_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D5B8 RID: 54712 RVA: 0x00129800 File Offset: 0x00127A00
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D5B9 RID: 54713
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageSeparableConvolution_GetMTime_01(HandleRef pThis);

		/// <summary>
		/// Overload standard modified time function. If kernel arrays are modified,
		/// then this object is modified as well.
		/// </summary>
		// Token: 0x0600D5BA RID: 54714 RVA: 0x0012980C File Offset: 0x00127A0C
		public override ulong GetMTime()
		{
			return vtkImageSeparableConvolution.vtkImageSeparableConvolution_GetMTime_01(base.GetCppThis());
		}

		// Token: 0x0600D5BB RID: 54715
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSeparableConvolution_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5BC RID: 54716 RVA: 0x0012982C File Offset: 0x00127A2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageSeparableConvolution.vtkImageSeparableConvolution_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600D5BD RID: 54717
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSeparableConvolution_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5BE RID: 54718 RVA: 0x0012984C File Offset: 0x00127A4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageSeparableConvolution.vtkImageSeparableConvolution_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600D5BF RID: 54719
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSeparableConvolution_GetXKernel_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5C0 RID: 54720 RVA: 0x00129868 File Offset: 0x00127A68
		public virtual vtkFloatArray GetXKernel()
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSeparableConvolution.vtkImageSeparableConvolution_GetXKernel_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		// Token: 0x0600D5C1 RID: 54721
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSeparableConvolution_GetYKernel_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5C2 RID: 54722 RVA: 0x001298D8 File Offset: 0x00127AD8
		public virtual vtkFloatArray GetYKernel()
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSeparableConvolution.vtkImageSeparableConvolution_GetYKernel_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		// Token: 0x0600D5C3 RID: 54723
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSeparableConvolution_GetZKernel_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5C4 RID: 54724 RVA: 0x00129948 File Offset: 0x00127B48
		public virtual vtkFloatArray GetZKernel()
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSeparableConvolution.vtkImageSeparableConvolution_GetZKernel_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		// Token: 0x0600D5C5 RID: 54725
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSeparableConvolution_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5C6 RID: 54726 RVA: 0x001299B8 File Offset: 0x00127BB8
		public override int IsA(string type)
		{
			return vtkImageSeparableConvolution.vtkImageSeparableConvolution_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600D5C7 RID: 54727
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSeparableConvolution_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5C8 RID: 54728 RVA: 0x001299D8 File Offset: 0x00127BD8
		public new static int IsTypeOf(string type)
		{
			return vtkImageSeparableConvolution.vtkImageSeparableConvolution_IsTypeOf_08(type);
		}

		// Token: 0x0600D5C9 RID: 54729
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSeparableConvolution_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5CA RID: 54730 RVA: 0x001299F4 File Offset: 0x00127BF4
		public new vtkImageSeparableConvolution NewInstance()
		{
			vtkImageSeparableConvolution result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSeparableConvolution.vtkImageSeparableConvolution_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSeparableConvolution)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D5CB RID: 54731
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSeparableConvolution_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5CC RID: 54732 RVA: 0x00129A50 File Offset: 0x00127C50
		public new static vtkImageSeparableConvolution SafeDownCast(vtkObjectBase o)
		{
			vtkImageSeparableConvolution vtkImageSeparableConvolution = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSeparableConvolution.vtkImageSeparableConvolution_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSeparableConvolution = (vtkImageSeparableConvolution)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSeparableConvolution.Register(null);
				}
			}
			return vtkImageSeparableConvolution;
		}

		// Token: 0x0600D5CD RID: 54733
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSeparableConvolution_SetXKernel_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5CE RID: 54734 RVA: 0x00129AD0 File Offset: 0x00127CD0
		public virtual void SetXKernel(vtkFloatArray arg0)
		{
			vtkImageSeparableConvolution.vtkImageSeparableConvolution_SetXKernel_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D5CF RID: 54735
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSeparableConvolution_SetYKernel_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5D0 RID: 54736 RVA: 0x00129B00 File Offset: 0x00127D00
		public virtual void SetYKernel(vtkFloatArray arg0)
		{
			vtkImageSeparableConvolution.vtkImageSeparableConvolution_SetYKernel_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D5D1 RID: 54737
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSeparableConvolution_SetZKernel_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D5D2 RID: 54738 RVA: 0x00129B30 File Offset: 0x00127D30
		public virtual void SetZKernel(vtkFloatArray arg0)
		{
			vtkImageSeparableConvolution.vtkImageSeparableConvolution_SetZKernel_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FC2 RID: 4034
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSeparableConvolution";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FC3 RID: 4035
		public new static readonly string MRClassNameKey = "class vtkImageSeparableConvolution";
	}
}
