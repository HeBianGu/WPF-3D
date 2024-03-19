using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageFFT
	/// </summary>
	/// <remarks>
	///     Fast Fourier Transform.
	///
	/// vtkImageFFT implements a fast Fourier transform.  The input
	/// can have real or complex data in any components and data types, but
	/// the output is always complex doubles with real values in component0, and
	/// imaginary values in component1.  The filter is fastest for images that
	/// have power of two sizes.  The filter uses a butterfly diagram for each
	/// prime factor of the dimension.  This makes images with prime number dimensions
	/// (i.e. 17x17) much slower to compute.  Multi dimensional (i.e volumes)
	/// FFT's are decomposed so that each axis executes serially.
	/// </remarks>
	// Token: 0x0200025E RID: 606
	public class vtkImageFFT : vtkImageFourierFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006FC4 RID: 28612 RVA: 0x000A0F87 File Offset: 0x0009F187
		static vtkImageFFT()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageFFT.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageFFT"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006FC5 RID: 28613 RVA: 0x000A0FAF File Offset: 0x0009F1AF
		public vtkImageFFT(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006FC6 RID: 28614
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageFFT_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FC7 RID: 28615 RVA: 0x000A0FC0 File Offset: 0x0009F1C0
		public new static vtkImageFFT New()
		{
			vtkImageFFT result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageFFT.vtkImageFFT_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageFFT)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FC8 RID: 28616 RVA: 0x000A1014 File Offset: 0x0009F214
		public vtkImageFFT() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageFFT.vtkImageFFT_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006FC9 RID: 28617 RVA: 0x000A1058 File Offset: 0x0009F258
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006FCA RID: 28618
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageFFT_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FCB RID: 28619 RVA: 0x000A1064 File Offset: 0x0009F264
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageFFT.vtkImageFFT_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06006FCC RID: 28620
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageFFT_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FCD RID: 28621 RVA: 0x000A1084 File Offset: 0x0009F284
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageFFT.vtkImageFFT_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006FCE RID: 28622
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageFFT_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FCF RID: 28623 RVA: 0x000A10A0 File Offset: 0x0009F2A0
		public override int IsA(string type)
		{
			return vtkImageFFT.vtkImageFFT_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06006FD0 RID: 28624
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageFFT_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FD1 RID: 28625 RVA: 0x000A10C0 File Offset: 0x0009F2C0
		public new static int IsTypeOf(string type)
		{
			return vtkImageFFT.vtkImageFFT_IsTypeOf_04(type);
		}

		// Token: 0x06006FD2 RID: 28626
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageFFT_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FD3 RID: 28627 RVA: 0x000A10DC File Offset: 0x0009F2DC
		public new vtkImageFFT NewInstance()
		{
			vtkImageFFT result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageFFT.vtkImageFFT_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageFFT)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006FD4 RID: 28628
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageFFT_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FD5 RID: 28629 RVA: 0x000A1138 File Offset: 0x0009F338
		public new static vtkImageFFT SafeDownCast(vtkObjectBase o)
		{
			vtkImageFFT vtkImageFFT = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageFFT.vtkImageFFT_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageFFT = (vtkImageFFT)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageFFT.Register(null);
				}
			}
			return vtkImageFFT;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009B1 RID: 2481
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageFFT";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009B2 RID: 2482
		public new static readonly string MRClassNameKey = "class vtkImageFFT";
	}
}
