using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExodusIIWriter
	/// </summary>
	/// <remarks>
	///    Write Exodus II files
	///
	///     This is a vtkWriter that writes it's vtkUnstructuredGrid
	///     input out to an Exodus II file.  Go to http://endo.sandia.gov/SEACAS/
	///     for more information about the Exodus II format.
	///
	///     Exodus files contain much information that is not captured
	///     in a vtkUnstructuredGrid, such as time steps, information
	///     lines, node sets, and side sets.  This information can be
	///     stored in a vtkModelMetadata object.
	///
	///     The vtkExodusReader and vtkPExodusReader can create
	///     a vtkModelMetadata object and embed it in a vtkUnstructuredGrid
	///     in a series of field arrays.  This writer searches for these
	///     field arrays and will use the metadata contained in them
	///     when creating the new Exodus II file.
	///
	///     You can also explicitly give the vtkExodusIIWriter a
	///     vtkModelMetadata object to use when writing the file.
	///
	///     In the absence of the information provided by vtkModelMetadata,
	///     if this writer is not part of a parallel application, we will use
	///     reasonable defaults for all the values in the output Exodus file.
	///     If you don't provide a block ID element array, we'll create a
	///     block for each cell type that appears in the unstructured grid.
	///
	///     However if this writer is part of a parallel application (hence
	///     writing out a distributed Exodus file), then we need at the very
	///     least a list of all the block IDs that appear in the file.  And
	///     we need the element array of block IDs for the input unstructured grid.
	///
	///     In the absence of a vtkModelMetadata object, you can also provide
	///     time step information which we will include in the output Exodus
	///     file.
	///
	/// @warning
	///     If the input floating point field arrays and point locations are all
	///     floats or all doubles, this class will operate more efficiently.
	///     Mixing floats and doubles will slow you down, because Exodus II
	///     requires that we write only floats or only doubles.
	///
	/// @warning
	///     We use the terms "point" and "node" interchangeably.
	///     Also, we use the terms "element" and "cell" interchangeably.
	/// </remarks>
	// Token: 0x020001BC RID: 444
	public class vtkExodusIIWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060056A0 RID: 22176 RVA: 0x0007D6C3 File Offset: 0x0007B8C3
		static vtkExodusIIWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExodusIIWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExodusIIWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060056A1 RID: 22177 RVA: 0x0007D6EB File Offset: 0x0007B8EB
		public vtkExodusIIWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060056A2 RID: 22178
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060056A3 RID: 22179 RVA: 0x0007D6FC File Offset: 0x0007B8FC
		public new static vtkExodusIIWriter New()
		{
			vtkExodusIIWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIIWriter.vtkExodusIIWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusIIWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060056A4 RID: 22180 RVA: 0x0007D750 File Offset: 0x0007B950
		public vtkExodusIIWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExodusIIWriter.vtkExodusIIWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060056A5 RID: 22181 RVA: 0x0007D794 File Offset: 0x0007B994
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060056A6 RID: 22182
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIWriter_GetBlockIdArrayName_01(HandleRef pThis);

		/// <summary>
		/// When WriteAllTimeSteps is turned ON, the writer is executed once for
		/// each timestep available from the reader.
		/// </summary>
		// Token: 0x060056A7 RID: 22183 RVA: 0x0007D7A0 File Offset: 0x0007B9A0
		public virtual string GetBlockIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIWriter.vtkExodusIIWriter_GetBlockIdArrayName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060056A8 RID: 22184
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIWriter_GetFileName_02(HandleRef pThis);

		/// <summary>
		/// Name for the output file.  If writing in parallel, the number
		/// of processes and the process rank will be appended to the name,
		/// so each process is writing out a separate file.
		/// If not set, this class will make up a file name.
		/// </summary>
		// Token: 0x060056A9 RID: 22185 RVA: 0x0007D7DC File Offset: 0x0007B9DC
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIWriter.vtkExodusIIWriter_GetFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060056AA RID: 22186
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIWriter_GetGhostLevel_03(HandleRef pThis);

		/// <summary>
		/// We never write out ghost cells.  This variable is here to satisfy
		/// the behavior of ParaView on invoking a parallel writer.
		/// </summary>
		// Token: 0x060056AB RID: 22187 RVA: 0x0007D818 File Offset: 0x0007BA18
		public virtual int GetGhostLevel()
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_GetGhostLevel_03(base.GetCppThis());
		}

		// Token: 0x060056AC RID: 22188
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExodusIIWriter_GetIgnoreMetaDataWarning_04(HandleRef pThis);

		/// <summary>
		/// In certain cases we know that metadata doesn't exist and
		/// we want to ignore that warning.
		/// </summary>
		// Token: 0x060056AD RID: 22189 RVA: 0x0007D838 File Offset: 0x0007BA38
		public virtual bool GetIgnoreMetaDataWarning()
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_GetIgnoreMetaDataWarning_04(base.GetCppThis()) != 0;
		}

		// Token: 0x060056AE RID: 22190
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIWriter_GetModelMetadata_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the vtkModelMetadata object which contains the Exodus file
		/// model information (metadata) absent in the vtkUnstructuredGrid.  If you
		/// have this object, you don't need to set any other values before writing.
		/// (Just the FileName and the Input.)
		/// Note that the vtkExodusReader can create and attach a vtkModelMetadata
		/// object to it's output.  If this has happened, the ExodusIIWriter will
		/// find it and use it.
		/// </summary>
		// Token: 0x060056AF RID: 22191 RVA: 0x0007D860 File Offset: 0x0007BA60
		public virtual vtkModelMetadata GetModelMetadata()
		{
			vtkModelMetadata vtkModelMetadata = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIIWriter.vtkExodusIIWriter_GetModelMetadata_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkModelMetadata = (vtkModelMetadata)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkModelMetadata.Register(null);
				}
			}
			return vtkModelMetadata;
		}

		// Token: 0x060056B0 RID: 22192
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExodusIIWriter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060056B1 RID: 22193 RVA: 0x0007D8D0 File Offset: 0x0007BAD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060056B2 RID: 22194
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExodusIIWriter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060056B3 RID: 22195 RVA: 0x0007D8F0 File Offset: 0x0007BAF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060056B4 RID: 22196
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIWriter_GetStoreDoubles_08(HandleRef pThis);

		/// <summary>
		/// If StoreDoubles is ON, the floating point fields in the Exodus file
		/// will be double precision fields.  The default is determined by the
		/// max precision of the input.  If the field data appears to be doubles,
		/// then StoreDoubles will be ON, otherwise StoreDoubles will be OFF.
		/// </summary>
		// Token: 0x060056B5 RID: 22197 RVA: 0x0007D90C File Offset: 0x0007BB0C
		public virtual int GetStoreDoubles()
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_GetStoreDoubles_08(base.GetCppThis());
		}

		// Token: 0x060056B6 RID: 22198
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIWriter_GetWriteAllTimeSteps_09(HandleRef pThis);

		/// <summary>
		/// When WriteAllTimeSteps is turned ON, the writer is executed once for
		/// each timestep available from the reader.
		/// </summary>
		// Token: 0x060056B7 RID: 22199 RVA: 0x0007D92C File Offset: 0x0007BB2C
		public virtual int GetWriteAllTimeSteps()
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_GetWriteAllTimeSteps_09(base.GetCppThis());
		}

		// Token: 0x060056B8 RID: 22200
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIWriter_GetWriteOutBlockIdArray_10(HandleRef pThis);

		/// <summary>
		/// By default, the integer array containing the global Block Ids of the
		/// cells is not included when the new Exodus II file is written out.  If
		/// you do want to include this array, set WriteOutBlockIdArray to ON.
		/// </summary>
		// Token: 0x060056B9 RID: 22201 RVA: 0x0007D94C File Offset: 0x0007BB4C
		public virtual int GetWriteOutBlockIdArray()
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_GetWriteOutBlockIdArray_10(base.GetCppThis());
		}

		// Token: 0x060056BA RID: 22202
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIWriter_GetWriteOutGlobalElementIdArray_11(HandleRef pThis);

		/// <summary>
		/// By default, the integer array containing the global Element Ids
		/// is not included when the new Exodus II file is written out.  If you
		/// do want to include this array, set WriteOutGlobalElementIdArray to ON.
		/// </summary>
		// Token: 0x060056BB RID: 22203 RVA: 0x0007D96C File Offset: 0x0007BB6C
		public virtual int GetWriteOutGlobalElementIdArray()
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_GetWriteOutGlobalElementIdArray_11(base.GetCppThis());
		}

		// Token: 0x060056BC RID: 22204
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIWriter_GetWriteOutGlobalNodeIdArray_12(HandleRef pThis);

		/// <summary>
		/// By default, the integer array containing the global Node Ids
		/// is not included when the new Exodus II file is written out.  If
		/// you do want to include this array, set WriteOutGlobalNodeIdArray to ON.
		/// </summary>
		// Token: 0x060056BD RID: 22205 RVA: 0x0007D98C File Offset: 0x0007BB8C
		public virtual int GetWriteOutGlobalNodeIdArray()
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_GetWriteOutGlobalNodeIdArray_12(base.GetCppThis());
		}

		// Token: 0x060056BE RID: 22206
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_IgnoreMetaDataWarningOff_13(HandleRef pThis);

		/// <summary>
		/// In certain cases we know that metadata doesn't exist and
		/// we want to ignore that warning.
		/// </summary>
		// Token: 0x060056BF RID: 22207 RVA: 0x0007D9AB File Offset: 0x0007BBAB
		public virtual void IgnoreMetaDataWarningOff()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_IgnoreMetaDataWarningOff_13(base.GetCppThis());
		}

		// Token: 0x060056C0 RID: 22208
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_IgnoreMetaDataWarningOn_14(HandleRef pThis);

		/// <summary>
		/// In certain cases we know that metadata doesn't exist and
		/// we want to ignore that warning.
		/// </summary>
		// Token: 0x060056C1 RID: 22209 RVA: 0x0007D9BA File Offset: 0x0007BBBA
		public virtual void IgnoreMetaDataWarningOn()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_IgnoreMetaDataWarningOn_14(base.GetCppThis());
		}

		// Token: 0x060056C2 RID: 22210
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIWriter_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060056C3 RID: 22211 RVA: 0x0007D9CC File Offset: 0x0007BBCC
		public override int IsA(string type)
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x060056C4 RID: 22212
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIWriter_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060056C5 RID: 22213 RVA: 0x0007D9EC File Offset: 0x0007BBEC
		public new static int IsTypeOf(string type)
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_IsTypeOf_16(type);
		}

		// Token: 0x060056C6 RID: 22214
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIWriter_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060056C7 RID: 22215 RVA: 0x0007DA08 File Offset: 0x0007BC08
		public new vtkExodusIIWriter NewInstance()
		{
			vtkExodusIIWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIIWriter.vtkExodusIIWriter_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusIIWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060056C8 RID: 22216
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIWriter_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060056C9 RID: 22217 RVA: 0x0007DA64 File Offset: 0x0007BC64
		public new static vtkExodusIIWriter SafeDownCast(vtkObjectBase o)
		{
			vtkExodusIIWriter vtkExodusIIWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIIWriter.vtkExodusIIWriter_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExodusIIWriter = (vtkExodusIIWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExodusIIWriter.Register(null);
				}
			}
			return vtkExodusIIWriter;
		}

		// Token: 0x060056CA RID: 22218
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_SetBlockIdArrayName_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// When WriteAllTimeSteps is turned ON, the writer is executed once for
		/// each timestep available from the reader.
		/// </summary>
		// Token: 0x060056CB RID: 22219 RVA: 0x0007DAE3 File Offset: 0x0007BCE3
		public virtual void SetBlockIdArrayName(string _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetBlockIdArrayName_20(base.GetCppThis(), _arg);
		}

		// Token: 0x060056CC RID: 22220
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_SetFileName_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Name for the output file.  If writing in parallel, the number
		/// of processes and the process rank will be appended to the name,
		/// so each process is writing out a separate file.
		/// If not set, this class will make up a file name.
		/// </summary>
		// Token: 0x060056CD RID: 22221 RVA: 0x0007DAF3 File Offset: 0x0007BCF3
		public virtual void SetFileName(string _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetFileName_21(base.GetCppThis(), _arg);
		}

		// Token: 0x060056CE RID: 22222
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_SetGhostLevel_22(HandleRef pThis, int _arg);

		/// <summary>
		/// We never write out ghost cells.  This variable is here to satisfy
		/// the behavior of ParaView on invoking a parallel writer.
		/// </summary>
		// Token: 0x060056CF RID: 22223 RVA: 0x0007DB03 File Offset: 0x0007BD03
		public virtual void SetGhostLevel(int _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetGhostLevel_22(base.GetCppThis(), _arg);
		}

		// Token: 0x060056D0 RID: 22224
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_SetIgnoreMetaDataWarning_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// In certain cases we know that metadata doesn't exist and
		/// we want to ignore that warning.
		/// </summary>
		// Token: 0x060056D1 RID: 22225 RVA: 0x0007DB13 File Offset: 0x0007BD13
		public virtual void SetIgnoreMetaDataWarning(bool _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetIgnoreMetaDataWarning_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060056D2 RID: 22226
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_SetModelMetadata_24(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the vtkModelMetadata object which contains the Exodus file
		/// model information (metadata) absent in the vtkUnstructuredGrid.  If you
		/// have this object, you don't need to set any other values before writing.
		/// (Just the FileName and the Input.)
		/// Note that the vtkExodusReader can create and attach a vtkModelMetadata
		/// object to it's output.  If this has happened, the ExodusIIWriter will
		/// find it and use it.
		/// </summary>
		// Token: 0x060056D3 RID: 22227 RVA: 0x0007DB2C File Offset: 0x0007BD2C
		public void SetModelMetadata(vtkModelMetadata arg0)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetModelMetadata_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060056D4 RID: 22228
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_SetStoreDoubles_25(HandleRef pThis, int _arg);

		/// <summary>
		/// If StoreDoubles is ON, the floating point fields in the Exodus file
		/// will be double precision fields.  The default is determined by the
		/// max precision of the input.  If the field data appears to be doubles,
		/// then StoreDoubles will be ON, otherwise StoreDoubles will be OFF.
		/// </summary>
		// Token: 0x060056D5 RID: 22229 RVA: 0x0007DB5B File Offset: 0x0007BD5B
		public virtual void SetStoreDoubles(int _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetStoreDoubles_25(base.GetCppThis(), _arg);
		}

		// Token: 0x060056D6 RID: 22230
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_SetWriteAllTimeSteps_26(HandleRef pThis, int _arg);

		/// <summary>
		/// When WriteAllTimeSteps is turned ON, the writer is executed once for
		/// each timestep available from the reader.
		/// </summary>
		// Token: 0x060056D7 RID: 22231 RVA: 0x0007DB6B File Offset: 0x0007BD6B
		public virtual void SetWriteAllTimeSteps(int _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetWriteAllTimeSteps_26(base.GetCppThis(), _arg);
		}

		// Token: 0x060056D8 RID: 22232
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_SetWriteOutBlockIdArray_27(HandleRef pThis, int _arg);

		/// <summary>
		/// By default, the integer array containing the global Block Ids of the
		/// cells is not included when the new Exodus II file is written out.  If
		/// you do want to include this array, set WriteOutBlockIdArray to ON.
		/// </summary>
		// Token: 0x060056D9 RID: 22233 RVA: 0x0007DB7B File Offset: 0x0007BD7B
		public virtual void SetWriteOutBlockIdArray(int _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetWriteOutBlockIdArray_27(base.GetCppThis(), _arg);
		}

		// Token: 0x060056DA RID: 22234
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_SetWriteOutGlobalElementIdArray_28(HandleRef pThis, int _arg);

		/// <summary>
		/// By default, the integer array containing the global Element Ids
		/// is not included when the new Exodus II file is written out.  If you
		/// do want to include this array, set WriteOutGlobalElementIdArray to ON.
		/// </summary>
		// Token: 0x060056DB RID: 22235 RVA: 0x0007DB8B File Offset: 0x0007BD8B
		public virtual void SetWriteOutGlobalElementIdArray(int _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetWriteOutGlobalElementIdArray_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060056DC RID: 22236
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_SetWriteOutGlobalNodeIdArray_29(HandleRef pThis, int _arg);

		/// <summary>
		/// By default, the integer array containing the global Node Ids
		/// is not included when the new Exodus II file is written out.  If
		/// you do want to include this array, set WriteOutGlobalNodeIdArray to ON.
		/// </summary>
		// Token: 0x060056DD RID: 22237 RVA: 0x0007DB9B File Offset: 0x0007BD9B
		public virtual void SetWriteOutGlobalNodeIdArray(int _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetWriteOutGlobalNodeIdArray_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060056DE RID: 22238
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_WriteAllTimeStepsOff_30(HandleRef pThis);

		/// <summary>
		/// When WriteAllTimeSteps is turned ON, the writer is executed once for
		/// each timestep available from the reader.
		/// </summary>
		// Token: 0x060056DF RID: 22239 RVA: 0x0007DBAB File Offset: 0x0007BDAB
		public virtual void WriteAllTimeStepsOff()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteAllTimeStepsOff_30(base.GetCppThis());
		}

		// Token: 0x060056E0 RID: 22240
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_WriteAllTimeStepsOn_31(HandleRef pThis);

		/// <summary>
		/// When WriteAllTimeSteps is turned ON, the writer is executed once for
		/// each timestep available from the reader.
		/// </summary>
		// Token: 0x060056E1 RID: 22241 RVA: 0x0007DBBA File Offset: 0x0007BDBA
		public virtual void WriteAllTimeStepsOn()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteAllTimeStepsOn_31(base.GetCppThis());
		}

		// Token: 0x060056E2 RID: 22242
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_WriteOutBlockIdArrayOff_32(HandleRef pThis);

		/// <summary>
		/// By default, the integer array containing the global Block Ids of the
		/// cells is not included when the new Exodus II file is written out.  If
		/// you do want to include this array, set WriteOutBlockIdArray to ON.
		/// </summary>
		// Token: 0x060056E3 RID: 22243 RVA: 0x0007DBC9 File Offset: 0x0007BDC9
		public virtual void WriteOutBlockIdArrayOff()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteOutBlockIdArrayOff_32(base.GetCppThis());
		}

		// Token: 0x060056E4 RID: 22244
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_WriteOutBlockIdArrayOn_33(HandleRef pThis);

		/// <summary>
		/// By default, the integer array containing the global Block Ids of the
		/// cells is not included when the new Exodus II file is written out.  If
		/// you do want to include this array, set WriteOutBlockIdArray to ON.
		/// </summary>
		// Token: 0x060056E5 RID: 22245 RVA: 0x0007DBD8 File Offset: 0x0007BDD8
		public virtual void WriteOutBlockIdArrayOn()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteOutBlockIdArrayOn_33(base.GetCppThis());
		}

		// Token: 0x060056E6 RID: 22246
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_WriteOutGlobalElementIdArrayOff_34(HandleRef pThis);

		/// <summary>
		/// By default, the integer array containing the global Element Ids
		/// is not included when the new Exodus II file is written out.  If you
		/// do want to include this array, set WriteOutGlobalElementIdArray to ON.
		/// </summary>
		// Token: 0x060056E7 RID: 22247 RVA: 0x0007DBE7 File Offset: 0x0007BDE7
		public virtual void WriteOutGlobalElementIdArrayOff()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteOutGlobalElementIdArrayOff_34(base.GetCppThis());
		}

		// Token: 0x060056E8 RID: 22248
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_WriteOutGlobalElementIdArrayOn_35(HandleRef pThis);

		/// <summary>
		/// By default, the integer array containing the global Element Ids
		/// is not included when the new Exodus II file is written out.  If you
		/// do want to include this array, set WriteOutGlobalElementIdArray to ON.
		/// </summary>
		// Token: 0x060056E9 RID: 22249 RVA: 0x0007DBF6 File Offset: 0x0007BDF6
		public virtual void WriteOutGlobalElementIdArrayOn()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteOutGlobalElementIdArrayOn_35(base.GetCppThis());
		}

		// Token: 0x060056EA RID: 22250
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_WriteOutGlobalNodeIdArrayOff_36(HandleRef pThis);

		/// <summary>
		/// By default, the integer array containing the global Node Ids
		/// is not included when the new Exodus II file is written out.  If
		/// you do want to include this array, set WriteOutGlobalNodeIdArray to ON.
		/// </summary>
		// Token: 0x060056EB RID: 22251 RVA: 0x0007DC05 File Offset: 0x0007BE05
		public virtual void WriteOutGlobalNodeIdArrayOff()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteOutGlobalNodeIdArrayOff_36(base.GetCppThis());
		}

		// Token: 0x060056EC RID: 22252
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIWriter_WriteOutGlobalNodeIdArrayOn_37(HandleRef pThis);

		/// <summary>
		/// By default, the integer array containing the global Node Ids
		/// is not included when the new Exodus II file is written out.  If
		/// you do want to include this array, set WriteOutGlobalNodeIdArray to ON.
		/// </summary>
		// Token: 0x060056ED RID: 22253 RVA: 0x0007DC14 File Offset: 0x0007BE14
		public virtual void WriteOutGlobalNodeIdArrayOn()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteOutGlobalNodeIdArrayOn_37(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000819 RID: 2073
		public new const string MRFullTypeName = "Kitware.VTK.vtkExodusIIWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400081A RID: 2074
		public new static readonly string MRClassNameKey = "class vtkExodusIIWriter";
	}
}
