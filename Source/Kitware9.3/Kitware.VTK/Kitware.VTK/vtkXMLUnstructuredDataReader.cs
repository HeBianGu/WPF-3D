using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLUnstructuredDataReader
	/// </summary>
	/// <remarks>
	///    Superclass for unstructured data XML readers.
	///
	/// vtkXMLUnstructuredDataReader provides functionality common to all
	/// unstructured data format readers.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPolyDataReader vtkXMLUnstructuredGridReader
	/// </seealso>
	// Token: 0x020006DF RID: 1759
	public abstract class vtkXMLUnstructuredDataReader : vtkXMLDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060129A3 RID: 76195 RVA: 0x001A2133 File Offset: 0x001A0333
		static vtkXMLUnstructuredDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLUnstructuredDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLUnstructuredDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060129A4 RID: 76196 RVA: 0x001A215B File Offset: 0x001A035B
		public vtkXMLUnstructuredDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060129A5 RID: 76197 RVA: 0x001A2169 File Offset: 0x001A0369
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060129A6 RID: 76198
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLUnstructuredDataReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

		/// <summary>
		/// Setup the reader as if the given update extent were requested by
		/// its output.  This can be used after an UpdateInformation to
		/// validate GetNumberOfPoints() and GetNumberOfCells() without
		/// actually reading data.
		/// </summary>
		// Token: 0x060129A7 RID: 76199 RVA: 0x001A2174 File Offset: 0x001A0374
		public override void CopyOutputInformation(vtkInformation outInfo, int port)
		{
			vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_CopyOutputInformation_01(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), port);
		}

		// Token: 0x060129A8 RID: 76200
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUnstructuredDataReader_GetNumberOfCells_02(HandleRef pThis);

		/// <summary>
		/// Get the number of cells in the output.
		/// </summary>
		// Token: 0x060129A9 RID: 76201 RVA: 0x001A21A4 File Offset: 0x001A03A4
		public override long GetNumberOfCells()
		{
			return vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_GetNumberOfCells_02(base.GetCppThis());
		}

		// Token: 0x060129AA RID: 76202
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUnstructuredDataReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129AB RID: 76203 RVA: 0x001A21C4 File Offset: 0x001A03C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060129AC RID: 76204
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUnstructuredDataReader_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129AD RID: 76205 RVA: 0x001A21E4 File Offset: 0x001A03E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060129AE RID: 76206
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUnstructuredDataReader_GetNumberOfPieces_05(HandleRef pThis);

		/// <summary>
		/// Get the number of pieces in the file
		/// </summary>
		// Token: 0x060129AF RID: 76207 RVA: 0x001A2200 File Offset: 0x001A0400
		public virtual long GetNumberOfPieces()
		{
			return vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_GetNumberOfPieces_05(base.GetCppThis());
		}

		// Token: 0x060129B0 RID: 76208
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUnstructuredDataReader_GetNumberOfPoints_06(HandleRef pThis);

		/// <summary>
		/// Get the number of points in the output.
		/// </summary>
		// Token: 0x060129B1 RID: 76209 RVA: 0x001A2220 File Offset: 0x001A0420
		public override long GetNumberOfPoints()
		{
			return vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_GetNumberOfPoints_06(base.GetCppThis());
		}

		// Token: 0x060129B2 RID: 76210
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUnstructuredDataReader_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129B3 RID: 76211 RVA: 0x001A2240 File Offset: 0x001A0440
		public override int IsA(string type)
		{
			return vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060129B4 RID: 76212
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUnstructuredDataReader_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129B5 RID: 76213 RVA: 0x001A2260 File Offset: 0x001A0460
		public new static int IsTypeOf(string type)
		{
			return vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_IsTypeOf_08(type);
		}

		// Token: 0x060129B6 RID: 76214
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUnstructuredDataReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129B7 RID: 76215 RVA: 0x001A227C File Offset: 0x001A047C
		public new vtkXMLUnstructuredDataReader NewInstance()
		{
			vtkXMLUnstructuredDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUnstructuredDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060129B8 RID: 76216
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUnstructuredDataReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129B9 RID: 76217 RVA: 0x001A22D8 File Offset: 0x001A04D8
		public new static vtkXMLUnstructuredDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLUnstructuredDataReader vtkXMLUnstructuredDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLUnstructuredDataReader = (vtkXMLUnstructuredDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLUnstructuredDataReader.Register(null);
				}
			}
			return vtkXMLUnstructuredDataReader;
		}

		// Token: 0x060129BA RID: 76218
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLUnstructuredDataReader_SetupUpdateExtent_11(HandleRef pThis, int piece, int numberOfPieces, int ghostLevel);

		/// <summary>
		/// Setup the reader as if the given update extent were requested by
		/// its output.  This can be used after an UpdateInformation to
		/// validate GetNumberOfPoints() and GetNumberOfCells() without
		/// actually reading data.
		/// </summary>
		// Token: 0x060129BB RID: 76219 RVA: 0x001A2357 File Offset: 0x001A0557
		public void SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)
		{
			vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_SetupUpdateExtent_11(base.GetCppThis(), piece, numberOfPieces, ghostLevel);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400156F RID: 5487
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLUnstructuredDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001570 RID: 5488
		public new static readonly string MRClassNameKey = "class vtkXMLUnstructuredDataReader";
	}
}
