using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextRendererStringToImage
	/// </summary>
	/// <remarks>
	///    uses vtkTextRenderer to render the
	/// supplied text to an image.
	/// </remarks>
	// Token: 0x020007C2 RID: 1986
	public class vtkTextRendererStringToImage : vtkStringToImage
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060145A4 RID: 83364 RVA: 0x001CC8C3 File Offset: 0x001CAAC3
		static vtkTextRendererStringToImage()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextRendererStringToImage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextRendererStringToImage"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060145A5 RID: 83365 RVA: 0x001CC8EB File Offset: 0x001CAAEB
		public vtkTextRendererStringToImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060145A6 RID: 83366
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextRendererStringToImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145A7 RID: 83367 RVA: 0x001CC8FC File Offset: 0x001CAAFC
		public new static vtkTextRendererStringToImage New()
		{
			vtkTextRendererStringToImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextRendererStringToImage.vtkTextRendererStringToImage_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextRendererStringToImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145A8 RID: 83368 RVA: 0x001CC950 File Offset: 0x001CAB50
		public vtkTextRendererStringToImage() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTextRendererStringToImage.vtkTextRendererStringToImage_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060145A9 RID: 83369 RVA: 0x001CC994 File Offset: 0x001CAB94
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060145AA RID: 83370
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRendererStringToImage_DeepCopy_01(HandleRef pThis, HandleRef utility);

		/// <summary>
		/// Make a deep copy of the supplied utility class.
		/// </summary>
		// Token: 0x060145AB RID: 83371 RVA: 0x001CC9A0 File Offset: 0x001CABA0
		public void DeepCopy(vtkTextRendererStringToImage utility)
		{
			vtkTextRendererStringToImage.vtkTextRendererStringToImage_DeepCopy_01(base.GetCppThis(), (utility == null) ? default(HandleRef) : utility.GetCppThis());
		}

		// Token: 0x060145AC RID: 83372
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextRendererStringToImage_GetBounds_02(HandleRef pThis, HandleRef property, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1, int dpi, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		// Token: 0x060145AD RID: 83373 RVA: 0x001CC9D0 File Offset: 0x001CABD0
		public override vtkVector2i GetBounds(vtkTextProperty property, string arg1, int dpi)
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextRendererStringToImage.vtkTextRendererStringToImage_GetBounds_02(base.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis(), arg1, dpi, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060145AE RID: 83374
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextRendererStringToImage_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145AF RID: 83375 RVA: 0x001CCA44 File Offset: 0x001CAC44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTextRendererStringToImage.vtkTextRendererStringToImage_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060145B0 RID: 83376
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextRendererStringToImage_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145B1 RID: 83377 RVA: 0x001CCA64 File Offset: 0x001CAC64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTextRendererStringToImage.vtkTextRendererStringToImage_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060145B2 RID: 83378
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRendererStringToImage_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145B3 RID: 83379 RVA: 0x001CCA80 File Offset: 0x001CAC80
		public override int IsA(string type)
		{
			return vtkTextRendererStringToImage.vtkTextRendererStringToImage_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060145B4 RID: 83380
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRendererStringToImage_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145B5 RID: 83381 RVA: 0x001CCAA0 File Offset: 0x001CACA0
		public new static int IsTypeOf(string type)
		{
			return vtkTextRendererStringToImage.vtkTextRendererStringToImage_IsTypeOf_06(type);
		}

		// Token: 0x060145B6 RID: 83382
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextRendererStringToImage_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145B7 RID: 83383 RVA: 0x001CCABC File Offset: 0x001CACBC
		public new vtkTextRendererStringToImage NewInstance()
		{
			vtkTextRendererStringToImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextRendererStringToImage.vtkTextRendererStringToImage_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextRendererStringToImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060145B8 RID: 83384
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRendererStringToImage_RenderString_09(HandleRef pThis, HandleRef property, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1, int dpi, HandleRef data, IntPtr textDims);

		/// <summary>
		/// Given a text property and a string, this function initializes the
		/// vtkImageData *data and renders it in a vtkImageData. textDims, if provided,
		/// will be overwritten by the pixel width and height of the rendered string.
		/// This is useful when ScaleToPowerOfTwo is true, and the image dimensions may
		/// not match the dimensions of the rendered text.
		/// </summary>
		// Token: 0x060145B9 RID: 83385 RVA: 0x001CCB18 File Offset: 0x001CAD18
		public override int RenderString(vtkTextProperty property, string arg1, int dpi, vtkImageData data, IntPtr textDims)
		{
			return vtkTextRendererStringToImage.vtkTextRendererStringToImage_RenderString_09(base.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis(), arg1, dpi, (data == null) ? default(HandleRef) : data.GetCppThis(), textDims);
		}

		// Token: 0x060145BA RID: 83386
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextRendererStringToImage_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145BB RID: 83387 RVA: 0x001CCB68 File Offset: 0x001CAD68
		public new static vtkTextRendererStringToImage SafeDownCast(vtkObjectBase o)
		{
			vtkTextRendererStringToImage vtkTextRendererStringToImage = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextRendererStringToImage.vtkTextRendererStringToImage_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextRendererStringToImage = (vtkTextRendererStringToImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextRendererStringToImage.Register(null);
				}
			}
			return vtkTextRendererStringToImage;
		}

		// Token: 0x060145BC RID: 83388
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRendererStringToImage_SetScaleToPowerOfTwo_11(HandleRef pThis, byte scale);

		/// <summary>
		/// Should we produce images at powers of 2, makes rendering on old OpenGL
		/// hardware easier. Default is false.
		/// </summary>
		// Token: 0x060145BD RID: 83389 RVA: 0x001CCBE7 File Offset: 0x001CADE7
		public override void SetScaleToPowerOfTwo(bool scale)
		{
			vtkTextRendererStringToImage.vtkTextRendererStringToImage_SetScaleToPowerOfTwo_11(base.GetCppThis(), scale ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017A2 RID: 6050
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextRendererStringToImage";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017A3 RID: 6051
		public new static readonly string MRClassNameKey = "class vtkTextRendererStringToImage";
	}
}
