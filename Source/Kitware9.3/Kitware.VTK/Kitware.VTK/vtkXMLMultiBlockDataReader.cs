using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLMultiBlockDataReader
	/// </summary>
	/// <remarks>
	///    Reader for multi-block datasets
	///
	/// vtkXMLMultiBlockDataReader reads the VTK XML multi-block data file
	/// format. XML multi-block data files are meta-files that point to a list
	/// of serial VTK XML files. When reading in parallel, it will distribute
	/// sub-blocks among processor. If the number of sub-blocks is less than
	/// the number of processors, some processors will not have any sub-blocks
	/// for that block. If the number of sub-blocks is larger than the
	/// number of processors, each processor will possibly have more than
	/// 1 sub-block.
	/// </remarks>
	// Token: 0x020006CC RID: 1740
	public class vtkXMLMultiBlockDataReader : vtkXMLCompositeDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012803 RID: 75779 RVA: 0x0019F05F File Offset: 0x0019D25F
		static vtkXMLMultiBlockDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLMultiBlockDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLMultiBlockDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012804 RID: 75780 RVA: 0x0019F087 File Offset: 0x0019D287
		public vtkXMLMultiBlockDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012805 RID: 75781
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLMultiBlockDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012806 RID: 75782 RVA: 0x0019F098 File Offset: 0x0019D298
		public new static vtkXMLMultiBlockDataReader New()
		{
			vtkXMLMultiBlockDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLMultiBlockDataReader.vtkXMLMultiBlockDataReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLMultiBlockDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012807 RID: 75783 RVA: 0x0019F0EC File Offset: 0x0019D2EC
		public vtkXMLMultiBlockDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLMultiBlockDataReader.vtkXMLMultiBlockDataReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012808 RID: 75784 RVA: 0x0019F130 File Offset: 0x0019D330
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012809 RID: 75785
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLMultiBlockDataReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601280A RID: 75786 RVA: 0x0019F13C File Offset: 0x0019D33C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLMultiBlockDataReader.vtkXMLMultiBlockDataReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601280B RID: 75787
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLMultiBlockDataReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601280C RID: 75788 RVA: 0x0019F15C File Offset: 0x0019D35C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLMultiBlockDataReader.vtkXMLMultiBlockDataReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601280D RID: 75789
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLMultiBlockDataReader_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601280E RID: 75790 RVA: 0x0019F178 File Offset: 0x0019D378
		public override int IsA(string type)
		{
			return vtkXMLMultiBlockDataReader.vtkXMLMultiBlockDataReader_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601280F RID: 75791
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLMultiBlockDataReader_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012810 RID: 75792 RVA: 0x0019F198 File Offset: 0x0019D398
		public new static int IsTypeOf(string type)
		{
			return vtkXMLMultiBlockDataReader.vtkXMLMultiBlockDataReader_IsTypeOf_04(type);
		}

		// Token: 0x06012811 RID: 75793
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLMultiBlockDataReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012812 RID: 75794 RVA: 0x0019F1B4 File Offset: 0x0019D3B4
		public new vtkXMLMultiBlockDataReader NewInstance()
		{
			vtkXMLMultiBlockDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLMultiBlockDataReader.vtkXMLMultiBlockDataReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLMultiBlockDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012813 RID: 75795
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLMultiBlockDataReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012814 RID: 75796 RVA: 0x0019F210 File Offset: 0x0019D410
		public new static vtkXMLMultiBlockDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLMultiBlockDataReader vtkXMLMultiBlockDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLMultiBlockDataReader.vtkXMLMultiBlockDataReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLMultiBlockDataReader = (vtkXMLMultiBlockDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLMultiBlockDataReader.Register(null);
				}
			}
			return vtkXMLMultiBlockDataReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001549 RID: 5449
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLMultiBlockDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400154A RID: 5450
		public new static readonly string MRClassNameKey = "class vtkXMLMultiBlockDataReader";
	}
}
