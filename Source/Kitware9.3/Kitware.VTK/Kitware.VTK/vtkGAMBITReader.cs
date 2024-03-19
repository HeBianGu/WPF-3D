using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGAMBITReader
	/// </summary>
	/// <remarks>
	///    reads a dataset in Fluent GAMBIT neutral file format
	///
	/// vtkGAMBITReader creates an unstructured grid dataset. It reads ASCII files
	/// stored in GAMBIT neutral format, with optional data stored at the nodes or
	/// at the cells of the model. A cell-based fielddata stores the material id.
	///
	/// @par Thanks:
	/// Thanks to Jean M. Favre (CSCS, Swiss Center for Scientific Computing) who
	/// developed this class.
	/// Please address all comments to Jean Favre (jfavre at cscs.ch)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAVSucdReader
	/// </seealso>
	// Token: 0x020001FF RID: 511
	public class vtkGAMBITReader : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006260 RID: 25184 RVA: 0x0008D99A File Offset: 0x0008BB9A
		static vtkGAMBITReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGAMBITReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGAMBITReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006261 RID: 25185 RVA: 0x0008D9C2 File Offset: 0x0008BBC2
		public vtkGAMBITReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006262 RID: 25186
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGAMBITReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006263 RID: 25187 RVA: 0x0008D9D0 File Offset: 0x0008BBD0
		public new static vtkGAMBITReader New()
		{
			vtkGAMBITReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGAMBITReader.vtkGAMBITReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGAMBITReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006264 RID: 25188 RVA: 0x0008DA24 File Offset: 0x0008BC24
		public vtkGAMBITReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGAMBITReader.vtkGAMBITReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006265 RID: 25189 RVA: 0x0008DA68 File Offset: 0x0008BC68
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006266 RID: 25190
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGAMBITReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Specify the file name of the GAMBIT data file to read.
		/// </summary>
		// Token: 0x06006267 RID: 25191 RVA: 0x0008DA74 File Offset: 0x0008BC74
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGAMBITReader.vtkGAMBITReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006268 RID: 25192
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGAMBITReader_GetNumberOfCellFields_02(HandleRef pThis);

		/// <summary>
		/// Get the number of data components at the nodes and cells.
		/// </summary>
		// Token: 0x06006269 RID: 25193 RVA: 0x0008DAB0 File Offset: 0x0008BCB0
		public virtual int GetNumberOfCellFields()
		{
			return vtkGAMBITReader.vtkGAMBITReader_GetNumberOfCellFields_02(base.GetCppThis());
		}

		// Token: 0x0600626A RID: 25194
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGAMBITReader_GetNumberOfCells_03(HandleRef pThis);

		/// <summary>
		/// Get the total number of cells. The number of cells is only valid after a
		/// successful read of the data file is performed.
		/// </summary>
		// Token: 0x0600626B RID: 25195 RVA: 0x0008DAD0 File Offset: 0x0008BCD0
		public virtual int GetNumberOfCells()
		{
			return vtkGAMBITReader.vtkGAMBITReader_GetNumberOfCells_03(base.GetCppThis());
		}

		// Token: 0x0600626C RID: 25196
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGAMBITReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600626D RID: 25197 RVA: 0x0008DAF0 File Offset: 0x0008BCF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGAMBITReader.vtkGAMBITReader_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600626E RID: 25198
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGAMBITReader_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600626F RID: 25199 RVA: 0x0008DB10 File Offset: 0x0008BD10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGAMBITReader.vtkGAMBITReader_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06006270 RID: 25200
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGAMBITReader_GetNumberOfNodeFields_06(HandleRef pThis);

		/// <summary>
		/// Get the number of data components at the nodes and cells.
		/// </summary>
		// Token: 0x06006271 RID: 25201 RVA: 0x0008DB2C File Offset: 0x0008BD2C
		public virtual int GetNumberOfNodeFields()
		{
			return vtkGAMBITReader.vtkGAMBITReader_GetNumberOfNodeFields_06(base.GetCppThis());
		}

		// Token: 0x06006272 RID: 25202
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGAMBITReader_GetNumberOfNodes_07(HandleRef pThis);

		/// <summary>
		/// Get the total number of nodes. The number of nodes is only valid after a
		/// successful read of the data file is performed.
		/// </summary>
		// Token: 0x06006273 RID: 25203 RVA: 0x0008DB4C File Offset: 0x0008BD4C
		public virtual int GetNumberOfNodes()
		{
			return vtkGAMBITReader.vtkGAMBITReader_GetNumberOfNodes_07(base.GetCppThis());
		}

		// Token: 0x06006274 RID: 25204
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGAMBITReader_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006275 RID: 25205 RVA: 0x0008DB6C File Offset: 0x0008BD6C
		public override int IsA(string type)
		{
			return vtkGAMBITReader.vtkGAMBITReader_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06006276 RID: 25206
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGAMBITReader_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006277 RID: 25207 RVA: 0x0008DB8C File Offset: 0x0008BD8C
		public new static int IsTypeOf(string type)
		{
			return vtkGAMBITReader.vtkGAMBITReader_IsTypeOf_09(type);
		}

		// Token: 0x06006278 RID: 25208
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGAMBITReader_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006279 RID: 25209 RVA: 0x0008DBA8 File Offset: 0x0008BDA8
		public new vtkGAMBITReader NewInstance()
		{
			vtkGAMBITReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGAMBITReader.vtkGAMBITReader_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGAMBITReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600627A RID: 25210
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGAMBITReader_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600627B RID: 25211 RVA: 0x0008DC04 File Offset: 0x0008BE04
		public new static vtkGAMBITReader SafeDownCast(vtkObjectBase o)
		{
			vtkGAMBITReader vtkGAMBITReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGAMBITReader.vtkGAMBITReader_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGAMBITReader = (vtkGAMBITReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGAMBITReader.Register(null);
				}
			}
			return vtkGAMBITReader;
		}

		// Token: 0x0600627C RID: 25212
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGAMBITReader_SetFileName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the file name of the GAMBIT data file to read.
		/// </summary>
		// Token: 0x0600627D RID: 25213 RVA: 0x0008DC83 File Offset: 0x0008BE83
		public virtual void SetFileName(string _arg)
		{
			vtkGAMBITReader.vtkGAMBITReader_SetFileName_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008C8 RID: 2248
		public new const string MRFullTypeName = "Kitware.VTK.vtkGAMBITReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008C9 RID: 2249
		public new static readonly string MRClassNameKey = "class vtkGAMBITReader";
	}
}
