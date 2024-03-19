using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageButterworthLowPass
	/// </summary>
	/// <remarks>
	///    Frequency domain Low pass.
	///
	/// This filter only works on an image after it has been converted to
	/// frequency domain by a vtkImageFFT filter.  A vtkImageRFFT filter
	/// can be used to convert the output back into the spatial domain.
	/// vtkImageButterworthLowPass the high frequency components are
	/// attenuated.  Input and output are in doubles, with two components
	/// (complex numbers).
	/// out(i, j) = (1 + pow(CutOff/Freq(i,j), 2*Order));
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageButterworthHighPass vtkImageFFT vtkImageRFFT
	/// </seealso>
	// Token: 0x0200025B RID: 603
	public class vtkImageButterworthLowPass : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006F70 RID: 28528 RVA: 0x000A0875 File Offset: 0x0009EA75
		static vtkImageButterworthLowPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageButterworthLowPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageButterworthLowPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006F71 RID: 28529 RVA: 0x000A089D File Offset: 0x0009EA9D
		public vtkImageButterworthLowPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006F72 RID: 28530
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageButterworthLowPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F73 RID: 28531 RVA: 0x000A08AC File Offset: 0x0009EAAC
		public new static vtkImageButterworthLowPass New()
		{
			vtkImageButterworthLowPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageButterworthLowPass.vtkImageButterworthLowPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageButterworthLowPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F74 RID: 28532 RVA: 0x000A0900 File Offset: 0x0009EB00
		public vtkImageButterworthLowPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageButterworthLowPass.vtkImageButterworthLowPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006F75 RID: 28533 RVA: 0x000A0944 File Offset: 0x0009EB44
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006F76 RID: 28534
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageButterworthLowPass_GetCutOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F77 RID: 28535 RVA: 0x000A0950 File Offset: 0x0009EB50
		public virtual double[] GetCutOff()
		{
			IntPtr intPtr = vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetCutOff_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006F78 RID: 28536
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthLowPass_GetCutOff_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F79 RID: 28537 RVA: 0x000A0998 File Offset: 0x0009EB98
		public virtual void GetCutOff(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetCutOff_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06006F7A RID: 28538
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthLowPass_GetCutOff_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F7B RID: 28539 RVA: 0x000A09AA File Offset: 0x0009EBAA
		public virtual void GetCutOff(IntPtr _arg)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetCutOff_03(base.GetCppThis(), _arg);
		}

		// Token: 0x06006F7C RID: 28540
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageButterworthLowPass_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F7D RID: 28541 RVA: 0x000A09BC File Offset: 0x0009EBBC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06006F7E RID: 28542
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageButterworthLowPass_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F7F RID: 28543 RVA: 0x000A09DC File Offset: 0x0009EBDC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06006F80 RID: 28544
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageButterworthLowPass_GetOrder_06(HandleRef pThis);

		/// <summary>
		/// The order determines sharpness of the cutoff curve.
		/// </summary>
		// Token: 0x06006F81 RID: 28545 RVA: 0x000A09F8 File Offset: 0x0009EBF8
		public virtual int GetOrder()
		{
			return vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetOrder_06(base.GetCppThis());
		}

		// Token: 0x06006F82 RID: 28546
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageButterworthLowPass_GetXCutOff_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F83 RID: 28547 RVA: 0x000A0A18 File Offset: 0x0009EC18
		public double GetXCutOff()
		{
			return vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetXCutOff_07(base.GetCppThis());
		}

		// Token: 0x06006F84 RID: 28548
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageButterworthLowPass_GetYCutOff_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F85 RID: 28549 RVA: 0x000A0A38 File Offset: 0x0009EC38
		public double GetYCutOff()
		{
			return vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetYCutOff_08(base.GetCppThis());
		}

		// Token: 0x06006F86 RID: 28550
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageButterworthLowPass_GetZCutOff_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F87 RID: 28551 RVA: 0x000A0A58 File Offset: 0x0009EC58
		public double GetZCutOff()
		{
			return vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetZCutOff_09(base.GetCppThis());
		}

		// Token: 0x06006F88 RID: 28552
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageButterworthLowPass_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F89 RID: 28553 RVA: 0x000A0A78 File Offset: 0x0009EC78
		public override int IsA(string type)
		{
			return vtkImageButterworthLowPass.vtkImageButterworthLowPass_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06006F8A RID: 28554
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageButterworthLowPass_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F8B RID: 28555 RVA: 0x000A0A98 File Offset: 0x0009EC98
		public new static int IsTypeOf(string type)
		{
			return vtkImageButterworthLowPass.vtkImageButterworthLowPass_IsTypeOf_11(type);
		}

		// Token: 0x06006F8C RID: 28556
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageButterworthLowPass_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F8D RID: 28557 RVA: 0x000A0AB4 File Offset: 0x0009ECB4
		public new vtkImageButterworthLowPass NewInstance()
		{
			vtkImageButterworthLowPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageButterworthLowPass.vtkImageButterworthLowPass_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageButterworthLowPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006F8E RID: 28558
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageButterworthLowPass_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F8F RID: 28559 RVA: 0x000A0B10 File Offset: 0x0009ED10
		public new static vtkImageButterworthLowPass SafeDownCast(vtkObjectBase o)
		{
			vtkImageButterworthLowPass vtkImageButterworthLowPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageButterworthLowPass.vtkImageButterworthLowPass_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageButterworthLowPass = (vtkImageButterworthLowPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageButterworthLowPass.Register(null);
				}
			}
			return vtkImageButterworthLowPass;
		}

		// Token: 0x06006F90 RID: 28560
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthLowPass_SetCutOff_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F91 RID: 28561 RVA: 0x000A0B8F File Offset: 0x0009ED8F
		public virtual void SetCutOff(double _arg1, double _arg2, double _arg3)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_SetCutOff_15(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06006F92 RID: 28562
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthLowPass_SetCutOff_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F93 RID: 28563 RVA: 0x000A0BA1 File Offset: 0x0009EDA1
		public virtual void SetCutOff(IntPtr _arg)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_SetCutOff_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06006F94 RID: 28564
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthLowPass_SetCutOff_17(HandleRef pThis, double v);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F95 RID: 28565 RVA: 0x000A0BB1 File Offset: 0x0009EDB1
		public void SetCutOff(double v)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_SetCutOff_17(base.GetCppThis(), v);
		}

		// Token: 0x06006F96 RID: 28566
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthLowPass_SetOrder_18(HandleRef pThis, int _arg);

		/// <summary>
		/// The order determines sharpness of the cutoff curve.
		/// </summary>
		// Token: 0x06006F97 RID: 28567 RVA: 0x000A0BC1 File Offset: 0x0009EDC1
		public virtual void SetOrder(int _arg)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_SetOrder_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06006F98 RID: 28568
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthLowPass_SetXCutOff_19(HandleRef pThis, double cutOff);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F99 RID: 28569 RVA: 0x000A0BD1 File Offset: 0x0009EDD1
		public void SetXCutOff(double cutOff)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_SetXCutOff_19(base.GetCppThis(), cutOff);
		}

		// Token: 0x06006F9A RID: 28570
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthLowPass_SetYCutOff_20(HandleRef pThis, double cutOff);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F9B RID: 28571 RVA: 0x000A0BE1 File Offset: 0x0009EDE1
		public void SetYCutOff(double cutOff)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_SetYCutOff_20(base.GetCppThis(), cutOff);
		}

		// Token: 0x06006F9C RID: 28572
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthLowPass_SetZCutOff_21(HandleRef pThis, double cutOff);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F9D RID: 28573 RVA: 0x000A0BF1 File Offset: 0x0009EDF1
		public void SetZCutOff(double cutOff)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_SetZCutOff_21(base.GetCppThis(), cutOff);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009AB RID: 2475
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageButterworthLowPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009AC RID: 2476
		public new static readonly string MRClassNameKey = "class vtkImageButterworthLowPass";
	}
}
