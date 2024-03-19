using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataToImageStencil
	/// </summary>
	/// <remarks>
	///    use polydata to mask an image
	///
	/// The vtkPolyDataToImageStencil class will convert polydata into
	/// an image stencil.  The polydata can either be a closed surface
	/// mesh or a series of polyline contours (one contour per slice).
	/// @warning
	/// If contours are provided, the contours must be aligned with the
	/// Z planes.  Other contour orientations are not supported.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageStencil vtkImageAccumulate vtkImageBlend vtkImageReslice
	/// </seealso>
	// Token: 0x0200023C RID: 572
	public class vtkPolyDataToImageStencil : vtkImageStencilSource
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006A93 RID: 27283 RVA: 0x0009A0BC File Offset: 0x000982BC
		static vtkPolyDataToImageStencil()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataToImageStencil.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataToImageStencil"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006A94 RID: 27284 RVA: 0x0009A0E4 File Offset: 0x000982E4
		public vtkPolyDataToImageStencil(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006A95 RID: 27285
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataToImageStencil_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A96 RID: 27286 RVA: 0x0009A0F4 File Offset: 0x000982F4
		public new static vtkPolyDataToImageStencil New()
		{
			vtkPolyDataToImageStencil result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataToImageStencil)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A97 RID: 27287 RVA: 0x0009A148 File Offset: 0x00098348
		public vtkPolyDataToImageStencil() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006A98 RID: 27288 RVA: 0x0009A18C File Offset: 0x0009838C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006A99 RID: 27289
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataToImageStencil_GetEnableSMP_01(HandleRef pThis);

		/// <summary>
		/// Enable/Disable SMP for multithreading. SMP is On by default.
		/// </summary>
		// Token: 0x06006A9A RID: 27290 RVA: 0x0009A198 File Offset: 0x00098398
		public virtual bool GetEnableSMP()
		{
			return vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_GetEnableSMP_01(base.GetCppThis()) != 0;
		}

		// Token: 0x06006A9B RID: 27291
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataToImageStencil_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function to convert into a stencil.
		/// </summary>
		// Token: 0x06006A9C RID: 27292 RVA: 0x0009A1C0 File Offset: 0x000983C0
		public vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06006A9D RID: 27293
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataToImageStencil_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A9E RID: 27294 RVA: 0x0009A230 File Offset: 0x00098430
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06006A9F RID: 27295
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataToImageStencil_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006AA0 RID: 27296 RVA: 0x0009A250 File Offset: 0x00098450
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06006AA1 RID: 27297
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyDataToImageStencil_GetTolerance_05(HandleRef pThis);

		/// <summary>
		/// The tolerance for including a voxel inside the stencil.
		/// This is in fractions of a voxel, and must be between 0 and 1.
		/// Tolerance is only applied in the x and y directions, not in z.
		/// Setting the tolerance to zero disables all tolerance checks and
		/// might result in faster performance.
		/// </summary>
		// Token: 0x06006AA2 RID: 27298 RVA: 0x0009A26C File Offset: 0x0009846C
		public virtual double GetTolerance()
		{
			return vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_GetTolerance_05(base.GetCppThis());
		}

		// Token: 0x06006AA3 RID: 27299
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyDataToImageStencil_GetToleranceMaxValue_06(HandleRef pThis);

		/// <summary>
		/// The tolerance for including a voxel inside the stencil.
		/// This is in fractions of a voxel, and must be between 0 and 1.
		/// Tolerance is only applied in the x and y directions, not in z.
		/// Setting the tolerance to zero disables all tolerance checks and
		/// might result in faster performance.
		/// </summary>
		// Token: 0x06006AA4 RID: 27300 RVA: 0x0009A28C File Offset: 0x0009848C
		public virtual double GetToleranceMaxValue()
		{
			return vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_GetToleranceMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06006AA5 RID: 27301
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyDataToImageStencil_GetToleranceMinValue_07(HandleRef pThis);

		/// <summary>
		/// The tolerance for including a voxel inside the stencil.
		/// This is in fractions of a voxel, and must be between 0 and 1.
		/// Tolerance is only applied in the x and y directions, not in z.
		/// Setting the tolerance to zero disables all tolerance checks and
		/// might result in faster performance.
		/// </summary>
		// Token: 0x06006AA6 RID: 27302 RVA: 0x0009A2AC File Offset: 0x000984AC
		public virtual double GetToleranceMinValue()
		{
			return vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_GetToleranceMinValue_07(base.GetCppThis());
		}

		// Token: 0x06006AA7 RID: 27303
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataToImageStencil_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006AA8 RID: 27304 RVA: 0x0009A2CC File Offset: 0x000984CC
		public override int IsA(string type)
		{
			return vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06006AA9 RID: 27305
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataToImageStencil_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006AAA RID: 27306 RVA: 0x0009A2EC File Offset: 0x000984EC
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_IsTypeOf_09(type);
		}

		// Token: 0x06006AAB RID: 27307
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataToImageStencil_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006AAC RID: 27308 RVA: 0x0009A308 File Offset: 0x00098508
		public new vtkPolyDataToImageStencil NewInstance()
		{
			vtkPolyDataToImageStencil result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataToImageStencil)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006AAD RID: 27309
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataToImageStencil_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006AAE RID: 27310 RVA: 0x0009A364 File Offset: 0x00098564
		public new static vtkPolyDataToImageStencil SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataToImageStencil vtkPolyDataToImageStencil = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataToImageStencil = (vtkPolyDataToImageStencil)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataToImageStencil.Register(null);
				}
			}
			return vtkPolyDataToImageStencil;
		}

		// Token: 0x06006AAF RID: 27311
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataToImageStencil_SetEnableSMP_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/Disable SMP for multithreading. SMP is On by default.
		/// </summary>
		// Token: 0x06006AB0 RID: 27312 RVA: 0x0009A3E3 File Offset: 0x000985E3
		public virtual void SetEnableSMP(bool _arg)
		{
			vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_SetEnableSMP_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06006AB1 RID: 27313
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataToImageStencil_SetInputData_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function to convert into a stencil.
		/// </summary>
		// Token: 0x06006AB2 RID: 27314 RVA: 0x0009A3FC File Offset: 0x000985FC
		public virtual void SetInputData(vtkPolyData arg0)
		{
			vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_SetInputData_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06006AB3 RID: 27315
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataToImageStencil_SetTolerance_15(HandleRef pThis, double _arg);

		/// <summary>
		/// The tolerance for including a voxel inside the stencil.
		/// This is in fractions of a voxel, and must be between 0 and 1.
		/// Tolerance is only applied in the x and y directions, not in z.
		/// Setting the tolerance to zero disables all tolerance checks and
		/// might result in faster performance.
		/// </summary>
		// Token: 0x06006AB4 RID: 27316 RVA: 0x0009A42B File Offset: 0x0009862B
		public virtual void SetTolerance(double _arg)
		{
			vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_SetTolerance_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000963 RID: 2403
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataToImageStencil";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000964 RID: 2404
		public new static readonly string MRClassNameKey = "class vtkPolyDataToImageStencil";
	}
}
