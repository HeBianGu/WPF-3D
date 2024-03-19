using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageChangeInformation
	/// </summary>
	/// <remarks>
	///    modify spacing, origin and extent.
	///
	/// vtkImageChangeInformation  modify the spacing, origin, or extent of
	/// the data without changing the data itself.  The data is not resampled
	/// by this filter, only the information accompanying the data is modified.
	/// </remarks>
	// Token: 0x02000853 RID: 2131
	public class vtkImageChangeInformation : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601618E RID: 90510 RVA: 0x001F1D3D File Offset: 0x001EFF3D
		static vtkImageChangeInformation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageChangeInformation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageChangeInformation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601618F RID: 90511 RVA: 0x001F1D65 File Offset: 0x001EFF65
		public vtkImageChangeInformation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016190 RID: 90512
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageChangeInformation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016191 RID: 90513 RVA: 0x001F1D74 File Offset: 0x001EFF74
		public new static vtkImageChangeInformation New()
		{
			vtkImageChangeInformation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageChangeInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016192 RID: 90514 RVA: 0x001F1DC8 File Offset: 0x001EFFC8
		public vtkImageChangeInformation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageChangeInformation.vtkImageChangeInformation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016193 RID: 90515 RVA: 0x001F1E0C File Offset: 0x001F000C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016194 RID: 90516
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_CenterImageOff_01(HandleRef pThis);

		/// <summary>
		/// Set the Origin of the output so that image coordinate (0,0,0)
		/// lies at the Center of the data set.  This will override
		/// SetOutputOrigin.  This is often a useful operation to apply
		/// before using vtkImageReslice to apply a transformation to an image.
		/// </summary>
		// Token: 0x06016195 RID: 90517 RVA: 0x001F1E17 File Offset: 0x001F0017
		public virtual void CenterImageOff()
		{
			vtkImageChangeInformation.vtkImageChangeInformation_CenterImageOff_01(base.GetCppThis());
		}

		// Token: 0x06016196 RID: 90518
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_CenterImageOn_02(HandleRef pThis);

		/// <summary>
		/// Set the Origin of the output so that image coordinate (0,0,0)
		/// lies at the Center of the data set.  This will override
		/// SetOutputOrigin.  This is often a useful operation to apply
		/// before using vtkImageReslice to apply a transformation to an image.
		/// </summary>
		// Token: 0x06016197 RID: 90519 RVA: 0x001F1E26 File Offset: 0x001F0026
		public virtual void CenterImageOn()
		{
			vtkImageChangeInformation.vtkImageChangeInformation_CenterImageOn_02(base.GetCppThis());
		}

		// Token: 0x06016198 RID: 90520
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageChangeInformation_GetCenterImage_03(HandleRef pThis);

		/// <summary>
		/// Set the Origin of the output so that image coordinate (0,0,0)
		/// lies at the Center of the data set.  This will override
		/// SetOutputOrigin.  This is often a useful operation to apply
		/// before using vtkImageReslice to apply a transformation to an image.
		/// </summary>
		// Token: 0x06016199 RID: 90521 RVA: 0x001F1E38 File Offset: 0x001F0038
		public virtual int GetCenterImage()
		{
			return vtkImageChangeInformation.vtkImageChangeInformation_GetCenterImage_03(base.GetCppThis());
		}

		// Token: 0x0601619A RID: 90522
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageChangeInformation_GetExtentTranslation_04(HandleRef pThis);

		/// <summary>
		/// Apply a translation to the extent.
		/// </summary>
		// Token: 0x0601619B RID: 90523 RVA: 0x001F1E58 File Offset: 0x001F0058
		public virtual int[] GetExtentTranslation()
		{
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetExtentTranslation_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601619C RID: 90524
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_GetExtentTranslation_05(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Apply a translation to the extent.
		/// </summary>
		// Token: 0x0601619D RID: 90525 RVA: 0x001F1EA0 File Offset: 0x001F00A0
		public virtual void GetExtentTranslation(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetExtentTranslation_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601619E RID: 90526
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_GetExtentTranslation_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Apply a translation to the extent.
		/// </summary>
		// Token: 0x0601619F RID: 90527 RVA: 0x001F1EB2 File Offset: 0x001F00B2
		public virtual void GetExtentTranslation(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetExtentTranslation_06(base.GetCppThis(), _arg);
		}

		// Token: 0x060161A0 RID: 90528
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageChangeInformation_GetInformationInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Copy the information from another data set.  By default,
		/// the information is copied from the input.
		/// </summary>
		// Token: 0x060161A1 RID: 90529 RVA: 0x001F1EC4 File Offset: 0x001F00C4
		public virtual vtkImageData GetInformationInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetInformationInput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x060161A2 RID: 90530
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageChangeInformation_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060161A3 RID: 90531 RVA: 0x001F1F34 File Offset: 0x001F0134
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageChangeInformation.vtkImageChangeInformation_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x060161A4 RID: 90532
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageChangeInformation_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060161A5 RID: 90533 RVA: 0x001F1F54 File Offset: 0x001F0154
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageChangeInformation.vtkImageChangeInformation_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x060161A6 RID: 90534
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageChangeInformation_GetOriginScale_10(HandleRef pThis);

		/// <summary>
		/// Apply a scale to the origin.  The scale is applied
		/// before the translation.
		/// </summary>
		// Token: 0x060161A7 RID: 90535 RVA: 0x001F1F70 File Offset: 0x001F0170
		public virtual double[] GetOriginScale()
		{
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetOriginScale_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060161A8 RID: 90536
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_GetOriginScale_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Apply a scale to the origin.  The scale is applied
		/// before the translation.
		/// </summary>
		// Token: 0x060161A9 RID: 90537 RVA: 0x001F1FB8 File Offset: 0x001F01B8
		public virtual void GetOriginScale(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOriginScale_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060161AA RID: 90538
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_GetOriginScale_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Apply a scale to the origin.  The scale is applied
		/// before the translation.
		/// </summary>
		// Token: 0x060161AB RID: 90539 RVA: 0x001F1FCA File Offset: 0x001F01CA
		public virtual void GetOriginScale(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOriginScale_12(base.GetCppThis(), _arg);
		}

		// Token: 0x060161AC RID: 90540
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageChangeInformation_GetOriginTranslation_13(HandleRef pThis);

		/// <summary>
		/// Apply a translation to the origin.
		/// </summary>
		// Token: 0x060161AD RID: 90541 RVA: 0x001F1FDC File Offset: 0x001F01DC
		public virtual double[] GetOriginTranslation()
		{
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetOriginTranslation_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060161AE RID: 90542
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_GetOriginTranslation_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Apply a translation to the origin.
		/// </summary>
		// Token: 0x060161AF RID: 90543 RVA: 0x001F2024 File Offset: 0x001F0224
		public virtual void GetOriginTranslation(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOriginTranslation_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060161B0 RID: 90544
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_GetOriginTranslation_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Apply a translation to the origin.
		/// </summary>
		// Token: 0x060161B1 RID: 90545 RVA: 0x001F2036 File Offset: 0x001F0236
		public virtual void GetOriginTranslation(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOriginTranslation_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060161B2 RID: 90546
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageChangeInformation_GetOutputDirection_16(HandleRef pThis);

		/// <summary>
		/// Specify a new direction matrix explicitly.  The default is to
		/// use the direction of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161B3 RID: 90547 RVA: 0x001F2048 File Offset: 0x001F0248
		public virtual double[] GetOutputDirection()
		{
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetOutputDirection_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[9];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060161B4 RID: 90548
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_GetOutputDirection_17(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a new direction matrix explicitly.  The default is to
		/// use the direction of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161B5 RID: 90549 RVA: 0x001F2091 File Offset: 0x001F0291
		public virtual void GetOutputDirection(IntPtr data)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOutputDirection_17(base.GetCppThis(), data);
		}

		// Token: 0x060161B6 RID: 90550
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageChangeInformation_GetOutputExtentStart_18(HandleRef pThis);

		/// <summary>
		/// Specify new starting values for the extent explicitly.
		/// These values are used as WholeExtent[0], WholeExtent[2] and
		/// WholeExtent[4] of the output.  The default is to the
		/// use the extent start of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161B7 RID: 90551 RVA: 0x001F20A4 File Offset: 0x001F02A4
		public virtual int[] GetOutputExtentStart()
		{
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetOutputExtentStart_18(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060161B8 RID: 90552
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_GetOutputExtentStart_19(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Specify new starting values for the extent explicitly.
		/// These values are used as WholeExtent[0], WholeExtent[2] and
		/// WholeExtent[4] of the output.  The default is to the
		/// use the extent start of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161B9 RID: 90553 RVA: 0x001F20EC File Offset: 0x001F02EC
		public virtual void GetOutputExtentStart(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOutputExtentStart_19(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060161BA RID: 90554
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_GetOutputExtentStart_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify new starting values for the extent explicitly.
		/// These values are used as WholeExtent[0], WholeExtent[2] and
		/// WholeExtent[4] of the output.  The default is to the
		/// use the extent start of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161BB RID: 90555 RVA: 0x001F20FE File Offset: 0x001F02FE
		public virtual void GetOutputExtentStart(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOutputExtentStart_20(base.GetCppThis(), _arg);
		}

		// Token: 0x060161BC RID: 90556
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageChangeInformation_GetOutputOrigin_21(HandleRef pThis);

		/// <summary>
		/// Specify a new data origin explicitly.  The default is to
		/// use the origin of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161BD RID: 90557 RVA: 0x001F2110 File Offset: 0x001F0310
		public virtual double[] GetOutputOrigin()
		{
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetOutputOrigin_21(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060161BE RID: 90558
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_GetOutputOrigin_22(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Specify a new data origin explicitly.  The default is to
		/// use the origin of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161BF RID: 90559 RVA: 0x001F2158 File Offset: 0x001F0358
		public virtual void GetOutputOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOutputOrigin_22(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060161C0 RID: 90560
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_GetOutputOrigin_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a new data origin explicitly.  The default is to
		/// use the origin of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161C1 RID: 90561 RVA: 0x001F216A File Offset: 0x001F036A
		public virtual void GetOutputOrigin(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOutputOrigin_23(base.GetCppThis(), _arg);
		}

		// Token: 0x060161C2 RID: 90562
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageChangeInformation_GetOutputSpacing_24(HandleRef pThis);

		/// <summary>
		/// Specify a new data spacing explicitly.  The default is to
		/// use the spacing of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161C3 RID: 90563 RVA: 0x001F217C File Offset: 0x001F037C
		public virtual double[] GetOutputSpacing()
		{
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetOutputSpacing_24(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060161C4 RID: 90564
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_GetOutputSpacing_25(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Specify a new data spacing explicitly.  The default is to
		/// use the spacing of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161C5 RID: 90565 RVA: 0x001F21C4 File Offset: 0x001F03C4
		public virtual void GetOutputSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOutputSpacing_25(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060161C6 RID: 90566
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_GetOutputSpacing_26(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a new data spacing explicitly.  The default is to
		/// use the spacing of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161C7 RID: 90567 RVA: 0x001F21D6 File Offset: 0x001F03D6
		public virtual void GetOutputSpacing(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetOutputSpacing_26(base.GetCppThis(), _arg);
		}

		// Token: 0x060161C8 RID: 90568
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageChangeInformation_GetSpacingScale_27(HandleRef pThis);

		/// <summary>
		/// Apply a scale factor to the spacing.
		/// </summary>
		// Token: 0x060161C9 RID: 90569 RVA: 0x001F21E8 File Offset: 0x001F03E8
		public virtual double[] GetSpacingScale()
		{
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_GetSpacingScale_27(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060161CA RID: 90570
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_GetSpacingScale_28(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Apply a scale factor to the spacing.
		/// </summary>
		// Token: 0x060161CB RID: 90571 RVA: 0x001F2230 File Offset: 0x001F0430
		public virtual void GetSpacingScale(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetSpacingScale_28(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060161CC RID: 90572
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_GetSpacingScale_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Apply a scale factor to the spacing.
		/// </summary>
		// Token: 0x060161CD RID: 90573 RVA: 0x001F2242 File Offset: 0x001F0442
		public virtual void GetSpacingScale(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_GetSpacingScale_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060161CE RID: 90574
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageChangeInformation_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060161CF RID: 90575 RVA: 0x001F2254 File Offset: 0x001F0454
		public override int IsA(string type)
		{
			return vtkImageChangeInformation.vtkImageChangeInformation_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x060161D0 RID: 90576
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageChangeInformation_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060161D1 RID: 90577 RVA: 0x001F2274 File Offset: 0x001F0474
		public new static int IsTypeOf(string type)
		{
			return vtkImageChangeInformation.vtkImageChangeInformation_IsTypeOf_31(type);
		}

		// Token: 0x060161D2 RID: 90578
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageChangeInformation_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060161D3 RID: 90579 RVA: 0x001F2290 File Offset: 0x001F0490
		public new vtkImageChangeInformation NewInstance()
		{
			vtkImageChangeInformation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageChangeInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060161D4 RID: 90580
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageChangeInformation_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060161D5 RID: 90581 RVA: 0x001F22EC File Offset: 0x001F04EC
		public new static vtkImageChangeInformation SafeDownCast(vtkObjectBase o)
		{
			vtkImageChangeInformation vtkImageChangeInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageChangeInformation.vtkImageChangeInformation_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageChangeInformation = (vtkImageChangeInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageChangeInformation.Register(null);
				}
			}
			return vtkImageChangeInformation;
		}

		// Token: 0x060161D6 RID: 90582
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetCenterImage_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the Origin of the output so that image coordinate (0,0,0)
		/// lies at the Center of the data set.  This will override
		/// SetOutputOrigin.  This is often a useful operation to apply
		/// before using vtkImageReslice to apply a transformation to an image.
		/// </summary>
		// Token: 0x060161D7 RID: 90583 RVA: 0x001F236B File Offset: 0x001F056B
		public virtual void SetCenterImage(int _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetCenterImage_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060161D8 RID: 90584
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetExtentTranslation_36(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Apply a translation to the extent.
		/// </summary>
		// Token: 0x060161D9 RID: 90585 RVA: 0x001F237B File Offset: 0x001F057B
		public virtual void SetExtentTranslation(int _arg1, int _arg2, int _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetExtentTranslation_36(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060161DA RID: 90586
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetExtentTranslation_37(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Apply a translation to the extent.
		/// </summary>
		// Token: 0x060161DB RID: 90587 RVA: 0x001F238D File Offset: 0x001F058D
		public virtual void SetExtentTranslation(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetExtentTranslation_37(base.GetCppThis(), _arg);
		}

		// Token: 0x060161DC RID: 90588
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetInformationInputData_38(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Copy the information from another data set.  By default,
		/// the information is copied from the input.
		/// </summary>
		// Token: 0x060161DD RID: 90589 RVA: 0x001F23A0 File Offset: 0x001F05A0
		public virtual void SetInformationInputData(vtkImageData arg0)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetInformationInputData_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060161DE RID: 90590
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetOriginScale_39(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Apply a scale to the origin.  The scale is applied
		/// before the translation.
		/// </summary>
		// Token: 0x060161DF RID: 90591 RVA: 0x001F23CF File Offset: 0x001F05CF
		public virtual void SetOriginScale(double _arg1, double _arg2, double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOriginScale_39(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060161E0 RID: 90592
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetOriginScale_40(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Apply a scale to the origin.  The scale is applied
		/// before the translation.
		/// </summary>
		// Token: 0x060161E1 RID: 90593 RVA: 0x001F23E1 File Offset: 0x001F05E1
		public virtual void SetOriginScale(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOriginScale_40(base.GetCppThis(), _arg);
		}

		// Token: 0x060161E2 RID: 90594
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetOriginTranslation_41(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Apply a translation to the origin.
		/// </summary>
		// Token: 0x060161E3 RID: 90595 RVA: 0x001F23F1 File Offset: 0x001F05F1
		public virtual void SetOriginTranslation(double _arg1, double _arg2, double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOriginTranslation_41(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060161E4 RID: 90596
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetOriginTranslation_42(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Apply a translation to the origin.
		/// </summary>
		// Token: 0x060161E5 RID: 90597 RVA: 0x001F2403 File Offset: 0x001F0603
		public virtual void SetOriginTranslation(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOriginTranslation_42(base.GetCppThis(), _arg);
		}

		// Token: 0x060161E6 RID: 90598
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetOutputDirection_43(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a new direction matrix explicitly.  The default is to
		/// use the direction of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161E7 RID: 90599 RVA: 0x001F2413 File Offset: 0x001F0613
		public virtual void SetOutputDirection(IntPtr data)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOutputDirection_43(base.GetCppThis(), data);
		}

		// Token: 0x060161E8 RID: 90600
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetOutputExtentStart_44(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Specify new starting values for the extent explicitly.
		/// These values are used as WholeExtent[0], WholeExtent[2] and
		/// WholeExtent[4] of the output.  The default is to the
		/// use the extent start of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161E9 RID: 90601 RVA: 0x001F2423 File Offset: 0x001F0623
		public virtual void SetOutputExtentStart(int _arg1, int _arg2, int _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOutputExtentStart_44(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060161EA RID: 90602
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetOutputExtentStart_45(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify new starting values for the extent explicitly.
		/// These values are used as WholeExtent[0], WholeExtent[2] and
		/// WholeExtent[4] of the output.  The default is to the
		/// use the extent start of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161EB RID: 90603 RVA: 0x001F2435 File Offset: 0x001F0635
		public virtual void SetOutputExtentStart(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOutputExtentStart_45(base.GetCppThis(), _arg);
		}

		// Token: 0x060161EC RID: 90604
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetOutputOrigin_46(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a new data origin explicitly.  The default is to
		/// use the origin of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161ED RID: 90605 RVA: 0x001F2445 File Offset: 0x001F0645
		public virtual void SetOutputOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOutputOrigin_46(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060161EE RID: 90606
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetOutputOrigin_47(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a new data origin explicitly.  The default is to
		/// use the origin of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161EF RID: 90607 RVA: 0x001F2457 File Offset: 0x001F0657
		public virtual void SetOutputOrigin(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOutputOrigin_47(base.GetCppThis(), _arg);
		}

		// Token: 0x060161F0 RID: 90608
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetOutputSpacing_48(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a new data spacing explicitly.  The default is to
		/// use the spacing of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161F1 RID: 90609 RVA: 0x001F2467 File Offset: 0x001F0667
		public virtual void SetOutputSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOutputSpacing_48(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060161F2 RID: 90610
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetOutputSpacing_49(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a new data spacing explicitly.  The default is to
		/// use the spacing of the Input, or of the InformationInput
		/// if InformationInput is set.
		/// </summary>
		// Token: 0x060161F3 RID: 90611 RVA: 0x001F2479 File Offset: 0x001F0679
		public virtual void SetOutputSpacing(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetOutputSpacing_49(base.GetCppThis(), _arg);
		}

		// Token: 0x060161F4 RID: 90612
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetSpacingScale_50(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Apply a scale factor to the spacing.
		/// </summary>
		// Token: 0x060161F5 RID: 90613 RVA: 0x001F2489 File Offset: 0x001F0689
		public virtual void SetSpacingScale(double _arg1, double _arg2, double _arg3)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetSpacingScale_50(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060161F6 RID: 90614
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageChangeInformation_SetSpacingScale_51(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Apply a scale factor to the spacing.
		/// </summary>
		// Token: 0x060161F7 RID: 90615 RVA: 0x001F249B File Offset: 0x001F069B
		public virtual void SetSpacingScale(IntPtr _arg)
		{
			vtkImageChangeInformation.vtkImageChangeInformation_SetSpacingScale_51(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018FA RID: 6394
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageChangeInformation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018FB RID: 6395
		public new static readonly string MRClassNameKey = "class vtkImageChangeInformation";
	}
}
