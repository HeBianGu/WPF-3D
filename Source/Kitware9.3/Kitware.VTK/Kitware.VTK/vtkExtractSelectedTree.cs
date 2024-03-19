using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractSelectedTree
	/// </summary>
	/// <remarks>
	///    return a subtree from a vtkTree
	///
	///
	/// input 0 --- a vtkTree
	/// input 1 --- a vtkSelection, containing selected vertices. It may have
	/// FILED_type set to POINTS ( a vertex selection) or CELLS (an edge selection).
	/// A vertex selection preserves the edges that connect selected vertices.
	/// An edge selection preserves the vertices that are adjacent to at least one
	/// selected edges.
	/// </remarks>
	// Token: 0x0200067D RID: 1661
	public class vtkExtractSelectedTree : vtkTreeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011E01 RID: 73217 RVA: 0x00190337 File Offset: 0x0018E537
		static vtkExtractSelectedTree()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedTree"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011E02 RID: 73218 RVA: 0x0019035F File Offset: 0x0018E55F
		public vtkExtractSelectedTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011E03 RID: 73219
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E04 RID: 73220 RVA: 0x00190370 File Offset: 0x0018E570
		public new static vtkExtractSelectedTree New()
		{
			vtkExtractSelectedTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedTree.vtkExtractSelectedTree_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E05 RID: 73221 RVA: 0x001903C4 File Offset: 0x0018E5C4
		public vtkExtractSelectedTree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractSelectedTree.vtkExtractSelectedTree_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011E06 RID: 73222 RVA: 0x00190408 File Offset: 0x0018E608
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011E07 RID: 73223
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedTree_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// A convenience method for setting the second input (i.e. the selection).
		/// </summary>
		// Token: 0x06011E08 RID: 73224 RVA: 0x00190414 File Offset: 0x0018E614
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkExtractSelectedTree.vtkExtractSelectedTree_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x06011E09 RID: 73225
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedTree_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E0A RID: 73226 RVA: 0x0019044C File Offset: 0x0018E64C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractSelectedTree.vtkExtractSelectedTree_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06011E0B RID: 73227
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedTree_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E0C RID: 73228 RVA: 0x0019046C File Offset: 0x0018E66C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractSelectedTree.vtkExtractSelectedTree_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06011E0D RID: 73229
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedTree_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E0E RID: 73230 RVA: 0x00190488 File Offset: 0x0018E688
		public override int IsA(string type)
		{
			return vtkExtractSelectedTree.vtkExtractSelectedTree_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06011E0F RID: 73231
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedTree_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E10 RID: 73232 RVA: 0x001904A8 File Offset: 0x0018E6A8
		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedTree.vtkExtractSelectedTree_IsTypeOf_05(type);
		}

		// Token: 0x06011E11 RID: 73233
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedTree_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E12 RID: 73234 RVA: 0x001904C4 File Offset: 0x0018E6C4
		public new vtkExtractSelectedTree NewInstance()
		{
			vtkExtractSelectedTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedTree.vtkExtractSelectedTree_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011E13 RID: 73235
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedTree_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E14 RID: 73236 RVA: 0x00190520 File Offset: 0x0018E720
		public new static vtkExtractSelectedTree SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedTree vtkExtractSelectedTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedTree.vtkExtractSelectedTree_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedTree = (vtkExtractSelectedTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedTree.Register(null);
				}
			}
			return vtkExtractSelectedTree;
		}

		// Token: 0x06011E15 RID: 73237
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedTree_SetSelectionConnection_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A convenience method for setting the second input (i.e. the selection).
		/// </summary>
		// Token: 0x06011E16 RID: 73238 RVA: 0x001905A0 File Offset: 0x0018E7A0
		public void SetSelectionConnection(vtkAlgorithmOutput arg0)
		{
			vtkExtractSelectedTree.vtkExtractSelectedTree_SetSelectionConnection_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400149F RID: 5279
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedTree";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014A0 RID: 5280
		public new static readonly string MRClassNameKey = "class vtkExtractSelectedTree";
	}
}
