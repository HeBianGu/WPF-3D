using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkExecutionAggregator
	/// </summary>
	/// <remarks>
	///  Aggregate the results of the sub-pipeline in vtkEndFor
	///
	/// vtkExecutionAggregator is an interface for vtkEndFor aggregators
	/// An aggregator is called at the end of each loop and processes the
	/// resulting data object.
	/// The `GetOutputDataObject` should only be called once the iterations are done,
	/// it can be used for data reduction.
	///
	/// </remarks>
	/// <seealso>
	///  vtkEndFor, vtkForEach, vtkAggregateToPartitionedDataSetCollection
	/// </seealso>
	// Token: 0x020009C5 RID: 2501
	public abstract class vtkExecutionAggregator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A215 RID: 107029 RVA: 0x0024349D File Offset: 0x0024169D
		static vtkExecutionAggregator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExecutionAggregator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExecutionAggregator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A216 RID: 107030 RVA: 0x002434C5 File Offset: 0x002416C5
		public vtkExecutionAggregator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A217 RID: 107031 RVA: 0x002434D3 File Offset: 0x002416D3
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A218 RID: 107032
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExecutionAggregator_Aggregate_01(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Called at the end of each iteration with the corresponding data object.
		/// </summary>
		// Token: 0x0601A219 RID: 107033 RVA: 0x002434E0 File Offset: 0x002416E0
		public virtual bool Aggregate(vtkDataObject input)
		{
			return vtkExecutionAggregator.vtkExecutionAggregator_Aggregate_01(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis()) != 0;
		}

		// Token: 0x0601A21A RID: 107034
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutionAggregator_Clear_02(HandleRef pThis);

		/// <summary>
		/// Called after the iterations are done, to clean memory
		/// that where used by the Aggregate method.
		/// It is called after the output has been retrieved
		/// </summary>
		// Token: 0x0601A21B RID: 107035 RVA: 0x0024351B File Offset: 0x0024171B
		public virtual void Clear()
		{
			vtkExecutionAggregator.vtkExecutionAggregator_Clear_02(base.GetCppThis());
		}

		// Token: 0x0601A21C RID: 107036
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExecutionAggregator_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A21D RID: 107037 RVA: 0x0024352C File Offset: 0x0024172C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExecutionAggregator.vtkExecutionAggregator_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A21E RID: 107038
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExecutionAggregator_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A21F RID: 107039 RVA: 0x0024354C File Offset: 0x0024174C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExecutionAggregator.vtkExecutionAggregator_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601A220 RID: 107040
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutionAggregator_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A221 RID: 107041 RVA: 0x00243568 File Offset: 0x00241768
		public override int IsA(string type)
		{
			return vtkExecutionAggregator.vtkExecutionAggregator_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601A222 RID: 107042
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutionAggregator_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A223 RID: 107043 RVA: 0x00243588 File Offset: 0x00241788
		public new static int IsTypeOf(string type)
		{
			return vtkExecutionAggregator.vtkExecutionAggregator_IsTypeOf_06(type);
		}

		// Token: 0x0601A224 RID: 107044
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutionAggregator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A225 RID: 107045 RVA: 0x002435A4 File Offset: 0x002417A4
		public new vtkExecutionAggregator NewInstance()
		{
			vtkExecutionAggregator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutionAggregator.vtkExecutionAggregator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExecutionAggregator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A226 RID: 107046
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutionAggregator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A227 RID: 107047 RVA: 0x00243600 File Offset: 0x00241800
		public new static vtkExecutionAggregator SafeDownCast(vtkObjectBase o)
		{
			vtkExecutionAggregator vtkExecutionAggregator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutionAggregator.vtkExecutionAggregator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExecutionAggregator = (vtkExecutionAggregator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExecutionAggregator.Register(null);
				}
			}
			return vtkExecutionAggregator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C57 RID: 7255
		public new const string MRFullTypeName = "Kitware.VTK.vtkExecutionAggregator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C58 RID: 7256
		public new static readonly string MRClassNameKey = "class vtkExecutionAggregator";
	}
}
