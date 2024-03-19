using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPDataObjectWriter
	/// </summary>
	/// <remarks>
	///    Write data in a parallel XML format.
	///
	/// vtkXMLPDataWriter is the superclass for all XML parallel data object
	/// writers.  It provides functionality needed for writing parallel
	/// formats, such as the selection of which writer writes the summary
	/// file and what range of pieces are assigned to each serial writer.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLDataObjectWriter
	/// </seealso>
	// Token: 0x0200013F RID: 319
	public abstract class vtkXMLPDataObjectWriter : vtkXMLWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003E80 RID: 16000 RVA: 0x0005B553 File Offset: 0x00059753
		static vtkXMLPDataObjectWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPDataObjectWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPDataObjectWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003E81 RID: 16001 RVA: 0x0005B57B File Offset: 0x0005977B
		public vtkXMLPDataObjectWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003E82 RID: 16002 RVA: 0x0005B589 File Offset: 0x00059789
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003E83 RID: 16003
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPDataObjectWriter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Controller used to communicate data type of blocks.
		/// By default, the global controller is used. If you want another
		/// controller to be used, set it with this.
		/// </summary>
		// Token: 0x06003E84 RID: 16004 RVA: 0x0005B594 File Offset: 0x00059794
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003E85 RID: 16005
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataObjectWriter_GetEndPiece_02(HandleRef pThis);

		/// <summary>
		/// Get/Set the range of pieces assigned to this writer.
		/// </summary>
		// Token: 0x06003E86 RID: 16006 RVA: 0x0005B604 File Offset: 0x00059804
		public virtual int GetEndPiece()
		{
			return vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_GetEndPiece_02(base.GetCppThis());
		}

		// Token: 0x06003E87 RID: 16007
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataObjectWriter_GetGhostLevel_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the ghost level used for this writer's piece.
		/// </summary>
		// Token: 0x06003E88 RID: 16008 RVA: 0x0005B624 File Offset: 0x00059824
		public virtual int GetGhostLevel()
		{
			return vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_GetGhostLevel_03(base.GetCppThis());
		}

		// Token: 0x06003E89 RID: 16009
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPDataObjectWriter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E8A RID: 16010 RVA: 0x0005B644 File Offset: 0x00059844
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06003E8B RID: 16011
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPDataObjectWriter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E8C RID: 16012 RVA: 0x0005B664 File Offset: 0x00059864
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06003E8D RID: 16013
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataObjectWriter_GetNumberOfPieces_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of pieces that are being written in parallel.
		/// </summary>
		// Token: 0x06003E8E RID: 16014 RVA: 0x0005B680 File Offset: 0x00059880
		public virtual int GetNumberOfPieces()
		{
			return vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_GetNumberOfPieces_06(base.GetCppThis());
		}

		// Token: 0x06003E8F RID: 16015
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataObjectWriter_GetStartPiece_07(HandleRef pThis);

		/// <summary>
		/// Get/Set the range of pieces assigned to this writer.
		/// </summary>
		// Token: 0x06003E90 RID: 16016 RVA: 0x0005B6A0 File Offset: 0x000598A0
		public virtual int GetStartPiece()
		{
			return vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_GetStartPiece_07(base.GetCppThis());
		}

		// Token: 0x06003E91 RID: 16017
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkXMLPDataObjectWriter_GetUseSubdirectory_08(HandleRef pThis);

		/// <summary>
		/// Get/Set whether to use a subdirectory to store the pieces
		/// </summary>
		// Token: 0x06003E92 RID: 16018 RVA: 0x0005B6C0 File Offset: 0x000598C0
		public virtual bool GetUseSubdirectory()
		{
			return vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_GetUseSubdirectory_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06003E93 RID: 16019
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataObjectWriter_GetWriteSummaryFile_09(HandleRef pThis);

		/// <summary>
		/// Get/Set whether the writer should write the summary file that
		/// refers to all of the pieces' individual files.
		/// This is on by default. Note that only the first process writes
		/// the summary file.
		/// </summary>
		// Token: 0x06003E94 RID: 16020 RVA: 0x0005B6E8 File Offset: 0x000598E8
		public virtual int GetWriteSummaryFile()
		{
			return vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_GetWriteSummaryFile_09(base.GetCppThis());
		}

		// Token: 0x06003E95 RID: 16021
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataObjectWriter_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E96 RID: 16022 RVA: 0x0005B708 File Offset: 0x00059908
		public override int IsA(string type)
		{
			return vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06003E97 RID: 16023
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataObjectWriter_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E98 RID: 16024 RVA: 0x0005B728 File Offset: 0x00059928
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_IsTypeOf_11(type);
		}

		// Token: 0x06003E99 RID: 16025
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPDataObjectWriter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E9A RID: 16026 RVA: 0x0005B744 File Offset: 0x00059944
		public new vtkXMLPDataObjectWriter NewInstance()
		{
			vtkXMLPDataObjectWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPDataObjectWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003E9B RID: 16027
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPDataObjectWriter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E9C RID: 16028 RVA: 0x0005B7A0 File Offset: 0x000599A0
		public new static vtkXMLPDataObjectWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPDataObjectWriter vtkXMLPDataObjectWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPDataObjectWriter = (vtkXMLPDataObjectWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPDataObjectWriter.Register(null);
				}
			}
			return vtkXMLPDataObjectWriter;
		}

		// Token: 0x06003E9D RID: 16029
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPDataObjectWriter_SetController_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Controller used to communicate data type of blocks.
		/// By default, the global controller is used. If you want another
		/// controller to be used, set it with this.
		/// </summary>
		// Token: 0x06003E9E RID: 16030 RVA: 0x0005B820 File Offset: 0x00059A20
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_SetController_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003E9F RID: 16031
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPDataObjectWriter_SetEndPiece_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the range of pieces assigned to this writer.
		/// </summary>
		// Token: 0x06003EA0 RID: 16032 RVA: 0x0005B84F File Offset: 0x00059A4F
		public virtual void SetEndPiece(int _arg)
		{
			vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_SetEndPiece_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06003EA1 RID: 16033
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPDataObjectWriter_SetGhostLevel_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the ghost level used for this writer's piece.
		/// </summary>
		// Token: 0x06003EA2 RID: 16034 RVA: 0x0005B85F File Offset: 0x00059A5F
		public virtual void SetGhostLevel(int _arg)
		{
			vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_SetGhostLevel_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06003EA3 RID: 16035
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPDataObjectWriter_SetNumberOfPieces_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the number of pieces that are being written in parallel.
		/// </summary>
		// Token: 0x06003EA4 RID: 16036 RVA: 0x0005B86F File Offset: 0x00059A6F
		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_SetNumberOfPieces_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06003EA5 RID: 16037
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPDataObjectWriter_SetStartPiece_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the range of pieces assigned to this writer.
		/// </summary>
		// Token: 0x06003EA6 RID: 16038 RVA: 0x0005B87F File Offset: 0x00059A7F
		public virtual void SetStartPiece(int _arg)
		{
			vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_SetStartPiece_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06003EA7 RID: 16039
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPDataObjectWriter_SetUseSubdirectory_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set whether to use a subdirectory to store the pieces
		/// </summary>
		// Token: 0x06003EA8 RID: 16040 RVA: 0x0005B88F File Offset: 0x00059A8F
		public virtual void SetUseSubdirectory(bool _arg)
		{
			vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_SetUseSubdirectory_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06003EA9 RID: 16041
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPDataObjectWriter_SetWriteSummaryFile_20(HandleRef pThis, int flag);

		/// <summary>
		/// Get/Set whether the writer should write the summary file that
		/// refers to all of the pieces' individual files.
		/// This is on by default. Note that only the first process writes
		/// the summary file.
		/// </summary>
		// Token: 0x06003EAA RID: 16042 RVA: 0x0005B8A7 File Offset: 0x00059AA7
		public virtual void SetWriteSummaryFile(int flag)
		{
			vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_SetWriteSummaryFile_20(base.GetCppThis(), flag);
		}

		// Token: 0x06003EAB RID: 16043
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPDataObjectWriter_WriteSummaryFileOff_21(HandleRef pThis);

		/// <summary>
		/// Get/Set whether the writer should write the summary file that
		/// refers to all of the pieces' individual files.
		/// This is on by default. Note that only the first process writes
		/// the summary file.
		/// </summary>
		// Token: 0x06003EAC RID: 16044 RVA: 0x0005B8B7 File Offset: 0x00059AB7
		public virtual void WriteSummaryFileOff()
		{
			vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_WriteSummaryFileOff_21(base.GetCppThis());
		}

		// Token: 0x06003EAD RID: 16045
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPDataObjectWriter_WriteSummaryFileOn_22(HandleRef pThis);

		/// <summary>
		/// Get/Set whether the writer should write the summary file that
		/// refers to all of the pieces' individual files.
		/// This is on by default. Note that only the first process writes
		/// the summary file.
		/// </summary>
		// Token: 0x06003EAE RID: 16046 RVA: 0x0005B8C6 File Offset: 0x00059AC6
		public virtual void WriteSummaryFileOn()
		{
			vtkXMLPDataObjectWriter.vtkXMLPDataObjectWriter_WriteSummaryFileOn_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006C2 RID: 1730
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPDataObjectWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006C3 RID: 1731
		public new static readonly string MRClassNameKey = "class vtkXMLPDataObjectWriter";
	}
}
