using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMathTextUtilities
	/// </summary>
	/// <remarks>
	///    Abstract interface to equation rendering.
	///
	/// vtkMathTextUtilities defines an interface for equation rendering. Intended
	/// for use with the python matplotlib.mathtext module (implemented in the
	/// vtkMatplotlib module).
	/// </remarks>
	// Token: 0x020007C0 RID: 1984
	public abstract class vtkMathTextUtilities : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601456E RID: 83310 RVA: 0x001CC23B File Offset: 0x001CA43B
		static vtkMathTextUtilities()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMathTextUtilities.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMathTextUtilities"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601456F RID: 83311 RVA: 0x001CC263 File Offset: 0x001CA463
		public vtkMathTextUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014570 RID: 83312
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMathTextUtilities_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This is a singleton pattern New. There will be only ONE reference
		/// to a vtkMathTextUtilities object per process.  Clients that
		/// call this method must use Delete() on the object so that reference
		/// counting will work. The single instance will be unreferenced when
		/// the program exits. You should just use the static GetInstance() method
		/// anyway to get the singleton.
		/// </summary>
		// Token: 0x06014571 RID: 83313 RVA: 0x001CC274 File Offset: 0x001CA474
		public new static vtkMathTextUtilities New()
		{
			vtkMathTextUtilities result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMathTextUtilities.vtkMathTextUtilities_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMathTextUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// This is a singleton pattern New. There will be only ONE reference
		/// to a vtkMathTextUtilities object per process.  Clients that
		/// call this method must use Delete() on the object so that reference
		/// counting will work. The single instance will be unreferenced when
		/// the program exits. You should just use the static GetInstance() method
		/// anyway to get the singleton.
		/// </summary>
		// Token: 0x06014572 RID: 83314 RVA: 0x001CC2C8 File Offset: 0x001CA4C8
		public vtkMathTextUtilities() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMathTextUtilities.vtkMathTextUtilities_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014573 RID: 83315 RVA: 0x001CC30C File Offset: 0x001CA50C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014574 RID: 83316
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMathTextUtilities_GetBoundingBox_01(HandleRef pThis, HandleRef tprop, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, int dpi, IntPtr bbox);

		/// <summary>
		/// Determine the dimensions of the image that RenderString will produce for
		/// a given str, tprop, and dpi
		/// </summary>
		// Token: 0x06014575 RID: 83317 RVA: 0x001CC318 File Offset: 0x001CA518
		public virtual bool GetBoundingBox(vtkTextProperty tprop, string str, int dpi, IntPtr bbox)
		{
			return vtkMathTextUtilities.vtkMathTextUtilities_GetBoundingBox_01(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), str, dpi, bbox) != 0;
		}

		// Token: 0x06014576 RID: 83318
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMathTextUtilities_GetConstrainedFontSize_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, HandleRef tprop, int targetWidth, int targetHeight, int dpi);

		/// <summary>
		/// This function returns the font size (in points) required to fit the string
		/// in the target rectangle. The font size of tprop is updated to the computed
		/// value as well. If an error occurs (e.g. an improperly formatted MathText
		/// string), -1 is returned.
		/// </summary>
		// Token: 0x06014577 RID: 83319 RVA: 0x001CC358 File Offset: 0x001CA558
		public virtual int GetConstrainedFontSize(string str, vtkTextProperty tprop, int targetWidth, int targetHeight, int dpi)
		{
			return vtkMathTextUtilities.vtkMathTextUtilities_GetConstrainedFontSize_02(base.GetCppThis(), str, (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), targetWidth, targetHeight, dpi);
		}

		// Token: 0x06014578 RID: 83320
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMathTextUtilities_GetInstance_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the singleton instance with no reference counting.
		/// </summary>
		// Token: 0x06014579 RID: 83321 RVA: 0x001CC394 File Offset: 0x001CA594
		public static vtkMathTextUtilities GetInstance()
		{
			vtkMathTextUtilities vtkMathTextUtilities = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMathTextUtilities.vtkMathTextUtilities_GetInstance_03(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMathTextUtilities = (vtkMathTextUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMathTextUtilities.Register(null);
				}
			}
			return vtkMathTextUtilities;
		}

		// Token: 0x0601457A RID: 83322
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMathTextUtilities_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601457B RID: 83323 RVA: 0x001CC400 File Offset: 0x001CA600
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMathTextUtilities.vtkMathTextUtilities_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601457C RID: 83324
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMathTextUtilities_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601457D RID: 83325 RVA: 0x001CC420 File Offset: 0x001CA620
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMathTextUtilities.vtkMathTextUtilities_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601457E RID: 83326
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMathTextUtilities_GetScaleToPowerOfTwo_06(HandleRef pThis);

		/// <summary>
		/// Set to true if the graphics implementation requires texture image dimensions
		/// to be a power of two. Default is true, but this member will be set
		/// appropriately when GL is inited.
		/// </summary>
		// Token: 0x0601457F RID: 83327 RVA: 0x001CC43C File Offset: 0x001CA63C
		public virtual bool GetScaleToPowerOfTwo()
		{
			return vtkMathTextUtilities.vtkMathTextUtilities_GetScaleToPowerOfTwo_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06014580 RID: 83328
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMathTextUtilities_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014581 RID: 83329 RVA: 0x001CC464 File Offset: 0x001CA664
		public override int IsA(string type)
		{
			return vtkMathTextUtilities.vtkMathTextUtilities_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06014582 RID: 83330
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMathTextUtilities_IsAvailable_08(HandleRef pThis);

		/// <summary>
		/// Returns true if mathtext rendering is available.
		/// </summary>
		// Token: 0x06014583 RID: 83331 RVA: 0x001CC484 File Offset: 0x001CA684
		public virtual bool IsAvailable()
		{
			return vtkMathTextUtilities.vtkMathTextUtilities_IsAvailable_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06014584 RID: 83332
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMathTextUtilities_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014585 RID: 83333 RVA: 0x001CC4AC File Offset: 0x001CA6AC
		public new static int IsTypeOf(string type)
		{
			return vtkMathTextUtilities.vtkMathTextUtilities_IsTypeOf_09(type);
		}

		// Token: 0x06014586 RID: 83334
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMathTextUtilities_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014587 RID: 83335 RVA: 0x001CC4C8 File Offset: 0x001CA6C8
		public new vtkMathTextUtilities NewInstance()
		{
			vtkMathTextUtilities result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMathTextUtilities.vtkMathTextUtilities_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMathTextUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014588 RID: 83336
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMathTextUtilities_RenderString_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, HandleRef data, HandleRef tprop, int dpi, IntPtr textDims);

		/// <summary>
		/// Render the given string @a str into the vtkImageData @a data with a
		/// resolution of @a dpi. textDims, will be overwritten by the pixel width and
		/// height of the rendered string. This is useful when ScaleToPowerOfTwo is
		/// set to true, and the image dimensions may not match the dimensions of the
		/// rendered text.
		/// </summary>
		// Token: 0x06014589 RID: 83337 RVA: 0x001CC524 File Offset: 0x001CA724
		public virtual bool RenderString(string str, vtkImageData data, vtkTextProperty tprop, int dpi, IntPtr textDims)
		{
			return vtkMathTextUtilities.vtkMathTextUtilities_RenderString_12(base.GetCppThis(), str, (data == null) ? default(HandleRef) : data.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), dpi, textDims) != 0;
		}

		// Token: 0x0601458A RID: 83338
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMathTextUtilities_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601458B RID: 83339 RVA: 0x001CC57C File Offset: 0x001CA77C
		public new static vtkMathTextUtilities SafeDownCast(vtkObjectBase o)
		{
			vtkMathTextUtilities vtkMathTextUtilities = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMathTextUtilities.vtkMathTextUtilities_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMathTextUtilities = (vtkMathTextUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMathTextUtilities.Register(null);
				}
			}
			return vtkMathTextUtilities;
		}

		// Token: 0x0601458C RID: 83340
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMathTextUtilities_SetInstance_14(HandleRef instance);

		/// <summary>
		/// Supply a user defined instance. Call Delete() on the supplied
		/// instance after setting it to fix the reference count.
		/// </summary>
		// Token: 0x0601458D RID: 83341 RVA: 0x001CC5FC File Offset: 0x001CA7FC
		public static void SetInstance(vtkMathTextUtilities instance)
		{
			vtkMathTextUtilities.vtkMathTextUtilities_SetInstance_14((instance == null) ? default(HandleRef) : instance.GetCppThis());
		}

		// Token: 0x0601458E RID: 83342
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMathTextUtilities_SetScaleToPowerOfTwo_15(HandleRef pThis, byte scale);

		/// <summary>
		/// Set to true if the graphics implementation requires texture image dimensions
		/// to be a power of two. Default is true, but this member will be set
		/// appropriately when GL is inited.
		/// </summary>
		// Token: 0x0601458F RID: 83343 RVA: 0x001CC625 File Offset: 0x001CA825
		public virtual void SetScaleToPowerOfTwo(bool scale)
		{
			vtkMathTextUtilities.vtkMathTextUtilities_SetScaleToPowerOfTwo_15(base.GetCppThis(), scale ? (byte)1 : (byte)0);
		}

		// Token: 0x06014590 RID: 83344
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMathTextUtilities_StringToPath_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, HandleRef path, HandleRef tprop, int dpi);

		/// <summary>
		/// Parse the MathText expression in str and fill path with a contour of the
		/// glyphs.
		/// </summary>
		// Token: 0x06014591 RID: 83345 RVA: 0x001CC640 File Offset: 0x001CA840
		public virtual bool StringToPath(string str, vtkPath path, vtkTextProperty tprop, int dpi)
		{
			return vtkMathTextUtilities.vtkMathTextUtilities_StringToPath_16(base.GetCppThis(), str, (path == null) ? default(HandleRef) : path.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), dpi) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400179E RID: 6046
		public new const string MRFullTypeName = "Kitware.VTK.vtkMathTextUtilities";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400179F RID: 6047
		public new static readonly string MRClassNameKey = "class vtkMathTextUtilities";
	}
}
