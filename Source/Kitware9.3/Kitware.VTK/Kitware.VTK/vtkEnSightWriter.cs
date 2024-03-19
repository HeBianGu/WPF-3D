using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEnSightWriter
	/// </summary>
	/// <remarks>
	///    write vtk unstructured grid data as an EnSight file
	///
	/// vtkEnSightWriter is a source object that writes binary
	/// unstructured grid data files in EnSight format. See EnSight Manual for
	/// format details
	///
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// Be sure to specify the endian-ness of the file when reading it into EnSight
	/// </remarks>
	// Token: 0x02000151 RID: 337
	public class vtkEnSightWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600401A RID: 16410 RVA: 0x0005E3C3 File Offset: 0x0005C5C3
		static vtkEnSightWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEnSightWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSightWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600401B RID: 16411 RVA: 0x0005E3EB File Offset: 0x0005C5EB
		public vtkEnSightWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600401C RID: 16412
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///
		/// </summary>
		// Token: 0x0600401D RID: 16413 RVA: 0x0005E3FC File Offset: 0x0005C5FC
		public new static vtkEnSightWriter New()
		{
			vtkEnSightWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSightWriter.vtkEnSightWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///
		/// </summary>
		// Token: 0x0600401E RID: 16414 RVA: 0x0005E450 File Offset: 0x0005C650
		public vtkEnSightWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEnSightWriter.vtkEnSightWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600401F RID: 16415 RVA: 0x0005E494 File Offset: 0x0005C694
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004020 RID: 16416
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightWriter_GetBaseName_01(HandleRef pThis);

		/// <summary>
		/// Specify base name of EnSight data files to write.
		/// </summary>
		// Token: 0x06004021 RID: 16417 RVA: 0x0005E4A0 File Offset: 0x0005C6A0
		public virtual string GetBaseName()
		{
			string s = Marshal.PtrToStringAnsi(vtkEnSightWriter.vtkEnSightWriter_GetBaseName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004022 RID: 16418
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightWriter_GetBlockIDs_02(HandleRef pThis);

		/// <summary>
		/// set the array of Block ID's
		/// this class keeps a reference to the array and will not delete it
		/// </summary>
		// Token: 0x06004023 RID: 16419 RVA: 0x0005E4DC File Offset: 0x0005C6DC
		public virtual IntPtr GetBlockIDs()
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetBlockIDs_02(base.GetCppThis());
		}

		// Token: 0x06004024 RID: 16420
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightWriter_GetFileName_03(HandleRef pThis);

		/// <summary>
		/// Specify the path and base name of the output files.
		/// </summary>
		// Token: 0x06004025 RID: 16421 RVA: 0x0005E4FC File Offset: 0x0005C6FC
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkEnSightWriter.vtkEnSightWriter_GetFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004026 RID: 16422
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightWriter_GetGhostLevel_04(HandleRef pThis);

		/// <summary>
		/// Specify the number of ghost levels to include in output files
		/// </summary>
		// Token: 0x06004027 RID: 16423 RVA: 0x0005E538 File Offset: 0x0005C738
		public virtual int GetGhostLevel()
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetGhostLevel_04(base.GetCppThis());
		}

		// Token: 0x06004028 RID: 16424
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightWriter_GetInput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the input data or filter.
		/// </summary>
		// Token: 0x06004029 RID: 16425 RVA: 0x0005E558 File Offset: 0x0005C758
		public new virtual vtkUnstructuredGrid GetInput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSightWriter.vtkEnSightWriter_GetInput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x0600402A RID: 16426
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightWriter_GetNumberOfBlocks_06(HandleRef pThis);

		/// <summary>
		/// set the number of block ID's
		/// </summary>
		// Token: 0x0600402B RID: 16427 RVA: 0x0005E5C8 File Offset: 0x0005C7C8
		public virtual int GetNumberOfBlocks()
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetNumberOfBlocks_06(base.GetCppThis());
		}

		// Token: 0x0600402C RID: 16428
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnSightWriter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600402D RID: 16429 RVA: 0x0005E5E8 File Offset: 0x0005C7E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600402E RID: 16430
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnSightWriter_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600402F RID: 16431 RVA: 0x0005E608 File Offset: 0x0005C808
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06004030 RID: 16432
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightWriter_GetPath_09(HandleRef pThis);

		/// <summary>
		/// Specify path of EnSight data files to write.
		/// </summary>
		// Token: 0x06004031 RID: 16433 RVA: 0x0005E624 File Offset: 0x0005C824
		public virtual string GetPath()
		{
			string s = Marshal.PtrToStringAnsi(vtkEnSightWriter.vtkEnSightWriter_GetPath_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004032 RID: 16434
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightWriter_GetProcessNumber_10(HandleRef pThis);

		/// <summary>
		/// Specify which process this writer is
		/// </summary>
		// Token: 0x06004033 RID: 16435 RVA: 0x0005E660 File Offset: 0x0005C860
		public virtual int GetProcessNumber()
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetProcessNumber_10(base.GetCppThis());
		}

		// Token: 0x06004034 RID: 16436
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightWriter_GetTimeStep_11(HandleRef pThis);

		/// <summary>
		/// Specify the Timestep that this data is for
		/// </summary>
		// Token: 0x06004035 RID: 16437 RVA: 0x0005E680 File Offset: 0x0005C880
		public virtual int GetTimeStep()
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetTimeStep_11(base.GetCppThis());
		}

		// Token: 0x06004036 RID: 16438
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkEnSightWriter_GetTransientGeometry_12(HandleRef pThis);

		/// <summary>
		/// Specify whether the geometry changes each timestep
		/// if false, geometry is only written at timestep 0
		/// </summary>
		// Token: 0x06004037 RID: 16439 RVA: 0x0005E6A0 File Offset: 0x0005C8A0
		public virtual bool GetTransientGeometry()
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetTransientGeometry_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06004038 RID: 16440
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkEnSightWriter_GetWriteElementIDs_13(HandleRef pThis);

		/// <summary>
		/// Turn on/off writing element IDs (default: on).
		/// If this is on, geometry files will contain element IDs for each part
		/// (&lt;code&gt;element id given&lt;/code&gt;), otherwise element IDs are omitted
		/// (&lt;code&gt;element id off&lt;/code&gt;).
		///
		/// The EnSight element IDs correspond to VTK cell IDs in the input dataset.
		/// </summary>
		// Token: 0x06004039 RID: 16441 RVA: 0x0005E6C8 File Offset: 0x0005C8C8
		public virtual bool GetWriteElementIDs()
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetWriteElementIDs_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0600403A RID: 16442
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkEnSightWriter_GetWriteNodeIDs_14(HandleRef pThis);

		/// <summary>
		/// Turn on/off writing node IDs (default: on).
		/// If this is on, geometry files will contain node IDs for each part
		/// (&lt;code&gt;node id given&lt;/code&gt;), otherwise node IDs are omitted
		/// (&lt;code&gt;node id off&lt;/code&gt;).
		///
		/// The EnSight node IDs correspond to VTK point IDs in the input dataset.
		/// </summary>
		// Token: 0x0600403B RID: 16443 RVA: 0x0005E6F0 File Offset: 0x0005C8F0
		public virtual bool GetWriteNodeIDs()
		{
			return vtkEnSightWriter.vtkEnSightWriter_GetWriteNodeIDs_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0600403C RID: 16444
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightWriter_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600403D RID: 16445 RVA: 0x0005E718 File Offset: 0x0005C918
		public override int IsA(string type)
		{
			return vtkEnSightWriter.vtkEnSightWriter_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x0600403E RID: 16446
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnSightWriter_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600403F RID: 16447 RVA: 0x0005E738 File Offset: 0x0005C938
		public new static int IsTypeOf(string type)
		{
			return vtkEnSightWriter.vtkEnSightWriter_IsTypeOf_16(type);
		}

		// Token: 0x06004040 RID: 16448
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightWriter_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004041 RID: 16449 RVA: 0x0005E754 File Offset: 0x0005C954
		public new vtkEnSightWriter NewInstance()
		{
			vtkEnSightWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSightWriter.vtkEnSightWriter_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004042 RID: 16450
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnSightWriter_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004043 RID: 16451 RVA: 0x0005E7B0 File Offset: 0x0005C9B0
		public new static vtkEnSightWriter SafeDownCast(vtkObjectBase o)
		{
			vtkEnSightWriter vtkEnSightWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnSightWriter.vtkEnSightWriter_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEnSightWriter = (vtkEnSightWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEnSightWriter.Register(null);
				}
			}
			return vtkEnSightWriter;
		}

		// Token: 0x06004044 RID: 16452
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_SetBaseName_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify base name of EnSight data files to write.
		/// </summary>
		// Token: 0x06004045 RID: 16453 RVA: 0x0005E82F File Offset: 0x0005CA2F
		public virtual void SetBaseName(string _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetBaseName_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06004046 RID: 16454
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_SetBlockIDs_21(HandleRef pThis, IntPtr val);

		/// <summary>
		/// set the array of Block ID's
		/// this class keeps a reference to the array and will not delete it
		/// </summary>
		// Token: 0x06004047 RID: 16455 RVA: 0x0005E83F File Offset: 0x0005CA3F
		public virtual void SetBlockIDs(IntPtr val)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetBlockIDs_21(base.GetCppThis(), val);
		}

		// Token: 0x06004048 RID: 16456
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_SetFileName_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the path and base name of the output files.
		/// </summary>
		// Token: 0x06004049 RID: 16457 RVA: 0x0005E84F File Offset: 0x0005CA4F
		public virtual void SetFileName(string _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetFileName_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600404A RID: 16458
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_SetGhostLevel_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of ghost levels to include in output files
		/// </summary>
		// Token: 0x0600404B RID: 16459 RVA: 0x0005E85F File Offset: 0x0005CA5F
		public virtual void SetGhostLevel(int _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetGhostLevel_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600404C RID: 16460
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_SetInputData_24(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Specify the input data or filter.
		/// </summary>
		// Token: 0x0600404D RID: 16461 RVA: 0x0005E870 File Offset: 0x0005CA70
		public virtual void SetInputData(vtkUnstructuredGrid input)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetInputData_24(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0600404E RID: 16462
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_SetNumberOfBlocks_25(HandleRef pThis, int _arg);

		/// <summary>
		/// set the number of block ID's
		/// </summary>
		// Token: 0x0600404F RID: 16463 RVA: 0x0005E89F File Offset: 0x0005CA9F
		public virtual void SetNumberOfBlocks(int _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetNumberOfBlocks_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06004050 RID: 16464
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_SetPath_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify path of EnSight data files to write.
		/// </summary>
		// Token: 0x06004051 RID: 16465 RVA: 0x0005E8AF File Offset: 0x0005CAAF
		public virtual void SetPath(string _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetPath_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06004052 RID: 16466
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_SetProcessNumber_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify which process this writer is
		/// </summary>
		// Token: 0x06004053 RID: 16467 RVA: 0x0005E8BF File Offset: 0x0005CABF
		public virtual void SetProcessNumber(int _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetProcessNumber_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06004054 RID: 16468
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_SetTimeStep_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the Timestep that this data is for
		/// </summary>
		// Token: 0x06004055 RID: 16469 RVA: 0x0005E8CF File Offset: 0x0005CACF
		public virtual void SetTimeStep(int _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetTimeStep_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06004056 RID: 16470
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_SetTransientGeometry_29(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether the geometry changes each timestep
		/// if false, geometry is only written at timestep 0
		/// </summary>
		// Token: 0x06004057 RID: 16471 RVA: 0x0005E8DF File Offset: 0x0005CADF
		public virtual void SetTransientGeometry(bool _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetTransientGeometry_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004058 RID: 16472
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_SetWriteElementIDs_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off writing element IDs (default: on).
		/// If this is on, geometry files will contain element IDs for each part
		/// (&lt;code&gt;element id given&lt;/code&gt;), otherwise element IDs are omitted
		/// (&lt;code&gt;element id off&lt;/code&gt;).
		///
		/// The EnSight element IDs correspond to VTK cell IDs in the input dataset.
		/// </summary>
		// Token: 0x06004059 RID: 16473 RVA: 0x0005E8F7 File Offset: 0x0005CAF7
		public virtual void SetWriteElementIDs(bool _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetWriteElementIDs_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600405A RID: 16474
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_SetWriteNodeIDs_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off writing node IDs (default: on).
		/// If this is on, geometry files will contain node IDs for each part
		/// (&lt;code&gt;node id given&lt;/code&gt;), otherwise node IDs are omitted
		/// (&lt;code&gt;node id off&lt;/code&gt;).
		///
		/// The EnSight node IDs correspond to VTK point IDs in the input dataset.
		/// </summary>
		// Token: 0x0600405B RID: 16475 RVA: 0x0005E90F File Offset: 0x0005CB0F
		public virtual void SetWriteNodeIDs(bool _arg)
		{
			vtkEnSightWriter.vtkEnSightWriter_SetWriteNodeIDs_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600405C RID: 16476
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_WriteCaseFile_32(HandleRef pThis, int TotalTimeSteps);

		/// <summary>
		/// Writes the case file that EnSight is capable of reading
		/// The other data files must be written before the case file
		/// and the input must be one of the time steps
		/// variables must be the same for all time steps or the case file will be
		/// missing variables
		/// </summary>
		// Token: 0x0600405D RID: 16477 RVA: 0x0005E927 File Offset: 0x0005CB27
		public virtual void WriteCaseFile(int TotalTimeSteps)
		{
			vtkEnSightWriter.vtkEnSightWriter_WriteCaseFile_32(base.GetCppThis(), TotalTimeSteps);
		}

		// Token: 0x0600405E RID: 16478
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_WriteElementIDsOff_33(HandleRef pThis);

		/// <summary>
		/// Turn on/off writing element IDs (default: on).
		/// If this is on, geometry files will contain element IDs for each part
		/// (&lt;code&gt;element id given&lt;/code&gt;), otherwise element IDs are omitted
		/// (&lt;code&gt;element id off&lt;/code&gt;).
		///
		/// The EnSight element IDs correspond to VTK cell IDs in the input dataset.
		/// </summary>
		// Token: 0x0600405F RID: 16479 RVA: 0x0005E937 File Offset: 0x0005CB37
		public virtual void WriteElementIDsOff()
		{
			vtkEnSightWriter.vtkEnSightWriter_WriteElementIDsOff_33(base.GetCppThis());
		}

		// Token: 0x06004060 RID: 16480
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_WriteElementIDsOn_34(HandleRef pThis);

		/// <summary>
		/// Turn on/off writing element IDs (default: on).
		/// If this is on, geometry files will contain element IDs for each part
		/// (&lt;code&gt;element id given&lt;/code&gt;), otherwise element IDs are omitted
		/// (&lt;code&gt;element id off&lt;/code&gt;).
		///
		/// The EnSight element IDs correspond to VTK cell IDs in the input dataset.
		/// </summary>
		// Token: 0x06004061 RID: 16481 RVA: 0x0005E946 File Offset: 0x0005CB46
		public virtual void WriteElementIDsOn()
		{
			vtkEnSightWriter.vtkEnSightWriter_WriteElementIDsOn_34(base.GetCppThis());
		}

		// Token: 0x06004062 RID: 16482
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_WriteNodeIDsOff_35(HandleRef pThis);

		/// <summary>
		/// Turn on/off writing node IDs (default: on).
		/// If this is on, geometry files will contain node IDs for each part
		/// (&lt;code&gt;node id given&lt;/code&gt;), otherwise node IDs are omitted
		/// (&lt;code&gt;node id off&lt;/code&gt;).
		///
		/// The EnSight node IDs correspond to VTK point IDs in the input dataset.
		/// </summary>
		// Token: 0x06004063 RID: 16483 RVA: 0x0005E955 File Offset: 0x0005CB55
		public virtual void WriteNodeIDsOff()
		{
			vtkEnSightWriter.vtkEnSightWriter_WriteNodeIDsOff_35(base.GetCppThis());
		}

		// Token: 0x06004064 RID: 16484
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_WriteNodeIDsOn_36(HandleRef pThis);

		/// <summary>
		/// Turn on/off writing node IDs (default: on).
		/// If this is on, geometry files will contain node IDs for each part
		/// (&lt;code&gt;node id given&lt;/code&gt;), otherwise node IDs are omitted
		/// (&lt;code&gt;node id off&lt;/code&gt;).
		///
		/// The EnSight node IDs correspond to VTK point IDs in the input dataset.
		/// </summary>
		// Token: 0x06004065 RID: 16485 RVA: 0x0005E964 File Offset: 0x0005CB64
		public virtual void WriteNodeIDsOn()
		{
			vtkEnSightWriter.vtkEnSightWriter_WriteNodeIDsOn_36(base.GetCppThis());
		}

		// Token: 0x06004066 RID: 16486
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnSightWriter_WriteSOSCaseFile_37(HandleRef pThis, int NumProcs);

		/// <summary>
		/// Writes the case file that EnSight is capable of reading
		/// The other data files must be written before the case file
		/// and the input must be one of the time steps
		/// variables must be the same for all time steps or the case file will be
		/// missing variables
		/// </summary>
		// Token: 0x06004067 RID: 16487 RVA: 0x0005E973 File Offset: 0x0005CB73
		public virtual void WriteSOSCaseFile(int NumProcs)
		{
			vtkEnSightWriter.vtkEnSightWriter_WriteSOSCaseFile_37(base.GetCppThis(), NumProcs);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006E6 RID: 1766
		public new const string MRFullTypeName = "Kitware.VTK.vtkEnSightWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006E7 RID: 1767
		public new static readonly string MRClassNameKey = "class vtkEnSightWriter";
	}
}
