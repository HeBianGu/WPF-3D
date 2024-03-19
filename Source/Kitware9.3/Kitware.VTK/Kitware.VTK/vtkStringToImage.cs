using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStringToImage
	/// </summary>
	/// <remarks>
	///    base class for classes that render supplied text
	/// to an image.
	///
	///
	///
	/// </remarks>
	// Token: 0x020007BA RID: 1978
	public abstract class vtkStringToImage : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060144AC RID: 83116 RVA: 0x001CAF0E File Offset: 0x001C910E
		static vtkStringToImage()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStringToImage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStringToImage"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060144AD RID: 83117 RVA: 0x001CAF36 File Offset: 0x001C9136
		public vtkStringToImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060144AE RID: 83118 RVA: 0x001CAF44 File Offset: 0x001C9144
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060144AF RID: 83119
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringToImage_GetBounds_01(HandleRef pThis, HandleRef property, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1, int dpi, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
		// Token: 0x060144B0 RID: 83120 RVA: 0x001CAF50 File Offset: 0x001C9150
		public virtual vtkVector2i GetBounds(vtkTextProperty property, string arg1, int dpi)
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringToImage.vtkStringToImage_GetBounds_01(base.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis(), arg1, dpi, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060144B1 RID: 83121
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringToImage_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060144B2 RID: 83122 RVA: 0x001CAFC4 File Offset: 0x001C91C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStringToImage.vtkStringToImage_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060144B3 RID: 83123
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringToImage_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060144B4 RID: 83124 RVA: 0x001CAFE4 File Offset: 0x001C91E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStringToImage.vtkStringToImage_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060144B5 RID: 83125
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStringToImage_GetScaleToPowerOfTwo_04(HandleRef pThis);

		/// <summary>
		/// Should we produce images at powers of 2, makes rendering on old OpenGL
		/// hardware easier. Default is false.
		/// </summary>
		// Token: 0x060144B6 RID: 83126 RVA: 0x001CB000 File Offset: 0x001C9200
		public virtual bool GetScaleToPowerOfTwo()
		{
			return vtkStringToImage.vtkStringToImage_GetScaleToPowerOfTwo_04(base.GetCppThis()) != 0;
		}

		// Token: 0x060144B7 RID: 83127
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringToImage_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060144B8 RID: 83128 RVA: 0x001CB028 File Offset: 0x001C9228
		public override int IsA(string type)
		{
			return vtkStringToImage.vtkStringToImage_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060144B9 RID: 83129
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringToImage_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060144BA RID: 83130 RVA: 0x001CB048 File Offset: 0x001C9248
		public new static int IsTypeOf(string type)
		{
			return vtkStringToImage.vtkStringToImage_IsTypeOf_06(type);
		}

		// Token: 0x060144BB RID: 83131
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringToImage_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060144BC RID: 83132 RVA: 0x001CB064 File Offset: 0x001C9264
		public new vtkStringToImage NewInstance()
		{
			vtkStringToImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringToImage.vtkStringToImage_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringToImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060144BD RID: 83133
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringToImage_RenderString_08(HandleRef pThis, HandleRef property, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1, int dpi, HandleRef data, IntPtr text_dims);

		/// <summary>
		/// Given a text property and a string, this function initializes the
		/// vtkImageData *data and renders it in a vtkImageData. textDims, if provided,
		/// will be overwritten by the pixel width and height of the rendered string.
		/// This is useful when ScaleToPowerOfTwo is true, and the image dimensions may
		/// not match the dimensions of the rendered text.
		/// </summary>
		// Token: 0x060144BE RID: 83134 RVA: 0x001CB0C0 File Offset: 0x001C92C0
		public virtual int RenderString(vtkTextProperty property, string arg1, int dpi, vtkImageData data, IntPtr text_dims)
		{
			return vtkStringToImage.vtkStringToImage_RenderString_08(base.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis(), arg1, dpi, (data == null) ? default(HandleRef) : data.GetCppThis(), text_dims);
		}

		// Token: 0x060144BF RID: 83135
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringToImage_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060144C0 RID: 83136 RVA: 0x001CB110 File Offset: 0x001C9310
		public new static vtkStringToImage SafeDownCast(vtkObjectBase o)
		{
			vtkStringToImage vtkStringToImage = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringToImage.vtkStringToImage_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringToImage = (vtkStringToImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringToImage.Register(null);
				}
			}
			return vtkStringToImage;
		}

		// Token: 0x060144C1 RID: 83137
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToImage_SetScaleToPowerOfTwo_10(HandleRef pThis, byte scale);

		/// <summary>
		/// Should we produce images at powers of 2, makes rendering on old OpenGL
		/// hardware easier. Default is false.
		/// </summary>
		// Token: 0x060144C2 RID: 83138 RVA: 0x001CB18F File Offset: 0x001C938F
		public virtual void SetScaleToPowerOfTwo(bool scale)
		{
			vtkStringToImage.vtkStringToImage_SetScaleToPowerOfTwo_10(base.GetCppThis(), scale ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400178E RID: 6030
		public new const string MRFullTypeName = "Kitware.VTK.vtkStringToImage";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400178F RID: 6031
		public new static readonly string MRClassNameKey = "class vtkStringToImage";
	}
}
