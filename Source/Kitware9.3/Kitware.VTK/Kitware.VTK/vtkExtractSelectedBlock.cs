using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkExtractSelectedBlock
	/// </summary>
	/// <remarks>
	///  Extract-Selection filter to extract blocks.
	///
	/// vtkExtractSelectedBlock extracts blocks from a composite dataset on input 0
	/// using a vtkSelection on input 1.
	///
	/// IDs extracted can refer to leaf nodes or non-leaf nodes. When they refer to
	/// non-leaf nodes, the entire subtree is extracted.
	///
	/// Note: this filter uses `vtkCompositeDataSet::ShallowCopy`, as a result, datasets at
	/// leaf nodes are simply passed through, rather than being shallow-copied
	/// themselves.
	///
	/// @deprecated vtkExtractSelectedBlock is deprecated in VTK 9.2 and will be removed.
	/// Use `vtkExtractSelection` instead of `vtkExtractSelectedBlock`.
	///
	/// Example using vtkExtractSelectedBlock:
	///
	/// vtkNew&lt;vtkExtractSelectedBlock&gt; selFilter;
	/// selFilter-&gt;SetInputConnection(0, sphereSource-&gt;GetOutputPort());
	/// selFilter-&gt;SetInputConnection(1, selectionSource-&gt;GetOutputPort());
	///
	/// Example using vtkExtractSelection:
	///
	/// vtkNew&lt;vtkExtractSelection&gt; selFilter;
	/// selFilter-&gt;SetInputConnection(0, sphereSource-&gt;GetOutputPort());
	/// selFilter-&gt;SetInputConnection(1, selectionSource-&gt;GetOutputPort());
	/// </remarks>
	// Token: 0x020006B2 RID: 1714
	public class vtkExtractSelectedBlock : vtkExtractSelectionBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060124F9 RID: 75001 RVA: 0x0019A757 File Offset: 0x00198957
		static vtkExtractSelectedBlock()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedBlock.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedBlock"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060124FA RID: 75002 RVA: 0x0019A77F File Offset: 0x0019897F
		public vtkExtractSelectedBlock(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060124FB RID: 75003
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedBlock_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124FC RID: 75004 RVA: 0x0019A790 File Offset: 0x00198990
		public new static vtkExtractSelectedBlock New()
		{
			vtkExtractSelectedBlock result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedBlock.vtkExtractSelectedBlock_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedBlock)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060124FD RID: 75005 RVA: 0x0019A7E4 File Offset: 0x001989E4
		public vtkExtractSelectedBlock() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractSelectedBlock.vtkExtractSelectedBlock_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060124FE RID: 75006 RVA: 0x0019A828 File Offset: 0x00198A28
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060124FF RID: 75007
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedBlock_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012500 RID: 75008 RVA: 0x0019A834 File Offset: 0x00198A34
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractSelectedBlock.vtkExtractSelectedBlock_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012501 RID: 75009
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedBlock_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012502 RID: 75010 RVA: 0x0019A854 File Offset: 0x00198A54
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractSelectedBlock.vtkExtractSelectedBlock_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012503 RID: 75011
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedBlock_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012504 RID: 75012 RVA: 0x0019A870 File Offset: 0x00198A70
		public override int IsA(string type)
		{
			return vtkExtractSelectedBlock.vtkExtractSelectedBlock_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06012505 RID: 75013
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedBlock_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012506 RID: 75014 RVA: 0x0019A890 File Offset: 0x00198A90
		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedBlock.vtkExtractSelectedBlock_IsTypeOf_04(type);
		}

		// Token: 0x06012507 RID: 75015
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedBlock_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012508 RID: 75016 RVA: 0x0019A8AC File Offset: 0x00198AAC
		public new vtkExtractSelectedBlock NewInstance()
		{
			vtkExtractSelectedBlock result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedBlock.vtkExtractSelectedBlock_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedBlock)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012509 RID: 75017
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedBlock_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601250A RID: 75018 RVA: 0x0019A908 File Offset: 0x00198B08
		public new static vtkExtractSelectedBlock SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedBlock vtkExtractSelectedBlock = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedBlock.vtkExtractSelectedBlock_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedBlock = (vtkExtractSelectedBlock)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedBlock.Register(null);
				}
			}
			return vtkExtractSelectedBlock;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001512 RID: 5394
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedBlock";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001513 RID: 5395
		public new static readonly string MRClassNameKey = "class vtkExtractSelectedBlock";
	}
}
