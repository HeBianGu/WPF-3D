using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPUnstructuredDataReader
	/// </summary>
	/// <remarks>
	///    Superclass for parallel unstructured data XML readers.
	///
	/// vtkXMLPUnstructuredDataReader provides functionality common to all
	/// parallel unstructured data format readers.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPPolyDataReader vtkXMLPUnstructuredGridReader
	/// </seealso>
	// Token: 0x020006D7 RID: 1751
	public abstract class vtkXMLPUnstructuredDataReader : vtkXMLPDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060128F4 RID: 76020 RVA: 0x001A0A93 File Offset: 0x0019EC93
		static vtkXMLPUnstructuredDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPUnstructuredDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPUnstructuredDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060128F5 RID: 76021 RVA: 0x001A0ABB File Offset: 0x0019ECBB
		public vtkXMLPUnstructuredDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060128F6 RID: 76022 RVA: 0x001A0AC9 File Offset: 0x0019ECC9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060128F7 RID: 76023
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPUnstructuredDataReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128F8 RID: 76024 RVA: 0x001A0AD4 File Offset: 0x0019ECD4
		public override void CopyOutputInformation(vtkInformation outInfo, int port)
		{
			vtkXMLPUnstructuredDataReader.vtkXMLPUnstructuredDataReader_CopyOutputInformation_01(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), port);
		}

		// Token: 0x060128F9 RID: 76025
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPUnstructuredDataReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128FA RID: 76026 RVA: 0x001A0B04 File Offset: 0x0019ED04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPUnstructuredDataReader.vtkXMLPUnstructuredDataReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060128FB RID: 76027
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPUnstructuredDataReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128FC RID: 76028 RVA: 0x001A0B24 File Offset: 0x0019ED24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPUnstructuredDataReader.vtkXMLPUnstructuredDataReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060128FD RID: 76029
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPUnstructuredDataReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128FE RID: 76030 RVA: 0x001A0B40 File Offset: 0x0019ED40
		public override int IsA(string type)
		{
			return vtkXMLPUnstructuredDataReader.vtkXMLPUnstructuredDataReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060128FF RID: 76031
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPUnstructuredDataReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012900 RID: 76032 RVA: 0x001A0B60 File Offset: 0x0019ED60
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPUnstructuredDataReader.vtkXMLPUnstructuredDataReader_IsTypeOf_05(type);
		}

		// Token: 0x06012901 RID: 76033
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUnstructuredDataReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012902 RID: 76034 RVA: 0x001A0B7C File Offset: 0x0019ED7C
		public new vtkXMLPUnstructuredDataReader NewInstance()
		{
			vtkXMLPUnstructuredDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUnstructuredDataReader.vtkXMLPUnstructuredDataReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPUnstructuredDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012903 RID: 76035
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUnstructuredDataReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012904 RID: 76036 RVA: 0x001A0BD8 File Offset: 0x0019EDD8
		public new static vtkXMLPUnstructuredDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPUnstructuredDataReader vtkXMLPUnstructuredDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUnstructuredDataReader.vtkXMLPUnstructuredDataReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPUnstructuredDataReader = (vtkXMLPUnstructuredDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPUnstructuredDataReader.Register(null);
				}
			}
			return vtkXMLPUnstructuredDataReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400155F RID: 5471
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPUnstructuredDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001560 RID: 5472
		public new static readonly string MRClassNameKey = "class vtkXMLPUnstructuredDataReader";
	}
}
