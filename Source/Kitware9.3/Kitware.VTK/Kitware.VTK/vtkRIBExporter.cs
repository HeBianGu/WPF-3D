using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRIBExporter
	/// </summary>
	/// <remarks>
	///    export a scene into RenderMan RIB format.
	///
	/// vtkRIBExporter is a concrete subclass of vtkExporter that writes a
	/// Renderman .RIB files. The input specifies a vtkRenderWindow. All
	/// visible actors and lights will be included in the rib file. The
	/// following file naming conventions apply:
	///   rib file - FilePrefix.rib
	///   image file created by RenderMan - FilePrefix.tif
	///   texture files - TexturePrefix_0xADDR_MTIME.tif
	/// This object does NOT generate an image file. The user must run either
	/// RenderMan or a RenderMan emulator like Blue Moon Ray Tracer (BMRT).
	/// vtk properties are convert to Renderman shaders as follows:
	///   Normal property, no texture map - plastic.sl
	///   Normal property with texture map - txtplastic.sl
	/// These two shaders must be compiled by the rendering package being
	/// used.  vtkRIBExporter also supports custom shaders. The shaders are
	/// written using the Renderman Shading Language. See "The Renderman
	/// Companion", ISBN 0-201-50868, 1989 for details on writing shaders.
	/// vtkRIBProperty specifies the declarations and parameter settings for
	/// custom shaders.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExporter vtkRIBProperty vtkRIBLight
	/// </seealso>
	// Token: 0x020001EF RID: 495
	public class vtkRIBExporter : vtkExporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005DE8 RID: 24040 RVA: 0x000883EB File Offset: 0x000865EB
		static vtkRIBExporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRIBExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRIBExporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005DE9 RID: 24041 RVA: 0x00088413 File Offset: 0x00086613
		public vtkRIBExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005DEA RID: 24042
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DEB RID: 24043 RVA: 0x00088424 File Offset: 0x00086624
		public new static vtkRIBExporter New()
		{
			vtkRIBExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRIBExporter.vtkRIBExporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRIBExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DEC RID: 24044 RVA: 0x00088478 File Offset: 0x00086678
		public vtkRIBExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRIBExporter.vtkRIBExporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005DED RID: 24045 RVA: 0x000884BC File Offset: 0x000866BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005DEE RID: 24046
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBExporter_BackgroundOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the background flag. Default is 0 (off).
		/// If set, the rib file will contain an
		/// image shader that will use the renderer window's background
		/// color. Normally, RenderMan does generate backgrounds. Backgrounds are
		/// composited into the scene with the tiffcomp program that comes with
		/// Pixar's RenderMan Toolkit.  In fact, Pixar's Renderman will accept an
		/// image shader but only sets the alpha of the background. Images created
		/// this way will still have a black background but contain an alpha of 1
		/// at all pixels and CANNOT be subsequently composited with other images
		/// using tiffcomp.  However, other RenderMan compliant renderers like
		/// Blue Moon Ray Tracing (BMRT) do allow image shaders and properly set
		/// the background color. If this sounds too confusing, use the following
		/// rules: If you are using Pixar's Renderman, leave the Background
		/// off. Otherwise, try setting BackGroundOn and see if you get the
		/// desired results.
		/// </summary>
		// Token: 0x06005DEF RID: 24047 RVA: 0x000884C7 File Offset: 0x000866C7
		public virtual void BackgroundOff()
		{
			vtkRIBExporter.vtkRIBExporter_BackgroundOff_01(base.GetCppThis());
		}

		// Token: 0x06005DF0 RID: 24048
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBExporter_BackgroundOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the background flag. Default is 0 (off).
		/// If set, the rib file will contain an
		/// image shader that will use the renderer window's background
		/// color. Normally, RenderMan does generate backgrounds. Backgrounds are
		/// composited into the scene with the tiffcomp program that comes with
		/// Pixar's RenderMan Toolkit.  In fact, Pixar's Renderman will accept an
		/// image shader but only sets the alpha of the background. Images created
		/// this way will still have a black background but contain an alpha of 1
		/// at all pixels and CANNOT be subsequently composited with other images
		/// using tiffcomp.  However, other RenderMan compliant renderers like
		/// Blue Moon Ray Tracing (BMRT) do allow image shaders and properly set
		/// the background color. If this sounds too confusing, use the following
		/// rules: If you are using Pixar's Renderman, leave the Background
		/// off. Otherwise, try setting BackGroundOn and see if you get the
		/// desired results.
		/// </summary>
		// Token: 0x06005DF1 RID: 24049 RVA: 0x000884D6 File Offset: 0x000866D6
		public virtual void BackgroundOn()
		{
			vtkRIBExporter.vtkRIBExporter_BackgroundOn_02(base.GetCppThis());
		}

		// Token: 0x06005DF2 RID: 24050
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBExporter_ExportArraysOff_03(HandleRef pThis);

		/// <summary>
		/// Set or get the ExportArrays. If ExportArrays is set, then
		/// all point data, field data, and cell data arrays will get
		/// exported together with polygons. Default is Off (0).
		/// </summary>
		// Token: 0x06005DF3 RID: 24051 RVA: 0x000884E5 File Offset: 0x000866E5
		public virtual void ExportArraysOff()
		{
			vtkRIBExporter.vtkRIBExporter_ExportArraysOff_03(base.GetCppThis());
		}

		// Token: 0x06005DF4 RID: 24052
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBExporter_ExportArraysOn_04(HandleRef pThis);

		/// <summary>
		/// Set or get the ExportArrays. If ExportArrays is set, then
		/// all point data, field data, and cell data arrays will get
		/// exported together with polygons. Default is Off (0).
		/// </summary>
		// Token: 0x06005DF5 RID: 24053 RVA: 0x000884F4 File Offset: 0x000866F4
		public virtual void ExportArraysOn()
		{
			vtkRIBExporter.vtkRIBExporter_ExportArraysOn_04(base.GetCppThis());
		}

		// Token: 0x06005DF6 RID: 24054
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRIBExporter_GetBackground_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the background flag. Default is 0 (off).
		/// If set, the rib file will contain an
		/// image shader that will use the renderer window's background
		/// color. Normally, RenderMan does generate backgrounds. Backgrounds are
		/// composited into the scene with the tiffcomp program that comes with
		/// Pixar's RenderMan Toolkit.  In fact, Pixar's Renderman will accept an
		/// image shader but only sets the alpha of the background. Images created
		/// this way will still have a black background but contain an alpha of 1
		/// at all pixels and CANNOT be subsequently composited with other images
		/// using tiffcomp.  However, other RenderMan compliant renderers like
		/// Blue Moon Ray Tracing (BMRT) do allow image shaders and properly set
		/// the background color. If this sounds too confusing, use the following
		/// rules: If you are using Pixar's Renderman, leave the Background
		/// off. Otherwise, try setting BackGroundOn and see if you get the
		/// desired results.
		/// </summary>
		// Token: 0x06005DF7 RID: 24055 RVA: 0x00088504 File Offset: 0x00086704
		public virtual int GetBackground()
		{
			return vtkRIBExporter.vtkRIBExporter_GetBackground_05(base.GetCppThis());
		}

		// Token: 0x06005DF8 RID: 24056
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRIBExporter_GetExportArrays_06(HandleRef pThis);

		/// <summary>
		/// Set or get the ExportArrays. If ExportArrays is set, then
		/// all point data, field data, and cell data arrays will get
		/// exported together with polygons. Default is Off (0).
		/// </summary>
		// Token: 0x06005DF9 RID: 24057 RVA: 0x00088524 File Offset: 0x00086724
		public virtual int GetExportArrays()
		{
			return vtkRIBExporter.vtkRIBExporter_GetExportArrays_06(base.GetCppThis());
		}

		// Token: 0x06005DFA RID: 24058
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRIBExporter_GetExportArraysMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Set or get the ExportArrays. If ExportArrays is set, then
		/// all point data, field data, and cell data arrays will get
		/// exported together with polygons. Default is Off (0).
		/// </summary>
		// Token: 0x06005DFB RID: 24059 RVA: 0x00088544 File Offset: 0x00086744
		public virtual int GetExportArraysMaxValue()
		{
			return vtkRIBExporter.vtkRIBExporter_GetExportArraysMaxValue_07(base.GetCppThis());
		}

		// Token: 0x06005DFC RID: 24060
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRIBExporter_GetExportArraysMinValue_08(HandleRef pThis);

		/// <summary>
		/// Set or get the ExportArrays. If ExportArrays is set, then
		/// all point data, field data, and cell data arrays will get
		/// exported together with polygons. Default is Off (0).
		/// </summary>
		// Token: 0x06005DFD RID: 24061 RVA: 0x00088564 File Offset: 0x00086764
		public virtual int GetExportArraysMinValue()
		{
			return vtkRIBExporter.vtkRIBExporter_GetExportArraysMinValue_08(base.GetCppThis());
		}

		// Token: 0x06005DFE RID: 24062
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBExporter_GetFilePrefix_09(HandleRef pThis);

		/// <summary>
		/// Specify the prefix of the files to write out. The resulting file names
		/// will have .rib appended to them.
		/// </summary>
		// Token: 0x06005DFF RID: 24063 RVA: 0x00088584 File Offset: 0x00086784
		public virtual string GetFilePrefix()
		{
			string s = Marshal.PtrToStringAnsi(vtkRIBExporter.vtkRIBExporter_GetFilePrefix_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005E00 RID: 24064
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRIBExporter_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E01 RID: 24065 RVA: 0x000885C0 File Offset: 0x000867C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRIBExporter.vtkRIBExporter_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06005E02 RID: 24066
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRIBExporter_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E03 RID: 24067 RVA: 0x000885E0 File Offset: 0x000867E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRIBExporter.vtkRIBExporter_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06005E04 RID: 24068
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBExporter_GetPixelSamples_12(HandleRef pThis);

		/// <summary>
		/// Specify the sampling rate for the rendering. Default is 2 2.
		/// </summary>
		// Token: 0x06005E05 RID: 24069 RVA: 0x000885FC File Offset: 0x000867FC
		public virtual int[] GetPixelSamples()
		{
			IntPtr intPtr = vtkRIBExporter.vtkRIBExporter_GetPixelSamples_12(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06005E06 RID: 24070
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBExporter_GetPixelSamples_13(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the sampling rate for the rendering. Default is 2 2.
		/// </summary>
		// Token: 0x06005E07 RID: 24071 RVA: 0x00088644 File Offset: 0x00086844
		public virtual void GetPixelSamples(IntPtr data)
		{
			vtkRIBExporter.vtkRIBExporter_GetPixelSamples_13(base.GetCppThis(), data);
		}

		// Token: 0x06005E08 RID: 24072
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBExporter_GetSize_14(HandleRef pThis);

		/// <summary>
		/// Specify the size of the image for RenderMan. If none is specified, the
		/// size of the render window will be used.
		/// </summary>
		// Token: 0x06005E09 RID: 24073 RVA: 0x00088654 File Offset: 0x00086854
		public virtual int[] GetSize()
		{
			IntPtr intPtr = vtkRIBExporter.vtkRIBExporter_GetSize_14(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06005E0A RID: 24074
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBExporter_GetSize_15(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the size of the image for RenderMan. If none is specified, the
		/// size of the render window will be used.
		/// </summary>
		// Token: 0x06005E0B RID: 24075 RVA: 0x0008869C File Offset: 0x0008689C
		public virtual void GetSize(IntPtr data)
		{
			vtkRIBExporter.vtkRIBExporter_GetSize_15(base.GetCppThis(), data);
		}

		// Token: 0x06005E0C RID: 24076
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBExporter_GetTexturePrefix_16(HandleRef pThis);

		/// <summary>
		/// Specify the prefix of any generated texture files.
		/// </summary>
		// Token: 0x06005E0D RID: 24077 RVA: 0x000886AC File Offset: 0x000868AC
		public virtual string GetTexturePrefix()
		{
			string s = Marshal.PtrToStringAnsi(vtkRIBExporter.vtkRIBExporter_GetTexturePrefix_16(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005E0E RID: 24078
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRIBExporter_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E0F RID: 24079 RVA: 0x000886E8 File Offset: 0x000868E8
		public override int IsA(string type)
		{
			return vtkRIBExporter.vtkRIBExporter_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06005E10 RID: 24080
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRIBExporter_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E11 RID: 24081 RVA: 0x00088708 File Offset: 0x00086908
		public new static int IsTypeOf(string type)
		{
			return vtkRIBExporter.vtkRIBExporter_IsTypeOf_18(type);
		}

		// Token: 0x06005E12 RID: 24082
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBExporter_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E13 RID: 24083 RVA: 0x00088724 File Offset: 0x00086924
		public new vtkRIBExporter NewInstance()
		{
			vtkRIBExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRIBExporter.vtkRIBExporter_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRIBExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005E14 RID: 24084
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBExporter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E15 RID: 24085 RVA: 0x00088780 File Offset: 0x00086980
		public new static vtkRIBExporter SafeDownCast(vtkObjectBase o)
		{
			vtkRIBExporter vtkRIBExporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRIBExporter.vtkRIBExporter_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRIBExporter = (vtkRIBExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRIBExporter.Register(null);
				}
			}
			return vtkRIBExporter;
		}

		// Token: 0x06005E16 RID: 24086
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBExporter_SetBackground_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the background flag. Default is 0 (off).
		/// If set, the rib file will contain an
		/// image shader that will use the renderer window's background
		/// color. Normally, RenderMan does generate backgrounds. Backgrounds are
		/// composited into the scene with the tiffcomp program that comes with
		/// Pixar's RenderMan Toolkit.  In fact, Pixar's Renderman will accept an
		/// image shader but only sets the alpha of the background. Images created
		/// this way will still have a black background but contain an alpha of 1
		/// at all pixels and CANNOT be subsequently composited with other images
		/// using tiffcomp.  However, other RenderMan compliant renderers like
		/// Blue Moon Ray Tracing (BMRT) do allow image shaders and properly set
		/// the background color. If this sounds too confusing, use the following
		/// rules: If you are using Pixar's Renderman, leave the Background
		/// off. Otherwise, try setting BackGroundOn and see if you get the
		/// desired results.
		/// </summary>
		// Token: 0x06005E17 RID: 24087 RVA: 0x000887FF File Offset: 0x000869FF
		public virtual void SetBackground(int _arg)
		{
			vtkRIBExporter.vtkRIBExporter_SetBackground_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06005E18 RID: 24088
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBExporter_SetExportArrays_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Set or get the ExportArrays. If ExportArrays is set, then
		/// all point data, field data, and cell data arrays will get
		/// exported together with polygons. Default is Off (0).
		/// </summary>
		// Token: 0x06005E19 RID: 24089 RVA: 0x0008880F File Offset: 0x00086A0F
		public virtual void SetExportArrays(int _arg)
		{
			vtkRIBExporter.vtkRIBExporter_SetExportArrays_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06005E1A RID: 24090
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBExporter_SetFilePrefix_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the prefix of the files to write out. The resulting file names
		/// will have .rib appended to them.
		/// </summary>
		// Token: 0x06005E1B RID: 24091 RVA: 0x0008881F File Offset: 0x00086A1F
		public virtual void SetFilePrefix(string _arg)
		{
			vtkRIBExporter.vtkRIBExporter_SetFilePrefix_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06005E1C RID: 24092
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBExporter_SetPixelSamples_25(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Specify the sampling rate for the rendering. Default is 2 2.
		/// </summary>
		// Token: 0x06005E1D RID: 24093 RVA: 0x0008882F File Offset: 0x00086A2F
		public virtual void SetPixelSamples(int _arg1, int _arg2)
		{
			vtkRIBExporter.vtkRIBExporter_SetPixelSamples_25(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06005E1E RID: 24094
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBExporter_SetPixelSamples_26(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the sampling rate for the rendering. Default is 2 2.
		/// </summary>
		// Token: 0x06005E1F RID: 24095 RVA: 0x00088840 File Offset: 0x00086A40
		public void SetPixelSamples(IntPtr _arg)
		{
			vtkRIBExporter.vtkRIBExporter_SetPixelSamples_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06005E20 RID: 24096
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBExporter_SetSize_27(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Specify the size of the image for RenderMan. If none is specified, the
		/// size of the render window will be used.
		/// </summary>
		// Token: 0x06005E21 RID: 24097 RVA: 0x00088850 File Offset: 0x00086A50
		public virtual void SetSize(int _arg1, int _arg2)
		{
			vtkRIBExporter.vtkRIBExporter_SetSize_27(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06005E22 RID: 24098
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBExporter_SetSize_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the size of the image for RenderMan. If none is specified, the
		/// size of the render window will be used.
		/// </summary>
		// Token: 0x06005E23 RID: 24099 RVA: 0x00088861 File Offset: 0x00086A61
		public void SetSize(IntPtr _arg)
		{
			vtkRIBExporter.vtkRIBExporter_SetSize_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06005E24 RID: 24100
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBExporter_SetTexturePrefix_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the prefix of any generated texture files.
		/// </summary>
		// Token: 0x06005E25 RID: 24101 RVA: 0x00088871 File Offset: 0x00086A71
		public virtual void SetTexturePrefix(string _arg)
		{
			vtkRIBExporter.vtkRIBExporter_SetTexturePrefix_29(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008A8 RID: 2216
		public new const string MRFullTypeName = "Kitware.VTK.vtkRIBExporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008A9 RID: 2217
		public new static readonly string MRClassNameKey = "class vtkRIBExporter";
	}
}
