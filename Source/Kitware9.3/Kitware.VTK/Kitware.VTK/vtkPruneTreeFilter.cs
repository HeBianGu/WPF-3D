using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPruneTreeFilter
	/// </summary>
	/// <remarks>
	///    prune a subtree out of a vtkTree
	///
	///
	/// Removes a subtree rooted at a particular vertex in a vtkTree.
	///
	/// </remarks>
	// Token: 0x0200068A RID: 1674
	public class vtkPruneTreeFilter : vtkTreeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011F6B RID: 73579 RVA: 0x001927B7 File Offset: 0x001909B7
		static vtkPruneTreeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPruneTreeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPruneTreeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011F6C RID: 73580 RVA: 0x001927DF File Offset: 0x001909DF
		public vtkPruneTreeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011F6D RID: 73581
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPruneTreeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F6E RID: 73582 RVA: 0x001927F0 File Offset: 0x001909F0
		public new static vtkPruneTreeFilter New()
		{
			vtkPruneTreeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPruneTreeFilter.vtkPruneTreeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPruneTreeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F6F RID: 73583 RVA: 0x00192844 File Offset: 0x00190A44
		public vtkPruneTreeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPruneTreeFilter.vtkPruneTreeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011F70 RID: 73584 RVA: 0x00192888 File Offset: 0x00190A88
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011F71 RID: 73585
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPruneTreeFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F72 RID: 73586 RVA: 0x00192894 File Offset: 0x00190A94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPruneTreeFilter.vtkPruneTreeFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06011F73 RID: 73587
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPruneTreeFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F74 RID: 73588 RVA: 0x001928B4 File Offset: 0x00190AB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPruneTreeFilter.vtkPruneTreeFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06011F75 RID: 73589
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPruneTreeFilter_GetParentVertex_03(HandleRef pThis);

		/// <summary>
		/// Set the parent vertex of the subtree to remove.
		/// </summary>
		// Token: 0x06011F76 RID: 73590 RVA: 0x001928D0 File Offset: 0x00190AD0
		public virtual long GetParentVertex()
		{
			return vtkPruneTreeFilter.vtkPruneTreeFilter_GetParentVertex_03(base.GetCppThis());
		}

		// Token: 0x06011F77 RID: 73591
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPruneTreeFilter_GetShouldPruneParentVertex_04(HandleRef pThis);

		/// <summary>
		/// Should we remove the parent vertex, or just its descendants?
		/// Default behavior is to remove the parent vertex.
		/// </summary>
		// Token: 0x06011F78 RID: 73592 RVA: 0x001928F0 File Offset: 0x00190AF0
		public virtual bool GetShouldPruneParentVertex()
		{
			return vtkPruneTreeFilter.vtkPruneTreeFilter_GetShouldPruneParentVertex_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06011F79 RID: 73593
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPruneTreeFilter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F7A RID: 73594 RVA: 0x00192918 File Offset: 0x00190B18
		public override int IsA(string type)
		{
			return vtkPruneTreeFilter.vtkPruneTreeFilter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06011F7B RID: 73595
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPruneTreeFilter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F7C RID: 73596 RVA: 0x00192938 File Offset: 0x00190B38
		public new static int IsTypeOf(string type)
		{
			return vtkPruneTreeFilter.vtkPruneTreeFilter_IsTypeOf_06(type);
		}

		// Token: 0x06011F7D RID: 73597
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPruneTreeFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F7E RID: 73598 RVA: 0x00192954 File Offset: 0x00190B54
		public new vtkPruneTreeFilter NewInstance()
		{
			vtkPruneTreeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPruneTreeFilter.vtkPruneTreeFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPruneTreeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011F7F RID: 73599
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPruneTreeFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F80 RID: 73600 RVA: 0x001929B0 File Offset: 0x00190BB0
		public new static vtkPruneTreeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPruneTreeFilter vtkPruneTreeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPruneTreeFilter.vtkPruneTreeFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPruneTreeFilter = (vtkPruneTreeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPruneTreeFilter.Register(null);
				}
			}
			return vtkPruneTreeFilter;
		}

		// Token: 0x06011F81 RID: 73601
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPruneTreeFilter_SetParentVertex_10(HandleRef pThis, long _arg);

		/// <summary>
		/// Set the parent vertex of the subtree to remove.
		/// </summary>
		// Token: 0x06011F82 RID: 73602 RVA: 0x00192A2F File Offset: 0x00190C2F
		public virtual void SetParentVertex(long _arg)
		{
			vtkPruneTreeFilter.vtkPruneTreeFilter_SetParentVertex_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06011F83 RID: 73603
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPruneTreeFilter_SetShouldPruneParentVertex_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// Should we remove the parent vertex, or just its descendants?
		/// Default behavior is to remove the parent vertex.
		/// </summary>
		// Token: 0x06011F84 RID: 73604 RVA: 0x00192A3F File Offset: 0x00190C3F
		public virtual void SetShouldPruneParentVertex(bool _arg)
		{
			vtkPruneTreeFilter.vtkPruneTreeFilter_SetShouldPruneParentVertex_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014BD RID: 5309
		public new const string MRFullTypeName = "Kitware.VTK.vtkPruneTreeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014BE RID: 5310
		public new static readonly string MRClassNameKey = "class vtkPruneTreeFilter";
	}
}
