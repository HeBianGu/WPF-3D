using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageIdealHighPass
	/// </summary>
	/// <remarks>
	///    Simple frequency domain band pass.
	///
	/// This filter only works on an image after it has been converted to
	/// frequency domain by a vtkImageFFT filter.  A vtkImageRFFT filter
	/// can be used to convert the output back into the spatial domain.
	/// vtkImageIdealHighPass just sets a portion of the image to zero.  The sharp
	/// cutoff in the frequency domain produces ringing in the spatial domain.
	/// Input and Output must be doubles.  Dimensionality is set when the axes are
	/// set.  Defaults to 2D on X and Y axes.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageButterworthHighPass vtkImageIdealLowPass vtkImageFFT vtkImageRFFT
	/// </seealso>
	// Token: 0x02000260 RID: 608
	public class vtkImageIdealHighPass : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006FE8 RID: 28648 RVA: 0x000A13E7 File Offset: 0x0009F5E7
		static vtkImageIdealHighPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageIdealHighPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageIdealHighPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006FE9 RID: 28649 RVA: 0x000A140F File Offset: 0x0009F60F
		public vtkImageIdealHighPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006FEA RID: 28650
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageIdealHighPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FEB RID: 28651 RVA: 0x000A1420 File Offset: 0x0009F620
		public new static vtkImageIdealHighPass New()
		{
			vtkImageIdealHighPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageIdealHighPass.vtkImageIdealHighPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageIdealHighPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FEC RID: 28652 RVA: 0x000A1474 File Offset: 0x0009F674
		public vtkImageIdealHighPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageIdealHighPass.vtkImageIdealHighPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006FED RID: 28653 RVA: 0x000A14B8 File Offset: 0x0009F6B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006FEE RID: 28654
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageIdealHighPass_GetCutOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006FEF RID: 28655 RVA: 0x000A14C4 File Offset: 0x0009F6C4
		public virtual double[] GetCutOff()
		{
			IntPtr intPtr = vtkImageIdealHighPass.vtkImageIdealHighPass_GetCutOff_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006FF0 RID: 28656
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealHighPass_GetCutOff_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006FF1 RID: 28657 RVA: 0x000A150C File Offset: 0x0009F70C
		public virtual void GetCutOff(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_GetCutOff_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06006FF2 RID: 28658
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealHighPass_GetCutOff_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006FF3 RID: 28659 RVA: 0x000A151E File Offset: 0x0009F71E
		public virtual void GetCutOff(IntPtr _arg)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_GetCutOff_03(base.GetCppThis(), _arg);
		}

		// Token: 0x06006FF4 RID: 28660
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageIdealHighPass_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FF5 RID: 28661 RVA: 0x000A1530 File Offset: 0x0009F730
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageIdealHighPass.vtkImageIdealHighPass_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06006FF6 RID: 28662
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageIdealHighPass_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FF7 RID: 28663 RVA: 0x000A1550 File Offset: 0x0009F750
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageIdealHighPass.vtkImageIdealHighPass_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06006FF8 RID: 28664
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageIdealHighPass_GetXCutOff_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006FF9 RID: 28665 RVA: 0x000A156C File Offset: 0x0009F76C
		public double GetXCutOff()
		{
			return vtkImageIdealHighPass.vtkImageIdealHighPass_GetXCutOff_06(base.GetCppThis());
		}

		// Token: 0x06006FFA RID: 28666
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageIdealHighPass_GetYCutOff_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006FFB RID: 28667 RVA: 0x000A158C File Offset: 0x0009F78C
		public double GetYCutOff()
		{
			return vtkImageIdealHighPass.vtkImageIdealHighPass_GetYCutOff_07(base.GetCppThis());
		}

		// Token: 0x06006FFC RID: 28668
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageIdealHighPass_GetZCutOff_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06006FFD RID: 28669 RVA: 0x000A15AC File Offset: 0x0009F7AC
		public double GetZCutOff()
		{
			return vtkImageIdealHighPass.vtkImageIdealHighPass_GetZCutOff_08(base.GetCppThis());
		}

		// Token: 0x06006FFE RID: 28670
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageIdealHighPass_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FFF RID: 28671 RVA: 0x000A15CC File Offset: 0x0009F7CC
		public override int IsA(string type)
		{
			return vtkImageIdealHighPass.vtkImageIdealHighPass_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06007000 RID: 28672
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageIdealHighPass_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007001 RID: 28673 RVA: 0x000A15EC File Offset: 0x0009F7EC
		public new static int IsTypeOf(string type)
		{
			return vtkImageIdealHighPass.vtkImageIdealHighPass_IsTypeOf_10(type);
		}

		// Token: 0x06007002 RID: 28674
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageIdealHighPass_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007003 RID: 28675 RVA: 0x000A1608 File Offset: 0x0009F808
		public new vtkImageIdealHighPass NewInstance()
		{
			vtkImageIdealHighPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageIdealHighPass.vtkImageIdealHighPass_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageIdealHighPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007004 RID: 28676
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageIdealHighPass_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007005 RID: 28677 RVA: 0x000A1664 File Offset: 0x0009F864
		public new static vtkImageIdealHighPass SafeDownCast(vtkObjectBase o)
		{
			vtkImageIdealHighPass vtkImageIdealHighPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageIdealHighPass.vtkImageIdealHighPass_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageIdealHighPass = (vtkImageIdealHighPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageIdealHighPass.Register(null);
				}
			}
			return vtkImageIdealHighPass;
		}

		// Token: 0x06007006 RID: 28678
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealHighPass_SetCutOff_14(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06007007 RID: 28679 RVA: 0x000A16E3 File Offset: 0x0009F8E3
		public virtual void SetCutOff(double _arg1, double _arg2, double _arg3)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_SetCutOff_14(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06007008 RID: 28680
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealHighPass_SetCutOff_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06007009 RID: 28681 RVA: 0x000A16F5 File Offset: 0x0009F8F5
		public virtual void SetCutOff(IntPtr _arg)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_SetCutOff_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600700A RID: 28682
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealHighPass_SetCutOff_16(HandleRef pThis, double v);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x0600700B RID: 28683 RVA: 0x000A1705 File Offset: 0x0009F905
		public void SetCutOff(double v)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_SetCutOff_16(base.GetCppThis(), v);
		}

		// Token: 0x0600700C RID: 28684
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealHighPass_SetXCutOff_17(HandleRef pThis, double cutOff);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x0600700D RID: 28685 RVA: 0x000A1715 File Offset: 0x0009F915
		public void SetXCutOff(double cutOff)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_SetXCutOff_17(base.GetCppThis(), cutOff);
		}

		// Token: 0x0600700E RID: 28686
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealHighPass_SetYCutOff_18(HandleRef pThis, double cutOff);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x0600700F RID: 28687 RVA: 0x000A1725 File Offset: 0x0009F925
		public void SetYCutOff(double cutOff)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_SetYCutOff_18(base.GetCppThis(), cutOff);
		}

		// Token: 0x06007010 RID: 28688
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIdealHighPass_SetZCutOff_19(HandleRef pThis, double cutOff);

		/// <summary>
		/// Set/Get the cutoff frequency for each axis.
		/// The values are specified in the order X, Y, Z, Time.
		/// Units: Cycles per world unit (as defined by the data spacing).
		/// </summary>
		// Token: 0x06007011 RID: 28689 RVA: 0x000A1735 File Offset: 0x0009F935
		public void SetZCutOff(double cutOff)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_SetZCutOff_19(base.GetCppThis(), cutOff);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009B5 RID: 2485
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageIdealHighPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009B6 RID: 2486
		public new static readonly string MRClassNameKey = "class vtkImageIdealHighPass";
	}
}
