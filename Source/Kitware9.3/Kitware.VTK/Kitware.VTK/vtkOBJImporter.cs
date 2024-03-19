using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOBJImporter
	/// </summary>
	/// <remarks>
	///    import from .obj wavefront files
	///
	///                        from Wavefront .obj &amp; associated .mtl files.
	/// @par Thanks - Peter Karasev (Georgia Tech / Keysight Technologies Inc),:
	///                   Allen Tannenbaum (SUNY Stonybrook), Patricio Vela (Georgia Tech)
	/// </remarks>
	/// <seealso>
	///
	///  vtkImporter
	/// </seealso>
	// Token: 0x02000188 RID: 392
	public class vtkOBJImporter : vtkImporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004B37 RID: 19255 RVA: 0x0006D847 File Offset: 0x0006BA47
		static vtkOBJImporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOBJImporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOBJImporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004B38 RID: 19256 RVA: 0x0006D86F File Offset: 0x0006BA6F
		public vtkOBJImporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004B39 RID: 19257
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJImporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B3A RID: 19258 RVA: 0x0006D880 File Offset: 0x0006BA80
		public new static vtkOBJImporter New()
		{
			vtkOBJImporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJImporter.vtkOBJImporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBJImporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B3B RID: 19259 RVA: 0x0006D8D4 File Offset: 0x0006BAD4
		public vtkOBJImporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOBJImporter.vtkOBJImporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004B3C RID: 19260 RVA: 0x0006D918 File Offset: 0x0006BB18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004B3D RID: 19261
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJImporter_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Specify the name of the file to read.
		/// </summary>
		// Token: 0x06004B3E RID: 19262 RVA: 0x0006D924 File Offset: 0x0006BB24
		public string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkOBJImporter.vtkOBJImporter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004B3F RID: 19263
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJImporter_GetFileNameMTL_02(HandleRef pThis);

		/// <summary>
		/// Specify the name of the file to read.
		/// </summary>
		// Token: 0x06004B40 RID: 19264 RVA: 0x0006D960 File Offset: 0x0006BB60
		public string GetFileNameMTL()
		{
			string s = Marshal.PtrToStringAnsi(vtkOBJImporter.vtkOBJImporter_GetFileNameMTL_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004B41 RID: 19265
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOBJImporter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B42 RID: 19266 RVA: 0x0006D99C File Offset: 0x0006BB9C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOBJImporter.vtkOBJImporter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06004B43 RID: 19267
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOBJImporter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B44 RID: 19268 RVA: 0x0006D9BC File Offset: 0x0006BBBC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOBJImporter.vtkOBJImporter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06004B45 RID: 19269
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkOBJImporter_GetOutputDescription_05(HandleRef pThis, int idx);

		/// <summary>
		/// Get a string describing an output
		/// </summary>
		// Token: 0x06004B46 RID: 19270 RVA: 0x0006D9D8 File Offset: 0x0006BBD8
		public string GetOutputDescription(int idx)
		{
			return vtkOBJImporter.vtkOBJImporter_GetOutputDescription_05(base.GetCppThis(), idx);
		}

		// Token: 0x06004B47 RID: 19271
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkOBJImporter_GetOutputsDescription_06(HandleRef pThis);

		/// <summary>
		/// Get a printable string describing all outputs
		/// </summary>
		// Token: 0x06004B48 RID: 19272 RVA: 0x0006D9F8 File Offset: 0x0006BBF8
		public override string GetOutputsDescription()
		{
			return vtkOBJImporter.vtkOBJImporter_GetOutputsDescription_06(base.GetCppThis());
		}

		// Token: 0x06004B49 RID: 19273
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJImporter_GetTexturePath_07(HandleRef pThis);

		/// <summary>
		/// Specify the name of the file to read.
		/// </summary>
		// Token: 0x06004B4A RID: 19274 RVA: 0x0006DA18 File Offset: 0x0006BC18
		public string GetTexturePath()
		{
			string s = Marshal.PtrToStringAnsi(vtkOBJImporter.vtkOBJImporter_GetTexturePath_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004B4B RID: 19275
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOBJImporter_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B4C RID: 19276 RVA: 0x0006DA54 File Offset: 0x0006BC54
		public override int IsA(string type)
		{
			return vtkOBJImporter.vtkOBJImporter_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06004B4D RID: 19277
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOBJImporter_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B4E RID: 19278 RVA: 0x0006DA74 File Offset: 0x0006BC74
		public new static int IsTypeOf(string type)
		{
			return vtkOBJImporter.vtkOBJImporter_IsTypeOf_09(type);
		}

		// Token: 0x06004B4F RID: 19279
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJImporter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B50 RID: 19280 RVA: 0x0006DA90 File Offset: 0x0006BC90
		public new vtkOBJImporter NewInstance()
		{
			vtkOBJImporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJImporter.vtkOBJImporter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBJImporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004B51 RID: 19281
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJImporter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B52 RID: 19282 RVA: 0x0006DAEC File Offset: 0x0006BCEC
		public new static vtkOBJImporter SafeDownCast(vtkObjectBase o)
		{
			vtkOBJImporter vtkOBJImporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJImporter.vtkOBJImporter_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOBJImporter = (vtkOBJImporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOBJImporter.Register(null);
				}
			}
			return vtkOBJImporter;
		}

		// Token: 0x06004B53 RID: 19283
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOBJImporter_SetFileName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Specify the name of the file to read.
		/// </summary>
		// Token: 0x06004B54 RID: 19284 RVA: 0x0006DB6B File Offset: 0x0006BD6B
		public void SetFileName(string arg)
		{
			vtkOBJImporter.vtkOBJImporter_SetFileName_13(base.GetCppThis(), arg);
		}

		// Token: 0x06004B55 RID: 19285
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOBJImporter_SetFileNameMTL_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Specify the name of the file to read.
		/// </summary>
		// Token: 0x06004B56 RID: 19286 RVA: 0x0006DB7B File Offset: 0x0006BD7B
		public void SetFileNameMTL(string arg)
		{
			vtkOBJImporter.vtkOBJImporter_SetFileNameMTL_14(base.GetCppThis(), arg);
		}

		// Token: 0x06004B57 RID: 19287
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOBJImporter_SetTexturePath_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string path);

		/// <summary>
		/// Specify the name of the file to read.
		/// </summary>
		// Token: 0x06004B58 RID: 19288 RVA: 0x0006DB8B File Offset: 0x0006BD8B
		public void SetTexturePath(string path)
		{
			vtkOBJImporter.vtkOBJImporter_SetTexturePath_15(base.GetCppThis(), path);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000761 RID: 1889
		public new const string MRFullTypeName = "Kitware.VTK.vtkOBJImporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000762 RID: 1890
		public new static readonly string MRClassNameKey = "class vtkOBJImporter";
	}
}
