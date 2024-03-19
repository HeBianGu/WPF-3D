using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageResample
	/// </summary>
	/// <remarks>
	///    Resamples an image to be larger or smaller.
	///
	/// This filter produces an output with different spacing (and extent)
	/// than the input.  Linear interpolation can be used to resample the data.
	/// The Output spacing can be set explicitly or relative to input spacing
	/// with the SetAxisMagnificationFactor method.
	/// </remarks>
	// Token: 0x02000861 RID: 2145
	public class vtkImageResample : vtkImageReslice
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601639C RID: 91036 RVA: 0x001F4AAB File Offset: 0x001F2CAB
		static vtkImageResample()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageResample.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageResample"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601639D RID: 91037 RVA: 0x001F4AD3 File Offset: 0x001F2CD3
		public vtkImageResample(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601639E RID: 91038
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResample_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601639F RID: 91039 RVA: 0x001F4AE4 File Offset: 0x001F2CE4
		public new static vtkImageResample New()
		{
			vtkImageResample result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageResample.vtkImageResample_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageResample)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060163A0 RID: 91040 RVA: 0x001F4B38 File Offset: 0x001F2D38
		public vtkImageResample() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageResample.vtkImageResample_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060163A1 RID: 91041 RVA: 0x001F4B7C File Offset: 0x001F2D7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060163A2 RID: 91042
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageResample_GetAxisMagnificationFactor_01(HandleRef pThis, int axis, HandleRef inInfo);

		/// <summary>
		/// Get the computed magnification factor for a specific axis.
		/// The input information is required to compute the value.
		/// </summary>
		// Token: 0x060163A3 RID: 91043 RVA: 0x001F4B88 File Offset: 0x001F2D88
		public double GetAxisMagnificationFactor(int axis, vtkInformation inInfo)
		{
			return vtkImageResample.vtkImageResample_GetAxisMagnificationFactor_01(base.GetCppThis(), axis, (inInfo == null) ? default(HandleRef) : inInfo.GetCppThis());
		}

		// Token: 0x060163A4 RID: 91044
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResample_GetDimensionality_02(HandleRef pThis);

		/// <summary>
		/// Dimensionality is the number of axes which are considered during
		/// execution. To process images dimensionality would be set to 2.
		/// This has the same effect as setting the magnification of the third
		/// axis to 1.0
		/// </summary>
		// Token: 0x060163A5 RID: 91045 RVA: 0x001F4BC0 File Offset: 0x001F2DC0
		public virtual int GetDimensionality()
		{
			return vtkImageResample.vtkImageResample_GetDimensionality_02(base.GetCppThis());
		}

		// Token: 0x060163A6 RID: 91046
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResample_GetMagnificationFactors_03(HandleRef pThis);

		/// <summary>
		/// Set/Get Magnification factors.
		/// Zero is a reserved value indicating values have not been computed.
		/// </summary>
		// Token: 0x060163A7 RID: 91047 RVA: 0x001F4BE0 File Offset: 0x001F2DE0
		public virtual double[] GetMagnificationFactors()
		{
			IntPtr intPtr = vtkImageResample.vtkImageResample_GetMagnificationFactors_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060163A8 RID: 91048
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResample_GetMagnificationFactors_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get Magnification factors.
		/// Zero is a reserved value indicating values have not been computed.
		/// </summary>
		// Token: 0x060163A9 RID: 91049 RVA: 0x001F4C28 File Offset: 0x001F2E28
		public virtual void GetMagnificationFactors(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageResample.vtkImageResample_GetMagnificationFactors_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060163AA RID: 91050
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResample_GetMagnificationFactors_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get Magnification factors.
		/// Zero is a reserved value indicating values have not been computed.
		/// </summary>
		// Token: 0x060163AB RID: 91051 RVA: 0x001F4C3A File Offset: 0x001F2E3A
		public virtual void GetMagnificationFactors(IntPtr _arg)
		{
			vtkImageResample.vtkImageResample_GetMagnificationFactors_05(base.GetCppThis(), _arg);
		}

		// Token: 0x060163AC RID: 91052
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageResample_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060163AD RID: 91053 RVA: 0x001F4C4C File Offset: 0x001F2E4C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageResample.vtkImageResample_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060163AE RID: 91054
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageResample_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060163AF RID: 91055 RVA: 0x001F4C6C File Offset: 0x001F2E6C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageResample.vtkImageResample_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060163B0 RID: 91056
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResample_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060163B1 RID: 91057 RVA: 0x001F4C88 File Offset: 0x001F2E88
		public override int IsA(string type)
		{
			return vtkImageResample.vtkImageResample_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060163B2 RID: 91058
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResample_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060163B3 RID: 91059 RVA: 0x001F4CA8 File Offset: 0x001F2EA8
		public new static int IsTypeOf(string type)
		{
			return vtkImageResample.vtkImageResample_IsTypeOf_09(type);
		}

		// Token: 0x060163B4 RID: 91060
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResample_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060163B5 RID: 91061 RVA: 0x001F4CC4 File Offset: 0x001F2EC4
		public new vtkImageResample NewInstance()
		{
			vtkImageResample result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageResample.vtkImageResample_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageResample)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060163B6 RID: 91062
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResample_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060163B7 RID: 91063 RVA: 0x001F4D20 File Offset: 0x001F2F20
		public new static vtkImageResample SafeDownCast(vtkObjectBase o)
		{
			vtkImageResample vtkImageResample = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageResample.vtkImageResample_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageResample = (vtkImageResample)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageResample.Register(null);
				}
			}
			return vtkImageResample;
		}

		// Token: 0x060163B8 RID: 91064
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResample_SetAxisMagnificationFactor_13(HandleRef pThis, int axis, double factor);

		/// <summary>
		/// Set/Get Magnification factors.
		/// Zero is a reserved value indicating values have not been computed.
		/// </summary>
		// Token: 0x060163B9 RID: 91065 RVA: 0x001F4D9F File Offset: 0x001F2F9F
		public void SetAxisMagnificationFactor(int axis, double factor)
		{
			vtkImageResample.vtkImageResample_SetAxisMagnificationFactor_13(base.GetCppThis(), axis, factor);
		}

		// Token: 0x060163BA RID: 91066
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResample_SetAxisOutputSpacing_14(HandleRef pThis, int axis, double spacing);

		/// <summary>
		/// Set desired spacing.
		/// Zero is a reserved value indicating spacing has not been set.
		/// </summary>
		// Token: 0x060163BB RID: 91067 RVA: 0x001F4DB0 File Offset: 0x001F2FB0
		public void SetAxisOutputSpacing(int axis, double spacing)
		{
			vtkImageResample.vtkImageResample_SetAxisOutputSpacing_14(base.GetCppThis(), axis, spacing);
		}

		// Token: 0x060163BC RID: 91068
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResample_SetDimensionality_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Dimensionality is the number of axes which are considered during
		/// execution. To process images dimensionality would be set to 2.
		/// This has the same effect as setting the magnification of the third
		/// axis to 1.0
		/// </summary>
		// Token: 0x060163BD RID: 91069 RVA: 0x001F4DC1 File Offset: 0x001F2FC1
		public virtual void SetDimensionality(int _arg)
		{
			vtkImageResample.vtkImageResample_SetDimensionality_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060163BE RID: 91070
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResample_SetMagnificationFactors_16(HandleRef pThis, double fx, double fy, double fz);

		/// <summary>
		/// Set/Get Magnification factors.
		/// Zero is a reserved value indicating values have not been computed.
		/// </summary>
		// Token: 0x060163BF RID: 91071 RVA: 0x001F4DD1 File Offset: 0x001F2FD1
		public void SetMagnificationFactors(double fx, double fy, double fz)
		{
			vtkImageResample.vtkImageResample_SetMagnificationFactors_16(base.GetCppThis(), fx, fy, fz);
		}

		// Token: 0x060163C0 RID: 91072
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResample_SetMagnificationFactors_17(HandleRef pThis, IntPtr f);

		/// <summary>
		/// Set/Get Magnification factors.
		/// Zero is a reserved value indicating values have not been computed.
		/// </summary>
		// Token: 0x060163C1 RID: 91073 RVA: 0x001F4DE3 File Offset: 0x001F2FE3
		public void SetMagnificationFactors(IntPtr f)
		{
			vtkImageResample.vtkImageResample_SetMagnificationFactors_17(base.GetCppThis(), f);
		}

		// Token: 0x060163C2 RID: 91074
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResample_SetOutputSpacing_18(HandleRef pThis, double sx, double sy, double sz);

		/// <summary>
		/// Set desired spacing.
		/// Zero is a reserved value indicating spacing has not been set.
		/// </summary>
		// Token: 0x060163C3 RID: 91075 RVA: 0x001F4DF3 File Offset: 0x001F2FF3
		public override void SetOutputSpacing(double sx, double sy, double sz)
		{
			vtkImageResample.vtkImageResample_SetOutputSpacing_18(base.GetCppThis(), sx, sy, sz);
		}

		// Token: 0x060163C4 RID: 91076
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResample_SetOutputSpacing_19(HandleRef pThis, IntPtr spacing);

		/// <summary>
		/// Set desired spacing.
		/// Zero is a reserved value indicating spacing has not been set.
		/// </summary>
		// Token: 0x060163C5 RID: 91077 RVA: 0x001F4E05 File Offset: 0x001F3005
		public override void SetOutputSpacing(IntPtr spacing)
		{
			vtkImageResample.vtkImageResample_SetOutputSpacing_19(base.GetCppThis(), spacing);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001916 RID: 6422
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageResample";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001917 RID: 6423
		public new static readonly string MRClassNameKey = "class vtkImageResample";
	}
}
