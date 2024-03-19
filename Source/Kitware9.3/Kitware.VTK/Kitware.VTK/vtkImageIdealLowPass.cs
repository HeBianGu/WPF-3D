using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageIdealLowPass
	/// </summary>
	/// <remarks>
	///    Simple frequency domain band pass.
	///
	/// This filter only works on an image after it has been converted to
	/// frequency domain by a vtkImageFFT filter.  A vtkImageRFFT filter
	/// can be used to convert the output back into the spatial domain.
	/// vtkImageIdealLowPass just sets a portion of the image to zero.  The result
	/// is an image with a lot of ringing.  Input and Output must be doubles.
	/// Dimensionality is set when the axes are set.  Defaults to 2D on X and Y
	/// axes.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageButterworthLowPass vtkImageIdealHighPass vtkImageFFT vtkImageRFFT
	/// </seealso>
	// Token: 0x02000261 RID: 609
	public class vtkImageIdealLowPass : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007012 RID: 28690 RVA: 0x000A1745 File Offset: 0x0009F945
		static vtkImageIdealLowPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageIdealLowPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageIdealLowPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007013 RID: 28691 RVA: 0x000A176D File Offset: 0x0009F96D
		public vtkImageIdealLowPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007014 RID: 28692
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageIdealLowPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007015 RID: 28693 RVA: 0x000A177C File Offset: 0x0009F97C
		public new static vtkImageIdealLowPass New()
		{
			vtkImageIdealLowPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageIdealLowPass.vtkImageIdealLowPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageIdealLowPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007016 RID: 28694 RVA: 0x000A17D0 File Offset: 0x0009F9D0
		public vtkImageIdealLowPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageIdealLowPass.vtkImageIdealLowPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007017 RID: 28695 RVA: 0x000A1814 File Offset: 0x0009FA14
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007018 RID: 28696
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageIdealLowPass_GetCutOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06007019 RID: 28697 RVA: 0x000A1820 File Offset: 0x0009FA20
		public virtual double[] GetCutOff()
		{
			IntPtr intPtr = vtkImageIdealLowPass.vtkImageIdealLowPass_GetCutOff_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600701A RID: 28698
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealLowPass_GetCutOff_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x0600701B RID: 28699 RVA: 0x000A1868 File Offset: 0x0009FA68
		public virtual void GetCutOff(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_GetCutOff_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600701C RID: 28700
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealLowPass_GetCutOff_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x0600701D RID: 28701 RVA: 0x000A187A File Offset: 0x0009FA7A
		public virtual void GetCutOff(IntPtr _arg)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_GetCutOff_03(base.GetCppThis(), _arg);
		}

		// Token: 0x0600701E RID: 28702
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageIdealLowPass_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600701F RID: 28703 RVA: 0x000A188C File Offset: 0x0009FA8C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageIdealLowPass.vtkImageIdealLowPass_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06007020 RID: 28704
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageIdealLowPass_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007021 RID: 28705 RVA: 0x000A18AC File Offset: 0x0009FAAC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageIdealLowPass.vtkImageIdealLowPass_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06007022 RID: 28706
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageIdealLowPass_GetXCutOff_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06007023 RID: 28707 RVA: 0x000A18C8 File Offset: 0x0009FAC8
		public double GetXCutOff()
		{
			return vtkImageIdealLowPass.vtkImageIdealLowPass_GetXCutOff_06(base.GetCppThis());
		}

		// Token: 0x06007024 RID: 28708
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageIdealLowPass_GetYCutOff_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06007025 RID: 28709 RVA: 0x000A18E8 File Offset: 0x0009FAE8
		public double GetYCutOff()
		{
			return vtkImageIdealLowPass.vtkImageIdealLowPass_GetYCutOff_07(base.GetCppThis());
		}

		// Token: 0x06007026 RID: 28710
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageIdealLowPass_GetZCutOff_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06007027 RID: 28711 RVA: 0x000A1908 File Offset: 0x0009FB08
		public double GetZCutOff()
		{
			return vtkImageIdealLowPass.vtkImageIdealLowPass_GetZCutOff_08(base.GetCppThis());
		}

		// Token: 0x06007028 RID: 28712
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageIdealLowPass_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007029 RID: 28713 RVA: 0x000A1928 File Offset: 0x0009FB28
		public override int IsA(string type)
		{
			return vtkImageIdealLowPass.vtkImageIdealLowPass_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600702A RID: 28714
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageIdealLowPass_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600702B RID: 28715 RVA: 0x000A1948 File Offset: 0x0009FB48
		public new static int IsTypeOf(string type)
		{
			return vtkImageIdealLowPass.vtkImageIdealLowPass_IsTypeOf_10(type);
		}

		// Token: 0x0600702C RID: 28716
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageIdealLowPass_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600702D RID: 28717 RVA: 0x000A1964 File Offset: 0x0009FB64
		public new vtkImageIdealLowPass NewInstance()
		{
			vtkImageIdealLowPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageIdealLowPass.vtkImageIdealLowPass_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageIdealLowPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600702E RID: 28718
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageIdealLowPass_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600702F RID: 28719 RVA: 0x000A19C0 File Offset: 0x0009FBC0
		public new static vtkImageIdealLowPass SafeDownCast(vtkObjectBase o)
		{
			vtkImageIdealLowPass vtkImageIdealLowPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageIdealLowPass.vtkImageIdealLowPass_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageIdealLowPass = (vtkImageIdealLowPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageIdealLowPass.Register(null);
				}
			}
			return vtkImageIdealLowPass;
		}

		// Token: 0x06007030 RID: 28720
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealLowPass_SetCutOff_14(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06007031 RID: 28721 RVA: 0x000A1A3F File Offset: 0x0009FC3F
		public virtual void SetCutOff(double _arg1, double _arg2, double _arg3)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_SetCutOff_14(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06007032 RID: 28722
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealLowPass_SetCutOff_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06007033 RID: 28723 RVA: 0x000A1A51 File Offset: 0x0009FC51
		public virtual void SetCutOff(IntPtr _arg)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_SetCutOff_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06007034 RID: 28724
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealLowPass_SetCutOff_16(HandleRef pThis, double v);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06007035 RID: 28725 RVA: 0x000A1A61 File Offset: 0x0009FC61
		public void SetCutOff(double v)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_SetCutOff_16(base.GetCppThis(), v);
		}

		// Token: 0x06007036 RID: 28726
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealLowPass_SetXCutOff_17(HandleRef pThis, double cutOff);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06007037 RID: 28727 RVA: 0x000A1A71 File Offset: 0x0009FC71
		public void SetXCutOff(double cutOff)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_SetXCutOff_17(base.GetCppThis(), cutOff);
		}

		// Token: 0x06007038 RID: 28728
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealLowPass_SetYCutOff_18(HandleRef pThis, double cutOff);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06007039 RID: 28729 RVA: 0x000A1A81 File Offset: 0x0009FC81
		public void SetYCutOff(double cutOff)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_SetYCutOff_18(base.GetCppThis(), cutOff);
		}

		// Token: 0x0600703A RID: 28730
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealLowPass_SetZCutOff_19(HandleRef pThis, double cutOff);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x0600703B RID: 28731 RVA: 0x000A1A91 File Offset: 0x0009FC91
		public void SetZCutOff(double cutOff)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_SetZCutOff_19(base.GetCppThis(), cutOff);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009B7 RID: 2487
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageIdealLowPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009B8 RID: 2488
		public new static readonly string MRClassNameKey = "class vtkImageIdealLowPass";
	}
}
