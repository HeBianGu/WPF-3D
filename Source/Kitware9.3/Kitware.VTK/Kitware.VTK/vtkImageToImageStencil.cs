using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageToImageStencil
	/// </summary>
	/// <remarks>
	///    clip an image with a mask image
	///
	/// vtkImageToImageStencil will convert a vtkImageData into an stencil
	/// that can be used with vtkImageStecil or other vtk classes that apply
	/// a stencil to an image.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageStencil vtkImplicitFunctionToImageStencil vtkPolyDataToImageStencil
	/// </seealso>
	// Token: 0x02000237 RID: 567
	public class vtkImageToImageStencil : vtkImageStencilAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060069E9 RID: 27113 RVA: 0x000990AB File Offset: 0x000972AB
		static vtkImageToImageStencil()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageToImageStencil.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageToImageStencil"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060069EA RID: 27114 RVA: 0x000990D3 File Offset: 0x000972D3
		public vtkImageToImageStencil(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060069EB RID: 27115
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToImageStencil_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069EC RID: 27116 RVA: 0x000990E4 File Offset: 0x000972E4
		public new static vtkImageToImageStencil New()
		{
			vtkImageToImageStencil result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToImageStencil.vtkImageToImageStencil_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToImageStencil)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069ED RID: 27117 RVA: 0x00099138 File Offset: 0x00097338
		public vtkImageToImageStencil() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageToImageStencil.vtkImageToImageStencil_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060069EE RID: 27118 RVA: 0x0009917C File Offset: 0x0009737C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060069EF RID: 27119
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToImageStencil_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the image data to convert into a stencil.
		/// </summary>
		// Token: 0x060069F0 RID: 27120 RVA: 0x00099188 File Offset: 0x00097388
		public vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToImageStencil.vtkImageToImageStencil_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060069F1 RID: 27121
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageToImageStencil_GetLowerThreshold_02(HandleRef pThis);

		/// <summary>
		/// Get the Upper and Lower thresholds.
		/// </summary>
		// Token: 0x060069F2 RID: 27122 RVA: 0x000991F8 File Offset: 0x000973F8
		public virtual double GetLowerThreshold()
		{
			return vtkImageToImageStencil.vtkImageToImageStencil_GetLowerThreshold_02(base.GetCppThis());
		}

		// Token: 0x060069F3 RID: 27123
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageToImageStencil_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069F4 RID: 27124 RVA: 0x00099218 File Offset: 0x00097418
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageToImageStencil.vtkImageToImageStencil_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060069F5 RID: 27125
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageToImageStencil_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069F6 RID: 27126 RVA: 0x00099238 File Offset: 0x00097438
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageToImageStencil.vtkImageToImageStencil_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060069F7 RID: 27127
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageToImageStencil_GetUpperThreshold_05(HandleRef pThis);

		/// <summary>
		/// Get the Upper and Lower thresholds.
		/// </summary>
		// Token: 0x060069F8 RID: 27128 RVA: 0x00099254 File Offset: 0x00097454
		public virtual double GetUpperThreshold()
		{
			return vtkImageToImageStencil.vtkImageToImageStencil_GetUpperThreshold_05(base.GetCppThis());
		}

		// Token: 0x060069F9 RID: 27129
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToImageStencil_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069FA RID: 27130 RVA: 0x00099274 File Offset: 0x00097474
		public override int IsA(string type)
		{
			return vtkImageToImageStencil.vtkImageToImageStencil_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060069FB RID: 27131
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToImageStencil_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069FC RID: 27132 RVA: 0x00099294 File Offset: 0x00097494
		public new static int IsTypeOf(string type)
		{
			return vtkImageToImageStencil.vtkImageToImageStencil_IsTypeOf_07(type);
		}

		// Token: 0x060069FD RID: 27133
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToImageStencil_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069FE RID: 27134 RVA: 0x000992B0 File Offset: 0x000974B0
		public new vtkImageToImageStencil NewInstance()
		{
			vtkImageToImageStencil result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToImageStencil.vtkImageToImageStencil_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToImageStencil)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060069FF RID: 27135
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToImageStencil_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A00 RID: 27136 RVA: 0x0009930C File Offset: 0x0009750C
		public new static vtkImageToImageStencil SafeDownCast(vtkObjectBase o)
		{
			vtkImageToImageStencil vtkImageToImageStencil = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToImageStencil.vtkImageToImageStencil_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageToImageStencil = (vtkImageToImageStencil)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageToImageStencil.Register(null);
				}
			}
			return vtkImageToImageStencil;
		}

		// Token: 0x06006A01 RID: 27137
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToImageStencil_SetInputData_11(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Specify the image data to convert into a stencil.
		/// </summary>
		// Token: 0x06006A02 RID: 27138 RVA: 0x0009938C File Offset: 0x0009758C
		public void SetInputData(vtkImageData input)
		{
			vtkImageToImageStencil.vtkImageToImageStencil_SetInputData_11(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06006A03 RID: 27139
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToImageStencil_SetLowerThreshold_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Get the Upper and Lower thresholds.
		/// </summary>
		// Token: 0x06006A04 RID: 27140 RVA: 0x000993BB File Offset: 0x000975BB
		public virtual void SetLowerThreshold(double _arg)
		{
			vtkImageToImageStencil.vtkImageToImageStencil_SetLowerThreshold_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06006A05 RID: 27141
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToImageStencil_SetUpperThreshold_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Get the Upper and Lower thresholds.
		/// </summary>
		// Token: 0x06006A06 RID: 27142 RVA: 0x000993CB File Offset: 0x000975CB
		public virtual void SetUpperThreshold(double _arg)
		{
			vtkImageToImageStencil.vtkImageToImageStencil_SetUpperThreshold_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06006A07 RID: 27143
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToImageStencil_ThresholdBetween_14(HandleRef pThis, double lower, double upper);

		/// <summary>
		/// The values in a range (inclusive) match
		/// </summary>
		// Token: 0x06006A08 RID: 27144 RVA: 0x000993DB File Offset: 0x000975DB
		public void ThresholdBetween(double lower, double upper)
		{
			vtkImageToImageStencil.vtkImageToImageStencil_ThresholdBetween_14(base.GetCppThis(), lower, upper);
		}

		// Token: 0x06006A09 RID: 27145
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToImageStencil_ThresholdByLower_15(HandleRef pThis, double thresh);

		/// <summary>
		/// The values less than or equal to the value match.
		/// </summary>
		// Token: 0x06006A0A RID: 27146 RVA: 0x000993EC File Offset: 0x000975EC
		public void ThresholdByLower(double thresh)
		{
			vtkImageToImageStencil.vtkImageToImageStencil_ThresholdByLower_15(base.GetCppThis(), thresh);
		}

		// Token: 0x06006A0B RID: 27147
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToImageStencil_ThresholdByUpper_16(HandleRef pThis, double thresh);

		/// <summary>
		/// The values greater than or equal to the value match.
		/// </summary>
		// Token: 0x06006A0C RID: 27148 RVA: 0x000993FC File Offset: 0x000975FC
		public void ThresholdByUpper(double thresh)
		{
			vtkImageToImageStencil.vtkImageToImageStencil_ThresholdByUpper_16(base.GetCppThis(), thresh);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000958 RID: 2392
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageToImageStencil";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000959 RID: 2393
		public new static readonly string MRClassNameKey = "class vtkImageToImageStencil";
	}
}
