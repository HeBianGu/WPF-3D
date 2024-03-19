using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXYZMolReader
	/// </summary>
	/// <remarks>
	///    read Molecular Data files
	///
	/// vtkXYZMolReader is a source object that reads Molecule files
	/// The FileName must be specified
	///
	/// @par Thanks:
	/// Dr. Jean M. Favre who developed and contributed this class
	/// </remarks>
	// Token: 0x020001D3 RID: 467
	public class vtkXYZMolReader : vtkMoleculeReaderBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060059DC RID: 23004 RVA: 0x00081F4B File Offset: 0x0008014B
		static vtkXYZMolReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXYZMolReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXYZMolReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060059DD RID: 23005 RVA: 0x00081F73 File Offset: 0x00080173
		public vtkXYZMolReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060059DE RID: 23006
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXYZMolReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059DF RID: 23007 RVA: 0x00081F84 File Offset: 0x00080184
		public new static vtkXYZMolReader New()
		{
			vtkXYZMolReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXYZMolReader.vtkXYZMolReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXYZMolReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059E0 RID: 23008 RVA: 0x00081FD8 File Offset: 0x000801D8
		public vtkXYZMolReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXYZMolReader.vtkXYZMolReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060059E1 RID: 23009 RVA: 0x0008201C File Offset: 0x0008021C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060059E2 RID: 23010
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXYZMolReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Test whether the file with the given name can be read by this
		/// reader.
		/// </summary>
		// Token: 0x060059E3 RID: 23011 RVA: 0x00082028 File Offset: 0x00080228
		public virtual int CanReadFile(string name)
		{
			return vtkXYZMolReader.vtkXYZMolReader_CanReadFile_01(base.GetCppThis(), name);
		}

		// Token: 0x060059E4 RID: 23012
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXYZMolReader_GetMaxTimeStep_02(HandleRef pThis);

		/// <summary>
		/// Get the maximum time step.
		/// </summary>
		// Token: 0x060059E5 RID: 23013 RVA: 0x00082048 File Offset: 0x00080248
		public virtual int GetMaxTimeStep()
		{
			return vtkXYZMolReader.vtkXYZMolReader_GetMaxTimeStep_02(base.GetCppThis());
		}

		// Token: 0x060059E6 RID: 23014
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXYZMolReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059E7 RID: 23015 RVA: 0x00082068 File Offset: 0x00080268
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXYZMolReader.vtkXYZMolReader_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060059E8 RID: 23016
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXYZMolReader_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059E9 RID: 23017 RVA: 0x00082088 File Offset: 0x00080288
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXYZMolReader.vtkXYZMolReader_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060059EA RID: 23018
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXYZMolReader_GetTimeStep_05(HandleRef pThis);

		/// <summary>
		/// Set the current time step. It should be greater than 0 and smaller than
		/// MaxTimeStep.
		/// </summary>
		// Token: 0x060059EB RID: 23019 RVA: 0x000820A4 File Offset: 0x000802A4
		public virtual int GetTimeStep()
		{
			return vtkXYZMolReader.vtkXYZMolReader_GetTimeStep_05(base.GetCppThis());
		}

		// Token: 0x060059EC RID: 23020
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXYZMolReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059ED RID: 23021 RVA: 0x000820C4 File Offset: 0x000802C4
		public override int IsA(string type)
		{
			return vtkXYZMolReader.vtkXYZMolReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060059EE RID: 23022
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXYZMolReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059EF RID: 23023 RVA: 0x000820E4 File Offset: 0x000802E4
		public new static int IsTypeOf(string type)
		{
			return vtkXYZMolReader.vtkXYZMolReader_IsTypeOf_07(type);
		}

		// Token: 0x060059F0 RID: 23024
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXYZMolReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059F1 RID: 23025 RVA: 0x00082100 File Offset: 0x00080300
		public new vtkXYZMolReader NewInstance()
		{
			vtkXYZMolReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXYZMolReader.vtkXYZMolReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXYZMolReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060059F2 RID: 23026
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXYZMolReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059F3 RID: 23027 RVA: 0x0008215C File Offset: 0x0008035C
		public new static vtkXYZMolReader SafeDownCast(vtkObjectBase o)
		{
			vtkXYZMolReader vtkXYZMolReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXYZMolReader.vtkXYZMolReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXYZMolReader = (vtkXYZMolReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXYZMolReader.Register(null);
				}
			}
			return vtkXYZMolReader;
		}

		// Token: 0x060059F4 RID: 23028
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXYZMolReader_SetTimeStep_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the current time step. It should be greater than 0 and smaller than
		/// MaxTimeStep.
		/// </summary>
		// Token: 0x060059F5 RID: 23029 RVA: 0x000821DB File Offset: 0x000803DB
		public virtual void SetTimeStep(int _arg)
		{
			vtkXYZMolReader.vtkXYZMolReader_SetTimeStep_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400086D RID: 2157
		public new const string MRFullTypeName = "Kitware.VTK.vtkXYZMolReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400086E RID: 2158
		public new static readonly string MRClassNameKey = "class vtkXYZMolReader";
	}
}
