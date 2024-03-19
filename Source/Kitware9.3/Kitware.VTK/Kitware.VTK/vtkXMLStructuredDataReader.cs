using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLStructuredDataReader
	/// </summary>
	/// <remarks>
	///    Superclass for structured data XML readers.
	///
	/// vtkXMLStructuredDataReader provides functionality common to all
	/// structured data format readers.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLImageDataReader vtkXMLStructuredGridReader
	/// vtkXMLRectilinearGridReader
	/// </seealso>
	// Token: 0x020006CF RID: 1743
	public abstract class vtkXMLStructuredDataReader : vtkXMLDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012839 RID: 75833 RVA: 0x0019F6EF File Offset: 0x0019D8EF
		static vtkXMLStructuredDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLStructuredDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLStructuredDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601283A RID: 75834 RVA: 0x0019F717 File Offset: 0x0019D917
		public vtkXMLStructuredDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601283B RID: 75835 RVA: 0x0019F725 File Offset: 0x0019D925
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601283C RID: 75836
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLStructuredDataReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

		/// <summary>
		/// For the specified port, copy the information this reader sets up in
		/// SetupOutputInformation to outInfo
		/// </summary>
		// Token: 0x0601283D RID: 75837 RVA: 0x0019F730 File Offset: 0x0019D930
		public override void CopyOutputInformation(vtkInformation outInfo, int port)
		{
			vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_CopyOutputInformation_01(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), port);
		}

		// Token: 0x0601283E RID: 75838
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLStructuredDataReader_GetNumberOfCells_02(HandleRef pThis);

		/// <summary>
		/// Get the number of cells in the output.
		/// </summary>
		// Token: 0x0601283F RID: 75839 RVA: 0x0019F760 File Offset: 0x0019D960
		public override long GetNumberOfCells()
		{
			return vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_GetNumberOfCells_02(base.GetCppThis());
		}

		// Token: 0x06012840 RID: 75840
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLStructuredDataReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012841 RID: 75841 RVA: 0x0019F780 File Offset: 0x0019D980
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06012842 RID: 75842
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLStructuredDataReader_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012843 RID: 75843 RVA: 0x0019F7A0 File Offset: 0x0019D9A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06012844 RID: 75844
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLStructuredDataReader_GetNumberOfPoints_05(HandleRef pThis);

		/// <summary>
		/// Get the number of points in the output.
		/// </summary>
		// Token: 0x06012845 RID: 75845 RVA: 0x0019F7BC File Offset: 0x0019D9BC
		public override long GetNumberOfPoints()
		{
			return vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_GetNumberOfPoints_05(base.GetCppThis());
		}

		// Token: 0x06012846 RID: 75846
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLStructuredDataReader_GetWholeSlices_06(HandleRef pThis);

		/// <summary>
		/// Get/Set whether the reader gets a whole slice from disk when only
		/// a rectangle inside it is needed.  This mode reads more data than
		/// necessary, but prevents many short reads from interacting poorly
		/// with the compression and encoding schemes.
		/// </summary>
		// Token: 0x06012847 RID: 75847 RVA: 0x0019F7DC File Offset: 0x0019D9DC
		public virtual int GetWholeSlices()
		{
			return vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_GetWholeSlices_06(base.GetCppThis());
		}

		// Token: 0x06012848 RID: 75848
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLStructuredDataReader_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012849 RID: 75849 RVA: 0x0019F7FC File Offset: 0x0019D9FC
		public override int IsA(string type)
		{
			return vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601284A RID: 75850
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLStructuredDataReader_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601284B RID: 75851 RVA: 0x0019F81C File Offset: 0x0019DA1C
		public new static int IsTypeOf(string type)
		{
			return vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_IsTypeOf_08(type);
		}

		// Token: 0x0601284C RID: 75852
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLStructuredDataReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601284D RID: 75853 RVA: 0x0019F838 File Offset: 0x0019DA38
		public new vtkXMLStructuredDataReader NewInstance()
		{
			vtkXMLStructuredDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLStructuredDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601284E RID: 75854
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLStructuredDataReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601284F RID: 75855 RVA: 0x0019F894 File Offset: 0x0019DA94
		public new static vtkXMLStructuredDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLStructuredDataReader vtkXMLStructuredDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLStructuredDataReader = (vtkXMLStructuredDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLStructuredDataReader.Register(null);
				}
			}
			return vtkXMLStructuredDataReader;
		}

		// Token: 0x06012850 RID: 75856
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLStructuredDataReader_SetWholeSlices_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set whether the reader gets a whole slice from disk when only
		/// a rectangle inside it is needed.  This mode reads more data than
		/// necessary, but prevents many short reads from interacting poorly
		/// with the compression and encoding schemes.
		/// </summary>
		// Token: 0x06012851 RID: 75857 RVA: 0x0019F913 File Offset: 0x0019DB13
		public virtual void SetWholeSlices(int _arg)
		{
			vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_SetWholeSlices_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06012852 RID: 75858
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLStructuredDataReader_WholeSlicesOff_12(HandleRef pThis);

		/// <summary>
		/// Get/Set whether the reader gets a whole slice from disk when only
		/// a rectangle inside it is needed.  This mode reads more data than
		/// necessary, but prevents many short reads from interacting poorly
		/// with the compression and encoding schemes.
		/// </summary>
		// Token: 0x06012853 RID: 75859 RVA: 0x0019F923 File Offset: 0x0019DB23
		public virtual void WholeSlicesOff()
		{
			vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_WholeSlicesOff_12(base.GetCppThis());
		}

		// Token: 0x06012854 RID: 75860
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLStructuredDataReader_WholeSlicesOn_13(HandleRef pThis);

		/// <summary>
		/// Get/Set whether the reader gets a whole slice from disk when only
		/// a rectangle inside it is needed.  This mode reads more data than
		/// necessary, but prevents many short reads from interacting poorly
		/// with the compression and encoding schemes.
		/// </summary>
		// Token: 0x06012855 RID: 75861 RVA: 0x0019F932 File Offset: 0x0019DB32
		public virtual void WholeSlicesOn()
		{
			vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_WholeSlicesOn_13(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400154F RID: 5455
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLStructuredDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001550 RID: 5456
		public new static readonly string MRClassNameKey = "class vtkXMLStructuredDataReader";
	}
}
