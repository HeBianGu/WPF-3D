using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPartitionedDataSetCollectionReader
	/// </summary>
	/// <remarks>
	///    Reader for partitioned dataset collections
	///
	/// vtkXMLPartitionedDataSetCollectionReader reads the VTK XML partitioned
	/// dataset collection file format. These are meta-files that point to a list
	/// of serial VTK XML files. When reading in parallel, it will distribute
	/// sub-blocks among processor. If the number of sub-blocks is less than
	/// the number of processors, some processors will not have any sub-blocks
	/// for that block. If the number of sub-blocks is larger than the
	/// number of processors, each processor will possibly have more than
	/// 1 sub-block.
	/// </remarks>
	// Token: 0x020006DD RID: 1757
	public class vtkXMLPartitionedDataSetCollectionReader : vtkXMLCompositeDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601297F RID: 76159 RVA: 0x001A1CD3 File Offset: 0x0019FED3
		static vtkXMLPartitionedDataSetCollectionReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPartitionedDataSetCollectionReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPartitionedDataSetCollectionReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012980 RID: 76160 RVA: 0x001A1CFB File Offset: 0x0019FEFB
		public vtkXMLPartitionedDataSetCollectionReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012981 RID: 76161
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPartitionedDataSetCollectionReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012982 RID: 76162 RVA: 0x001A1D0C File Offset: 0x0019FF0C
		public new static vtkXMLPartitionedDataSetCollectionReader New()
		{
			vtkXMLPartitionedDataSetCollectionReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPartitionedDataSetCollectionReader.vtkXMLPartitionedDataSetCollectionReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPartitionedDataSetCollectionReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012983 RID: 76163 RVA: 0x001A1D60 File Offset: 0x0019FF60
		public vtkXMLPartitionedDataSetCollectionReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPartitionedDataSetCollectionReader.vtkXMLPartitionedDataSetCollectionReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012984 RID: 76164 RVA: 0x001A1DA4 File Offset: 0x0019FFA4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012985 RID: 76165
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPartitionedDataSetCollectionReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012986 RID: 76166 RVA: 0x001A1DB0 File Offset: 0x0019FFB0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPartitionedDataSetCollectionReader.vtkXMLPartitionedDataSetCollectionReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012987 RID: 76167
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPartitionedDataSetCollectionReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012988 RID: 76168 RVA: 0x001A1DD0 File Offset: 0x0019FFD0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPartitionedDataSetCollectionReader.vtkXMLPartitionedDataSetCollectionReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012989 RID: 76169
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPartitionedDataSetCollectionReader_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601298A RID: 76170 RVA: 0x001A1DEC File Offset: 0x0019FFEC
		public override int IsA(string type)
		{
			return vtkXMLPartitionedDataSetCollectionReader.vtkXMLPartitionedDataSetCollectionReader_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601298B RID: 76171
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPartitionedDataSetCollectionReader_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601298C RID: 76172 RVA: 0x001A1E0C File Offset: 0x001A000C
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPartitionedDataSetCollectionReader.vtkXMLPartitionedDataSetCollectionReader_IsTypeOf_04(type);
		}

		// Token: 0x0601298D RID: 76173
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPartitionedDataSetCollectionReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601298E RID: 76174 RVA: 0x001A1E28 File Offset: 0x001A0028
		public new vtkXMLPartitionedDataSetCollectionReader NewInstance()
		{
			vtkXMLPartitionedDataSetCollectionReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPartitionedDataSetCollectionReader.vtkXMLPartitionedDataSetCollectionReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPartitionedDataSetCollectionReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601298F RID: 76175
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPartitionedDataSetCollectionReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012990 RID: 76176 RVA: 0x001A1E84 File Offset: 0x001A0084
		public new static vtkXMLPartitionedDataSetCollectionReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPartitionedDataSetCollectionReader vtkXMLPartitionedDataSetCollectionReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPartitionedDataSetCollectionReader.vtkXMLPartitionedDataSetCollectionReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPartitionedDataSetCollectionReader = (vtkXMLPartitionedDataSetCollectionReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPartitionedDataSetCollectionReader.Register(null);
				}
			}
			return vtkXMLPartitionedDataSetCollectionReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400156B RID: 5483
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPartitionedDataSetCollectionReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400156C RID: 5484
		public new static readonly string MRClassNameKey = "class vtkXMLPartitionedDataSetCollectionReader";
	}
}
