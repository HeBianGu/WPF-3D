using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUniformGridPartitioner
	///
	///
	///  A concrete implementation of vtkMultiBlockDataSetAlgorithm that provides
	///  functionality for partitioning a uniform grid. The partitioning method
	///  that is used is Recursive Coordinate Bisection (RCB) where each time
	///  the longest dimension is split.
	///
	/// </summary>
	/// <seealso>
	///
	/// vtkStructuredGridPartitioner vtkRectilinearGridPartitioner
	/// </seealso>
	// Token: 0x020009EA RID: 2538
	public class vtkUniformGridPartitioner : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A656 RID: 108118 RVA: 0x0024A71B File Offset: 0x0024891B
		static vtkUniformGridPartitioner()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUniformGridPartitioner.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUniformGridPartitioner"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A657 RID: 108119 RVA: 0x0024A743 File Offset: 0x00248943
		public vtkUniformGridPartitioner(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A658 RID: 108120
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridPartitioner_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A659 RID: 108121 RVA: 0x0024A754 File Offset: 0x00248954
		public new static vtkUniformGridPartitioner New()
		{
			vtkUniformGridPartitioner result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridPartitioner.vtkUniformGridPartitioner_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniformGridPartitioner)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A65A RID: 108122 RVA: 0x0024A7A8 File Offset: 0x002489A8
		public vtkUniformGridPartitioner() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUniformGridPartitioner.vtkUniformGridPartitioner_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A65B RID: 108123 RVA: 0x0024A7EC File Offset: 0x002489EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A65C RID: 108124
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridPartitioner_DuplicateNodesOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x0601A65D RID: 108125 RVA: 0x0024A7F7 File Offset: 0x002489F7
		public virtual void DuplicateNodesOff()
		{
			vtkUniformGridPartitioner.vtkUniformGridPartitioner_DuplicateNodesOff_01(base.GetCppThis());
		}

		// Token: 0x0601A65E RID: 108126
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridPartitioner_DuplicateNodesOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x0601A65F RID: 108127 RVA: 0x0024A806 File Offset: 0x00248A06
		public virtual void DuplicateNodesOn()
		{
			vtkUniformGridPartitioner.vtkUniformGridPartitioner_DuplicateNodesOn_02(base.GetCppThis());
		}

		// Token: 0x0601A660 RID: 108128
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridPartitioner_GetDuplicateNodes_03(HandleRef pThis);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x0601A661 RID: 108129 RVA: 0x0024A818 File Offset: 0x00248A18
		public virtual int GetDuplicateNodes()
		{
			return vtkUniformGridPartitioner.vtkUniformGridPartitioner_GetDuplicateNodes_03(base.GetCppThis());
		}

		// Token: 0x0601A662 RID: 108130
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUniformGridPartitioner_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A663 RID: 108131 RVA: 0x0024A838 File Offset: 0x00248A38
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUniformGridPartitioner.vtkUniformGridPartitioner_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601A664 RID: 108132
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUniformGridPartitioner_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A665 RID: 108133 RVA: 0x0024A858 File Offset: 0x00248A58
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUniformGridPartitioner.vtkUniformGridPartitioner_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601A666 RID: 108134
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridPartitioner_GetNumberOfGhostLayers_06(HandleRef pThis);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x0601A667 RID: 108135 RVA: 0x0024A874 File Offset: 0x00248A74
		public virtual int GetNumberOfGhostLayers()
		{
			return vtkUniformGridPartitioner.vtkUniformGridPartitioner_GetNumberOfGhostLayers_06(base.GetCppThis());
		}

		// Token: 0x0601A668 RID: 108136
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridPartitioner_GetNumberOfPartitions_07(HandleRef pThis);

		/// <summary>
		/// Set/Get macro for the number of subdivisions.
		/// </summary>
		// Token: 0x0601A669 RID: 108137 RVA: 0x0024A894 File Offset: 0x00248A94
		public virtual int GetNumberOfPartitions()
		{
			return vtkUniformGridPartitioner.vtkUniformGridPartitioner_GetNumberOfPartitions_07(base.GetCppThis());
		}

		// Token: 0x0601A66A RID: 108138
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridPartitioner_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A66B RID: 108139 RVA: 0x0024A8B4 File Offset: 0x00248AB4
		public override int IsA(string type)
		{
			return vtkUniformGridPartitioner.vtkUniformGridPartitioner_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601A66C RID: 108140
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridPartitioner_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A66D RID: 108141 RVA: 0x0024A8D4 File Offset: 0x00248AD4
		public new static int IsTypeOf(string type)
		{
			return vtkUniformGridPartitioner.vtkUniformGridPartitioner_IsTypeOf_09(type);
		}

		// Token: 0x0601A66E RID: 108142
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridPartitioner_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A66F RID: 108143 RVA: 0x0024A8F0 File Offset: 0x00248AF0
		public new vtkUniformGridPartitioner NewInstance()
		{
			vtkUniformGridPartitioner result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridPartitioner.vtkUniformGridPartitioner_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniformGridPartitioner)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A670 RID: 108144
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridPartitioner_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A671 RID: 108145 RVA: 0x0024A94C File Offset: 0x00248B4C
		public new static vtkUniformGridPartitioner SafeDownCast(vtkObjectBase o)
		{
			vtkUniformGridPartitioner vtkUniformGridPartitioner = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridPartitioner.vtkUniformGridPartitioner_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGridPartitioner = (vtkUniformGridPartitioner)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGridPartitioner.Register(null);
				}
			}
			return vtkUniformGridPartitioner;
		}

		// Token: 0x0601A672 RID: 108146
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridPartitioner_SetDuplicateNodes_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x0601A673 RID: 108147 RVA: 0x0024A9CB File Offset: 0x00248BCB
		public virtual void SetDuplicateNodes(int _arg)
		{
			vtkUniformGridPartitioner.vtkUniformGridPartitioner_SetDuplicateNodes_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A674 RID: 108148
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridPartitioner_SetNumberOfGhostLayers_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x0601A675 RID: 108149 RVA: 0x0024A9DB File Offset: 0x00248BDB
		public virtual void SetNumberOfGhostLayers(int _arg)
		{
			vtkUniformGridPartitioner.vtkUniformGridPartitioner_SetNumberOfGhostLayers_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A676 RID: 108150
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridPartitioner_SetNumberOfPartitions_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get macro for the number of subdivisions.
		/// </summary>
		// Token: 0x0601A677 RID: 108151 RVA: 0x0024A9EB File Offset: 0x00248BEB
		public virtual void SetNumberOfPartitions(int _arg)
		{
			vtkUniformGridPartitioner.vtkUniformGridPartitioner_SetNumberOfPartitions_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CA4 RID: 7332
		public new const string MRFullTypeName = "Kitware.VTK.vtkUniformGridPartitioner";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CA5 RID: 7333
		public new static readonly string MRClassNameKey = "class vtkUniformGridPartitioner";
	}
}
