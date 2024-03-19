using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRTAnalyticSource
	/// </summary>
	/// <remarks>
	///    Create an image for regression testing
	///
	/// vtkRTAnalyticSource just produces images with pixel values determined
	/// by a Maximum*Gaussian*XMag*sin(XFreq*x)*sin(YFreq*y)*cos(ZFreq*z)
	/// Values are float scalars on point data with name "RTData".
	/// </remarks>
	// Token: 0x0200086C RID: 2156
	public class vtkRTAnalyticSource : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016616 RID: 91670 RVA: 0x001F7783 File Offset: 0x001F5983
		static vtkRTAnalyticSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRTAnalyticSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRTAnalyticSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016617 RID: 91671 RVA: 0x001F77AB File Offset: 0x001F59AB
		public vtkRTAnalyticSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016618 RID: 91672
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRTAnalyticSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016619 RID: 91673 RVA: 0x001F77BC File Offset: 0x001F59BC
		public new static vtkRTAnalyticSource New()
		{
			vtkRTAnalyticSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRTAnalyticSource.vtkRTAnalyticSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRTAnalyticSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601661A RID: 91674 RVA: 0x001F7810 File Offset: 0x001F5A10
		public vtkRTAnalyticSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRTAnalyticSource.vtkRTAnalyticSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601661B RID: 91675 RVA: 0x001F7854 File Offset: 0x001F5A54
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601661C RID: 91676
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRTAnalyticSource_GetCenter_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the center of function. Initial value is {0.0,0.0,0.0}
		/// </summary>
		// Token: 0x0601661D RID: 91677 RVA: 0x001F7860 File Offset: 0x001F5A60
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkRTAnalyticSource.vtkRTAnalyticSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601661E RID: 91678
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_GetCenter_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the center of function. Initial value is {0.0,0.0,0.0}
		/// </summary>
		// Token: 0x0601661F RID: 91679 RVA: 0x001F78A8 File Offset: 0x001F5AA8
		public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_GetCenter_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06016620 RID: 91680
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_GetCenter_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the center of function. Initial value is {0.0,0.0,0.0}
		/// </summary>
		// Token: 0x06016621 RID: 91681 RVA: 0x001F78BA File Offset: 0x001F5ABA
		public virtual void GetCenter(IntPtr _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_GetCenter_03(base.GetCppThis(), _arg);
		}

		// Token: 0x06016622 RID: 91682
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRTAnalyticSource_GetMaximum_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the Maximum value of the function. Initial value is 255.0.
		/// </summary>
		// Token: 0x06016623 RID: 91683 RVA: 0x001F78CC File Offset: 0x001F5ACC
		public virtual double GetMaximum()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetMaximum_04(base.GetCppThis());
		}

		// Token: 0x06016624 RID: 91684
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRTAnalyticSource_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016625 RID: 91685 RVA: 0x001F78EC File Offset: 0x001F5AEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06016626 RID: 91686
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRTAnalyticSource_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016627 RID: 91687 RVA: 0x001F790C File Offset: 0x001F5B0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06016628 RID: 91688
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRTAnalyticSource_GetStandardDeviation_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the standard deviation of the function. Initial value is 0.5.
		/// </summary>
		// Token: 0x06016629 RID: 91689 RVA: 0x001F7928 File Offset: 0x001F5B28
		public virtual double GetStandardDeviation()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetStandardDeviation_07(base.GetCppThis());
		}

		// Token: 0x0601662A RID: 91690
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRTAnalyticSource_GetSubsampleRate_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the sub-sample rate. Initial value is 1.
		/// </summary>
		// Token: 0x0601662B RID: 91691 RVA: 0x001F7948 File Offset: 0x001F5B48
		public virtual int GetSubsampleRate()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetSubsampleRate_08(base.GetCppThis());
		}

		// Token: 0x0601662C RID: 91692
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRTAnalyticSource_GetWholeExtent_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the extent of the whole output image. Initial value is
		/// {-10,10,-10,10,-10,10}
		/// </summary>
		// Token: 0x0601662D RID: 91693 RVA: 0x001F7968 File Offset: 0x001F5B68
		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkRTAnalyticSource.vtkRTAnalyticSource_GetWholeExtent_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601662E RID: 91694
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_GetWholeExtent_10(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set/Get the extent of the whole output image. Initial value is
		/// {-10,10,-10,10,-10,10}
		/// </summary>
		// Token: 0x0601662F RID: 91695 RVA: 0x001F79B0 File Offset: 0x001F5BB0
		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_GetWholeExtent_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06016630 RID: 91696
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_GetWholeExtent_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the extent of the whole output image. Initial value is
		/// {-10,10,-10,10,-10,10}
		/// </summary>
		// Token: 0x06016631 RID: 91697 RVA: 0x001F79C8 File Offset: 0x001F5BC8
		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_GetWholeExtent_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06016632 RID: 91698
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRTAnalyticSource_GetXFreq_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the natural frequency in x. Initial value is 60.
		/// </summary>
		// Token: 0x06016633 RID: 91699 RVA: 0x001F79D8 File Offset: 0x001F5BD8
		public virtual double GetXFreq()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetXFreq_12(base.GetCppThis());
		}

		// Token: 0x06016634 RID: 91700
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRTAnalyticSource_GetXMag_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the magnitude in x. Initial value is 10.
		/// </summary>
		// Token: 0x06016635 RID: 91701 RVA: 0x001F79F8 File Offset: 0x001F5BF8
		public virtual double GetXMag()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetXMag_13(base.GetCppThis());
		}

		// Token: 0x06016636 RID: 91702
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRTAnalyticSource_GetYFreq_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the natural frequency in y. Initial value is 30.
		/// </summary>
		// Token: 0x06016637 RID: 91703 RVA: 0x001F7A18 File Offset: 0x001F5C18
		public virtual double GetYFreq()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetYFreq_14(base.GetCppThis());
		}

		// Token: 0x06016638 RID: 91704
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRTAnalyticSource_GetYMag_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the magnitude in y. Initial value is 18.
		/// </summary>
		// Token: 0x06016639 RID: 91705 RVA: 0x001F7A38 File Offset: 0x001F5C38
		public virtual double GetYMag()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetYMag_15(base.GetCppThis());
		}

		// Token: 0x0601663A RID: 91706
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRTAnalyticSource_GetZFreq_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the natural frequency in z. Initial value is 40.
		/// </summary>
		// Token: 0x0601663B RID: 91707 RVA: 0x001F7A58 File Offset: 0x001F5C58
		public virtual double GetZFreq()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetZFreq_16(base.GetCppThis());
		}

		// Token: 0x0601663C RID: 91708
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRTAnalyticSource_GetZMag_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the magnitude in z. Initial value is 5.
		/// </summary>
		// Token: 0x0601663D RID: 91709 RVA: 0x001F7A78 File Offset: 0x001F5C78
		public virtual double GetZMag()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetZMag_17(base.GetCppThis());
		}

		// Token: 0x0601663E RID: 91710
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRTAnalyticSource_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601663F RID: 91711 RVA: 0x001F7A98 File Offset: 0x001F5C98
		public override int IsA(string type)
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x06016640 RID: 91712
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRTAnalyticSource_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016641 RID: 91713 RVA: 0x001F7AB8 File Offset: 0x001F5CB8
		public new static int IsTypeOf(string type)
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_IsTypeOf_19(type);
		}

		// Token: 0x06016642 RID: 91714
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRTAnalyticSource_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016643 RID: 91715 RVA: 0x001F7AD4 File Offset: 0x001F5CD4
		public new vtkRTAnalyticSource NewInstance()
		{
			vtkRTAnalyticSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRTAnalyticSource.vtkRTAnalyticSource_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRTAnalyticSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016644 RID: 91716
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRTAnalyticSource_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016645 RID: 91717 RVA: 0x001F7B30 File Offset: 0x001F5D30
		public new static vtkRTAnalyticSource SafeDownCast(vtkObjectBase o)
		{
			vtkRTAnalyticSource vtkRTAnalyticSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRTAnalyticSource.vtkRTAnalyticSource_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRTAnalyticSource = (vtkRTAnalyticSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRTAnalyticSource.Register(null);
				}
			}
			return vtkRTAnalyticSource;
		}

		// Token: 0x06016646 RID: 91718
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_SetCenter_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the center of function. Initial value is {0.0,0.0,0.0}
		/// </summary>
		// Token: 0x06016647 RID: 91719 RVA: 0x001F7BAF File Offset: 0x001F5DAF
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetCenter_23(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06016648 RID: 91720
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_SetCenter_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the center of function. Initial value is {0.0,0.0,0.0}
		/// </summary>
		// Token: 0x06016649 RID: 91721 RVA: 0x001F7BC1 File Offset: 0x001F5DC1
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetCenter_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0601664A RID: 91722
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_SetMaximum_25(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Maximum value of the function. Initial value is 255.0.
		/// </summary>
		// Token: 0x0601664B RID: 91723 RVA: 0x001F7BD1 File Offset: 0x001F5DD1
		public virtual void SetMaximum(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetMaximum_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0601664C RID: 91724
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_SetStandardDeviation_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the standard deviation of the function. Initial value is 0.5.
		/// </summary>
		// Token: 0x0601664D RID: 91725 RVA: 0x001F7BE1 File Offset: 0x001F5DE1
		public virtual void SetStandardDeviation(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetStandardDeviation_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0601664E RID: 91726
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_SetSubsampleRate_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the sub-sample rate. Initial value is 1.
		/// </summary>
		// Token: 0x0601664F RID: 91727 RVA: 0x001F7BF1 File Offset: 0x001F5DF1
		public virtual void SetSubsampleRate(int _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetSubsampleRate_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06016650 RID: 91728
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_SetWholeExtent_28(HandleRef pThis, int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax);

		/// <summary>
		/// Set/Get the extent of the whole output image. Initial value is
		/// {-10,10,-10,10,-10,10}
		/// </summary>
		// Token: 0x06016651 RID: 91729 RVA: 0x001F7C01 File Offset: 0x001F5E01
		public void SetWholeExtent(int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetWholeExtent_28(base.GetCppThis(), xMinx, xMax, yMin, yMax, zMin, zMax);
		}

		// Token: 0x06016652 RID: 91730
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_SetXFreq_29(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the natural frequency in x. Initial value is 60.
		/// </summary>
		// Token: 0x06016653 RID: 91731 RVA: 0x001F7C19 File Offset: 0x001F5E19
		public virtual void SetXFreq(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetXFreq_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06016654 RID: 91732
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_SetXMag_30(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the magnitude in x. Initial value is 10.
		/// </summary>
		// Token: 0x06016655 RID: 91733 RVA: 0x001F7C29 File Offset: 0x001F5E29
		public virtual void SetXMag(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetXMag_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06016656 RID: 91734
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_SetYFreq_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the natural frequency in y. Initial value is 30.
		/// </summary>
		// Token: 0x06016657 RID: 91735 RVA: 0x001F7C39 File Offset: 0x001F5E39
		public virtual void SetYFreq(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetYFreq_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06016658 RID: 91736
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_SetYMag_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the magnitude in y. Initial value is 18.
		/// </summary>
		// Token: 0x06016659 RID: 91737 RVA: 0x001F7C49 File Offset: 0x001F5E49
		public virtual void SetYMag(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetYMag_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0601665A RID: 91738
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_SetZFreq_33(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the natural frequency in z. Initial value is 40.
		/// </summary>
		// Token: 0x0601665B RID: 91739 RVA: 0x001F7C59 File Offset: 0x001F5E59
		public virtual void SetZFreq(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetZFreq_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0601665C RID: 91740
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRTAnalyticSource_SetZMag_34(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the magnitude in z. Initial value is 5.
		/// </summary>
		// Token: 0x0601665D RID: 91741 RVA: 0x001F7C69 File Offset: 0x001F5E69
		public virtual void SetZMag(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetZMag_34(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400192E RID: 6446
		public new const string MRFullTypeName = "Kitware.VTK.vtkRTAnalyticSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400192F RID: 6447
		public new static readonly string MRClassNameKey = "class vtkRTAnalyticSource";
	}
}
