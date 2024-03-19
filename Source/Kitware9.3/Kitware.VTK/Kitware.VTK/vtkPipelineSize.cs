using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPipelineSize
	/// </summary>
	/// <remarks>
	///    compute the memory required by a pipeline
	/// </remarks>
	// Token: 0x02000517 RID: 1303
	public class vtkPipelineSize : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E8E6 RID: 59622 RVA: 0x00144CE5 File Offset: 0x00142EE5
		static vtkPipelineSize()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPipelineSize.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPipelineSize"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E8E7 RID: 59623 RVA: 0x00144D0D File Offset: 0x00142F0D
		public vtkPipelineSize(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E8E8 RID: 59624
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPipelineSize_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8E9 RID: 59625 RVA: 0x00144D1C File Offset: 0x00142F1C
		public new static vtkPipelineSize New()
		{
			vtkPipelineSize result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPipelineSize.vtkPipelineSize_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPipelineSize)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8EA RID: 59626 RVA: 0x00144D70 File Offset: 0x00142F70
		public vtkPipelineSize() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPipelineSize.vtkPipelineSize_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E8EB RID: 59627 RVA: 0x00144DB4 File Offset: 0x00142FB4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E8EC RID: 59628
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPipelineSize_GetEstimatedSize_01(HandleRef pThis, HandleRef input, int inputPort, int connection);

		/// <summary>
		/// Compute an estimate of how much memory a pipeline will require in
		/// kibibytes (1024 bytes) This is only an estimate and the
		/// calculations in here do not take into account the specifics of many
		/// sources and filters.
		/// </summary>
		// Token: 0x0600E8ED RID: 59629 RVA: 0x00144DC0 File Offset: 0x00142FC0
		public uint GetEstimatedSize(vtkAlgorithm input, int inputPort, int connection)
		{
			return vtkPipelineSize.vtkPipelineSize_GetEstimatedSize_01(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), inputPort, connection);
		}

		// Token: 0x0600E8EE RID: 59630
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPipelineSize_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8EF RID: 59631 RVA: 0x00144DF8 File Offset: 0x00142FF8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPipelineSize.vtkPipelineSize_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E8F0 RID: 59632
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPipelineSize_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8F1 RID: 59633 RVA: 0x00144E18 File Offset: 0x00143018
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPipelineSize.vtkPipelineSize_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E8F2 RID: 59634
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPipelineSize_GetNumberOfSubPieces_04(HandleRef pThis, uint memoryLimit, HandleRef mapper, int piece, int numPieces);

		/// <summary>
		/// Determine how many subpieces a mapper should use to fit a target memory
		/// limit. The piece and numPieces can be queried from the mapper using
		/// `vtkPolyDataMapper::GetPiece` and
		/// `vtkPolyDataMapper::GetNumberOfSubPieces`.
		/// </summary>
		// Token: 0x0600E8F3 RID: 59635 RVA: 0x00144E34 File Offset: 0x00143034
		public uint GetNumberOfSubPieces(uint memoryLimit, vtkAlgorithm mapper, int piece, int numPieces)
		{
			return vtkPipelineSize.vtkPipelineSize_GetNumberOfSubPieces_04(base.GetCppThis(), memoryLimit, (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), piece, numPieces);
		}

		// Token: 0x0600E8F4 RID: 59636
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPipelineSize_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8F5 RID: 59637 RVA: 0x00144E6C File Offset: 0x0014306C
		public override int IsA(string type)
		{
			return vtkPipelineSize.vtkPipelineSize_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600E8F6 RID: 59638
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPipelineSize_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8F7 RID: 59639 RVA: 0x00144E8C File Offset: 0x0014308C
		public new static int IsTypeOf(string type)
		{
			return vtkPipelineSize.vtkPipelineSize_IsTypeOf_06(type);
		}

		// Token: 0x0600E8F8 RID: 59640
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPipelineSize_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8F9 RID: 59641 RVA: 0x00144EA8 File Offset: 0x001430A8
		public new vtkPipelineSize NewInstance()
		{
			vtkPipelineSize result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPipelineSize.vtkPipelineSize_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPipelineSize)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E8FA RID: 59642
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPipelineSize_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8FB RID: 59643 RVA: 0x00144F04 File Offset: 0x00143104
		public new static vtkPipelineSize SafeDownCast(vtkObjectBase o)
		{
			vtkPipelineSize vtkPipelineSize = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPipelineSize.vtkPipelineSize_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPipelineSize = (vtkPipelineSize)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPipelineSize.Register(null);
				}
			}
			return vtkPipelineSize;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001118 RID: 4376
		public new const string MRFullTypeName = "Kitware.VTK.vtkPipelineSize";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001119 RID: 4377
		public new static readonly string MRClassNameKey = "class vtkPipelineSize";
	}
}
