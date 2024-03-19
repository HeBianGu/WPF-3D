using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageGradientMagnitude
	/// </summary>
	/// <remarks>
	///    Computes magnitude of the gradient.
	///
	///
	/// vtkImageGradientMagnitude computes the gradient magnitude of an image.
	/// Setting the dimensionality determines whether the gradient is computed on
	/// 2D images, or 3D volumes.  The default is two dimensional XY images.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageGradient vtkImageMagnitude
	/// </seealso>
	// Token: 0x02000487 RID: 1159
	public class vtkImageGradientMagnitude : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D529 RID: 54569 RVA: 0x001288A3 File Offset: 0x00126AA3
		static vtkImageGradientMagnitude()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageGradientMagnitude.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageGradientMagnitude"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D52A RID: 54570 RVA: 0x001288CB File Offset: 0x00126ACB
		public vtkImageGradientMagnitude(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D52B RID: 54571
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGradientMagnitude_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D52C RID: 54572 RVA: 0x001288DC File Offset: 0x00126ADC
		public new static vtkImageGradientMagnitude New()
		{
			vtkImageGradientMagnitude result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageGradientMagnitude.vtkImageGradientMagnitude_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGradientMagnitude)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D52D RID: 54573 RVA: 0x00128930 File Offset: 0x00126B30
		public vtkImageGradientMagnitude() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageGradientMagnitude.vtkImageGradientMagnitude_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D52E RID: 54574 RVA: 0x00128974 File Offset: 0x00126B74
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D52F RID: 54575
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGradientMagnitude_GetDimensionality_01(HandleRef pThis);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...)
		/// </summary>
		// Token: 0x0600D530 RID: 54576 RVA: 0x00128980 File Offset: 0x00126B80
		public virtual int GetDimensionality()
		{
			return vtkImageGradientMagnitude.vtkImageGradientMagnitude_GetDimensionality_01(base.GetCppThis());
		}

		// Token: 0x0600D531 RID: 54577
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGradientMagnitude_GetDimensionalityMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...)
		/// </summary>
		// Token: 0x0600D532 RID: 54578 RVA: 0x001289A0 File Offset: 0x00126BA0
		public virtual int GetDimensionalityMaxValue()
		{
			return vtkImageGradientMagnitude.vtkImageGradientMagnitude_GetDimensionalityMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600D533 RID: 54579
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGradientMagnitude_GetDimensionalityMinValue_03(HandleRef pThis);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...)
		/// </summary>
		// Token: 0x0600D534 RID: 54580 RVA: 0x001289C0 File Offset: 0x00126BC0
		public virtual int GetDimensionalityMinValue()
		{
			return vtkImageGradientMagnitude.vtkImageGradientMagnitude_GetDimensionalityMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600D535 RID: 54581
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGradientMagnitude_GetHandleBoundaries_04(HandleRef pThis);

		/// <summary>
		/// If "HandleBoundariesOn" then boundary pixels are duplicated
		/// So central differences can get values.
		/// </summary>
		// Token: 0x0600D536 RID: 54582 RVA: 0x001289E0 File Offset: 0x00126BE0
		public virtual int GetHandleBoundaries()
		{
			return vtkImageGradientMagnitude.vtkImageGradientMagnitude_GetHandleBoundaries_04(base.GetCppThis());
		}

		// Token: 0x0600D537 RID: 54583
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageGradientMagnitude_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D538 RID: 54584 RVA: 0x00128A00 File Offset: 0x00126C00
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageGradientMagnitude.vtkImageGradientMagnitude_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600D539 RID: 54585
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageGradientMagnitude_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D53A RID: 54586 RVA: 0x00128A20 File Offset: 0x00126C20
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageGradientMagnitude.vtkImageGradientMagnitude_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600D53B RID: 54587
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGradientMagnitude_HandleBoundariesOff_07(HandleRef pThis);

		/// <summary>
		/// If "HandleBoundariesOn" then boundary pixels are duplicated
		/// So central differences can get values.
		/// </summary>
		// Token: 0x0600D53C RID: 54588 RVA: 0x00128A3A File Offset: 0x00126C3A
		public virtual void HandleBoundariesOff()
		{
			vtkImageGradientMagnitude.vtkImageGradientMagnitude_HandleBoundariesOff_07(base.GetCppThis());
		}

		// Token: 0x0600D53D RID: 54589
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGradientMagnitude_HandleBoundariesOn_08(HandleRef pThis);

		/// <summary>
		/// If "HandleBoundariesOn" then boundary pixels are duplicated
		/// So central differences can get values.
		/// </summary>
		// Token: 0x0600D53E RID: 54590 RVA: 0x00128A49 File Offset: 0x00126C49
		public virtual void HandleBoundariesOn()
		{
			vtkImageGradientMagnitude.vtkImageGradientMagnitude_HandleBoundariesOn_08(base.GetCppThis());
		}

		// Token: 0x0600D53F RID: 54591
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGradientMagnitude_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D540 RID: 54592 RVA: 0x00128A58 File Offset: 0x00126C58
		public override int IsA(string type)
		{
			return vtkImageGradientMagnitude.vtkImageGradientMagnitude_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600D541 RID: 54593
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageGradientMagnitude_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D542 RID: 54594 RVA: 0x00128A78 File Offset: 0x00126C78
		public new static int IsTypeOf(string type)
		{
			return vtkImageGradientMagnitude.vtkImageGradientMagnitude_IsTypeOf_10(type);
		}

		// Token: 0x0600D543 RID: 54595
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGradientMagnitude_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D544 RID: 54596 RVA: 0x00128A94 File Offset: 0x00126C94
		public new vtkImageGradientMagnitude NewInstance()
		{
			vtkImageGradientMagnitude result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageGradientMagnitude.vtkImageGradientMagnitude_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGradientMagnitude)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D545 RID: 54597
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageGradientMagnitude_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D546 RID: 54598 RVA: 0x00128AF0 File Offset: 0x00126CF0
		public new static vtkImageGradientMagnitude SafeDownCast(vtkObjectBase o)
		{
			vtkImageGradientMagnitude vtkImageGradientMagnitude = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageGradientMagnitude.vtkImageGradientMagnitude_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageGradientMagnitude = (vtkImageGradientMagnitude)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageGradientMagnitude.Register(null);
				}
			}
			return vtkImageGradientMagnitude;
		}

		// Token: 0x0600D547 RID: 54599
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGradientMagnitude_SetDimensionality_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...)
		/// </summary>
		// Token: 0x0600D548 RID: 54600 RVA: 0x00128B6F File Offset: 0x00126D6F
		public virtual void SetDimensionality(int _arg)
		{
			vtkImageGradientMagnitude.vtkImageGradientMagnitude_SetDimensionality_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D549 RID: 54601
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageGradientMagnitude_SetHandleBoundaries_15(HandleRef pThis, int _arg);

		/// <summary>
		/// If "HandleBoundariesOn" then boundary pixels are duplicated
		/// So central differences can get values.
		/// </summary>
		// Token: 0x0600D54A RID: 54602 RVA: 0x00128B7F File Offset: 0x00126D7F
		public virtual void SetHandleBoundaries(int _arg)
		{
			vtkImageGradientMagnitude.vtkImageGradientMagnitude_SetHandleBoundaries_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FB6 RID: 4022
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageGradientMagnitude";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FB7 RID: 4023
		public new static readonly string MRClassNameKey = "class vtkImageGradientMagnitude";
	}
}
