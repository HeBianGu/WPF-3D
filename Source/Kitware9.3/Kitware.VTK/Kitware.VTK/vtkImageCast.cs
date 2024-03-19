using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageCast
	/// </summary>
	/// <remarks>
	///     Image Data type Casting Filter
	///
	/// vtkImageCast filter casts the input type to match the output type in
	/// the image processing pipeline.  The filter does nothing if the input
	/// already has the correct type.  To specify the "CastTo" type,
	/// use "SetOutputScalarType" method.
	///
	/// @warning
	/// As vtkImageCast only casts values without rescaling them, its use is not
	/// recommended. vtkImageShiftScale is the recommended way to change the type
	/// of an image data.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageThreshold vtkImageShiftScale
	/// </seealso>
	// Token: 0x02000852 RID: 2130
	public class vtkImageCast : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601615C RID: 90460 RVA: 0x001F19F7 File Offset: 0x001EFBF7
		static vtkImageCast()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageCast.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCast"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601615D RID: 90461 RVA: 0x001F1A1F File Offset: 0x001EFC1F
		public vtkImageCast(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601615E RID: 90462
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCast_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601615F RID: 90463 RVA: 0x001F1A30 File Offset: 0x001EFC30
		public new static vtkImageCast New()
		{
			vtkImageCast result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCast.vtkImageCast_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCast)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016160 RID: 90464 RVA: 0x001F1A84 File Offset: 0x001EFC84
		public vtkImageCast() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageCast.vtkImageCast_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016161 RID: 90465 RVA: 0x001F1AC8 File Offset: 0x001EFCC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016162 RID: 90466
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCast_ClampOverflowOff_01(HandleRef pThis);

		/// <summary>
		/// When the ClampOverflow flag is on, the data is thresholded so that
		/// the output value does not exceed the max or min of the data type.
		/// Clamping is safer because otherwise you might invoke undefined
		/// behavior (and may crash) if the type conversion is out of range
		/// of the data type.  On the other hand, clamping is slower.
		/// By default ClampOverflow is off.
		/// </summary>
		// Token: 0x06016163 RID: 90467 RVA: 0x001F1AD3 File Offset: 0x001EFCD3
		public virtual void ClampOverflowOff()
		{
			vtkImageCast.vtkImageCast_ClampOverflowOff_01(base.GetCppThis());
		}

		// Token: 0x06016164 RID: 90468
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCast_ClampOverflowOn_02(HandleRef pThis);

		/// <summary>
		/// When the ClampOverflow flag is on, the data is thresholded so that
		/// the output value does not exceed the max or min of the data type.
		/// Clamping is safer because otherwise you might invoke undefined
		/// behavior (and may crash) if the type conversion is out of range
		/// of the data type.  On the other hand, clamping is slower.
		/// By default ClampOverflow is off.
		/// </summary>
		// Token: 0x06016165 RID: 90469 RVA: 0x001F1AE2 File Offset: 0x001EFCE2
		public virtual void ClampOverflowOn()
		{
			vtkImageCast.vtkImageCast_ClampOverflowOn_02(base.GetCppThis());
		}

		// Token: 0x06016166 RID: 90470
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCast_GetClampOverflow_03(HandleRef pThis);

		/// <summary>
		/// When the ClampOverflow flag is on, the data is thresholded so that
		/// the output value does not exceed the max or min of the data type.
		/// Clamping is safer because otherwise you might invoke undefined
		/// behavior (and may crash) if the type conversion is out of range
		/// of the data type.  On the other hand, clamping is slower.
		/// By default ClampOverflow is off.
		/// </summary>
		// Token: 0x06016167 RID: 90471 RVA: 0x001F1AF4 File Offset: 0x001EFCF4
		public virtual int GetClampOverflow()
		{
			return vtkImageCast.vtkImageCast_GetClampOverflow_03(base.GetCppThis());
		}

		// Token: 0x06016168 RID: 90472
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCast_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016169 RID: 90473 RVA: 0x001F1B14 File Offset: 0x001EFD14
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageCast.vtkImageCast_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601616A RID: 90474
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCast_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601616B RID: 90475 RVA: 0x001F1B34 File Offset: 0x001EFD34
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageCast.vtkImageCast_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601616C RID: 90476
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCast_GetOutputScalarType_06(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to.
		/// </summary>
		// Token: 0x0601616D RID: 90477 RVA: 0x001F1B50 File Offset: 0x001EFD50
		public virtual int GetOutputScalarType()
		{
			return vtkImageCast.vtkImageCast_GetOutputScalarType_06(base.GetCppThis());
		}

		// Token: 0x0601616E RID: 90478
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCast_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601616F RID: 90479 RVA: 0x001F1B70 File Offset: 0x001EFD70
		public override int IsA(string type)
		{
			return vtkImageCast.vtkImageCast_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06016170 RID: 90480
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCast_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016171 RID: 90481 RVA: 0x001F1B90 File Offset: 0x001EFD90
		public new static int IsTypeOf(string type)
		{
			return vtkImageCast.vtkImageCast_IsTypeOf_08(type);
		}

		// Token: 0x06016172 RID: 90482
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCast_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016173 RID: 90483 RVA: 0x001F1BAC File Offset: 0x001EFDAC
		public new vtkImageCast NewInstance()
		{
			vtkImageCast result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCast.vtkImageCast_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCast)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016174 RID: 90484
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCast_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016175 RID: 90485 RVA: 0x001F1C08 File Offset: 0x001EFE08
		public new static vtkImageCast SafeDownCast(vtkObjectBase o)
		{
			vtkImageCast vtkImageCast = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCast.vtkImageCast_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCast = (vtkImageCast)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCast.Register(null);
				}
			}
			return vtkImageCast;
		}

		// Token: 0x06016176 RID: 90486
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCast_SetClampOverflow_12(HandleRef pThis, int _arg);

		/// <summary>
		/// When the ClampOverflow flag is on, the data is thresholded so that
		/// the output value does not exceed the max or min of the data type.
		/// Clamping is safer because otherwise you might invoke undefined
		/// behavior (and may crash) if the type conversion is out of range
		/// of the data type.  On the other hand, clamping is slower.
		/// By default ClampOverflow is off.
		/// </summary>
		// Token: 0x06016177 RID: 90487 RVA: 0x001F1C87 File Offset: 0x001EFE87
		public virtual void SetClampOverflow(int _arg)
		{
			vtkImageCast.vtkImageCast_SetClampOverflow_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06016178 RID: 90488
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCast_SetOutputScalarType_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the desired output scalar type to cast to.
		/// </summary>
		// Token: 0x06016179 RID: 90489 RVA: 0x001F1C97 File Offset: 0x001EFE97
		public virtual void SetOutputScalarType(int _arg)
		{
			vtkImageCast.vtkImageCast_SetOutputScalarType_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0601617A RID: 90490
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCast_SetOutputScalarTypeToChar_14(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to.
		/// </summary>
		// Token: 0x0601617B RID: 90491 RVA: 0x001F1CA7 File Offset: 0x001EFEA7
		public void SetOutputScalarTypeToChar()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToChar_14(base.GetCppThis());
		}

		// Token: 0x0601617C RID: 90492
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCast_SetOutputScalarTypeToDouble_15(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to.
		/// </summary>
		// Token: 0x0601617D RID: 90493 RVA: 0x001F1CB6 File Offset: 0x001EFEB6
		public void SetOutputScalarTypeToDouble()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToDouble_15(base.GetCppThis());
		}

		// Token: 0x0601617E RID: 90494
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCast_SetOutputScalarTypeToFloat_16(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to.
		/// </summary>
		// Token: 0x0601617F RID: 90495 RVA: 0x001F1CC5 File Offset: 0x001EFEC5
		public void SetOutputScalarTypeToFloat()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToFloat_16(base.GetCppThis());
		}

		// Token: 0x06016180 RID: 90496
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCast_SetOutputScalarTypeToInt_17(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to.
		/// </summary>
		// Token: 0x06016181 RID: 90497 RVA: 0x001F1CD4 File Offset: 0x001EFED4
		public void SetOutputScalarTypeToInt()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToInt_17(base.GetCppThis());
		}

		// Token: 0x06016182 RID: 90498
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCast_SetOutputScalarTypeToLong_18(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to.
		/// </summary>
		// Token: 0x06016183 RID: 90499 RVA: 0x001F1CE3 File Offset: 0x001EFEE3
		public void SetOutputScalarTypeToLong()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToLong_18(base.GetCppThis());
		}

		// Token: 0x06016184 RID: 90500
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCast_SetOutputScalarTypeToShort_19(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to.
		/// </summary>
		// Token: 0x06016185 RID: 90501 RVA: 0x001F1CF2 File Offset: 0x001EFEF2
		public void SetOutputScalarTypeToShort()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToShort_19(base.GetCppThis());
		}

		// Token: 0x06016186 RID: 90502
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCast_SetOutputScalarTypeToUnsignedChar_20(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to.
		/// </summary>
		// Token: 0x06016187 RID: 90503 RVA: 0x001F1D01 File Offset: 0x001EFF01
		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToUnsignedChar_20(base.GetCppThis());
		}

		// Token: 0x06016188 RID: 90504
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCast_SetOutputScalarTypeToUnsignedInt_21(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to.
		/// </summary>
		// Token: 0x06016189 RID: 90505 RVA: 0x001F1D10 File Offset: 0x001EFF10
		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToUnsignedInt_21(base.GetCppThis());
		}

		// Token: 0x0601618A RID: 90506
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCast_SetOutputScalarTypeToUnsignedLong_22(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to.
		/// </summary>
		// Token: 0x0601618B RID: 90507 RVA: 0x001F1D1F File Offset: 0x001EFF1F
		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToUnsignedLong_22(base.GetCppThis());
		}

		// Token: 0x0601618C RID: 90508
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCast_SetOutputScalarTypeToUnsignedShort_23(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type to cast to.
		/// </summary>
		// Token: 0x0601618D RID: 90509 RVA: 0x001F1D2E File Offset: 0x001EFF2E
		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToUnsignedShort_23(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018F8 RID: 6392
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageCast";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018F9 RID: 6393
		public new static readonly string MRClassNameKey = "class vtkImageCast";
	}
}
