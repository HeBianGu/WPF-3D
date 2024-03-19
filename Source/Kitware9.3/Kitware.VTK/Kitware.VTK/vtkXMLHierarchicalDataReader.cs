using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLHierarchicalDataReader
	/// </summary>
	/// <remarks>
	///    Reader for hierarchical datasets
	///
	/// vtkXMLHierarchicalDataReader reads the VTK XML hierarchical data file
	/// format. XML hierarchical data files are meta-files that point to a list
	/// of serial VTK XML files. When reading in parallel, it will distribute
	/// sub-blocks among processor. If the number of sub-blocks is less than
	/// the number of processors, some processors will not have any sub-blocks
	/// for that level. If the number of sub-blocks is larger than the
	/// number of processors, each processor will possibly have more than
	/// 1 sub-block.
	/// </remarks>
	// Token: 0x020006CE RID: 1742
	public class vtkXMLHierarchicalDataReader : vtkXMLMultiGroupDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012827 RID: 75815 RVA: 0x0019F4BF File Offset: 0x0019D6BF
		static vtkXMLHierarchicalDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLHierarchicalDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLHierarchicalDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012828 RID: 75816 RVA: 0x0019F4E7 File Offset: 0x0019D6E7
		public vtkXMLHierarchicalDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012829 RID: 75817
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLHierarchicalDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601282A RID: 75818 RVA: 0x0019F4F8 File Offset: 0x0019D6F8
		public new static vtkXMLHierarchicalDataReader New()
		{
			vtkXMLHierarchicalDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLHierarchicalDataReader.vtkXMLHierarchicalDataReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLHierarchicalDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601282B RID: 75819 RVA: 0x0019F54C File Offset: 0x0019D74C
		public vtkXMLHierarchicalDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLHierarchicalDataReader.vtkXMLHierarchicalDataReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601282C RID: 75820 RVA: 0x0019F590 File Offset: 0x0019D790
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601282D RID: 75821
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLHierarchicalDataReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601282E RID: 75822 RVA: 0x0019F59C File Offset: 0x0019D79C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLHierarchicalDataReader.vtkXMLHierarchicalDataReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601282F RID: 75823
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLHierarchicalDataReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012830 RID: 75824 RVA: 0x0019F5BC File Offset: 0x0019D7BC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLHierarchicalDataReader.vtkXMLHierarchicalDataReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012831 RID: 75825
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLHierarchicalDataReader_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012832 RID: 75826 RVA: 0x0019F5D8 File Offset: 0x0019D7D8
		public override int IsA(string type)
		{
			return vtkXMLHierarchicalDataReader.vtkXMLHierarchicalDataReader_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06012833 RID: 75827
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLHierarchicalDataReader_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012834 RID: 75828 RVA: 0x0019F5F8 File Offset: 0x0019D7F8
		public new static int IsTypeOf(string type)
		{
			return vtkXMLHierarchicalDataReader.vtkXMLHierarchicalDataReader_IsTypeOf_04(type);
		}

		// Token: 0x06012835 RID: 75829
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLHierarchicalDataReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012836 RID: 75830 RVA: 0x0019F614 File Offset: 0x0019D814
		public new vtkXMLHierarchicalDataReader NewInstance()
		{
			vtkXMLHierarchicalDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLHierarchicalDataReader.vtkXMLHierarchicalDataReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLHierarchicalDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012837 RID: 75831
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLHierarchicalDataReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012838 RID: 75832 RVA: 0x0019F670 File Offset: 0x0019D870
		public new static vtkXMLHierarchicalDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLHierarchicalDataReader vtkXMLHierarchicalDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLHierarchicalDataReader.vtkXMLHierarchicalDataReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLHierarchicalDataReader = (vtkXMLHierarchicalDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLHierarchicalDataReader.Register(null);
				}
			}
			return vtkXMLHierarchicalDataReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400154D RID: 5453
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLHierarchicalDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400154E RID: 5454
		public new static readonly string MRClassNameKey = "class vtkXMLHierarchicalDataReader";
	}
}
