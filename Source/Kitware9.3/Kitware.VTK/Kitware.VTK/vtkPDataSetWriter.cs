using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPDataSetWriter
	/// </summary>
	/// <remarks>
	///    Manages writing pieces of a data set.
	///
	/// vtkPDataSetWriter will write a piece of a file, and will also create
	/// a metadata file that lists all of the files in a data set.
	/// </remarks>
	// Token: 0x0200015E RID: 350
	public class vtkPDataSetWriter : vtkDataSetWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060042B6 RID: 17078 RVA: 0x00061B57 File Offset: 0x0005FD57
		static vtkPDataSetWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPDataSetWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPDataSetWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060042B7 RID: 17079 RVA: 0x00061B7F File Offset: 0x0005FD7F
		public vtkPDataSetWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060042B8 RID: 17080
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDataSetWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042B9 RID: 17081 RVA: 0x00061B90 File Offset: 0x0005FD90
		public new static vtkPDataSetWriter New()
		{
			vtkPDataSetWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDataSetWriter.vtkPDataSetWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDataSetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042BA RID: 17082 RVA: 0x00061BE4 File Offset: 0x0005FDE4
		public vtkPDataSetWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPDataSetWriter.vtkPDataSetWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060042BB RID: 17083 RVA: 0x00061C28 File Offset: 0x0005FE28
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060042BC RID: 17084
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDataSetWriter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Controller used to communicate data type of blocks.
		/// By default, the global controller is used. If you want another
		/// controller to be used, set it with this.
		/// </summary>
		// Token: 0x060042BD RID: 17085 RVA: 0x00061C34 File Offset: 0x0005FE34
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDataSetWriter.vtkPDataSetWriter_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060042BE RID: 17086
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDataSetWriter_GetEndPiece_02(HandleRef pThis);

		/// <summary>
		/// This is the range of pieces that that this writer is
		/// responsible for writing.  All pieces must be written
		/// by some process.  The process that writes piece 0 also
		/// writes the pvtk file that lists all the piece file names.
		/// </summary>
		// Token: 0x060042BF RID: 17087 RVA: 0x00061CA4 File Offset: 0x0005FEA4
		public virtual int GetEndPiece()
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_GetEndPiece_02(base.GetCppThis());
		}

		// Token: 0x060042C0 RID: 17088
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDataSetWriter_GetFilePattern_03(HandleRef pThis);

		/// <summary>
		/// This file pattern uses the file name and piece number
		/// to construct a file name for the piece file.
		/// </summary>
		// Token: 0x060042C1 RID: 17089 RVA: 0x00061CC4 File Offset: 0x0005FEC4
		public virtual string GetFilePattern()
		{
			string s = Marshal.PtrToStringAnsi(vtkPDataSetWriter.vtkPDataSetWriter_GetFilePattern_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060042C2 RID: 17090
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDataSetWriter_GetGhostLevel_04(HandleRef pThis);

		/// <summary>
		/// Extra ghost cells will be written out to each piece file
		/// if this value is larger than 0.
		/// </summary>
		// Token: 0x060042C3 RID: 17091 RVA: 0x00061D00 File Offset: 0x0005FF00
		public virtual int GetGhostLevel()
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_GetGhostLevel_04(base.GetCppThis());
		}

		// Token: 0x060042C4 RID: 17092
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPDataSetWriter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042C5 RID: 17093 RVA: 0x00061D20 File Offset: 0x0005FF20
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060042C6 RID: 17094
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPDataSetWriter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042C7 RID: 17095 RVA: 0x00061D40 File Offset: 0x0005FF40
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060042C8 RID: 17096
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDataSetWriter_GetNumberOfPieces_07(HandleRef pThis);

		/// <summary>
		/// This is how many pieces the whole data set will be divided into.
		/// </summary>
		// Token: 0x060042C9 RID: 17097 RVA: 0x00061D5C File Offset: 0x0005FF5C
		public virtual int GetNumberOfPieces()
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_GetNumberOfPieces_07(base.GetCppThis());
		}

		// Token: 0x060042CA RID: 17098
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDataSetWriter_GetStartPiece_08(HandleRef pThis);

		/// <summary>
		/// This is the range of pieces that that this writer is
		/// responsible for writing.  All pieces must be written
		/// by some process.  The process that writes piece 0 also
		/// writes the pvtk file that lists all the piece file names.
		/// </summary>
		// Token: 0x060042CB RID: 17099 RVA: 0x00061D7C File Offset: 0x0005FF7C
		public virtual int GetStartPiece()
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_GetStartPiece_08(base.GetCppThis());
		}

		// Token: 0x060042CC RID: 17100
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDataSetWriter_GetUseRelativeFileNames_09(HandleRef pThis);

		/// <summary>
		/// This flag determines whether to use absolute paths for the piece files.
		/// By default the pieces are put in the main directory, and the piece file
		/// names in the meta data pvtk file are relative to this directory.
		/// This should make moving the whole lot to another directory, an easier task.
		/// </summary>
		// Token: 0x060042CD RID: 17101 RVA: 0x00061D9C File Offset: 0x0005FF9C
		public virtual int GetUseRelativeFileNames()
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_GetUseRelativeFileNames_09(base.GetCppThis());
		}

		// Token: 0x060042CE RID: 17102
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDataSetWriter_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042CF RID: 17103 RVA: 0x00061DBC File Offset: 0x0005FFBC
		public override int IsA(string type)
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x060042D0 RID: 17104
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDataSetWriter_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042D1 RID: 17105 RVA: 0x00061DDC File Offset: 0x0005FFDC
		public new static int IsTypeOf(string type)
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_IsTypeOf_11(type);
		}

		// Token: 0x060042D2 RID: 17106
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDataSetWriter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042D3 RID: 17107 RVA: 0x00061DF8 File Offset: 0x0005FFF8
		public new vtkPDataSetWriter NewInstance()
		{
			vtkPDataSetWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDataSetWriter.vtkPDataSetWriter_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDataSetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060042D4 RID: 17108
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDataSetWriter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042D5 RID: 17109 RVA: 0x00061E54 File Offset: 0x00060054
		public new static vtkPDataSetWriter SafeDownCast(vtkObjectBase o)
		{
			vtkPDataSetWriter vtkPDataSetWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDataSetWriter.vtkPDataSetWriter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPDataSetWriter = (vtkPDataSetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPDataSetWriter.Register(null);
				}
			}
			return vtkPDataSetWriter;
		}

		// Token: 0x060042D6 RID: 17110
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPDataSetWriter_SetController_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Controller used to communicate data type of blocks.
		/// By default, the global controller is used. If you want another
		/// controller to be used, set it with this.
		/// </summary>
		// Token: 0x060042D7 RID: 17111 RVA: 0x00061ED4 File Offset: 0x000600D4
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPDataSetWriter.vtkPDataSetWriter_SetController_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060042D8 RID: 17112
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPDataSetWriter_SetEndPiece_16(HandleRef pThis, int _arg);

		/// <summary>
		/// This is the range of pieces that that this writer is
		/// responsible for writing.  All pieces must be written
		/// by some process.  The process that writes piece 0 also
		/// writes the pvtk file that lists all the piece file names.
		/// </summary>
		// Token: 0x060042D9 RID: 17113 RVA: 0x00061F03 File Offset: 0x00060103
		public virtual void SetEndPiece(int _arg)
		{
			vtkPDataSetWriter.vtkPDataSetWriter_SetEndPiece_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060042DA RID: 17114
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPDataSetWriter_SetFilePattern_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// This file pattern uses the file name and piece number
		/// to construct a file name for the piece file.
		/// </summary>
		// Token: 0x060042DB RID: 17115 RVA: 0x00061F13 File Offset: 0x00060113
		public virtual void SetFilePattern(string _arg)
		{
			vtkPDataSetWriter.vtkPDataSetWriter_SetFilePattern_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060042DC RID: 17116
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPDataSetWriter_SetGhostLevel_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Extra ghost cells will be written out to each piece file
		/// if this value is larger than 0.
		/// </summary>
		// Token: 0x060042DD RID: 17117 RVA: 0x00061F23 File Offset: 0x00060123
		public virtual void SetGhostLevel(int _arg)
		{
			vtkPDataSetWriter.vtkPDataSetWriter_SetGhostLevel_18(base.GetCppThis(), _arg);
		}

		// Token: 0x060042DE RID: 17118
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPDataSetWriter_SetNumberOfPieces_19(HandleRef pThis, int num);

		/// <summary>
		/// This is how many pieces the whole data set will be divided into.
		/// </summary>
		// Token: 0x060042DF RID: 17119 RVA: 0x00061F33 File Offset: 0x00060133
		public void SetNumberOfPieces(int num)
		{
			vtkPDataSetWriter.vtkPDataSetWriter_SetNumberOfPieces_19(base.GetCppThis(), num);
		}

		// Token: 0x060042E0 RID: 17120
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPDataSetWriter_SetStartPiece_20(HandleRef pThis, int _arg);

		/// <summary>
		/// This is the range of pieces that that this writer is
		/// responsible for writing.  All pieces must be written
		/// by some process.  The process that writes piece 0 also
		/// writes the pvtk file that lists all the piece file names.
		/// </summary>
		// Token: 0x060042E1 RID: 17121 RVA: 0x00061F43 File Offset: 0x00060143
		public virtual void SetStartPiece(int _arg)
		{
			vtkPDataSetWriter.vtkPDataSetWriter_SetStartPiece_20(base.GetCppThis(), _arg);
		}

		// Token: 0x060042E2 RID: 17122
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPDataSetWriter_SetUseRelativeFileNames_21(HandleRef pThis, int _arg);

		/// <summary>
		/// This flag determines whether to use absolute paths for the piece files.
		/// By default the pieces are put in the main directory, and the piece file
		/// names in the meta data pvtk file are relative to this directory.
		/// This should make moving the whole lot to another directory, an easier task.
		/// </summary>
		// Token: 0x060042E3 RID: 17123 RVA: 0x00061F53 File Offset: 0x00060153
		public virtual void SetUseRelativeFileNames(int _arg)
		{
			vtkPDataSetWriter.vtkPDataSetWriter_SetUseRelativeFileNames_21(base.GetCppThis(), _arg);
		}

		// Token: 0x060042E4 RID: 17124
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPDataSetWriter_UseRelativeFileNamesOff_22(HandleRef pThis);

		/// <summary>
		/// This flag determines whether to use absolute paths for the piece files.
		/// By default the pieces are put in the main directory, and the piece file
		/// names in the meta data pvtk file are relative to this directory.
		/// This should make moving the whole lot to another directory, an easier task.
		/// </summary>
		// Token: 0x060042E5 RID: 17125 RVA: 0x00061F63 File Offset: 0x00060163
		public virtual void UseRelativeFileNamesOff()
		{
			vtkPDataSetWriter.vtkPDataSetWriter_UseRelativeFileNamesOff_22(base.GetCppThis());
		}

		// Token: 0x060042E6 RID: 17126
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPDataSetWriter_UseRelativeFileNamesOn_23(HandleRef pThis);

		/// <summary>
		/// This flag determines whether to use absolute paths for the piece files.
		/// By default the pieces are put in the main directory, and the piece file
		/// names in the meta data pvtk file are relative to this directory.
		/// This should make moving the whole lot to another directory, an easier task.
		/// </summary>
		// Token: 0x060042E7 RID: 17127 RVA: 0x00061F72 File Offset: 0x00060172
		public virtual void UseRelativeFileNamesOn()
		{
			vtkPDataSetWriter.vtkPDataSetWriter_UseRelativeFileNamesOn_23(base.GetCppThis());
		}

		// Token: 0x060042E8 RID: 17128
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDataSetWriter_Write_24(HandleRef pThis);

		/// <summary>
		/// Write the pvtk file and corresponding vtk files.
		/// </summary>
		// Token: 0x060042E9 RID: 17129 RVA: 0x00061F84 File Offset: 0x00060184
		public override int Write()
		{
			return vtkPDataSetWriter.vtkPDataSetWriter_Write_24(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000702 RID: 1794
		public new const string MRFullTypeName = "Kitware.VTK.vtkPDataSetWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000703 RID: 1795
		public new static readonly string MRClassNameKey = "class vtkPDataSetWriter";
	}
}
