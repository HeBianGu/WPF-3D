using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFreeTypeTools
	/// </summary>
	/// <remarks>
	///    FreeType library support
	///
	/// vtkFreeTypeTools provides a low-level interface to the FreeType2 library,
	/// including font-cache and rasterization.
	///
	/// @warning
	/// Internal use only.
	/// </remarks>
	// Token: 0x020007BC RID: 1980
	public class vtkFreeTypeTools : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060144DD RID: 83165 RVA: 0x001CB4E3 File Offset: 0x001C96E3
		static vtkFreeTypeTools()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFreeTypeTools.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFreeTypeTools"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060144DE RID: 83166 RVA: 0x001CB50B File Offset: 0x001C970B
		public vtkFreeTypeTools(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060144DF RID: 83167 RVA: 0x001CB519 File Offset: 0x001C9719
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060144E0 RID: 83168
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeTools_DebugTexturesOff_01(HandleRef pThis);

		/// <summary>
		/// If true, images produced by RenderString will have a transparent grey
		/// background and set the justification anchor texel to bright yellow.
		/// </summary>
		// Token: 0x060144E1 RID: 83169 RVA: 0x001CB524 File Offset: 0x001C9724
		public virtual void DebugTexturesOff()
		{
			vtkFreeTypeTools.vtkFreeTypeTools_DebugTexturesOff_01(base.GetCppThis());
		}

		// Token: 0x060144E2 RID: 83170
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeTools_DebugTexturesOn_02(HandleRef pThis);

		/// <summary>
		/// If true, images produced by RenderString will have a transparent grey
		/// background and set the justification anchor texel to bright yellow.
		/// </summary>
		// Token: 0x060144E3 RID: 83171 RVA: 0x001CB533 File Offset: 0x001C9733
		public virtual void DebugTexturesOn()
		{
			vtkFreeTypeTools.vtkFreeTypeTools_DebugTexturesOn_02(base.GetCppThis());
		}

		// Token: 0x060144E4 RID: 83172
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeTools_ForceCompiledFontsOff_03(HandleRef pThis);

		/// <summary>
		/// Force use of the fonts compiled into VTK, ignoring any FontConfig or
		/// embedded fonts. Useful for generating test images consistently across
		/// platforms. This flag is on by default.
		/// </summary>
		// Token: 0x060144E5 RID: 83173 RVA: 0x001CB542 File Offset: 0x001C9742
		public virtual void ForceCompiledFontsOff()
		{
			vtkFreeTypeTools.vtkFreeTypeTools_ForceCompiledFontsOff_03(base.GetCppThis());
		}

		// Token: 0x060144E6 RID: 83174
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeTools_ForceCompiledFontsOn_04(HandleRef pThis);

		/// <summary>
		/// Force use of the fonts compiled into VTK, ignoring any FontConfig or
		/// embedded fonts. Useful for generating test images consistently across
		/// platforms. This flag is on by default.
		/// </summary>
		// Token: 0x060144E7 RID: 83175 RVA: 0x001CB551 File Offset: 0x001C9751
		public virtual void ForceCompiledFontsOn()
		{
			vtkFreeTypeTools.vtkFreeTypeTools_ForceCompiledFontsOn_04(base.GetCppThis());
		}

		// Token: 0x060144E8 RID: 83176
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFreeTypeTools_GetBoundingBox_05(HandleRef pThis, HandleRef tprop, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, int dpi, IntPtr bbox);

		/// <summary>
		/// Given a text property and a string, get the bounding box {xmin, xmax,
		/// ymin, ymax} of the rendered string in pixels. The origin of the bounding
		/// box is the anchor point described by the horizontal and vertical
		/// justification text property variables.
		/// Returns true on success, false otherwise.
		/// @sa GetMetrics
		/// </summary>
		// Token: 0x060144E9 RID: 83177 RVA: 0x001CB560 File Offset: 0x001C9760
		public bool GetBoundingBox(vtkTextProperty tprop, string str, int dpi, IntPtr bbox)
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetBoundingBox_05(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), str, dpi, bbox) != 0;
		}

		// Token: 0x060144EA RID: 83178
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFreeTypeTools_GetConstrainedFontSize_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, HandleRef tprop, int dpi, int targetWidth, int targetHeight);

		/// <summary>
		/// This function returns the font size (in points) required to fit the string
		/// in the target rectangle. The font size of tprop is updated to the computed
		/// value as well. If an error occurs, -1 is returned.
		/// </summary>
		// Token: 0x060144EB RID: 83179 RVA: 0x001CB5A0 File Offset: 0x001C97A0
		public int GetConstrainedFontSize(string str, vtkTextProperty tprop, int dpi, int targetWidth, int targetHeight)
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetConstrainedFontSize_06(base.GetCppThis(), str, (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), dpi, targetWidth, targetHeight);
		}

		// Token: 0x060144EC RID: 83180
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFreeTypeTools_GetDebugTextures_07(HandleRef pThis);

		/// <summary>
		/// If true, images produced by RenderString will have a transparent grey
		/// background and set the justification anchor texel to bright yellow.
		/// </summary>
		// Token: 0x060144ED RID: 83181 RVA: 0x001CB5DC File Offset: 0x001C97DC
		public virtual bool GetDebugTextures()
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetDebugTextures_07(base.GetCppThis()) != 0;
		}

		// Token: 0x060144EE RID: 83182
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFreeTypeTools_GetForceCompiledFonts_08(HandleRef pThis);

		/// <summary>
		/// Force use of the fonts compiled into VTK, ignoring any FontConfig or
		/// embedded fonts. Useful for generating test images consistently across
		/// platforms. This flag is on by default.
		/// </summary>
		// Token: 0x060144EF RID: 83183 RVA: 0x001CB604 File Offset: 0x001C9804
		public virtual bool GetForceCompiledFonts()
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetForceCompiledFonts_08(base.GetCppThis()) != 0;
		}

		// Token: 0x060144F0 RID: 83184
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFreeTypeTools_GetInstance_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the singleton instance with no reference counting.
		/// </summary>
		// Token: 0x060144F1 RID: 83185 RVA: 0x001CB62C File Offset: 0x001C982C
		public static vtkFreeTypeTools GetInstance()
		{
			vtkFreeTypeTools vtkFreeTypeTools = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFreeTypeTools.vtkFreeTypeTools_GetInstance_09(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFreeTypeTools = (vtkFreeTypeTools)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFreeTypeTools.Register(null);
				}
			}
			return vtkFreeTypeTools;
		}

		// Token: 0x060144F2 RID: 83186
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfBytes_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
		/// bytes used by the cache. These settings can be changed as long as
		/// it is done prior to accessing any of the caches or the cache manager.
		/// </summary>
		// Token: 0x060144F3 RID: 83187 RVA: 0x001CB698 File Offset: 0x001C9898
		public virtual uint GetMaximumNumberOfBytes()
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetMaximumNumberOfBytes_10(base.GetCppThis());
		}

		// Token: 0x060144F4 RID: 83188
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfBytesMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
		/// bytes used by the cache. These settings can be changed as long as
		/// it is done prior to accessing any of the caches or the cache manager.
		/// </summary>
		// Token: 0x060144F5 RID: 83189 RVA: 0x001CB6B8 File Offset: 0x001C98B8
		public virtual uint GetMaximumNumberOfBytesMaxValue()
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetMaximumNumberOfBytesMaxValue_11(base.GetCppThis());
		}

		// Token: 0x060144F6 RID: 83190
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfBytesMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
		/// bytes used by the cache. These settings can be changed as long as
		/// it is done prior to accessing any of the caches or the cache manager.
		/// </summary>
		// Token: 0x060144F7 RID: 83191 RVA: 0x001CB6D8 File Offset: 0x001C98D8
		public virtual uint GetMaximumNumberOfBytesMinValue()
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetMaximumNumberOfBytesMinValue_12(base.GetCppThis());
		}

		// Token: 0x060144F8 RID: 83192
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfFaces_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
		/// bytes used by the cache. These settings can be changed as long as
		/// it is done prior to accessing any of the caches or the cache manager.
		/// </summary>
		// Token: 0x060144F9 RID: 83193 RVA: 0x001CB6F8 File Offset: 0x001C98F8
		public virtual uint GetMaximumNumberOfFaces()
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetMaximumNumberOfFaces_13(base.GetCppThis());
		}

		// Token: 0x060144FA RID: 83194
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfFacesMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
		/// bytes used by the cache. These settings can be changed as long as
		/// it is done prior to accessing any of the caches or the cache manager.
		/// </summary>
		// Token: 0x060144FB RID: 83195 RVA: 0x001CB718 File Offset: 0x001C9918
		public virtual uint GetMaximumNumberOfFacesMaxValue()
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetMaximumNumberOfFacesMaxValue_14(base.GetCppThis());
		}

		// Token: 0x060144FC RID: 83196
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfFacesMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
		/// bytes used by the cache. These settings can be changed as long as
		/// it is done prior to accessing any of the caches or the cache manager.
		/// </summary>
		// Token: 0x060144FD RID: 83197 RVA: 0x001CB738 File Offset: 0x001C9938
		public virtual uint GetMaximumNumberOfFacesMinValue()
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetMaximumNumberOfFacesMinValue_15(base.GetCppThis());
		}

		// Token: 0x060144FE RID: 83198
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfSizes_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
		/// bytes used by the cache. These settings can be changed as long as
		/// it is done prior to accessing any of the caches or the cache manager.
		/// </summary>
		// Token: 0x060144FF RID: 83199 RVA: 0x001CB758 File Offset: 0x001C9958
		public virtual uint GetMaximumNumberOfSizes()
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetMaximumNumberOfSizes_16(base.GetCppThis());
		}

		// Token: 0x06014500 RID: 83200
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfSizesMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
		/// bytes used by the cache. These settings can be changed as long as
		/// it is done prior to accessing any of the caches or the cache manager.
		/// </summary>
		// Token: 0x06014501 RID: 83201 RVA: 0x001CB778 File Offset: 0x001C9978
		public virtual uint GetMaximumNumberOfSizesMaxValue()
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetMaximumNumberOfSizesMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06014502 RID: 83202
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfSizesMinValue_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
		/// bytes used by the cache. These settings can be changed as long as
		/// it is done prior to accessing any of the caches or the cache manager.
		/// </summary>
		// Token: 0x06014503 RID: 83203 RVA: 0x001CB798 File Offset: 0x001C9998
		public virtual uint GetMaximumNumberOfSizesMinValue()
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetMaximumNumberOfSizesMinValue_18(base.GetCppThis());
		}

		// Token: 0x06014504 RID: 83204
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFreeTypeTools_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014505 RID: 83205 RVA: 0x001CB7B8 File Offset: 0x001C99B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x06014506 RID: 83206
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFreeTypeTools_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014507 RID: 83207 RVA: 0x001CB7D8 File Offset: 0x001C99D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x06014508 RID: 83208
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFreeTypeTools_GetScaleToPowerTwo_21(HandleRef pThis);

		/// <summary>
		/// Set whether the image produced should be scaled up to the nearest power of
		/// 2. This is normally required for older graphics cards where all textures
		/// must be a power of 2. This defaults to false, and should be fine on modern
		/// hardware.
		/// </summary>
		// Token: 0x06014509 RID: 83209 RVA: 0x001CB7F4 File Offset: 0x001C99F4
		public virtual bool GetScaleToPowerTwo()
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_GetScaleToPowerTwo_21(base.GetCppThis()) != 0;
		}

		// Token: 0x0601450A RID: 83210
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkFreeTypeTools_HashBuffer_22(IntPtr buffer, ulong n, uint hash);

		/// <summary>
		/// Hash a buffer of a given length. This function hashes n bytes and does
		/// not depend on a terminating null character.
		/// </summary>
		// Token: 0x0601450B RID: 83211 RVA: 0x001CB81C File Offset: 0x001C9A1C
		public static uint HashBuffer(IntPtr buffer, ulong n, uint hash)
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_HashBuffer_22(buffer, n, hash);
		}

		// Token: 0x0601450C RID: 83212
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkFreeTypeTools_HashString_23([MarshalAs(UnmanagedType.LPUTF8Str)] string str);

		/// <summary>
		/// Turn a string into a hash. This is not a general purpose hash
		/// function, and is only used to generate identifiers for cached fonts.
		/// </summary>
		// Token: 0x0601450D RID: 83213 RVA: 0x001CB838 File Offset: 0x001C9A38
		public static ushort HashString(string str)
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_HashString_23(str);
		}

		// Token: 0x0601450E RID: 83214
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFreeTypeTools_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601450F RID: 83215 RVA: 0x001CB854 File Offset: 0x001C9A54
		public override int IsA(string type)
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x06014510 RID: 83216
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFreeTypeTools_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014511 RID: 83217 RVA: 0x001CB874 File Offset: 0x001C9A74
		public new static int IsTypeOf(string type)
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_IsTypeOf_25(type);
		}

		// Token: 0x06014512 RID: 83218
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeTools_MapIdToTextProperty_26(HandleRef pThis, ulong tprop_cache_id, HandleRef tprop);

		/// <summary>
		/// Given a text property 'tprop', get its unique ID in our cache framework.
		/// In the same way, given a unique ID in our cache, retrieve the
		/// corresponding text property and assign its parameters to 'tprop'.
		/// Warning: there is no one to one mapping between a single text property
		/// the corresponding ID, and vice-versa. The ID is just a fast hash, a
		/// binary mask concatenating the attributes of the text property that are
		/// relevant to our cache (Color, Opacity, Justification setting are not
		/// stored).
		/// </summary>
		// Token: 0x06014513 RID: 83219 RVA: 0x001CB890 File Offset: 0x001C9A90
		public void MapIdToTextProperty(ulong tprop_cache_id, vtkTextProperty tprop)
		{
			vtkFreeTypeTools.vtkFreeTypeTools_MapIdToTextProperty_26(base.GetCppThis(), tprop_cache_id, (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		// Token: 0x06014514 RID: 83220
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeTools_MapTextPropertyToId_27(HandleRef pThis, HandleRef tprop, IntPtr tprop_cache_id);

		/// <summary>
		/// Given a text property 'tprop', get its unique ID in our cache framework.
		/// In the same way, given a unique ID in our cache, retrieve the
		/// corresponding text property and assign its parameters to 'tprop'.
		/// Warning: there is no one to one mapping between a single text property
		/// the corresponding ID, and vice-versa. The ID is just a fast hash, a
		/// binary mask concatenating the attributes of the text property that are
		/// relevant to our cache (Color, Opacity, Justification setting are not
		/// stored).
		/// </summary>
		// Token: 0x06014515 RID: 83221 RVA: 0x001CB8C0 File Offset: 0x001C9AC0
		public void MapTextPropertyToId(vtkTextProperty tprop, IntPtr tprop_cache_id)
		{
			vtkFreeTypeTools.vtkFreeTypeTools_MapTextPropertyToId_27(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), tprop_cache_id);
		}

		// Token: 0x06014516 RID: 83222
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFreeTypeTools_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014517 RID: 83223 RVA: 0x001CB8F0 File Offset: 0x001C9AF0
		public new vtkFreeTypeTools NewInstance()
		{
			vtkFreeTypeTools result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFreeTypeTools.vtkFreeTypeTools_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFreeTypeTools)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014518 RID: 83224
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFreeTypeTools_RenderString_29(HandleRef pThis, HandleRef tprop, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, int dpi, HandleRef data, IntPtr textDims);

		/// <summary>
		/// Given a text property and a string, this function initializes the
		/// vtkImageData *data and renders it in a vtkImageData. textDims, if provided,
		/// will be overwritten by the pixel width and height of the rendered string.
		/// This is useful when ScaleToPowerOfTwo is true, and the image dimensions may
		/// not match the dimensions of the rendered text.
		/// The origin of the image's extents is aligned with the anchor point
		/// described by the text property's vertical and horizontal justification
		/// options.
		/// </summary>
		// Token: 0x06014519 RID: 83225 RVA: 0x001CB94C File Offset: 0x001C9B4C
		public bool RenderString(vtkTextProperty tprop, string str, int dpi, vtkImageData data, IntPtr textDims)
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_RenderString_29(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), str, dpi, (data == null) ? default(HandleRef) : data.GetCppThis(), textDims) != 0;
		}

		// Token: 0x0601451A RID: 83226
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFreeTypeTools_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601451B RID: 83227 RVA: 0x001CB9A4 File Offset: 0x001C9BA4
		public new static vtkFreeTypeTools SafeDownCast(vtkObjectBase o)
		{
			vtkFreeTypeTools vtkFreeTypeTools = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFreeTypeTools.vtkFreeTypeTools_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFreeTypeTools = (vtkFreeTypeTools)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFreeTypeTools.Register(null);
				}
			}
			return vtkFreeTypeTools;
		}

		// Token: 0x0601451C RID: 83228
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeTools_ScaleToPowerTwoOff_31(HandleRef pThis);

		/// <summary>
		/// Set whether the image produced should be scaled up to the nearest power of
		/// 2. This is normally required for older graphics cards where all textures
		/// must be a power of 2. This defaults to false, and should be fine on modern
		/// hardware.
		/// </summary>
		// Token: 0x0601451D RID: 83229 RVA: 0x001CBA23 File Offset: 0x001C9C23
		public virtual void ScaleToPowerTwoOff()
		{
			vtkFreeTypeTools.vtkFreeTypeTools_ScaleToPowerTwoOff_31(base.GetCppThis());
		}

		// Token: 0x0601451E RID: 83230
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeTools_ScaleToPowerTwoOn_32(HandleRef pThis);

		/// <summary>
		/// Set whether the image produced should be scaled up to the nearest power of
		/// 2. This is normally required for older graphics cards where all textures
		/// must be a power of 2. This defaults to false, and should be fine on modern
		/// hardware.
		/// </summary>
		// Token: 0x0601451F RID: 83231 RVA: 0x001CBA32 File Offset: 0x001C9C32
		public virtual void ScaleToPowerTwoOn()
		{
			vtkFreeTypeTools.vtkFreeTypeTools_ScaleToPowerTwoOn_32(base.GetCppThis());
		}

		// Token: 0x06014520 RID: 83232
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeTools_SetDebugTextures_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, images produced by RenderString will have a transparent grey
		/// background and set the justification anchor texel to bright yellow.
		/// </summary>
		// Token: 0x06014521 RID: 83233 RVA: 0x001CBA41 File Offset: 0x001C9C41
		public virtual void SetDebugTextures(bool _arg)
		{
			vtkFreeTypeTools.vtkFreeTypeTools_SetDebugTextures_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06014522 RID: 83234
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeTools_SetForceCompiledFonts_34(HandleRef pThis, byte _arg);

		/// <summary>
		/// Force use of the fonts compiled into VTK, ignoring any FontConfig or
		/// embedded fonts. Useful for generating test images consistently across
		/// platforms. This flag is on by default.
		/// </summary>
		// Token: 0x06014523 RID: 83235 RVA: 0x001CBA59 File Offset: 0x001C9C59
		public virtual void SetForceCompiledFonts(bool _arg)
		{
			vtkFreeTypeTools.vtkFreeTypeTools_SetForceCompiledFonts_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06014524 RID: 83236
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeTools_SetInstance_35(HandleRef instance);

		/// <summary>
		/// Supply a user defined instance. Call Delete() on the supplied
		/// instance after setting it to fix the reference count.
		/// </summary>
		// Token: 0x06014525 RID: 83237 RVA: 0x001CBA74 File Offset: 0x001C9C74
		public static void SetInstance(vtkFreeTypeTools instance)
		{
			vtkFreeTypeTools.vtkFreeTypeTools_SetInstance_35((instance == null) ? default(HandleRef) : instance.GetCppThis());
		}

		// Token: 0x06014526 RID: 83238
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeTools_SetMaximumNumberOfBytes_36(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
		/// bytes used by the cache. These settings can be changed as long as
		/// it is done prior to accessing any of the caches or the cache manager.
		/// </summary>
		// Token: 0x06014527 RID: 83239 RVA: 0x001CBA9D File Offset: 0x001C9C9D
		public virtual void SetMaximumNumberOfBytes(uint _arg)
		{
			vtkFreeTypeTools.vtkFreeTypeTools_SetMaximumNumberOfBytes_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06014528 RID: 83240
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeTools_SetMaximumNumberOfFaces_37(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
		/// bytes used by the cache. These settings can be changed as long as
		/// it is done prior to accessing any of the caches or the cache manager.
		/// </summary>
		// Token: 0x06014529 RID: 83241 RVA: 0x001CBAAD File Offset: 0x001C9CAD
		public virtual void SetMaximumNumberOfFaces(uint _arg)
		{
			vtkFreeTypeTools.vtkFreeTypeTools_SetMaximumNumberOfFaces_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0601452A RID: 83242
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeTools_SetMaximumNumberOfSizes_38(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
		/// bytes used by the cache. These settings can be changed as long as
		/// it is done prior to accessing any of the caches or the cache manager.
		/// </summary>
		// Token: 0x0601452B RID: 83243 RVA: 0x001CBABD File Offset: 0x001C9CBD
		public virtual void SetMaximumNumberOfSizes(uint _arg)
		{
			vtkFreeTypeTools.vtkFreeTypeTools_SetMaximumNumberOfSizes_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0601452C RID: 83244
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeTools_SetScaleToPowerTwo_39(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set whether the image produced should be scaled up to the nearest power of
		/// 2. This is normally required for older graphics cards where all textures
		/// must be a power of 2. This defaults to false, and should be fine on modern
		/// hardware.
		/// </summary>
		// Token: 0x0601452D RID: 83245 RVA: 0x001CBACD File Offset: 0x001C9CCD
		public virtual void SetScaleToPowerTwo(bool _arg)
		{
			vtkFreeTypeTools.vtkFreeTypeTools_SetScaleToPowerTwo_39(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601452E RID: 83246
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFreeTypeTools_StringToPath_40(HandleRef pThis, HandleRef tprop, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, int dpi, HandleRef path);

		/// <summary>
		/// Given a text property and a string, this function populates the vtkPath
		/// path with the outline of the rendered string. The origin of the path
		/// coordinates is aligned with the anchor point described by the text
		/// property's horizontal and vertical justification options.
		/// </summary>
		// Token: 0x0601452F RID: 83247 RVA: 0x001CBAE8 File Offset: 0x001C9CE8
		public bool StringToPath(vtkTextProperty tprop, string str, int dpi, vtkPath path)
		{
			return vtkFreeTypeTools.vtkFreeTypeTools_StringToPath_40(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), str, dpi, (path == null) ? default(HandleRef) : path.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001792 RID: 6034
		public new const string MRFullTypeName = "Kitware.VTK.vtkFreeTypeTools";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001793 RID: 6035
		public new static readonly string MRClassNameKey = "class vtkFreeTypeTools";
	}
}
