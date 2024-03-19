using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkFFT
	/// </summary>
	/// <remarks>
	///  perform Discrete Fourier Transforms
	///
	/// vtkFFT provides methods to perform Discrete Fourier Transforms (DFT).
	/// These include providing forward and reverse Fourier transforms.
	/// The current implementation uses the third-party library kissfft.
	///
	/// The terminology tries to follow the Numpy terminology, that is :
	///  - Fft means the Fast Fourier Transform algorithm
	///  - Prefix `R` stands for Real (meaning optimized function for real inputs)
	///  - Prefix `I` stands for Inverse
	///
	/// Some functions provides pointer-based version of themself in order to
	/// prevent copying memory when possible.
	/// </remarks>
	// Token: 0x02000B13 RID: 2835
	public class vtkFFT : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DCE1 RID: 122081 RVA: 0x002A162F File Offset: 0x0029F82F
		static vtkFFT()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFFT.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFFT"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DCE2 RID: 122082 RVA: 0x002A1657 File Offset: 0x0029F857
		public vtkFFT(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DCE3 RID: 122083
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFFT_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a window generator function, create a symmetric 2D kernel.
		/// @c kernel is the pointer to the raw 2D data array.
		/// </summary>
		// Token: 0x0601DCE4 RID: 122084 RVA: 0x002A1668 File Offset: 0x0029F868
		public new static vtkFFT New()
		{
			vtkFFT result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFFT.vtkFFT_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFFT)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Given a window generator function, create a symmetric 2D kernel.
		/// @c kernel is the pointer to the raw 2D data array.
		/// </summary>
		// Token: 0x0601DCE5 RID: 122085 RVA: 0x002A16BC File Offset: 0x0029F8BC
		public vtkFFT() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFFT.vtkFFT_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DCE6 RID: 122086 RVA: 0x002A1700 File Offset: 0x0029F900
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DCE7 RID: 122087
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFFT_BartlettGenerator_01(ulong x, ulong size);

		/// <summary>
		/// Window generator functions. Implementation only needs to be valid for x E [0; size / 2]
		/// because kernels are symmetric by definitions. This point is very important for some
		/// kernels like Bartlett for example.
		///
		/// @warning Most generators need size &gt; 1 !
		///
		/// Can be used with @c GenerateKernel1D and @c GenerateKernel2D for generating full kernels.
		/// </summary>
		// Token: 0x0601DCE8 RID: 122088 RVA: 0x002A170C File Offset: 0x0029F90C
		public static double BartlettGenerator(ulong x, ulong size)
		{
			return vtkFFT.vtkFFT_BartlettGenerator_01(x, size);
		}

		// Token: 0x0601DCE9 RID: 122089
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFFT_BlackmanGenerator_02(ulong x, ulong size);

		/// <summary>
		/// Window generator functions. Implementation only needs to be valid for x E [0; size / 2]
		/// because kernels are symmetric by definitions. This point is very important for some
		/// kernels like Bartlett for example.
		///
		/// @warning Most generators need size &gt; 1 !
		///
		/// Can be used with @c GenerateKernel1D and @c GenerateKernel2D for generating full kernels.
		/// </summary>
		// Token: 0x0601DCEA RID: 122090 RVA: 0x002A1728 File Offset: 0x0029F928
		public static double BlackmanGenerator(ulong x, ulong size)
		{
			return vtkFFT.vtkFFT_BlackmanGenerator_02(x, size);
		}

		// Token: 0x0601DCEB RID: 122091
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFFT_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Given a window generator function, create a symmetric 2D kernel.
		/// @c kernel is the pointer to the raw 2D data array.
		/// </summary>
		// Token: 0x0601DCEC RID: 122092 RVA: 0x002A1744 File Offset: 0x0029F944
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFFT.vtkFFT_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601DCED RID: 122093
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFFT_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Given a window generator function, create a symmetric 2D kernel.
		/// @c kernel is the pointer to the raw 2D data array.
		/// </summary>
		// Token: 0x0601DCEE RID: 122094 RVA: 0x002A1764 File Offset: 0x0029F964
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFFT.vtkFFT_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601DCEF RID: 122095
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFFT_HanningGenerator_05(ulong x, ulong size);

		/// <summary>
		/// Window generator functions. Implementation only needs to be valid for x E [0; size / 2]
		/// because kernels are symmetric by definitions. This point is very important for some
		/// kernels like Bartlett for example.
		///
		/// @warning Most generators need size &gt; 1 !
		///
		/// Can be used with @c GenerateKernel1D and @c GenerateKernel2D for generating full kernels.
		/// </summary>
		// Token: 0x0601DCF0 RID: 122096 RVA: 0x002A1780 File Offset: 0x0029F980
		public static double HanningGenerator(ulong x, ulong size)
		{
			return vtkFFT.vtkFFT_HanningGenerator_05(x, size);
		}

		// Token: 0x0601DCF1 RID: 122097
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFFT_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Given a window generator function, create a symmetric 2D kernel.
		/// @c kernel is the pointer to the raw 2D data array.
		/// </summary>
		// Token: 0x0601DCF2 RID: 122098 RVA: 0x002A179C File Offset: 0x0029F99C
		public override int IsA(string type)
		{
			return vtkFFT.vtkFFT_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601DCF3 RID: 122099
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFFT_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Given a window generator function, create a symmetric 2D kernel.
		/// @c kernel is the pointer to the raw 2D data array.
		/// </summary>
		// Token: 0x0601DCF4 RID: 122100 RVA: 0x002A17BC File Offset: 0x0029F9BC
		public new static int IsTypeOf(string type)
		{
			return vtkFFT.vtkFFT_IsTypeOf_07(type);
		}

		// Token: 0x0601DCF5 RID: 122101
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFFT_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a window generator function, create a symmetric 2D kernel.
		/// @c kernel is the pointer to the raw 2D data array.
		/// </summary>
		// Token: 0x0601DCF6 RID: 122102 RVA: 0x002A17D8 File Offset: 0x0029F9D8
		public new vtkFFT NewInstance()
		{
			vtkFFT result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFFT.vtkFFT_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFFT)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DCF7 RID: 122103
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFFT_RectangularGenerator_10(ulong x, ulong size);

		/// <summary>
		/// Window generator functions. Implementation only needs to be valid for x E [0; size / 2]
		/// because kernels are symmetric by definitions. This point is very important for some
		/// kernels like Bartlett for example.
		///
		/// @warning Most generators need size &gt; 1 !
		///
		/// Can be used with @c GenerateKernel1D and @c GenerateKernel2D for generating full kernels.
		/// </summary>
		// Token: 0x0601DCF8 RID: 122104 RVA: 0x002A1834 File Offset: 0x0029FA34
		public static double RectangularGenerator(ulong x, ulong size)
		{
			return vtkFFT.vtkFFT_RectangularGenerator_10(x, size);
		}

		// Token: 0x0601DCF9 RID: 122105
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFFT_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a window generator function, create a symmetric 2D kernel.
		/// @c kernel is the pointer to the raw 2D data array.
		/// </summary>
		// Token: 0x0601DCFA RID: 122106 RVA: 0x002A1850 File Offset: 0x0029FA50
		public new static vtkFFT SafeDownCast(vtkObjectBase o)
		{
			vtkFFT vtkFFT = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFFT.vtkFFT_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFFT = (vtkFFT)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFFT.Register(null);
				}
			}
			return vtkFFT;
		}

		// Token: 0x0601DCFB RID: 122107
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFFT_SineGenerator_12(ulong x, ulong size);

		/// <summary>
		/// Window generator functions. Implementation only needs to be valid for x E [0; size / 2]
		/// because kernels are symmetric by definitions. This point is very important for some
		/// kernels like Bartlett for example.
		///
		/// @warning Most generators need size &gt; 1 !
		///
		/// Can be used with @c GenerateKernel1D and @c GenerateKernel2D for generating full kernels.
		/// </summary>
		// Token: 0x0601DCFC RID: 122108 RVA: 0x002A18D0 File Offset: 0x0029FAD0
		public static double SineGenerator(ulong x, ulong size)
		{
			return vtkFFT.vtkFFT_SineGenerator_12(x, size);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F57 RID: 8023
		public new const string MRFullTypeName = "Kitware.VTK.vtkFFT";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F58 RID: 8024
		public new static readonly string MRClassNameKey = "class vtkFFT";

		/// <summary>
		/// Enum containing octave band numbers, named upon their nominal midband frequency.
		/// Value multiplied by 3 should be a one-third-octave band number matching an octave band.
		/// </summary>
		// Token: 0x02000B14 RID: 2836
		public enum Octave
		{
			/// <summary>enum member</summary>
			// Token: 0x04001F5A RID: 8026
			Hz_125 = 7,
			/// <summary>enum member</summary>
			// Token: 0x04001F5B RID: 8027
			Hz_250,
			/// <summary>enum member</summary>
			// Token: 0x04001F5C RID: 8028
			Hz_31_5 = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001F5D RID: 8029
			Hz_500 = 9,
			/// <summary>enum member</summary>
			// Token: 0x04001F5E RID: 8030
			Hz_63 = 6,
			/// <summary>enum member</summary>
			// Token: 0x04001F5F RID: 8031
			kHz_1 = 10,
			/// <summary>enum member</summary>
			// Token: 0x04001F60 RID: 8032
			kHz_16 = 14,
			/// <summary>enum member</summary>
			// Token: 0x04001F61 RID: 8033
			kHz_2 = 11,
			/// <summary>enum member</summary>
			// Token: 0x04001F62 RID: 8034
			kHz_4,
			/// <summary>enum member</summary>
			// Token: 0x04001F63 RID: 8035
			kHz_8
		}

		/// <summary>
		/// Enum specifying which octave band we want to compute.
		/// Could be a full octave range, or a one-third-octave one for instance.
		/// </summary>
		// Token: 0x02000B15 RID: 2837
		public enum OctaveSubdivision
		{
			/// <summary>enum member</summary>
			// Token: 0x04001F65 RID: 8037
			FirstHalf = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001F66 RID: 8038
			FirstThird = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001F67 RID: 8039
			Full = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001F68 RID: 8040
			SecondHalf = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001F69 RID: 8041
			SecondThird = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001F6A RID: 8042
			ThirdThird
		}

		/// <summary>
		/// Scaling modes for Spectrogram and Csd functions.
		/// </summary>
		// Token: 0x02000B16 RID: 2838
		public enum Scaling
		{
			/// <summary>enum member</summary>
			// Token: 0x04001F6C RID: 8044
			Density,
			/// <summary>enum member</summary>
			// Token: 0x04001F6D RID: 8045
			Spectrum
		}

		/// <summary>
		/// Spectral modes for Spectrogram and Csd functions.
		/// </summary>
		// Token: 0x02000B17 RID: 2839
		public enum SpectralMode
		{
			/// <summary>enum member</summary>
			// Token: 0x04001F6F RID: 8047
			PSD = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001F70 RID: 8048
			STFT = 0
		}

		/// <summary>
		/// Window generator functions. Implementation only needs to be valid for x E [0; size / 2]
		/// because kernels are symmetric by definitions. This point is very important for some
		/// kernels like Bartlett for example.
		///
		/// @warning Most generators need size &gt; 1 !
		///
		/// Can be used with @c GenerateKernel1D and @c GenerateKernel2D for generating full kernels.
		/// </summary>
		// Token: 0x02000B18 RID: 2840
		// (Invoke) Token: 0x0601DCFE RID: 122110
		public delegate double WindowGenerator(ulong arg0, ulong arg1);
	}
}
