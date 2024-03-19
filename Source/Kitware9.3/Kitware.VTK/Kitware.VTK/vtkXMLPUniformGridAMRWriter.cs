using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPUniformGridAMRWriter
	/// </summary>
	/// <remarks>
	///    parallel writer for
	/// vtkUniformGridAMR and subclasses.
	///
	/// vtkXMLPCompositeDataWriter writes (in parallel or serially) vtkUniformGridAMR
	/// and subclasses. When running in parallel all processes are expected to have
	/// the same meta-data (i.e. amr-boxes, structure, etc.) however they may now
	/// have the missing data-blocks. This class extends
	/// vtkXMLUniformGridAMRWriter to communicate information about data blocks
	/// to the root node so that the root node can write the XML file describing the
	/// structure correctly.
	/// </remarks>
	// Token: 0x02000144 RID: 324
	public class vtkXMLPUniformGridAMRWriter : vtkXMLUniformGridAMRWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003EFF RID: 16127 RVA: 0x0005C1A7 File Offset: 0x0005A3A7
		static vtkXMLPUniformGridAMRWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPUniformGridAMRWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPUniformGridAMRWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003F00 RID: 16128 RVA: 0x0005C1CF File Offset: 0x0005A3CF
		public vtkXMLPUniformGridAMRWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003F01 RID: 16129
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUniformGridAMRWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F02 RID: 16130 RVA: 0x0005C1E0 File Offset: 0x0005A3E0
		public new static vtkXMLPUniformGridAMRWriter New()
		{
			vtkXMLPUniformGridAMRWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUniformGridAMRWriter.vtkXMLPUniformGridAMRWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPUniformGridAMRWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F03 RID: 16131 RVA: 0x0005C234 File Offset: 0x0005A434
		public vtkXMLPUniformGridAMRWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPUniformGridAMRWriter.vtkXMLPUniformGridAMRWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003F04 RID: 16132 RVA: 0x0005C278 File Offset: 0x0005A478
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003F05 RID: 16133
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUniformGridAMRWriter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Controller used to communicate data type of blocks.
		/// By default, the global controller is used. If you want another
		/// controller to be used, set it with this.
		/// If no controller is set, only the local blocks will be written
		/// to the meta-file.
		/// </summary>
		// Token: 0x06003F06 RID: 16134 RVA: 0x0005C284 File Offset: 0x0005A484
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUniformGridAMRWriter.vtkXMLPUniformGridAMRWriter_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x06003F07 RID: 16135
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPUniformGridAMRWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F08 RID: 16136 RVA: 0x0005C2F4 File Offset: 0x0005A4F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPUniformGridAMRWriter.vtkXMLPUniformGridAMRWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06003F09 RID: 16137
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPUniformGridAMRWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F0A RID: 16138 RVA: 0x0005C314 File Offset: 0x0005A514
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPUniformGridAMRWriter.vtkXMLPUniformGridAMRWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06003F0B RID: 16139
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPUniformGridAMRWriter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F0C RID: 16140 RVA: 0x0005C330 File Offset: 0x0005A530
		public override int IsA(string type)
		{
			return vtkXMLPUniformGridAMRWriter.vtkXMLPUniformGridAMRWriter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06003F0D RID: 16141
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPUniformGridAMRWriter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F0E RID: 16142 RVA: 0x0005C350 File Offset: 0x0005A550
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPUniformGridAMRWriter.vtkXMLPUniformGridAMRWriter_IsTypeOf_05(type);
		}

		// Token: 0x06003F0F RID: 16143
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUniformGridAMRWriter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F10 RID: 16144 RVA: 0x0005C36C File Offset: 0x0005A56C
		public new vtkXMLPUniformGridAMRWriter NewInstance()
		{
			vtkXMLPUniformGridAMRWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUniformGridAMRWriter.vtkXMLPUniformGridAMRWriter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPUniformGridAMRWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003F11 RID: 16145
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUniformGridAMRWriter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F12 RID: 16146 RVA: 0x0005C3C8 File Offset: 0x0005A5C8
		public new static vtkXMLPUniformGridAMRWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPUniformGridAMRWriter vtkXMLPUniformGridAMRWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUniformGridAMRWriter.vtkXMLPUniformGridAMRWriter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPUniformGridAMRWriter = (vtkXMLPUniformGridAMRWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPUniformGridAMRWriter.Register(null);
				}
			}
			return vtkXMLPUniformGridAMRWriter;
		}

		// Token: 0x06003F13 RID: 16147
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPUniformGridAMRWriter_SetController_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Controller used to communicate data type of blocks.
		/// By default, the global controller is used. If you want another
		/// controller to be used, set it with this.
		/// If no controller is set, only the local blocks will be written
		/// to the meta-file.
		/// </summary>
		// Token: 0x06003F14 RID: 16148 RVA: 0x0005C448 File Offset: 0x0005A648
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkXMLPUniformGridAMRWriter.vtkXMLPUniformGridAMRWriter_SetController_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003F15 RID: 16149
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPUniformGridAMRWriter_SetWriteMetaFile_10(HandleRef pThis, int flag);

		/// <summary>
		/// Set whether this instance will write the meta-file. WriteMetaFile
		/// is set to flag only on process 0 and all other processes have
		/// WriteMetaFile set to 0 by default.
		/// </summary>
		// Token: 0x06003F16 RID: 16150 RVA: 0x0005C477 File Offset: 0x0005A677
		public override void SetWriteMetaFile(int flag)
		{
			vtkXMLPUniformGridAMRWriter.vtkXMLPUniformGridAMRWriter_SetWriteMetaFile_10(base.GetCppThis(), flag);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006CC RID: 1740
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPUniformGridAMRWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006CD RID: 1741
		public new static readonly string MRClassNameKey = "class vtkXMLPUniformGridAMRWriter";
	}
}
