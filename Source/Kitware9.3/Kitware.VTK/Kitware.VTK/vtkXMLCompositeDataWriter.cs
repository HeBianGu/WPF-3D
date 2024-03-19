using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLCompositeDataWriter
	/// </summary>
	/// <remarks>
	///    Writer for multi-group datasets
	///
	/// vtkXMLCompositeDataWriter writes (serially) the VTK XML multi-group,
	/// multi-block hierarchical and hierarchical box files. XML multi-group
	/// data files are meta-files that point to a list of serial VTK XML files.
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPCompositeDataWriter
	/// </seealso>
	// Token: 0x02000142 RID: 322
	public abstract class vtkXMLCompositeDataWriter : vtkXMLWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003ED2 RID: 16082 RVA: 0x0005BD0B File Offset: 0x00059F0B
		static vtkXMLCompositeDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLCompositeDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLCompositeDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003ED3 RID: 16083 RVA: 0x0005BD33 File Offset: 0x00059F33
		public vtkXMLCompositeDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003ED4 RID: 16084 RVA: 0x0005BD41 File Offset: 0x00059F41
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003ED5 RID: 16085
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLCompositeDataWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x06003ED6 RID: 16086 RVA: 0x0005BD4C File Offset: 0x00059F4C
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003ED7 RID: 16087
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLCompositeDataWriter_GetGhostLevel_02(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of ghost levels to be written.
		/// </summary>
		// Token: 0x06003ED8 RID: 16088 RVA: 0x0005BD88 File Offset: 0x00059F88
		public virtual int GetGhostLevel()
		{
			return vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_GetGhostLevel_02(base.GetCppThis());
		}

		// Token: 0x06003ED9 RID: 16089
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLCompositeDataWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EDA RID: 16090 RVA: 0x0005BDA8 File Offset: 0x00059FA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06003EDB RID: 16091
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLCompositeDataWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EDC RID: 16092 RVA: 0x0005BDC8 File Offset: 0x00059FC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06003EDD RID: 16093
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLCompositeDataWriter_GetWriteMetaFile_05(HandleRef pThis);

		/// <summary>
		/// Get/Set whether this instance will write the meta-file.
		/// </summary>
		// Token: 0x06003EDE RID: 16094 RVA: 0x0005BDE4 File Offset: 0x00059FE4
		public virtual int GetWriteMetaFile()
		{
			return vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_GetWriteMetaFile_05(base.GetCppThis());
		}

		// Token: 0x06003EDF RID: 16095
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLCompositeDataWriter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EE0 RID: 16096 RVA: 0x0005BE04 File Offset: 0x0005A004
		public override int IsA(string type)
		{
			return vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06003EE1 RID: 16097
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLCompositeDataWriter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EE2 RID: 16098 RVA: 0x0005BE24 File Offset: 0x0005A024
		public new static int IsTypeOf(string type)
		{
			return vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_IsTypeOf_07(type);
		}

		// Token: 0x06003EE3 RID: 16099
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLCompositeDataWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EE4 RID: 16100 RVA: 0x0005BE40 File Offset: 0x0005A040
		public new vtkXMLCompositeDataWriter NewInstance()
		{
			vtkXMLCompositeDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLCompositeDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003EE5 RID: 16101
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLCompositeDataWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003EE6 RID: 16102 RVA: 0x0005BE9C File Offset: 0x0005A09C
		public new static vtkXMLCompositeDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLCompositeDataWriter vtkXMLCompositeDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLCompositeDataWriter = (vtkXMLCompositeDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLCompositeDataWriter.Register(null);
				}
			}
			return vtkXMLCompositeDataWriter;
		}

		// Token: 0x06003EE7 RID: 16103
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLCompositeDataWriter_SetGhostLevel_10(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the number of ghost levels to be written.
		/// </summary>
		// Token: 0x06003EE8 RID: 16104 RVA: 0x0005BF1B File Offset: 0x0005A11B
		public virtual void SetGhostLevel(int _arg)
		{
			vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_SetGhostLevel_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06003EE9 RID: 16105
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLCompositeDataWriter_SetWriteMetaFile_11(HandleRef pThis, int flag);

		/// <summary>
		/// Get/Set whether this instance will write the meta-file.
		/// </summary>
		// Token: 0x06003EEA RID: 16106 RVA: 0x0005BF2B File Offset: 0x0005A12B
		public virtual void SetWriteMetaFile(int flag)
		{
			vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_SetWriteMetaFile_11(base.GetCppThis(), flag);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006C8 RID: 1736
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLCompositeDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006C9 RID: 1737
		public new static readonly string MRClassNameKey = "class vtkXMLCompositeDataWriter";
	}
}
