using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPStructuredDataReader
	/// </summary>
	/// <remarks>
	///    Superclass for parallel structured data XML readers.
	///
	/// vtkXMLPStructuredDataReader provides functionality common to all
	/// parallel structured data format readers.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPImageDataReader vtkXMLPStructuredGridReader
	/// vtkXMLPRectilinearGridReader
	/// </seealso>
	// Token: 0x020006D5 RID: 1749
	public abstract class vtkXMLPStructuredDataReader : vtkXMLPDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060128CB RID: 75979 RVA: 0x001A058F File Offset: 0x0019E78F
		static vtkXMLPStructuredDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPStructuredDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPStructuredDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060128CC RID: 75980 RVA: 0x001A05B7 File Offset: 0x0019E7B7
		public vtkXMLPStructuredDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060128CD RID: 75981 RVA: 0x001A05C5 File Offset: 0x0019E7C5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060128CE RID: 75982
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPStructuredDataReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128CF RID: 75983 RVA: 0x001A05D0 File Offset: 0x0019E7D0
		public override void CopyOutputInformation(vtkInformation outInfo, int port)
		{
			vtkXMLPStructuredDataReader.vtkXMLPStructuredDataReader_CopyOutputInformation_01(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), port);
		}

		// Token: 0x060128D0 RID: 75984
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPStructuredDataReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128D1 RID: 75985 RVA: 0x001A0600 File Offset: 0x0019E800
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPStructuredDataReader.vtkXMLPStructuredDataReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060128D2 RID: 75986
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPStructuredDataReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128D3 RID: 75987 RVA: 0x001A0620 File Offset: 0x0019E820
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPStructuredDataReader.vtkXMLPStructuredDataReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060128D4 RID: 75988
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPStructuredDataReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128D5 RID: 75989 RVA: 0x001A063C File Offset: 0x0019E83C
		public override int IsA(string type)
		{
			return vtkXMLPStructuredDataReader.vtkXMLPStructuredDataReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060128D6 RID: 75990
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPStructuredDataReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128D7 RID: 75991 RVA: 0x001A065C File Offset: 0x0019E85C
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPStructuredDataReader.vtkXMLPStructuredDataReader_IsTypeOf_05(type);
		}

		// Token: 0x060128D8 RID: 75992
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPStructuredDataReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128D9 RID: 75993 RVA: 0x001A0678 File Offset: 0x0019E878
		public new vtkXMLPStructuredDataReader NewInstance()
		{
			vtkXMLPStructuredDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPStructuredDataReader.vtkXMLPStructuredDataReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPStructuredDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060128DA RID: 75994
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPStructuredDataReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128DB RID: 75995 RVA: 0x001A06D4 File Offset: 0x0019E8D4
		public new static vtkXMLPStructuredDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPStructuredDataReader vtkXMLPStructuredDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPStructuredDataReader.vtkXMLPStructuredDataReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPStructuredDataReader = (vtkXMLPStructuredDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPStructuredDataReader.Register(null);
				}
			}
			return vtkXMLPStructuredDataReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400155B RID: 5467
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPStructuredDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400155C RID: 5468
		public new static readonly string MRClassNameKey = "class vtkXMLPStructuredDataReader";
	}
}
