using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkApplyColors
	/// </summary>
	/// <remarks>
	///    apply colors to a data set.
	///
	///
	/// vtkApplyColors performs a coloring of the dataset using default colors,
	/// lookup tables, annotations, and/or a selection. The output is a
	/// four-component vtkUnsignedCharArray containing RGBA tuples for each
	/// element in the dataset. The first input is the dataset to be colored, which
	/// may be a vtkTable, vtkGraph subclass, or vtkDataSet subclass. The API
	/// of this algorithm refers to "points" and "cells". For vtkGraph, the
	/// "points" refer to the graph vertices and "cells" refer to graph edges.
	/// For vtkTable, "points" refer to table rows. For vtkDataSet subclasses, the
	/// meaning is obvious.
	///
	/// The second (optional) input is a vtkAnnotationLayers object, which stores
	/// a list of annotation layers, with each layer holding a list of
	/// vtkAnnotation objects. The annotation specifies a subset of data along with
	/// other properties, including color. For annotations with color properties,
	/// this algorithm will use the color to color elements, using a "top one wins"
	/// strategy.
	///
	/// The third (optional) input is a vtkSelection object, meant for specifying
	/// the current selection. You can control the color of the selection.
	///
	/// The algorithm takes two input arrays, specified with
	/// SetInputArrayToProcess(0, 0, 0, vtkDataObject::FIELD_ASSOCIATION_POINTS, name)
	/// and
	/// SetInputArrayToProcess(1, 0, 0, vtkDataObject::FIELD_ASSOCIATION_CELLS, name).
	/// These set the point and cell data arrays to use to color the data with
	/// the associated lookup table. For vtkGraph, vtkTable inputs, you would use
	/// FIELD_ASSOCIATION_VERTICES, FIELD_ASSOCIATION_EDGES, or
	/// FIELD_ASSOCIATION_ROWS as appropriate.
	///
	/// To use the color array generated here, you should do the following:
	///
	///  mapper-&gt;SetScalarModeToUseCellFieldData();
	///  mapper-&gt;SelectColorArray("vtkApplyColors color");
	///  mapper-&gt;SetScalarVisibility(true);
	///
	/// Colors are assigned with the following priorities:
	/// &lt;ol&gt;
	/// &lt;li&gt; If an item is part of the selection, it is colored with that color.
	/// &lt;li&gt; Otherwise, if the item is part of an annotation, it is colored
	///      with the color of the final (top) annotation in the set of layers.
	/// &lt;li&gt; Otherwise, if the lookup table is used, it is colored using the
	///      lookup table color for the data value of the element.
	/// &lt;li&gt; Otherwise it will be colored with the default color.
	/// &lt;/ol&gt;
	///
	/// Note: The opacity of an unselected item is defined by the multiplication
	/// of default opacity, lookup table opacity, and annotation opacity, where
	/// opacity is taken as a number from 0 to 1. So items will never be more opaque
	/// than any of these three opacities. Selected items are always given the
	/// selection opacity directly.
	/// </remarks>
	// Token: 0x0200005D RID: 93
	public class vtkApplyColors : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001094 RID: 4244 RVA: 0x0001E268 File Offset: 0x0001C468
		static vtkApplyColors()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkApplyColors.MRClassNameKey, Type.GetType("Kitware.VTK.vtkApplyColors"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001095 RID: 4245 RVA: 0x0001E290 File Offset: 0x0001C490
		public vtkApplyColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001096 RID: 4246
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApplyColors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001097 RID: 4247 RVA: 0x0001E2A0 File Offset: 0x0001C4A0
		public new static vtkApplyColors New()
		{
			vtkApplyColors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkApplyColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001098 RID: 4248 RVA: 0x0001E2F4 File Offset: 0x0001C4F4
		public vtkApplyColors() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkApplyColors.vtkApplyColors_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001099 RID: 4249 RVA: 0x0001E338 File Offset: 0x0001C538
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600109A RID: 4250
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApplyColors_GetCellColorOutputArrayName_01(HandleRef pThis);

		/// <summary>
		/// The output array name for the cell color RGBA array.
		/// Default is "vtkApplyColors color".
		/// </summary>
		// Token: 0x0600109B RID: 4251 RVA: 0x0001E344 File Offset: 0x0001C544
		public virtual string GetCellColorOutputArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkApplyColors.vtkApplyColors_GetCellColorOutputArrayName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600109C RID: 4252
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApplyColors_GetCellLookupTable_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The lookup table to use for cell colors. This is only used if
		/// input array 1 is set and UseCellLookupTable is on.
		/// </summary>
		// Token: 0x0600109D RID: 4253 RVA: 0x0001E380 File Offset: 0x0001C580
		public virtual vtkScalarsToColors GetCellLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_GetCellLookupTable_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600109E RID: 4254
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApplyColors_GetDefaultCellColor_03(HandleRef pThis);

		/// <summary>
		/// The default cell color for all unannotated, unselected elements
		/// of the data. This is used if UseCellLookupTable is off.
		/// </summary>
		// Token: 0x0600109F RID: 4255 RVA: 0x0001E3F0 File Offset: 0x0001C5F0
		public virtual double[] GetDefaultCellColor()
		{
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_GetDefaultCellColor_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060010A0 RID: 4256
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_GetDefaultCellColor_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The default cell color for all unannotated, unselected elements
		/// of the data. This is used if UseCellLookupTable is off.
		/// </summary>
		// Token: 0x060010A1 RID: 4257 RVA: 0x0001E438 File Offset: 0x0001C638
		public virtual void GetDefaultCellColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkApplyColors.vtkApplyColors_GetDefaultCellColor_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060010A2 RID: 4258
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_GetDefaultCellColor_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The default cell color for all unannotated, unselected elements
		/// of the data. This is used if UseCellLookupTable is off.
		/// </summary>
		// Token: 0x060010A3 RID: 4259 RVA: 0x0001E44A File Offset: 0x0001C64A
		public virtual void GetDefaultCellColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_GetDefaultCellColor_05(base.GetCppThis(), _arg);
		}

		// Token: 0x060010A4 RID: 4260
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkApplyColors_GetDefaultCellOpacity_06(HandleRef pThis);

		/// <summary>
		/// The default cell opacity for all unannotated, unselected elements
		/// of the data. This is used if UseCellLookupTable is off.
		/// </summary>
		// Token: 0x060010A5 RID: 4261 RVA: 0x0001E45C File Offset: 0x0001C65C
		public virtual double GetDefaultCellOpacity()
		{
			return vtkApplyColors.vtkApplyColors_GetDefaultCellOpacity_06(base.GetCppThis());
		}

		// Token: 0x060010A6 RID: 4262
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApplyColors_GetDefaultPointColor_07(HandleRef pThis);

		/// <summary>
		/// The default point color for all unannotated, unselected elements
		/// of the data. This is used if UsePointLookupTable is off.
		/// </summary>
		// Token: 0x060010A7 RID: 4263 RVA: 0x0001E47C File Offset: 0x0001C67C
		public virtual double[] GetDefaultPointColor()
		{
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_GetDefaultPointColor_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060010A8 RID: 4264
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_GetDefaultPointColor_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The default point color for all unannotated, unselected elements
		/// of the data. This is used if UsePointLookupTable is off.
		/// </summary>
		// Token: 0x060010A9 RID: 4265 RVA: 0x0001E4C4 File Offset: 0x0001C6C4
		public virtual void GetDefaultPointColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkApplyColors.vtkApplyColors_GetDefaultPointColor_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060010AA RID: 4266
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_GetDefaultPointColor_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The default point color for all unannotated, unselected elements
		/// of the data. This is used if UsePointLookupTable is off.
		/// </summary>
		// Token: 0x060010AB RID: 4267 RVA: 0x0001E4D6 File Offset: 0x0001C6D6
		public virtual void GetDefaultPointColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_GetDefaultPointColor_09(base.GetCppThis(), _arg);
		}

		// Token: 0x060010AC RID: 4268
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkApplyColors_GetDefaultPointOpacity_10(HandleRef pThis);

		/// <summary>
		/// The default point opacity for all unannotated, unselected elements
		/// of the data. This is used if UsePointLookupTable is off.
		/// </summary>
		// Token: 0x060010AD RID: 4269 RVA: 0x0001E4E8 File Offset: 0x0001C6E8
		public virtual double GetDefaultPointOpacity()
		{
			return vtkApplyColors.vtkApplyColors_GetDefaultPointOpacity_10(base.GetCppThis());
		}

		// Token: 0x060010AE RID: 4270
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkApplyColors_GetMTime_11(HandleRef pThis);

		/// <summary>
		/// Retrieve the modified time for this filter.
		/// </summary>
		// Token: 0x060010AF RID: 4271 RVA: 0x0001E508 File Offset: 0x0001C708
		public override ulong GetMTime()
		{
			return vtkApplyColors.vtkApplyColors_GetMTime_11(base.GetCppThis());
		}

		// Token: 0x060010B0 RID: 4272
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkApplyColors_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060010B1 RID: 4273 RVA: 0x0001E528 File Offset: 0x0001C728
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkApplyColors.vtkApplyColors_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x060010B2 RID: 4274
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkApplyColors_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060010B3 RID: 4275 RVA: 0x0001E548 File Offset: 0x0001C748
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkApplyColors.vtkApplyColors_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x060010B4 RID: 4276
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApplyColors_GetPointColorOutputArrayName_14(HandleRef pThis);

		/// <summary>
		/// The output array name for the point color RGBA array.
		/// Default is "vtkApplyColors color".
		/// </summary>
		// Token: 0x060010B5 RID: 4277 RVA: 0x0001E564 File Offset: 0x0001C764
		public virtual string GetPointColorOutputArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkApplyColors.vtkApplyColors_GetPointColorOutputArrayName_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060010B6 RID: 4278
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApplyColors_GetPointLookupTable_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The lookup table to use for point colors. This is only used if
		/// input array 0 is set and UsePointLookupTable is on.
		/// </summary>
		// Token: 0x060010B7 RID: 4279 RVA: 0x0001E5A0 File Offset: 0x0001C7A0
		public virtual vtkScalarsToColors GetPointLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_GetPointLookupTable_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060010B8 RID: 4280
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkApplyColors_GetScaleCellLookupTable_16(HandleRef pThis);

		/// <summary>
		/// If on, uses the range of the data to scale the lookup table range.
		/// Otherwise, uses the range defined in the lookup table.
		/// </summary>
		// Token: 0x060010B9 RID: 4281 RVA: 0x0001E610 File Offset: 0x0001C810
		public virtual bool GetScaleCellLookupTable()
		{
			return vtkApplyColors.vtkApplyColors_GetScaleCellLookupTable_16(base.GetCppThis()) != 0;
		}

		// Token: 0x060010BA RID: 4282
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkApplyColors_GetScalePointLookupTable_17(HandleRef pThis);

		/// <summary>
		/// If on, uses the range of the data to scale the lookup table range.
		/// Otherwise, uses the range defined in the lookup table.
		/// </summary>
		// Token: 0x060010BB RID: 4283 RVA: 0x0001E638 File Offset: 0x0001C838
		public virtual bool GetScalePointLookupTable()
		{
			return vtkApplyColors.vtkApplyColors_GetScalePointLookupTable_17(base.GetCppThis()) != 0;
		}

		// Token: 0x060010BC RID: 4284
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApplyColors_GetSelectedCellColor_18(HandleRef pThis);

		/// <summary>
		/// The cell color for all selected elements of the data.
		/// This is used if the selection input is available.
		/// </summary>
		// Token: 0x060010BD RID: 4285 RVA: 0x0001E660 File Offset: 0x0001C860
		public virtual double[] GetSelectedCellColor()
		{
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_GetSelectedCellColor_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060010BE RID: 4286
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_GetSelectedCellColor_19(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The cell color for all selected elements of the data.
		/// This is used if the selection input is available.
		/// </summary>
		// Token: 0x060010BF RID: 4287 RVA: 0x0001E6A8 File Offset: 0x0001C8A8
		public virtual void GetSelectedCellColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkApplyColors.vtkApplyColors_GetSelectedCellColor_19(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060010C0 RID: 4288
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_GetSelectedCellColor_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The cell color for all selected elements of the data.
		/// This is used if the selection input is available.
		/// </summary>
		// Token: 0x060010C1 RID: 4289 RVA: 0x0001E6BA File Offset: 0x0001C8BA
		public virtual void GetSelectedCellColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_GetSelectedCellColor_20(base.GetCppThis(), _arg);
		}

		// Token: 0x060010C2 RID: 4290
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkApplyColors_GetSelectedCellOpacity_21(HandleRef pThis);

		/// <summary>
		/// The cell opacity for all selected elements of the data.
		/// This is used if the selection input is available.
		/// </summary>
		// Token: 0x060010C3 RID: 4291 RVA: 0x0001E6CC File Offset: 0x0001C8CC
		public virtual double GetSelectedCellOpacity()
		{
			return vtkApplyColors.vtkApplyColors_GetSelectedCellOpacity_21(base.GetCppThis());
		}

		// Token: 0x060010C4 RID: 4292
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApplyColors_GetSelectedPointColor_22(HandleRef pThis);

		/// <summary>
		/// The point color for all selected elements of the data.
		/// This is used if the selection input is available.
		/// </summary>
		// Token: 0x060010C5 RID: 4293 RVA: 0x0001E6EC File Offset: 0x0001C8EC
		public virtual double[] GetSelectedPointColor()
		{
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_GetSelectedPointColor_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060010C6 RID: 4294
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_GetSelectedPointColor_23(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The point color for all selected elements of the data.
		/// This is used if the selection input is available.
		/// </summary>
		// Token: 0x060010C7 RID: 4295 RVA: 0x0001E734 File Offset: 0x0001C934
		public virtual void GetSelectedPointColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkApplyColors.vtkApplyColors_GetSelectedPointColor_23(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060010C8 RID: 4296
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_GetSelectedPointColor_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The point color for all selected elements of the data.
		/// This is used if the selection input is available.
		/// </summary>
		// Token: 0x060010C9 RID: 4297 RVA: 0x0001E746 File Offset: 0x0001C946
		public virtual void GetSelectedPointColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_GetSelectedPointColor_24(base.GetCppThis(), _arg);
		}

		// Token: 0x060010CA RID: 4298
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkApplyColors_GetSelectedPointOpacity_25(HandleRef pThis);

		/// <summary>
		/// The point opacity for all selected elements of the data.
		/// This is used if the selection input is available.
		/// </summary>
		// Token: 0x060010CB RID: 4299 RVA: 0x0001E758 File Offset: 0x0001C958
		public virtual double GetSelectedPointOpacity()
		{
			return vtkApplyColors.vtkApplyColors_GetSelectedPointOpacity_25(base.GetCppThis());
		}

		// Token: 0x060010CC RID: 4300
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkApplyColors_GetUseCellLookupTable_26(HandleRef pThis);

		/// <summary>
		/// If on, uses the cell lookup table to set the colors of unannotated,
		/// unselected elements of the data.
		/// </summary>
		// Token: 0x060010CD RID: 4301 RVA: 0x0001E778 File Offset: 0x0001C978
		public virtual bool GetUseCellLookupTable()
		{
			return vtkApplyColors.vtkApplyColors_GetUseCellLookupTable_26(base.GetCppThis()) != 0;
		}

		// Token: 0x060010CE RID: 4302
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkApplyColors_GetUseCurrentAnnotationColor_27(HandleRef pThis);

		/// <summary>
		/// Use the annotation to color the current annotation
		/// (i.e. the current selection). Otherwise use the selection
		/// color attributes of this filter.
		/// </summary>
		// Token: 0x060010CF RID: 4303 RVA: 0x0001E7A0 File Offset: 0x0001C9A0
		public virtual bool GetUseCurrentAnnotationColor()
		{
			return vtkApplyColors.vtkApplyColors_GetUseCurrentAnnotationColor_27(base.GetCppThis()) != 0;
		}

		// Token: 0x060010D0 RID: 4304
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkApplyColors_GetUsePointLookupTable_28(HandleRef pThis);

		/// <summary>
		/// If on, uses the point lookup table to set the colors of unannotated,
		/// unselected elements of the data.
		/// </summary>
		// Token: 0x060010D1 RID: 4305 RVA: 0x0001E7C8 File Offset: 0x0001C9C8
		public virtual bool GetUsePointLookupTable()
		{
			return vtkApplyColors.vtkApplyColors_GetUsePointLookupTable_28(base.GetCppThis()) != 0;
		}

		// Token: 0x060010D2 RID: 4306
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkApplyColors_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060010D3 RID: 4307 RVA: 0x0001E7F0 File Offset: 0x0001C9F0
		public override int IsA(string type)
		{
			return vtkApplyColors.vtkApplyColors_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x060010D4 RID: 4308
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkApplyColors_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060010D5 RID: 4309 RVA: 0x0001E810 File Offset: 0x0001CA10
		public new static int IsTypeOf(string type)
		{
			return vtkApplyColors.vtkApplyColors_IsTypeOf_30(type);
		}

		// Token: 0x060010D6 RID: 4310
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApplyColors_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060010D7 RID: 4311 RVA: 0x0001E82C File Offset: 0x0001CA2C
		public new vtkApplyColors NewInstance()
		{
			vtkApplyColors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkApplyColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060010D8 RID: 4312
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApplyColors_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060010D9 RID: 4313 RVA: 0x0001E888 File Offset: 0x0001CA88
		public new static vtkApplyColors SafeDownCast(vtkObjectBase o)
		{
			vtkApplyColors vtkApplyColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkApplyColors.vtkApplyColors_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkApplyColors = (vtkApplyColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkApplyColors.Register(null);
				}
			}
			return vtkApplyColors;
		}

		// Token: 0x060010DA RID: 4314
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_ScaleCellLookupTableOff_34(HandleRef pThis);

		/// <summary>
		/// If on, uses the range of the data to scale the lookup table range.
		/// Otherwise, uses the range defined in the lookup table.
		/// </summary>
		// Token: 0x060010DB RID: 4315 RVA: 0x0001E907 File Offset: 0x0001CB07
		public virtual void ScaleCellLookupTableOff()
		{
			vtkApplyColors.vtkApplyColors_ScaleCellLookupTableOff_34(base.GetCppThis());
		}

		// Token: 0x060010DC RID: 4316
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_ScaleCellLookupTableOn_35(HandleRef pThis);

		/// <summary>
		/// If on, uses the range of the data to scale the lookup table range.
		/// Otherwise, uses the range defined in the lookup table.
		/// </summary>
		// Token: 0x060010DD RID: 4317 RVA: 0x0001E916 File Offset: 0x0001CB16
		public virtual void ScaleCellLookupTableOn()
		{
			vtkApplyColors.vtkApplyColors_ScaleCellLookupTableOn_35(base.GetCppThis());
		}

		// Token: 0x060010DE RID: 4318
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_ScalePointLookupTableOff_36(HandleRef pThis);

		/// <summary>
		/// If on, uses the range of the data to scale the lookup table range.
		/// Otherwise, uses the range defined in the lookup table.
		/// </summary>
		// Token: 0x060010DF RID: 4319 RVA: 0x0001E925 File Offset: 0x0001CB25
		public virtual void ScalePointLookupTableOff()
		{
			vtkApplyColors.vtkApplyColors_ScalePointLookupTableOff_36(base.GetCppThis());
		}

		// Token: 0x060010E0 RID: 4320
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_ScalePointLookupTableOn_37(HandleRef pThis);

		/// <summary>
		/// If on, uses the range of the data to scale the lookup table range.
		/// Otherwise, uses the range defined in the lookup table.
		/// </summary>
		// Token: 0x060010E1 RID: 4321 RVA: 0x0001E934 File Offset: 0x0001CB34
		public virtual void ScalePointLookupTableOn()
		{
			vtkApplyColors.vtkApplyColors_ScalePointLookupTableOn_37(base.GetCppThis());
		}

		// Token: 0x060010E2 RID: 4322
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetCellColorOutputArrayName_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The output array name for the cell color RGBA array.
		/// Default is "vtkApplyColors color".
		/// </summary>
		// Token: 0x060010E3 RID: 4323 RVA: 0x0001E943 File Offset: 0x0001CB43
		public virtual void SetCellColorOutputArrayName(string _arg)
		{
			vtkApplyColors.vtkApplyColors_SetCellColorOutputArrayName_38(base.GetCppThis(), _arg);
		}

		// Token: 0x060010E4 RID: 4324
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetCellLookupTable_39(HandleRef pThis, HandleRef lut);

		/// <summary>
		/// The lookup table to use for cell colors. This is only used if
		/// input array 1 is set and UseCellLookupTable is on.
		/// </summary>
		// Token: 0x060010E5 RID: 4325 RVA: 0x0001E954 File Offset: 0x0001CB54
		public virtual void SetCellLookupTable(vtkScalarsToColors lut)
		{
			vtkApplyColors.vtkApplyColors_SetCellLookupTable_39(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		// Token: 0x060010E6 RID: 4326
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetDefaultCellColor_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The default cell color for all unannotated, unselected elements
		/// of the data. This is used if UseCellLookupTable is off.
		/// </summary>
		// Token: 0x060010E7 RID: 4327 RVA: 0x0001E983 File Offset: 0x0001CB83
		public virtual void SetDefaultCellColor(double _arg1, double _arg2, double _arg3)
		{
			vtkApplyColors.vtkApplyColors_SetDefaultCellColor_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060010E8 RID: 4328
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetDefaultCellColor_41(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The default cell color for all unannotated, unselected elements
		/// of the data. This is used if UseCellLookupTable is off.
		/// </summary>
		// Token: 0x060010E9 RID: 4329 RVA: 0x0001E995 File Offset: 0x0001CB95
		public virtual void SetDefaultCellColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_SetDefaultCellColor_41(base.GetCppThis(), _arg);
		}

		// Token: 0x060010EA RID: 4330
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetDefaultCellOpacity_42(HandleRef pThis, double _arg);

		/// <summary>
		/// The default cell opacity for all unannotated, unselected elements
		/// of the data. This is used if UseCellLookupTable is off.
		/// </summary>
		// Token: 0x060010EB RID: 4331 RVA: 0x0001E9A5 File Offset: 0x0001CBA5
		public virtual void SetDefaultCellOpacity(double _arg)
		{
			vtkApplyColors.vtkApplyColors_SetDefaultCellOpacity_42(base.GetCppThis(), _arg);
		}

		// Token: 0x060010EC RID: 4332
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetDefaultPointColor_43(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The default point color for all unannotated, unselected elements
		/// of the data. This is used if UsePointLookupTable is off.
		/// </summary>
		// Token: 0x060010ED RID: 4333 RVA: 0x0001E9B5 File Offset: 0x0001CBB5
		public virtual void SetDefaultPointColor(double _arg1, double _arg2, double _arg3)
		{
			vtkApplyColors.vtkApplyColors_SetDefaultPointColor_43(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060010EE RID: 4334
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetDefaultPointColor_44(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The default point color for all unannotated, unselected elements
		/// of the data. This is used if UsePointLookupTable is off.
		/// </summary>
		// Token: 0x060010EF RID: 4335 RVA: 0x0001E9C7 File Offset: 0x0001CBC7
		public virtual void SetDefaultPointColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_SetDefaultPointColor_44(base.GetCppThis(), _arg);
		}

		// Token: 0x060010F0 RID: 4336
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetDefaultPointOpacity_45(HandleRef pThis, double _arg);

		/// <summary>
		/// The default point opacity for all unannotated, unselected elements
		/// of the data. This is used if UsePointLookupTable is off.
		/// </summary>
		// Token: 0x060010F1 RID: 4337 RVA: 0x0001E9D7 File Offset: 0x0001CBD7
		public virtual void SetDefaultPointOpacity(double _arg)
		{
			vtkApplyColors.vtkApplyColors_SetDefaultPointOpacity_45(base.GetCppThis(), _arg);
		}

		// Token: 0x060010F2 RID: 4338
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetPointColorOutputArrayName_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The output array name for the point color RGBA array.
		/// Default is "vtkApplyColors color".
		/// </summary>
		// Token: 0x060010F3 RID: 4339 RVA: 0x0001E9E7 File Offset: 0x0001CBE7
		public virtual void SetPointColorOutputArrayName(string _arg)
		{
			vtkApplyColors.vtkApplyColors_SetPointColorOutputArrayName_46(base.GetCppThis(), _arg);
		}

		// Token: 0x060010F4 RID: 4340
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetPointLookupTable_47(HandleRef pThis, HandleRef lut);

		/// <summary>
		/// The lookup table to use for point colors. This is only used if
		/// input array 0 is set and UsePointLookupTable is on.
		/// </summary>
		// Token: 0x060010F5 RID: 4341 RVA: 0x0001E9F8 File Offset: 0x0001CBF8
		public virtual void SetPointLookupTable(vtkScalarsToColors lut)
		{
			vtkApplyColors.vtkApplyColors_SetPointLookupTable_47(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		// Token: 0x060010F6 RID: 4342
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetScaleCellLookupTable_48(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, uses the range of the data to scale the lookup table range.
		/// Otherwise, uses the range defined in the lookup table.
		/// </summary>
		// Token: 0x060010F7 RID: 4343 RVA: 0x0001EA27 File Offset: 0x0001CC27
		public virtual void SetScaleCellLookupTable(bool _arg)
		{
			vtkApplyColors.vtkApplyColors_SetScaleCellLookupTable_48(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060010F8 RID: 4344
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetScalePointLookupTable_49(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, uses the range of the data to scale the lookup table range.
		/// Otherwise, uses the range defined in the lookup table.
		/// </summary>
		// Token: 0x060010F9 RID: 4345 RVA: 0x0001EA3F File Offset: 0x0001CC3F
		public virtual void SetScalePointLookupTable(bool _arg)
		{
			vtkApplyColors.vtkApplyColors_SetScalePointLookupTable_49(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060010FA RID: 4346
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetSelectedCellColor_50(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The cell color for all selected elements of the data.
		/// This is used if the selection input is available.
		/// </summary>
		// Token: 0x060010FB RID: 4347 RVA: 0x0001EA57 File Offset: 0x0001CC57
		public virtual void SetSelectedCellColor(double _arg1, double _arg2, double _arg3)
		{
			vtkApplyColors.vtkApplyColors_SetSelectedCellColor_50(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060010FC RID: 4348
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetSelectedCellColor_51(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The cell color for all selected elements of the data.
		/// This is used if the selection input is available.
		/// </summary>
		// Token: 0x060010FD RID: 4349 RVA: 0x0001EA69 File Offset: 0x0001CC69
		public virtual void SetSelectedCellColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_SetSelectedCellColor_51(base.GetCppThis(), _arg);
		}

		// Token: 0x060010FE RID: 4350
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetSelectedCellOpacity_52(HandleRef pThis, double _arg);

		/// <summary>
		/// The cell opacity for all selected elements of the data.
		/// This is used if the selection input is available.
		/// </summary>
		// Token: 0x060010FF RID: 4351 RVA: 0x0001EA79 File Offset: 0x0001CC79
		public virtual void SetSelectedCellOpacity(double _arg)
		{
			vtkApplyColors.vtkApplyColors_SetSelectedCellOpacity_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06001100 RID: 4352
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetSelectedPointColor_53(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The point color for all selected elements of the data.
		/// This is used if the selection input is available.
		/// </summary>
		// Token: 0x06001101 RID: 4353 RVA: 0x0001EA89 File Offset: 0x0001CC89
		public virtual void SetSelectedPointColor(double _arg1, double _arg2, double _arg3)
		{
			vtkApplyColors.vtkApplyColors_SetSelectedPointColor_53(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06001102 RID: 4354
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetSelectedPointColor_54(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The point color for all selected elements of the data.
		/// This is used if the selection input is available.
		/// </summary>
		// Token: 0x06001103 RID: 4355 RVA: 0x0001EA9B File Offset: 0x0001CC9B
		public virtual void SetSelectedPointColor(IntPtr _arg)
		{
			vtkApplyColors.vtkApplyColors_SetSelectedPointColor_54(base.GetCppThis(), _arg);
		}

		// Token: 0x06001104 RID: 4356
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetSelectedPointOpacity_55(HandleRef pThis, double _arg);

		/// <summary>
		/// The point opacity for all selected elements of the data.
		/// This is used if the selection input is available.
		/// </summary>
		// Token: 0x06001105 RID: 4357 RVA: 0x0001EAAB File Offset: 0x0001CCAB
		public virtual void SetSelectedPointOpacity(double _arg)
		{
			vtkApplyColors.vtkApplyColors_SetSelectedPointOpacity_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06001106 RID: 4358
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetUseCellLookupTable_56(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, uses the cell lookup table to set the colors of unannotated,
		/// unselected elements of the data.
		/// </summary>
		// Token: 0x06001107 RID: 4359 RVA: 0x0001EABB File Offset: 0x0001CCBB
		public virtual void SetUseCellLookupTable(bool _arg)
		{
			vtkApplyColors.vtkApplyColors_SetUseCellLookupTable_56(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001108 RID: 4360
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetUseCurrentAnnotationColor_57(HandleRef pThis, byte _arg);

		/// <summary>
		/// Use the annotation to color the current annotation
		/// (i.e. the current selection). Otherwise use the selection
		/// color attributes of this filter.
		/// </summary>
		// Token: 0x06001109 RID: 4361 RVA: 0x0001EAD3 File Offset: 0x0001CCD3
		public virtual void SetUseCurrentAnnotationColor(bool _arg)
		{
			vtkApplyColors.vtkApplyColors_SetUseCurrentAnnotationColor_57(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600110A RID: 4362
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_SetUsePointLookupTable_58(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, uses the point lookup table to set the colors of unannotated,
		/// unselected elements of the data.
		/// </summary>
		// Token: 0x0600110B RID: 4363 RVA: 0x0001EAEB File Offset: 0x0001CCEB
		public virtual void SetUsePointLookupTable(bool _arg)
		{
			vtkApplyColors.vtkApplyColors_SetUsePointLookupTable_58(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600110C RID: 4364
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_UseCellLookupTableOff_59(HandleRef pThis);

		/// <summary>
		/// If on, uses the cell lookup table to set the colors of unannotated,
		/// unselected elements of the data.
		/// </summary>
		// Token: 0x0600110D RID: 4365 RVA: 0x0001EB03 File Offset: 0x0001CD03
		public virtual void UseCellLookupTableOff()
		{
			vtkApplyColors.vtkApplyColors_UseCellLookupTableOff_59(base.GetCppThis());
		}

		// Token: 0x0600110E RID: 4366
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_UseCellLookupTableOn_60(HandleRef pThis);

		/// <summary>
		/// If on, uses the cell lookup table to set the colors of unannotated,
		/// unselected elements of the data.
		/// </summary>
		// Token: 0x0600110F RID: 4367 RVA: 0x0001EB12 File Offset: 0x0001CD12
		public virtual void UseCellLookupTableOn()
		{
			vtkApplyColors.vtkApplyColors_UseCellLookupTableOn_60(base.GetCppThis());
		}

		// Token: 0x06001110 RID: 4368
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_UseCurrentAnnotationColorOff_61(HandleRef pThis);

		/// <summary>
		/// Use the annotation to color the current annotation
		/// (i.e. the current selection). Otherwise use the selection
		/// color attributes of this filter.
		/// </summary>
		// Token: 0x06001111 RID: 4369 RVA: 0x0001EB21 File Offset: 0x0001CD21
		public virtual void UseCurrentAnnotationColorOff()
		{
			vtkApplyColors.vtkApplyColors_UseCurrentAnnotationColorOff_61(base.GetCppThis());
		}

		// Token: 0x06001112 RID: 4370
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_UseCurrentAnnotationColorOn_62(HandleRef pThis);

		/// <summary>
		/// Use the annotation to color the current annotation
		/// (i.e. the current selection). Otherwise use the selection
		/// color attributes of this filter.
		/// </summary>
		// Token: 0x06001113 RID: 4371 RVA: 0x0001EB30 File Offset: 0x0001CD30
		public virtual void UseCurrentAnnotationColorOn()
		{
			vtkApplyColors.vtkApplyColors_UseCurrentAnnotationColorOn_62(base.GetCppThis());
		}

		// Token: 0x06001114 RID: 4372
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_UsePointLookupTableOff_63(HandleRef pThis);

		/// <summary>
		/// If on, uses the point lookup table to set the colors of unannotated,
		/// unselected elements of the data.
		/// </summary>
		// Token: 0x06001115 RID: 4373 RVA: 0x0001EB3F File Offset: 0x0001CD3F
		public virtual void UsePointLookupTableOff()
		{
			vtkApplyColors.vtkApplyColors_UsePointLookupTableOff_63(base.GetCppThis());
		}

		// Token: 0x06001116 RID: 4374
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkApplyColors_UsePointLookupTableOn_64(HandleRef pThis);

		/// <summary>
		/// If on, uses the point lookup table to set the colors of unannotated,
		/// unselected elements of the data.
		/// </summary>
		// Token: 0x06001117 RID: 4375 RVA: 0x0001EB4E File Offset: 0x0001CD4E
		public virtual void UsePointLookupTableOn()
		{
			vtkApplyColors.vtkApplyColors_UsePointLookupTableOn_64(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400043A RID: 1082
		public new const string MRFullTypeName = "Kitware.VTK.vtkApplyColors";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400043B RID: 1083
		public new static readonly string MRClassNameKey = "class vtkApplyColors";
	}
}
