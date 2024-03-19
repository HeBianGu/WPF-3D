using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkChartMatrix
	/// </summary>
	/// <remarks>
	///    container for a matrix of charts.
	///
	///
	/// This class contains a matrix of charts. These charts will be of type
	/// vtkChartXY by default, but this can be overridden. The class will manage
	/// their layout and object lifetime.
	/// </remarks>
	// Token: 0x0200063E RID: 1598
	public class vtkChartMatrix : vtkAbstractContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011481 RID: 70785 RVA: 0x0018152A File Offset: 0x0017F72A
		static vtkChartMatrix()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChartMatrix.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartMatrix"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011482 RID: 70786 RVA: 0x00181552 File Offset: 0x0017F752
		public vtkChartMatrix(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011483 RID: 70787
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartMatrix_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a new object.
		/// </summary>
		// Token: 0x06011484 RID: 70788 RVA: 0x00181560 File Offset: 0x0017F760
		public new static vtkChartMatrix New()
		{
			vtkChartMatrix result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartMatrix.vtkChartMatrix_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartMatrix)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a new object.
		/// </summary>
		// Token: 0x06011485 RID: 70789 RVA: 0x001815B4 File Offset: 0x0017F7B4
		public vtkChartMatrix() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkChartMatrix.vtkChartMatrix_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011486 RID: 70790 RVA: 0x001815F8 File Offset: 0x0017F7F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011487 RID: 70791
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_Allocate_01(HandleRef pThis);

		/// <summary>
		/// Allocate the charts, this will cause any null chart to be allocated.
		/// </summary>
		// Token: 0x06011488 RID: 70792 RVA: 0x00181603 File Offset: 0x0017F803
		public virtual void Allocate()
		{
			vtkChartMatrix.vtkChartMatrix_Allocate_01(base.GetCppThis());
		}

		// Token: 0x06011489 RID: 70793
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_ClearSpecificResizes_02(HandleRef pThis);

		/// <summary>
		/// Set a specific resize that will move the bottom left point of a chart.
		/// </summary>
		// Token: 0x0601148A RID: 70794 RVA: 0x00181612 File Offset: 0x0017F812
		public virtual void ClearSpecificResizes()
		{
			vtkChartMatrix.vtkChartMatrix_ClearSpecificResizes_02(base.GetCppThis());
		}

		// Token: 0x0601148B RID: 70795
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartMatrix_ComputeCurrentElementSceneRect_03(HandleRef pThis, HandleRef index, HandleRef offset, HandleRef increment, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Override this method if you want to customize layout instead of the default.
		/// The returned rect will be in scene coordinates and suitable for a chart element
		/// or chart matrix element.
		/// </summary>
		// Token: 0x0601148C RID: 70796 RVA: 0x00181624 File Offset: 0x0017F824
		public virtual vtkRectf ComputeCurrentElementSceneRect(vtkVector2i index, vtkVector2f offset, vtkVector2f increment)
		{
			vtkRectf result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartMatrix.vtkChartMatrix_ComputeCurrentElementSceneRect_03(base.GetCppThis(), (index == null) ? default(HandleRef) : index.GetCppThis(), (offset == null) ? default(HandleRef) : offset.GetCppThis(), (increment == null) ? default(HandleRef) : increment.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectf)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601148D RID: 70797
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_GetBorders_04(HandleRef pThis, IntPtr borders);

		/// <summary>
		/// Set/get the borders of the chart matrix (space in pixels around each chart).
		/// </summary>
		// Token: 0x0601148E RID: 70798 RVA: 0x001816C0 File Offset: 0x0017F8C0
		public virtual void GetBorders(IntPtr borders)
		{
			vtkChartMatrix.vtkChartMatrix_GetBorders_04(base.GetCppThis(), borders);
		}

		// Token: 0x0601148F RID: 70799
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartMatrix_GetChart_05(HandleRef pThis, HandleRef position, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the specified chart element, if the element does not exist nullptr will be
		/// returned. If the chart element has not yet been allocated it will be at
		/// this point.
		/// </summary>
		// Token: 0x06011490 RID: 70800 RVA: 0x001816D0 File Offset: 0x0017F8D0
		public virtual vtkChart GetChart(vtkVector2i position)
		{
			vtkChart vtkChart = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartMatrix.vtkChartMatrix_GetChart_05(base.GetCppThis(), (position == null) ? default(HandleRef) : position.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChart = (vtkChart)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChart.Register(null);
				}
			}
			return vtkChart;
		}

		// Token: 0x06011491 RID: 70801
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartMatrix_GetChartIndex_06(HandleRef pThis, HandleRef position, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the position of an element in the matrix at the specified location.
		/// The position should be specified in scene coordinates.
		/// </summary>
		// Token: 0x06011492 RID: 70802 RVA: 0x00181758 File Offset: 0x0017F958
		public virtual vtkVector2i GetChartIndex(vtkVector2f position)
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartMatrix.vtkChartMatrix_GetChartIndex_06(base.GetCppThis(), (position == null) ? default(HandleRef) : position.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011493 RID: 70803
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartMatrix_GetChartMatrix_07(HandleRef pThis, HandleRef position, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the specified chart matrix element. if the element does not exist, nullptr
		/// will be returned. If the element has not yet been allocated it will be at this
		/// point
		/// </summary>
		// Token: 0x06011494 RID: 70804 RVA: 0x001817C8 File Offset: 0x0017F9C8
		public virtual vtkChartMatrix GetChartMatrix(vtkVector2i position)
		{
			vtkChartMatrix vtkChartMatrix = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartMatrix.vtkChartMatrix_GetChartMatrix_07(base.GetCppThis(), (position == null) ? default(HandleRef) : position.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChartMatrix = (vtkChartMatrix)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChartMatrix.Register(null);
				}
			}
			return vtkChartMatrix;
		}

		// Token: 0x06011495 RID: 70805
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartMatrix_GetChartSpan_08(HandleRef pThis, HandleRef position, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the span of the specified element.
		/// </summary>
		// Token: 0x06011496 RID: 70806 RVA: 0x00181850 File Offset: 0x0017FA50
		public virtual vtkVector2i GetChartSpan(vtkVector2i position)
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartMatrix.vtkChartMatrix_GetChartSpan_08(base.GetCppThis(), (position == null) ? default(HandleRef) : position.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011497 RID: 70807
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkChartMatrix.StretchType vtkChartMatrix_GetFillStrategy_09(HandleRef pThis);

		/// <summary>
		/// This specifies whether the chart matrix will fill the entire scene
		/// or instead draw itself in a user provided rectangular subset of the scene.
		/// </summary>
		// Token: 0x06011498 RID: 70808 RVA: 0x001818C0 File Offset: 0x0017FAC0
		public vtkChartMatrix.StretchType GetFillStrategy()
		{
			return vtkChartMatrix.vtkChartMatrix_GetFillStrategy_09(base.GetCppThis());
		}

		// Token: 0x06011499 RID: 70809
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkChartMatrix_GetFlatIndex_10(HandleRef pThis, HandleRef index);

		/// <summary>
		/// Get internal 1-D index corresponding to the 2-D element index.
		/// </summary>
		// Token: 0x0601149A RID: 70810 RVA: 0x001818E0 File Offset: 0x0017FAE0
		public virtual ulong GetFlatIndex(vtkVector2i index)
		{
			return vtkChartMatrix.vtkChartMatrix_GetFlatIndex_10(base.GetCppThis(), (index == null) ? default(HandleRef) : index.GetCppThis());
		}

		// Token: 0x0601149B RID: 70811
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartMatrix_GetGutter_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the gutter that should be left between the charts in the matrix.
		/// </summary>
		// Token: 0x0601149C RID: 70812 RVA: 0x00181914 File Offset: 0x0017FB14
		public virtual vtkVector2f GetGutter()
		{
			vtkVector2f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartMatrix.vtkChartMatrix_GetGutter_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601149D RID: 70813
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkChartMatrix_GetNumberOfCharts_12(HandleRef pThis);

		/// <summary>
		/// Total number of charts within this chart matrix.
		/// </summary>
		// Token: 0x0601149E RID: 70814 RVA: 0x00181970 File Offset: 0x0017FB70
		public virtual ulong GetNumberOfCharts()
		{
			return vtkChartMatrix.vtkChartMatrix_GetNumberOfCharts_12(base.GetCppThis());
		}

		// Token: 0x0601149F RID: 70815
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartMatrix_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060114A0 RID: 70816 RVA: 0x00181990 File Offset: 0x0017FB90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkChartMatrix.vtkChartMatrix_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x060114A1 RID: 70817
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChartMatrix_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060114A2 RID: 70818 RVA: 0x001819B0 File Offset: 0x0017FBB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkChartMatrix.vtkChartMatrix_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x060114A3 RID: 70819
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartMatrix_GetRect_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the rectangular region that this chart matrix will occupy.
		/// Must also set FillStrategy to StretchType::CUSTOM
		/// </summary>
		// Token: 0x060114A4 RID: 70820 RVA: 0x001819CC File Offset: 0x0017FBCC
		public virtual vtkRecti GetRect()
		{
			vtkRecti result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartMatrix.vtkChartMatrix_GetRect_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRecti)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060114A5 RID: 70821
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartMatrix_GetSize_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the width and height of the chart matrix.
		/// </summary>
		// Token: 0x060114A6 RID: 70822 RVA: 0x00181A28 File Offset: 0x0017FC28
		public virtual vtkVector2i GetSize()
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartMatrix.vtkChartMatrix_GetSize_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060114A7 RID: 70823
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_GoToNextElement_17(HandleRef pThis, HandleRef index, HandleRef offset);

		/// <summary>
		/// These methods offer an API to iterate over the layout and obtain
		/// the offset of each child element (chart or chart matrix) within the scene,
		/// the index and the increment b/w each element.
		/// </summary>
		// Token: 0x060114A8 RID: 70824 RVA: 0x00181A84 File Offset: 0x0017FC84
		public virtual void GoToNextElement(vtkVector2i index, vtkVector2f offset)
		{
			vtkChartMatrix.vtkChartMatrix_GoToNextElement_17(base.GetCppThis(), (index == null) ? default(HandleRef) : index.GetCppThis(), (offset == null) ? default(HandleRef) : offset.GetCppThis());
		}

		// Token: 0x060114A9 RID: 70825
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_InitLayoutTraversal_18(HandleRef pThis, HandleRef index, HandleRef offset, HandleRef increment);

		/// <summary>
		/// These methods offer an API to iterate over the layout and obtain
		/// the offset of each child element (chart or chart matrix) within the scene,
		/// the index and the increment b/w each element.
		/// </summary>
		// Token: 0x060114AA RID: 70826 RVA: 0x00181AC8 File Offset: 0x0017FCC8
		public virtual void InitLayoutTraversal(vtkVector2i index, vtkVector2f offset, vtkVector2f increment)
		{
			vtkChartMatrix.vtkChartMatrix_InitLayoutTraversal_18(base.GetCppThis(), (index == null) ? default(HandleRef) : index.GetCppThis(), (offset == null) ? default(HandleRef) : offset.GetCppThis(), (increment == null) ? default(HandleRef) : increment.GetCppThis());
		}

		// Token: 0x060114AB RID: 70827
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartMatrix_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060114AC RID: 70828 RVA: 0x00181B24 File Offset: 0x0017FD24
		public override int IsA(string type)
		{
			return vtkChartMatrix.vtkChartMatrix_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x060114AD RID: 70829
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartMatrix_IsDoneWithTraversal_20(HandleRef pThis);

		/// <summary>
		/// These methods offer an API to iterate over the layout and obtain
		/// the offset of each child element (chart or chart matrix) within the scene,
		/// the index and the increment b/w each element.
		/// </summary>
		// Token: 0x060114AE RID: 70830 RVA: 0x00181B44 File Offset: 0x0017FD44
		public virtual bool IsDoneWithTraversal()
		{
			return vtkChartMatrix.vtkChartMatrix_IsDoneWithTraversal_20(base.GetCppThis()) != 0;
		}

		// Token: 0x060114AF RID: 70831
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChartMatrix_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060114B0 RID: 70832 RVA: 0x00181B6C File Offset: 0x0017FD6C
		public new static int IsTypeOf(string type)
		{
			return vtkChartMatrix.vtkChartMatrix_IsTypeOf_21(type);
		}

		// Token: 0x060114B1 RID: 70833
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_LabelOuter_22(HandleRef pThis, HandleRef leftBottomIdx, HandleRef rightTopIdx);

		/// <summary>
		/// Link all charts in the rectangle from leftBottom to rightTop.
		/// Label only the outer most y-axis and x-axis.
		/// This removes of gutter space between the linked charts.
		/// </summary>
		// Token: 0x060114B2 RID: 70834 RVA: 0x00181B88 File Offset: 0x0017FD88
		public virtual void LabelOuter(vtkVector2i leftBottomIdx, vtkVector2i rightTopIdx)
		{
			vtkChartMatrix.vtkChartMatrix_LabelOuter_22(base.GetCppThis(), (leftBottomIdx == null) ? default(HandleRef) : leftBottomIdx.GetCppThis(), (rightTopIdx == null) ? default(HandleRef) : rightTopIdx.GetCppThis());
		}

		// Token: 0x060114B3 RID: 70835
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_Link_23(HandleRef pThis, HandleRef index1, HandleRef index2, int axis);

		/// <summary>
		/// The chart at index2 will be setup to mimic
		/// axis range of chart at index1 for specified axis.
		/// Note: index is a two dimensional chart index. See vtkChartMatrix::GetChartIndex()
		///       flatIndex is a one dimensional chart index. See vtkChartMatrix::GetFlatIndex()
		/// </summary>
		// Token: 0x060114B4 RID: 70836 RVA: 0x00181BCC File Offset: 0x0017FDCC
		public virtual void Link(vtkVector2i index1, vtkVector2i index2, int axis)
		{
			vtkChartMatrix.vtkChartMatrix_Link_23(base.GetCppThis(), (index1 == null) ? default(HandleRef) : index1.GetCppThis(), (index2 == null) ? default(HandleRef) : index2.GetCppThis(), axis);
		}

		// Token: 0x060114B5 RID: 70837
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_Link_24(HandleRef pThis, ref ulong flatIndex1, ref ulong flatIndex2, int axis);

		/// <summary>
		/// The chart at index2 will be setup to mimic
		/// axis range of chart at index1 for specified axis.
		/// Note: index is a two dimensional chart index. See vtkChartMatrix::GetChartIndex()
		///       flatIndex is a one dimensional chart index. See vtkChartMatrix::GetFlatIndex()
		/// </summary>
		// Token: 0x060114B6 RID: 70838 RVA: 0x00181C11 File Offset: 0x0017FE11
		public virtual void Link(ref ulong flatIndex1, ref ulong flatIndex2, int axis)
		{
			vtkChartMatrix.vtkChartMatrix_Link_24(base.GetCppThis(), ref flatIndex1, ref flatIndex2, axis);
		}

		// Token: 0x060114B7 RID: 70839
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_LinkAll_25(HandleRef pThis, HandleRef index, int axis);

		/// <summary>
		/// Link a chart to all other charts in this chart matrix for specified axis
		/// </summary>
		// Token: 0x060114B8 RID: 70840 RVA: 0x00181C24 File Offset: 0x0017FE24
		public virtual void LinkAll(vtkVector2i index, int axis)
		{
			vtkChartMatrix.vtkChartMatrix_LinkAll_25(base.GetCppThis(), (index == null) ? default(HandleRef) : index.GetCppThis(), axis);
		}

		// Token: 0x060114B9 RID: 70841
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_LinkAll_26(HandleRef pThis, ref ulong flatIndex, int axis);

		/// <summary>
		/// Link a chart to all other charts in this chart matrix for specified axis
		/// </summary>
		// Token: 0x060114BA RID: 70842 RVA: 0x00181C54 File Offset: 0x0017FE54
		public virtual void LinkAll(ref ulong flatIndex, int axis)
		{
			vtkChartMatrix.vtkChartMatrix_LinkAll_26(base.GetCppThis(), ref flatIndex, axis);
		}

		// Token: 0x060114BB RID: 70843
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartMatrix_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060114BC RID: 70844 RVA: 0x00181C68 File Offset: 0x0017FE68
		public new vtkChartMatrix NewInstance()
		{
			vtkChartMatrix result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartMatrix.vtkChartMatrix_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartMatrix)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060114BD RID: 70845
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartMatrix_Paint_29(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the chart matrix.
		/// </summary>
		// Token: 0x060114BE RID: 70846 RVA: 0x00181CC4 File Offset: 0x0017FEC4
		public override bool Paint(vtkContext2D painter)
		{
			return vtkChartMatrix.vtkChartMatrix_Paint_29(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060114BF RID: 70847
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_ResetLinkedLayout_30(HandleRef pThis);

		/// <summary>
		/// Unlink every chart from all other charts for a specified axis.
		/// This effectively removes any linkage in the chart matrix.
		/// If vtkChartMatrix::LabelOuter() was used, call ResetLinkedLayout,
		/// sot that the gutters that were removed will
		/// be put back in place.
		/// </summary>
		// Token: 0x060114C0 RID: 70848 RVA: 0x00181CFF File Offset: 0x0017FEFF
		public virtual void ResetLinkedLayout()
		{
			vtkChartMatrix.vtkChartMatrix_ResetLinkedLayout_30(base.GetCppThis());
		}

		// Token: 0x060114C1 RID: 70849
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_ResetLinks_31(HandleRef pThis, int axis);

		/// <summary>
		/// Unlink every chart from all other charts for a specified axis.
		/// This effectively removes any linkage in the chart matrix.
		/// If vtkChartMatrix::LabelOuter() was used, call ResetLinkedLayout,
		/// sot that the gutters that were removed will
		/// be put back in place.
		/// </summary>
		// Token: 0x060114C2 RID: 70850 RVA: 0x00181D0E File Offset: 0x0017FF0E
		public virtual void ResetLinks(int axis)
		{
			vtkChartMatrix.vtkChartMatrix_ResetLinks_31(base.GetCppThis(), axis);
		}

		// Token: 0x060114C3 RID: 70851
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChartMatrix_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060114C4 RID: 70852 RVA: 0x00181D20 File Offset: 0x0017FF20
		public new static vtkChartMatrix SafeDownCast(vtkObjectBase o)
		{
			vtkChartMatrix vtkChartMatrix = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChartMatrix.vtkChartMatrix_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChartMatrix = (vtkChartMatrix)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChartMatrix.Register(null);
				}
			}
			return vtkChartMatrix;
		}

		// Token: 0x060114C5 RID: 70853
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_SetBorderBottom_33(HandleRef pThis, int value);

		/// <summary>
		/// Set/get the borders of the chart matrix (space in pixels around each chart).
		/// </summary>
		// Token: 0x060114C6 RID: 70854 RVA: 0x00181D9F File Offset: 0x0017FF9F
		public void SetBorderBottom(int value)
		{
			vtkChartMatrix.vtkChartMatrix_SetBorderBottom_33(base.GetCppThis(), value);
		}

		// Token: 0x060114C7 RID: 70855
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_SetBorderLeft_34(HandleRef pThis, int value);

		/// <summary>
		/// Set/get the borders of the chart matrix (space in pixels around each chart).
		/// </summary>
		// Token: 0x060114C8 RID: 70856 RVA: 0x00181DAF File Offset: 0x0017FFAF
		public void SetBorderLeft(int value)
		{
			vtkChartMatrix.vtkChartMatrix_SetBorderLeft_34(base.GetCppThis(), value);
		}

		// Token: 0x060114C9 RID: 70857
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_SetBorderRight_35(HandleRef pThis, int value);

		/// <summary>
		/// Set/get the borders of the chart matrix (space in pixels around each chart).
		/// </summary>
		// Token: 0x060114CA RID: 70858 RVA: 0x00181DBF File Offset: 0x0017FFBF
		public void SetBorderRight(int value)
		{
			vtkChartMatrix.vtkChartMatrix_SetBorderRight_35(base.GetCppThis(), value);
		}

		// Token: 0x060114CB RID: 70859
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_SetBorderTop_36(HandleRef pThis, int value);

		/// <summary>
		/// Set/get the borders of the chart matrix (space in pixels around each chart).
		/// </summary>
		// Token: 0x060114CC RID: 70860 RVA: 0x00181DCF File Offset: 0x0017FFCF
		public void SetBorderTop(int value)
		{
			vtkChartMatrix.vtkChartMatrix_SetBorderTop_36(base.GetCppThis(), value);
		}

		// Token: 0x060114CD RID: 70861
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_SetBorders_37(HandleRef pThis, int left, int bottom, int right, int top);

		/// <summary>
		/// Set/get the borders of the chart matrix (space in pixels around each chart).
		/// </summary>
		// Token: 0x060114CE RID: 70862 RVA: 0x00181DDF File Offset: 0x0017FFDF
		public virtual void SetBorders(int left, int bottom, int right, int top)
		{
			vtkChartMatrix.vtkChartMatrix_SetBorders_37(base.GetCppThis(), left, bottom, right, top);
		}

		// Token: 0x060114CF RID: 70863
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartMatrix_SetChart_38(HandleRef pThis, HandleRef position, HandleRef chart);

		/// <summary>
		/// Set the chart element, note that the chart matrix must be large enough to
		/// accommodate the element being set. Note that this class will take ownership
		/// of the chart object.
		/// \return false if the element cannot be set.
		/// </summary>
		// Token: 0x060114D0 RID: 70864 RVA: 0x00181DF4 File Offset: 0x0017FFF4
		public virtual bool SetChart(vtkVector2i position, vtkChart chart)
		{
			return vtkChartMatrix.vtkChartMatrix_SetChart_38(base.GetCppThis(), (position == null) ? default(HandleRef) : position.GetCppThis(), (chart == null) ? default(HandleRef) : chart.GetCppThis()) != 0;
		}

		// Token: 0x060114D1 RID: 70865
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartMatrix_SetChartMatrix_39(HandleRef pThis, HandleRef position, HandleRef chartMatrix);

		/// <summary>
		/// Set the element at position to a chart matrix,
		/// note that the chart matrix must be large enough to
		/// accommodate the element being set. Note that this class will take ownership
		/// of the chart matrix object.
		/// \return false if the element cannot be set.
		/// </summary>
		// Token: 0x060114D2 RID: 70866 RVA: 0x00181E44 File Offset: 0x00180044
		public virtual bool SetChartMatrix(vtkVector2i position, vtkChartMatrix chartMatrix)
		{
			return vtkChartMatrix.vtkChartMatrix_SetChartMatrix_39(base.GetCppThis(), (position == null) ? default(HandleRef) : position.GetCppThis(), (chartMatrix == null) ? default(HandleRef) : chartMatrix.GetCppThis()) != 0;
		}

		// Token: 0x060114D3 RID: 70867
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkChartMatrix_SetChartSpan_40(HandleRef pThis, HandleRef position, HandleRef span);

		/// <summary>
		/// Set the span of an element in the matrix. This defaults to 1x1, and cannot
		/// exceed the remaining space in x or y.
		/// \return false If the span is not possible.
		/// </summary>
		// Token: 0x060114D4 RID: 70868 RVA: 0x00181E94 File Offset: 0x00180094
		public virtual bool SetChartSpan(vtkVector2i position, vtkVector2i span)
		{
			return vtkChartMatrix.vtkChartMatrix_SetChartSpan_40(base.GetCppThis(), (position == null) ? default(HandleRef) : position.GetCppThis(), (span == null) ? default(HandleRef) : span.GetCppThis()) != 0;
		}

		// Token: 0x060114D5 RID: 70869
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_SetFillStrategy_41(HandleRef pThis, vtkChartMatrix.StretchType _arg);

		/// <summary>
		/// This specifies whether the chart matrix will fill the entire scene
		/// or instead draw itself in a user provided rectangular subset of the scene.
		/// </summary>
		// Token: 0x060114D6 RID: 70870 RVA: 0x00181EE4 File Offset: 0x001800E4
		public virtual void SetFillStrategy(vtkChartMatrix.StretchType _arg)
		{
			vtkChartMatrix.vtkChartMatrix_SetFillStrategy_41(base.GetCppThis(), _arg);
		}

		// Token: 0x060114D7 RID: 70871
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_SetGutter_42(HandleRef pThis, HandleRef gutter);

		/// <summary>
		/// Set the gutter that should be left between the charts in the matrix.
		/// </summary>
		// Token: 0x060114D8 RID: 70872 RVA: 0x00181EF4 File Offset: 0x001800F4
		public virtual void SetGutter(vtkVector2f gutter)
		{
			vtkChartMatrix.vtkChartMatrix_SetGutter_42(base.GetCppThis(), (gutter == null) ? default(HandleRef) : gutter.GetCppThis());
		}

		// Token: 0x060114D9 RID: 70873
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_SetGutterX_43(HandleRef pThis, float value);

		/// <summary>
		/// Set the gutter that should be left between the charts in the matrix.
		/// </summary>
		// Token: 0x060114DA RID: 70874 RVA: 0x00181F23 File Offset: 0x00180123
		public void SetGutterX(float value)
		{
			vtkChartMatrix.vtkChartMatrix_SetGutterX_43(base.GetCppThis(), value);
		}

		// Token: 0x060114DB RID: 70875
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_SetGutterY_44(HandleRef pThis, float value);

		/// <summary>
		/// Set the gutter that should be left between the charts in the matrix.
		/// </summary>
		// Token: 0x060114DC RID: 70876 RVA: 0x00181F33 File Offset: 0x00180133
		public void SetGutterY(float value)
		{
			vtkChartMatrix.vtkChartMatrix_SetGutterY_44(base.GetCppThis(), value);
		}

		// Token: 0x060114DD RID: 70877
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_SetPadding_45(HandleRef pThis, ref float padding);

		/// <summary>
		/// Set the gutter that should be left between the charts in the matrix.
		/// </summary>
		// Token: 0x060114DE RID: 70878 RVA: 0x00181F43 File Offset: 0x00180143
		public virtual void SetPadding(ref float padding)
		{
			vtkChartMatrix.vtkChartMatrix_SetPadding_45(base.GetCppThis(), ref padding);
		}

		// Token: 0x060114DF RID: 70879
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_SetRect_46(HandleRef pThis, HandleRef rect);

		/// <summary>
		/// Set the rectangular region that this chart matrix will occupy.
		/// Must also set FillStrategy to StretchType::CUSTOM
		/// </summary>
		// Token: 0x060114E0 RID: 70880 RVA: 0x00181F54 File Offset: 0x00180154
		public virtual void SetRect(vtkRecti rect)
		{
			vtkChartMatrix.vtkChartMatrix_SetRect_46(base.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis());
		}

		// Token: 0x060114E1 RID: 70881
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_SetSize_47(HandleRef pThis, HandleRef size);

		/// <summary>
		/// Set the width and height of the chart matrix. This will cause an immediate
		/// resize of the chart matrix, the default size is 0x0 (no charts). No chart
		/// objects are created until Allocate is called.
		/// </summary>
		// Token: 0x060114E2 RID: 70882 RVA: 0x00181F84 File Offset: 0x00180184
		public virtual void SetSize(vtkVector2i size)
		{
			vtkChartMatrix.vtkChartMatrix_SetSize_47(base.GetCppThis(), (size == null) ? default(HandleRef) : size.GetCppThis());
		}

		// Token: 0x060114E3 RID: 70883
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_SetSpecificResize_48(HandleRef pThis, HandleRef index, HandleRef resize);

		/// <summary>
		/// Set a specific resize that will move the bottom left point of a chart.
		/// </summary>
		// Token: 0x060114E4 RID: 70884 RVA: 0x00181FB4 File Offset: 0x001801B4
		public virtual void SetSpecificResize(vtkVector2i index, vtkVector2f resize)
		{
			vtkChartMatrix.vtkChartMatrix_SetSpecificResize_48(base.GetCppThis(), (index == null) ? default(HandleRef) : index.GetCppThis(), (resize == null) ? default(HandleRef) : resize.GetCppThis());
		}

		// Token: 0x060114E5 RID: 70885
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_Unlink_49(HandleRef pThis, HandleRef index1, HandleRef index2, int axis);

		/// <summary>
		/// Unlink the two charts for specified axis i.e,
		/// Chart at index2 will no longer mimic the axis range of chart at index1
		/// </summary>
		// Token: 0x060114E6 RID: 70886 RVA: 0x00181FF8 File Offset: 0x001801F8
		public virtual void Unlink(vtkVector2i index1, vtkVector2i index2, int axis)
		{
			vtkChartMatrix.vtkChartMatrix_Unlink_49(base.GetCppThis(), (index1 == null) ? default(HandleRef) : index1.GetCppThis(), (index2 == null) ? default(HandleRef) : index2.GetCppThis(), axis);
		}

		// Token: 0x060114E7 RID: 70887
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_Unlink_50(HandleRef pThis, ref ulong flatIndex1, ref ulong flatIndex2, int axis);

		/// <summary>
		/// Unlink the two charts for specified axis i.e,
		/// Chart at index2 will no longer mimic the axis range of chart at index1
		/// </summary>
		// Token: 0x060114E8 RID: 70888 RVA: 0x0018203D File Offset: 0x0018023D
		public virtual void Unlink(ref ulong flatIndex1, ref ulong flatIndex2, int axis)
		{
			vtkChartMatrix.vtkChartMatrix_Unlink_50(base.GetCppThis(), ref flatIndex1, ref flatIndex2, axis);
		}

		// Token: 0x060114E9 RID: 70889
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_UnlinkAll_51(HandleRef pThis, HandleRef index, int axis);

		/// <summary>
		/// Unlink all charts from given chart for a specified axis.
		/// </summary>
		// Token: 0x060114EA RID: 70890 RVA: 0x00182050 File Offset: 0x00180250
		public virtual void UnlinkAll(vtkVector2i index, int axis)
		{
			vtkChartMatrix.vtkChartMatrix_UnlinkAll_51(base.GetCppThis(), (index == null) ? default(HandleRef) : index.GetCppThis(), axis);
		}

		// Token: 0x060114EB RID: 70891
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_UnlinkAll_52(HandleRef pThis, ref ulong flatIndex, int axis);

		/// <summary>
		/// Unlink all charts from given chart for a specified axis.
		/// </summary>
		// Token: 0x060114EC RID: 70892 RVA: 0x00182080 File Offset: 0x00180280
		public virtual void UnlinkAll(ref ulong flatIndex, int axis)
		{
			vtkChartMatrix.vtkChartMatrix_UnlinkAll_52(base.GetCppThis(), ref flatIndex, axis);
		}

		// Token: 0x060114ED RID: 70893
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChartMatrix_Update_53(HandleRef pThis);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// </summary>
		// Token: 0x060114EE RID: 70894 RVA: 0x00182091 File Offset: 0x00180291
		public override void Update()
		{
			vtkChartMatrix.vtkChartMatrix_Update_53(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001404 RID: 5124
		public new const string MRFullTypeName = "Kitware.VTK.vtkChartMatrix";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001405 RID: 5125
		public new static readonly string MRClassNameKey = "class vtkChartMatrix";

		/// <summary>
		/// Override this method if you want to customize layout instead of the default.
		/// The returned rect will be in scene coordinates and suitable for a chart element
		/// or chart matrix element.
		/// </summary>
		// Token: 0x0200063F RID: 1599
		public enum StretchType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001407 RID: 5127
			CUSTOM = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001408 RID: 5128
			SCENE = 0
		}
	}
}
