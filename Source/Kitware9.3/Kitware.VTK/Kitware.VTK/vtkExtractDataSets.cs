using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractDataSets
	/// </summary>
	/// <remarks>
	///    extracts a number of datasets.
	///
	/// vtkExtractDataSets accepts a vtkHierarchicalBoxDataSet as input and extracts
	/// different datasets from different levels. The output is
	/// vtkMultiBlockDataSet of vtkMultiPiece datasets. Each block corresponds to
	/// a level in the vktHierarchicalBoxDataSet. Individual datasets, within a level,
	/// are stored in a vtkMultiPiece dataset.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHierarchicalBoxDataSet, vtkMultiBlockDataSet vtkMultiPieceDataSet
	/// </seealso>
	// Token: 0x020006AA RID: 1706
	public class vtkExtractDataSets : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060123E8 RID: 74728 RVA: 0x00198F73 File Offset: 0x00197173
		static vtkExtractDataSets()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractDataSets.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractDataSets"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060123E9 RID: 74729 RVA: 0x00198F9B File Offset: 0x0019719B
		public vtkExtractDataSets(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060123EA RID: 74730
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractDataSets_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123EB RID: 74731 RVA: 0x00198FAC File Offset: 0x001971AC
		public new static vtkExtractDataSets New()
		{
			vtkExtractDataSets result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractDataSets.vtkExtractDataSets_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractDataSets)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123EC RID: 74732 RVA: 0x00199000 File Offset: 0x00197200
		public vtkExtractDataSets() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractDataSets.vtkExtractDataSets_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060123ED RID: 74733 RVA: 0x00199044 File Offset: 0x00197244
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060123EE RID: 74734
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractDataSets_AddDataSet_01(HandleRef pThis, uint level, uint idx);

		/// <summary>
		/// Add a dataset to be extracted.
		/// </summary>
		// Token: 0x060123EF RID: 74735 RVA: 0x0019904F File Offset: 0x0019724F
		public void AddDataSet(uint level, uint idx)
		{
			vtkExtractDataSets.vtkExtractDataSets_AddDataSet_01(base.GetCppThis(), level, idx);
		}

		// Token: 0x060123F0 RID: 74736
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractDataSets_ClearDataSetList_02(HandleRef pThis);

		/// <summary>
		/// Remove all entries from the list of datasets to be extracted.
		/// </summary>
		// Token: 0x060123F1 RID: 74737 RVA: 0x00199060 File Offset: 0x00197260
		public void ClearDataSetList()
		{
			vtkExtractDataSets.vtkExtractDataSets_ClearDataSetList_02(base.GetCppThis());
		}

		// Token: 0x060123F2 RID: 74738
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractDataSets_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123F3 RID: 74739 RVA: 0x00199070 File Offset: 0x00197270
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractDataSets.vtkExtractDataSets_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060123F4 RID: 74740
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractDataSets_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123F5 RID: 74741 RVA: 0x00199090 File Offset: 0x00197290
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractDataSets.vtkExtractDataSets_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060123F6 RID: 74742
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractDataSets_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123F7 RID: 74743 RVA: 0x001990AC File Offset: 0x001972AC
		public override int IsA(string type)
		{
			return vtkExtractDataSets.vtkExtractDataSets_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060123F8 RID: 74744
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractDataSets_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123F9 RID: 74745 RVA: 0x001990CC File Offset: 0x001972CC
		public new static int IsTypeOf(string type)
		{
			return vtkExtractDataSets.vtkExtractDataSets_IsTypeOf_06(type);
		}

		// Token: 0x060123FA RID: 74746
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractDataSets_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123FB RID: 74747 RVA: 0x001990E8 File Offset: 0x001972E8
		public new vtkExtractDataSets NewInstance()
		{
			vtkExtractDataSets result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractDataSets.vtkExtractDataSets_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractDataSets)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060123FC RID: 74748
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractDataSets_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123FD RID: 74749 RVA: 0x00199144 File Offset: 0x00197344
		public new static vtkExtractDataSets SafeDownCast(vtkObjectBase o)
		{
			vtkExtractDataSets vtkExtractDataSets = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractDataSets.vtkExtractDataSets_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractDataSets = (vtkExtractDataSets)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractDataSets.Register(null);
				}
			}
			return vtkExtractDataSets;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001502 RID: 5378
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractDataSets";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001503 RID: 5379
		public new static readonly string MRClassNameKey = "class vtkExtractDataSets";
	}
}
