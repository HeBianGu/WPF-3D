using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLCompositeDataReader
	/// </summary>
	/// <remarks>
	///    Reader for multi-group datasets
	///
	/// vtkXMLCompositeDataReader reads the VTK XML multi-group data file
	/// format. XML multi-group data files are meta-files that point to a list
	/// of serial VTK XML files. When reading in parallel, it will distribute
	/// sub-blocks among processor. If the number of sub-blocks is less than
	/// the number of processors, some processors will not have any sub-blocks
	/// for that group. If the number of sub-blocks is larger than the
	/// number of processors, each processor will possibly have more than
	/// 1 sub-block.
	/// </remarks>
	// Token: 0x020006C2 RID: 1730
	public abstract class vtkXMLCompositeDataReader : vtkXMLReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012739 RID: 75577 RVA: 0x0019D977 File Offset: 0x0019BB77
		static vtkXMLCompositeDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLCompositeDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLCompositeDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601273A RID: 75578 RVA: 0x0019D99F File Offset: 0x0019BB9F
		public vtkXMLCompositeDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601273B RID: 75579 RVA: 0x0019D9AD File Offset: 0x0019BBAD
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601273C RID: 75580
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLCompositeDataReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601273D RID: 75581 RVA: 0x0019D9B8 File Offset: 0x0019BBB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLCompositeDataReader.vtkXMLCompositeDataReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601273E RID: 75582
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLCompositeDataReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601273F RID: 75583 RVA: 0x0019D9D8 File Offset: 0x0019BBD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLCompositeDataReader.vtkXMLCompositeDataReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012740 RID: 75584
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLCompositeDataReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06012741 RID: 75585 RVA: 0x0019D9F4 File Offset: 0x0019BBF4
		public vtkCompositeDataSet GetOutput()
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLCompositeDataReader.vtkXMLCompositeDataReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		// Token: 0x06012742 RID: 75586
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLCompositeDataReader_GetOutput_04(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06012743 RID: 75587 RVA: 0x0019DA64 File Offset: 0x0019BC64
		public vtkCompositeDataSet GetOutput(int arg0)
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLCompositeDataReader.vtkXMLCompositeDataReader_GetOutput_04(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		// Token: 0x06012744 RID: 75588
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLCompositeDataReader_GetPieceDistribution_05(HandleRef pThis);

		/// <summary>
		/// Set the strategy for assigning files to parallel readers. The default is
		/// @a Block.
		///
		/// Let @a X be the rank of a specific reader, and @a N be the number of
		/// reader, then:
		/// @arg @c Block Each processor is assigned a contiguous block of files,
		///      [@a X * @a N, ( @a X + 1) * @a N ).
		/// @arg @c Interleave The files are interleaved across readers,
		/// @a i * @a N + @a X.
		/// @{
		/// </summary>
		// Token: 0x06012745 RID: 75589 RVA: 0x0019DAD4 File Offset: 0x0019BCD4
		public virtual int GetPieceDistribution()
		{
			return vtkXMLCompositeDataReader.vtkXMLCompositeDataReader_GetPieceDistribution_05(base.GetCppThis());
		}

		// Token: 0x06012746 RID: 75590
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLCompositeDataReader_GetPieceDistributionMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Set the strategy for assigning files to parallel readers. The default is
		/// @a Block.
		///
		/// Let @a X be the rank of a specific reader, and @a N be the number of
		/// reader, then:
		/// @arg @c Block Each processor is assigned a contiguous block of files,
		///      [@a X * @a N, ( @a X + 1) * @a N ).
		/// @arg @c Interleave The files are interleaved across readers,
		/// @a i * @a N + @a X.
		/// @{
		/// </summary>
		// Token: 0x06012747 RID: 75591 RVA: 0x0019DAF4 File Offset: 0x0019BCF4
		public virtual int GetPieceDistributionMaxValue()
		{
			return vtkXMLCompositeDataReader.vtkXMLCompositeDataReader_GetPieceDistributionMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06012748 RID: 75592
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLCompositeDataReader_GetPieceDistributionMinValue_07(HandleRef pThis);

		/// <summary>
		/// Set the strategy for assigning files to parallel readers. The default is
		/// @a Block.
		///
		/// Let @a X be the rank of a specific reader, and @a N be the number of
		/// reader, then:
		/// @arg @c Block Each processor is assigned a contiguous block of files,
		///      [@a X * @a N, ( @a X + 1) * @a N ).
		/// @arg @c Interleave The files are interleaved across readers,
		/// @a i * @a N + @a X.
		/// @{
		/// </summary>
		// Token: 0x06012749 RID: 75593 RVA: 0x0019DB14 File Offset: 0x0019BD14
		public virtual int GetPieceDistributionMinValue()
		{
			return vtkXMLCompositeDataReader.vtkXMLCompositeDataReader_GetPieceDistributionMinValue_07(base.GetCppThis());
		}

		// Token: 0x0601274A RID: 75594
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLCompositeDataReader_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601274B RID: 75595 RVA: 0x0019DB34 File Offset: 0x0019BD34
		public override int IsA(string type)
		{
			return vtkXMLCompositeDataReader.vtkXMLCompositeDataReader_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601274C RID: 75596
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLCompositeDataReader_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601274D RID: 75597 RVA: 0x0019DB54 File Offset: 0x0019BD54
		public new static int IsTypeOf(string type)
		{
			return vtkXMLCompositeDataReader.vtkXMLCompositeDataReader_IsTypeOf_09(type);
		}

		// Token: 0x0601274E RID: 75598
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLCompositeDataReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601274F RID: 75599 RVA: 0x0019DB70 File Offset: 0x0019BD70
		public new vtkXMLCompositeDataReader NewInstance()
		{
			vtkXMLCompositeDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLCompositeDataReader.vtkXMLCompositeDataReader_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLCompositeDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012750 RID: 75600
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLCompositeDataReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012751 RID: 75601 RVA: 0x0019DBCC File Offset: 0x0019BDCC
		public new static vtkXMLCompositeDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLCompositeDataReader vtkXMLCompositeDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLCompositeDataReader.vtkXMLCompositeDataReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLCompositeDataReader = (vtkXMLCompositeDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLCompositeDataReader.Register(null);
				}
			}
			return vtkXMLCompositeDataReader;
		}

		// Token: 0x06012752 RID: 75602
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLCompositeDataReader_SetFileName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06012753 RID: 75603 RVA: 0x0019DC4B File Offset: 0x0019BE4B
		public override void SetFileName(string arg0)
		{
			vtkXMLCompositeDataReader.vtkXMLCompositeDataReader_SetFileName_12(base.GetCppThis(), arg0);
		}

		// Token: 0x06012754 RID: 75604
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLCompositeDataReader_SetPieceDistribution_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the strategy for assigning files to parallel readers. The default is
		/// @a Block.
		///
		/// Let @a X be the rank of a specific reader, and @a N be the number of
		/// reader, then:
		/// @arg @c Block Each processor is assigned a contiguous block of files,
		///      [@a X * @a N, ( @a X + 1) * @a N ).
		/// @arg @c Interleave The files are interleaved across readers,
		/// @a i * @a N + @a X.
		/// @{
		/// </summary>
		// Token: 0x06012755 RID: 75605 RVA: 0x0019DC5B File Offset: 0x0019BE5B
		public virtual void SetPieceDistribution(int _arg)
		{
			vtkXMLCompositeDataReader.vtkXMLCompositeDataReader_SetPieceDistribution_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001534 RID: 5428
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLCompositeDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001535 RID: 5429
		public new static readonly string MRClassNameKey = "class vtkXMLCompositeDataReader";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020006C3 RID: 1731
		public enum Block_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001537 RID: 5431
			Block,
			/// <summary>enum member</summary>
			// Token: 0x04001538 RID: 5432
			Interleave
		}
	}
}
