using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageRFFT
	/// </summary>
	/// <remarks>
	///     Reverse Fast Fourier Transform.
	///
	/// vtkImageRFFT implements the reverse fast Fourier transform.  The input
	/// can have real or complex data in any components and data types, but
	/// the output is always complex doubles with real values in component0, and
	/// imaginary values in component1.  The filter is fastest for images that
	/// have power of two sizes.  The filter uses butterfly filters for each
	/// prime factor of the dimension.  This makes images with prime number dimensions
	/// (i.e. 17x17) much slower to compute.  Multi dimensional (i.e volumes)
	/// FFT's are decomposed so that each axis executes in series.
	/// In most cases the RFFT will produce an image whose imaginary values are all
	/// zero's. In this case vtkImageExtractComponents can be used to remove
	/// this imaginary components leaving only the real image.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageExtractComponenents
	/// </seealso>
	// Token: 0x02000262 RID: 610
	public class vtkImageRFFT : vtkImageFourierFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600703C RID: 28732 RVA: 0x000A1AA1 File Offset: 0x0009FCA1
		static vtkImageRFFT()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageRFFT.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageRFFT"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600703D RID: 28733 RVA: 0x000A1AC9 File Offset: 0x0009FCC9
		public vtkImageRFFT(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600703E RID: 28734
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRFFT_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600703F RID: 28735 RVA: 0x000A1AD8 File Offset: 0x0009FCD8
		public new static vtkImageRFFT New()
		{
			vtkImageRFFT result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRFFT.vtkImageRFFT_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRFFT)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007040 RID: 28736 RVA: 0x000A1B2C File Offset: 0x0009FD2C
		public vtkImageRFFT() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageRFFT.vtkImageRFFT_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007041 RID: 28737 RVA: 0x000A1B70 File Offset: 0x0009FD70
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007042 RID: 28738
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageRFFT_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007043 RID: 28739 RVA: 0x000A1B7C File Offset: 0x0009FD7C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageRFFT.vtkImageRFFT_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06007044 RID: 28740
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageRFFT_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007045 RID: 28741 RVA: 0x000A1B9C File Offset: 0x0009FD9C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageRFFT.vtkImageRFFT_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06007046 RID: 28742
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageRFFT_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007047 RID: 28743 RVA: 0x000A1BB8 File Offset: 0x0009FDB8
		public override int IsA(string type)
		{
			return vtkImageRFFT.vtkImageRFFT_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06007048 RID: 28744
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageRFFT_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007049 RID: 28745 RVA: 0x000A1BD8 File Offset: 0x0009FDD8
		public new static int IsTypeOf(string type)
		{
			return vtkImageRFFT.vtkImageRFFT_IsTypeOf_04(type);
		}

		// Token: 0x0600704A RID: 28746
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRFFT_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600704B RID: 28747 RVA: 0x000A1BF4 File Offset: 0x0009FDF4
		public new vtkImageRFFT NewInstance()
		{
			vtkImageRFFT result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRFFT.vtkImageRFFT_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRFFT)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600704C RID: 28748
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRFFT_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600704D RID: 28749 RVA: 0x000A1C50 File Offset: 0x0009FE50
		public new static vtkImageRFFT SafeDownCast(vtkObjectBase o)
		{
			vtkImageRFFT vtkImageRFFT = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRFFT.vtkImageRFFT_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageRFFT = (vtkImageRFFT)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageRFFT.Register(null);
				}
			}
			return vtkImageRFFT;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009B9 RID: 2489
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageRFFT";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009BA RID: 2490
		public new static readonly string MRClassNameKey = "class vtkImageRFFT";
	}
}
