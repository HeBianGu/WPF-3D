using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageMandelbrotSource
	/// </summary>
	/// <remarks>
	///    Mandelbrot image.
	///
	/// vtkImageMandelbrotSource creates an unsigned char image of the Mandelbrot
	/// set.  The values in the image are the number of iterations it takes for
	/// the magnitude of the value to get over 2.  The equation repeated is
	/// z = z^2 + C (z and C are complex).  Initial value of z is zero, and the
	/// real value of C is mapped onto the x axis, and the imaginary value of C
	/// is mapped onto the Y Axis.  I was thinking of extending this source
	/// to generate Julia Sets (initial value of Z varies).  This would be 4
	/// possible parameters to vary, but there are no more 4d images :(
	/// The third dimension (z axis) is the imaginary value of the initial value.
	/// </remarks>
	// Token: 0x02000758 RID: 1880
	public class vtkImageMandelbrotSource : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013843 RID: 79939 RVA: 0x001B95FE File Offset: 0x001B77FE
		static vtkImageMandelbrotSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMandelbrotSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMandelbrotSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013844 RID: 79940 RVA: 0x001B9626 File Offset: 0x001B7826
		public vtkImageMandelbrotSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013845 RID: 79941
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMandelbrotSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013846 RID: 79942 RVA: 0x001B9634 File Offset: 0x001B7834
		public new static vtkImageMandelbrotSource New()
		{
			vtkImageMandelbrotSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMandelbrotSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013847 RID: 79943 RVA: 0x001B9688 File Offset: 0x001B7888
		public vtkImageMandelbrotSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageMandelbrotSource.vtkImageMandelbrotSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013848 RID: 79944 RVA: 0x001B96CC File Offset: 0x001B78CC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013849 RID: 79945
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_ConstantSizeOff_01(HandleRef pThis);

		/// <summary>
		/// This flag determines whether the Size or spacing of
		/// a data set remain constant (when extent is changed).
		/// By default, size remains constant.
		/// </summary>
		// Token: 0x0601384A RID: 79946 RVA: 0x001B96D7 File Offset: 0x001B78D7
		public virtual void ConstantSizeOff()
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_ConstantSizeOff_01(base.GetCppThis());
		}

		// Token: 0x0601384B RID: 79947
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_ConstantSizeOn_02(HandleRef pThis);

		/// <summary>
		/// This flag determines whether the Size or spacing of
		/// a data set remain constant (when extent is changed).
		/// By default, size remains constant.
		/// </summary>
		// Token: 0x0601384C RID: 79948 RVA: 0x001B96E6 File Offset: 0x001B78E6
		public virtual void ConstantSizeOn()
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_ConstantSizeOn_02(base.GetCppThis());
		}

		// Token: 0x0601384D RID: 79949
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_CopyOriginAndSample_03(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Convenience for Viewer.  Copy the OriginCX and the SpacingCX.
		/// What about other parameters ???
		/// </summary>
		// Token: 0x0601384E RID: 79950 RVA: 0x001B96F8 File Offset: 0x001B78F8
		public void CopyOriginAndSample(vtkImageMandelbrotSource source)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_CopyOriginAndSample_03(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601384F RID: 79951
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMandelbrotSource_GetConstantSize_04(HandleRef pThis);

		/// <summary>
		/// This flag determines whether the Size or spacing of
		/// a data set remain constant (when extent is changed).
		/// By default, size remains constant.
		/// </summary>
		// Token: 0x06013850 RID: 79952 RVA: 0x001B9728 File Offset: 0x001B7928
		public virtual int GetConstantSize()
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetConstantSize_04(base.GetCppThis());
		}

		// Token: 0x06013851 RID: 79953
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkImageMandelbrotSource_GetMaximumNumberOfIterations_05(HandleRef pThis);

		/// <summary>
		/// The maximum number of cycles run to see if the value goes over 2
		/// </summary>
		// Token: 0x06013852 RID: 79954 RVA: 0x001B9748 File Offset: 0x001B7948
		public virtual ushort GetMaximumNumberOfIterations()
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetMaximumNumberOfIterations_05(base.GetCppThis());
		}

		// Token: 0x06013853 RID: 79955
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkImageMandelbrotSource_GetMaximumNumberOfIterationsMaxValue_06(HandleRef pThis);

		/// <summary>
		/// The maximum number of cycles run to see if the value goes over 2
		/// </summary>
		// Token: 0x06013854 RID: 79956 RVA: 0x001B9768 File Offset: 0x001B7968
		public virtual ushort GetMaximumNumberOfIterationsMaxValue()
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetMaximumNumberOfIterationsMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06013855 RID: 79957
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkImageMandelbrotSource_GetMaximumNumberOfIterationsMinValue_07(HandleRef pThis);

		/// <summary>
		/// The maximum number of cycles run to see if the value goes over 2
		/// </summary>
		// Token: 0x06013856 RID: 79958 RVA: 0x001B9788 File Offset: 0x001B7988
		public virtual ushort GetMaximumNumberOfIterationsMinValue()
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetMaximumNumberOfIterationsMinValue_07(base.GetCppThis());
		}

		// Token: 0x06013857 RID: 79959
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMandelbrotSource_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013858 RID: 79960 RVA: 0x001B97A8 File Offset: 0x001B79A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06013859 RID: 79961
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMandelbrotSource_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601385A RID: 79962 RVA: 0x001B97C8 File Offset: 0x001B79C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601385B RID: 79963
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMandelbrotSource_GetOriginCX_10(HandleRef pThis);

		/// <summary>
		/// Imaginary and real value for C (constant in equation)
		/// and X (initial value).
		/// </summary>
		// Token: 0x0601385C RID: 79964 RVA: 0x001B97E4 File Offset: 0x001B79E4
		public virtual double[] GetOriginCX()
		{
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetOriginCX_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601385D RID: 79965
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_GetOriginCX_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Imaginary and real value for C (constant in equation)
		/// and X (initial value).
		/// </summary>
		// Token: 0x0601385E RID: 79966 RVA: 0x001B982C File Offset: 0x001B7A2C
		public virtual void GetOriginCX(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetOriginCX_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x0601385F RID: 79967
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_GetOriginCX_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Imaginary and real value for C (constant in equation)
		/// and X (initial value).
		/// </summary>
		// Token: 0x06013860 RID: 79968 RVA: 0x001B9840 File Offset: 0x001B7A40
		public virtual void GetOriginCX(IntPtr _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetOriginCX_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06013861 RID: 79969
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMandelbrotSource_GetProjectionAxes_13(HandleRef pThis);

		/// <summary>
		/// Set the projection from the 4D space (4 parameters / 2 imaginary numbers)
		/// to the axes of the 3D Volume.
		/// 0=C_Real, 1=C_Imaginary, 2=X_Real, 4=X_Imaginary
		/// </summary>
		// Token: 0x06013862 RID: 79970 RVA: 0x001B9850 File Offset: 0x001B7A50
		public virtual int[] GetProjectionAxes()
		{
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetProjectionAxes_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013863 RID: 79971
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_GetProjectionAxes_14(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Set the projection from the 4D space (4 parameters / 2 imaginary numbers)
		/// to the axes of the 3D Volume.
		/// 0=C_Real, 1=C_Imaginary, 2=X_Real, 4=X_Imaginary
		/// </summary>
		// Token: 0x06013864 RID: 79972 RVA: 0x001B9898 File Offset: 0x001B7A98
		public virtual void GetProjectionAxes(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetProjectionAxes_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06013865 RID: 79973
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_GetProjectionAxes_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the projection from the 4D space (4 parameters / 2 imaginary numbers)
		/// to the axes of the 3D Volume.
		/// 0=C_Real, 1=C_Imaginary, 2=X_Real, 4=X_Imaginary
		/// </summary>
		// Token: 0x06013866 RID: 79974 RVA: 0x001B98AA File Offset: 0x001B7AAA
		public virtual void GetProjectionAxes(IntPtr _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetProjectionAxes_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06013867 RID: 79975
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMandelbrotSource_GetSampleCX_16(HandleRef pThis);

		/// <summary>
		/// Imaginary and real value for C (constant in equation)
		/// and X (initial value).
		/// </summary>
		// Token: 0x06013868 RID: 79976 RVA: 0x001B98BC File Offset: 0x001B7ABC
		public virtual double[] GetSampleCX()
		{
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSampleCX_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013869 RID: 79977
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_GetSampleCX_17(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Imaginary and real value for C (constant in equation)
		/// and X (initial value).
		/// </summary>
		// Token: 0x0601386A RID: 79978 RVA: 0x001B9904 File Offset: 0x001B7B04
		public virtual void GetSampleCX(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSampleCX_17(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x0601386B RID: 79979
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_GetSampleCX_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Imaginary and real value for C (constant in equation)
		/// and X (initial value).
		/// </summary>
		// Token: 0x0601386C RID: 79980 RVA: 0x001B9918 File Offset: 0x001B7B18
		public virtual void GetSampleCX(IntPtr _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSampleCX_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601386D RID: 79981
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMandelbrotSource_GetSizeCX_19(HandleRef pThis);

		/// <summary>
		/// Just a different way of setting the sample.
		/// This sets the size of the 4D volume.
		/// SampleCX is computed from size and extent.
		/// Size is ignored when a dimension i 0 (collapsed).
		/// </summary>
		// Token: 0x0601386E RID: 79982 RVA: 0x001B9928 File Offset: 0x001B7B28
		public double[] GetSizeCX()
		{
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSizeCX_19(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601386F RID: 79983
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_GetSizeCX_20(HandleRef pThis, IntPtr s);

		/// <summary>
		/// Just a different way of setting the sample.
		/// This sets the size of the 4D volume.
		/// SampleCX is computed from size and extent.
		/// Size is ignored when a dimension i 0 (collapsed).
		/// </summary>
		// Token: 0x06013870 RID: 79984 RVA: 0x001B9970 File Offset: 0x001B7B70
		public void GetSizeCX(IntPtr s)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSizeCX_20(base.GetCppThis(), s);
		}

		// Token: 0x06013871 RID: 79985
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMandelbrotSource_GetSubsampleRate_21(HandleRef pThis);

		/// <summary>
		/// Set/Get a subsample rate.
		/// </summary>
		// Token: 0x06013872 RID: 79986 RVA: 0x001B9980 File Offset: 0x001B7B80
		public virtual int GetSubsampleRate()
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSubsampleRate_21(base.GetCppThis());
		}

		// Token: 0x06013873 RID: 79987
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMandelbrotSource_GetSubsampleRateMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Set/Get a subsample rate.
		/// </summary>
		// Token: 0x06013874 RID: 79988 RVA: 0x001B99A0 File Offset: 0x001B7BA0
		public virtual int GetSubsampleRateMaxValue()
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSubsampleRateMaxValue_22(base.GetCppThis());
		}

		// Token: 0x06013875 RID: 79989
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMandelbrotSource_GetSubsampleRateMinValue_23(HandleRef pThis);

		/// <summary>
		/// Set/Get a subsample rate.
		/// </summary>
		// Token: 0x06013876 RID: 79990 RVA: 0x001B99C0 File Offset: 0x001B7BC0
		public virtual int GetSubsampleRateMinValue()
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSubsampleRateMinValue_23(base.GetCppThis());
		}

		// Token: 0x06013877 RID: 79991
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMandelbrotSource_GetWholeExtent_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the extent of the whole output Volume.
		/// </summary>
		// Token: 0x06013878 RID: 79992 RVA: 0x001B99E0 File Offset: 0x001B7BE0
		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetWholeExtent_24(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013879 RID: 79993
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_GetWholeExtent_25(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set/Get the extent of the whole output Volume.
		/// </summary>
		// Token: 0x0601387A RID: 79994 RVA: 0x001B9A28 File Offset: 0x001B7C28
		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetWholeExtent_25(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0601387B RID: 79995
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_GetWholeExtent_26(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the extent of the whole output Volume.
		/// </summary>
		// Token: 0x0601387C RID: 79996 RVA: 0x001B9A40 File Offset: 0x001B7C40
		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetWholeExtent_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0601387D RID: 79997
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMandelbrotSource_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601387E RID: 79998 RVA: 0x001B9A50 File Offset: 0x001B7C50
		public override int IsA(string type)
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x0601387F RID: 79999
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMandelbrotSource_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013880 RID: 80000 RVA: 0x001B9A70 File Offset: 0x001B7C70
		public new static int IsTypeOf(string type)
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_IsTypeOf_28(type);
		}

		// Token: 0x06013881 RID: 80001
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMandelbrotSource_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013882 RID: 80002 RVA: 0x001B9A8C File Offset: 0x001B7C8C
		public new vtkImageMandelbrotSource NewInstance()
		{
			vtkImageMandelbrotSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMandelbrotSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013883 RID: 80003
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_Pan_31(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Convenience for Viewer.  Pan 3D volume relative to spacing.
		/// Zoom constant factor.
		/// </summary>
		// Token: 0x06013884 RID: 80004 RVA: 0x001B9AE6 File Offset: 0x001B7CE6
		public void Pan(double x, double y, double z)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_Pan_31(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06013885 RID: 80005
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMandelbrotSource_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013886 RID: 80006 RVA: 0x001B9AF8 File Offset: 0x001B7CF8
		public new static vtkImageMandelbrotSource SafeDownCast(vtkObjectBase o)
		{
			vtkImageMandelbrotSource vtkImageMandelbrotSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMandelbrotSource = (vtkImageMandelbrotSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMandelbrotSource.Register(null);
				}
			}
			return vtkImageMandelbrotSource;
		}

		// Token: 0x06013887 RID: 80007
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_SetConstantSize_33(HandleRef pThis, int _arg);

		/// <summary>
		/// This flag determines whether the Size or spacing of
		/// a data set remain constant (when extent is changed).
		/// By default, size remains constant.
		/// </summary>
		// Token: 0x06013888 RID: 80008 RVA: 0x001B9B77 File Offset: 0x001B7D77
		public virtual void SetConstantSize(int _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetConstantSize_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06013889 RID: 80009
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_SetMaximumNumberOfIterations_34(HandleRef pThis, ushort _arg);

		/// <summary>
		/// The maximum number of cycles run to see if the value goes over 2
		/// </summary>
		// Token: 0x0601388A RID: 80010 RVA: 0x001B9B87 File Offset: 0x001B7D87
		public virtual void SetMaximumNumberOfIterations(ushort _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetMaximumNumberOfIterations_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0601388B RID: 80011
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_SetOriginCX_35(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Imaginary and real value for C (constant in equation)
		/// and X (initial value).
		/// </summary>
		// Token: 0x0601388C RID: 80012 RVA: 0x001B9B97 File Offset: 0x001B7D97
		public virtual void SetOriginCX(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetOriginCX_35(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x0601388D RID: 80013
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_SetOriginCX_36(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Imaginary and real value for C (constant in equation)
		/// and X (initial value).
		/// </summary>
		// Token: 0x0601388E RID: 80014 RVA: 0x001B9BAB File Offset: 0x001B7DAB
		public virtual void SetOriginCX(IntPtr _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetOriginCX_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0601388F RID: 80015
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_SetProjectionAxes_37(HandleRef pThis, int x, int y, int z);

		/// <summary>
		/// Set the projection from the 4D space (4 parameters / 2 imaginary numbers)
		/// to the axes of the 3D Volume.
		/// 0=C_Real, 1=C_Imaginary, 2=X_Real, 4=X_Imaginary
		/// </summary>
		// Token: 0x06013890 RID: 80016 RVA: 0x001B9BBB File Offset: 0x001B7DBB
		public void SetProjectionAxes(int x, int y, int z)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetProjectionAxes_37(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06013891 RID: 80017
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_SetProjectionAxes_38(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set the projection from the 4D space (4 parameters / 2 imaginary numbers)
		/// to the axes of the 3D Volume.
		/// 0=C_Real, 1=C_Imaginary, 2=X_Real, 4=X_Imaginary
		/// </summary>
		// Token: 0x06013892 RID: 80018 RVA: 0x001B9BCD File Offset: 0x001B7DCD
		public void SetProjectionAxes(IntPtr a)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetProjectionAxes_38(base.GetCppThis(), a);
		}

		// Token: 0x06013893 RID: 80019
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_SetSampleCX_39(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Imaginary and real value for C (constant in equation)
		/// and X (initial value).
		/// </summary>
		// Token: 0x06013894 RID: 80020 RVA: 0x001B9BDD File Offset: 0x001B7DDD
		public virtual void SetSampleCX(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetSampleCX_39(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x06013895 RID: 80021
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_SetSampleCX_40(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Imaginary and real value for C (constant in equation)
		/// and X (initial value).
		/// </summary>
		// Token: 0x06013896 RID: 80022 RVA: 0x001B9BF1 File Offset: 0x001B7DF1
		public virtual void SetSampleCX(IntPtr _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetSampleCX_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06013897 RID: 80023
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_SetSizeCX_41(HandleRef pThis, double cReal, double cImag, double xReal, double xImag);

		/// <summary>
		/// Just a different way of setting the sample.
		/// This sets the size of the 4D volume.
		/// SampleCX is computed from size and extent.
		/// Size is ignored when a dimension i 0 (collapsed).
		/// </summary>
		// Token: 0x06013898 RID: 80024 RVA: 0x001B9C01 File Offset: 0x001B7E01
		public void SetSizeCX(double cReal, double cImag, double xReal, double xImag)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetSizeCX_41(base.GetCppThis(), cReal, cImag, xReal, xImag);
		}

		// Token: 0x06013899 RID: 80025
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_SetSubsampleRate_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get a subsample rate.
		/// </summary>
		// Token: 0x0601389A RID: 80026 RVA: 0x001B9C15 File Offset: 0x001B7E15
		public virtual void SetSubsampleRate(int _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetSubsampleRate_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0601389B RID: 80027
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_SetWholeExtent_43(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Set/Get the extent of the whole output Volume.
		/// </summary>
		// Token: 0x0601389C RID: 80028 RVA: 0x001B9C25 File Offset: 0x001B7E25
		public void SetWholeExtent(IntPtr extent)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetWholeExtent_43(base.GetCppThis(), extent);
		}

		// Token: 0x0601389D RID: 80029
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_SetWholeExtent_44(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		/// <summary>
		/// Set/Get the extent of the whole output Volume.
		/// </summary>
		// Token: 0x0601389E RID: 80030 RVA: 0x001B9C35 File Offset: 0x001B7E35
		public void SetWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetWholeExtent_44(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}

		// Token: 0x0601389F RID: 80031
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMandelbrotSource_Zoom_45(HandleRef pThis, double factor);

		/// <summary>
		/// Convenience for Viewer.  Pan 3D volume relative to spacing.
		/// Zoom constant factor.
		/// </summary>
		// Token: 0x060138A0 RID: 80032 RVA: 0x001B9C4D File Offset: 0x001B7E4D
		public void Zoom(double factor)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_Zoom_45(base.GetCppThis(), factor);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400168D RID: 5773
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMandelbrotSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400168E RID: 5774
		public new static readonly string MRClassNameKey = "class vtkImageMandelbrotSource";
	}
}
