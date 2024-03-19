using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPieChartActor
	/// </summary>
	/// <remarks>
	///    create a pie chart from an array
	///
	/// vtkPieChartActor generates a pie chart from an array of numbers defined in
	/// field data (a vtkDataObject). To use this class, you must specify an input
	/// data object. You'll probably also want to specify the position of the plot
	/// be setting the Position and Position2 instance variables, which define a
	/// rectangle in which the plot lies.  There are also many other instance
	/// variables that control the look of the plot includes its title,
	/// and legend.
	///
	/// Set the text property/attributes of the title and the labels through the
	/// vtkTextProperty objects associated with these components.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkParallelCoordinatesActor vtkXYPlotActor2D vtkSpiderPlotActor
	/// </seealso>
	// Token: 0x020003D2 RID: 978
	public class vtkPieChartActor : vtkActor2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B6D0 RID: 46800 RVA: 0x001013EF File Offset: 0x000FF5EF
		static vtkPieChartActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPieChartActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPieChartActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B6D1 RID: 46801 RVA: 0x00101417 File Offset: 0x000FF617
		public vtkPieChartActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B6D2 RID: 46802
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieChartActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600B6D3 RID: 46803 RVA: 0x00101428 File Offset: 0x000FF628
		public new static vtkPieChartActor New()
		{
			vtkPieChartActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPieChartActor.vtkPieChartActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPieChartActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600B6D4 RID: 46804 RVA: 0x0010147C File Offset: 0x000FF67C
		public vtkPieChartActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPieChartActor.vtkPieChartActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B6D5 RID: 46805 RVA: 0x001014C0 File Offset: 0x000FF6C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B6D6 RID: 46806
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieChartActor_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input data object to this actor.
		/// </summary>
		// Token: 0x0600B6D7 RID: 46807 RVA: 0x001014CC File Offset: 0x000FF6CC
		public virtual vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPieChartActor.vtkPieChartActor_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B6D8 RID: 46808
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieChartActor_GetLabelTextProperty_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the labels text property. This controls the appearance
		/// of all pie piece labels.
		/// </summary>
		// Token: 0x0600B6D9 RID: 46809 RVA: 0x0010153C File Offset: 0x000FF73C
		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPieChartActor.vtkPieChartActor_GetLabelTextProperty_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B6DA RID: 46810
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieChartActor_GetLabelVisibility_03(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the display of pie piece labels.
		/// </summary>
		// Token: 0x0600B6DB RID: 46811 RVA: 0x001015AC File Offset: 0x000FF7AC
		public virtual int GetLabelVisibility()
		{
			return vtkPieChartActor.vtkPieChartActor_GetLabelVisibility_03(base.GetCppThis());
		}

		// Token: 0x0600B6DC RID: 46812
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieChartActor_GetLegendActor_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve handles to the legend box. This is useful if you would like
		/// to manually control the legend appearance.
		/// </summary>
		// Token: 0x0600B6DD RID: 46813 RVA: 0x001015CC File Offset: 0x000FF7CC
		public virtual vtkLegendBoxActor GetLegendActor()
		{
			vtkLegendBoxActor vtkLegendBoxActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPieChartActor.vtkPieChartActor_GetLegendActor_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B6DE RID: 46814
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieChartActor_GetLegendVisibility_05(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the creation of a legend. If on, the legend labels will
		/// be created automatically unless the per plot legend symbol has been
		/// set.
		/// </summary>
		// Token: 0x0600B6DF RID: 46815 RVA: 0x0010163C File Offset: 0x000FF83C
		public virtual int GetLegendVisibility()
		{
			return vtkPieChartActor.vtkPieChartActor_GetLegendVisibility_05(base.GetCppThis());
		}

		// Token: 0x0600B6E0 RID: 46816
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPieChartActor_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600B6E1 RID: 46817 RVA: 0x0010165C File Offset: 0x000FF85C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPieChartActor.vtkPieChartActor_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600B6E2 RID: 46818
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPieChartActor_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600B6E3 RID: 46819 RVA: 0x0010167C File Offset: 0x000FF87C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPieChartActor.vtkPieChartActor_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600B6E4 RID: 46820
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieChartActor_GetPieceColor_08(HandleRef pThis, int i);

		/// <summary>
		/// Specify colors for each piece of pie. If not specified, they are
		/// automatically generated.
		/// </summary>
		// Token: 0x0600B6E5 RID: 46821 RVA: 0x00101698 File Offset: 0x000FF898
		public IntPtr GetPieceColor(int i)
		{
			return vtkPieChartActor.vtkPieChartActor_GetPieceColor_08(base.GetCppThis(), i);
		}

		// Token: 0x0600B6E6 RID: 46822
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieChartActor_GetPieceLabel_09(HandleRef pThis, int i);

		/// <summary>
		/// Specify the names for each piece of pie.  not specified, then an integer
		/// number is automatically generated.
		/// </summary>
		// Token: 0x0600B6E7 RID: 46823 RVA: 0x001016B8 File Offset: 0x000FF8B8
		public string GetPieceLabel(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkPieChartActor.vtkPieChartActor_GetPieceLabel_09(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B6E8 RID: 46824
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieChartActor_GetTitle_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the title of the pie chart.
		/// </summary>
		// Token: 0x0600B6E9 RID: 46825 RVA: 0x001016F4 File Offset: 0x000FF8F4
		public virtual string GetTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkPieChartActor.vtkPieChartActor_GetTitle_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B6EA RID: 46826
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieChartActor_GetTitleTextProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the title text property. The property controls the
		/// appearance of the plot title.
		/// </summary>
		// Token: 0x0600B6EB RID: 46827 RVA: 0x00101730 File Offset: 0x000FF930
		public virtual vtkTextProperty GetTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPieChartActor.vtkPieChartActor_GetTitleTextProperty_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B6EC RID: 46828
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieChartActor_GetTitleVisibility_12(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the display of a plot title.
		/// </summary>
		// Token: 0x0600B6ED RID: 46829 RVA: 0x001017A0 File Offset: 0x000FF9A0
		public virtual int GetTitleVisibility()
		{
			return vtkPieChartActor.vtkPieChartActor_GetTitleVisibility_12(base.GetCppThis());
		}

		// Token: 0x0600B6EE RID: 46830
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieChartActor_HasTranslucentPolygonalGeometry_13(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600B6EF RID: 46831 RVA: 0x001017C0 File Offset: 0x000FF9C0
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkPieChartActor.vtkPieChartActor_HasTranslucentPolygonalGeometry_13(base.GetCppThis());
		}

		// Token: 0x0600B6F0 RID: 46832
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieChartActor_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600B6F1 RID: 46833 RVA: 0x001017E0 File Offset: 0x000FF9E0
		public override int IsA(string type)
		{
			return vtkPieChartActor.vtkPieChartActor_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0600B6F2 RID: 46834
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieChartActor_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600B6F3 RID: 46835 RVA: 0x00101800 File Offset: 0x000FFA00
		public new static int IsTypeOf(string type)
		{
			return vtkPieChartActor.vtkPieChartActor_IsTypeOf_15(type);
		}

		// Token: 0x0600B6F4 RID: 46836
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_LabelVisibilityOff_16(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the display of pie piece labels.
		/// </summary>
		// Token: 0x0600B6F5 RID: 46837 RVA: 0x0010181A File Offset: 0x000FFA1A
		public virtual void LabelVisibilityOff()
		{
			vtkPieChartActor.vtkPieChartActor_LabelVisibilityOff_16(base.GetCppThis());
		}

		// Token: 0x0600B6F6 RID: 46838
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_LabelVisibilityOn_17(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the display of pie piece labels.
		/// </summary>
		// Token: 0x0600B6F7 RID: 46839 RVA: 0x00101829 File Offset: 0x000FFA29
		public virtual void LabelVisibilityOn()
		{
			vtkPieChartActor.vtkPieChartActor_LabelVisibilityOn_17(base.GetCppThis());
		}

		// Token: 0x0600B6F8 RID: 46840
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_LegendVisibilityOff_18(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the creation of a legend. If on, the legend labels will
		/// be created automatically unless the per plot legend symbol has been
		/// set.
		/// </summary>
		// Token: 0x0600B6F9 RID: 46841 RVA: 0x00101838 File Offset: 0x000FFA38
		public virtual void LegendVisibilityOff()
		{
			vtkPieChartActor.vtkPieChartActor_LegendVisibilityOff_18(base.GetCppThis());
		}

		// Token: 0x0600B6FA RID: 46842
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_LegendVisibilityOn_19(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the creation of a legend. If on, the legend labels will
		/// be created automatically unless the per plot legend symbol has been
		/// set.
		/// </summary>
		// Token: 0x0600B6FB RID: 46843 RVA: 0x00101847 File Offset: 0x000FFA47
		public virtual void LegendVisibilityOn()
		{
			vtkPieChartActor.vtkPieChartActor_LegendVisibilityOn_19(base.GetCppThis());
		}

		// Token: 0x0600B6FC RID: 46844
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieChartActor_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600B6FD RID: 46845 RVA: 0x00101858 File Offset: 0x000FFA58
		public new vtkPieChartActor NewInstance()
		{
			vtkPieChartActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPieChartActor.vtkPieChartActor_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPieChartActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B6FE RID: 46846
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_ReleaseGraphicsResources_22(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600B6FF RID: 46847 RVA: 0x001018B4 File Offset: 0x000FFAB4
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkPieChartActor.vtkPieChartActor_ReleaseGraphicsResources_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B700 RID: 46848
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieChartActor_RenderOpaqueGeometry_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the pie plot.
		/// </summary>
		// Token: 0x0600B701 RID: 46849 RVA: 0x001018E4 File Offset: 0x000FFAE4
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkPieChartActor.vtkPieChartActor_RenderOpaqueGeometry_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B702 RID: 46850
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieChartActor_RenderOverlay_24(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the pie plot.
		/// </summary>
		// Token: 0x0600B703 RID: 46851 RVA: 0x00101918 File Offset: 0x000FFB18
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkPieChartActor.vtkPieChartActor_RenderOverlay_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B704 RID: 46852
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieChartActor_RenderTranslucentPolygonalGeometry_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the pie plot.
		/// </summary>
		// Token: 0x0600B705 RID: 46853 RVA: 0x0010194C File Offset: 0x000FFB4C
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkPieChartActor.vtkPieChartActor_RenderTranslucentPolygonalGeometry_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B706 RID: 46854
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieChartActor_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600B707 RID: 46855 RVA: 0x00101980 File Offset: 0x000FFB80
		public new static vtkPieChartActor SafeDownCast(vtkObjectBase o)
		{
			vtkPieChartActor vtkPieChartActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPieChartActor.vtkPieChartActor_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPieChartActor = (vtkPieChartActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPieChartActor.Register(null);
				}
			}
			return vtkPieChartActor;
		}

		// Token: 0x0600B708 RID: 46856
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_SetInputConnection_27(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the input to the pie chart actor. SetInputData()
		/// does not connect the pipeline whereas SetInputConnection()
		/// does.
		/// </summary>
		// Token: 0x0600B709 RID: 46857 RVA: 0x00101A00 File Offset: 0x000FFC00
		public virtual void SetInputConnection(vtkAlgorithmOutput arg0)
		{
			vtkPieChartActor.vtkPieChartActor_SetInputConnection_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B70A RID: 46858
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_SetInputData_28(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the input to the pie chart actor. SetInputData()
		/// does not connect the pipeline whereas SetInputConnection()
		/// does.
		/// </summary>
		// Token: 0x0600B70B RID: 46859 RVA: 0x00101A30 File Offset: 0x000FFC30
		public virtual void SetInputData(vtkDataObject arg0)
		{
			vtkPieChartActor.vtkPieChartActor_SetInputData_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B70C RID: 46860
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_SetLabelTextProperty_29(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the labels text property. This controls the appearance
		/// of all pie piece labels.
		/// </summary>
		// Token: 0x0600B70D RID: 46861 RVA: 0x00101A60 File Offset: 0x000FFC60
		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkPieChartActor.vtkPieChartActor_SetLabelTextProperty_29(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B70E RID: 46862
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_SetLabelVisibility_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/Disable the display of pie piece labels.
		/// </summary>
		// Token: 0x0600B70F RID: 46863 RVA: 0x00101A8F File Offset: 0x000FFC8F
		public virtual void SetLabelVisibility(int _arg)
		{
			vtkPieChartActor.vtkPieChartActor_SetLabelVisibility_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B710 RID: 46864
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_SetLegendVisibility_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/Disable the creation of a legend. If on, the legend labels will
		/// be created automatically unless the per plot legend symbol has been
		/// set.
		/// </summary>
		// Token: 0x0600B711 RID: 46865 RVA: 0x00101A9F File Offset: 0x000FFC9F
		public virtual void SetLegendVisibility(int _arg)
		{
			vtkPieChartActor.vtkPieChartActor_SetLegendVisibility_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B712 RID: 46866
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_SetPieceColor_32(HandleRef pThis, int i, double r, double g, double b);

		/// <summary>
		/// Specify colors for each piece of pie. If not specified, they are
		/// automatically generated.
		/// </summary>
		// Token: 0x0600B713 RID: 46867 RVA: 0x00101AAF File Offset: 0x000FFCAF
		public void SetPieceColor(int i, double r, double g, double b)
		{
			vtkPieChartActor.vtkPieChartActor_SetPieceColor_32(base.GetCppThis(), i, r, g, b);
		}

		// Token: 0x0600B714 RID: 46868
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_SetPieceColor_33(HandleRef pThis, int i, IntPtr color);

		/// <summary>
		/// Specify colors for each piece of pie. If not specified, they are
		/// automatically generated.
		/// </summary>
		// Token: 0x0600B715 RID: 46869 RVA: 0x00101AC3 File Offset: 0x000FFCC3
		public void SetPieceColor(int i, IntPtr color)
		{
			vtkPieChartActor.vtkPieChartActor_SetPieceColor_33(base.GetCppThis(), i, color);
		}

		// Token: 0x0600B716 RID: 46870
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_SetPieceLabel_34(HandleRef pThis, int i, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1);

		/// <summary>
		/// Specify the names for each piece of pie.  not specified, then an integer
		/// number is automatically generated.
		/// </summary>
		// Token: 0x0600B717 RID: 46871 RVA: 0x00101AD4 File Offset: 0x000FFCD4
		public void SetPieceLabel(int i, string arg1)
		{
			vtkPieChartActor.vtkPieChartActor_SetPieceLabel_34(base.GetCppThis(), i, arg1);
		}

		// Token: 0x0600B718 RID: 46872
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_SetTitle_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the title of the pie chart.
		/// </summary>
		// Token: 0x0600B719 RID: 46873 RVA: 0x00101AE5 File Offset: 0x000FFCE5
		public virtual void SetTitle(string _arg)
		{
			vtkPieChartActor.vtkPieChartActor_SetTitle_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B71A RID: 46874
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_SetTitleTextProperty_36(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the title text property. The property controls the
		/// appearance of the plot title.
		/// </summary>
		// Token: 0x0600B71B RID: 46875 RVA: 0x00101AF8 File Offset: 0x000FFCF8
		public virtual void SetTitleTextProperty(vtkTextProperty p)
		{
			vtkPieChartActor.vtkPieChartActor_SetTitleTextProperty_36(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B71C RID: 46876
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_SetTitleVisibility_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/Disable the display of a plot title.
		/// </summary>
		// Token: 0x0600B71D RID: 46877 RVA: 0x00101B27 File Offset: 0x000FFD27
		public virtual void SetTitleVisibility(int _arg)
		{
			vtkPieChartActor.vtkPieChartActor_SetTitleVisibility_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B71E RID: 46878
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_TitleVisibilityOff_38(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the display of a plot title.
		/// </summary>
		// Token: 0x0600B71F RID: 46879 RVA: 0x00101B37 File Offset: 0x000FFD37
		public virtual void TitleVisibilityOff()
		{
			vtkPieChartActor.vtkPieChartActor_TitleVisibilityOff_38(base.GetCppThis());
		}

		// Token: 0x0600B720 RID: 46880
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieChartActor_TitleVisibilityOn_39(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the display of a plot title.
		/// </summary>
		// Token: 0x0600B721 RID: 46881 RVA: 0x00101B46 File Offset: 0x000FFD46
		public virtual void TitleVisibilityOn()
		{
			vtkPieChartActor.vtkPieChartActor_TitleVisibilityOn_39(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DFF RID: 3583
		public new const string MRFullTypeName = "Kitware.VTK.vtkPieChartActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E00 RID: 3584
		public new static readonly string MRClassNameKey = "class vtkPieChartActor";
	}
}
