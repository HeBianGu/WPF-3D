using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageButterworthHighPass
	/// </summary>
	/// <remarks>
	///    Frequency domain high pass.
	///
	/// This filter only works on an image after it has been converted to
	/// frequency domain by a vtkImageFFT filter.  A vtkImageRFFT filter
	/// can be used to convert the output back into the spatial domain.
	/// vtkImageButterworthHighPass the frequency components around 0 are
	/// attenuated.  Input and output are in doubles, with two components
	/// (complex numbers).
	/// out(i, j) = 1 / (1 + pow(CutOff/Freq(i,j), 2*Order));
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageButterworthLowPass
	/// </seealso>
	// Token: 0x0200025A RID: 602
	public class vtkImageButterworthHighPass : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006F42 RID: 28482 RVA: 0x000A04E7 File Offset: 0x0009E6E7
		static vtkImageButterworthHighPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageButterworthHighPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageButterworthHighPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006F43 RID: 28483 RVA: 0x000A050F File Offset: 0x0009E70F
		public vtkImageButterworthHighPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006F44 RID: 28484
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageButterworthHighPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F45 RID: 28485 RVA: 0x000A0520 File Offset: 0x0009E720
		public new static vtkImageButterworthHighPass New()
		{
			vtkImageButterworthHighPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageButterworthHighPass.vtkImageButterworthHighPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageButterworthHighPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F46 RID: 28486 RVA: 0x000A0574 File Offset: 0x0009E774
		public vtkImageButterworthHighPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageButterworthHighPass.vtkImageButterworthHighPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006F47 RID: 28487 RVA: 0x000A05B8 File Offset: 0x0009E7B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006F48 RID: 28488
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageButterworthHighPass_GetCutOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F49 RID: 28489 RVA: 0x000A05C4 File Offset: 0x0009E7C4
		public virtual double[] GetCutOff()
		{
			IntPtr intPtr = vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetCutOff_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006F4A RID: 28490
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthHighPass_GetCutOff_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F4B RID: 28491 RVA: 0x000A060C File Offset: 0x0009E80C
		public virtual void GetCutOff(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetCutOff_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06006F4C RID: 28492
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthHighPass_GetCutOff_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F4D RID: 28493 RVA: 0x000A061E File Offset: 0x0009E81E
		public virtual void GetCutOff(IntPtr _arg)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetCutOff_03(base.GetCppThis(), _arg);
		}

		// Token: 0x06006F4E RID: 28494
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageButterworthHighPass_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F4F RID: 28495 RVA: 0x000A0630 File Offset: 0x0009E830
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06006F50 RID: 28496
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageButterworthHighPass_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F51 RID: 28497 RVA: 0x000A0650 File Offset: 0x0009E850
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06006F52 RID: 28498
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageButterworthHighPass_GetOrder_06(HandleRef pThis);

		/// <summary>
		/// The order determines sharpness of the cutoff curve.
		/// </summary>
		// Token: 0x06006F53 RID: 28499 RVA: 0x000A066C File Offset: 0x0009E86C
		public virtual int GetOrder()
		{
			return vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetOrder_06(base.GetCppThis());
		}

		// Token: 0x06006F54 RID: 28500
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageButterworthHighPass_GetXCutOff_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F55 RID: 28501 RVA: 0x000A068C File Offset: 0x0009E88C
		public double GetXCutOff()
		{
			return vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetXCutOff_07(base.GetCppThis());
		}

		// Token: 0x06006F56 RID: 28502
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageButterworthHighPass_GetYCutOff_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F57 RID: 28503 RVA: 0x000A06AC File Offset: 0x0009E8AC
		public double GetYCutOff()
		{
			return vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetYCutOff_08(base.GetCppThis());
		}

		// Token: 0x06006F58 RID: 28504
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageButterworthHighPass_GetZCutOff_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F59 RID: 28505 RVA: 0x000A06CC File Offset: 0x0009E8CC
		public double GetZCutOff()
		{
			return vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetZCutOff_09(base.GetCppThis());
		}

		// Token: 0x06006F5A RID: 28506
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageButterworthHighPass_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F5B RID: 28507 RVA: 0x000A06EC File Offset: 0x0009E8EC
		public override int IsA(string type)
		{
			return vtkImageButterworthHighPass.vtkImageButterworthHighPass_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06006F5C RID: 28508
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageButterworthHighPass_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F5D RID: 28509 RVA: 0x000A070C File Offset: 0x0009E90C
		public new static int IsTypeOf(string type)
		{
			return vtkImageButterworthHighPass.vtkImageButterworthHighPass_IsTypeOf_11(type);
		}

		// Token: 0x06006F5E RID: 28510
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageButterworthHighPass_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F5F RID: 28511 RVA: 0x000A0728 File Offset: 0x0009E928
		public new vtkImageButterworthHighPass NewInstance()
		{
			vtkImageButterworthHighPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageButterworthHighPass.vtkImageButterworthHighPass_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageButterworthHighPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006F60 RID: 28512
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageButterworthHighPass_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F61 RID: 28513 RVA: 0x000A0784 File Offset: 0x0009E984
		public new static vtkImageButterworthHighPass SafeDownCast(vtkObjectBase o)
		{
			vtkImageButterworthHighPass vtkImageButterworthHighPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageButterworthHighPass.vtkImageButterworthHighPass_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageButterworthHighPass = (vtkImageButterworthHighPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageButterworthHighPass.Register(null);
				}
			}
			return vtkImageButterworthHighPass;
		}

		// Token: 0x06006F62 RID: 28514
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthHighPass_SetCutOff_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F63 RID: 28515 RVA: 0x000A0803 File Offset: 0x0009EA03
		public virtual void SetCutOff(double _arg1, double _arg2, double _arg3)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_SetCutOff_15(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06006F64 RID: 28516
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthHighPass_SetCutOff_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F65 RID: 28517 RVA: 0x000A0815 File Offset: 0x0009EA15
		public virtual void SetCutOff(IntPtr _arg)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_SetCutOff_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06006F66 RID: 28518
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthHighPass_SetCutOff_17(HandleRef pThis, double v);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F67 RID: 28519 RVA: 0x000A0825 File Offset: 0x0009EA25
		public void SetCutOff(double v)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_SetCutOff_17(base.GetCppThis(), v);
		}

		// Token: 0x06006F68 RID: 28520
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthHighPass_SetOrder_18(HandleRef pThis, int _arg);

		/// <summary>
		/// The order determines sharpness of the cutoff curve.
		/// </summary>
		// Token: 0x06006F69 RID: 28521 RVA: 0x000A0835 File Offset: 0x0009EA35
		public virtual void SetOrder(int _arg)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_SetOrder_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06006F6A RID: 28522
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthHighPass_SetXCutOff_19(HandleRef pThis, double cutOff);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F6B RID: 28523 RVA: 0x000A0845 File Offset: 0x0009EA45
		public void SetXCutOff(double cutOff)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_SetXCutOff_19(base.GetCppThis(), cutOff);
		}

		// Token: 0x06006F6C RID: 28524
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthHighPass_SetYCutOff_20(HandleRef pThis, double cutOff);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F6D RID: 28525 RVA: 0x000A0855 File Offset: 0x0009EA55
		public void SetYCutOff(double cutOff)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_SetYCutOff_20(base.GetCppThis(), cutOff);
		}

		// Token: 0x06006F6E RID: 28526
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageButterworthHighPass_SetZCutOff_21(HandleRef pThis, double cutOff);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006F6F RID: 28527 RVA: 0x000A0865 File Offset: 0x0009EA65
		public void SetZCutOff(double cutOff)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_SetZCutOff_21(base.GetCppThis(), cutOff);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009A9 RID: 2473
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageButterworthHighPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009AA RID: 2474
		public new static readonly string MRClassNameKey = "class vtkImageButterworthHighPass";
	}
}
