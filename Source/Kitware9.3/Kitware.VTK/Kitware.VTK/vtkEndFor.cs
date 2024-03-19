using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkEndFor
	/// </summary>
	/// <remarks>
	///  vtkEndFor define the end of the sub-pipeline to loop
	///
	/// vtkEndFor works together with vtkForEach. It marks the end of the loop.
	/// Its goals is to use the given `vtkExecutionAggregator` to process the result
	/// of each iteration and provide an output dataset.
	///
	/// The default aggregator is vtkAggregateToPartitionedDataSetCollection, which
	/// build a vtkPartitionedDataSetCollection with each result in a separate partition.
	///
	/// &gt; Largely inspired by the ttkForEach/ttkEndFor in the TTK project
	/// &gt; (https://github.com/topology-tool-kit/ttk/tree/dev)
	///
	/// </remarks>
	/// <seealso>
	///  vtkForEach, vtkExecutionAggregator
	/// </seealso>
	// Token: 0x020009CB RID: 2507
	public class vtkEndFor : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A29C RID: 107164 RVA: 0x002444D9 File Offset: 0x002426D9
		static vtkEndFor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEndFor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEndFor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A29D RID: 107165 RVA: 0x00244501 File Offset: 0x00242701
		public vtkEndFor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A29E RID: 107166
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEndFor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A29F RID: 107167 RVA: 0x00244510 File Offset: 0x00242710
		public new static vtkEndFor New()
		{
			vtkEndFor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEndFor.vtkEndFor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEndFor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2A0 RID: 107168 RVA: 0x00244564 File Offset: 0x00242764
		public vtkEndFor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEndFor.vtkEndFor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A2A1 RID: 107169 RVA: 0x002445A8 File Offset: 0x002427A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A2A2 RID: 107170
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEndFor_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2A3 RID: 107171 RVA: 0x002445B4 File Offset: 0x002427B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEndFor.vtkEndFor_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A2A4 RID: 107172
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEndFor_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2A5 RID: 107173 RVA: 0x002445D4 File Offset: 0x002427D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEndFor.vtkEndFor_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A2A6 RID: 107174
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEndFor_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2A7 RID: 107175 RVA: 0x002445F0 File Offset: 0x002427F0
		public override int IsA(string type)
		{
			return vtkEndFor.vtkEndFor_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A2A8 RID: 107176
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEndFor_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2A9 RID: 107177 RVA: 0x00244610 File Offset: 0x00242810
		public new static int IsTypeOf(string type)
		{
			return vtkEndFor.vtkEndFor_IsTypeOf_04(type);
		}

		// Token: 0x0601A2AA RID: 107178
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEndFor_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2AB RID: 107179 RVA: 0x0024462C File Offset: 0x0024282C
		public new vtkEndFor NewInstance()
		{
			vtkEndFor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEndFor.vtkEndFor_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEndFor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A2AC RID: 107180
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEndFor_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2AD RID: 107181 RVA: 0x00244688 File Offset: 0x00242888
		public new static vtkEndFor SafeDownCast(vtkObjectBase o)
		{
			vtkEndFor vtkEndFor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEndFor.vtkEndFor_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEndFor = (vtkEndFor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEndFor.Register(null);
				}
			}
			return vtkEndFor;
		}

		// Token: 0x0601A2AE RID: 107182
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEndFor_SetAggregator_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Aggregator object to use to reduce / aggregate results of for loop
		/// </summary>
		// Token: 0x0601A2AF RID: 107183 RVA: 0x00244708 File Offset: 0x00242908
		public virtual void SetAggregator(vtkExecutionAggregator arg0)
		{
			vtkEndFor.vtkEndFor_SetAggregator_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C63 RID: 7267
		public new const string MRFullTypeName = "Kitware.VTK.vtkEndFor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C64 RID: 7268
		public new static readonly string MRClassNameKey = "class vtkEndFor";
	}
}
