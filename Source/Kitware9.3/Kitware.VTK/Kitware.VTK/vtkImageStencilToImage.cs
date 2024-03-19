using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageStencilToImage
	/// </summary>
	/// <remarks>
	///    Convert an image stencil into an image
	///
	/// vtkImageStencilToImage will convert an image stencil into a binary
	/// image.  The default output will be an 8-bit image with a value of 1
	/// inside the stencil and 0 outside.  When used in combination with
	/// vtkPolyDataToImageStencil or vtkImplicitFunctionToImageStencil, this
	/// can be used to create a binary image from a mesh or a function.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitModeller
	/// </seealso>
	// Token: 0x02000235 RID: 565
	public class vtkImageStencilToImage : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060069A1 RID: 27041 RVA: 0x00098A87 File Offset: 0x00096C87
		static vtkImageStencilToImage()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageStencilToImage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageStencilToImage"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060069A2 RID: 27042 RVA: 0x00098AAF File Offset: 0x00096CAF
		public vtkImageStencilToImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060069A3 RID: 27043
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilToImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069A4 RID: 27044 RVA: 0x00098AC0 File Offset: 0x00096CC0
		public new static vtkImageStencilToImage New()
		{
			vtkImageStencilToImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilToImage.vtkImageStencilToImage_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencilToImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069A5 RID: 27045 RVA: 0x00098B14 File Offset: 0x00096D14
		public vtkImageStencilToImage() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageStencilToImage.vtkImageStencilToImage_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060069A6 RID: 27046 RVA: 0x00098B58 File Offset: 0x00096D58
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060069A7 RID: 27047
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageStencilToImage_GetInsideValue_01(HandleRef pThis);

		/// <summary>
		/// The value to use inside the stencil.  The default is 1.
		/// </summary>
		// Token: 0x060069A8 RID: 27048 RVA: 0x00098B64 File Offset: 0x00096D64
		public virtual double GetInsideValue()
		{
			return vtkImageStencilToImage.vtkImageStencilToImage_GetInsideValue_01(base.GetCppThis());
		}

		// Token: 0x060069A9 RID: 27049
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageStencilToImage_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069AA RID: 27050 RVA: 0x00098B84 File Offset: 0x00096D84
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageStencilToImage.vtkImageStencilToImage_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060069AB RID: 27051
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageStencilToImage_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069AC RID: 27052 RVA: 0x00098BA4 File Offset: 0x00096DA4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageStencilToImage.vtkImageStencilToImage_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060069AD RID: 27053
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencilToImage_GetOutputScalarType_04(HandleRef pThis);

		/// <summary>
		/// The desired output scalar type.  The default is unsigned char.
		/// </summary>
		// Token: 0x060069AE RID: 27054 RVA: 0x00098BC0 File Offset: 0x00096DC0
		public virtual int GetOutputScalarType()
		{
			return vtkImageStencilToImage.vtkImageStencilToImage_GetOutputScalarType_04(base.GetCppThis());
		}

		// Token: 0x060069AF RID: 27055
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageStencilToImage_GetOutsideValue_05(HandleRef pThis);

		/// <summary>
		/// The value to use outside the stencil.  The default is 0.
		/// </summary>
		// Token: 0x060069B0 RID: 27056 RVA: 0x00098BE0 File Offset: 0x00096DE0
		public virtual double GetOutsideValue()
		{
			return vtkImageStencilToImage.vtkImageStencilToImage_GetOutsideValue_05(base.GetCppThis());
		}

		// Token: 0x060069B1 RID: 27057
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencilToImage_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069B2 RID: 27058 RVA: 0x00098C00 File Offset: 0x00096E00
		public override int IsA(string type)
		{
			return vtkImageStencilToImage.vtkImageStencilToImage_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060069B3 RID: 27059
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencilToImage_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069B4 RID: 27060 RVA: 0x00098C20 File Offset: 0x00096E20
		public new static int IsTypeOf(string type)
		{
			return vtkImageStencilToImage.vtkImageStencilToImage_IsTypeOf_07(type);
		}

		// Token: 0x060069B5 RID: 27061
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilToImage_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069B6 RID: 27062 RVA: 0x00098C3C File Offset: 0x00096E3C
		public new vtkImageStencilToImage NewInstance()
		{
			vtkImageStencilToImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilToImage.vtkImageStencilToImage_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencilToImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060069B7 RID: 27063
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilToImage_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060069B8 RID: 27064 RVA: 0x00098C98 File Offset: 0x00096E98
		public new static vtkImageStencilToImage SafeDownCast(vtkObjectBase o)
		{
			vtkImageStencilToImage vtkImageStencilToImage = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilToImage.vtkImageStencilToImage_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilToImage = (vtkImageStencilToImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilToImage.Register(null);
				}
			}
			return vtkImageStencilToImage;
		}

		// Token: 0x060069B9 RID: 27065
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilToImage_SetInsideValue_11(HandleRef pThis, double _arg);

		/// <summary>
		/// The value to use inside the stencil.  The default is 1.
		/// </summary>
		// Token: 0x060069BA RID: 27066 RVA: 0x00098D17 File Offset: 0x00096F17
		public virtual void SetInsideValue(double _arg)
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetInsideValue_11(base.GetCppThis(), _arg);
		}

		// Token: 0x060069BB RID: 27067
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilToImage_SetOutputScalarType_12(HandleRef pThis, int _arg);

		/// <summary>
		/// The desired output scalar type.  The default is unsigned char.
		/// </summary>
		// Token: 0x060069BC RID: 27068 RVA: 0x00098D27 File Offset: 0x00096F27
		public virtual void SetOutputScalarType(int _arg)
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarType_12(base.GetCppThis(), _arg);
		}

		// Token: 0x060069BD RID: 27069
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToChar_13(HandleRef pThis);

		/// <summary>
		/// The desired output scalar type.  The default is unsigned char.
		/// </summary>
		// Token: 0x060069BE RID: 27070 RVA: 0x00098D37 File Offset: 0x00096F37
		public void SetOutputScalarTypeToChar()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToChar_13(base.GetCppThis());
		}

		// Token: 0x060069BF RID: 27071
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToDouble_14(HandleRef pThis);

		/// <summary>
		/// The desired output scalar type.  The default is unsigned char.
		/// </summary>
		// Token: 0x060069C0 RID: 27072 RVA: 0x00098D46 File Offset: 0x00096F46
		public void SetOutputScalarTypeToDouble()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToDouble_14(base.GetCppThis());
		}

		// Token: 0x060069C1 RID: 27073
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToFloat_15(HandleRef pThis);

		/// <summary>
		/// The desired output scalar type.  The default is unsigned char.
		/// </summary>
		// Token: 0x060069C2 RID: 27074 RVA: 0x00098D55 File Offset: 0x00096F55
		public void SetOutputScalarTypeToFloat()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToFloat_15(base.GetCppThis());
		}

		// Token: 0x060069C3 RID: 27075
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToInt_16(HandleRef pThis);

		/// <summary>
		/// The desired output scalar type.  The default is unsigned char.
		/// </summary>
		// Token: 0x060069C4 RID: 27076 RVA: 0x00098D64 File Offset: 0x00096F64
		public void SetOutputScalarTypeToInt()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToInt_16(base.GetCppThis());
		}

		// Token: 0x060069C5 RID: 27077
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToLong_17(HandleRef pThis);

		/// <summary>
		/// The desired output scalar type.  The default is unsigned char.
		/// </summary>
		// Token: 0x060069C6 RID: 27078 RVA: 0x00098D73 File Offset: 0x00096F73
		public void SetOutputScalarTypeToLong()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToLong_17(base.GetCppThis());
		}

		// Token: 0x060069C7 RID: 27079
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToShort_18(HandleRef pThis);

		/// <summary>
		/// The desired output scalar type.  The default is unsigned char.
		/// </summary>
		// Token: 0x060069C8 RID: 27080 RVA: 0x00098D82 File Offset: 0x00096F82
		public void SetOutputScalarTypeToShort()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToShort_18(base.GetCppThis());
		}

		// Token: 0x060069C9 RID: 27081
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToUnsignedChar_19(HandleRef pThis);

		/// <summary>
		/// The desired output scalar type.  The default is unsigned char.
		/// </summary>
		// Token: 0x060069CA RID: 27082 RVA: 0x00098D91 File Offset: 0x00096F91
		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToUnsignedChar_19(base.GetCppThis());
		}

		// Token: 0x060069CB RID: 27083
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToUnsignedInt_20(HandleRef pThis);

		/// <summary>
		/// The desired output scalar type.  The default is unsigned char.
		/// </summary>
		// Token: 0x060069CC RID: 27084 RVA: 0x00098DA0 File Offset: 0x00096FA0
		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToUnsignedInt_20(base.GetCppThis());
		}

		// Token: 0x060069CD RID: 27085
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToUnsignedLong_21(HandleRef pThis);

		/// <summary>
		/// The desired output scalar type.  The default is unsigned char.
		/// </summary>
		// Token: 0x060069CE RID: 27086 RVA: 0x00098DAF File Offset: 0x00096FAF
		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToUnsignedLong_21(base.GetCppThis());
		}

		// Token: 0x060069CF RID: 27087
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToUnsignedShort_22(HandleRef pThis);

		/// <summary>
		/// The desired output scalar type.  The default is unsigned char.
		/// </summary>
		// Token: 0x060069D0 RID: 27088 RVA: 0x00098DBE File Offset: 0x00096FBE
		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToUnsignedShort_22(base.GetCppThis());
		}

		// Token: 0x060069D1 RID: 27089
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilToImage_SetOutsideValue_23(HandleRef pThis, double _arg);

		/// <summary>
		/// The value to use outside the stencil.  The default is 0.
		/// </summary>
		// Token: 0x060069D2 RID: 27090 RVA: 0x00098DCD File Offset: 0x00096FCD
		public virtual void SetOutsideValue(double _arg)
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutsideValue_23(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000954 RID: 2388
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageStencilToImage";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000955 RID: 2389
		public new static readonly string MRClassNameKey = "class vtkImageStencilToImage";
	}
}
