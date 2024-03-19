using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageGradient
	/// </summary>
	/// <remarks>
	///    Computes the gradient vector.
	///
	/// vtkImageGradient computes the gradient vector of an image.  The
	/// vector results are stored as scalar components. The Dimensionality
	/// determines whether to perform a 2d or 3d gradient. The default is
	/// two dimensional XY gradient.  OutputScalarType is always
	/// double. Gradient is computed using central differences.
	/// </remarks>
	// Token: 0x02000486 RID: 1158
	public class vtkImageGradient : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D507 RID: 54535 RVA: 0x001285B8 File Offset: 0x001267B8
		static vtkImageGradient()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageGradient.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageGradient"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D508 RID: 54536 RVA: 0x001285E0 File Offset: 0x001267E0
		public vtkImageGradient(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D509 RID: 54537
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGradient_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D50A RID: 54538 RVA: 0x001285F0 File Offset: 0x001267F0
		public new static vtkImageGradient New()
		{
			vtkImageGradient result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageGradient.vtkImageGradient_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGradient)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D50B RID: 54539 RVA: 0x00128644 File Offset: 0x00126844
		public vtkImageGradient() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageGradient.vtkImageGradient_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D50C RID: 54540 RVA: 0x00128688 File Offset: 0x00126888
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D50D RID: 54541
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGradient_GetDimensionality_01(HandleRef pThis);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...)
		/// </summary>
		// Token: 0x0600D50E RID: 54542 RVA: 0x00128694 File Offset: 0x00126894
		public virtual int GetDimensionality()
		{
			return vtkImageGradient.vtkImageGradient_GetDimensionality_01(base.GetCppThis());
		}

		// Token: 0x0600D50F RID: 54543
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGradient_GetDimensionalityMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...)
		/// </summary>
		// Token: 0x0600D510 RID: 54544 RVA: 0x001286B4 File Offset: 0x001268B4
		public virtual int GetDimensionalityMaxValue()
		{
			return vtkImageGradient.vtkImageGradient_GetDimensionalityMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600D511 RID: 54545
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGradient_GetDimensionalityMinValue_03(HandleRef pThis);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...)
		/// </summary>
		// Token: 0x0600D512 RID: 54546 RVA: 0x001286D4 File Offset: 0x001268D4
		public virtual int GetDimensionalityMinValue()
		{
			return vtkImageGradient.vtkImageGradient_GetDimensionalityMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600D513 RID: 54547
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGradient_GetHandleBoundaries_04(HandleRef pThis);

		/// <summary>
		/// Get/Set whether to handle boundaries.  If enabled, boundary
		/// pixels are treated as duplicated so that central differencing
		/// works for the boundary pixels.  If disabled, the output whole
		/// extent of the image is reduced by one pixel.
		/// </summary>
		// Token: 0x0600D514 RID: 54548 RVA: 0x001286F4 File Offset: 0x001268F4
		public virtual int GetHandleBoundaries()
		{
			return vtkImageGradient.vtkImageGradient_GetHandleBoundaries_04(base.GetCppThis());
		}

		// Token: 0x0600D515 RID: 54549
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageGradient_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D516 RID: 54550 RVA: 0x00128714 File Offset: 0x00126914
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageGradient.vtkImageGradient_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600D517 RID: 54551
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageGradient_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D518 RID: 54552 RVA: 0x00128734 File Offset: 0x00126934
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageGradient.vtkImageGradient_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600D519 RID: 54553
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGradient_HandleBoundariesOff_07(HandleRef pThis);

		/// <summary>
		/// Get/Set whether to handle boundaries.  If enabled, boundary
		/// pixels are treated as duplicated so that central differencing
		/// works for the boundary pixels.  If disabled, the output whole
		/// extent of the image is reduced by one pixel.
		/// </summary>
		// Token: 0x0600D51A RID: 54554 RVA: 0x0012874E File Offset: 0x0012694E
		public virtual void HandleBoundariesOff()
		{
			vtkImageGradient.vtkImageGradient_HandleBoundariesOff_07(base.GetCppThis());
		}

		// Token: 0x0600D51B RID: 54555
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGradient_HandleBoundariesOn_08(HandleRef pThis);

		/// <summary>
		/// Get/Set whether to handle boundaries.  If enabled, boundary
		/// pixels are treated as duplicated so that central differencing
		/// works for the boundary pixels.  If disabled, the output whole
		/// extent of the image is reduced by one pixel.
		/// </summary>
		// Token: 0x0600D51C RID: 54556 RVA: 0x0012875D File Offset: 0x0012695D
		public virtual void HandleBoundariesOn()
		{
			vtkImageGradient.vtkImageGradient_HandleBoundariesOn_08(base.GetCppThis());
		}

		// Token: 0x0600D51D RID: 54557
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGradient_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D51E RID: 54558 RVA: 0x0012876C File Offset: 0x0012696C
		public override int IsA(string type)
		{
			return vtkImageGradient.vtkImageGradient_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600D51F RID: 54559
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGradient_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D520 RID: 54560 RVA: 0x0012878C File Offset: 0x0012698C
		public new static int IsTypeOf(string type)
		{
			return vtkImageGradient.vtkImageGradient_IsTypeOf_10(type);
		}

		// Token: 0x0600D521 RID: 54561
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGradient_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D522 RID: 54562 RVA: 0x001287A8 File Offset: 0x001269A8
		public new vtkImageGradient NewInstance()
		{
			vtkImageGradient result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageGradient.vtkImageGradient_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGradient)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D523 RID: 54563
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGradient_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D524 RID: 54564 RVA: 0x00128804 File Offset: 0x00126A04
		public new static vtkImageGradient SafeDownCast(vtkObjectBase o)
		{
			vtkImageGradient vtkImageGradient = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageGradient.vtkImageGradient_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageGradient = (vtkImageGradient)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageGradient.Register(null);
				}
			}
			return vtkImageGradient;
		}

		// Token: 0x0600D525 RID: 54565
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGradient_SetDimensionality_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...)
		/// </summary>
		// Token: 0x0600D526 RID: 54566 RVA: 0x00128883 File Offset: 0x00126A83
		public virtual void SetDimensionality(int _arg)
		{
			vtkImageGradient.vtkImageGradient_SetDimensionality_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D527 RID: 54567
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGradient_SetHandleBoundaries_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set whether to handle boundaries.  If enabled, boundary
		/// pixels are treated as duplicated so that central differencing
		/// works for the boundary pixels.  If disabled, the output whole
		/// extent of the image is reduced by one pixel.
		/// </summary>
		// Token: 0x0600D528 RID: 54568 RVA: 0x00128893 File Offset: 0x00126A93
		public virtual void SetHandleBoundaries(int _arg)
		{
			vtkImageGradient.vtkImageGradient_SetHandleBoundaries_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FB4 RID: 4020
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageGradient";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FB5 RID: 4021
		public new static readonly string MRClassNameKey = "class vtkImageGradient";
	}
}
