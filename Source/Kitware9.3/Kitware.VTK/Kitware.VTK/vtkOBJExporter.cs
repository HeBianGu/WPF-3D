using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOBJExporter
	/// </summary>
	/// <remarks>
	///    export a scene into Wavefront format.
	///
	/// vtkOBJExporter is a concrete subclass of vtkExporter that writes wavefront
	/// .OBJ files in ASCII form. It also writes out a mtl file that contains the
	/// material properties. The filenames are derived by appending the .obj and
	/// .mtl suffix onto the user specified FilePrefix.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExporter
	/// </seealso>
	// Token: 0x020001EC RID: 492
	public class vtkOBJExporter : vtkExporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005D9E RID: 23966 RVA: 0x00087BDF File Offset: 0x00085DDF
		static vtkOBJExporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOBJExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOBJExporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005D9F RID: 23967 RVA: 0x00087C07 File Offset: 0x00085E07
		public vtkOBJExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005DA0 RID: 23968
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DA1 RID: 23969 RVA: 0x00087C18 File Offset: 0x00085E18
		public new static vtkOBJExporter New()
		{
			vtkOBJExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJExporter.vtkOBJExporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBJExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DA2 RID: 23970 RVA: 0x00087C6C File Offset: 0x00085E6C
		public vtkOBJExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOBJExporter.vtkOBJExporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005DA3 RID: 23971 RVA: 0x00087CB0 File Offset: 0x00085EB0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005DA4 RID: 23972
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJExporter_GetFilePrefix_01(HandleRef pThis);

		/// <summary>
		/// Specify the prefix of the files to write out. The resulting filenames
		/// will have .obj and .mtl appended to them.
		/// </summary>
		// Token: 0x06005DA5 RID: 23973 RVA: 0x00087CBC File Offset: 0x00085EBC
		public virtual string GetFilePrefix()
		{
			string s = Marshal.PtrToStringAnsi(vtkOBJExporter.vtkOBJExporter_GetFilePrefix_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005DA6 RID: 23974
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJExporter_GetMTLFileComment_02(HandleRef pThis);

		/// <summary>
		/// Specify comment string that will be written to the mtl file header.
		/// </summary>
		// Token: 0x06005DA7 RID: 23975 RVA: 0x00087CF8 File Offset: 0x00085EF8
		public virtual string GetMTLFileComment()
		{
			string s = Marshal.PtrToStringAnsi(vtkOBJExporter.vtkOBJExporter_GetMTLFileComment_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005DA8 RID: 23976
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOBJExporter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DA9 RID: 23977 RVA: 0x00087D34 File Offset: 0x00085F34
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOBJExporter.vtkOBJExporter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06005DAA RID: 23978
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOBJExporter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DAB RID: 23979 RVA: 0x00087D54 File Offset: 0x00085F54
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOBJExporter.vtkOBJExporter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06005DAC RID: 23980
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJExporter_GetOBJFileComment_05(HandleRef pThis);

		/// <summary>
		/// Specify comment string that will be written to the obj file header.
		/// </summary>
		// Token: 0x06005DAD RID: 23981 RVA: 0x00087D70 File Offset: 0x00085F70
		public virtual string GetOBJFileComment()
		{
			string s = Marshal.PtrToStringAnsi(vtkOBJExporter.vtkOBJExporter_GetOBJFileComment_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005DAE RID: 23982
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOBJExporter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DAF RID: 23983 RVA: 0x00087DAC File Offset: 0x00085FAC
		public override int IsA(string type)
		{
			return vtkOBJExporter.vtkOBJExporter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06005DB0 RID: 23984
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOBJExporter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DB1 RID: 23985 RVA: 0x00087DCC File Offset: 0x00085FCC
		public new static int IsTypeOf(string type)
		{
			return vtkOBJExporter.vtkOBJExporter_IsTypeOf_07(type);
		}

		// Token: 0x06005DB2 RID: 23986
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJExporter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DB3 RID: 23987 RVA: 0x00087DE8 File Offset: 0x00085FE8
		public new vtkOBJExporter NewInstance()
		{
			vtkOBJExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJExporter.vtkOBJExporter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBJExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005DB4 RID: 23988
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJExporter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005DB5 RID: 23989 RVA: 0x00087E44 File Offset: 0x00086044
		public new static vtkOBJExporter SafeDownCast(vtkObjectBase o)
		{
			vtkOBJExporter vtkOBJExporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJExporter.vtkOBJExporter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOBJExporter = (vtkOBJExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOBJExporter.Register(null);
				}
			}
			return vtkOBJExporter;
		}

		// Token: 0x06005DB6 RID: 23990
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOBJExporter_SetFilePrefix_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the prefix of the files to write out. The resulting filenames
		/// will have .obj and .mtl appended to them.
		/// </summary>
		// Token: 0x06005DB7 RID: 23991 RVA: 0x00087EC3 File Offset: 0x000860C3
		public virtual void SetFilePrefix(string _arg)
		{
			vtkOBJExporter.vtkOBJExporter_SetFilePrefix_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06005DB8 RID: 23992
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOBJExporter_SetMTLFileComment_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify comment string that will be written to the mtl file header.
		/// </summary>
		// Token: 0x06005DB9 RID: 23993 RVA: 0x00087ED3 File Offset: 0x000860D3
		public virtual void SetMTLFileComment(string _arg)
		{
			vtkOBJExporter.vtkOBJExporter_SetMTLFileComment_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06005DBA RID: 23994
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOBJExporter_SetOBJFileComment_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify comment string that will be written to the obj file header.
		/// </summary>
		// Token: 0x06005DBB RID: 23995 RVA: 0x00087EE3 File Offset: 0x000860E3
		public virtual void SetOBJFileComment(string _arg)
		{
			vtkOBJExporter.vtkOBJExporter_SetOBJFileComment_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008A2 RID: 2210
		public new const string MRFullTypeName = "Kitware.VTK.vtkOBJExporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008A3 RID: 2211
		public new static readonly string MRClassNameKey = "class vtkOBJExporter";
	}
}
