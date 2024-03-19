using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkExpandMarkedElements
	/// </summary>
	/// <remarks>
	///  expands marked elements to including adjacent elements.
	///
	/// vtkExpandMarkedElements is intended to expand selected cells to
	/// grow to include adjacent cells. The filter works across all blocks in a
	/// composite dataset and across all ranks. Besides cells, the filter can be used
	/// to expand selected points instead in which case adjacent points are defined
	/// as points on any cell that has the source point as one of its points.
	///
	/// The selected cells (or points) are indicated by a `vtkSignedCharArray` on
	/// cell-data (or point-data). The array can be selected by using
	/// `SetInputArrayToProcess(0, 0, 0,...)` (see
	/// vtkAlgorithm::SetInputArrayToProcess).
	///
	/// Currently, the filter only supports expanding marked elements for cells and
	/// points.
	/// </remarks>
	// Token: 0x020006A5 RID: 1701
	public class vtkExpandMarkedElements : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601232E RID: 74542 RVA: 0x00197F8F File Offset: 0x0019618F
		static vtkExpandMarkedElements()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExpandMarkedElements.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExpandMarkedElements"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601232F RID: 74543 RVA: 0x00197FB7 File Offset: 0x001961B7
		public vtkExpandMarkedElements(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012330 RID: 74544
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExpandMarkedElements_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012331 RID: 74545 RVA: 0x00197FC8 File Offset: 0x001961C8
		public new static vtkExpandMarkedElements New()
		{
			vtkExpandMarkedElements result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExpandMarkedElements.vtkExpandMarkedElements_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExpandMarkedElements)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012332 RID: 74546 RVA: 0x0019801C File Offset: 0x0019621C
		public vtkExpandMarkedElements() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExpandMarkedElements.vtkExpandMarkedElements_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012333 RID: 74547 RVA: 0x00198060 File Offset: 0x00196260
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012334 RID: 74548
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExpandMarkedElements_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the controller to use. By default, is initialized to
		/// `vtkMultiProcessController::GetGlobalController` in the constructor.
		/// </summary>
		// Token: 0x06012335 RID: 74549 RVA: 0x0019806C File Offset: 0x0019626C
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExpandMarkedElements.vtkExpandMarkedElements_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x06012336 RID: 74550
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExpandMarkedElements_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012337 RID: 74551 RVA: 0x001980DC File Offset: 0x001962DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExpandMarkedElements.vtkExpandMarkedElements_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06012338 RID: 74552
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExpandMarkedElements_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012339 RID: 74553 RVA: 0x001980FC File Offset: 0x001962FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExpandMarkedElements.vtkExpandMarkedElements_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601233A RID: 74554
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExpandMarkedElements_GetNumberOfLayers_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of layers to expand by.
		/// Default is 2.
		/// </summary>
		// Token: 0x0601233B RID: 74555 RVA: 0x00198118 File Offset: 0x00196318
		public virtual int GetNumberOfLayers()
		{
			return vtkExpandMarkedElements.vtkExpandMarkedElements_GetNumberOfLayers_04(base.GetCppThis());
		}

		// Token: 0x0601233C RID: 74556
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExpandMarkedElements_GetNumberOfLayersMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of layers to expand by.
		/// Default is 2.
		/// </summary>
		// Token: 0x0601233D RID: 74557 RVA: 0x00198138 File Offset: 0x00196338
		public virtual int GetNumberOfLayersMaxValue()
		{
			return vtkExpandMarkedElements.vtkExpandMarkedElements_GetNumberOfLayersMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0601233E RID: 74558
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExpandMarkedElements_GetNumberOfLayersMinValue_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of layers to expand by.
		/// Default is 2.
		/// </summary>
		// Token: 0x0601233F RID: 74559 RVA: 0x00198158 File Offset: 0x00196358
		public virtual int GetNumberOfLayersMinValue()
		{
			return vtkExpandMarkedElements.vtkExpandMarkedElements_GetNumberOfLayersMinValue_06(base.GetCppThis());
		}

		// Token: 0x06012340 RID: 74560
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExpandMarkedElements_GetRemoveIntermediateLayers_07(HandleRef pThis);

		/// <summary>
		/// Get/Set the flag to remove intermediate layers
		/// Default is false.
		/// </summary>
		// Token: 0x06012341 RID: 74561 RVA: 0x00198178 File Offset: 0x00196378
		public virtual bool GetRemoveIntermediateLayers()
		{
			return vtkExpandMarkedElements.vtkExpandMarkedElements_GetRemoveIntermediateLayers_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06012342 RID: 74562
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExpandMarkedElements_GetRemoveSeed_08(HandleRef pThis);

		/// <summary>
		/// Get/Set the flag to remove seed of marked elements.
		/// Default is false.
		/// </summary>
		// Token: 0x06012343 RID: 74563 RVA: 0x001981A0 File Offset: 0x001963A0
		public virtual bool GetRemoveSeed()
		{
			return vtkExpandMarkedElements.vtkExpandMarkedElements_GetRemoveSeed_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06012344 RID: 74564
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExpandMarkedElements_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012345 RID: 74565 RVA: 0x001981C8 File Offset: 0x001963C8
		public override int IsA(string type)
		{
			return vtkExpandMarkedElements.vtkExpandMarkedElements_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06012346 RID: 74566
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExpandMarkedElements_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012347 RID: 74567 RVA: 0x001981E8 File Offset: 0x001963E8
		public new static int IsTypeOf(string type)
		{
			return vtkExpandMarkedElements.vtkExpandMarkedElements_IsTypeOf_10(type);
		}

		// Token: 0x06012348 RID: 74568
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExpandMarkedElements_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012349 RID: 74569 RVA: 0x00198204 File Offset: 0x00196404
		public new vtkExpandMarkedElements NewInstance()
		{
			vtkExpandMarkedElements result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExpandMarkedElements.vtkExpandMarkedElements_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExpandMarkedElements)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601234A RID: 74570
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandMarkedElements_RemoveIntermediateLayersOff_13(HandleRef pThis);

		/// <summary>
		/// Get/Set the flag to remove intermediate layers
		/// Default is false.
		/// </summary>
		// Token: 0x0601234B RID: 74571 RVA: 0x0019825E File Offset: 0x0019645E
		public virtual void RemoveIntermediateLayersOff()
		{
			vtkExpandMarkedElements.vtkExpandMarkedElements_RemoveIntermediateLayersOff_13(base.GetCppThis());
		}

		// Token: 0x0601234C RID: 74572
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandMarkedElements_RemoveIntermediateLayersOn_14(HandleRef pThis);

		/// <summary>
		/// Get/Set the flag to remove intermediate layers
		/// Default is false.
		/// </summary>
		// Token: 0x0601234D RID: 74573 RVA: 0x0019826D File Offset: 0x0019646D
		public virtual void RemoveIntermediateLayersOn()
		{
			vtkExpandMarkedElements.vtkExpandMarkedElements_RemoveIntermediateLayersOn_14(base.GetCppThis());
		}

		// Token: 0x0601234E RID: 74574
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandMarkedElements_RemoveSeedOff_15(HandleRef pThis);

		/// <summary>
		/// Get/Set the flag to remove seed of marked elements.
		/// Default is false.
		/// </summary>
		// Token: 0x0601234F RID: 74575 RVA: 0x0019827C File Offset: 0x0019647C
		public virtual void RemoveSeedOff()
		{
			vtkExpandMarkedElements.vtkExpandMarkedElements_RemoveSeedOff_15(base.GetCppThis());
		}

		// Token: 0x06012350 RID: 74576
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandMarkedElements_RemoveSeedOn_16(HandleRef pThis);

		/// <summary>
		/// Get/Set the flag to remove seed of marked elements.
		/// Default is false.
		/// </summary>
		// Token: 0x06012351 RID: 74577 RVA: 0x0019828B File Offset: 0x0019648B
		public virtual void RemoveSeedOn()
		{
			vtkExpandMarkedElements.vtkExpandMarkedElements_RemoveSeedOn_16(base.GetCppThis());
		}

		// Token: 0x06012352 RID: 74578
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExpandMarkedElements_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012353 RID: 74579 RVA: 0x0019829C File Offset: 0x0019649C
		public new static vtkExpandMarkedElements SafeDownCast(vtkObjectBase o)
		{
			vtkExpandMarkedElements vtkExpandMarkedElements = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExpandMarkedElements.vtkExpandMarkedElements_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExpandMarkedElements = (vtkExpandMarkedElements)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExpandMarkedElements.Register(null);
				}
			}
			return vtkExpandMarkedElements;
		}

		// Token: 0x06012354 RID: 74580
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandMarkedElements_SetController_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the controller to use. By default, is initialized to
		/// `vtkMultiProcessController::GetGlobalController` in the constructor.
		/// </summary>
		// Token: 0x06012355 RID: 74581 RVA: 0x0019831C File Offset: 0x0019651C
		public void SetController(vtkMultiProcessController arg0)
		{
			vtkExpandMarkedElements.vtkExpandMarkedElements_SetController_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06012356 RID: 74582
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandMarkedElements_SetNumberOfLayers_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the number of layers to expand by.
		/// Default is 2.
		/// </summary>
		// Token: 0x06012357 RID: 74583 RVA: 0x0019834B File Offset: 0x0019654B
		public virtual void SetNumberOfLayers(int _arg)
		{
			vtkExpandMarkedElements.vtkExpandMarkedElements_SetNumberOfLayers_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06012358 RID: 74584
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandMarkedElements_SetRemoveIntermediateLayers_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set the flag to remove intermediate layers
		/// Default is false.
		/// </summary>
		// Token: 0x06012359 RID: 74585 RVA: 0x0019835B File Offset: 0x0019655B
		public virtual void SetRemoveIntermediateLayers(bool _arg)
		{
			vtkExpandMarkedElements.vtkExpandMarkedElements_SetRemoveIntermediateLayers_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601235A RID: 74586
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandMarkedElements_SetRemoveSeed_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set the flag to remove seed of marked elements.
		/// Default is false.
		/// </summary>
		// Token: 0x0601235B RID: 74587 RVA: 0x00198373 File Offset: 0x00196573
		public virtual void SetRemoveSeed(bool _arg)
		{
			vtkExpandMarkedElements.vtkExpandMarkedElements_SetRemoveSeed_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014F8 RID: 5368
		public new const string MRFullTypeName = "Kitware.VTK.vtkExpandMarkedElements";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014F9 RID: 5369
		public new static readonly string MRClassNameKey = "class vtkExpandMarkedElements";
	}
}
