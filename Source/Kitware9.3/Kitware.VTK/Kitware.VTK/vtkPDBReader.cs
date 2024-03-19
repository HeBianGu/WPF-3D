using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPDBReader
	/// </summary>
	/// <remarks>
	///    read Molecular Data files
	///
	/// vtkPDBReader is a source object that reads Molecule files
	/// The FileName must be specified
	///
	/// @par Thanks:
	/// Dr. Jean M. Favre who developed and contributed this class
	/// </remarks>
	// Token: 0x020001D0 RID: 464
	public class vtkPDBReader : vtkMoleculeReaderBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600599E RID: 22942 RVA: 0x00081823 File Offset: 0x0007FA23
		static vtkPDBReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPDBReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPDBReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600599F RID: 22943 RVA: 0x0008184B File Offset: 0x0007FA4B
		public vtkPDBReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060059A0 RID: 22944
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDBReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059A1 RID: 22945 RVA: 0x0008185C File Offset: 0x0007FA5C
		public new static vtkPDBReader New()
		{
			vtkPDBReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDBReader.vtkPDBReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDBReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059A2 RID: 22946 RVA: 0x000818B0 File Offset: 0x0007FAB0
		public vtkPDBReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPDBReader.vtkPDBReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060059A3 RID: 22947 RVA: 0x000818F4 File Offset: 0x0007FAF4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060059A4 RID: 22948
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPDBReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059A5 RID: 22949 RVA: 0x00081900 File Offset: 0x0007FB00
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPDBReader.vtkPDBReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060059A6 RID: 22950
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPDBReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059A7 RID: 22951 RVA: 0x00081920 File Offset: 0x0007FB20
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPDBReader.vtkPDBReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060059A8 RID: 22952
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDBReader_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059A9 RID: 22953 RVA: 0x0008193C File Offset: 0x0007FB3C
		public override int IsA(string type)
		{
			return vtkPDBReader.vtkPDBReader_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060059AA RID: 22954
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDBReader_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059AB RID: 22955 RVA: 0x0008195C File Offset: 0x0007FB5C
		public new static int IsTypeOf(string type)
		{
			return vtkPDBReader.vtkPDBReader_IsTypeOf_04(type);
		}

		// Token: 0x060059AC RID: 22956
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDBReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059AD RID: 22957 RVA: 0x00081978 File Offset: 0x0007FB78
		public new vtkPDBReader NewInstance()
		{
			vtkPDBReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDBReader.vtkPDBReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDBReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060059AE RID: 22958
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDBReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059AF RID: 22959 RVA: 0x000819D4 File Offset: 0x0007FBD4
		public new static vtkPDBReader SafeDownCast(vtkObjectBase o)
		{
			vtkPDBReader vtkPDBReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDBReader.vtkPDBReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPDBReader = (vtkPDBReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPDBReader.Register(null);
				}
			}
			return vtkPDBReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000867 RID: 2151
		public new const string MRFullTypeName = "Kitware.VTK.vtkPDBReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000868 RID: 2152
		public new static readonly string MRClassNameKey = "class vtkPDBReader";
	}
}
