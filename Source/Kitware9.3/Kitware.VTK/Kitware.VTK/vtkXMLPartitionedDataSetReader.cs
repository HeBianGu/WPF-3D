using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPartitionedDataSetReader
	/// </summary>
	/// <remarks>
	///    Reader for partitioned datasets
	///
	/// vtkXMLPartitionedDataSetReader reads the VTK XML partitioned dataset file
	/// format. XML partitioned dataset files are meta-files that point to a list
	/// of serial VTK XML files. When reading in parallel, it will distribute
	/// sub-blocks among processors. If the number of sub-blocks is less than
	/// the number of processors, some processors will not have any sub-blocks
	/// for that block. If the number of sub-blocks is larger than the
	/// number of processors, each processor will possibly have more than
	/// 1 sub-block.
	/// </remarks>
	// Token: 0x020006DE RID: 1758
	public class vtkXMLPartitionedDataSetReader : vtkXMLCompositeDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012991 RID: 76177 RVA: 0x001A1F03 File Offset: 0x001A0103
		static vtkXMLPartitionedDataSetReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPartitionedDataSetReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPartitionedDataSetReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012992 RID: 76178 RVA: 0x001A1F2B File Offset: 0x001A012B
		public vtkXMLPartitionedDataSetReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012993 RID: 76179
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPartitionedDataSetReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012994 RID: 76180 RVA: 0x001A1F3C File Offset: 0x001A013C
		public new static vtkXMLPartitionedDataSetReader New()
		{
			vtkXMLPartitionedDataSetReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPartitionedDataSetReader.vtkXMLPartitionedDataSetReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPartitionedDataSetReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012995 RID: 76181 RVA: 0x001A1F90 File Offset: 0x001A0190
		public vtkXMLPartitionedDataSetReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPartitionedDataSetReader.vtkXMLPartitionedDataSetReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012996 RID: 76182 RVA: 0x001A1FD4 File Offset: 0x001A01D4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012997 RID: 76183
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPartitionedDataSetReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012998 RID: 76184 RVA: 0x001A1FE0 File Offset: 0x001A01E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPartitionedDataSetReader.vtkXMLPartitionedDataSetReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012999 RID: 76185
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPartitionedDataSetReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601299A RID: 76186 RVA: 0x001A2000 File Offset: 0x001A0200
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPartitionedDataSetReader.vtkXMLPartitionedDataSetReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601299B RID: 76187
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPartitionedDataSetReader_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601299C RID: 76188 RVA: 0x001A201C File Offset: 0x001A021C
		public override int IsA(string type)
		{
			return vtkXMLPartitionedDataSetReader.vtkXMLPartitionedDataSetReader_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601299D RID: 76189
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPartitionedDataSetReader_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601299E RID: 76190 RVA: 0x001A203C File Offset: 0x001A023C
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPartitionedDataSetReader.vtkXMLPartitionedDataSetReader_IsTypeOf_04(type);
		}

		// Token: 0x0601299F RID: 76191
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPartitionedDataSetReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129A0 RID: 76192 RVA: 0x001A2058 File Offset: 0x001A0258
		public new vtkXMLPartitionedDataSetReader NewInstance()
		{
			vtkXMLPartitionedDataSetReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPartitionedDataSetReader.vtkXMLPartitionedDataSetReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPartitionedDataSetReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060129A1 RID: 76193
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPartitionedDataSetReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129A2 RID: 76194 RVA: 0x001A20B4 File Offset: 0x001A02B4
		public new static vtkXMLPartitionedDataSetReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPartitionedDataSetReader vtkXMLPartitionedDataSetReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPartitionedDataSetReader.vtkXMLPartitionedDataSetReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPartitionedDataSetReader = (vtkXMLPartitionedDataSetReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPartitionedDataSetReader.Register(null);
				}
			}
			return vtkXMLPartitionedDataSetReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400156D RID: 5485
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPartitionedDataSetReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400156E RID: 5486
		public new static readonly string MRClassNameKey = "class vtkXMLPartitionedDataSetReader";
	}
}
