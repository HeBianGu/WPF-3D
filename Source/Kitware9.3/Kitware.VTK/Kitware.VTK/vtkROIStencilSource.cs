using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkROIStencilSource
	/// </summary>
	/// <remarks>
	///    create simple mask shapes
	///
	/// vtkROIStencilSource will create an image stencil with a
	/// simple shape like a box, a sphere, or a cylinder.  Its output can
	/// be used with vtkImageStecil or other vtk classes that apply
	/// a stencil to an image.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitFunctionToImageStencil vtkLassoStencilSource
	/// @par Thanks:
	/// Thanks to David Gobbi for contributing this class to VTK.
	/// </seealso>
	// Token: 0x0200023D RID: 573
	public class vtkROIStencilSource : vtkImageStencilSource
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006AB5 RID: 27317 RVA: 0x0009A43B File Offset: 0x0009863B
		static vtkROIStencilSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkROIStencilSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkROIStencilSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006AB6 RID: 27318 RVA: 0x0009A463 File Offset: 0x00098663
		public vtkROIStencilSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006AB7 RID: 27319
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkROIStencilSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006AB8 RID: 27320 RVA: 0x0009A474 File Offset: 0x00098674
		public new static vtkROIStencilSource New()
		{
			vtkROIStencilSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkROIStencilSource.vtkROIStencilSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkROIStencilSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006AB9 RID: 27321 RVA: 0x0009A4C8 File Offset: 0x000986C8
		public vtkROIStencilSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkROIStencilSource.vtkROIStencilSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006ABA RID: 27322 RVA: 0x0009A50C File Offset: 0x0009870C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006ABB RID: 27323
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkROIStencilSource_GetBounds_01(HandleRef pThis);

		/// <summary>
		/// Set the bounds of the region of interest.  The bounds take
		/// the spacing and origin into account.
		/// </summary>
		// Token: 0x06006ABC RID: 27324 RVA: 0x0009A518 File Offset: 0x00098718
		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkROIStencilSource.vtkROIStencilSource_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006ABD RID: 27325
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkROIStencilSource_GetBounds_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// Set the bounds of the region of interest.  The bounds take
		/// the spacing and origin into account.
		/// </summary>
		// Token: 0x06006ABE RID: 27326 RVA: 0x0009A560 File Offset: 0x00098760
		public virtual void GetBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkROIStencilSource.vtkROIStencilSource_GetBounds_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06006ABF RID: 27327
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkROIStencilSource_GetBounds_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the bounds of the region of interest.  The bounds take
		/// the spacing and origin into account.
		/// </summary>
		// Token: 0x06006AC0 RID: 27328 RVA: 0x0009A578 File Offset: 0x00098778
		public virtual void GetBounds(IntPtr _arg)
		{
			vtkROIStencilSource.vtkROIStencilSource_GetBounds_03(base.GetCppThis(), _arg);
		}

		// Token: 0x06006AC1 RID: 27329
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkROIStencilSource_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006AC2 RID: 27330 RVA: 0x0009A588 File Offset: 0x00098788
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkROIStencilSource.vtkROIStencilSource_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06006AC3 RID: 27331
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkROIStencilSource_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006AC4 RID: 27332 RVA: 0x0009A5A8 File Offset: 0x000987A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkROIStencilSource.vtkROIStencilSource_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06006AC5 RID: 27333
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkROIStencilSource_GetShape_06(HandleRef pThis);

		/// <summary>
		/// The shape of the region of interest.  Cylinders can be oriented
		/// along the X, Y, or Z axes.  The default shape is "Box".
		/// </summary>
		// Token: 0x06006AC6 RID: 27334 RVA: 0x0009A5C4 File Offset: 0x000987C4
		public virtual int GetShape()
		{
			return vtkROIStencilSource.vtkROIStencilSource_GetShape_06(base.GetCppThis());
		}

		// Token: 0x06006AC7 RID: 27335
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkROIStencilSource_GetShapeAsString_07(HandleRef pThis);

		/// <summary>
		/// The shape of the region of interest.  Cylinders can be oriented
		/// along the X, Y, or Z axes.  The default shape is "Box".
		/// </summary>
		// Token: 0x06006AC8 RID: 27336 RVA: 0x0009A5E4 File Offset: 0x000987E4
		public virtual string GetShapeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkROIStencilSource.vtkROIStencilSource_GetShapeAsString_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006AC9 RID: 27337
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkROIStencilSource_GetShapeMaxValue_08(HandleRef pThis);

		/// <summary>
		/// The shape of the region of interest.  Cylinders can be oriented
		/// along the X, Y, or Z axes.  The default shape is "Box".
		/// </summary>
		// Token: 0x06006ACA RID: 27338 RVA: 0x0009A620 File Offset: 0x00098820
		public virtual int GetShapeMaxValue()
		{
			return vtkROIStencilSource.vtkROIStencilSource_GetShapeMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06006ACB RID: 27339
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkROIStencilSource_GetShapeMinValue_09(HandleRef pThis);

		/// <summary>
		/// The shape of the region of interest.  Cylinders can be oriented
		/// along the X, Y, or Z axes.  The default shape is "Box".
		/// </summary>
		// Token: 0x06006ACC RID: 27340 RVA: 0x0009A640 File Offset: 0x00098840
		public virtual int GetShapeMinValue()
		{
			return vtkROIStencilSource.vtkROIStencilSource_GetShapeMinValue_09(base.GetCppThis());
		}

		// Token: 0x06006ACD RID: 27341
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkROIStencilSource_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006ACE RID: 27342 RVA: 0x0009A660 File Offset: 0x00098860
		public override int IsA(string type)
		{
			return vtkROIStencilSource.vtkROIStencilSource_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06006ACF RID: 27343
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkROIStencilSource_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006AD0 RID: 27344 RVA: 0x0009A680 File Offset: 0x00098880
		public new static int IsTypeOf(string type)
		{
			return vtkROIStencilSource.vtkROIStencilSource_IsTypeOf_11(type);
		}

		// Token: 0x06006AD1 RID: 27345
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkROIStencilSource_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006AD2 RID: 27346 RVA: 0x0009A69C File Offset: 0x0009889C
		public new vtkROIStencilSource NewInstance()
		{
			vtkROIStencilSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkROIStencilSource.vtkROIStencilSource_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkROIStencilSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006AD3 RID: 27347
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkROIStencilSource_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006AD4 RID: 27348 RVA: 0x0009A6F8 File Offset: 0x000988F8
		public new static vtkROIStencilSource SafeDownCast(vtkObjectBase o)
		{
			vtkROIStencilSource vtkROIStencilSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkROIStencilSource.vtkROIStencilSource_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkROIStencilSource = (vtkROIStencilSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkROIStencilSource.Register(null);
				}
			}
			return vtkROIStencilSource;
		}

		// Token: 0x06006AD5 RID: 27349
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkROIStencilSource_SetBounds_15(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set the bounds of the region of interest.  The bounds take
		/// the spacing and origin into account.
		/// </summary>
		// Token: 0x06006AD6 RID: 27350 RVA: 0x0009A777 File Offset: 0x00098977
		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkROIStencilSource.vtkROIStencilSource_SetBounds_15(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06006AD7 RID: 27351
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkROIStencilSource_SetBounds_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the bounds of the region of interest.  The bounds take
		/// the spacing and origin into account.
		/// </summary>
		// Token: 0x06006AD8 RID: 27352 RVA: 0x0009A78F File Offset: 0x0009898F
		public virtual void SetBounds(IntPtr _arg)
		{
			vtkROIStencilSource.vtkROIStencilSource_SetBounds_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06006AD9 RID: 27353
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkROIStencilSource_SetShape_17(HandleRef pThis, int _arg);

		/// <summary>
		/// The shape of the region of interest.  Cylinders can be oriented
		/// along the X, Y, or Z axes.  The default shape is "Box".
		/// </summary>
		// Token: 0x06006ADA RID: 27354 RVA: 0x0009A79F File Offset: 0x0009899F
		public virtual void SetShape(int _arg)
		{
			vtkROIStencilSource.vtkROIStencilSource_SetShape_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06006ADB RID: 27355
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkROIStencilSource_SetShapeToBox_18(HandleRef pThis);

		/// <summary>
		/// The shape of the region of interest.  Cylinders can be oriented
		/// along the X, Y, or Z axes.  The default shape is "Box".
		/// </summary>
		// Token: 0x06006ADC RID: 27356 RVA: 0x0009A7AF File Offset: 0x000989AF
		public void SetShapeToBox()
		{
			vtkROIStencilSource.vtkROIStencilSource_SetShapeToBox_18(base.GetCppThis());
		}

		// Token: 0x06006ADD RID: 27357
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkROIStencilSource_SetShapeToCylinderX_19(HandleRef pThis);

		/// <summary>
		/// The shape of the region of interest.  Cylinders can be oriented
		/// along the X, Y, or Z axes.  The default shape is "Box".
		/// </summary>
		// Token: 0x06006ADE RID: 27358 RVA: 0x0009A7BE File Offset: 0x000989BE
		public void SetShapeToCylinderX()
		{
			vtkROIStencilSource.vtkROIStencilSource_SetShapeToCylinderX_19(base.GetCppThis());
		}

		// Token: 0x06006ADF RID: 27359
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkROIStencilSource_SetShapeToCylinderY_20(HandleRef pThis);

		/// <summary>
		/// The shape of the region of interest.  Cylinders can be oriented
		/// along the X, Y, or Z axes.  The default shape is "Box".
		/// </summary>
		// Token: 0x06006AE0 RID: 27360 RVA: 0x0009A7CD File Offset: 0x000989CD
		public void SetShapeToCylinderY()
		{
			vtkROIStencilSource.vtkROIStencilSource_SetShapeToCylinderY_20(base.GetCppThis());
		}

		// Token: 0x06006AE1 RID: 27361
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkROIStencilSource_SetShapeToCylinderZ_21(HandleRef pThis);

		/// <summary>
		/// The shape of the region of interest.  Cylinders can be oriented
		/// along the X, Y, or Z axes.  The default shape is "Box".
		/// </summary>
		// Token: 0x06006AE2 RID: 27362 RVA: 0x0009A7DC File Offset: 0x000989DC
		public void SetShapeToCylinderZ()
		{
			vtkROIStencilSource.vtkROIStencilSource_SetShapeToCylinderZ_21(base.GetCppThis());
		}

		// Token: 0x06006AE3 RID: 27363
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkROIStencilSource_SetShapeToEllipsoid_22(HandleRef pThis);

		/// <summary>
		/// The shape of the region of interest.  Cylinders can be oriented
		/// along the X, Y, or Z axes.  The default shape is "Box".
		/// </summary>
		// Token: 0x06006AE4 RID: 27364 RVA: 0x0009A7EB File Offset: 0x000989EB
		public void SetShapeToEllipsoid()
		{
			vtkROIStencilSource.vtkROIStencilSource_SetShapeToEllipsoid_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000965 RID: 2405
		public new const string MRFullTypeName = "Kitware.VTK.vtkROIStencilSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000966 RID: 2406
		public new static readonly string MRClassNameKey = "class vtkROIStencilSource";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200023E RID: 574
		public enum BOX_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000968 RID: 2408
			BOX,
			/// <summary>enum member</summary>
			// Token: 0x04000969 RID: 2409
			CYLINDERX = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400096A RID: 2410
			CYLINDERY,
			/// <summary>enum member</summary>
			// Token: 0x0400096B RID: 2411
			CYLINDERZ,
			/// <summary>enum member</summary>
			// Token: 0x0400096C RID: 2412
			ELLIPSOID = 1
		}
	}
}
