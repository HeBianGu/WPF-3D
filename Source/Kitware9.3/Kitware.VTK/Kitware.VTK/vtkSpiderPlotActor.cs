using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSpiderPlotActor
	/// </summary>
	/// <remarks>
	///    create a spider plot from input field
	///
	/// vtkSpiderPlotActor generates a spider plot from an input field (i.e.,
	/// vtkDataObject). A spider plot represents N-dimensional data by using a set
	/// of N axes that originate from the center of a circle, and form the spokes
	/// of a wheel (like a spider web).  Each N-dimensional point is plotted as a
	/// polyline that forms a closed polygon; the vertices of the polygon
	/// are plotted against the radial axes.
	///
	/// To use this class, you must specify an input data object. You'll probably
	/// also want to specify the position of the plot be setting the Position and
	/// Position2 instance variables, which define a rectangle in which the plot
	/// lies. Another important parameter is the IndependentVariables ivar, which
	/// tells the instance how to interpret the field data (independent variables
	/// as the rows or columns of the field). There are also many other instance
	/// variables that control the look of the plot includes its title and legend.
	///
	/// Set the text property/attributes of the title and the labels through the
	/// vtkTextProperty objects associated with these components.
	///
	/// @warning
	/// Field data is not necessarily "rectangular" in shape. In these cases, some
	/// of the data may not be plotted.
	///
	/// @warning
	/// Field data can contain non-numeric arrays (i.e. arrays not subclasses of
	/// vtkDataArray). Such arrays are skipped.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkParallelCoordinatesActor vtkXYPlotActor2D
	/// </seealso>
	// Token: 0x020003DA RID: 986
	public class vtkSpiderPlotActor : vtkActor2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600BA96 RID: 47766 RVA: 0x00105851 File Offset: 0x00103A51
		static vtkSpiderPlotActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpiderPlotActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpiderPlotActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600BA97 RID: 47767 RVA: 0x00105879 File Offset: 0x00103A79
		public vtkSpiderPlotActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600BA98 RID: 47768
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpiderPlotActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600BA99 RID: 47769 RVA: 0x00105888 File Offset: 0x00103A88
		public new static vtkSpiderPlotActor New()
		{
			vtkSpiderPlotActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpiderPlotActor.vtkSpiderPlotActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpiderPlotActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600BA9A RID: 47770 RVA: 0x001058DC File Offset: 0x00103ADC
		public vtkSpiderPlotActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSpiderPlotActor.vtkSpiderPlotActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600BA9B RID: 47771 RVA: 0x00105920 File Offset: 0x00103B20
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600BA9C RID: 47772
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpiderPlotActor_GetAxisLabel_01(HandleRef pThis, int i);

		/// <summary>
		/// Specify the names of the radial spokes (i.e., the radial axes). If
		/// not specified, then an integer number is automatically generated.
		/// </summary>
		// Token: 0x0600BA9D RID: 47773 RVA: 0x0010592C File Offset: 0x00103B2C
		public string GetAxisLabel(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkSpiderPlotActor.vtkSpiderPlotActor_GetAxisLabel_01(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600BA9E RID: 47774
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_GetAxisRange_02(HandleRef pThis, int i, IntPtr range);

		/// <summary>
		/// Specify the range of data on each radial axis. If not specified,
		/// then the range is computed automatically.
		/// </summary>
		// Token: 0x0600BA9F RID: 47775 RVA: 0x00105967 File Offset: 0x00103B67
		public void GetAxisRange(int i, IntPtr range)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_GetAxisRange_02(base.GetCppThis(), i, range);
		}

		// Token: 0x0600BAA0 RID: 47776
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpiderPlotActor_GetIndependentVariables_03(HandleRef pThis);

		/// <summary>
		/// Specify whether to use the rows or columns as independent variables.
		/// If columns, then each row represents a separate point. If rows, then
		/// each column represents a separate point.
		/// </summary>
		// Token: 0x0600BAA1 RID: 47777 RVA: 0x00105978 File Offset: 0x00103B78
		public virtual int GetIndependentVariables()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetIndependentVariables_03(base.GetCppThis());
		}

		// Token: 0x0600BAA2 RID: 47778
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpiderPlotActor_GetIndependentVariablesMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Specify whether to use the rows or columns as independent variables.
		/// If columns, then each row represents a separate point. If rows, then
		/// each column represents a separate point.
		/// </summary>
		// Token: 0x0600BAA3 RID: 47779 RVA: 0x00105998 File Offset: 0x00103B98
		public virtual int GetIndependentVariablesMaxValue()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetIndependentVariablesMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0600BAA4 RID: 47780
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpiderPlotActor_GetIndependentVariablesMinValue_05(HandleRef pThis);

		/// <summary>
		/// Specify whether to use the rows or columns as independent variables.
		/// If columns, then each row represents a separate point. If rows, then
		/// each column represents a separate point.
		/// </summary>
		// Token: 0x0600BAA5 RID: 47781 RVA: 0x001059B8 File Offset: 0x00103BB8
		public virtual int GetIndependentVariablesMinValue()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetIndependentVariablesMinValue_05(base.GetCppThis());
		}

		// Token: 0x0600BAA6 RID: 47782
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpiderPlotActor_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input data object to this actor.
		/// </summary>
		// Token: 0x0600BAA7 RID: 47783 RVA: 0x001059D8 File Offset: 0x00103BD8
		public virtual vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpiderPlotActor.vtkSpiderPlotActor_GetInput_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0600BAA8 RID: 47784
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpiderPlotActor_GetLabelTextProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Enable/Disable the creation of a legend. If on, the legend labels will
		/// be created automatically unless the per plot legend symbol has been
		/// set.
		/// </summary>
		// Token: 0x0600BAA9 RID: 47785 RVA: 0x00105A48 File Offset: 0x00103C48
		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpiderPlotActor.vtkSpiderPlotActor_GetLabelTextProperty_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600BAAA RID: 47786
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpiderPlotActor_GetLabelVisibility_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the title text property.
		/// </summary>
		// Token: 0x0600BAAB RID: 47787 RVA: 0x00105AB8 File Offset: 0x00103CB8
		public virtual int GetLabelVisibility()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetLabelVisibility_08(base.GetCppThis());
		}

		// Token: 0x0600BAAC RID: 47788
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpiderPlotActor_GetLegendActor_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve handles to the legend box. This is useful if you would like
		/// to manually control the legend appearance.
		/// </summary>
		// Token: 0x0600BAAD RID: 47789 RVA: 0x00105AD8 File Offset: 0x00103CD8
		public virtual vtkLegendBoxActor GetLegendActor()
		{
			vtkLegendBoxActor vtkLegendBoxActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpiderPlotActor.vtkSpiderPlotActor_GetLegendActor_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLegendBoxActor = (vtkLegendBoxActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLegendBoxActor.Register(null);
				}
			}
			return vtkLegendBoxActor;
		}

		// Token: 0x0600BAAE RID: 47790
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpiderPlotActor_GetLegendVisibility_10(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the creation of a legend. If on, the legend labels will
		/// be created automatically unless the per plot legend symbol has been
		/// set.
		/// </summary>
		// Token: 0x0600BAAF RID: 47791 RVA: 0x00105B48 File Offset: 0x00103D48
		public virtual int GetLegendVisibility()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetLegendVisibility_10(base.GetCppThis());
		}

		// Token: 0x0600BAB0 RID: 47792
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpiderPlotActor_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600BAB1 RID: 47793 RVA: 0x00105B68 File Offset: 0x00103D68
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0600BAB2 RID: 47794
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpiderPlotActor_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600BAB3 RID: 47795 RVA: 0x00105B88 File Offset: 0x00103D88
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0600BAB4 RID: 47796
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpiderPlotActor_GetNumberOfRings_13(HandleRef pThis);

		/// <summary>
		/// Specify the number of circumferential rings. If set to zero, then
		/// none will be shown; otherwise the specified number will be shown.
		/// </summary>
		// Token: 0x0600BAB5 RID: 47797 RVA: 0x00105BA4 File Offset: 0x00103DA4
		public virtual int GetNumberOfRings()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetNumberOfRings_13(base.GetCppThis());
		}

		// Token: 0x0600BAB6 RID: 47798
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpiderPlotActor_GetNumberOfRingsMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Specify the number of circumferential rings. If set to zero, then
		/// none will be shown; otherwise the specified number will be shown.
		/// </summary>
		// Token: 0x0600BAB7 RID: 47799 RVA: 0x00105BC4 File Offset: 0x00103DC4
		public virtual int GetNumberOfRingsMaxValue()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetNumberOfRingsMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0600BAB8 RID: 47800
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpiderPlotActor_GetNumberOfRingsMinValue_15(HandleRef pThis);

		/// <summary>
		/// Specify the number of circumferential rings. If set to zero, then
		/// none will be shown; otherwise the specified number will be shown.
		/// </summary>
		// Token: 0x0600BAB9 RID: 47801 RVA: 0x00105BE4 File Offset: 0x00103DE4
		public virtual int GetNumberOfRingsMinValue()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetNumberOfRingsMinValue_15(base.GetCppThis());
		}

		// Token: 0x0600BABA RID: 47802
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpiderPlotActor_GetPlotColor_16(HandleRef pThis, int i);

		/// <summary>
		/// Specify colors for each plot. If not specified, they are automatically generated.
		/// </summary>
		// Token: 0x0600BABB RID: 47803 RVA: 0x00105C04 File Offset: 0x00103E04
		public IntPtr GetPlotColor(int i)
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetPlotColor_16(base.GetCppThis(), i);
		}

		// Token: 0x0600BABC RID: 47804
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpiderPlotActor_GetTitle_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the title of the spider plot.
		/// </summary>
		// Token: 0x0600BABD RID: 47805 RVA: 0x00105C24 File Offset: 0x00103E24
		public virtual string GetTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkSpiderPlotActor.vtkSpiderPlotActor_GetTitle_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600BABE RID: 47806
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpiderPlotActor_GetTitleTextProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the title text property.
		/// </summary>
		// Token: 0x0600BABF RID: 47807 RVA: 0x00105C60 File Offset: 0x00103E60
		public virtual vtkTextProperty GetTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpiderPlotActor.vtkSpiderPlotActor_GetTitleTextProperty_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600BAC0 RID: 47808
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpiderPlotActor_GetTitleVisibility_19(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the display of a plot title.
		/// </summary>
		// Token: 0x0600BAC1 RID: 47809 RVA: 0x00105CD0 File Offset: 0x00103ED0
		public virtual int GetTitleVisibility()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_GetTitleVisibility_19(base.GetCppThis());
		}

		// Token: 0x0600BAC2 RID: 47810
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpiderPlotActor_HasTranslucentPolygonalGeometry_20(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600BAC3 RID: 47811 RVA: 0x00105CF0 File Offset: 0x00103EF0
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_HasTranslucentPolygonalGeometry_20(base.GetCppThis());
		}

		// Token: 0x0600BAC4 RID: 47812
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpiderPlotActor_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600BAC5 RID: 47813 RVA: 0x00105D10 File Offset: 0x00103F10
		public override int IsA(string type)
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x0600BAC6 RID: 47814
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpiderPlotActor_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600BAC7 RID: 47815 RVA: 0x00105D30 File Offset: 0x00103F30
		public new static int IsTypeOf(string type)
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_IsTypeOf_22(type);
		}

		// Token: 0x0600BAC8 RID: 47816
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_LabelVisibilityOff_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the title text property.
		/// </summary>
		// Token: 0x0600BAC9 RID: 47817 RVA: 0x00105D4A File Offset: 0x00103F4A
		public virtual void LabelVisibilityOff()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_LabelVisibilityOff_23(base.GetCppThis());
		}

		// Token: 0x0600BACA RID: 47818
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_LabelVisibilityOn_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the title text property.
		/// </summary>
		// Token: 0x0600BACB RID: 47819 RVA: 0x00105D59 File Offset: 0x00103F59
		public virtual void LabelVisibilityOn()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_LabelVisibilityOn_24(base.GetCppThis());
		}

		// Token: 0x0600BACC RID: 47820
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_LegendVisibilityOff_25(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the creation of a legend. If on, the legend labels will
		/// be created automatically unless the per plot legend symbol has been
		/// set.
		/// </summary>
		// Token: 0x0600BACD RID: 47821 RVA: 0x00105D68 File Offset: 0x00103F68
		public virtual void LegendVisibilityOff()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_LegendVisibilityOff_25(base.GetCppThis());
		}

		// Token: 0x0600BACE RID: 47822
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_LegendVisibilityOn_26(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the creation of a legend. If on, the legend labels will
		/// be created automatically unless the per plot legend symbol has been
		/// set.
		/// </summary>
		// Token: 0x0600BACF RID: 47823 RVA: 0x00105D77 File Offset: 0x00103F77
		public virtual void LegendVisibilityOn()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_LegendVisibilityOn_26(base.GetCppThis());
		}

		// Token: 0x0600BAD0 RID: 47824
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpiderPlotActor_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600BAD1 RID: 47825 RVA: 0x00105D88 File Offset: 0x00103F88
		public new vtkSpiderPlotActor NewInstance()
		{
			vtkSpiderPlotActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpiderPlotActor.vtkSpiderPlotActor_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpiderPlotActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600BAD2 RID: 47826
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_ReleaseGraphicsResources_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600BAD3 RID: 47827 RVA: 0x00105DE4 File Offset: 0x00103FE4
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_ReleaseGraphicsResources_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600BAD4 RID: 47828
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpiderPlotActor_RenderOpaqueGeometry_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the spider plot.
		/// </summary>
		// Token: 0x0600BAD5 RID: 47829 RVA: 0x00105E14 File Offset: 0x00104014
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_RenderOpaqueGeometry_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600BAD6 RID: 47830
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpiderPlotActor_RenderOverlay_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the spider plot.
		/// </summary>
		// Token: 0x0600BAD7 RID: 47831 RVA: 0x00105E48 File Offset: 0x00104048
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_RenderOverlay_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600BAD8 RID: 47832
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpiderPlotActor_RenderTranslucentPolygonalGeometry_32(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the spider plot.
		/// </summary>
		// Token: 0x0600BAD9 RID: 47833 RVA: 0x00105E7C File Offset: 0x0010407C
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkSpiderPlotActor.vtkSpiderPlotActor_RenderTranslucentPolygonalGeometry_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600BADA RID: 47834
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpiderPlotActor_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600BADB RID: 47835 RVA: 0x00105EB0 File Offset: 0x001040B0
		public new static vtkSpiderPlotActor SafeDownCast(vtkObjectBase o)
		{
			vtkSpiderPlotActor vtkSpiderPlotActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpiderPlotActor.vtkSpiderPlotActor_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpiderPlotActor = (vtkSpiderPlotActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpiderPlotActor.Register(null);
				}
			}
			return vtkSpiderPlotActor;
		}

		// Token: 0x0600BADC RID: 47836
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetAxisLabel_34(HandleRef pThis, int i, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1);

		/// <summary>
		/// Specify the names of the radial spokes (i.e., the radial axes). If
		/// not specified, then an integer number is automatically generated.
		/// </summary>
		// Token: 0x0600BADD RID: 47837 RVA: 0x00105F2F File Offset: 0x0010412F
		public void SetAxisLabel(int i, string arg1)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetAxisLabel_34(base.GetCppThis(), i, arg1);
		}

		// Token: 0x0600BADE RID: 47838
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetAxisRange_35(HandleRef pThis, int i, double min, double max);

		/// <summary>
		/// Specify the range of data on each radial axis. If not specified,
		/// then the range is computed automatically.
		/// </summary>
		// Token: 0x0600BADF RID: 47839 RVA: 0x00105F40 File Offset: 0x00104140
		public void SetAxisRange(int i, double min, double max)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetAxisRange_35(base.GetCppThis(), i, min, max);
		}

		// Token: 0x0600BAE0 RID: 47840
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetAxisRange_36(HandleRef pThis, int i, IntPtr range);

		/// <summary>
		/// Specify the range of data on each radial axis. If not specified,
		/// then the range is computed automatically.
		/// </summary>
		// Token: 0x0600BAE1 RID: 47841 RVA: 0x00105F52 File Offset: 0x00104152
		public void SetAxisRange(int i, IntPtr range)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetAxisRange_36(base.GetCppThis(), i, range);
		}

		// Token: 0x0600BAE2 RID: 47842
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetIndependentVariables_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to use the rows or columns as independent variables.
		/// If columns, then each row represents a separate point. If rows, then
		/// each column represents a separate point.
		/// </summary>
		// Token: 0x0600BAE3 RID: 47843 RVA: 0x00105F63 File Offset: 0x00104163
		public virtual void SetIndependentVariables(int _arg)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetIndependentVariables_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BAE4 RID: 47844
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetIndependentVariablesToColumns_38(HandleRef pThis);

		/// <summary>
		/// Specify whether to use the rows or columns as independent variables.
		/// If columns, then each row represents a separate point. If rows, then
		/// each column represents a separate point.
		/// </summary>
		// Token: 0x0600BAE5 RID: 47845 RVA: 0x00105F73 File Offset: 0x00104173
		public void SetIndependentVariablesToColumns()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetIndependentVariablesToColumns_38(base.GetCppThis());
		}

		// Token: 0x0600BAE6 RID: 47846
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetIndependentVariablesToRows_39(HandleRef pThis);

		/// <summary>
		/// Specify whether to use the rows or columns as independent variables.
		/// If columns, then each row represents a separate point. If rows, then
		/// each column represents a separate point.
		/// </summary>
		// Token: 0x0600BAE7 RID: 47847 RVA: 0x00105F82 File Offset: 0x00104182
		public void SetIndependentVariablesToRows()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetIndependentVariablesToRows_39(base.GetCppThis());
		}

		// Token: 0x0600BAE8 RID: 47848
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetInputConnection_40(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the input to the pie chart actor. SetInputData()
		/// does not connect the pipeline whereas SetInputConnection()
		/// does.
		/// </summary>
		// Token: 0x0600BAE9 RID: 47849 RVA: 0x00105F94 File Offset: 0x00104194
		public virtual void SetInputConnection(vtkAlgorithmOutput arg0)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetInputConnection_40(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600BAEA RID: 47850
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetInputData_41(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the input to the pie chart actor. SetInputData()
		/// does not connect the pipeline whereas SetInputConnection()
		/// does.
		/// </summary>
		// Token: 0x0600BAEB RID: 47851 RVA: 0x00105FC4 File Offset: 0x001041C4
		public virtual void SetInputData(vtkDataObject arg0)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetInputData_41(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600BAEC RID: 47852
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetLabelTextProperty_42(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Enable/Disable the creation of a legend. If on, the legend labels will
		/// be created automatically unless the per plot legend symbol has been
		/// set.
		/// </summary>
		// Token: 0x0600BAED RID: 47853 RVA: 0x00105FF4 File Offset: 0x001041F4
		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetLabelTextProperty_42(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600BAEE RID: 47854
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetLabelVisibility_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the title text property.
		/// </summary>
		// Token: 0x0600BAEF RID: 47855 RVA: 0x00106023 File Offset: 0x00104223
		public virtual void SetLabelVisibility(int _arg)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetLabelVisibility_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BAF0 RID: 47856
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetLegendVisibility_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/Disable the creation of a legend. If on, the legend labels will
		/// be created automatically unless the per plot legend symbol has been
		/// set.
		/// </summary>
		// Token: 0x0600BAF1 RID: 47857 RVA: 0x00106033 File Offset: 0x00104233
		public virtual void SetLegendVisibility(int _arg)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetLegendVisibility_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BAF2 RID: 47858
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetNumberOfRings_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of circumferential rings. If set to zero, then
		/// none will be shown; otherwise the specified number will be shown.
		/// </summary>
		// Token: 0x0600BAF3 RID: 47859 RVA: 0x00106043 File Offset: 0x00104243
		public virtual void SetNumberOfRings(int _arg)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetNumberOfRings_45(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BAF4 RID: 47860
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetPlotColor_46(HandleRef pThis, int i, double r, double g, double b);

		/// <summary>
		/// Specify colors for each plot. If not specified, they are automatically generated.
		/// </summary>
		// Token: 0x0600BAF5 RID: 47861 RVA: 0x00106053 File Offset: 0x00104253
		public void SetPlotColor(int i, double r, double g, double b)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetPlotColor_46(base.GetCppThis(), i, r, g, b);
		}

		// Token: 0x0600BAF6 RID: 47862
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetPlotColor_47(HandleRef pThis, int i, IntPtr color);

		/// <summary>
		/// Specify colors for each plot. If not specified, they are automatically generated.
		/// </summary>
		// Token: 0x0600BAF7 RID: 47863 RVA: 0x00106067 File Offset: 0x00104267
		public void SetPlotColor(int i, IntPtr color)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetPlotColor_47(base.GetCppThis(), i, color);
		}

		// Token: 0x0600BAF8 RID: 47864
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetTitle_48(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the title of the spider plot.
		/// </summary>
		// Token: 0x0600BAF9 RID: 47865 RVA: 0x00106078 File Offset: 0x00104278
		public virtual void SetTitle(string _arg)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetTitle_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BAFA RID: 47866
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetTitleTextProperty_49(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the title text property.
		/// </summary>
		// Token: 0x0600BAFB RID: 47867 RVA: 0x00106088 File Offset: 0x00104288
		public virtual void SetTitleTextProperty(vtkTextProperty p)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetTitleTextProperty_49(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600BAFC RID: 47868
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_SetTitleVisibility_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/Disable the display of a plot title.
		/// </summary>
		// Token: 0x0600BAFD RID: 47869 RVA: 0x001060B7 File Offset: 0x001042B7
		public virtual void SetTitleVisibility(int _arg)
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_SetTitleVisibility_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BAFE RID: 47870
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_TitleVisibilityOff_51(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the display of a plot title.
		/// </summary>
		// Token: 0x0600BAFF RID: 47871 RVA: 0x001060C7 File Offset: 0x001042C7
		public virtual void TitleVisibilityOff()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_TitleVisibilityOff_51(base.GetCppThis());
		}

		// Token: 0x0600BB00 RID: 47872
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpiderPlotActor_TitleVisibilityOn_52(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the display of a plot title.
		/// </summary>
		// Token: 0x0600BB01 RID: 47873 RVA: 0x001060D6 File Offset: 0x001042D6
		public virtual void TitleVisibilityOn()
		{
			vtkSpiderPlotActor.vtkSpiderPlotActor_TitleVisibilityOn_52(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E13 RID: 3603
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpiderPlotActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E14 RID: 3604
		public new static readonly string MRClassNameKey = "class vtkSpiderPlotActor";
	}
}
