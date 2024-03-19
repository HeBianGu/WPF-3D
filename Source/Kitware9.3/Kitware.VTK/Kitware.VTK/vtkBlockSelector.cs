using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkBlockSelector
	/// </summary>
	/// <remarks>
	///  selector for blocks
	///
	/// Selects cells or points contained in a block as defined in the
	/// vtkSelectionNode used to initialize this operator.
	///
	/// This selector supports vtkSelectionNode::BLOCKS and
	/// vtkSelectionNode::BLOCK_SELECTORS.
	/// </remarks>
	// Token: 0x020006A3 RID: 1699
	public class vtkBlockSelector : vtkSelector
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060122C4 RID: 74436 RVA: 0x0019720B File Offset: 0x0019540B
		static vtkBlockSelector()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBlockSelector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBlockSelector"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060122C5 RID: 74437 RVA: 0x00197233 File Offset: 0x00195433
		public vtkBlockSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060122C6 RID: 74438
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122C7 RID: 74439 RVA: 0x00197244 File Offset: 0x00195444
		public new static vtkBlockSelector New()
		{
			vtkBlockSelector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlockSelector.vtkBlockSelector_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlockSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122C8 RID: 74440 RVA: 0x00197298 File Offset: 0x00195498
		public vtkBlockSelector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBlockSelector.vtkBlockSelector_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060122C9 RID: 74441 RVA: 0x001972DC File Offset: 0x001954DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060122CA RID: 74442
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockSelector_Execute_01(HandleRef pThis, HandleRef input, HandleRef output);

		/// <summary>
		/// Overridden to handle `BLOCK_SELECTORS`. We need the data to convert
		/// selector expressions to composite indices for quick check if block is
		/// selected. We do that here.
		/// </summary>
		// Token: 0x060122CB RID: 74443 RVA: 0x001972E8 File Offset: 0x001954E8
		public override void Execute(vtkDataObject input, vtkDataObject output)
		{
			vtkBlockSelector.vtkBlockSelector_Execute_01(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x060122CC RID: 74444
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBlockSelector_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122CD RID: 74445 RVA: 0x0019732C File Offset: 0x0019552C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBlockSelector.vtkBlockSelector_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060122CE RID: 74446
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBlockSelector_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122CF RID: 74447 RVA: 0x0019734C File Offset: 0x0019554C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBlockSelector.vtkBlockSelector_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060122D0 RID: 74448
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockSelector_Initialize_04(HandleRef pThis, HandleRef node);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122D1 RID: 74449 RVA: 0x00197368 File Offset: 0x00195568
		public override void Initialize(vtkSelectionNode node)
		{
			vtkBlockSelector.vtkBlockSelector_Initialize_04(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis());
		}

		// Token: 0x060122D2 RID: 74450
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlockSelector_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122D3 RID: 74451 RVA: 0x00197398 File Offset: 0x00195598
		public override int IsA(string type)
		{
			return vtkBlockSelector.vtkBlockSelector_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060122D4 RID: 74452
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlockSelector_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122D5 RID: 74453 RVA: 0x001973B8 File Offset: 0x001955B8
		public new static int IsTypeOf(string type)
		{
			return vtkBlockSelector.vtkBlockSelector_IsTypeOf_06(type);
		}

		// Token: 0x060122D6 RID: 74454
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockSelector_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122D7 RID: 74455 RVA: 0x001973D4 File Offset: 0x001955D4
		public new vtkBlockSelector NewInstance()
		{
			vtkBlockSelector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlockSelector.vtkBlockSelector_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlockSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060122D8 RID: 74456
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockSelector_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122D9 RID: 74457 RVA: 0x00197430 File Offset: 0x00195630
		public new static vtkBlockSelector SafeDownCast(vtkObjectBase o)
		{
			vtkBlockSelector vtkBlockSelector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlockSelector.vtkBlockSelector_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBlockSelector = (vtkBlockSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBlockSelector.Register(null);
				}
			}
			return vtkBlockSelector;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014F4 RID: 5364
		public new const string MRFullTypeName = "Kitware.VTK.vtkBlockSelector";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014F5 RID: 5365
		public new static readonly string MRClassNameKey = "class vtkBlockSelector";
	}
}
