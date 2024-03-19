using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFreeTypeStringToImage
	/// </summary>
	/// <remarks>
	///    render the supplied text to an image.
	///
	/// </remarks>
	// Token: 0x020007BB RID: 1979
	public class vtkFreeTypeStringToImage : vtkStringToImage
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060144C3 RID: 83139 RVA: 0x001CB1A7 File Offset: 0x001C93A7
		static vtkFreeTypeStringToImage()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFreeTypeStringToImage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFreeTypeStringToImage"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060144C4 RID: 83140 RVA: 0x001CB1CF File Offset: 0x001C93CF
		public vtkFreeTypeStringToImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060144C5 RID: 83141
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFreeTypeStringToImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060144C6 RID: 83142 RVA: 0x001CB1E0 File Offset: 0x001C93E0
		public new static vtkFreeTypeStringToImage New()
		{
			vtkFreeTypeStringToImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFreeTypeStringToImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060144C7 RID: 83143 RVA: 0x001CB234 File Offset: 0x001C9434
		public vtkFreeTypeStringToImage() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060144C8 RID: 83144 RVA: 0x001CB278 File Offset: 0x001C9478
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060144C9 RID: 83145
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeStringToImage_DeepCopy_01(HandleRef pThis, HandleRef utility);

		/// <summary>
		/// Make a deep copy of the supplied utility class.
		/// </summary>
		// Token: 0x060144CA RID: 83146 RVA: 0x001CB284 File Offset: 0x001C9484
		public void DeepCopy(vtkFreeTypeStringToImage utility)
		{
			vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_DeepCopy_01(base.GetCppThis(), (utility == null) ? default(HandleRef) : utility.GetCppThis());
		}

		// Token: 0x060144CB RID: 83147
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFreeTypeStringToImage_GetBounds_02(HandleRef pThis, HandleRef property, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1, int dpi, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a text property and a string, get the bounding box [xmin, xmax] x
		/// [ymin, ymax]. Note that this is the bounding box of the area
		/// where actual pixels will be written, given a text/pen/baseline location
		/// of (0,0).
		/// For example, if the string starts with a 'space', or depending on the
		/// orientation, you can end up with a [-20, -10] x [5, 10] bbox (the math
		/// to get the real bbox is straightforward).
		/// Return 1 on success, 0 otherwise.
		/// You can use IsBoundingBoxValid() to test if the computed bbox
		/// is valid (it may not if GetBoundingBox() failed or if the string
		/// was empty).
		/// </summary>
		// Token: 0x060144CC RID: 83148 RVA: 0x001CB2B4 File Offset: 0x001C94B4
		public override vtkVector2i GetBounds(vtkTextProperty property, string arg1, int dpi)
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_GetBounds_02(base.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis(), arg1, dpi, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060144CD RID: 83149
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFreeTypeStringToImage_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060144CE RID: 83150 RVA: 0x001CB328 File Offset: 0x001C9528
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060144CF RID: 83151
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFreeTypeStringToImage_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060144D0 RID: 83152 RVA: 0x001CB348 File Offset: 0x001C9548
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060144D1 RID: 83153
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFreeTypeStringToImage_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060144D2 RID: 83154 RVA: 0x001CB364 File Offset: 0x001C9564
		public override int IsA(string type)
		{
			return vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060144D3 RID: 83155
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFreeTypeStringToImage_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060144D4 RID: 83156 RVA: 0x001CB384 File Offset: 0x001C9584
		public new static int IsTypeOf(string type)
		{
			return vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_IsTypeOf_06(type);
		}

		// Token: 0x060144D5 RID: 83157
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFreeTypeStringToImage_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060144D6 RID: 83158 RVA: 0x001CB3A0 File Offset: 0x001C95A0
		public new vtkFreeTypeStringToImage NewInstance()
		{
			vtkFreeTypeStringToImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFreeTypeStringToImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060144D7 RID: 83159
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFreeTypeStringToImage_RenderString_09(HandleRef pThis, HandleRef property, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1, int dpi, HandleRef data, IntPtr textDims);

		/// <summary>
		/// Given a text property and a string, this function initializes the
		/// vtkImageData *data and renders it in a vtkImageData. textDims, if provided,
		/// will be overwritten by the pixel width and height of the rendered string.
		/// This is useful when ScaleToPowerOfTwo is true, and the image dimensions may
		/// not match the dimensions of the rendered text.
		/// </summary>
		// Token: 0x060144D8 RID: 83160 RVA: 0x001CB3FC File Offset: 0x001C95FC
		public override int RenderString(vtkTextProperty property, string arg1, int dpi, vtkImageData data, IntPtr textDims)
		{
			return vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_RenderString_09(base.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis(), arg1, dpi, (data == null) ? default(HandleRef) : data.GetCppThis(), textDims);
		}

		// Token: 0x060144D9 RID: 83161
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFreeTypeStringToImage_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060144DA RID: 83162 RVA: 0x001CB44C File Offset: 0x001C964C
		public new static vtkFreeTypeStringToImage SafeDownCast(vtkObjectBase o)
		{
			vtkFreeTypeStringToImage vtkFreeTypeStringToImage = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFreeTypeStringToImage = (vtkFreeTypeStringToImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFreeTypeStringToImage.Register(null);
				}
			}
			return vtkFreeTypeStringToImage;
		}

		// Token: 0x060144DB RID: 83163
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeStringToImage_SetScaleToPowerOfTwo_11(HandleRef pThis, byte scale);

		/// <summary>
		/// Should we produce images at powers of 2, makes rendering on old OpenGL
		/// hardware easier. Default is false.
		/// </summary>
		// Token: 0x060144DC RID: 83164 RVA: 0x001CB4CB File Offset: 0x001C96CB
		public override void SetScaleToPowerOfTwo(bool scale)
		{
			vtkFreeTypeStringToImage.vtkFreeTypeStringToImage_SetScaleToPowerOfTwo_11(base.GetCppThis(), scale ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001790 RID: 6032
		public new const string MRFullTypeName = "Kitware.VTK.vtkFreeTypeStringToImage";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001791 RID: 6033
		public new static readonly string MRClassNameKey = "class vtkFreeTypeStringToImage";
	}
}
