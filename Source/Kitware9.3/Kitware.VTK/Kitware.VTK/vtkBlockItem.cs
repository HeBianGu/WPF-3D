using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBlockItem
	/// </summary>
	/// <remarks>
	///    a vtkContextItem that draws a block (optional label).
	///
	/// This is a vtkContextItem that can be placed into a vtkContextScene. It draws
	/// a block of the given dimensions, and reacts to mouse events.
	///
	/// vtkBlockItem can also be used to render label in the scene. The label
	/// properties can be set using `vtkTextProperty` accessed via
	/// `GetLabelProperties`.
	///
	/// </remarks>
	// Token: 0x020007A8 RID: 1960
	public class vtkBlockItem : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060141A1 RID: 82337 RVA: 0x001C6779 File Offset: 0x001C4979
		static vtkBlockItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBlockItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBlockItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060141A2 RID: 82338 RVA: 0x001C67A1 File Offset: 0x001C49A1
		public vtkBlockItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060141A3 RID: 82339
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060141A4 RID: 82340 RVA: 0x001C67B0 File Offset: 0x001C49B0
		public new static vtkBlockItem New()
		{
			vtkBlockItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlockItem.vtkBlockItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlockItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060141A5 RID: 82341 RVA: 0x001C6804 File Offset: 0x001C4A04
		public vtkBlockItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBlockItem.vtkBlockItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060141A6 RID: 82342 RVA: 0x001C6848 File Offset: 0x001C4A48
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060141A7 RID: 82343
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_AutoComputeDimensionsOff_01(HandleRef pThis);

		/// <summary>
		/// When set to true, the dimensions for the block are computed automatically
		/// using the anchor point, alignment at the size of the label.
		/// Otherwise the `Dimensions` are used.
		///
		/// Default is false i.e `Dimensions` will be used.
		/// </summary>
		// Token: 0x060141A8 RID: 82344 RVA: 0x001C6853 File Offset: 0x001C4A53
		public virtual void AutoComputeDimensionsOff()
		{
			vtkBlockItem.vtkBlockItem_AutoComputeDimensionsOff_01(base.GetCppThis());
		}

		// Token: 0x060141A9 RID: 82345
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_AutoComputeDimensionsOn_02(HandleRef pThis);

		/// <summary>
		/// When set to true, the dimensions for the block are computed automatically
		/// using the anchor point, alignment at the size of the label.
		/// Otherwise the `Dimensions` are used.
		///
		/// Default is false i.e `Dimensions` will be used.
		/// </summary>
		// Token: 0x060141AA RID: 82346 RVA: 0x001C6862 File Offset: 0x001C4A62
		public virtual void AutoComputeDimensionsOn()
		{
			vtkBlockItem.vtkBlockItem_AutoComputeDimensionsOn_02(base.GetCppThis());
		}

		// Token: 0x060141AB RID: 82347
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBlockItem_GetAutoComputeDimensions_03(HandleRef pThis);

		/// <summary>
		/// When set to true, the dimensions for the block are computed automatically
		/// using the anchor point, alignment at the size of the label.
		/// Otherwise the `Dimensions` are used.
		///
		/// Default is false i.e `Dimensions` will be used.
		/// </summary>
		// Token: 0x060141AC RID: 82348 RVA: 0x001C6874 File Offset: 0x001C4A74
		public virtual bool GetAutoComputeDimensions()
		{
			return vtkBlockItem.vtkBlockItem_GetAutoComputeDimensions_03(base.GetCppThis()) != 0;
		}

		// Token: 0x060141AD RID: 82349
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockItem_GetBrush_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the brush used to draw the block item background.
		/// </summary>
		// Token: 0x060141AE RID: 82350 RVA: 0x001C689C File Offset: 0x001C4A9C
		public virtual vtkBrush GetBrush()
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlockItem.vtkBlockItem_GetBrush_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBrush = (vtkBrush)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBrush.Register(null);
				}
			}
			return vtkBrush;
		}

		// Token: 0x060141AF RID: 82351
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockItem_GetDimensions_05(HandleRef pThis);

		/// <summary>
		/// Get the dimensions of the block, elements 0 and 1 are the x and y
		/// coordinate of the bottom corner. Elements 2 and 3 are the width and
		/// height.
		/// Initial value is (0,0,0,0)
		/// </summary>
		// Token: 0x060141B0 RID: 82352 RVA: 0x001C690C File Offset: 0x001C4B0C
		public virtual float[] GetDimensions()
		{
			IntPtr intPtr = vtkBlockItem.vtkBlockItem_GetDimensions_05(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060141B1 RID: 82353
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_GetDimensions_06(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4);

		/// <summary>
		/// Get the dimensions of the block, elements 0 and 1 are the x and y
		/// coordinate of the bottom corner. Elements 2 and 3 are the width and
		/// height.
		/// Initial value is (0,0,0,0)
		/// </summary>
		// Token: 0x060141B2 RID: 82354 RVA: 0x001C6954 File Offset: 0x001C4B54
		public virtual void GetDimensions(ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4)
		{
			vtkBlockItem.vtkBlockItem_GetDimensions_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x060141B3 RID: 82355
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_GetDimensions_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the dimensions of the block, elements 0 and 1 are the x and y
		/// coordinate of the bottom corner. Elements 2 and 3 are the width and
		/// height.
		/// Initial value is (0,0,0,0)
		/// </summary>
		// Token: 0x060141B4 RID: 82356 RVA: 0x001C6968 File Offset: 0x001C4B68
		public virtual void GetDimensions(IntPtr _arg)
		{
			vtkBlockItem.vtkBlockItem_GetDimensions_07(base.GetCppThis(), _arg);
		}

		// Token: 0x060141B5 RID: 82357
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlockItem_GetHorizontalAlignment_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the horizontal alignment of the legend to the point specified.
		/// Valid values are LEFT, CENTER and RIGHT.
		/// </summary>
		// Token: 0x060141B6 RID: 82358 RVA: 0x001C6978 File Offset: 0x001C4B78
		public virtual int GetHorizontalAlignment()
		{
			return vtkBlockItem.vtkBlockItem_GetHorizontalAlignment_08(base.GetCppThis());
		}

		// Token: 0x060141B7 RID: 82359
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkBlockItem_GetLabel_09(HandleRef pThis);

		/// <summary>
		/// Get the block label.
		/// </summary>
		// Token: 0x060141B8 RID: 82360 RVA: 0x001C6998 File Offset: 0x001C4B98
		public virtual string GetLabel()
		{
			return vtkBlockItem.vtkBlockItem_GetLabel_09(base.GetCppThis());
		}

		// Token: 0x060141B9 RID: 82361
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockItem_GetLabelProperties_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Provides access to the vtkTextProperty object that controls the way the
		/// label is rendered.
		/// </summary>
		// Token: 0x060141BA RID: 82362 RVA: 0x001C69B8 File Offset: 0x001C4BB8
		public virtual vtkTextProperty GetLabelProperties()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlockItem.vtkBlockItem_GetLabelProperties_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x060141BB RID: 82363
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockItem_GetMargins_11(HandleRef pThis);

		/// <summary>
		/// When AutoComputeDimensions is true, these are the margins from the edge of
		/// the viewport to use when placing the block based on HorizontalAlignment and
		/// VerticalAlignment preferences.
		/// </summary>
		// Token: 0x060141BC RID: 82364 RVA: 0x001C6A28 File Offset: 0x001C4C28
		public virtual int[] GetMargins()
		{
			IntPtr intPtr = vtkBlockItem.vtkBlockItem_GetMargins_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060141BD RID: 82365
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_GetMargins_12(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// When AutoComputeDimensions is true, these are the margins from the edge of
		/// the viewport to use when placing the block based on HorizontalAlignment and
		/// VerticalAlignment preferences.
		/// </summary>
		// Token: 0x060141BE RID: 82366 RVA: 0x001C6A70 File Offset: 0x001C4C70
		public virtual void GetMargins(ref int _arg1, ref int _arg2)
		{
			vtkBlockItem.vtkBlockItem_GetMargins_12(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060141BF RID: 82367
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_GetMargins_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// When AutoComputeDimensions is true, these are the margins from the edge of
		/// the viewport to use when placing the block based on HorizontalAlignment and
		/// VerticalAlignment preferences.
		/// </summary>
		// Token: 0x060141C0 RID: 82368 RVA: 0x001C6A81 File Offset: 0x001C4C81
		public virtual void GetMargins(IntPtr _arg)
		{
			vtkBlockItem.vtkBlockItem_GetMargins_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060141C1 RID: 82369
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockItem_GetMouseOverBrush_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the brush used to draw the block item background when the
		/// item is "hit" i.e. interaction is enabled and the mouse is over the block.
		/// </summary>
		// Token: 0x060141C2 RID: 82370 RVA: 0x001C6A94 File Offset: 0x001C4C94
		public virtual vtkBrush GetMouseOverBrush()
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlockItem.vtkBlockItem_GetMouseOverBrush_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBrush = (vtkBrush)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBrush.Register(null);
				}
			}
			return vtkBrush;
		}

		// Token: 0x060141C3 RID: 82371
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBlockItem_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060141C4 RID: 82372 RVA: 0x001C6B04 File Offset: 0x001C4D04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBlockItem.vtkBlockItem_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x060141C5 RID: 82373
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBlockItem_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060141C6 RID: 82374 RVA: 0x001C6B24 File Offset: 0x001C4D24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBlockItem.vtkBlockItem_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x060141C7 RID: 82375
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockItem_GetPadding_17(HandleRef pThis);

		/// <summary>
		/// When AutoComputeDimensions is true, these are the padding for the label
		/// within the block.
		///
		/// Default is (5, 5).
		/// </summary>
		// Token: 0x060141C8 RID: 82376 RVA: 0x001C6B40 File Offset: 0x001C4D40
		public virtual int[] GetPadding()
		{
			IntPtr intPtr = vtkBlockItem.vtkBlockItem_GetPadding_17(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060141C9 RID: 82377
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_GetPadding_18(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// When AutoComputeDimensions is true, these are the padding for the label
		/// within the block.
		///
		/// Default is (5, 5).
		/// </summary>
		// Token: 0x060141CA RID: 82378 RVA: 0x001C6B88 File Offset: 0x001C4D88
		public virtual void GetPadding(ref int _arg1, ref int _arg2)
		{
			vtkBlockItem.vtkBlockItem_GetPadding_18(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060141CB RID: 82379
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_GetPadding_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// When AutoComputeDimensions is true, these are the padding for the label
		/// within the block.
		///
		/// Default is (5, 5).
		/// </summary>
		// Token: 0x060141CC RID: 82380 RVA: 0x001C6B99 File Offset: 0x001C4D99
		public virtual void GetPadding(IntPtr _arg)
		{
			vtkBlockItem.vtkBlockItem_GetPadding_19(base.GetCppThis(), _arg);
		}

		// Token: 0x060141CD RID: 82381
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockItem_GetPen_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get pen used to draw the block item outline.
		/// </summary>
		// Token: 0x060141CE RID: 82382 RVA: 0x001C6BAC File Offset: 0x001C4DAC
		public virtual vtkPen GetPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlockItem.vtkBlockItem_GetPen_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		// Token: 0x060141CF RID: 82383
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlockItem_GetVerticalAlignment_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the vertical alignment of the legend to the point specified.
		/// Valid values are TOP, CENTER and BOTTOM.
		/// </summary>
		// Token: 0x060141D0 RID: 82384 RVA: 0x001C6C1C File Offset: 0x001C4E1C
		public virtual int GetVerticalAlignment()
		{
			return vtkBlockItem.vtkBlockItem_GetVerticalAlignment_21(base.GetCppThis());
		}

		// Token: 0x060141D1 RID: 82385
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlockItem_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060141D2 RID: 82386 RVA: 0x001C6C3C File Offset: 0x001C4E3C
		public override int IsA(string type)
		{
			return vtkBlockItem.vtkBlockItem_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x060141D3 RID: 82387
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlockItem_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060141D4 RID: 82388 RVA: 0x001C6C5C File Offset: 0x001C4E5C
		public new static int IsTypeOf(string type)
		{
			return vtkBlockItem.vtkBlockItem_IsTypeOf_23(type);
		}

		// Token: 0x060141D5 RID: 82389
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockItem_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060141D6 RID: 82390 RVA: 0x001C6C78 File Offset: 0x001C4E78
		public new vtkBlockItem NewInstance()
		{
			vtkBlockItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlockItem.vtkBlockItem_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlockItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060141D7 RID: 82391
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBlockItem_Paint_26(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the item.
		/// </summary>
		// Token: 0x060141D8 RID: 82392 RVA: 0x001C6CD4 File Offset: 0x001C4ED4
		public override bool Paint(vtkContext2D painter)
		{
			return vtkBlockItem.vtkBlockItem_Paint_26(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060141D9 RID: 82393
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockItem_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060141DA RID: 82394 RVA: 0x001C6D10 File Offset: 0x001C4F10
		public new static vtkBlockItem SafeDownCast(vtkObjectBase o)
		{
			vtkBlockItem vtkBlockItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlockItem.vtkBlockItem_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBlockItem = (vtkBlockItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBlockItem.Register(null);
				}
			}
			return vtkBlockItem;
		}

		// Token: 0x060141DB RID: 82395
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_SetAutoComputeDimensions_28(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true, the dimensions for the block are computed automatically
		/// using the anchor point, alignment at the size of the label.
		/// Otherwise the `Dimensions` are used.
		///
		/// Default is false i.e `Dimensions` will be used.
		/// </summary>
		// Token: 0x060141DC RID: 82396 RVA: 0x001C6D8F File Offset: 0x001C4F8F
		public virtual void SetAutoComputeDimensions(bool _arg)
		{
			vtkBlockItem.vtkBlockItem_SetAutoComputeDimensions_28(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060141DD RID: 82397
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_SetDimensions_29(HandleRef pThis, float _arg1, float _arg2, float _arg3, float _arg4);

		/// <summary>
		/// Set the dimensions of the block, elements 0 and 1 are the x and y
		/// coordinate of the bottom corner. Elements 2 and 3 are the width and
		/// height.
		/// Initial value is (0,0,0,0).
		/// </summary>
		// Token: 0x060141DE RID: 82398 RVA: 0x001C6DA7 File Offset: 0x001C4FA7
		public virtual void SetDimensions(float _arg1, float _arg2, float _arg3, float _arg4)
		{
			vtkBlockItem.vtkBlockItem_SetDimensions_29(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x060141DF RID: 82399
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_SetDimensions_30(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the dimensions of the block, elements 0 and 1 are the x and y
		/// coordinate of the bottom corner. Elements 2 and 3 are the width and
		/// height.
		/// Initial value is (0,0,0,0).
		/// </summary>
		// Token: 0x060141E0 RID: 82400 RVA: 0x001C6DBB File Offset: 0x001C4FBB
		public virtual void SetDimensions(IntPtr _arg)
		{
			vtkBlockItem.vtkBlockItem_SetDimensions_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060141E1 RID: 82401
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_SetHorizontalAlignment_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the horizontal alignment of the legend to the point specified.
		/// Valid values are LEFT, CENTER and RIGHT.
		/// </summary>
		// Token: 0x060141E2 RID: 82402 RVA: 0x001C6DCB File Offset: 0x001C4FCB
		public virtual void SetHorizontalAlignment(int _arg)
		{
			vtkBlockItem.vtkBlockItem_SetHorizontalAlignment_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060141E3 RID: 82403
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_SetLabel_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string label);

		/// <summary>
		/// Set the block label.
		/// </summary>
		// Token: 0x060141E4 RID: 82404 RVA: 0x001C6DDB File Offset: 0x001C4FDB
		public virtual void SetLabel(string label)
		{
			vtkBlockItem.vtkBlockItem_SetLabel_32(base.GetCppThis(), label);
		}

		// Token: 0x060141E5 RID: 82405
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_SetLabelProperties_33(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Provides access to the vtkTextProperty object that controls the way the
		/// label is rendered.
		/// </summary>
		// Token: 0x060141E6 RID: 82406 RVA: 0x001C6DEC File Offset: 0x001C4FEC
		public void SetLabelProperties(vtkTextProperty arg0)
		{
			vtkBlockItem.vtkBlockItem_SetLabelProperties_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060141E7 RID: 82407
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_SetMargins_34(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// When AutoComputeDimensions is true, these are the margins from the edge of
		/// the viewport to use when placing the block based on HorizontalAlignment and
		/// VerticalAlignment preferences.
		/// </summary>
		// Token: 0x060141E8 RID: 82408 RVA: 0x001C6E1B File Offset: 0x001C501B
		public virtual void SetMargins(int _arg1, int _arg2)
		{
			vtkBlockItem.vtkBlockItem_SetMargins_34(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060141E9 RID: 82409
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_SetMargins_35(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// When AutoComputeDimensions is true, these are the margins from the edge of
		/// the viewport to use when placing the block based on HorizontalAlignment and
		/// VerticalAlignment preferences.
		/// </summary>
		// Token: 0x060141EA RID: 82410 RVA: 0x001C6E2C File Offset: 0x001C502C
		public void SetMargins(IntPtr _arg)
		{
			vtkBlockItem.vtkBlockItem_SetMargins_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060141EB RID: 82411
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_SetPadding_36(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// When AutoComputeDimensions is true, these are the padding for the label
		/// within the block.
		///
		/// Default is (5, 5).
		/// </summary>
		// Token: 0x060141EC RID: 82412 RVA: 0x001C6E3C File Offset: 0x001C503C
		public virtual void SetPadding(int _arg1, int _arg2)
		{
			vtkBlockItem.vtkBlockItem_SetPadding_36(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060141ED RID: 82413
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_SetPadding_37(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// When AutoComputeDimensions is true, these are the padding for the label
		/// within the block.
		///
		/// Default is (5, 5).
		/// </summary>
		// Token: 0x060141EE RID: 82414 RVA: 0x001C6E4D File Offset: 0x001C504D
		public void SetPadding(IntPtr _arg)
		{
			vtkBlockItem.vtkBlockItem_SetPadding_37(base.GetCppThis(), _arg);
		}

		// Token: 0x060141EF RID: 82415
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlockItem_SetVerticalAlignment_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the vertical alignment of the legend to the point specified.
		/// Valid values are TOP, CENTER and BOTTOM.
		/// </summary>
		// Token: 0x060141F0 RID: 82416 RVA: 0x001C6E5D File Offset: 0x001C505D
		public virtual void SetVerticalAlignment(int _arg)
		{
			vtkBlockItem.vtkBlockItem_SetVerticalAlignment_38(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001754 RID: 5972
		public new const string MRFullTypeName = "Kitware.VTK.vtkBlockItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001755 RID: 5973
		public new static readonly string MRClassNameKey = "class vtkBlockItem";

		/// <summary>
		/// When set to true, the dimensions for the block are computed automatically
		/// using the anchor point, alignment at the size of the label.
		/// Otherwise the `Dimensions` are used.
		///
		/// Default is false i.e `Dimensions` will be used.
		/// </summary>
		// Token: 0x020007A9 RID: 1961
		public enum BOTTOM_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001757 RID: 5975
			BOTTOM = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001758 RID: 5976
			CENTER = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001759 RID: 5977
			CUSTOM = 5,
			/// <summary>enum member</summary>
			// Token: 0x0400175A RID: 5978
			LEFT = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400175B RID: 5979
			RIGHT = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400175C RID: 5980
			TOP
		}
	}
}
