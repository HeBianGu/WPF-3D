using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLHierarchicalBoxDataReader
	/// </summary>
	/// <remarks>
	///    Reader for hierarchical datasets
	/// (for backwards compatibility).
	///
	///
	/// vtkXMLHierarchicalBoxDataReader is an empty subclass of
	/// vtkXMLUniformGridAMRReader. This is only for backwards compatibility. Newer
	/// code should simply use vtkXMLUniformGridAMRReader.
	///
	/// @warning
	/// The reader supports reading v1.1 and above. For older versions, use
	/// vtkXMLHierarchicalBoxDataFileConverter.
	/// </remarks>
	// Token: 0x020006CA RID: 1738
	public class vtkXMLHierarchicalBoxDataReader : vtkXMLUniformGridAMRReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060127DD RID: 75741 RVA: 0x0019EBC3 File Offset: 0x0019CDC3
		static vtkXMLHierarchicalBoxDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLHierarchicalBoxDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLHierarchicalBoxDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060127DE RID: 75742 RVA: 0x0019EBEB File Offset: 0x0019CDEB
		public vtkXMLHierarchicalBoxDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060127DF RID: 75743
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127E0 RID: 75744 RVA: 0x0019EBFC File Offset: 0x0019CDFC
		public new static vtkXMLHierarchicalBoxDataReader New()
		{
			vtkXMLHierarchicalBoxDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLHierarchicalBoxDataReader.vtkXMLHierarchicalBoxDataReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLHierarchicalBoxDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127E1 RID: 75745 RVA: 0x0019EC50 File Offset: 0x0019CE50
		public vtkXMLHierarchicalBoxDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLHierarchicalBoxDataReader.vtkXMLHierarchicalBoxDataReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060127E2 RID: 75746 RVA: 0x0019EC94 File Offset: 0x0019CE94
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060127E3 RID: 75747
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLHierarchicalBoxDataReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127E4 RID: 75748 RVA: 0x0019ECA0 File Offset: 0x0019CEA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLHierarchicalBoxDataReader.vtkXMLHierarchicalBoxDataReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060127E5 RID: 75749
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLHierarchicalBoxDataReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127E6 RID: 75750 RVA: 0x0019ECC0 File Offset: 0x0019CEC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLHierarchicalBoxDataReader.vtkXMLHierarchicalBoxDataReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060127E7 RID: 75751
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLHierarchicalBoxDataReader_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127E8 RID: 75752 RVA: 0x0019ECDC File Offset: 0x0019CEDC
		public override int IsA(string type)
		{
			return vtkXMLHierarchicalBoxDataReader.vtkXMLHierarchicalBoxDataReader_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060127E9 RID: 75753
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLHierarchicalBoxDataReader_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127EA RID: 75754 RVA: 0x0019ECFC File Offset: 0x0019CEFC
		public new static int IsTypeOf(string type)
		{
			return vtkXMLHierarchicalBoxDataReader.vtkXMLHierarchicalBoxDataReader_IsTypeOf_04(type);
		}

		// Token: 0x060127EB RID: 75755
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127EC RID: 75756 RVA: 0x0019ED18 File Offset: 0x0019CF18
		public new vtkXMLHierarchicalBoxDataReader NewInstance()
		{
			vtkXMLHierarchicalBoxDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLHierarchicalBoxDataReader.vtkXMLHierarchicalBoxDataReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLHierarchicalBoxDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060127ED RID: 75757
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127EE RID: 75758 RVA: 0x0019ED74 File Offset: 0x0019CF74
		public new static vtkXMLHierarchicalBoxDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLHierarchicalBoxDataReader vtkXMLHierarchicalBoxDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLHierarchicalBoxDataReader.vtkXMLHierarchicalBoxDataReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLHierarchicalBoxDataReader = (vtkXMLHierarchicalBoxDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLHierarchicalBoxDataReader.Register(null);
				}
			}
			return vtkXMLHierarchicalBoxDataReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001545 RID: 5445
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLHierarchicalBoxDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001546 RID: 5446
		public new static readonly string MRClassNameKey = "class vtkXMLHierarchicalBoxDataReader";
	}
}
