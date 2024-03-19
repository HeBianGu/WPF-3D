using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCategoryLegend
	/// </summary>
	/// <remarks>
	///    Legend item to display categorical data.
	///
	/// vtkCategoryLegend will display a label and color patch for each value
	/// in a categorical data set.  To use this class, you must first populate
	/// a vtkScalarsToColors by using the SetAnnotation() method.  The other
	/// input to this class is a vtkVariantArray.  This should contain the
	/// annotated values from the vtkScalarsToColors that you wish to include
	/// within the legend.
	/// </remarks>
	// Token: 0x02000633 RID: 1587
	public class vtkCategoryLegend : vtkChartLegend
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060112DE RID: 70366 RVA: 0x0017EF0A File Offset: 0x0017D10A
		static vtkCategoryLegend()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCategoryLegend.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCategoryLegend"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060112DF RID: 70367 RVA: 0x0017EF32 File Offset: 0x0017D132
		public vtkCategoryLegend(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060112E0 RID: 70368
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCategoryLegend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060112E1 RID: 70369 RVA: 0x0017EF40 File Offset: 0x0017D140
		public new static vtkCategoryLegend New()
		{
			vtkCategoryLegend result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCategoryLegend.vtkCategoryLegend_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCategoryLegend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060112E2 RID: 70370 RVA: 0x0017EF94 File Offset: 0x0017D194
		public vtkCategoryLegend() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCategoryLegend.vtkCategoryLegend_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060112E3 RID: 70371 RVA: 0x0017EFD8 File Offset: 0x0017D1D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060112E4 RID: 70372
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCategoryLegend_GetBoundingRect_01(HandleRef pThis, HandleRef painter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Compute and return the lower left corner of this legend, along
		/// with its width and height.
		/// </summary>
		// Token: 0x060112E5 RID: 70373 RVA: 0x0017EFE4 File Offset: 0x0017D1E4
		public override vtkRectf GetBoundingRect(vtkContext2D painter)
		{
			vtkRectf result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCategoryLegend.vtkCategoryLegend_GetBoundingRect_01(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectf)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060112E6 RID: 70374
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCategoryLegend_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060112E7 RID: 70375 RVA: 0x0017F054 File Offset: 0x0017D254
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCategoryLegend.vtkCategoryLegend_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060112E8 RID: 70376
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCategoryLegend_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060112E9 RID: 70377 RVA: 0x0017F074 File Offset: 0x0017D274
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCategoryLegend.vtkCategoryLegend_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060112EA RID: 70378
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkCategoryLegend_GetOutlierLabel_04(HandleRef pThis);

		/// <summary>
		/// Get/set the label to use for outlier data.
		/// </summary>
		// Token: 0x060112EB RID: 70379 RVA: 0x0017F090 File Offset: 0x0017D290
		public virtual string GetOutlierLabel()
		{
			return vtkCategoryLegend.vtkCategoryLegend_GetOutlierLabel_04(base.GetCppThis());
		}

		// Token: 0x060112EC RID: 70380
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCategoryLegend_GetScalarsToColors_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the vtkScalarsToColors used to draw this legend.
		/// Since this legend represents categorical data, this
		/// vtkScalarsToColors must have been populated using SetAnnotation().
		/// </summary>
		// Token: 0x060112ED RID: 70381 RVA: 0x0017F0B0 File Offset: 0x0017D2B0
		public virtual vtkScalarsToColors GetScalarsToColors()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCategoryLegend.vtkCategoryLegend_GetScalarsToColors_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		// Token: 0x060112EE RID: 70382
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkCategoryLegend_GetTitle_06(HandleRef pThis);

		/// <summary>
		/// Get/set the title text of the legend.
		/// </summary>
		// Token: 0x060112EF RID: 70383 RVA: 0x0017F120 File Offset: 0x0017D320
		public virtual string GetTitle()
		{
			return vtkCategoryLegend.vtkCategoryLegend_GetTitle_06(base.GetCppThis());
		}

		// Token: 0x060112F0 RID: 70384
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCategoryLegend_GetValues_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the array of values that will be represented by this legend.
		/// This array must contain distinct annotated values from the ScalarsToColors.
		/// Each value in this array will be drawn as a separate entry within this
		/// legend.
		/// </summary>
		// Token: 0x060112F1 RID: 70385 RVA: 0x0017F140 File Offset: 0x0017D340
		public virtual vtkVariantArray GetValues()
		{
			vtkVariantArray vtkVariantArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCategoryLegend.vtkCategoryLegend_GetValues_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVariantArray = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVariantArray.Register(null);
				}
			}
			return vtkVariantArray;
		}

		// Token: 0x060112F2 RID: 70386
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCategoryLegend_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060112F3 RID: 70387 RVA: 0x0017F1B0 File Offset: 0x0017D3B0
		public override int IsA(string type)
		{
			return vtkCategoryLegend.vtkCategoryLegend_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060112F4 RID: 70388
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCategoryLegend_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060112F5 RID: 70389 RVA: 0x0017F1D0 File Offset: 0x0017D3D0
		public new static int IsTypeOf(string type)
		{
			return vtkCategoryLegend.vtkCategoryLegend_IsTypeOf_09(type);
		}

		// Token: 0x060112F6 RID: 70390
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCategoryLegend_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060112F7 RID: 70391 RVA: 0x0017F1EC File Offset: 0x0017D3EC
		public new vtkCategoryLegend NewInstance()
		{
			vtkCategoryLegend result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCategoryLegend.vtkCategoryLegend_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCategoryLegend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060112F8 RID: 70392
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCategoryLegend_Paint_12(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint the legend into a rectangle defined by the bounds.
		/// </summary>
		// Token: 0x060112F9 RID: 70393 RVA: 0x0017F248 File Offset: 0x0017D448
		public override bool Paint(vtkContext2D painter)
		{
			return vtkCategoryLegend.vtkCategoryLegend_Paint_12(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060112FA RID: 70394
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCategoryLegend_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060112FB RID: 70395 RVA: 0x0017F284 File Offset: 0x0017D484
		public new static vtkCategoryLegend SafeDownCast(vtkObjectBase o)
		{
			vtkCategoryLegend vtkCategoryLegend = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCategoryLegend.vtkCategoryLegend_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCategoryLegend = (vtkCategoryLegend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCategoryLegend.Register(null);
				}
			}
			return vtkCategoryLegend;
		}

		// Token: 0x060112FC RID: 70396
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCategoryLegend_SetOutlierLabel_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/set the label to use for outlier data.
		/// </summary>
		// Token: 0x060112FD RID: 70397 RVA: 0x0017F303 File Offset: 0x0017D503
		public virtual void SetOutlierLabel(string _arg)
		{
			vtkCategoryLegend.vtkCategoryLegend_SetOutlierLabel_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060112FE RID: 70398
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCategoryLegend_SetScalarsToColors_15(HandleRef pThis, HandleRef stc);

		/// <summary>
		/// Get/Set the vtkScalarsToColors used to draw this legend.
		/// Since this legend represents categorical data, this
		/// vtkScalarsToColors must have been populated using SetAnnotation().
		/// </summary>
		// Token: 0x060112FF RID: 70399 RVA: 0x0017F314 File Offset: 0x0017D514
		public virtual void SetScalarsToColors(vtkScalarsToColors stc)
		{
			vtkCategoryLegend.vtkCategoryLegend_SetScalarsToColors_15(base.GetCppThis(), (stc == null) ? default(HandleRef) : stc.GetCppThis());
		}

		// Token: 0x06011300 RID: 70400
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCategoryLegend_SetTitle_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string title);

		/// <summary>
		/// Get/set the title text of the legend.
		/// </summary>
		// Token: 0x06011301 RID: 70401 RVA: 0x0017F343 File Offset: 0x0017D543
		public virtual void SetTitle(string title)
		{
			vtkCategoryLegend.vtkCategoryLegend_SetTitle_16(base.GetCppThis(), title);
		}

		// Token: 0x06011302 RID: 70402
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCategoryLegend_SetValues_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the array of values that will be represented by this legend.
		/// This array must contain distinct annotated values from the ScalarsToColors.
		/// Each value in this array will be drawn as a separate entry within this
		/// legend.
		/// </summary>
		// Token: 0x06011303 RID: 70403 RVA: 0x0017F354 File Offset: 0x0017D554
		public virtual void SetValues(vtkVariantArray arg0)
		{
			vtkCategoryLegend.vtkCategoryLegend_SetValues_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013DB RID: 5083
		public new const string MRFullTypeName = "Kitware.VTK.vtkCategoryLegend";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013DC RID: 5084
		public new static readonly string MRClassNameKey = "class vtkCategoryLegend";

		/// <summary>
		/// Enum of legend orientation types
		/// </summary>
		// Token: 0x02000634 RID: 1588
		public enum HORIZONTAL_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040013DE RID: 5086
			HORIZONTAL = 1,
			/// <summary>enum member</summary>
			// Token: 0x040013DF RID: 5087
			VERTICAL = 0
		}
	}
}
