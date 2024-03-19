using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPDataReader
	/// </summary>
	/// <remarks>
	///    Superclass for PVTK XML file readers that read vtkDataSets.
	///
	/// vtkXMLPDataReader provides functionality common to all PVTK XML
	/// file readers that read vtkDataSets. Concrete subclasses call upon
	/// this functionality when needed.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLDataReader
	/// </seealso>
	// Token: 0x020006D4 RID: 1748
	public abstract class vtkXMLPDataReader : vtkXMLPDataObjectReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060128BA RID: 75962 RVA: 0x001A03CB File Offset: 0x0019E5CB
		static vtkXMLPDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060128BB RID: 75963 RVA: 0x001A03F3 File Offset: 0x0019E5F3
		public vtkXMLPDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060128BC RID: 75964 RVA: 0x001A0401 File Offset: 0x0019E601
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060128BD RID: 75965
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPDataReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

		/// <summary>
		/// For the specified port, copy the information this reader sets up in
		/// SetupOutputInformation to outInfo
		/// </summary>
		// Token: 0x060128BE RID: 75966 RVA: 0x001A040C File Offset: 0x0019E60C
		public override void CopyOutputInformation(vtkInformation outInfo, int port)
		{
			vtkXMLPDataReader.vtkXMLPDataReader_CopyOutputInformation_01(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), port);
		}

		// Token: 0x060128BF RID: 75967
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPDataReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128C0 RID: 75968 RVA: 0x001A043C File Offset: 0x0019E63C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPDataReader.vtkXMLPDataReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060128C1 RID: 75969
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPDataReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128C2 RID: 75970 RVA: 0x001A045C File Offset: 0x0019E65C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPDataReader.vtkXMLPDataReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060128C3 RID: 75971
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128C4 RID: 75972 RVA: 0x001A0478 File Offset: 0x0019E678
		public override int IsA(string type)
		{
			return vtkXMLPDataReader.vtkXMLPDataReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060128C5 RID: 75973
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPDataReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128C6 RID: 75974 RVA: 0x001A0498 File Offset: 0x0019E698
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPDataReader.vtkXMLPDataReader_IsTypeOf_05(type);
		}

		// Token: 0x060128C7 RID: 75975
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPDataReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128C8 RID: 75976 RVA: 0x001A04B4 File Offset: 0x0019E6B4
		public new vtkXMLPDataReader NewInstance()
		{
			vtkXMLPDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPDataReader.vtkXMLPDataReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060128C9 RID: 75977
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPDataReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128CA RID: 75978 RVA: 0x001A0510 File Offset: 0x0019E710
		public new static vtkXMLPDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPDataReader vtkXMLPDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPDataReader.vtkXMLPDataReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPDataReader = (vtkXMLPDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPDataReader.Register(null);
				}
			}
			return vtkXMLPDataReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001559 RID: 5465
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400155A RID: 5466
		public new static readonly string MRClassNameKey = "class vtkXMLPDataReader";
	}
}
