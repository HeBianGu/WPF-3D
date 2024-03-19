using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMFIXReader
	/// </summary>
	/// <remarks>
	///    reads a dataset in MFIX file format
	///
	/// vtkMFIXReader creates an unstructured grid dataset. It reads a restart
	/// file and a set of sp files.  The restart file contains the mesh
	/// information.  MFIX meshes are either cylindrical or rectilinear, but
	/// this reader will convert them to an unstructured grid.  The sp files
	/// contain transient data for the cells.  Each sp file has one or more
	/// variables stored inside it.
	///
	/// @par Thanks:
	/// Thanks to Phil Nicoletti and Brian Dotson at the National Energy
	/// Technology Laboratory who developed this class.
	/// Please address all comments to Brian Dotson (brian.dotson@netl.doe.gov)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGAMBITReader
	/// </seealso>
	// Token: 0x0200020A RID: 522
	public class vtkMFIXReader : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060063D8 RID: 25560 RVA: 0x0008FB27 File Offset: 0x0008DD27
		static vtkMFIXReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMFIXReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMFIXReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060063D9 RID: 25561 RVA: 0x0008FB4F File Offset: 0x0008DD4F
		public vtkMFIXReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060063DA RID: 25562
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMFIXReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060063DB RID: 25563 RVA: 0x0008FB60 File Offset: 0x0008DD60
		public new static vtkMFIXReader New()
		{
			vtkMFIXReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMFIXReader.vtkMFIXReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMFIXReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060063DC RID: 25564 RVA: 0x0008FBB4 File Offset: 0x0008DDB4
		public vtkMFIXReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMFIXReader.vtkMFIXReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060063DD RID: 25565 RVA: 0x0008FBF8 File Offset: 0x0008DDF8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060063DE RID: 25566
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMFIXReader_DisableAllCellArrays_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off all cell arrays.
		/// </summary>
		// Token: 0x060063DF RID: 25567 RVA: 0x0008FC03 File Offset: 0x0008DE03
		public void DisableAllCellArrays()
		{
			vtkMFIXReader.vtkMFIXReader_DisableAllCellArrays_01(base.GetCppThis());
		}

		// Token: 0x060063E0 RID: 25568
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMFIXReader_EnableAllCellArrays_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off all cell arrays.
		/// </summary>
		// Token: 0x060063E1 RID: 25569 RVA: 0x0008FC12 File Offset: 0x0008DE12
		public void EnableAllCellArrays()
		{
			vtkMFIXReader.vtkMFIXReader_EnableAllCellArrays_02(base.GetCppThis());
		}

		// Token: 0x060063E2 RID: 25570
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMFIXReader_GetCellArrayName_03(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the cell array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x060063E3 RID: 25571 RVA: 0x0008FC24 File Offset: 0x0008DE24
		public string GetCellArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkMFIXReader.vtkMFIXReader_GetCellArrayName_03(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060063E4 RID: 25572
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMFIXReader_GetCellArrayStatus_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x060063E5 RID: 25573 RVA: 0x0008FC60 File Offset: 0x0008DE60
		public int GetCellArrayStatus(string name)
		{
			return vtkMFIXReader.vtkMFIXReader_GetCellArrayStatus_04(base.GetCppThis(), name);
		}

		// Token: 0x060063E6 RID: 25574
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMFIXReader_GetCellDataRange_05(HandleRef pThis, int cellComp, IntPtr min, IntPtr max);

		/// <summary>
		/// Get the range of cell data.
		/// </summary>
		// Token: 0x060063E7 RID: 25575 RVA: 0x0008FC80 File Offset: 0x0008DE80
		public void GetCellDataRange(int cellComp, IntPtr min, IntPtr max)
		{
			vtkMFIXReader.vtkMFIXReader_GetCellDataRange_05(base.GetCppThis(), cellComp, min, max);
		}

		// Token: 0x060063E8 RID: 25576
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMFIXReader_GetFileName_06(HandleRef pThis);

		/// <summary>
		/// Specify the file name of the MFIX Restart data file to read.
		/// </summary>
		// Token: 0x060063E9 RID: 25577 RVA: 0x0008FC94 File Offset: 0x0008DE94
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMFIXReader.vtkMFIXReader_GetFileName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060063EA RID: 25578
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMFIXReader_GetNumberOfCellArrays_07(HandleRef pThis);

		/// <summary>
		/// Get the number of cell arrays available in the input.
		/// </summary>
		// Token: 0x060063EB RID: 25579 RVA: 0x0008FCD0 File Offset: 0x0008DED0
		public int GetNumberOfCellArrays()
		{
			return vtkMFIXReader.vtkMFIXReader_GetNumberOfCellArrays_07(base.GetCppThis());
		}

		// Token: 0x060063EC RID: 25580
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMFIXReader_GetNumberOfCellFields_08(HandleRef pThis);

		/// <summary>
		/// Get the number of data components at the nodes and cells.
		/// </summary>
		// Token: 0x060063ED RID: 25581 RVA: 0x0008FCF0 File Offset: 0x0008DEF0
		public virtual int GetNumberOfCellFields()
		{
			return vtkMFIXReader.vtkMFIXReader_GetNumberOfCellFields_08(base.GetCppThis());
		}

		// Token: 0x060063EE RID: 25582
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMFIXReader_GetNumberOfCells_09(HandleRef pThis);

		/// <summary>
		/// Get the total number of cells. The number of cells is only valid after a
		/// successful read of the data file is performed.
		/// </summary>
		// Token: 0x060063EF RID: 25583 RVA: 0x0008FD10 File Offset: 0x0008DF10
		public virtual int GetNumberOfCells()
		{
			return vtkMFIXReader.vtkMFIXReader_GetNumberOfCells_09(base.GetCppThis());
		}

		// Token: 0x060063F0 RID: 25584
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMFIXReader_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060063F1 RID: 25585 RVA: 0x0008FD30 File Offset: 0x0008DF30
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMFIXReader.vtkMFIXReader_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x060063F2 RID: 25586
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMFIXReader_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060063F3 RID: 25587 RVA: 0x0008FD50 File Offset: 0x0008DF50
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMFIXReader.vtkMFIXReader_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x060063F4 RID: 25588
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMFIXReader_GetNumberOfPoints_12(HandleRef pThis);

		/// <summary>
		/// Get the total number of nodes. The number of nodes is only valid after a
		/// successful read of the data file is performed.
		/// </summary>
		// Token: 0x060063F5 RID: 25589 RVA: 0x0008FD6C File Offset: 0x0008DF6C
		public virtual int GetNumberOfPoints()
		{
			return vtkMFIXReader.vtkMFIXReader_GetNumberOfPoints_12(base.GetCppThis());
		}

		// Token: 0x060063F6 RID: 25590
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMFIXReader_GetNumberOfTimeSteps_13(HandleRef pThis);

		/// <summary>
		/// Returns the number of timesteps.
		/// </summary>
		// Token: 0x060063F7 RID: 25591 RVA: 0x0008FD8C File Offset: 0x0008DF8C
		public virtual int GetNumberOfTimeSteps()
		{
			return vtkMFIXReader.vtkMFIXReader_GetNumberOfTimeSteps_13(base.GetCppThis());
		}

		// Token: 0x060063F8 RID: 25592
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMFIXReader_GetTimeStep_14(HandleRef pThis);

		/// <summary>
		/// Which TimeStep to read.
		/// </summary>
		// Token: 0x060063F9 RID: 25593 RVA: 0x0008FDAC File Offset: 0x0008DFAC
		public virtual int GetTimeStep()
		{
			return vtkMFIXReader.vtkMFIXReader_GetTimeStep_14(base.GetCppThis());
		}

		// Token: 0x060063FA RID: 25594
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMFIXReader_GetTimeStepRange_15(HandleRef pThis);

		/// <summary>
		/// Which TimeStepRange to read
		/// </summary>
		// Token: 0x060063FB RID: 25595 RVA: 0x0008FDCC File Offset: 0x0008DFCC
		public virtual int[] GetTimeStepRange()
		{
			IntPtr intPtr = vtkMFIXReader.vtkMFIXReader_GetTimeStepRange_15(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060063FC RID: 25596
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMFIXReader_GetTimeStepRange_16(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Which TimeStepRange to read
		/// </summary>
		// Token: 0x060063FD RID: 25597 RVA: 0x0008FE14 File Offset: 0x0008E014
		public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
		{
			vtkMFIXReader.vtkMFIXReader_GetTimeStepRange_16(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060063FE RID: 25598
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMFIXReader_GetTimeStepRange_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Which TimeStepRange to read
		/// </summary>
		// Token: 0x060063FF RID: 25599 RVA: 0x0008FE25 File Offset: 0x0008E025
		public virtual void GetTimeStepRange(IntPtr _arg)
		{
			vtkMFIXReader.vtkMFIXReader_GetTimeStepRange_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06006400 RID: 25600
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMFIXReader_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006401 RID: 25601 RVA: 0x0008FE38 File Offset: 0x0008E038
		public override int IsA(string type)
		{
			return vtkMFIXReader.vtkMFIXReader_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x06006402 RID: 25602
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMFIXReader_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006403 RID: 25603 RVA: 0x0008FE58 File Offset: 0x0008E058
		public new static int IsTypeOf(string type)
		{
			return vtkMFIXReader.vtkMFIXReader_IsTypeOf_19(type);
		}

		// Token: 0x06006404 RID: 25604
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMFIXReader_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006405 RID: 25605 RVA: 0x0008FE74 File Offset: 0x0008E074
		public new vtkMFIXReader NewInstance()
		{
			vtkMFIXReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMFIXReader.vtkMFIXReader_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMFIXReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006406 RID: 25606
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMFIXReader_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006407 RID: 25607 RVA: 0x0008FED0 File Offset: 0x0008E0D0
		public new static vtkMFIXReader SafeDownCast(vtkObjectBase o)
		{
			vtkMFIXReader vtkMFIXReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMFIXReader.vtkMFIXReader_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMFIXReader = (vtkMFIXReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMFIXReader.Register(null);
				}
			}
			return vtkMFIXReader;
		}

		// Token: 0x06006408 RID: 25608
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMFIXReader_SetCellArrayStatus_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x06006409 RID: 25609 RVA: 0x0008FF4F File Offset: 0x0008E14F
		public void SetCellArrayStatus(string name, int status)
		{
			vtkMFIXReader.vtkMFIXReader_SetCellArrayStatus_23(base.GetCppThis(), name, status);
		}

		// Token: 0x0600640A RID: 25610
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMFIXReader_SetFileName_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the file name of the MFIX Restart data file to read.
		/// </summary>
		// Token: 0x0600640B RID: 25611 RVA: 0x0008FF60 File Offset: 0x0008E160
		public virtual void SetFileName(string _arg)
		{
			vtkMFIXReader.vtkMFIXReader_SetFileName_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600640C RID: 25612
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMFIXReader_SetTimeStep_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Which TimeStep to read.
		/// </summary>
		// Token: 0x0600640D RID: 25613 RVA: 0x0008FF70 File Offset: 0x0008E170
		public virtual void SetTimeStep(int _arg)
		{
			vtkMFIXReader.vtkMFIXReader_SetTimeStep_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600640E RID: 25614
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMFIXReader_SetTimeStepRange_26(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Which TimeStepRange to read
		/// </summary>
		// Token: 0x0600640F RID: 25615 RVA: 0x0008FF80 File Offset: 0x0008E180
		public virtual void SetTimeStepRange(int _arg1, int _arg2)
		{
			vtkMFIXReader.vtkMFIXReader_SetTimeStepRange_26(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06006410 RID: 25616
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMFIXReader_SetTimeStepRange_27(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Which TimeStepRange to read
		/// </summary>
		// Token: 0x06006411 RID: 25617 RVA: 0x0008FF91 File Offset: 0x0008E191
		public void SetTimeStepRange(IntPtr _arg)
		{
			vtkMFIXReader.vtkMFIXReader_SetTimeStepRange_27(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008EB RID: 2283
		public new const string MRFullTypeName = "Kitware.VTK.vtkMFIXReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008EC RID: 2284
		public new static readonly string MRClassNameKey = "class vtkMFIXReader";
	}
}
