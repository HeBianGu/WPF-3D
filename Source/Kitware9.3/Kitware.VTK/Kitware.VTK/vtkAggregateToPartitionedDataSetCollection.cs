using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkAggregateToPartitionedDataSetCollection
	/// </summary>
	/// <remarks>
	///  Aggregate results in the vtkEndFor
	///
	/// vtkAggregateToPartitionedDataSetCollection is an execution aggregator for the
	/// `vtkEndFor` filter that insert each iteration result in a partition of a
	/// vtkPartitionnedDataSetCollection.
	///
	/// </remarks>
	/// <seealso>
	///  vtkEndFor, vtkForEach, vtkExecutionAggregator
	/// </seealso>
	// Token: 0x020009C6 RID: 2502
	public class vtkAggregateToPartitionedDataSetCollection : vtkExecutionAggregator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A228 RID: 107048 RVA: 0x0024367F File Offset: 0x0024187F
		static vtkAggregateToPartitionedDataSetCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAggregateToPartitionedDataSetCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAggregateToPartitionedDataSetCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A229 RID: 107049 RVA: 0x002436A7 File Offset: 0x002418A7
		public vtkAggregateToPartitionedDataSetCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A22A RID: 107050
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAggregateToPartitionedDataSetCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A22B RID: 107051 RVA: 0x002436B8 File Offset: 0x002418B8
		public new static vtkAggregateToPartitionedDataSetCollection New()
		{
			vtkAggregateToPartitionedDataSetCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAggregateToPartitionedDataSetCollection.vtkAggregateToPartitionedDataSetCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAggregateToPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A22C RID: 107052 RVA: 0x0024370C File Offset: 0x0024190C
		public vtkAggregateToPartitionedDataSetCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAggregateToPartitionedDataSetCollection.vtkAggregateToPartitionedDataSetCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A22D RID: 107053 RVA: 0x00243750 File Offset: 0x00241950
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A22E RID: 107054
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAggregateToPartitionedDataSetCollection_Aggregate_01(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Push the input dataset at the end of the output vtkPartitionedDataSetCollection.
		/// </summary>
		// Token: 0x0601A22F RID: 107055 RVA: 0x0024375C File Offset: 0x0024195C
		public override bool Aggregate(vtkDataObject input)
		{
			return vtkAggregateToPartitionedDataSetCollection.vtkAggregateToPartitionedDataSetCollection_Aggregate_01(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis()) != 0;
		}

		// Token: 0x0601A230 RID: 107056
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAggregateToPartitionedDataSetCollection_Clear_02(HandleRef pThis);

		/// <summary>
		/// Reset the internal vtkPartitionedDataSetCollection
		/// </summary>
		// Token: 0x0601A231 RID: 107057 RVA: 0x00243797 File Offset: 0x00241997
		public override void Clear()
		{
			vtkAggregateToPartitionedDataSetCollection.vtkAggregateToPartitionedDataSetCollection_Clear_02(base.GetCppThis());
		}

		// Token: 0x0601A232 RID: 107058
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAggregateToPartitionedDataSetCollection_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A233 RID: 107059 RVA: 0x002437A8 File Offset: 0x002419A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAggregateToPartitionedDataSetCollection.vtkAggregateToPartitionedDataSetCollection_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A234 RID: 107060
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAggregateToPartitionedDataSetCollection_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A235 RID: 107061 RVA: 0x002437C8 File Offset: 0x002419C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAggregateToPartitionedDataSetCollection.vtkAggregateToPartitionedDataSetCollection_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601A236 RID: 107062
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAggregateToPartitionedDataSetCollection_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A237 RID: 107063 RVA: 0x002437E4 File Offset: 0x002419E4
		public override int IsA(string type)
		{
			return vtkAggregateToPartitionedDataSetCollection.vtkAggregateToPartitionedDataSetCollection_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601A238 RID: 107064
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAggregateToPartitionedDataSetCollection_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A239 RID: 107065 RVA: 0x00243804 File Offset: 0x00241A04
		public new static int IsTypeOf(string type)
		{
			return vtkAggregateToPartitionedDataSetCollection.vtkAggregateToPartitionedDataSetCollection_IsTypeOf_06(type);
		}

		// Token: 0x0601A23A RID: 107066
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAggregateToPartitionedDataSetCollection_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A23B RID: 107067 RVA: 0x00243820 File Offset: 0x00241A20
		public new vtkAggregateToPartitionedDataSetCollection NewInstance()
		{
			vtkAggregateToPartitionedDataSetCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAggregateToPartitionedDataSetCollection.vtkAggregateToPartitionedDataSetCollection_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAggregateToPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A23C RID: 107068
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAggregateToPartitionedDataSetCollection_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A23D RID: 107069 RVA: 0x0024387C File Offset: 0x00241A7C
		public new static vtkAggregateToPartitionedDataSetCollection SafeDownCast(vtkObjectBase o)
		{
			vtkAggregateToPartitionedDataSetCollection vtkAggregateToPartitionedDataSetCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAggregateToPartitionedDataSetCollection.vtkAggregateToPartitionedDataSetCollection_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAggregateToPartitionedDataSetCollection = (vtkAggregateToPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAggregateToPartitionedDataSetCollection.Register(null);
				}
			}
			return vtkAggregateToPartitionedDataSetCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C59 RID: 7257
		public new const string MRFullTypeName = "Kitware.VTK.vtkAggregateToPartitionedDataSetCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C5A RID: 7258
		public new static readonly string MRClassNameKey = "class vtkAggregateToPartitionedDataSetCollection";
	}
}
