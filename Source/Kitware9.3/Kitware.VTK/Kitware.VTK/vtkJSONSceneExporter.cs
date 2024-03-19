using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkJSONSceneExporter
	/// </summary>
	/// <remarks>
	///    Export the content of a vtkRenderWindow into a directory with
	///          a JSON meta file describing the scene along with the http datasets
	///
	/// @warning
	/// This writer assume LittleEndian by default. Additional work should be done to properly
	/// handle endianness.
	/// </remarks>
	// Token: 0x020001EB RID: 491
	public class vtkJSONSceneExporter : vtkExporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005D6C RID: 23916 RVA: 0x000877AE File Offset: 0x000859AE
		static vtkJSONSceneExporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkJSONSceneExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkJSONSceneExporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005D6D RID: 23917 RVA: 0x000877D6 File Offset: 0x000859D6
		public vtkJSONSceneExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005D6E RID: 23918
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONSceneExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D6F RID: 23919 RVA: 0x000877E4 File Offset: 0x000859E4
		public new static vtkJSONSceneExporter New()
		{
			vtkJSONSceneExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONSceneExporter.vtkJSONSceneExporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJSONSceneExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D70 RID: 23920 RVA: 0x00087838 File Offset: 0x00085A38
		public vtkJSONSceneExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkJSONSceneExporter.vtkJSONSceneExporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005D71 RID: 23921 RVA: 0x0008787C File Offset: 0x00085A7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005D72 RID: 23922
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONSceneExporter_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Specify file name of vtk data file to write.
		/// This correspond to the root directory of the data to write.
		/// </summary>
		// Token: 0x06005D73 RID: 23923 RVA: 0x00087888 File Offset: 0x00085A88
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkJSONSceneExporter.vtkJSONSceneExporter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005D74 RID: 23924
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJSONSceneExporter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D75 RID: 23925 RVA: 0x000878C4 File Offset: 0x00085AC4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkJSONSceneExporter.vtkJSONSceneExporter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06005D76 RID: 23926
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJSONSceneExporter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D77 RID: 23927 RVA: 0x000878E4 File Offset: 0x00085AE4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkJSONSceneExporter.vtkJSONSceneExporter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06005D78 RID: 23928
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkJSONSceneExporter_GetPolyLODsBaseSize_04(HandleRef pThis);

		/// <summary>
		/// The base size to be used for poly LODs. The poly LODs will stop
		/// being written out when one is smaller than this size, or if the
		/// difference in the sizes of the two most recent LODs is less
		/// than 5%.
		/// Default is 100 KB. Units are in bytes.
		/// </summary>
		// Token: 0x06005D79 RID: 23929 RVA: 0x00087900 File Offset: 0x00085B00
		public virtual ulong GetPolyLODsBaseSize()
		{
			return vtkJSONSceneExporter.vtkJSONSceneExporter_GetPolyLODsBaseSize_04(base.GetCppThis());
		}

		// Token: 0x06005D7A RID: 23930
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONSceneExporter_GetPolyLODsBaseUrl_05(HandleRef pThis);

		/// <summary>
		/// The base URL to be used for poly LODs.
		/// Default is nullptr.
		/// </summary>
		// Token: 0x06005D7B RID: 23931 RVA: 0x00087920 File Offset: 0x00085B20
		public virtual string GetPolyLODsBaseUrl()
		{
			string s = Marshal.PtrToStringAnsi(vtkJSONSceneExporter.vtkJSONSceneExporter_GetPolyLODsBaseUrl_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005D7C RID: 23932
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkJSONSceneExporter_GetTextureLODsBaseSize_06(HandleRef pThis);

		/// <summary>
		/// The base size to be used for texture LODs. The texture LODs will
		/// stop being written out when one is smaller than this size.
		/// Default is 100 KB. Units are in bytes.
		/// </summary>
		// Token: 0x06005D7D RID: 23933 RVA: 0x0008795C File Offset: 0x00085B5C
		public virtual ulong GetTextureLODsBaseSize()
		{
			return vtkJSONSceneExporter.vtkJSONSceneExporter_GetTextureLODsBaseSize_06(base.GetCppThis());
		}

		// Token: 0x06005D7E RID: 23934
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONSceneExporter_GetTextureLODsBaseUrl_07(HandleRef pThis);

		/// <summary>
		/// The base URL to be used for texture LODs.
		/// Default is nullptr.
		/// </summary>
		// Token: 0x06005D7F RID: 23935 RVA: 0x0008797C File Offset: 0x00085B7C
		public virtual string GetTextureLODsBaseUrl()
		{
			string s = Marshal.PtrToStringAnsi(vtkJSONSceneExporter.vtkJSONSceneExporter_GetTextureLODsBaseUrl_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005D80 RID: 23936
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkJSONSceneExporter_GetWritePolyLODs_08(HandleRef pThis);

		/// <summary>
		/// Whether or not to write poly LODs.
		/// This will write out the poly LOD sources in a series of decreasing
		/// resolution data sets, which are intended to be uploaded to the
		/// web. vtkQuadricCluster is used to decrease the resolution of the
		/// poly data. Each will be approximately 1/4 the size of the previous
		/// one (unless certain errors occur, and then the defaults for quadric
		/// clustering will be used, which will produce an unknown size). The
		/// files will stop being written out when one is smaller than the
		/// PolyLODsBaseSize, or if the difference in the sizes of the two
		/// most recent LODs is less than 5%. The smallest LOD will be written
		/// into the vtkjs file, rather than with the rest of the LODs.
		/// Default is false.
		/// </summary>
		// Token: 0x06005D81 RID: 23937 RVA: 0x000879B8 File Offset: 0x00085BB8
		public virtual bool GetWritePolyLODs()
		{
			return vtkJSONSceneExporter.vtkJSONSceneExporter_GetWritePolyLODs_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06005D82 RID: 23938
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkJSONSceneExporter_GetWriteTextureLODs_09(HandleRef pThis);

		/// <summary>
		/// Whether or not to write texture LODs.
		/// This will write out the textures in a series of decreasing
		/// resolution JPEG files, which are intended to be uploaded to the
		/// web. Each file will be 1/4 the size of the previous one. The files
		/// will stop being written out when one is smaller than the
		/// TextureLODsBaseSize.
		/// Default is false.
		/// </summary>
		// Token: 0x06005D83 RID: 23939 RVA: 0x000879E0 File Offset: 0x00085BE0
		public virtual bool GetWriteTextureLODs()
		{
			return vtkJSONSceneExporter.vtkJSONSceneExporter_GetWriteTextureLODs_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06005D84 RID: 23940
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkJSONSceneExporter_GetWriteTextures_10(HandleRef pThis);

		/// <summary>
		/// Whether or not to write textures.
		/// Textures will be written in JPEG format.
		/// Default is false.
		/// </summary>
		// Token: 0x06005D85 RID: 23941 RVA: 0x00087A08 File Offset: 0x00085C08
		public virtual bool GetWriteTextures()
		{
			return vtkJSONSceneExporter.vtkJSONSceneExporter_GetWriteTextures_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06005D86 RID: 23942
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJSONSceneExporter_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D87 RID: 23943 RVA: 0x00087A30 File Offset: 0x00085C30
		public override int IsA(string type)
		{
			return vtkJSONSceneExporter.vtkJSONSceneExporter_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06005D88 RID: 23944
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJSONSceneExporter_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D89 RID: 23945 RVA: 0x00087A50 File Offset: 0x00085C50
		public new static int IsTypeOf(string type)
		{
			return vtkJSONSceneExporter.vtkJSONSceneExporter_IsTypeOf_12(type);
		}

		// Token: 0x06005D8A RID: 23946
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONSceneExporter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D8B RID: 23947 RVA: 0x00087A6C File Offset: 0x00085C6C
		public new vtkJSONSceneExporter NewInstance()
		{
			vtkJSONSceneExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONSceneExporter.vtkJSONSceneExporter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJSONSceneExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005D8C RID: 23948
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONSceneExporter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005D8D RID: 23949 RVA: 0x00087AC8 File Offset: 0x00085CC8
		public new static vtkJSONSceneExporter SafeDownCast(vtkObjectBase o)
		{
			vtkJSONSceneExporter vtkJSONSceneExporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONSceneExporter.vtkJSONSceneExporter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkJSONSceneExporter = (vtkJSONSceneExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkJSONSceneExporter.Register(null);
				}
			}
			return vtkJSONSceneExporter;
		}

		// Token: 0x06005D8E RID: 23950
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONSceneExporter_SetFileName_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of vtk data file to write.
		/// This correspond to the root directory of the data to write.
		/// </summary>
		// Token: 0x06005D8F RID: 23951 RVA: 0x00087B47 File Offset: 0x00085D47
		public virtual void SetFileName(string _arg)
		{
			vtkJSONSceneExporter.vtkJSONSceneExporter_SetFileName_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06005D90 RID: 23952
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONSceneExporter_SetPolyLODsBaseSize_17(HandleRef pThis, ulong _arg);

		/// <summary>
		/// The base size to be used for poly LODs. The poly LODs will stop
		/// being written out when one is smaller than this size, or if the
		/// difference in the sizes of the two most recent LODs is less
		/// than 5%.
		/// Default is 100 KB. Units are in bytes.
		/// </summary>
		// Token: 0x06005D91 RID: 23953 RVA: 0x00087B57 File Offset: 0x00085D57
		public virtual void SetPolyLODsBaseSize(ulong _arg)
		{
			vtkJSONSceneExporter.vtkJSONSceneExporter_SetPolyLODsBaseSize_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06005D92 RID: 23954
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONSceneExporter_SetPolyLODsBaseUrl_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The base URL to be used for poly LODs.
		/// Default is nullptr.
		/// </summary>
		// Token: 0x06005D93 RID: 23955 RVA: 0x00087B67 File Offset: 0x00085D67
		public virtual void SetPolyLODsBaseUrl(string _arg)
		{
			vtkJSONSceneExporter.vtkJSONSceneExporter_SetPolyLODsBaseUrl_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06005D94 RID: 23956
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONSceneExporter_SetTextureLODsBaseSize_19(HandleRef pThis, ulong _arg);

		/// <summary>
		/// The base size to be used for texture LODs. The texture LODs will
		/// stop being written out when one is smaller than this size.
		/// Default is 100 KB. Units are in bytes.
		/// </summary>
		// Token: 0x06005D95 RID: 23957 RVA: 0x00087B77 File Offset: 0x00085D77
		public virtual void SetTextureLODsBaseSize(ulong _arg)
		{
			vtkJSONSceneExporter.vtkJSONSceneExporter_SetTextureLODsBaseSize_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06005D96 RID: 23958
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONSceneExporter_SetTextureLODsBaseUrl_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The base URL to be used for texture LODs.
		/// Default is nullptr.
		/// </summary>
		// Token: 0x06005D97 RID: 23959 RVA: 0x00087B87 File Offset: 0x00085D87
		public virtual void SetTextureLODsBaseUrl(string _arg)
		{
			vtkJSONSceneExporter.vtkJSONSceneExporter_SetTextureLODsBaseUrl_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06005D98 RID: 23960
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONSceneExporter_SetWritePolyLODs_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether or not to write poly LODs.
		/// This will write out the poly LOD sources in a series of decreasing
		/// resolution data sets, which are intended to be uploaded to the
		/// web. vtkQuadricCluster is used to decrease the resolution of the
		/// poly data. Each will be approximately 1/4 the size of the previous
		/// one (unless certain errors occur, and then the defaults for quadric
		/// clustering will be used, which will produce an unknown size). The
		/// files will stop being written out when one is smaller than the
		/// PolyLODsBaseSize, or if the difference in the sizes of the two
		/// most recent LODs is less than 5%. The smallest LOD will be written
		/// into the vtkjs file, rather than with the rest of the LODs.
		/// Default is false.
		/// </summary>
		// Token: 0x06005D99 RID: 23961 RVA: 0x00087B97 File Offset: 0x00085D97
		public virtual void SetWritePolyLODs(bool _arg)
		{
			vtkJSONSceneExporter.vtkJSONSceneExporter_SetWritePolyLODs_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005D9A RID: 23962
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONSceneExporter_SetWriteTextureLODs_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether or not to write texture LODs.
		/// This will write out the textures in a series of decreasing
		/// resolution JPEG files, which are intended to be uploaded to the
		/// web. Each file will be 1/4 the size of the previous one. The files
		/// will stop being written out when one is smaller than the
		/// TextureLODsBaseSize.
		/// Default is false.
		/// </summary>
		// Token: 0x06005D9B RID: 23963 RVA: 0x00087BAF File Offset: 0x00085DAF
		public virtual void SetWriteTextureLODs(bool _arg)
		{
			vtkJSONSceneExporter.vtkJSONSceneExporter_SetWriteTextureLODs_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005D9C RID: 23964
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONSceneExporter_SetWriteTextures_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether or not to write textures.
		/// Textures will be written in JPEG format.
		/// Default is false.
		/// </summary>
		// Token: 0x06005D9D RID: 23965 RVA: 0x00087BC7 File Offset: 0x00085DC7
		public virtual void SetWriteTextures(bool _arg)
		{
			vtkJSONSceneExporter.vtkJSONSceneExporter_SetWriteTextures_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008A0 RID: 2208
		public new const string MRFullTypeName = "Kitware.VTK.vtkJSONSceneExporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008A1 RID: 2209
		public new static readonly string MRClassNameKey = "class vtkJSONSceneExporter";
	}
}
