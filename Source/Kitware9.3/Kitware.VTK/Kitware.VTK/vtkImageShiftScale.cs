using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageShiftScale
	/// </summary>
	/// <remarks>
	///    shift and scale an input image
	///
	/// With vtkImageShiftScale Pixels are shifted (a constant value added)
	/// and then scaled (multiplied by a scalar. As a convenience, this class
	/// allows you to set the output scalar type similar to vtkImageCast.
	/// This is because shift scale operations frequently convert data types.
	/// </remarks>
	// Token: 0x02000865 RID: 2149
	public class vtkImageShiftScale : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601645E RID: 91230 RVA: 0x001F58F3 File Offset: 0x001F3AF3
		static vtkImageShiftScale()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageShiftScale.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageShiftScale"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601645F RID: 91231 RVA: 0x001F591B File Offset: 0x001F3B1B
		public vtkImageShiftScale(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016460 RID: 91232
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageShiftScale_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016461 RID: 91233 RVA: 0x001F592C File Offset: 0x001F3B2C
		public new static vtkImageShiftScale New()
		{
			vtkImageShiftScale result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageShiftScale.vtkImageShiftScale_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageShiftScale)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016462 RID: 91234 RVA: 0x001F5980 File Offset: 0x001F3B80
		public vtkImageShiftScale() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageShiftScale.vtkImageShiftScale_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016463 RID: 91235 RVA: 0x001F59C4 File Offset: 0x001F3BC4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016464 RID: 91236
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_ClampOverflowOff_01(HandleRef pThis);

		/// <summary>
		/// When the ClampOverflow flag is on, the data is thresholded so that
		/// the output value does not exceed the max or min of the data type.
		/// Clamping is safer because otherwise you might invoke undefined
		/// behavior (and may crash) if the type conversion is out of range
		/// of the data type.  On the other hand, clamping is slower.
		/// By default, ClampOverflow is off.
		/// </summary>
		// Token: 0x06016465 RID: 91237 RVA: 0x001F59CF File Offset: 0x001F3BCF
		public virtual void ClampOverflowOff()
		{
			vtkImageShiftScale.vtkImageShiftScale_ClampOverflowOff_01(base.GetCppThis());
		}

		// Token: 0x06016466 RID: 91238
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_ClampOverflowOn_02(HandleRef pThis);

		/// <summary>
		/// When the ClampOverflow flag is on, the data is thresholded so that
		/// the output value does not exceed the max or min of the data type.
		/// Clamping is safer because otherwise you might invoke undefined
		/// behavior (and may crash) if the type conversion is out of range
		/// of the data type.  On the other hand, clamping is slower.
		/// By default, ClampOverflow is off.
		/// </summary>
		// Token: 0x06016467 RID: 91239 RVA: 0x001F59DE File Offset: 0x001F3BDE
		public virtual void ClampOverflowOn()
		{
			vtkImageShiftScale.vtkImageShiftScale_ClampOverflowOn_02(base.GetCppThis());
		}

		// Token: 0x06016468 RID: 91240
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageShiftScale_GetClampOverflow_03(HandleRef pThis);

		/// <summary>
		/// When the ClampOverflow flag is on, the data is thresholded so that
		/// the output value does not exceed the max or min of the data type.
		/// Clamping is safer because otherwise you might invoke undefined
		/// behavior (and may crash) if the type conversion is out of range
		/// of the data type.  On the other hand, clamping is slower.
		/// By default, ClampOverflow is off.
		/// </summary>
		// Token: 0x06016469 RID: 91241 RVA: 0x001F59F0 File Offset: 0x001F3BF0
		public virtual int GetClampOverflow()
		{
			return vtkImageShiftScale.vtkImageShiftScale_GetClampOverflow_03(base.GetCppThis());
		}

		// Token: 0x0601646A RID: 91242
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageShiftScale_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601646B RID: 91243 RVA: 0x001F5A10 File Offset: 0x001F3C10
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageShiftScale.vtkImageShiftScale_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601646C RID: 91244
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageShiftScale_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601646D RID: 91245 RVA: 0x001F5A30 File Offset: 0x001F3C30
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageShiftScale.vtkImageShiftScale_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601646E RID: 91246
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageShiftScale_GetOutputScalarType_06(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type. The result of the shift
		/// and scale operations is cast to the type specified.
		/// </summary>
		// Token: 0x0601646F RID: 91247 RVA: 0x001F5A4C File Offset: 0x001F3C4C
		public virtual int GetOutputScalarType()
		{
			return vtkImageShiftScale.vtkImageShiftScale_GetOutputScalarType_06(base.GetCppThis());
		}

		// Token: 0x06016470 RID: 91248
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageShiftScale_GetScale_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the scale value. Each pixel is multiplied by this value.
		/// </summary>
		// Token: 0x06016471 RID: 91249 RVA: 0x001F5A6C File Offset: 0x001F3C6C
		public virtual double GetScale()
		{
			return vtkImageShiftScale.vtkImageShiftScale_GetScale_07(base.GetCppThis());
		}

		// Token: 0x06016472 RID: 91250
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageShiftScale_GetShift_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the shift value. This value is added to each pixel
		/// </summary>
		// Token: 0x06016473 RID: 91251 RVA: 0x001F5A8C File Offset: 0x001F3C8C
		public virtual double GetShift()
		{
			return vtkImageShiftScale.vtkImageShiftScale_GetShift_08(base.GetCppThis());
		}

		// Token: 0x06016474 RID: 91252
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageShiftScale_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016475 RID: 91253 RVA: 0x001F5AAC File Offset: 0x001F3CAC
		public override int IsA(string type)
		{
			return vtkImageShiftScale.vtkImageShiftScale_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06016476 RID: 91254
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageShiftScale_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016477 RID: 91255 RVA: 0x001F5ACC File Offset: 0x001F3CCC
		public new static int IsTypeOf(string type)
		{
			return vtkImageShiftScale.vtkImageShiftScale_IsTypeOf_10(type);
		}

		// Token: 0x06016478 RID: 91256
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageShiftScale_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016479 RID: 91257 RVA: 0x001F5AE8 File Offset: 0x001F3CE8
		public new vtkImageShiftScale NewInstance()
		{
			vtkImageShiftScale result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageShiftScale.vtkImageShiftScale_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageShiftScale)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601647A RID: 91258
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageShiftScale_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601647B RID: 91259 RVA: 0x001F5B44 File Offset: 0x001F3D44
		public new static vtkImageShiftScale SafeDownCast(vtkObjectBase o)
		{
			vtkImageShiftScale vtkImageShiftScale = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageShiftScale.vtkImageShiftScale_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageShiftScale = (vtkImageShiftScale)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageShiftScale.Register(null);
				}
			}
			return vtkImageShiftScale;
		}

		// Token: 0x0601647C RID: 91260
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_SetClampOverflow_14(HandleRef pThis, int _arg);

		/// <summary>
		/// When the ClampOverflow flag is on, the data is thresholded so that
		/// the output value does not exceed the max or min of the data type.
		/// Clamping is safer because otherwise you might invoke undefined
		/// behavior (and may crash) if the type conversion is out of range
		/// of the data type.  On the other hand, clamping is slower.
		/// By default, ClampOverflow is off.
		/// </summary>
		// Token: 0x0601647D RID: 91261 RVA: 0x001F5BC3 File Offset: 0x001F3DC3
		public virtual void SetClampOverflow(int _arg)
		{
			vtkImageShiftScale.vtkImageShiftScale_SetClampOverflow_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0601647E RID: 91262
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_SetOutputScalarType_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the desired output scalar type. The result of the shift
		/// and scale operations is cast to the type specified.
		/// </summary>
		// Token: 0x0601647F RID: 91263 RVA: 0x001F5BD3 File Offset: 0x001F3DD3
		public virtual void SetOutputScalarType(int _arg)
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarType_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06016480 RID: 91264
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToChar_16(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type. The result of the shift
		/// and scale operations is cast to the type specified.
		/// </summary>
		// Token: 0x06016481 RID: 91265 RVA: 0x001F5BE3 File Offset: 0x001F3DE3
		public void SetOutputScalarTypeToChar()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToChar_16(base.GetCppThis());
		}

		// Token: 0x06016482 RID: 91266
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToDouble_17(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type. The result of the shift
		/// and scale operations is cast to the type specified.
		/// </summary>
		// Token: 0x06016483 RID: 91267 RVA: 0x001F5BF2 File Offset: 0x001F3DF2
		public void SetOutputScalarTypeToDouble()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToDouble_17(base.GetCppThis());
		}

		// Token: 0x06016484 RID: 91268
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToFloat_18(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type. The result of the shift
		/// and scale operations is cast to the type specified.
		/// </summary>
		// Token: 0x06016485 RID: 91269 RVA: 0x001F5C01 File Offset: 0x001F3E01
		public void SetOutputScalarTypeToFloat()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToFloat_18(base.GetCppThis());
		}

		// Token: 0x06016486 RID: 91270
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToInt_19(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type. The result of the shift
		/// and scale operations is cast to the type specified.
		/// </summary>
		// Token: 0x06016487 RID: 91271 RVA: 0x001F5C10 File Offset: 0x001F3E10
		public void SetOutputScalarTypeToInt()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToInt_19(base.GetCppThis());
		}

		// Token: 0x06016488 RID: 91272
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToLong_20(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type. The result of the shift
		/// and scale operations is cast to the type specified.
		/// </summary>
		// Token: 0x06016489 RID: 91273 RVA: 0x001F5C1F File Offset: 0x001F3E1F
		public void SetOutputScalarTypeToLong()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToLong_20(base.GetCppThis());
		}

		// Token: 0x0601648A RID: 91274
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToShort_21(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type. The result of the shift
		/// and scale operations is cast to the type specified.
		/// </summary>
		// Token: 0x0601648B RID: 91275 RVA: 0x001F5C2E File Offset: 0x001F3E2E
		public void SetOutputScalarTypeToShort()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToShort_21(base.GetCppThis());
		}

		// Token: 0x0601648C RID: 91276
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToUnsignedChar_22(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type. The result of the shift
		/// and scale operations is cast to the type specified.
		/// </summary>
		// Token: 0x0601648D RID: 91277 RVA: 0x001F5C3D File Offset: 0x001F3E3D
		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToUnsignedChar_22(base.GetCppThis());
		}

		// Token: 0x0601648E RID: 91278
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToUnsignedInt_23(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type. The result of the shift
		/// and scale operations is cast to the type specified.
		/// </summary>
		// Token: 0x0601648F RID: 91279 RVA: 0x001F5C4C File Offset: 0x001F3E4C
		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToUnsignedInt_23(base.GetCppThis());
		}

		// Token: 0x06016490 RID: 91280
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToUnsignedLong_24(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type. The result of the shift
		/// and scale operations is cast to the type specified.
		/// </summary>
		// Token: 0x06016491 RID: 91281 RVA: 0x001F5C5B File Offset: 0x001F3E5B
		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToUnsignedLong_24(base.GetCppThis());
		}

		// Token: 0x06016492 RID: 91282
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToUnsignedShort_25(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type. The result of the shift
		/// and scale operations is cast to the type specified.
		/// </summary>
		// Token: 0x06016493 RID: 91283 RVA: 0x001F5C6A File Offset: 0x001F3E6A
		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToUnsignedShort_25(base.GetCppThis());
		}

		// Token: 0x06016494 RID: 91284
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_SetScale_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scale value. Each pixel is multiplied by this value.
		/// </summary>
		// Token: 0x06016495 RID: 91285 RVA: 0x001F5C79 File Offset: 0x001F3E79
		public virtual void SetScale(double _arg)
		{
			vtkImageShiftScale.vtkImageShiftScale_SetScale_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06016496 RID: 91286
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageShiftScale_SetShift_27(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the shift value. This value is added to each pixel
		/// </summary>
		// Token: 0x06016497 RID: 91287 RVA: 0x001F5C89 File Offset: 0x001F3E89
		public virtual void SetShift(double _arg)
		{
			vtkImageShiftScale.vtkImageShiftScale_SetShift_27(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001920 RID: 6432
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageShiftScale";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001921 RID: 6433
		public new static readonly string MRClassNameKey = "class vtkImageShiftScale";
	}
}
