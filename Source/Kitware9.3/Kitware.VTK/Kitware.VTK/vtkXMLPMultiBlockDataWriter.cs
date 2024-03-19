using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPMultiBlockDataWriter
	/// </summary>
	/// <remarks>
	///    parallel writer for
	/// vtkHierarchicalBoxDataSet.
	///
	/// vtkXMLPCompositeDataWriter writes (in parallel or serially) the VTK XML
	/// multi-group, multi-block hierarchical and hierarchical box files. XML
	/// multi-group data files are meta-files that point to a list of serial VTK
	/// XML files.
	/// </remarks>
	// Token: 0x02000149 RID: 329
	public class vtkXMLPMultiBlockDataWriter : vtkXMLMultiBlockDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003F62 RID: 16226 RVA: 0x0005CD93 File Offset: 0x0005AF93
		static vtkXMLPMultiBlockDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPMultiBlockDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPMultiBlockDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003F63 RID: 16227 RVA: 0x0005CDBB File Offset: 0x0005AFBB
		public vtkXMLPMultiBlockDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003F64 RID: 16228
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPMultiBlockDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F65 RID: 16229 RVA: 0x0005CDCC File Offset: 0x0005AFCC
		public new static vtkXMLPMultiBlockDataWriter New()
		{
			vtkXMLPMultiBlockDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPMultiBlockDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F66 RID: 16230 RVA: 0x0005CE20 File Offset: 0x0005B020
		public vtkXMLPMultiBlockDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003F67 RID: 16231 RVA: 0x0005CE64 File Offset: 0x0005B064
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003F68 RID: 16232
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPMultiBlockDataWriter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Controller used to communicate data type of blocks.
		/// By default, the global controller is used. If you want another
		/// controller to be used, set it with this.
		/// If no controller is set, only the local blocks will be written
		/// to the meta-file.
		/// </summary>
		// Token: 0x06003F69 RID: 16233 RVA: 0x0005CE70 File Offset: 0x0005B070
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003F6A RID: 16234
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPMultiBlockDataWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F6B RID: 16235 RVA: 0x0005CEE0 File Offset: 0x0005B0E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06003F6C RID: 16236
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPMultiBlockDataWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F6D RID: 16237 RVA: 0x0005CF00 File Offset: 0x0005B100
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06003F6E RID: 16238
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPMultiBlockDataWriter_GetNumberOfPieces_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of pieces that are being written in parallel.
		/// </summary>
		// Token: 0x06003F6F RID: 16239 RVA: 0x0005CF1C File Offset: 0x0005B11C
		public virtual int GetNumberOfPieces()
		{
			return vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_GetNumberOfPieces_04(base.GetCppThis());
		}

		// Token: 0x06003F70 RID: 16240
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPMultiBlockDataWriter_GetStartPiece_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the range of pieces assigned to this writer.
		/// </summary>
		// Token: 0x06003F71 RID: 16241 RVA: 0x0005CF3C File Offset: 0x0005B13C
		public virtual int GetStartPiece()
		{
			return vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_GetStartPiece_05(base.GetCppThis());
		}

		// Token: 0x06003F72 RID: 16242
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPMultiBlockDataWriter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F73 RID: 16243 RVA: 0x0005CF5C File Offset: 0x0005B15C
		public override int IsA(string type)
		{
			return vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06003F74 RID: 16244
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPMultiBlockDataWriter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F75 RID: 16245 RVA: 0x0005CF7C File Offset: 0x0005B17C
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_IsTypeOf_07(type);
		}

		// Token: 0x06003F76 RID: 16246
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPMultiBlockDataWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F77 RID: 16247 RVA: 0x0005CF98 File Offset: 0x0005B198
		public new vtkXMLPMultiBlockDataWriter NewInstance()
		{
			vtkXMLPMultiBlockDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPMultiBlockDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003F78 RID: 16248
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPMultiBlockDataWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F79 RID: 16249 RVA: 0x0005CFF4 File Offset: 0x0005B1F4
		public new static vtkXMLPMultiBlockDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPMultiBlockDataWriter vtkXMLPMultiBlockDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPMultiBlockDataWriter = (vtkXMLPMultiBlockDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPMultiBlockDataWriter.Register(null);
				}
			}
			return vtkXMLPMultiBlockDataWriter;
		}

		// Token: 0x06003F7A RID: 16250
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPMultiBlockDataWriter_SetController_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Controller used to communicate data type of blocks.
		/// By default, the global controller is used. If you want another
		/// controller to be used, set it with this.
		/// If no controller is set, only the local blocks will be written
		/// to the meta-file.
		/// </summary>
		// Token: 0x06003F7B RID: 16251 RVA: 0x0005D074 File Offset: 0x0005B274
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_SetController_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003F7C RID: 16252
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPMultiBlockDataWriter_SetNumberOfPieces_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the number of pieces that are being written in parallel.
		/// </summary>
		// Token: 0x06003F7D RID: 16253 RVA: 0x0005D0A3 File Offset: 0x0005B2A3
		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_SetNumberOfPieces_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06003F7E RID: 16254
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPMultiBlockDataWriter_SetStartPiece_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the range of pieces assigned to this writer.
		/// </summary>
		// Token: 0x06003F7F RID: 16255 RVA: 0x0005D0B3 File Offset: 0x0005B2B3
		public virtual void SetStartPiece(int _arg)
		{
			vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_SetStartPiece_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06003F80 RID: 16256
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPMultiBlockDataWriter_SetWriteMetaFile_14(HandleRef pThis, int flag);

		/// <summary>
		/// Set whether this instance will write the meta-file. WriteMetaFile
		/// is set to flag only on process 0 and all other processes have
		/// WriteMetaFile set to 0 by default.
		/// </summary>
		// Token: 0x06003F81 RID: 16257 RVA: 0x0005D0C3 File Offset: 0x0005B2C3
		public override void SetWriteMetaFile(int flag)
		{
			vtkXMLPMultiBlockDataWriter.vtkXMLPMultiBlockDataWriter_SetWriteMetaFile_14(base.GetCppThis(), flag);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006D6 RID: 1750
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPMultiBlockDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006D7 RID: 1751
		public new static readonly string MRClassNameKey = "class vtkXMLPMultiBlockDataWriter";
	}
}
